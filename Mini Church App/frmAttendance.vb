Imports System.Data.SqlClient
Public Class frmAttendance
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    'Database entry stuff
    Dim attendanceTableAdapter As MinChurchDbDataSetTableAdapters.AttendanceTableAdapter = New MinChurchDbDataSetTableAdapters.AttendanceTableAdapter
    Dim attendanceDataset As MinChurchDbDataSet = New MinChurchDbDataSet()
    'Variable for storing member details collected
    Dim attendanceRow As MinChurchDbDataSet.AttendanceRow

    'To clear all text fields
    Public Sub clearTextFields()
        txtMemID.Clear()
        txtMemName.Clear()
        txtSearchMem.Clear()
        txtTemperature.Clear()
    End Sub


    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enables Arrival Time Timer
        ArrivalTimer.Enabled = True
        dtpMeetDate.Value = Date.Now.ToShortDateString


        'Handles auto complete for search box
        Try
            'OPENING THE CONNECTION
            sqlConn.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With sqlCMD
                .Connection = sqlConn
                .CommandText = "SELECT firstName + otherName + lastName as Search FROM Member where firstName like('" & txtSearchMem.Text & "%') or lastName like('" & txtSearchMem.Text & "%') or otherName like('" & txtSearchMem.Text & "%')"
            End With
            'FILLING THE DATA IN THE DATATABLE
            sqlDA.SelectCommand = sqlCMD
            sqlDA.Fill(dataT)
            'SET A VARIABLE AS A ROW OF DATA IN THE DATATABLE
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtSearchMem.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dataT.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtSearchMem.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            MsgBox("No data found on person!")
            sqlConn.Close()
            sqlDA.Dispose()
        End Try
        'CLOSING THE CONNECTION
        sqlConn.Close()
        sqlDA.Dispose()
    End Sub

    Private Sub btnSearchMemNameAtt_Click(sender As Object, e As EventArgs) Handles btnSearchMemNameAtt.Click
        'Handles automatic input of details
        Try
            sqlCMD.Connection = sqlConn
            sqlCMD.CommandText = "SELECT memberID, fullName FROM Details WHERE fullName='" & txtSearchMem.Text & "'"
            sqlCMD.CommandType = CommandType.Text


            sqlConn.Open()
            Using sdr As SqlDataReader = sqlCMD.ExecuteReader()
                sdr.Read()

                txtMemID.Text = sdr("memberID").ToString()
                txtMemName.Text = sdr("fullName").ToString()

            End Using
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlConn.Close()
        End Try
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click

        attendanceRow = attendanceDataset.Attendance.NewRow

        'Fill rows in the member table of the database
        attendanceRow.memberID = txtMemID.Text
        attendanceRow.temperature = txtTemperature.Text
        attendanceRow.signaturee = rbSign.Text
        attendanceRow.arrivalTime = lbArrivalTime.Text
        attendanceRow.datee = dtpMeetDate.Value.Date

        Try
            'Saving the details into the database
            attendanceDataset.Attendance.AddAttendanceRow(attendanceRow)
            attendanceTableAdapter.Update(attendanceDataset.Attendance)

            Dim markOption = MessageBox.Show("Attendance recorded successfully! Do you want to mark another? ", "Check in Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If markOption = DialogResult.Yes Then
                Me.Show()
                clearTextFields()
            Else
                frmMainMenu.Show()
                clearTextFields()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error in taking the attendance. Please check for the following: 1. Duplicate checkin 2. Meeing Date not scheduled", "Saving Error")

        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmMainMenu.Show()
            clearTextFields()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub sysTime_Tick(sender As Object, e As EventArgs) Handles ArrivalTimer.Tick
        'Sets Arrival Time to current system time
        lbArrivalTime.Text = Date.Now.ToShortTimeString
    End Sub

End Class
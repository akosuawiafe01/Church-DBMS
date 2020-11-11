Imports System.Data.SqlClient
Public Class frmSchedMeet
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    'Database entry stuff
    Dim meetingTableAdapter As MinChurchDbDataSetTableAdapters.MeetingTableAdapter = New MinChurchDbDataSetTableAdapters.MeetingTableAdapter
    Dim meetingDataset As MinChurchDbDataSet = New MinChurchDbDataSet()
    'Variable for storing member details collected
    Dim meetingRow As MinChurchDbDataSet.MeetingRow


    Public Sub clearTextFields()
        'To clear all text fields
        txtLirtMeet.Clear()
        txtMeetTitle.Clear()
        txtResPerson.Clear()
        dtpMeetDate.Refresh()

    End Sub
    Private Sub btnCancelMeet_Click(sender As Object, e As EventArgs) Handles btnCancelMeet.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmMainMenu.Show()
            clearTextFields()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnScheMeet_Click(sender As Object, e As EventArgs) Handles btnScheMeet.Click
        meetingRow = meetingDataset.Meeting.NewRow

        'Fill rows in the member table of the database
        meetingRow.title = txtMeetTitle.Text
        meetingRow.resourcePerson = txtResPerson.Text
        meetingRow.liturgist = txtLirtMeet.Text
        meetingRow.datee = dtpMeetDate.Value.Date

        Try
            'Saving the details into the database
            meetingDataset.Meeting.AddMeetingRow(meetingRow)
            meetingTableAdapter.Update(meetingDataset.Meeting)

            Dim markOption = MessageBox.Show("Event recorded successfully! Do you want to add another event? ", "Check in Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If markOption = DialogResult.Yes Then
                Me.Show()
                clearTextFields()
            Else
                frmMainMenu.Show()
                clearTextFields()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("This attendance has been already recorded", "Duplicate check in!")
        End Try

    End Sub

    Private Sub frmSchedMeet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpMeetDate.Value = Date.Now.ToShortDateString
    End Sub

End Class
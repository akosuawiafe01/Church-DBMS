Imports System.Data.SqlClient

Public Class frmMemberRegistration
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    'Database entry stuff
    Dim memberTableAdapter As MinChurchDbDataSetTableAdapters.MemberTableAdapter = New MinChurchDbDataSetTableAdapters.MemberTableAdapter
    Dim memberDataset As MinChurchDbDataSet = New MinChurchDbDataSet()
    'Variable for storing member details collected
    Dim memberRow As MinChurchDbDataSet.MemberRow

    'Random Number generator stuff
    Dim memberID As Integer = 3

    Public Sub clearTextFields()
        'Clears all input fields
        txtMemID.Clear()
        txtAltCon.Clear()
        txtEmergencyConRel.Clear()
        txtContact.Clear()
        txtDigAddr.Clear()
        txtEmail.Clear()
        txtEmerCon.Clear()
        txtFN.Clear()
        txtLN.Clear()
        txtOccupation.Clear()
        txtON.Clear()
        txtResLoc.Clear()
        cmbGender.Refresh()
        cmbMarStats.Refresh()
        cmbTitle.Refresh()
        dtpDOB.Refresh()
    End Sub

    Private Sub btnCanMemReg_Click(sender As Object, e As EventArgs) Handles btnCanMemReg.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmMainMenu.Show()
            clearTextFields()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnRegMeme_Click(sender As Object, e As EventArgs) Handles btnRegMeme.Click
        memberRow = memberDataset.Member.NewRow

        'Fill rows in the member table of the database
        memberRow.memberID = txtMemID.Text
        memberRow.firstName = txtFN.Text
        memberRow.otherName = txtON.Text
        memberRow.lastName = txtLN.Text
        memberRow.alternateContact = txtAltCon.Text
        memberRow.contact = txtContact.Text
        memberRow.emergencyContact = txtEmerCon.Text
        memberRow.emergencyContactRel = txtEmergencyConRel.Text
        memberRow.digitalAddress = txtDigAddr.Text
        memberRow.email = txtEmail.Text
        memberRow.occupation = txtOccupation.Text
        memberRow.residenceLocation = txtResLoc.Text
        memberRow.gender = cmbGender.SelectedItem
        memberRow.title = cmbTitle.SelectedItem
        memberRow.maritalStatus = cmbMarStats.SelectedItem
        memberRow.dob = dtpDOB.Value.Date
        memberRow.registrationDate = dtpRegDate.Value.Date

        Try
            'Saving the details into the database
            memberDataset.Member.AddMemberRow(memberRow)
            memberTableAdapter.Update(memberDataset.Member)


            Dim payOption = MessageBox.Show("" & txtFN.Text & " has been registered successfully. Do you want to add another record? ", "Registration Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If payOption = DialogResult.Yes Then
                Me.Show()
                clearTextFields()
                txtMemID.Text = "GC-YPG/" + randomNumber(memberID)
            Else
                frmMainMenu.Show()
                clearTextFields()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub frmMemberRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMemID.Text = "GC-YPG/" + randomNumber(memberID)
        dtpRegDate.Value = Date.Now.ToShortDateString
        'Handles auto complete for search box
        Try
            'OPENING THE CONNECTION
            sqlConn.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With sqlCMD
                .Connection = sqlConn
                .CommandText = "SELECT firstName + otherName + lastName FROM Member where firstName like('" & txtSearchReg.Text & "%') or lastName like('" & txtSearchReg.Text & "%') or otherName like('" & txtSearchReg.Text & "%')"
            End With
            'FILLING THE DATA IN THE DATATABLE
            sqlDA.SelectCommand = sqlCMD
            sqlDA.Fill(dataT)
            'SET A VARIABLE AS A ROW OF DATA IN THE DATATABLE
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtSearchReg.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dataT.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtSearchReg.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlConn.Close()
            sqlDA.Dispose()
        End Try
        'CLOSING THE CONNECTION
        sqlConn.Close()
        sqlDA.Dispose()

    End Sub

    Private Sub btnSearchReg_Click(sender As Object, e As EventArgs) Handles btnSearchReg.Click

        'Handles automatic input of details
        Try
            sqlCMD.Connection = sqlConn
            sqlCMD.CommandText = "SELECT * FROM Details WHERE fullName='" & txtSearchReg.Text & "'"
            sqlCMD.CommandType = CommandType.Text


            sqlConn.Open()
            Using sdr As SqlDataReader = sqlCMD.ExecuteReader()
                sdr.Read()

                txtMemID.Text = sdr("memberID").ToString()
                txtFN.Text = sdr("firstName").ToString()
                txtON.Text = sdr("lastName").ToString
                txtLN.Text = sdr("otherName").ToString()
                txtAltCon.Text = sdr("alternateContact").ToString()
                txtContact.Text = sdr("contact").ToString()
                txtEmergencyConRel.Text = sdr("emergencyContactRel").ToString()
                txtEmerCon.Text = sdr("emergencyContact").ToString()
                txtDigAddr.Text = sdr("digitalAddress").ToString()
                txtEmail.Text = sdr("email").ToString()
                txtOccupation.Text = sdr("occupation").ToString()
                txtResLoc.Text = sdr("residenceLocation").ToString()
                cmbGender.SelectedItem = sdr("gender").ToString()
                cmbTitle.SelectedItem = sdr("title").ToString()
                cmbMarStats.SelectedItem = sdr("maritalStatus").ToString()
                dtpDOB.Value = sdr("dob").ToString()
                dtpRegDate.Value = sdr("registrationDate").ToString()
            End Using
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlConn.Close()
        End Try
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchReg.Clear()
        clearTextFields()
    End Sub
End Class
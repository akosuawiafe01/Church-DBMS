Imports System.Data.SqlClient
Imports System.IO
Public Class frmMemberRegistration
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable
    Public sdr As SqlDataReader

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
        Dim ms As New MemoryStream()
        Try
            sqlConn.Open()
            sqlCMD = New SqlCommand("Insert into Member values(@memberID, @title, @firstName, @lastName, @otherName, @email, @dob, @residenceLocation, @alternateContact, @gender, @occupation, @maritalStatus, @registrationDate, @emergencyContact, @emergencyContactRel, @digitalAddress, @contact, @picture)", sqlConn)

            'Saving the details into the database
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("memberID", txtMemID.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("title", cmbTitle.SelectedItem))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("firstName", txtFN.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("lastName", txtLN.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("otherName", txtON.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("email", txtEmail.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("dob", dtpDOB.Value.Date))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("residenceLocation", txtAltCon.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("alternateContact", txtAltCon.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("gender", cmbGender.SelectedItem.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("occupation", txtOccupation.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("maritalStatus", cmbMarStats.SelectedItem))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("registrationDate", dtpRegDate.Value.Date))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("emergencyContact", txtEmerCon.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("emergencyContactRel", txtEmergencyConRel.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("digitalAddress", txtDigAddr.Text.Trim()))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("contact", txtContact.Text.Trim()))

            'Deals with saving image into database
            pbProfilePic.BackgroundImage.Save(ms, pbProfilePic.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim profilePicture As New SqlParameter("@picture", SqlDbType.Image)
            profilePicture.Value = data
            sqlCMD.Parameters.Add(profilePicture)
            sqlCMD.ExecuteNonQuery()

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
        Finally
            sqlConn.Close()
            Me.Cursor = Cursors.Default
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
        Finally
            'CLOSING THE CONNECTION
            sqlConn.Close()
            sqlDA.Dispose()
        End Try

    End Sub

    Private Sub btnSearchReg_Click(sender As Object, e As EventArgs) Handles btnSearchReg.Click

        'Handles automatic input of details
        Try
            sqlCMD.Connection = sqlConn
            sqlCMD.CommandText = "SELECT * FROM Details WHERE fullName='" & txtSearchReg.Text & "'"
            sqlCMD.CommandType = CommandType.Text

            sqlConn.Open()
            sdr = sqlCMD.ExecuteReader()
            Using sdr
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

            sdr = sqlCMD.ExecuteReader()
            If sdr.Read = True Then

                Dim imageData As Byte() = sdr(17)
                If Not imageData Is Nothing Then

                    Using ms As New MemoryStream(imageData, 0, imageData.Length)

                        ms.Write(imageData, 0, imageData.Length)

                        pbProfilePic.Image = Image.FromStream(ms, True)

                        Me.Cursor = Cursors.Default
                    End Using
                End If
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            sqlConn.Close()
        End Try



    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchReg.Clear()
        pbProfilePic.Image = Nothing
        clearTextFields()
        txtMemID.Text = "GC-YPG/" + randomNumber(memberID)
    End Sub

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim open As OpenFileDialog
            open = New OpenFileDialog
            open.FileName = ""
            open.Filter = "Image Formats(*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif)|*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif|JPEG Format(*.jpg;*.jpeg)|*.jpg;*.jpeg|BITMAP Format(*.bmp)|*.bmp|GIF Format(*.gif)|*.gif|PNG Format(*.png)|*.png"
            If open.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbProfilePic.BackgroundImageLayout = ImageLayout.Stretch
                pbProfilePic.BackgroundImage = Image.FromFile(open.FileName.ToUpper)

            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


End Class
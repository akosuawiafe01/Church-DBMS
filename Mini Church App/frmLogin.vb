Imports System.Data.SqlClient
Public Class frmLogin
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    Public Sub clearTextFields()
        txtUsername.Clear()
        txtPassword.Clear()
        cbViewPass.Checked = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Handles user logins
        ' Try
        ' sqlCMD.Connection = sqlConn
        'sqlCMD.CommandText = "SELECT username, password FROM System_Access WHERE username ='" & txtUsername.Text & "' AND password ='" & txtPassword.Text & "'"
        ' sqlCMD.CommandType = CommandType.Text


        'sqlConn.Open()
        'Using sdr As SqlDataReader = sqlCMD.ExecuteReader()
        'Dim dataRead As String = sdr.Read()

        'If (dataRead = True) Then
        Me.Hide()
            frmMainMenu.Show()
            '        clearTextFields()
        'lbLoginUnsucc.Visible = False

        'Else
        'lbLoginUnsucc.Visible = True
        'lbLoginUnsucc.Text = "Login Unsuccessful 😕, Try again!"
        'Me.Show()

        'End If

        'End Using
        'sqlConn.Close()

        'Catch ex As Exception
        '   MessageBox.Show(ex.Message)
        '  sqlConn.Close()
        'End Try
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbViewPass.CheckedChanged
        If cbViewPass.Checked Then
            txtPassword.PasswordChar = Nothing
            txtPassword.Focus()
        Else
            txtPassword.PasswordChar = "*"
            txtPassword.Focus()
        End If
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub
End Class

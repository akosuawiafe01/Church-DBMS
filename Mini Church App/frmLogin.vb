Public Class frmLogin
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles lbLogin.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMainMenu.Show()
        Me.Hide()

    End Sub
End Class

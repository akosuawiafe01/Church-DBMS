Public Class frmMainMenu
    Dim quoteIndex As Integer = 1

    Public Sub clearLoginFields()
        frmLogin.txtUsername.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.cbViewPass.Checked = False
        frmLogin.lbLoginUnsucc.Visible = False
    End Sub
    Private Sub ScheduleMeetingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleMeetingToolStripMenuItem.Click
        frmSchedMeet.Show()
        Me.Hide()
    End Sub

    Private Sub DuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuesToolStripMenuItem.Click
        frmDues.Show()
        Me.Hide()
    End Sub

    Private Sub MarkAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAttendanceToolStripMenuItem.Click
        frmAttendance.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        frmMemberRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logoutOption = MessageBox.Show("Do you want to exit this app?", "YPG Database System <--> Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        clearLoginFields()
        If logoutOption = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        Else
            Me.Show()
        End If

    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim quotes(10) As String
        'ReDim Preserve quotes(100)
        quotes = {"God loves you!", "Don't give up!", "Sleep is for the week", "No pain, No gain", "God is the greatest", "Faith, Hope and Love", "Pass7", "Index8", "Index9", "Index10"}
        Dim indexforQuotes As Integer = randomNumber(quoteIndex)
        lbQuotes.Text = quotes(indexforQuotes)
    End Sub

    Private Sub DuesRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuesRecordsToolStripMenuItem.Click
        rptDuesRecords.Show()
        Me.Close()
    End Sub

    Private Sub DueYAFMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DueYAFMembersToolStripMenuItem.Click
        rptDueYAF.Show()
        Me.Close()
    End Sub

    Private Sub MeetingCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeetingCountToolStripMenuItem.Click
        rptMeetingHeadCount.Show()
        Me.Close()
    End Sub

    Private Sub AllRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllRecordsToolStripMenuItem.Click
        rptDuesRecords.Show()
        Me.Close()
    End Sub
End Class
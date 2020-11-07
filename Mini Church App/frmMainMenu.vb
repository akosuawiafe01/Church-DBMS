Public Class frmMainMenu
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
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
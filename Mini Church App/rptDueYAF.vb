Public Class rptDueYAF


    Private Sub rptDueYAF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.DueYAFMembers' table. You can move, or remove it, as needed.
        Me.DueYAFMembersTableAdapter.Fill(Me.MinChurchDbDataSet.DueYAFMembers)

    End Sub

    Private Sub btnBackMain_Click(sender As Object, e As EventArgs) Handles btnBackMain.Click
        Dim backOption = MessageBox.Show("Do you want to go back to the main menu?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If backOption = DialogResult.Yes Then
            frmMainMenu.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class
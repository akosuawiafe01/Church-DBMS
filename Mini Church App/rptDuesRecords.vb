Public Class rptDuesRecords
    Private Sub rptDuesRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.AllPaidDues' table. You can move, or remove it, as needed.
        Me.AllPaidDuesTableAdapter.Fill(Me.MinChurchDbDataSet.AllPaidDues)
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.AllPaidDues' table. You can move, or remove it, as needed.
        Me.AllPaidDuesTableAdapter.Fill(Me.MinChurchDbDataSet.AllPaidDues)
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.AllPaidDues' table. You can move, or remove it, as needed.
        Me.AllPaidDuesTableAdapter.Fill(Me.MinChurchDbDataSet.AllPaidDues)
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.AllPaidDues' table. You can move, or remove it, as needed.
        Me.AllPaidDuesTableAdapter.Fill(Me.MinChurchDbDataSet.AllPaidDues)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim backOption = MessageBox.Show("Do you want to go back to the main menu?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If backOption = DialogResult.Yes Then
            frmMainMenu.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class
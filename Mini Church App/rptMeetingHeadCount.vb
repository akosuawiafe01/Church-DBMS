Imports System.Data.SqlClient

Public Class rptMeetingHeadCount
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim backOption = MessageBox.Show("Do you want to go back to the main menu?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If backOption = DialogResult.Yes Then
            frmMainMenu.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub rptMeetingHeadCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MinChurchDbDataSet.MeetingHeadCount' table. You can move, or remove it, as needed.
        Me.MeetingHeadCountTableAdapter.Fill(Me.MinChurchDbDataSet.MeetingHeadCount)

    End Sub

End Class
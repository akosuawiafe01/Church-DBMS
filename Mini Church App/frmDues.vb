Imports System.Data.SqlClient

Public Class frmDues
    'SQL connection stuff
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable

    'Database entry stuff
    Dim duesTableAdapter As MinChurchDbDataSetTableAdapters.DuesTableAdapter = New MinChurchDbDataSetTableAdapters.DuesTableAdapter
    Dim duesDataset As MinChurchDbDataSet = New MinChurchDbDataSet()
    'Variable for storing member details collected
    Dim duesRow As MinChurchDbDataSet.DuesRow

    'Random Number generator stuff
    Dim receiptNum As Integer = 10

    Public Sub clearTextFields()
        'Clears all input fields
        txtMemID.Clear()
        txtMemName.Clear()
        txtPayAmount.Clear()
        txtRecepNo.Clear()
        txtSearchMemNameDues.Clear()
        cmbPayMonth.Refresh()
        cmbPayYear.Refresh()

    End Sub


    Private Sub btnCancelPay_Click(sender As Object, e As EventArgs) Handles btnCancelPay.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If cancelOption = DialogResult.Yes Then
            frmMainMenu.Show()
            clearTextFields()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnPayDues_Click(sender As Object, e As EventArgs) Handles btnPayDues.Click

        duesRow = duesDataset.Dues.NewRow

        'Fill rows in the member table of the database
        duesRow.memberID = txtMemID.Text
        duesRow.receiptNo = txtRecepNo.Text
        duesRow.Amount = txtPayAmount.Text
        duesRow.paydate = dtpPayDate.Value.Date
        duesRow.Month = cmbPayMonth.SelectedItem
        duesRow.Year = cmbPayYear.SelectedItem

        Try
            'Saving the details into the database
            duesDataset.Dues.AddDuesRow(duesRow)
            duesTableAdapter.Update(duesDataset.Dues)


            Dim payOption = MessageBox.Show("Payment made successfully. Do you want to make another payment? ", "Payment Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If payOption = DialogResult.Yes Then
                Me.Show()
                clearTextFields()
                txtRecepNo.Text = randomNumber(receiptNum)
            Else
                frmMainMenu.Show()
                clearTextFields()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmDues_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpPayDate.Value = Date.Now.ToShortDateString

        'Handles auto complete for search box
        Try
            'OPENING THE CONNECTION
            sqlConn.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With sqlCMD
                .Connection = sqlConn
                .CommandText = "SELECT firstName + otherName + lastName as Search FROM Member where firstName like('" & txtSearchMemNameDues.Text & "%') or lastName like('" & txtSearchMemNameDues.Text & "%') or otherName like('" & txtSearchMemNameDues.Text & "%')"
            End With
            'FILLING THE DATA IN THE DATATABLE
            sqlDA.SelectCommand = sqlCMD
            sqlDA.Fill(dataT)
            'SET A VARIABLE AS A ROW OF DATA IN THE DATATABLE
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtSearchMemNameDues.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dataT.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtSearchMemNameDues.AutoCompleteCustomSource.Add(r.Item(0).ToString)
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

    Private Sub btnSearchMem_Click(sender As Object, e As EventArgs) Handles btnSearchMem.Click
        'Handles automatic input of details
        Try
            sqlCMD.Connection = sqlConn
            sqlCMD.CommandText = "SELECT memberID, fullName FROM Details WHERE fullName='" & txtSearchMemNameDues.Text & "'"
            sqlCMD.CommandType = CommandType.Text


            sqlConn.Open()
            Using sdr As SqlDataReader = sqlCMD.ExecuteReader()
                sdr.Read()

                txtMemID.Text = sdr("memberID").ToString()
                txtMemName.Text = sdr("fullName").ToString()

            End Using
            sqlConn.Close()

            txtRecepNo.Text = randomNumber(receiptNum)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sqlConn.Close()
        End Try
    End Sub

End Class
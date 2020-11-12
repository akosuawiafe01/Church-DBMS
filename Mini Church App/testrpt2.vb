Imports System
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class testrpt2
    Public connStr As String = "Data Source=.;Initial Catalog=MinChurchDb;Integrated Security=True"
    Public sqlConn As New SqlConnection(connStr)
    Public sqlCMD As New SqlCommand
    Public sqlDA As New SqlDataAdapter
    Public dataT As New DataTable
    Public reader As SqlDataReader

    'use  get application running path
    Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))

    Private Sub testrpt2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        ReportViewer1.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim open As OpenFileDialog
            open = New OpenFileDialog
            open.FileName = ""
            open.Filter = "Image Formats(*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif)|*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif|JPEG Format(*.jpg;*.jpeg)|*.jpg;*.jpeg|BITMAP Format(*.bmp)|*.bmp|GIF Format(*.gif)|*.gif|PNG Format(*.png)|*.png"
            If open.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
                PictureBox1.BackgroundImage = Image.FromFile(open.FileName.ToUpper)
                name.Text = open.SafeFileName.ToString 'Get as image name
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim ms As New MemoryStream()

            'save record in database
            sqlConn.Open()
            sqlCMD = New SqlCommand("Insert into Images values(@name,@img, @id)", sqlConn)
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("name", name.Text))
            sqlCMD.Parameters.Add(New SqlClient.SqlParameter("id", id.Text))
            PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim img As New SqlParameter("@img", SqlDbType.Image)
            img.Value = data
            sqlCMD.Parameters.Add(img)
            sqlCMD.ExecuteNonQuery()
            MessageBox.Show("Image saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            name.Text = Nothing
            PictureBox1.BackgroundImage = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            sqlConn.Close()
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSearc_Click(sender As Object, e As EventArgs) Handles btnSearc.Click

        Try
            'search image name if existing
            sqlConn.Open()
            sqlCMD = New SqlCommand("Select * from Member where memberID='" & id.Text & "'", sqlConn)
            reader = sqlCMD.ExecuteReader()
            If reader.Read = False Then
                MessageBox.Show("Photo name: " & name.Text.ToUpper & " does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                name.Text = reader(0).ToString

                'store image value from the database in byte
                Dim imageData As Byte() = reader(17)
                If Not imageData Is Nothing Then

                    Using ms As New MemoryStream(imageData, 0, imageData.Length)

                        ms.Write(imageData, 0, imageData.Length)

                        PictureBox1.BackgroundImage = Image.FromStream(ms)

                    End Using
                End If
                Me.Cursor = Cursors.Default
            End If
            Me.Cursor = Cursors.Default

        Catch mem As OutOfMemoryException
            MessageBox.Show(mem.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            Me.Cursor = Cursors.Default
            sqlConn.Close()
        End Try


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "YPG Database System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmMainMenu.Show()
            'clearTextFields()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class



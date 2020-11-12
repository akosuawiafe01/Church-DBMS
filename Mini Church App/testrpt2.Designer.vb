<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testrpt2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.name = New System.Windows.Forms.TextBox()
        Me.btnSearc = New Guna.UI2.WinForms.Guna2Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.BackColor = System.Drawing.Color.Black
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(352, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.CheckedState.Parent = Me.btnBrowse
        Me.btnBrowse.CustomImages.Parent = Me.btnBrowse
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.HoverState.Parent = Me.btnBrowse
        Me.btnBrowse.Location = New System.Drawing.Point(210, 324)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.ShadowDecoration.Parent = Me.btnBrowse
        Me.btnBrowse.Size = New System.Drawing.Size(189, 36)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        '
        'btnSave
        '
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(515, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(190, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'name
        '
        Me.name.Location = New System.Drawing.Point(26, 117)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(204, 20)
        Me.name.TabIndex = 3
        '
        'btnSearc
        '
        Me.btnSearc.CheckedState.Parent = Me.btnSearc
        Me.btnSearc.CustomImages.Parent = Me.btnSearc
        Me.btnSearc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearc.ForeColor = System.Drawing.Color.White
        Me.btnSearc.HoverState.Parent = Me.btnSearc
        Me.btnSearc.Location = New System.Drawing.Point(128, 211)
        Me.btnSearc.Name = "btnSearc"
        Me.btnSearc.ShadowDecoration.Parent = Me.btnSearc
        Me.btnSearc.Size = New System.Drawing.Size(91, 39)
        Me.btnSearc.TabIndex = 4
        Me.btnSearc.Text = "Search"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(40, 88)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(190, 20)
        Me.id.TabIndex = 5
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(712, 97)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(51, 50)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "back"
        '
        'testrpt2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.btnSearc)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        'Me.name = "testrpt2"
        Me.Text = "testrpt2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents name As TextBox
    Friend WithEvents btnSearc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents id As TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class

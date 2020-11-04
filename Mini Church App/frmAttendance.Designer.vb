<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtSearchMem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gpDets = New System.Windows.Forms.GroupBox()
        Me.txtMemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMemID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckSign = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTemperature = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMark = New Guna.UI2.WinForms.Guna2Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gpDets.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(1262, 60)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Attendance Section"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtSearchMem
        '
        Me.txtSearchMem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchMem.DefaultText = ""
        Me.txtSearchMem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchMem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchMem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMem.DisabledState.Parent = Me.txtSearchMem
        Me.txtSearchMem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMem.FocusedState.Parent = Me.txtSearchMem
        Me.txtSearchMem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMem.HoverState.Parent = Me.txtSearchMem
        Me.txtSearchMem.Location = New System.Drawing.Point(933, 94)
        Me.txtSearchMem.Name = "txtSearchMem"
        Me.txtSearchMem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchMem.PlaceholderText = "Search for member"
        Me.txtSearchMem.SelectedText = ""
        Me.txtSearchMem.ShadowDecoration.Parent = Me.txtSearchMem
        Me.txtSearchMem.Size = New System.Drawing.Size(341, 41)
        Me.txtSearchMem.TabIndex = 1
        '
        'gpDets
        '
        Me.gpDets.Controls.Add(Me.txtMemName)
        Me.gpDets.Controls.Add(Me.txtMemID)
        Me.gpDets.Controls.Add(Me.Label2)
        Me.gpDets.Controls.Add(Me.Label1)
        Me.gpDets.Location = New System.Drawing.Point(15, 145)
        Me.gpDets.Name = "gpDets"
        Me.gpDets.Size = New System.Drawing.Size(1259, 151)
        Me.gpDets.TabIndex = 2
        Me.gpDets.TabStop = False
        Me.gpDets.Text = "Details"
        '
        'txtMemName
        '
        Me.txtMemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemName.DefaultText = ""
        Me.txtMemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemName.DisabledState.Parent = Me.txtMemName
        Me.txtMemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemName.FocusedState.Parent = Me.txtMemName
        Me.txtMemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemName.HoverState.Parent = Me.txtMemName
        Me.txtMemName.Location = New System.Drawing.Point(152, 78)
        Me.txtMemName.Name = "txtMemName"
        Me.txtMemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemName.PlaceholderText = "Name"
        Me.txtMemName.SelectedText = ""
        Me.txtMemName.ShadowDecoration.Parent = Me.txtMemName
        Me.txtMemName.Size = New System.Drawing.Size(387, 33)
        Me.txtMemName.TabIndex = 3
        '
        'txtMemID
        '
        Me.txtMemID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemID.DefaultText = ""
        Me.txtMemID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMemID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMemID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemID.DisabledState.Parent = Me.txtMemID
        Me.txtMemID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemID.FocusedState.Parent = Me.txtMemID
        Me.txtMemID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemID.HoverState.Parent = Me.txtMemID
        Me.txtMemID.Location = New System.Drawing.Point(152, 35)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemID.PlaceholderText = "Member ID"
        Me.txtMemID.SelectedText = ""
        Me.txtMemID.ShadowDecoration.Parent = Me.txtMemID
        Me.txtMemID.Size = New System.Drawing.Size(216, 33)
        Me.txtMemID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.ckSign)
        Me.GroupBox2.Controls.Add(Me.txtTime)
        Me.GroupBox2.Controls.Add(Me.txtTemperature)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1259, 167)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mark Attendance"
        '
        'ckSign
        '
        Me.ckSign.AutoSize = True
        Me.ckSign.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckSign.CheckedState.BorderRadius = 2
        Me.ckSign.CheckedState.BorderThickness = 0
        Me.ckSign.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ckSign.Location = New System.Drawing.Point(661, 110)
        Me.ckSign.Name = "ckSign"
        Me.ckSign.Size = New System.Drawing.Size(71, 17)
        Me.ckSign.TabIndex = 2
        Me.ckSign.Text = "Signature"
        Me.ckSign.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ckSign.UncheckedState.BorderRadius = 2
        Me.ckSign.UncheckedState.BorderThickness = 0
        Me.ckSign.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ckSign.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.DefaultText = ""
        Me.txtTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTime.DisabledState.Parent = Me.txtTime
        Me.txtTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTime.FocusedState.Parent = Me.txtTime
        Me.txtTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTime.HoverState.Parent = Me.txtTime
        Me.txtTime.Location = New System.Drawing.Point(61, 98)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTime.PlaceholderText = "Arrival Time"
        Me.txtTime.SelectedText = ""
        Me.txtTime.ShadowDecoration.Parent = Me.txtTime
        Me.txtTime.Size = New System.Drawing.Size(247, 29)
        Me.txtTime.TabIndex = 1
        '
        'txtTemperature
        '
        Me.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemperature.DefaultText = ""
        Me.txtTemperature.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTemperature.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTemperature.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTemperature.DisabledState.Parent = Me.txtTemperature
        Me.txtTemperature.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTemperature.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTemperature.FocusedState.Parent = Me.txtTemperature
        Me.txtTemperature.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTemperature.HoverState.Parent = Me.txtTemperature
        Me.txtTemperature.Location = New System.Drawing.Point(61, 35)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTemperature.PlaceholderText = "Temperature"
        Me.txtTemperature.SelectedText = ""
        Me.txtTemperature.ShadowDecoration.Parent = Me.txtTemperature
        Me.txtTemperature.Size = New System.Drawing.Size(247, 29)
        Me.txtTemperature.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(1040, 516)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(117, 31)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'btnMark
        '
        Me.btnMark.CheckedState.Parent = Me.btnMark
        Me.btnMark.CustomImages.Parent = Me.btnMark
        Me.btnMark.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMark.ForeColor = System.Drawing.Color.White
        Me.btnMark.HoverState.Parent = Me.btnMark
        Me.btnMark.Location = New System.Drawing.Point(850, 516)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.ShadowDecoration.Parent = Me.btnMark
        Me.btnMark.Size = New System.Drawing.Size(117, 31)
        Me.btnMark.TabIndex = 5
        Me.btnMark.Text = "Mark"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(661, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Meeting Title"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 581)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpDets)
        Me.Controls.Add(Me.txtSearchMem)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpDets.ResumeLayout(False)
        Me.gpDets.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSearchMem As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gpDets As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMemID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTemperature As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ckSign As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMark As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboBox1 As ComboBox
End Class

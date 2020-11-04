<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSchedMeet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtMeetID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMeetTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLirtMeet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtResPerson = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnCancelMeet = New Guna.UI2.WinForms.Guna2Button()
        Me.btnScheMeet = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(1283, 56)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Schedule a Meeting"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtMeetID
        '
        Me.txtMeetID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMeetID.DefaultText = ""
        Me.txtMeetID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMeetID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMeetID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMeetID.DisabledState.Parent = Me.txtMeetID
        Me.txtMeetID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMeetID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMeetID.FocusedState.Parent = Me.txtMeetID
        Me.txtMeetID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMeetID.HoverState.Parent = Me.txtMeetID
        Me.txtMeetID.Location = New System.Drawing.Point(450, 222)
        Me.txtMeetID.Name = "txtMeetID"
        Me.txtMeetID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMeetID.PlaceholderText = "Meeting ID"
        Me.txtMeetID.SelectedText = ""
        Me.txtMeetID.ShadowDecoration.Parent = Me.txtMeetID
        Me.txtMeetID.Size = New System.Drawing.Size(486, 27)
        Me.txtMeetID.TabIndex = 1
        '
        'txtMeetTitle
        '
        Me.txtMeetTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMeetTitle.DefaultText = ""
        Me.txtMeetTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMeetTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMeetTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMeetTitle.DisabledState.Parent = Me.txtMeetTitle
        Me.txtMeetTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMeetTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMeetTitle.FocusedState.Parent = Me.txtMeetTitle
        Me.txtMeetTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMeetTitle.HoverState.Parent = Me.txtMeetTitle
        Me.txtMeetTitle.Location = New System.Drawing.Point(450, 280)
        Me.txtMeetTitle.Name = "txtMeetTitle"
        Me.txtMeetTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMeetTitle.PlaceholderText = "Title"
        Me.txtMeetTitle.SelectedText = ""
        Me.txtMeetTitle.ShadowDecoration.Parent = Me.txtMeetTitle
        Me.txtMeetTitle.Size = New System.Drawing.Size(486, 27)
        Me.txtMeetTitle.TabIndex = 2
        '
        'txtLirtMeet
        '
        Me.txtLirtMeet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLirtMeet.DefaultText = ""
        Me.txtLirtMeet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLirtMeet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLirtMeet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLirtMeet.DisabledState.Parent = Me.txtLirtMeet
        Me.txtLirtMeet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLirtMeet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLirtMeet.FocusedState.Parent = Me.txtLirtMeet
        Me.txtLirtMeet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLirtMeet.HoverState.Parent = Me.txtLirtMeet
        Me.txtLirtMeet.Location = New System.Drawing.Point(450, 343)
        Me.txtLirtMeet.Name = "txtLirtMeet"
        Me.txtLirtMeet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLirtMeet.PlaceholderText = "Liturgist"
        Me.txtLirtMeet.SelectedText = ""
        Me.txtLirtMeet.ShadowDecoration.Parent = Me.txtLirtMeet
        Me.txtLirtMeet.Size = New System.Drawing.Size(486, 27)
        Me.txtLirtMeet.TabIndex = 3
        '
        'txtResPerson
        '
        Me.txtResPerson.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResPerson.DefaultText = ""
        Me.txtResPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtResPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtResPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResPerson.DisabledState.Parent = Me.txtResPerson
        Me.txtResPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResPerson.FocusedState.Parent = Me.txtResPerson
        Me.txtResPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResPerson.HoverState.Parent = Me.txtResPerson
        Me.txtResPerson.Location = New System.Drawing.Point(450, 389)
        Me.txtResPerson.Name = "txtResPerson"
        Me.txtResPerson.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResPerson.PlaceholderText = "Resource Person"
        Me.txtResPerson.SelectedText = ""
        Me.txtResPerson.ShadowDecoration.Parent = Me.txtResPerson
        Me.txtResPerson.Size = New System.Drawing.Size(486, 27)
        Me.txtResPerson.TabIndex = 4
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(450, 454)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(486, 27)
        Me.Guna2DateTimePicker1.TabIndex = 5
        Me.Guna2DateTimePicker1.Value = New Date(2020, 10, 27, 12, 14, 4, 825)
        '
        'btnCancelMeet
        '
        Me.btnCancelMeet.CheckedState.Parent = Me.btnCancelMeet
        Me.btnCancelMeet.CustomImages.Parent = Me.btnCancelMeet
        Me.btnCancelMeet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancelMeet.ForeColor = System.Drawing.Color.White
        Me.btnCancelMeet.HoverState.Parent = Me.btnCancelMeet
        Me.btnCancelMeet.Location = New System.Drawing.Point(856, 514)
        Me.btnCancelMeet.Name = "btnCancelMeet"
        Me.btnCancelMeet.ShadowDecoration.Parent = Me.btnCancelMeet
        Me.btnCancelMeet.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelMeet.TabIndex = 6
        Me.btnCancelMeet.Text = "Cancel"
        '
        'btnScheMeet
        '
        Me.btnScheMeet.CheckedState.Parent = Me.btnScheMeet
        Me.btnScheMeet.CustomImages.Parent = Me.btnScheMeet
        Me.btnScheMeet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnScheMeet.ForeColor = System.Drawing.Color.White
        Me.btnScheMeet.HoverState.Parent = Me.btnScheMeet
        Me.btnScheMeet.Location = New System.Drawing.Point(665, 514)
        Me.btnScheMeet.Name = "btnScheMeet"
        Me.btnScheMeet.ShadowDecoration.Parent = Me.btnScheMeet
        Me.btnScheMeet.Size = New System.Drawing.Size(80, 30)
        Me.btnScheMeet.TabIndex = 7
        Me.btnScheMeet.Text = "Schedule"
        '
        'frmSchedMeet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 590)
        Me.Controls.Add(Me.btnScheMeet)
        Me.Controls.Add(Me.btnCancelMeet)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.txtResPerson)
        Me.Controls.Add(Me.txtLirtMeet)
        Me.Controls.Add(Me.txtMeetTitle)
        Me.Controls.Add(Me.txtMeetID)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "frmSchedMeet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Meeting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtMeetID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMeetTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLirtMeet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtResPerson As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnCancelMeet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnScheMeet As Guna.UI2.WinForms.Guna2Button
End Class

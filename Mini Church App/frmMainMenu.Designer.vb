<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleMeetingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuesRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeetingCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DueYAFMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbQuotes = New System.Windows.Forms.Label()
        Me.tbAbout = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuesToolStripMenuItem, Me.MarkAttendanceToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.ScheduleMeetingToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1315, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DuesToolStripMenuItem
        '
        Me.DuesToolStripMenuItem.Name = "DuesToolStripMenuItem"
        Me.DuesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.DuesToolStripMenuItem.Text = "Dues"
        '
        'MarkAttendanceToolStripMenuItem
        '
        Me.MarkAttendanceToolStripMenuItem.Name = "MarkAttendanceToolStripMenuItem"
        Me.MarkAttendanceToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.MarkAttendanceToolStripMenuItem.Text = "Mark Attendance"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.RegisterToolStripMenuItem.Text = "Register Member"
        '
        'ScheduleMeetingToolStripMenuItem
        '
        Me.ScheduleMeetingToolStripMenuItem.Name = "ScheduleMeetingToolStripMenuItem"
        Me.ScheduleMeetingToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ScheduleMeetingToolStripMenuItem.Text = "Schedule a Meeting"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuesRecordsToolStripMenuItem, Me.MeetingCountToolStripMenuItem, Me.DueYAFMembersToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.ReportsToolStripMenuItem.Text = "Predefined Queries"
        '
        'DuesRecordsToolStripMenuItem
        '
        Me.DuesRecordsToolStripMenuItem.Name = "DuesRecordsToolStripMenuItem"
        Me.DuesRecordsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DuesRecordsToolStripMenuItem.Text = "Dues Records"
        '
        'MeetingCountToolStripMenuItem
        '
        Me.MeetingCountToolStripMenuItem.Name = "MeetingCountToolStripMenuItem"
        Me.MeetingCountToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MeetingCountToolStripMenuItem.Text = "Meeting Head Count"
        '
        'DueYAFMembersToolStripMenuItem
        '
        Me.DueYAFMembersToolStripMenuItem.Name = "DueYAFMembersToolStripMenuItem"
        Me.DueYAFMembersToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DueYAFMembersToolStripMenuItem.Text = "Due YAF members"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'btnLogout
        '
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.White
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(1201, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(102, 22)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1325, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "About Us"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(622, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(677, 460)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbQuotes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1325, 492)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Today's Quotes"
        Me.TabPage3.ToolTipText = "fddf"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbQuotes
        '
        Me.lbQuotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuotes.Location = New System.Drawing.Point(6, 47)
        Me.lbQuotes.Name = "lbQuotes"
        Me.lbQuotes.Size = New System.Drawing.Size(1256, 413)
        Me.lbQuotes.TabIndex = 2
        Me.lbQuotes.Text = "Today'sQuotes"
        Me.lbQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbAbout
        '
        Me.tbAbout.Controls.Add(Me.TabPage3)
        Me.tbAbout.Controls.Add(Me.TabPage1)
        Me.tbAbout.Location = New System.Drawing.Point(0, 27)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.SelectedIndex = 0
        Me.tbAbout.Size = New System.Drawing.Size(1333, 518)
        Me.tbAbout.TabIndex = 2
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tbAbout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.tbAbout.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleMeetingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DuesRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeetingCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DueYAFMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbQuotes As Label
    Friend WithEvents tbAbout As TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
End Class

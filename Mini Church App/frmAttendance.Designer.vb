<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtSearchMem = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gpDets = New System.Windows.Forms.GroupBox()
        Me.txtMemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMemID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTemperature = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMark = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchMemNameAtt = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpArrivalTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbMeetTitle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.MinChurchDbDataSet = New Mini_Church_App.MinChurchDbDataSet()
        Me.MeetingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MeetingTableAdapter = New Mini_Church_App.MinChurchDbDataSetTableAdapters.MeetingTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbSign = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.gpDets.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeetingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtSearchMem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchMem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
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
        Me.txtSearchMem.Location = New System.Drawing.Point(614, 98)
        Me.txtSearchMem.Name = "txtSearchMem"
        Me.txtSearchMem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchMem.PlaceholderText = "Search for member by name"
        Me.txtSearchMem.SelectedText = ""
        Me.txtSearchMem.ShadowDecoration.Parent = Me.txtSearchMem
        Me.txtSearchMem.Size = New System.Drawing.Size(528, 41)
        Me.txtSearchMem.TabIndex = 1
        '
        'gpDets
        '
        Me.gpDets.Controls.Add(Me.txtMemName)
        Me.gpDets.Controls.Add(Me.txtMemID)
        Me.gpDets.Controls.Add(Me.Label2)
        Me.gpDets.Controls.Add(Me.Label1)
        Me.gpDets.Enabled = False
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
        Me.txtMemName.Enabled = False
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
        Me.txtMemName.Size = New System.Drawing.Size(452, 33)
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
        Me.txtMemID.Enabled = False
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
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(41, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbSign)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpArrivalTime)
        Me.GroupBox2.Controls.Add(Me.cmbMeetTitle)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTemperature)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1259, 167)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mark Attendance"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(658, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Meeting Title"
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
        'btnSearchMemNameAtt
        '
        Me.btnSearchMemNameAtt.CheckedState.Parent = Me.btnSearchMemNameAtt
        Me.btnSearchMemNameAtt.CustomImages.Parent = Me.btnSearchMemNameAtt
        Me.btnSearchMemNameAtt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchMemNameAtt.ForeColor = System.Drawing.Color.White
        Me.btnSearchMemNameAtt.HoverState.Parent = Me.btnSearchMemNameAtt
        Me.btnSearchMemNameAtt.Location = New System.Drawing.Point(1165, 98)
        Me.btnSearchMemNameAtt.Name = "btnSearchMemNameAtt"
        Me.btnSearchMemNameAtt.ShadowDecoration.Parent = Me.btnSearchMemNameAtt
        Me.btnSearchMemNameAtt.Size = New System.Drawing.Size(101, 32)
        Me.btnSearchMemNameAtt.TabIndex = 6
        Me.btnSearchMemNameAtt.Text = "Search by name"
        '
        'dtpArrivalTime
        '
        Me.dtpArrivalTime.CheckedState.Parent = Me.dtpArrivalTime
        Me.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpArrivalTime.HoverState.Parent = Me.dtpArrivalTime
        Me.dtpArrivalTime.Location = New System.Drawing.Point(152, 78)
        Me.dtpArrivalTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpArrivalTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpArrivalTime.Name = "dtpArrivalTime"
        Me.dtpArrivalTime.ShadowDecoration.Parent = Me.dtpArrivalTime
        Me.dtpArrivalTime.Size = New System.Drawing.Size(247, 29)
        Me.dtpArrivalTime.TabIndex = 7
        Me.dtpArrivalTime.Value = New Date(2020, 11, 6, 22, 34, 22, 249)
        '
        'cmbMeetTitle
        '
        Me.cmbMeetTitle.BackColor = System.Drawing.Color.Transparent
        Me.cmbMeetTitle.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MeetingBindingSource, "eventID", True))
        Me.cmbMeetTitle.DataSource = Me.MeetingBindingSource
        Me.cmbMeetTitle.DisplayMember = "title"
        Me.cmbMeetTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMeetTitle.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMeetTitle.FocusedState.Parent = Me.cmbMeetTitle
        Me.cmbMeetTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMeetTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMeetTitle.FormattingEnabled = True
        Me.cmbMeetTitle.HoverState.Parent = Me.cmbMeetTitle
        Me.cmbMeetTitle.ItemHeight = 30
        Me.cmbMeetTitle.ItemsAppearance.Parent = Me.cmbMeetTitle
        Me.cmbMeetTitle.Location = New System.Drawing.Point(835, 28)
        Me.cmbMeetTitle.Name = "cmbMeetTitle"
        Me.cmbMeetTitle.ShadowDecoration.Parent = Me.cmbMeetTitle
        Me.cmbMeetTitle.Size = New System.Drawing.Size(230, 36)
        Me.cmbMeetTitle.TabIndex = 5
        Me.cmbMeetTitle.ValueMember = "eventID"
        '
        'MinChurchDbDataSet
        '
        Me.MinChurchDbDataSet.DataSetName = "MinChurchDbDataSet"
        Me.MinChurchDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MeetingBindingSource
        '
        Me.MeetingBindingSource.DataMember = "Meeting"
        Me.MeetingBindingSource.DataSource = Me.MinChurchDbDataSet
        '
        'MeetingTableAdapter
        '
        Me.MeetingTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Arrival Time"
        '
        'rbSign
        '
        Me.rbSign.AutoSize = True
        Me.rbSign.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSign.CheckedState.BorderThickness = 0
        Me.rbSign.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbSign.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbSign.CheckedState.InnerOffset = -4
        Me.rbSign.Location = New System.Drawing.Point(661, 108)
        Me.rbSign.Name = "rbSign"
        Me.rbSign.Size = New System.Drawing.Size(70, 17)
        Me.rbSign.TabIndex = 9
        Me.rbSign.TabStop = True
        Me.rbSign.Text = "Signature"
        Me.rbSign.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbSign.UncheckedState.BorderThickness = 2
        Me.rbSign.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbSign.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rbSign.UseVisualStyleBackColor = True
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 581)
        Me.Controls.Add(Me.btnSearchMemNameAtt)
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
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeetingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtTemperature As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMark As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearchMemNameAtt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpArrivalTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbMeetTitle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents MinChurchDbDataSet As MinChurchDbDataSet
    Friend WithEvents MeetingBindingSource As BindingSource
    Friend WithEvents MeetingTableAdapter As MinChurchDbDataSetTableAdapters.MeetingTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents rbSign As Guna.UI2.WinForms.Guna2RadioButton
End Class

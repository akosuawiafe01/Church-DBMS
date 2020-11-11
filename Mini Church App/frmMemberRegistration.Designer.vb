<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRegistration
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbMarStats = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAltCon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtON = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistrationDate = New Guna.UI.WinForms.GunaLabel()
        Me.dtpRegDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtEmergencyConRel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmerCon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDigAddr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtResLoc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbProfilePic = New System.Windows.Forms.PictureBox()
        Me.btnCanMemReg = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRegMeme = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtMemID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labMemID = New Guna.UI.WinForms.GunaLabel()
        Me.txtSearchReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearchReg = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateMemDeats = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(-1, 1)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(1296, 60)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Member Registration Desk"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GunaLabel3)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Controls.Add(Me.dtpDOB)
        Me.GroupBox1.Controls.Add(Me.cmbMarStats)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.txtOccupation)
        Me.GroupBox1.Controls.Add(Me.txtAltCon)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtON)
        Me.GroupBox1.Controls.Add(Me.txtFN)
        Me.GroupBox1.Controls.Add(Me.txtLN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 327)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Details"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(33, 276)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(226, 27)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Date of Birth"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr.", "Miss", "Mrs."})
        Me.cmbTitle.Location = New System.Drawing.Point(33, 40)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(226, 21)
        Me.cmbTitle.TabIndex = 9
        Me.cmbTitle.Text = "Title"
        '
        'dtpDOB
        '
        Me.dtpDOB.CheckedState.Parent = Me.dtpDOB
        Me.dtpDOB.FillColor = System.Drawing.Color.White
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDOB.HoverState.Parent = Me.dtpDOB
        Me.dtpDOB.Location = New System.Drawing.Point(397, 276)
        Me.dtpDOB.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.ShadowDecoration.Parent = Me.dtpDOB
        Me.dtpDOB.Size = New System.Drawing.Size(226, 27)
        Me.dtpDOB.TabIndex = 8
        Me.dtpDOB.Value = New Date(2020, 11, 3, 17, 32, 13, 984)
        '
        'cmbMarStats
        '
        Me.cmbMarStats.FormattingEnabled = True
        Me.cmbMarStats.Items.AddRange(New Object() {"Single", "Married"})
        Me.cmbMarStats.Location = New System.Drawing.Point(397, 237)
        Me.cmbMarStats.Name = "cmbMarStats"
        Me.cmbMarStats.Size = New System.Drawing.Size(226, 21)
        Me.cmbMarStats.TabIndex = 9
        Me.cmbMarStats.Text = "Marital Status"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(397, 40)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(226, 21)
        Me.cmbGender.TabIndex = 8
        Me.cmbGender.Text = "Gender"
        '
        'txtOccupation
        '
        Me.txtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOccupation.DefaultText = ""
        Me.txtOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccupation.DisabledState.Parent = Me.txtOccupation
        Me.txtOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOccupation.FocusedState.Parent = Me.txtOccupation
        Me.txtOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOccupation.HoverState.Parent = Me.txtOccupation
        Me.txtOccupation.Location = New System.Drawing.Point(33, 237)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccupation.PlaceholderText = "Occupation"
        Me.txtOccupation.SelectedText = ""
        Me.txtOccupation.ShadowDecoration.Parent = Me.txtOccupation
        Me.txtOccupation.Size = New System.Drawing.Size(226, 27)
        Me.txtOccupation.TabIndex = 7
        '
        'txtAltCon
        '
        Me.txtAltCon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAltCon.DefaultText = ""
        Me.txtAltCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAltCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAltCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAltCon.DisabledState.Parent = Me.txtAltCon
        Me.txtAltCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAltCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAltCon.FocusedState.Parent = Me.txtAltCon
        Me.txtAltCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAltCon.HoverState.Parent = Me.txtAltCon
        Me.txtAltCon.Location = New System.Drawing.Point(397, 187)
        Me.txtAltCon.Name = "txtAltCon"
        Me.txtAltCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAltCon.PlaceholderText = "Alternate Contact"
        Me.txtAltCon.SelectedText = ""
        Me.txtAltCon.ShadowDecoration.Parent = Me.txtAltCon
        Me.txtAltCon.Size = New System.Drawing.Size(226, 27)
        Me.txtAltCon.TabIndex = 6
        '
        'txtContact
        '
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.Parent = Me.txtContact
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.FocusedState.Parent = Me.txtContact
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.HoverState.Parent = Me.txtContact
        Me.txtContact.Location = New System.Drawing.Point(33, 187)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.PlaceholderText = "Contact"
        Me.txtContact.SelectedText = ""
        Me.txtContact.ShadowDecoration.Parent = Me.txtContact
        Me.txtContact.Size = New System.Drawing.Size(226, 27)
        Me.txtContact.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(397, 137)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(226, 27)
        Me.txtEmail.TabIndex = 4
        '
        'txtON
        '
        Me.txtON.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtON.DefaultText = ""
        Me.txtON.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtON.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtON.DisabledState.Parent = Me.txtON
        Me.txtON.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtON.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtON.FocusedState.Parent = Me.txtON
        Me.txtON.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtON.HoverState.Parent = Me.txtON
        Me.txtON.Location = New System.Drawing.Point(33, 137)
        Me.txtON.Name = "txtON"
        Me.txtON.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtON.PlaceholderText = "Other Name"
        Me.txtON.SelectedText = ""
        Me.txtON.ShadowDecoration.Parent = Me.txtON
        Me.txtON.Size = New System.Drawing.Size(226, 27)
        Me.txtON.TabIndex = 3
        '
        'txtFN
        '
        Me.txtFN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFN.DefaultText = ""
        Me.txtFN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFN.DisabledState.Parent = Me.txtFN
        Me.txtFN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFN.FocusedState.Parent = Me.txtFN
        Me.txtFN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFN.HoverState.Parent = Me.txtFN
        Me.txtFN.Location = New System.Drawing.Point(397, 87)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFN.PlaceholderText = "First Name"
        Me.txtFN.SelectedText = ""
        Me.txtFN.ShadowDecoration.Parent = Me.txtFN
        Me.txtFN.Size = New System.Drawing.Size(226, 27)
        Me.txtFN.TabIndex = 2
        '
        'txtLN
        '
        Me.txtLN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLN.DefaultText = ""
        Me.txtLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLN.DisabledState.Parent = Me.txtLN
        Me.txtLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLN.FocusedState.Parent = Me.txtLN
        Me.txtLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLN.HoverState.Parent = Me.txtLN
        Me.txtLN.Location = New System.Drawing.Point(33, 87)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLN.PlaceholderText = "Last Name"
        Me.txtLN.SelectedText = ""
        Me.txtLN.ShadowDecoration.Parent = Me.txtLN
        Me.txtLN.Size = New System.Drawing.Size(226, 27)
        Me.txtLN.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRegistrationDate)
        Me.GroupBox2.Controls.Add(Me.dtpRegDate)
        Me.GroupBox2.Controls.Add(Me.txtEmergencyConRel)
        Me.GroupBox2.Controls.Add(Me.txtEmerCon)
        Me.GroupBox2.Controls.Add(Me.txtDigAddr)
        Me.GroupBox2.Controls.Add(Me.txtResLoc)
        Me.GroupBox2.Location = New System.Drawing.Point(764, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 267)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Residence Information and Others"
        '
        'lblRegistrationDate
        '
        Me.lblRegistrationDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRegistrationDate.Location = New System.Drawing.Point(25, 216)
        Me.lblRegistrationDate.Name = "lblRegistrationDate"
        Me.lblRegistrationDate.Size = New System.Drawing.Size(134, 27)
        Me.lblRegistrationDate.TabIndex = 13
        Me.lblRegistrationDate.Text = "Registration Date"
        Me.lblRegistrationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpRegDate
        '
        Me.dtpRegDate.CheckedState.Parent = Me.dtpRegDate
        Me.dtpRegDate.Enabled = False
        Me.dtpRegDate.FillColor = System.Drawing.Color.White
        Me.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpRegDate.HoverState.Parent = Me.dtpRegDate
        Me.dtpRegDate.Location = New System.Drawing.Point(181, 216)
        Me.dtpRegDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpRegDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.ShadowDecoration.Parent = Me.dtpRegDate
        Me.dtpRegDate.Size = New System.Drawing.Size(250, 27)
        Me.dtpRegDate.TabIndex = 12
        Me.dtpRegDate.Value = New Date(2020, 11, 3, 17, 48, 5, 230)
        '
        'txtEmergencyConRel
        '
        Me.txtEmergencyConRel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmergencyConRel.DefaultText = ""
        Me.txtEmergencyConRel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmergencyConRel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmergencyConRel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmergencyConRel.DisabledState.Parent = Me.txtEmergencyConRel
        Me.txtEmergencyConRel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmergencyConRel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmergencyConRel.FocusedState.Parent = Me.txtEmergencyConRel
        Me.txtEmergencyConRel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmergencyConRel.HoverState.Parent = Me.txtEmergencyConRel
        Me.txtEmergencyConRel.Location = New System.Drawing.Point(28, 171)
        Me.txtEmergencyConRel.Name = "txtEmergencyConRel"
        Me.txtEmergencyConRel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmergencyConRel.PlaceholderText = "Emergency Contact Relationship"
        Me.txtEmergencyConRel.SelectedText = ""
        Me.txtEmergencyConRel.ShadowDecoration.Parent = Me.txtEmergencyConRel
        Me.txtEmergencyConRel.Size = New System.Drawing.Size(411, 27)
        Me.txtEmergencyConRel.TabIndex = 11
        '
        'txtEmerCon
        '
        Me.txtEmerCon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmerCon.DefaultText = ""
        Me.txtEmerCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmerCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmerCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmerCon.DisabledState.Parent = Me.txtEmerCon
        Me.txtEmerCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmerCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmerCon.FocusedState.Parent = Me.txtEmerCon
        Me.txtEmerCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmerCon.HoverState.Parent = Me.txtEmerCon
        Me.txtEmerCon.Location = New System.Drawing.Point(28, 127)
        Me.txtEmerCon.Name = "txtEmerCon"
        Me.txtEmerCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmerCon.PlaceholderText = "Emergency Contact"
        Me.txtEmerCon.SelectedText = ""
        Me.txtEmerCon.ShadowDecoration.Parent = Me.txtEmerCon
        Me.txtEmerCon.Size = New System.Drawing.Size(411, 27)
        Me.txtEmerCon.TabIndex = 10
        '
        'txtDigAddr
        '
        Me.txtDigAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDigAddr.DefaultText = ""
        Me.txtDigAddr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDigAddr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDigAddr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDigAddr.DisabledState.Parent = Me.txtDigAddr
        Me.txtDigAddr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDigAddr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDigAddr.FocusedState.Parent = Me.txtDigAddr
        Me.txtDigAddr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDigAddr.HoverState.Parent = Me.txtDigAddr
        Me.txtDigAddr.Location = New System.Drawing.Point(28, 77)
        Me.txtDigAddr.Name = "txtDigAddr"
        Me.txtDigAddr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDigAddr.PlaceholderText = "Digital Address"
        Me.txtDigAddr.SelectedText = ""
        Me.txtDigAddr.ShadowDecoration.Parent = Me.txtDigAddr
        Me.txtDigAddr.Size = New System.Drawing.Size(411, 27)
        Me.txtDigAddr.TabIndex = 9
        '
        'txtResLoc
        '
        Me.txtResLoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResLoc.DefaultText = ""
        Me.txtResLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtResLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtResLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResLoc.DisabledState.Parent = Me.txtResLoc
        Me.txtResLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtResLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResLoc.FocusedState.Parent = Me.txtResLoc
        Me.txtResLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtResLoc.HoverState.Parent = Me.txtResLoc
        Me.txtResLoc.Location = New System.Drawing.Point(28, 27)
        Me.txtResLoc.Name = "txtResLoc"
        Me.txtResLoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResLoc.PlaceholderText = "Residence Location"
        Me.txtResLoc.SelectedText = ""
        Me.txtResLoc.ShadowDecoration.Parent = Me.txtResLoc
        Me.txtResLoc.Size = New System.Drawing.Size(411, 27)
        Me.txtResLoc.TabIndex = 8
        '
        'pbProfilePic
        '
        Me.pbProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbProfilePic.Location = New System.Drawing.Point(995, 112)
        Me.pbProfilePic.Name = "pbProfilePic"
        Me.pbProfilePic.Size = New System.Drawing.Size(252, 130)
        Me.pbProfilePic.TabIndex = 3
        Me.pbProfilePic.TabStop = False
        '
        'btnCanMemReg
        '
        Me.btnCanMemReg.CheckedState.Parent = Me.btnCanMemReg
        Me.btnCanMemReg.CustomImages.Parent = Me.btnCanMemReg
        Me.btnCanMemReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCanMemReg.ForeColor = System.Drawing.Color.White
        Me.btnCanMemReg.HoverState.Parent = Me.btnCanMemReg
        Me.btnCanMemReg.Location = New System.Drawing.Point(1171, 575)
        Me.btnCanMemReg.Name = "btnCanMemReg"
        Me.btnCanMemReg.ShadowDecoration.Parent = Me.btnCanMemReg
        Me.btnCanMemReg.Size = New System.Drawing.Size(76, 24)
        Me.btnCanMemReg.TabIndex = 4
        Me.btnCanMemReg.Text = "Cancel"
        '
        'btnRegMeme
        '
        Me.btnRegMeme.CheckedState.Parent = Me.btnRegMeme
        Me.btnRegMeme.CustomImages.Parent = Me.btnRegMeme
        Me.btnRegMeme.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegMeme.ForeColor = System.Drawing.Color.White
        Me.btnRegMeme.HoverState.Parent = Me.btnRegMeme
        Me.btnRegMeme.Location = New System.Drawing.Point(882, 575)
        Me.btnRegMeme.Name = "btnRegMeme"
        Me.btnRegMeme.ShadowDecoration.Parent = Me.btnRegMeme
        Me.btnRegMeme.Size = New System.Drawing.Size(76, 24)
        Me.btnRegMeme.TabIndex = 5
        Me.btnRegMeme.Text = "Register"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(1203, 254)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(44, 15)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "Picture"
        '
        'txtMemID
        '
        Me.txtMemID.BorderColor = System.Drawing.Color.Red
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
        Me.txtMemID.Location = New System.Drawing.Point(114, 170)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemID.PlaceholderText = ""
        Me.txtMemID.SelectedText = ""
        Me.txtMemID.ShadowDecoration.Parent = Me.txtMemID
        Me.txtMemID.Size = New System.Drawing.Size(157, 27)
        Me.txtMemID.TabIndex = 0
        '
        'labMemID
        '
        Me.labMemID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.labMemID.Location = New System.Drawing.Point(42, 172)
        Me.labMemID.Name = "labMemID"
        Me.labMemID.Size = New System.Drawing.Size(66, 27)
        Me.labMemID.TabIndex = 7
        Me.labMemID.Text = "Member ID"
        '
        'txtSearchReg
        '
        Me.txtSearchReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchReg.DefaultText = ""
        Me.txtSearchReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchReg.DisabledState.Parent = Me.txtSearchReg
        Me.txtSearchReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchReg.FocusedState.Parent = Me.txtSearchReg
        Me.txtSearchReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchReg.HoverState.Parent = Me.txtSearchReg
        Me.txtSearchReg.Location = New System.Drawing.Point(321, 169)
        Me.txtSearchReg.Name = "txtSearchReg"
        Me.txtSearchReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchReg.PlaceholderText = "Search for member"
        Me.txtSearchReg.SelectedText = ""
        Me.txtSearchReg.ShadowDecoration.Parent = Me.txtSearchReg
        Me.txtSearchReg.Size = New System.Drawing.Size(382, 28)
        Me.txtSearchReg.TabIndex = 8
        '
        'btnSearchReg
        '
        Me.btnSearchReg.CheckedState.Parent = Me.btnSearchReg
        Me.btnSearchReg.CustomImages.Parent = Me.btnSearchReg
        Me.btnSearchReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchReg.ForeColor = System.Drawing.Color.White
        Me.btnSearchReg.HoverState.Parent = Me.btnSearchReg
        Me.btnSearchReg.Location = New System.Drawing.Point(610, 203)
        Me.btnSearchReg.Name = "btnSearchReg"
        Me.btnSearchReg.ShadowDecoration.Parent = Me.btnSearchReg
        Me.btnSearchReg.Size = New System.Drawing.Size(93, 28)
        Me.btnSearchReg.TabIndex = 9
        Me.btnSearchReg.Text = "Search by name"
        '
        'btnUpdateMemDeats
        '
        Me.btnUpdateMemDeats.CheckedState.Parent = Me.btnUpdateMemDeats
        Me.btnUpdateMemDeats.CustomImages.Parent = Me.btnUpdateMemDeats
        Me.btnUpdateMemDeats.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdateMemDeats.ForeColor = System.Drawing.Color.White
        Me.btnUpdateMemDeats.HoverState.Parent = Me.btnUpdateMemDeats
        Me.btnUpdateMemDeats.Location = New System.Drawing.Point(1016, 575)
        Me.btnUpdateMemDeats.Name = "btnUpdateMemDeats"
        Me.btnUpdateMemDeats.ShadowDecoration.Parent = Me.btnUpdateMemDeats
        Me.btnUpdateMemDeats.Size = New System.Drawing.Size(92, 24)
        Me.btnUpdateMemDeats.TabIndex = 10
        Me.btnUpdateMemDeats.Text = "Update Details"
        '
        'btnClearSearch
        '
        Me.btnClearSearch.CheckedState.Parent = Me.btnClearSearch
        Me.btnClearSearch.CustomImages.Parent = Me.btnClearSearch
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearSearch.ForeColor = System.Drawing.Color.White
        Me.btnClearSearch.HoverState.Parent = Me.btnClearSearch
        Me.btnClearSearch.Location = New System.Drawing.Point(409, 203)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.ShadowDecoration.Parent = Me.btnClearSearch
        Me.btnClearSearch.Size = New System.Drawing.Size(92, 24)
        Me.btnClearSearch.TabIndex = 11
        Me.btnClearSearch.Text = "Clear search"
        '
        'frmMemberRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1295, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnUpdateMemDeats)
        Me.Controls.Add(Me.btnSearchReg)
        Me.Controls.Add(Me.txtSearchReg)
        Me.Controls.Add(Me.labMemID)
        Me.Controls.Add(Me.txtMemID)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.btnRegMeme)
        Me.Controls.Add(Me.btnCanMemReg)
        Me.Controls.Add(Me.pbProfilePic)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "frmMemberRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberRegistration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents btnCanMemReg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegMeme As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAltCon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtON As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMemID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labMemID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtpDOB As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbMarStats As ComboBox
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtEmergencyConRel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmerCon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDigAddr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtResLoc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRegistrationDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtpRegDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtSearchReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearchReg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateMemDeats As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearSearch As Guna.UI2.WinForms.Guna2Button
End Class

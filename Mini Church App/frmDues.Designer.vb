<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDues
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchMemNameDues = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMemID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPayYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpPayDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbPayMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPayAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRecepNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPayDues = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelPay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchMem = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1224, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dues Desk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtSearchMemNameDues
        '
        Me.txtSearchMemNameDues.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchMemNameDues.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearchMemNameDues.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchMemNameDues.DefaultText = ""
        Me.txtSearchMemNameDues.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchMemNameDues.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchMemNameDues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMemNameDues.DisabledState.Parent = Me.txtSearchMemNameDues
        Me.txtSearchMemNameDues.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMemNameDues.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMemNameDues.FocusedState.Parent = Me.txtSearchMemNameDues
        Me.txtSearchMemNameDues.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMemNameDues.HoverState.Parent = Me.txtSearchMemNameDues
        Me.txtSearchMemNameDues.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMemNameDues.Location = New System.Drawing.Point(589, 92)
        Me.txtSearchMemNameDues.Name = "txtSearchMemNameDues"
        Me.txtSearchMemNameDues.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchMemNameDues.PlaceholderText = "Search for member by name"
        Me.txtSearchMemNameDues.SelectedText = ""
        Me.txtSearchMemNameDues.ShadowDecoration.Parent = Me.txtSearchMemNameDues
        Me.txtSearchMemNameDues.Size = New System.Drawing.Size(528, 41)
        Me.txtSearchMemNameDues.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMemName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMemID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(28, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1196, 163)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
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
        Me.txtMemName.Location = New System.Drawing.Point(699, 66)
        Me.txtMemName.Name = "txtMemName"
        Me.txtMemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemName.PlaceholderText = ""
        Me.txtMemName.SelectedText = ""
        Me.txtMemName.ShadowDecoration.Parent = Me.txtMemName
        Me.txtMemName.Size = New System.Drawing.Size(445, 24)
        Me.txtMemName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(582, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
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
        Me.txtMemID.Location = New System.Drawing.Point(178, 66)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemID.PlaceholderText = ""
        Me.txtMemID.SelectedText = ""
        Me.txtMemID.ShadowDecoration.Parent = Me.txtMemID
        Me.txtMemID.Size = New System.Drawing.Size(178, 24)
        Me.txtMemID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(58, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Member ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPayYear)
        Me.GroupBox2.Controls.Add(Me.dtpPayDate)
        Me.GroupBox2.Controls.Add(Me.cmbPayMonth)
        Me.GroupBox2.Controls.Add(Me.txtPayAmount)
        Me.GroupBox2.Controls.Add(Me.txtRecepNo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1196, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Make Payments"
        '
        'cmbPayYear
        '
        Me.cmbPayYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPayYear.FocusedState.Parent = Me.cmbPayYear
        Me.cmbPayYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPayYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPayYear.FormattingEnabled = True
        Me.cmbPayYear.HoverState.Parent = Me.cmbPayYear
        Me.cmbPayYear.ItemHeight = 20
        Me.cmbPayYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.cmbPayYear.ItemsAppearance.Parent = Me.cmbPayYear
        Me.cmbPayYear.Location = New System.Drawing.Point(914, 31)
        Me.cmbPayYear.MaxDropDownItems = 5
        Me.cmbPayYear.Name = "cmbPayYear"
        Me.cmbPayYear.ShadowDecoration.Parent = Me.cmbPayYear
        Me.cmbPayYear.Size = New System.Drawing.Size(230, 26)
        Me.cmbPayYear.TabIndex = 9
        '
        'dtpPayDate
        '
        Me.dtpPayDate.CheckedState.Parent = Me.dtpPayDate
        Me.dtpPayDate.FillColor = System.Drawing.Color.White
        Me.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpPayDate.HoverState.Parent = Me.dtpPayDate
        Me.dtpPayDate.Location = New System.Drawing.Point(178, 132)
        Me.dtpPayDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpPayDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.ShadowDecoration.Parent = Me.dtpPayDate
        Me.dtpPayDate.Size = New System.Drawing.Size(230, 36)
        Me.dtpPayDate.TabIndex = 7
        Me.dtpPayDate.Value = New Date(2020, 10, 27, 11, 36, 15, 338)
        '
        'cmbPayMonth
        '
        Me.cmbPayMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayMonth.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPayMonth.FocusedState.Parent = Me.cmbPayMonth
        Me.cmbPayMonth.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPayMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPayMonth.FormattingEnabled = True
        Me.cmbPayMonth.HoverState.Parent = Me.cmbPayMonth
        Me.cmbPayMonth.ItemHeight = 30
        Me.cmbPayMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbPayMonth.ItemsAppearance.Parent = Me.cmbPayMonth
        Me.cmbPayMonth.Location = New System.Drawing.Point(523, 37)
        Me.cmbPayMonth.Name = "cmbPayMonth"
        Me.cmbPayMonth.ShadowDecoration.Parent = Me.cmbPayMonth
        Me.cmbPayMonth.Size = New System.Drawing.Size(230, 36)
        Me.cmbPayMonth.TabIndex = 5
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPayAmount.DefaultText = ""
        Me.txtPayAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPayAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPayAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPayAmount.DisabledState.Parent = Me.txtPayAmount
        Me.txtPayAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPayAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPayAmount.FocusedState.Parent = Me.txtPayAmount
        Me.txtPayAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPayAmount.HoverState.Parent = Me.txtPayAmount
        Me.txtPayAmount.Location = New System.Drawing.Point(914, 125)
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPayAmount.PlaceholderText = "Amount"
        Me.txtPayAmount.SelectedText = ""
        Me.txtPayAmount.ShadowDecoration.Parent = Me.txtPayAmount
        Me.txtPayAmount.Size = New System.Drawing.Size(230, 30)
        Me.txtPayAmount.TabIndex = 8
        '
        'txtRecepNo
        '
        Me.txtRecepNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRecepNo.DefaultText = ""
        Me.txtRecepNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRecepNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRecepNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecepNo.DisabledState.Parent = Me.txtRecepNo
        Me.txtRecepNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRecepNo.Enabled = False
        Me.txtRecepNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecepNo.FocusedState.Parent = Me.txtRecepNo
        Me.txtRecepNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecepNo.HoverState.Parent = Me.txtRecepNo
        Me.txtRecepNo.Location = New System.Drawing.Point(178, 37)
        Me.txtRecepNo.Name = "txtRecepNo"
        Me.txtRecepNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecepNo.PlaceholderText = "Reciept No."
        Me.txtRecepNo.SelectedText = ""
        Me.txtRecepNo.ShadowDecoration.Parent = Me.txtRecepNo
        Me.txtRecepNo.Size = New System.Drawing.Size(230, 30)
        Me.txtRecepNo.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(94, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Payment Date"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(821, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(821, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Year"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(449, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Month"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(94, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reciept No."
        '
        'btnPayDues
        '
        Me.btnPayDues.CheckedState.Parent = Me.btnPayDues
        Me.btnPayDues.CustomImages.Parent = Me.btnPayDues
        Me.btnPayDues.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPayDues.ForeColor = System.Drawing.Color.White
        Me.btnPayDues.HoverState.Parent = Me.btnPayDues
        Me.btnPayDues.Location = New System.Drawing.Point(932, 586)
        Me.btnPayDues.Name = "btnPayDues"
        Me.btnPayDues.ShadowDecoration.Parent = Me.btnPayDues
        Me.btnPayDues.Size = New System.Drawing.Size(99, 28)
        Me.btnPayDues.TabIndex = 9
        Me.btnPayDues.Text = "Pay"
        '
        'btnCancelPay
        '
        Me.btnCancelPay.CheckedState.Parent = Me.btnCancelPay
        Me.btnCancelPay.CustomImages.Parent = Me.btnCancelPay
        Me.btnCancelPay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancelPay.ForeColor = System.Drawing.Color.White
        Me.btnCancelPay.HoverState.Parent = Me.btnCancelPay
        Me.btnCancelPay.Location = New System.Drawing.Point(1073, 586)
        Me.btnCancelPay.Name = "btnCancelPay"
        Me.btnCancelPay.ShadowDecoration.Parent = Me.btnCancelPay
        Me.btnCancelPay.Size = New System.Drawing.Size(99, 28)
        Me.btnCancelPay.TabIndex = 10
        Me.btnCancelPay.Text = "Cancel"
        '
        'btnSearchMem
        '
        Me.btnSearchMem.CheckedState.Parent = Me.btnSearchMem
        Me.btnSearchMem.CustomImages.Parent = Me.btnSearchMem
        Me.btnSearchMem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearchMem.ForeColor = System.Drawing.Color.White
        Me.btnSearchMem.HoverState.Parent = Me.btnSearchMem
        Me.btnSearchMem.Location = New System.Drawing.Point(1123, 92)
        Me.btnSearchMem.Name = "btnSearchMem"
        Me.btnSearchMem.ShadowDecoration.Parent = Me.btnSearchMem
        Me.btnSearchMem.Size = New System.Drawing.Size(101, 32)
        Me.btnSearchMem.TabIndex = 1
        Me.btnSearchMem.Text = "Search by name"
        '
        'frmDues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearchMem)
        Me.Controls.Add(Me.btnCancelPay)
        Me.Controls.Add(Me.btnPayDues)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearchMemNameDues)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dues "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchMemNameDues As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMemID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPayMonth As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPayAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRecepNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpPayDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnPayDues As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearchMem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbPayYear As Guna.UI2.WinForms.Guna2ComboBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDues
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMemID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRecepNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPayAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbPayMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbPayYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnPayDues = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelPay = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1224, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dues Desk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(763, 79)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(461, 32)
        Me.Guna2TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMemName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMemID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1196, 163)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Guna2DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.cmbPayYear)
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
        Me.txtMemName.Location = New System.Drawing.Point(699, 66)
        Me.txtMemName.Name = "txtMemName"
        Me.txtMemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemName.PlaceholderText = ""
        Me.txtMemName.SelectedText = ""
        Me.txtMemName.ShadowDecoration.Parent = Me.txtMemName
        Me.txtMemName.Size = New System.Drawing.Size(445, 24)
        Me.txtMemName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(582, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(58, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Member ID"
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
        Me.txtMemID.Location = New System.Drawing.Point(178, 66)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemID.PlaceholderText = ""
        Me.txtMemID.SelectedText = ""
        Me.txtMemID.ShadowDecoration.Parent = Me.txtMemID
        Me.txtMemID.Size = New System.Drawing.Size(178, 24)
        Me.txtMemID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(94, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reciept No."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(449, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Month"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(821, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Year"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(821, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(94, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Payment Date"
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
        Me.txtRecepNo.TabIndex = 5
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
        'cmbPayMonth
        '
        Me.cmbPayMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.cmbPayMonth.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cmbPayMonth.TabIndex = 9
        '
        'cmbPayYear
        '
        Me.cmbPayYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPayYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbPayYear.FocusedState.Parent = Me.cmbPayYear
        Me.cmbPayYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPayYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPayYear.FormattingEnabled = True
        Me.cmbPayYear.HoverState.Parent = Me.cmbPayYear
        Me.cmbPayYear.ItemHeight = 30
        Me.cmbPayYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2027", "2028", "2029", "2030", "2031"})
        Me.cmbPayYear.ItemsAppearance.Parent = Me.cmbPayYear
        Me.cmbPayYear.Location = New System.Drawing.Point(914, 37)
        Me.cmbPayYear.Name = "cmbPayYear"
        Me.cmbPayYear.ShadowDecoration.Parent = Me.cmbPayYear
        Me.cmbPayYear.Size = New System.Drawing.Size(230, 36)
        Me.cmbPayYear.TabIndex = 10
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(178, 132)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(230, 36)
        Me.Guna2DateTimePicker1.TabIndex = 11
        Me.Guna2DateTimePicker1.Value = New Date(2020, 10, 27, 11, 36, 15, 338)
        '
        'btnPayDues
        '
        Me.btnPayDues.CheckedState.Parent = Me.btnPayDues
        Me.btnPayDues.CustomImages.Parent = Me.btnPayDues
        Me.btnPayDues.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPayDues.ForeColor = System.Drawing.Color.White
        Me.btnPayDues.HoverState.Parent = Me.btnPayDues
        Me.btnPayDues.Location = New System.Drawing.Point(852, 586)
        Me.btnPayDues.Name = "btnPayDues"
        Me.btnPayDues.ShadowDecoration.Parent = Me.btnPayDues
        Me.btnPayDues.Size = New System.Drawing.Size(99, 28)
        Me.btnPayDues.TabIndex = 4
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
        Me.btnCancelPay.TabIndex = 5
        Me.btnCancelPay.Text = "Cancel"
        '
        'frmDues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 656)
        Me.Controls.Add(Me.btnCancelPay)
        Me.Controls.Add(Me.btnPayDues)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2TextBox1)
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
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
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
    Friend WithEvents cmbPayYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnPayDues As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelPay As Guna.UI2.WinForms.Guna2Button
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rptDuesRecords
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAllDues = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.MinChurchDbDataSet = New Mini_Church_App.MinChurchDbDataSet()
        Me.AllPaidDuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllPaidDuesTableAdapter = New Mini_Church_App.MinChurchDbDataSetTableAdapters.AllPaidDuesTableAdapter()
        Me.ReceiptNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAllDues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllPaidDuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1212, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dues Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dgvAllDues
        '
        Me.dgvAllDues.AllowUserToAddRows = False
        Me.dgvAllDues.AllowUserToDeleteRows = False
        Me.dgvAllDues.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvAllDues.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAllDues.AutoGenerateColumns = False
        Me.dgvAllDues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAllDues.BackgroundColor = System.Drawing.Color.White
        Me.dgvAllDues.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAllDues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAllDues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAllDues.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAllDues.ColumnHeadersHeight = 21
        Me.dgvAllDues.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptNumberDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.OtherNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn})
        Me.dgvAllDues.DataSource = Me.AllPaidDuesBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAllDues.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAllDues.EnableHeadersVisualStyles = False
        Me.dgvAllDues.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAllDues.Location = New System.Drawing.Point(0, 120)
        Me.dgvAllDues.Name = "dgvAllDues"
        Me.dgvAllDues.ReadOnly = True
        Me.dgvAllDues.RowHeadersVisible = False
        Me.dgvAllDues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAllDues.Size = New System.Drawing.Size(1212, 477)
        Me.dgvAllDues.TabIndex = 1
        Me.dgvAllDues.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAllDues.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAllDues.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAllDues.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAllDues.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAllDues.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAllDues.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAllDues.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAllDues.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAllDues.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAllDues.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAllDues.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAllDues.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAllDues.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvAllDues.ThemeStyle.ReadOnly = True
        Me.dgvAllDues.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAllDues.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAllDues.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAllDues.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvAllDues.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAllDues.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAllDues.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(1068, 609)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(113, 35)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Main Menu"
        '
        'MinChurchDbDataSet
        '
        Me.MinChurchDbDataSet.DataSetName = "MinChurchDbDataSet"
        Me.MinChurchDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllPaidDuesBindingSource
        '
        Me.AllPaidDuesBindingSource.DataMember = "AllPaidDues"
        Me.AllPaidDuesBindingSource.DataSource = Me.MinChurchDbDataSet
        '
        'AllPaidDuesTableAdapter
        '
        Me.AllPaidDuesTableAdapter.ClearBeforeFill = True
        '
        'ReceiptNumberDataGridViewTextBoxColumn
        '
        Me.ReceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "Receipt_Number"
        Me.ReceiptNumberDataGridViewTextBoxColumn.HeaderText = "Receipt_Number"
        Me.ReceiptNumberDataGridViewTextBoxColumn.Name = "ReceiptNumberDataGridViewTextBoxColumn"
        Me.ReceiptNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OtherNameDataGridViewTextBoxColumn
        '
        Me.OtherNameDataGridViewTextBoxColumn.DataPropertyName = "Other_Name"
        Me.OtherNameDataGridViewTextBoxColumn.HeaderText = "Other_Name"
        Me.OtherNameDataGridViewTextBoxColumn.Name = "OtherNameDataGridViewTextBoxColumn"
        Me.OtherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        Me.MonthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PayDateDataGridViewTextBoxColumn
        '
        Me.PayDateDataGridViewTextBoxColumn.DataPropertyName = "Pay_Date"
        Me.PayDateDataGridViewTextBoxColumn.HeaderText = "Pay_Date"
        Me.PayDateDataGridViewTextBoxColumn.Name = "PayDateDataGridViewTextBoxColumn"
        Me.PayDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'rptDuesRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAllDues)
        Me.Controls.Add(Me.Label1)
        Me.Name = "rptDuesRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "rptDuesRecords"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAllDues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllPaidDuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAllDues As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MinChurchDbDataSet As MinChurchDbDataSet
    Friend WithEvents AllPaidDuesBindingSource As BindingSource
    Friend WithEvents AllPaidDuesTableAdapter As MinChurchDbDataSetTableAdapters.AllPaidDuesTableAdapter
    Friend WithEvents ReceiptNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptDueYAF
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvYafMem = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueYAFMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MinChurchDbDataSet = New Mini_Church_App.MinChurchDbDataSet()
        Me.DueYAFMembersTableAdapter = New Mini_Church_App.MinChurchDbDataSetTableAdapters.DueYAFMembersTableAdapter()
        Me.btnBackMain = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvYafMem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DueYAFMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1228, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Due YAF Members"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dgvYafMem
        '
        Me.dgvYafMem.AllowUserToAddRows = False
        Me.dgvYafMem.AllowUserToDeleteRows = False
        Me.dgvYafMem.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvYafMem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvYafMem.AutoGenerateColumns = False
        Me.dgvYafMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvYafMem.BackgroundColor = System.Drawing.Color.White
        Me.dgvYafMem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvYafMem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvYafMem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvYafMem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvYafMem.ColumnHeadersHeight = 21
        Me.dgvYafMem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AgeDataGridViewTextBoxColumn})
        Me.dgvYafMem.DataSource = Me.DueYAFMembersBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvYafMem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvYafMem.EnableHeadersVisualStyles = False
        Me.dgvYafMem.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvYafMem.Location = New System.Drawing.Point(12, 109)
        Me.dgvYafMem.Name = "dgvYafMem"
        Me.dgvYafMem.ReadOnly = True
        Me.dgvYafMem.RowHeadersVisible = False
        Me.dgvYafMem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvYafMem.Size = New System.Drawing.Size(1212, 480)
        Me.dgvYafMem.TabIndex = 1
        Me.dgvYafMem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvYafMem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvYafMem.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvYafMem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvYafMem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvYafMem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvYafMem.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvYafMem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvYafMem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvYafMem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvYafMem.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvYafMem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvYafMem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvYafMem.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvYafMem.ThemeStyle.ReadOnly = True
        Me.dgvYafMem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvYafMem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvYafMem.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvYafMem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvYafMem.ThemeStyle.RowsStyle.Height = 22
        Me.dgvYafMem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvYafMem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueYAFMembersBindingSource
        '
        Me.DueYAFMembersBindingSource.DataMember = "DueYAFMembers"
        Me.DueYAFMembersBindingSource.DataSource = Me.MinChurchDbDataSet
        '
        'MinChurchDbDataSet
        '
        Me.MinChurchDbDataSet.DataSetName = "MinChurchDbDataSet"
        Me.MinChurchDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DueYAFMembersTableAdapter
        '
        Me.DueYAFMembersTableAdapter.ClearBeforeFill = True
        '
        'btnBackMain
        '
        Me.btnBackMain.CheckedState.Parent = Me.btnBackMain
        Me.btnBackMain.CustomImages.Parent = Me.btnBackMain
        Me.btnBackMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackMain.ForeColor = System.Drawing.Color.White
        Me.btnBackMain.HoverState.Parent = Me.btnBackMain
        Me.btnBackMain.Location = New System.Drawing.Point(1067, 595)
        Me.btnBackMain.Name = "btnBackMain"
        Me.btnBackMain.ShadowDecoration.Parent = Me.btnBackMain
        Me.btnBackMain.Size = New System.Drawing.Size(157, 28)
        Me.btnBackMain.TabIndex = 2
        Me.btnBackMain.Text = "Back to Main Menu"
        '
        'rptDueYAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBackMain)
        Me.Controls.Add(Me.dgvYafMem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "rptDueYAF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptDueYAF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvYafMem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DueYAFMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvYafMem As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MinChurchDbDataSet As MinChurchDbDataSet
    Friend WithEvents DueYAFMembersBindingSource As BindingSource
    Friend WithEvents DueYAFMembersTableAdapter As MinChurchDbDataSetTableAdapters.DueYAFMembersTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBackMain As Guna.UI2.WinForms.Guna2Button
End Class

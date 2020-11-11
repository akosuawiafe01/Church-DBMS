<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptMeetingHeadCount
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
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvHeadCount = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MinChurchDbDataSet = New Mini_Church_App.MinChurchDbDataSet()
        Me.MeetingHeadCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MeetingHeadCountTableAdapter = New Mini_Church_App.MinChurchDbDataSetTableAdapters.MeetingHeadCountTableAdapter()
        Me.MeetingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeetingTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHeadCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeetingHeadCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1212, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Meeting Head Count"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(1074, 610)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(120, 34)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Main Menu"
        '
        'dgvHeadCount
        '
        Me.dgvHeadCount.AllowUserToAddRows = False
        Me.dgvHeadCount.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvHeadCount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHeadCount.AutoGenerateColumns = False
        Me.dgvHeadCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHeadCount.BackgroundColor = System.Drawing.Color.White
        Me.dgvHeadCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHeadCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHeadCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeadCount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHeadCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeadCount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MeetingDateDataGridViewTextBoxColumn, Me.MeetingTitleDataGridViewTextBoxColumn, Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn})
        Me.dgvHeadCount.DataSource = Me.MeetingHeadCountBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHeadCount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHeadCount.EnableHeadersVisualStyles = False
        Me.dgvHeadCount.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHeadCount.Location = New System.Drawing.Point(12, 101)
        Me.dgvHeadCount.Name = "dgvHeadCount"
        Me.dgvHeadCount.ReadOnly = True
        Me.dgvHeadCount.RowHeadersVisible = False
        Me.dgvHeadCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHeadCount.Size = New System.Drawing.Size(1212, 487)
        Me.dgvHeadCount.TabIndex = 3
        Me.dgvHeadCount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvHeadCount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHeadCount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvHeadCount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvHeadCount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvHeadCount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvHeadCount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvHeadCount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeadCount.ThemeStyle.HeaderStyle.Height = 21
        Me.dgvHeadCount.ThemeStyle.ReadOnly = True
        Me.dgvHeadCount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHeadCount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHeadCount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvHeadCount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvHeadCount.ThemeStyle.RowsStyle.Height = 22
        Me.dgvHeadCount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHeadCount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'MinChurchDbDataSet
        '
        Me.MinChurchDbDataSet.DataSetName = "MinChurchDbDataSet"
        Me.MinChurchDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MeetingHeadCountBindingSource
        '
        Me.MeetingHeadCountBindingSource.DataMember = "MeetingHeadCount"
        Me.MeetingHeadCountBindingSource.DataSource = Me.MinChurchDbDataSet
        '
        'MeetingHeadCountTableAdapter
        '
        Me.MeetingHeadCountTableAdapter.ClearBeforeFill = True
        '
        'MeetingDateDataGridViewTextBoxColumn
        '
        Me.MeetingDateDataGridViewTextBoxColumn.DataPropertyName = "Meeting_Date"
        Me.MeetingDateDataGridViewTextBoxColumn.HeaderText = "Meeting_Date"
        Me.MeetingDateDataGridViewTextBoxColumn.Name = "MeetingDateDataGridViewTextBoxColumn"
        Me.MeetingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MeetingTitleDataGridViewTextBoxColumn
        '
        Me.MeetingTitleDataGridViewTextBoxColumn.DataPropertyName = "Meeting_Title"
        Me.MeetingTitleDataGridViewTextBoxColumn.HeaderText = "Meeting_Title"
        Me.MeetingTitleDataGridViewTextBoxColumn.Name = "MeetingTitleDataGridViewTextBoxColumn"
        Me.MeetingTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalNumberofPeoplePresentDataGridViewTextBoxColumn
        '
        Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn.DataPropertyName = "Total_Number_of_People_Present"
        Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn.HeaderText = "Total_Number_of_People_Present"
        Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn.Name = "TotalNumberofPeoplePresentDataGridViewTextBoxColumn"
        Me.TotalNumberofPeoplePresentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'rptMeetingHeadCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvHeadCount)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "rptMeetingHeadCount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptMeetingHeadCount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvHeadCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinChurchDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeetingHeadCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvHeadCount As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MinChurchDbDataSet As MinChurchDbDataSet
    Friend WithEvents MeetingHeadCountBindingSource As BindingSource
    Friend WithEvents MeetingHeadCountTableAdapter As MinChurchDbDataSetTableAdapters.MeetingHeadCountTableAdapter
    Friend WithEvents MeetingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeetingTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalNumberofPeoplePresentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

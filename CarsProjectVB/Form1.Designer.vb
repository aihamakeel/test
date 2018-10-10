<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Tbl1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarsProjectDataSet = New CarsProjectVB.CarsProjectDataSet()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrceNamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MngmntNamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChekNamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChekDatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TirDatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BattryDatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.SrchGrp = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbx2 = New System.Windows.Forms.ComboBox()
        Me.cmbx1 = New System.Windows.Forms.ComboBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.InsrtGrp = New System.Windows.Forms.GroupBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Tbl1TableAdapter = New CarsProjectVB.CarsProjectDataSetTableAdapters.Tbl1TableAdapter()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.Tbl1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SrchGrp.SuspendLayout()
        Me.InsrtGrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbl1BindingSource
        '
        Me.Tbl1BindingSource.DataMember = "Tbl1"
        Me.Tbl1BindingSource.DataSource = Me.CarsProjectDataSet
        '
        'CarsProjectDataSet
        '
        Me.CarsProjectDataSet.DataSetName = "CarsProjectDataSet"
        Me.CarsProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Button4)
        Me.groupBox1.Controls.Add(Me.Button5)
        Me.groupBox1.Controls.Add(Me.Button6)
        Me.groupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.groupBox1.Location = New System.Drawing.Point(347, 49)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(278, 168)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "حذف"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(74, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 33)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "حذف بيانات عجلة"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(74, 117)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 33)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "حذف اسم المديرية"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(74, 73)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 33)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "حذف نوع العجلة"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CarNoDataGridViewTextBoxColumn, Me.CarTypeDataGridViewTextBoxColumn, Me.CarColorDataGridViewTextBoxColumn, Me.SrceNamDataGridViewTextBoxColumn, Me.MngmntNamDataGridViewTextBoxColumn, Me.ChekNamDataGridViewTextBoxColumn, Me.ChekDatDataGridViewTextBoxColumn, Me.TirDatDataGridViewTextBoxColumn, Me.BattryDatDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.AttachsDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.Tbl1BindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridView1.Location = New System.Drawing.Point(31, 237)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(1233, 417)
        Me.dataGridView1.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CarNoDataGridViewTextBoxColumn
        '
        Me.CarNoDataGridViewTextBoxColumn.DataPropertyName = "Car_No"
        Me.CarNoDataGridViewTextBoxColumn.HeaderText = "رقم العجلة"
        Me.CarNoDataGridViewTextBoxColumn.Name = "CarNoDataGridViewTextBoxColumn"
        Me.CarNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarTypeDataGridViewTextBoxColumn
        '
        Me.CarTypeDataGridViewTextBoxColumn.DataPropertyName = "Car_Type"
        Me.CarTypeDataGridViewTextBoxColumn.HeaderText = "نوع العجلة"
        Me.CarTypeDataGridViewTextBoxColumn.Name = "CarTypeDataGridViewTextBoxColumn"
        Me.CarTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarColorDataGridViewTextBoxColumn
        '
        Me.CarColorDataGridViewTextBoxColumn.DataPropertyName = "Car_Color"
        Me.CarColorDataGridViewTextBoxColumn.HeaderText = "لون العجلة"
        Me.CarColorDataGridViewTextBoxColumn.Name = "CarColorDataGridViewTextBoxColumn"
        Me.CarColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrceNamDataGridViewTextBoxColumn
        '
        Me.SrceNamDataGridViewTextBoxColumn.DataPropertyName = "Srce_Nam"
        Me.SrceNamDataGridViewTextBoxColumn.HeaderText = "اسم المستلم"
        Me.SrceNamDataGridViewTextBoxColumn.Name = "SrceNamDataGridViewTextBoxColumn"
        Me.SrceNamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MngmntNamDataGridViewTextBoxColumn
        '
        Me.MngmntNamDataGridViewTextBoxColumn.DataPropertyName = "Mngmnt_Nam"
        Me.MngmntNamDataGridViewTextBoxColumn.HeaderText = "اسم المديرية"
        Me.MngmntNamDataGridViewTextBoxColumn.Name = "MngmntNamDataGridViewTextBoxColumn"
        Me.MngmntNamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChekNamDataGridViewTextBoxColumn
        '
        Me.ChekNamDataGridViewTextBoxColumn.DataPropertyName = "Chek_Nam"
        Me.ChekNamDataGridViewTextBoxColumn.HeaderText = "نوع التصليح"
        Me.ChekNamDataGridViewTextBoxColumn.Name = "ChekNamDataGridViewTextBoxColumn"
        Me.ChekNamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChekDatDataGridViewTextBoxColumn
        '
        Me.ChekDatDataGridViewTextBoxColumn.DataPropertyName = "Chek_Dat"
        Me.ChekDatDataGridViewTextBoxColumn.HeaderText = "تاريخ التصليح"
        Me.ChekDatDataGridViewTextBoxColumn.Name = "ChekDatDataGridViewTextBoxColumn"
        Me.ChekDatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TirDatDataGridViewTextBoxColumn
        '
        Me.TirDatDataGridViewTextBoxColumn.DataPropertyName = "Tir_Dat"
        Me.TirDatDataGridViewTextBoxColumn.HeaderText = "تاريخ استلام الاطارات"
        Me.TirDatDataGridViewTextBoxColumn.Name = "TirDatDataGridViewTextBoxColumn"
        Me.TirDatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BattryDatDataGridViewTextBoxColumn
        '
        Me.BattryDatDataGridViewTextBoxColumn.DataPropertyName = "Battry_Dat"
        Me.BattryDatDataGridViewTextBoxColumn.HeaderText = "تاريخ استلام البطارية"
        Me.BattryDatDataGridViewTextBoxColumn.Name = "BattryDatDataGridViewTextBoxColumn"
        Me.BattryDatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "الملاحظات"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttachsDataGridViewTextBoxColumn
        '
        Me.AttachsDataGridViewTextBoxColumn.DataPropertyName = "Attachs"
        Me.AttachsDataGridViewTextBoxColumn.HeaderText = "المرفق"
        Me.AttachsDataGridViewTextBoxColumn.Name = "AttachsDataGridViewTextBoxColumn"
        Me.AttachsDataGridViewTextBoxColumn.ReadOnly = True
        Me.AttachsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SrchGrp
        '
        Me.SrchGrp.Controls.Add(Me.label3)
        Me.SrchGrp.Controls.Add(Me.label2)
        Me.SrchGrp.Controls.Add(Me.label1)
        Me.SrchGrp.Controls.Add(Me.cmbx2)
        Me.SrchGrp.Controls.Add(Me.cmbx1)
        Me.SrchGrp.Controls.Add(Me.txt1)
        Me.SrchGrp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SrchGrp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SrchGrp.Location = New System.Drawing.Point(986, 49)
        Me.SrchGrp.Name = "SrchGrp"
        Me.SrchGrp.Size = New System.Drawing.Size(278, 168)
        Me.SrchGrp.TabIndex = 5
        Me.SrchGrp.TabStop = False
        Me.SrchGrp.Text = "بحث"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(200, 124)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 17)
        Me.label3.TabIndex = 5
        Me.label3.Text = "اسم المديرية"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(203, 77)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 17)
        Me.label2.TabIndex = 4
        Me.label2.Text = "اسم المستلم"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(207, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 17)
        Me.label1.TabIndex = 3
        Me.label1.Text = "نوع العجلة"
        '
        'cmbx2
        '
        Me.cmbx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbx2.FormattingEnabled = True
        Me.cmbx2.Location = New System.Drawing.Point(12, 119)
        Me.cmbx2.Name = "cmbx2"
        Me.cmbx2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbx2.Size = New System.Drawing.Size(181, 27)
        Me.cmbx2.TabIndex = 2
        '
        'cmbx1
        '
        Me.cmbx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbx1.FormattingEnabled = True
        Me.cmbx1.Location = New System.Drawing.Point(12, 28)
        Me.cmbx1.Name = "cmbx1"
        Me.cmbx1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbx1.Size = New System.Drawing.Size(181, 27)
        Me.cmbx1.TabIndex = 0
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 75)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(181, 26)
        Me.txt1.TabIndex = 1
        '
        'InsrtGrp
        '
        Me.InsrtGrp.Controls.Add(Me.button3)
        Me.InsrtGrp.Controls.Add(Me.button2)
        Me.InsrtGrp.Controls.Add(Me.button1)
        Me.InsrtGrp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.InsrtGrp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InsrtGrp.Location = New System.Drawing.Point(668, 49)
        Me.InsrtGrp.Name = "InsrtGrp"
        Me.InsrtGrp.Size = New System.Drawing.Size(278, 168)
        Me.InsrtGrp.TabIndex = 3
        Me.InsrtGrp.TabStop = False
        Me.InsrtGrp.Text = "ادخال"
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Black
        Me.button3.Location = New System.Drawing.Point(66, 26)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(131, 33)
        Me.button3.TabIndex = 3
        Me.button3.Text = "ادخال بيانات عجلة"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Location = New System.Drawing.Point(66, 116)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(131, 33)
        Me.button2.TabIndex = 5
        Me.button2.Text = "ادخال اسم المديرية"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Location = New System.Drawing.Point(66, 72)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(131, 33)
        Me.button1.TabIndex = 4
        Me.button1.Text = "ادخال نوع العجلة"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Tbl1TableAdapter
        '
        Me.Tbl1TableAdapter.ClearBeforeFill = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1125, 14)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 28)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "عرض جميع البيانات"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1009, 14)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 28)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "طبع تقرير"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Tbl1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CarsProjectVB.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(31, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1233, 623)
        Me.ReportViewer1.TabIndex = 10
        Me.ReportViewer1.Visible = False
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Red
        Me.Button9.Location = New System.Drawing.Point(34, 32)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(29, 23)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "X"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1294, 671)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.SrchGrp)
        Me.Controls.Add(Me.InsrtGrp)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    برنامج تسليم العجلات"
        CType(Me.Tbl1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SrchGrp.ResumeLayout(False)
        Me.SrchGrp.PerformLayout()
        Me.InsrtGrp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents SrchGrp As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmbx2 As System.Windows.Forms.ComboBox
    Private WithEvents cmbx1 As System.Windows.Forms.ComboBox
    Private WithEvents txt1 As System.Windows.Forms.TextBox
    Private WithEvents InsrtGrp As System.Windows.Forms.GroupBox
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents CarsProjectDataSet As CarsProjectVB.CarsProjectDataSet
    Friend WithEvents Tbl1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl1TableAdapter As CarsProjectVB.CarsProjectDataSetTableAdapters.Tbl1TableAdapter
    Private WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents Button5 As System.Windows.Forms.Button
    Private WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrceNamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MngmntNamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChekNamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChekDatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TirDatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BattryDatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttachsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSummary
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSummary))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnCompile = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.ComboBox()
        Me.btnCharts = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.cmbWeek = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.DGVRaws = New System.Windows.Forms.DataGridView()
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNwCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCVisits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCRet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBonus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRaws, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightClick.SuspendLayout()
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCompile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtYear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCharts)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbWeek)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbMonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTP)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1197, 507)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 3
        '
        'btnCompile
        '
        Me.btnCompile.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompile.ForeColor = System.Drawing.Color.Maroon
        Me.btnCompile.Location = New System.Drawing.Point(1030, 17)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(135, 49)
        Me.btnCompile.TabIndex = 12
        Me.btnCompile.Text = "COMPILE DATA"
        Me.btnCompile.UseVisualStyleBackColor = False
        '
        'txtYear
        '
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.txtYear.Location = New System.Drawing.Point(9, 44)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(147, 21)
        Me.txtYear.TabIndex = 11
        '
        'btnCharts
        '
        Me.btnCharts.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCharts.ForeColor = System.Drawing.Color.Maroon
        Me.btnCharts.Location = New System.Drawing.Point(889, 17)
        Me.btnCharts.Name = "btnCharts"
        Me.btnCharts.Size = New System.Drawing.Size(135, 49)
        Me.btnCharts.TabIndex = 10
        Me.btnCharts.Text = "LOAD CHART"
        Me.btnCharts.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.ForeColor = System.Drawing.Color.Maroon
        Me.btnLoad.Location = New System.Drawing.Point(802, 17)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 49)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "LOAD INFO"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Maroon
        Me.btnExport.Location = New System.Drawing.Point(1077, 17)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(114, 48)
        Me.btnExport.TabIndex = 9
        Me.btnExport.Text = "Export Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'cmbWeek
        '
        Me.cmbWeek.FormattingEnabled = True
        Me.cmbWeek.Items.AddRange(New Object() {"WEEK 1", "WEEK 2", "WEEK 3", "WEEK 4", "WEEK 5"})
        Me.cmbWeek.Location = New System.Drawing.Point(369, 44)
        Me.cmbWeek.Name = "cmbWeek"
        Me.cmbWeek.Size = New System.Drawing.Size(147, 21)
        Me.cmbWeek.TabIndex = 8
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbMonth.Location = New System.Drawing.Point(189, 44)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(147, 21)
        Me.cmbMonth.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SELECT DAY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SELECT WEEK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SELECT MONTH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ENTER YEAR"
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(578, 45)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(200, 20)
        Me.DTP.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DGVData)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DGVRaws)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ColChart)
        Me.SplitContainer2.Size = New System.Drawing.Size(1197, 425)
        Me.SplitContainer2.SplitterDistance = 548
        Me.SplitContainer2.TabIndex = 1
        '
        'DGVData
        '
        Me.DGVData.AllowUserToAddRows = False
        Me.DGVData.AllowUserToDeleteRows = False
        Me.DGVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVData.Location = New System.Drawing.Point(0, 0)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.ReadOnly = True
        Me.DGVData.RowHeadersVisible = False
        Me.DGVData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVData.Size = New System.Drawing.Size(548, 425)
        Me.DGVData.TabIndex = 0
        '
        'DGVRaws
        '
        Me.DGVRaws.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRaws.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVRaws.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRaws.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FCashier, Me.FNwCust, Me.FCVisits, Me.FCRet, Me.ColPercent, Me.ColPos, Me.ColBonus})
        Me.DGVRaws.ContextMenuStrip = Me.RightClick
        Me.DGVRaws.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVRaws.Location = New System.Drawing.Point(0, 0)
        Me.DGVRaws.MultiSelect = False
        Me.DGVRaws.Name = "DGVRaws"
        Me.DGVRaws.RowHeadersVisible = False
        Me.DGVRaws.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRaws.Size = New System.Drawing.Size(645, 425)
        Me.DGVRaws.TabIndex = 3
        '
        'RightClick
        '
        Me.RightClick.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.Size = New System.Drawing.Size(153, 48)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'ColChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.ColChart.ChartAreas.Add(ChartArea1)
        Me.ColChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.ColChart.Legends.Add(Legend1)
        Me.ColChart.Location = New System.Drawing.Point(0, 0)
        Me.ColChart.Name = "ColChart"
        Series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Series1.BorderColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "DrawingStyle=Emboss"
        Series1.Legend = "Legend1"
        Series1.Name = "Grade"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Me.ColChart.Series.Add(Series1)
        Me.ColChart.Size = New System.Drawing.Size(645, 425)
        Me.ColChart.TabIndex = 2
        '
        'FCashier
        '
        Me.FCashier.HeaderText = "Sales Clerk"
        Me.FCashier.Name = "FCashier"
        '
        'FNwCust
        '
        Me.FNwCust.HeaderText = "New Customers"
        Me.FNwCust.Name = "FNwCust"
        '
        'FCVisits
        '
        Me.FCVisits.HeaderText = "Customer Visitation"
        Me.FCVisits.Name = "FCVisits"
        '
        'FCRet
        '
        Me.FCRet.HeaderText = "Returns (GH¢)"
        Me.FCRet.Name = "FCRet"
        '
        'ColPercent
        '
        Me.ColPercent.HeaderText = "Percentage (%)"
        Me.ColPercent.Name = "ColPercent"
        '
        'ColPos
        '
        Me.ColPos.HeaderText = "Position"
        Me.ColPos.Name = "ColPos"
        '
        'ColBonus
        '
        Me.ColBonus.HeaderText = "Bonus (GH¢)"
        Me.ColBonus.Name = "ColBonus"
        '
        'FrmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 507)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSummary"
        Me.Text = "Summary of Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRaws, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightClick.ResumeLayout(False)
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGVData As System.Windows.Forms.DataGridView
    Friend WithEvents cmbWeek As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ColChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txtYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnCharts As System.Windows.Forms.Button
    Friend WithEvents btnCompile As System.Windows.Forms.Button
    Friend WithEvents DGVRaws As System.Windows.Forms.DataGridView
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FCashier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNwCust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCVisits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCRet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBonus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

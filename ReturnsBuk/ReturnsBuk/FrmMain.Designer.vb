<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.ColChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmbWeek = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVis = New System.Windows.Forms.TextBox()
        Me.txtCurStands = New System.Windows.Forms.TextBox()
        Me.txtRemOrEx = New System.Windows.Forms.TextBox()
        Me.txtWeeklyTag = New System.Windows.Forms.TextBox()
        Me.txtSunTot = New System.Windows.Forms.TextBox()
        Me.txtDRet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewCust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSalesClerk = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.DGVsummary = New System.Windows.Forms.DataGridView()
        Me.colFCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNewCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustVis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDRet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFieldCashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVsummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightClick.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbDay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ColChart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbWeek)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCurStands)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtRemOrEx)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtWeeklyTag)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSunTot)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDRet)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNewCust)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSalesClerk)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DTP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnChart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOk)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVsummary)
        Me.SplitContainer1.Size = New System.Drawing.Size(968, 684)
        Me.SplitContainer1.SplitterDistance = 320
        Me.SplitContainer1.TabIndex = 0
        '
        'cmbDay
        '
        Me.cmbDay.Enabled = False
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbDay.Location = New System.Drawing.Point(252, 41)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(53, 21)
        Me.cmbDay.TabIndex = 14
        '
        'ColChart
        '
        Me.ColChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ColChart.ChartAreas.Add(ChartArea1)
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        Me.ColChart.Legends.Add(Legend1)
        Me.ColChart.Location = New System.Drawing.Point(2, 392)
        Me.ColChart.Name = "ColChart"
        Me.ColChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.BorderColor = System.Drawing.Color.Green
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "DrawingStyle=Cylinder, LabelStyle=Bottom"
        Series1.Legend = "Legend1"
        Series1.Name = "Grade"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Me.ColChart.Series.Add(Series1)
        Me.ColChart.Size = New System.Drawing.Size(317, 300)
        Me.ColChart.TabIndex = 13
        '
        'cmbWeek
        '
        Me.cmbWeek.Enabled = False
        Me.cmbWeek.FormattingEnabled = True
        Me.cmbWeek.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbWeek.Location = New System.Drawing.Point(80, 41)
        Me.cmbWeek.Name = "cmbWeek"
        Me.cmbWeek.Size = New System.Drawing.Size(121, 21)
        Me.cmbWeek.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(207, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "DAYS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "WEEK NO."
        '
        'txtVis
        '
        Me.txtVis.Enabled = False
        Me.txtVis.Location = New System.Drawing.Point(149, 141)
        Me.txtVis.Name = "txtVis"
        Me.txtVis.Size = New System.Drawing.Size(122, 20)
        Me.txtVis.TabIndex = 4
        '
        'txtCurStands
        '
        Me.txtCurStands.Enabled = False
        Me.txtCurStands.Location = New System.Drawing.Point(139, 243)
        Me.txtCurStands.Name = "txtCurStands"
        Me.txtCurStands.Size = New System.Drawing.Size(132, 20)
        Me.txtCurStands.TabIndex = 7
        Me.txtCurStands.Visible = False
        '
        'txtRemOrEx
        '
        Me.txtRemOrEx.Enabled = False
        Me.txtRemOrEx.Location = New System.Drawing.Point(139, 311)
        Me.txtRemOrEx.Name = "txtRemOrEx"
        Me.txtRemOrEx.Size = New System.Drawing.Size(132, 20)
        Me.txtRemOrEx.TabIndex = 9
        Me.txtRemOrEx.Visible = False
        '
        'txtWeeklyTag
        '
        Me.txtWeeklyTag.Enabled = False
        Me.txtWeeklyTag.Location = New System.Drawing.Point(112, 281)
        Me.txtWeeklyTag.Name = "txtWeeklyTag"
        Me.txtWeeklyTag.Size = New System.Drawing.Size(161, 20)
        Me.txtWeeklyTag.TabIndex = 8
        Me.txtWeeklyTag.Text = "GH¢ 300,000"
        '
        'txtSunTot
        '
        Me.txtSunTot.Enabled = False
        Me.txtSunTot.Location = New System.Drawing.Point(110, 209)
        Me.txtSunTot.Name = "txtSunTot"
        Me.txtSunTot.Size = New System.Drawing.Size(161, 20)
        Me.txtSunTot.TabIndex = 6
        '
        'txtDRet
        '
        Me.txtDRet.Enabled = False
        Me.txtDRet.Location = New System.Drawing.Point(110, 175)
        Me.txtDRet.Name = "txtDRet"
        Me.txtDRet.Size = New System.Drawing.Size(161, 20)
        Me.txtDRet.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "CURRENT STANDINGS"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "REMAINING OR EXCESS"
        Me.Label6.Visible = False
        '
        'txtNewCust
        '
        Me.txtNewCust.Enabled = False
        Me.txtNewCust.Location = New System.Drawing.Point(110, 107)
        Me.txtNewCust.Name = "txtNewCust"
        Me.txtNewCust.Size = New System.Drawing.Size(161, 20)
        Me.txtNewCust.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "WEEKLY TARGET"
        '
        'cmbSalesClerk
        '
        Me.cmbSalesClerk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSalesClerk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSalesClerk.Enabled = False
        Me.cmbSalesClerk.FormattingEnabled = True
        Me.cmbSalesClerk.Items.AddRange(New Object() {"NSOHYEYA RUTH", "ANAFO LAWRENCIA", "ANINYIE JUSTINA", "NSOBILA VERA", "ATAGOLSAH RAHINATU", "YARO-KANO ZEENAT", "AKOLGO FLORENCE", "ISSAH VICTORIA", "AYAANE BRIDGET", "AYINE MONICA"})
        Me.cmbSalesClerk.Location = New System.Drawing.Point(92, 72)
        Me.cmbSalesClerk.Name = "cmbSalesClerk"
        Me.cmbSalesClerk.Size = New System.Drawing.Size(179, 21)
        Me.cmbSalesClerk.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SUM TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DAILY RETURNS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CUSTOMER VISITATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NEW CUSTOMERS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SALES CLERK"
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(11, 12)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(271, 20)
        Me.DTP.TabIndex = 0
        '
        'btnChart
        '
        Me.btnChart.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnChart.Enabled = False
        Me.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChart.Location = New System.Drawing.Point(211, 342)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(75, 44)
        Me.btnChart.TabIndex = 12
        Me.btnChart.Text = "VIEW CHART"
        Me.btnChart.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(109, 342)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 44)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Location = New System.Drawing.Point(7, 342)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 44)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK!"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'DGVsummary
        '
        Me.DGVsummary.AllowDrop = True
        Me.DGVsummary.AllowUserToAddRows = False
        Me.DGVsummary.AllowUserToDeleteRows = False
        Me.DGVsummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVsummary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVsummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVsummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFCashier, Me.colNewCust, Me.colCustVis, Me.colDRet})
        Me.DGVsummary.ContextMenuStrip = Me.RightClick
        Me.DGVsummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVsummary.Location = New System.Drawing.Point(0, 0)
        Me.DGVsummary.Name = "DGVsummary"
        Me.DGVsummary.ReadOnly = True
        Me.DGVsummary.RowHeadersVisible = False
        Me.DGVsummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVsummary.Size = New System.Drawing.Size(644, 684)
        Me.DGVsummary.TabIndex = 0
        '
        'colFCashier
        '
        Me.colFCashier.HeaderText = "Field Cashier"
        Me.colFCashier.Name = "colFCashier"
        Me.colFCashier.ReadOnly = True
        '
        'colNewCust
        '
        Me.colNewCust.HeaderText = "New Customers"
        Me.colNewCust.Name = "colNewCust"
        Me.colNewCust.ReadOnly = True
        '
        'colCustVis
        '
        Me.colCustVis.HeaderText = "Customer Visitation"
        Me.colCustVis.Name = "colCustVis"
        Me.colCustVis.ReadOnly = True
        '
        'colDRet
        '
        Me.colDRet.HeaderText = "Daily Returns"
        Me.colDRet.Name = "colDRet"
        Me.colDRet.ReadOnly = True
        '
        'RightClick
        '
        Me.RightClick.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.RightClick.Name = "RightClick"
        Me.RightClick.Size = New System.Drawing.Size(114, 26)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(968, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator, Me.AddFieldCashierToolStripMenuItem, Me.toolStripSeparator2, Me.AddUserToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(163, 6)
        '
        'AddFieldCashierToolStripMenuItem
        '
        Me.AddFieldCashierToolStripMenuItem.Enabled = False
        Me.AddFieldCashierToolStripMenuItem.Name = "AddFieldCashierToolStripMenuItem"
        Me.AddFieldCashierToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddFieldCashierToolStripMenuItem.Text = "Add Field Cashier"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Enabled = False
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Summary"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Enabled = False
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OptionsToolStripMenuItem.Text = "&Modify Records"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Enabled = False
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(113, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 708)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "Returns Buk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ColChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVsummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightClick.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmbSalesClerk As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents DGVsummary As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnChart As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtVis As System.Windows.Forms.TextBox
    Friend WithEvents txtSunTot As System.Windows.Forms.TextBox
    Friend WithEvents txtDRet As System.Windows.Forms.TextBox
    Friend WithEvents txtNewCust As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCurStands As System.Windows.Forms.TextBox
    Friend WithEvents txtRemOrEx As System.Windows.Forms.TextBox
    Friend WithEvents txtWeeklyTag As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents colFCashier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNewCust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustVis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDRet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbWeek As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AddFieldCashierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

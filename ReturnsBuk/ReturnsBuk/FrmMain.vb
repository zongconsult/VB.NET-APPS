Imports System.Data.OleDb

Public Class FrmMain
    'passing textbox values as variables
    Dim SumTotal As Double
    Dim DailyReturns As Double
    Dim CurStands As Double
    Dim WeeklyTag As Double = 450000
    Public AccessLevel As String = FrmLogin.AccessLevel

    Dim count As Integer = -1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmLogin.Close()
        If AccessLevel = "Relationship Officer" Then
            AddFieldCashierToolStripMenuItem.Enabled = True
        Else
            AddFieldCashierToolStripMenuItem.Enabled = False
        End If

        If AccessLevel = "Credit Officer" Then
            CustomizeToolStripMenuItem.Enabled = True
        Else
            CustomizeToolStripMenuItem.Enabled = False
        End If

        If AccessLevel = "Branch Manager" Then
            CustomizeToolStripMenuItem.Enabled = True
        Else
            CustomizeToolStripMenuItem.Enabled = False
        End If

        If AccessLevel = "Administrator" Then
            AddUserToolStripMenuItem.Enabled = True
            AddFieldCashierToolStripMenuItem.Enabled = True
            CustomizeToolStripMenuItem.Enabled = True
            OptionsToolStripMenuItem.Enabled = True
            ReportsToolStripMenuItem.Enabled = True

        Else
            AddUserToolStripMenuItem.Enabled = False
            AddFieldCashierToolStripMenuItem.Enabled = False
            CustomizeToolStripMenuItem.Enabled = False
            OptionsToolStripMenuItem.Enabled = False
            ReportsToolStripMenuItem.Enabled = False
        End If
        'connect to access database
        'connectAccess()
        cmbSalesClerk.SelectedIndex = 0
        cmbWeek.SelectedIndex = 0
        txtNewCust.Focus()

    End Sub

    Private Sub DGVsummary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVsummary.CellContentClick

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim index As Integer = cmbSalesClerk.SelectedIndex
        'set focus to combobox
        Try

            If count >= 9 Then
                cmbSalesClerk.Focus()
                MessageBox.Show("There exist only 10 Field Cashiers ", "List Is Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub

            Else
                'assign variables to textbox value
                SumTotal = Val(txtSunTot.Text)
                DailyReturns = Val(txtDRet.Text)
                CurStands = Val(txtCurStands.Text)
                'WeeklyTag = 450000
                'pass textbox contents to datgridview
                DGVsummary.Rows.Add(cmbSalesClerk.Text, Double.Parse(txtNewCust.Text), Double.Parse(txtVis.Text), Double.Parse(txtDRet.Text))
                'add daily sales to make the sum total of the day
                SumTotal = SumTotal + DailyReturns
                txtSunTot.Text = SumTotal
                'set current standings to sumtotal
                txtCurStands.Text = SumTotal
                count = count + 1
                cmbSalesClerk.SelectedIndex = cmbSalesClerk.SelectedIndex + 1

                cmbSalesClerk.Focus()
            End If

            'check if current standings is greater or less than weekly target
            If CurStands > WeeklyTag Then
                txtRemOrEx.Text = CurStands - WeeklyTag
            End If

            If CurStands < WeeklyTag Then
                txtRemOrEx.Text = CurStands - WeeklyTag
            End If
            If Val(txtRemOrEx.Text) < 0 Then
                txtRemOrEx.BackColor = Color.IndianRed

            Else
                'txtRemOrEx.ForeColor = Color.Black
                txtRemOrEx.BackColor = Color.LimeGreen

            End If

        Catch ex As Exception
            MessageBox.Show("There exist only 10 Field Cashiers ", "List Is Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            count = -1
        End Try


    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        DGVsummary.Rows.RemoveAt(DGVsummary.CurrentRow.Index)
    End Sub

    Private Sub cmbSalesClerk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSalesClerk.SelectedIndexChanged

    End Sub

    Private Sub DGVsummary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVsummary.KeyDown
        If e.KeyCode = Keys.Delete Then
            DELETEToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem.Click
        FrmSummary.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If DGVsummary.Rows.Count <= 0 Then

        Else


            Dim Mmonth As String
            'check if the data already exists in db
            Try
                'supposing data already exist display it exist else save
                'checking if subject already exist
                'checking to see whetherrecords with date,week, and day already exists            
                selectstring = "SELECT * FROM tblReturns WHERE [EDD Date]=#" & DTP.Value.Date & "#"
                Dim cmd As New OleDbCommand
                cmd.CommandText = selectstring
                cmd.Connection = accessConn
                Dim reader As OleDbDataReader
                reader = cmd.ExecuteReader
                While reader.Read() = True
                    MessageBox.Show("Info for " & DTP.Value.Date.ToLongDateString & " WEEK " & Me.cmbWeek.Text.ToUpper & " Already exist", "Cannot create duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End While
                For x As Integer = 0 To DGVsummary.Rows.Count - 1
                    Dim SalesClerk As String
                    Dim NCust As Integer
                    Dim visitation As Integer
                    Dim returns As Double
                    Dim WKStands As Double
                    SalesClerk = DGVsummary.Rows(x).Cells(0).Value
                    NCust = DGVsummary.Rows(x).Cells(1).Value
                    visitation = DGVsummary.Rows(x).Cells(2).Value
                    returns = DGVsummary.Rows(x).Cells(3).Value

                    'InsertAccessDB()

                    'insert statement
                    Dim InsertString As String = "INSERT INTO tblReturns ([EDD Year], [EDD Month], Week, [EDD Date], [Sales Clerk], [New Customers], [Visitation], Returns, [Weekly Standings]) values ([@EDD Year], [@EDD Month], @Week, [@EDD Date], [@Sales Clerk], [@New Customers], @Visitation, @Returns, [@Weekly Standings])"
                    Dim com As New OleDb.OleDbCommand(InsertString, Module_Init.accessConn)
                    com.Parameters.AddWithValue("@EDD Year", DTP.Value.Date.Year) 'replace com with public dbcom
                    com.Parameters.AddWithValue("@EDD Month", DTP.Value.Date.Month)
                    com.Parameters.AddWithValue("@Week", cmbWeek.SelectedIndex + 1)
                    com.Parameters.AddWithValue("@EDD Date", DTP.Value.Date)
                    com.Parameters.AddWithValue("@Sales Clerk", SalesClerk)
                    com.Parameters.AddWithValue("@New Customers", NCust)
                    com.Parameters.AddWithValue("@Visitation", visitation)
                    com.Parameters.AddWithValue("@Returns", returns)
                    com.Parameters.AddWithValue("@Weekly Standings", WKStands)
                    com.ExecuteNonQuery()
                    com.Dispose()
                Next
                'converting numeric representation of months to strings
                If DTP.Value.Month = 1 Then
                    Mmonth = "January"
                End If
                If DTP.Value.Month = 2 Then
                    Mmonth = "February"
                End If
                If DTP.Value.Month = 3 Then
                    Mmonth = "March"
                End If
                If DTP.Value.Month = 4 Then
                    Mmonth = "April"
                End If
                If DTP.Value.Month = 5 Then
                    Mmonth = "May"
                End If
                If DTP.Value.Month = 6 Then
                    Mmonth = "June"
                End If
                If DTP.Value.Month = 7 Then
                    Mmonth = "July"
                End If
                If DTP.Value.Month = 8 Then
                    Mmonth = "August"
                End If
                If DTP.Value.Month = 9 Then
                    Mmonth = "September"
                End If
                If DTP.Value.Month = 10 Then
                    Mmonth = "October"
                End If
                If DTP.Value.Month = 11 Then
                    Mmonth = "November"
                End If
                If DTP.Value.Month = 12 Then
                    Mmonth = "December"
                End If
                MessageBox.Show("RETURNS for " & Mmonth & " " & DTP.Value.Year & " WEEK " & cmbWeek.SelectedIndex + 1 & " Is Successfully Recorded", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.DGVData.DataTable.Clear()
                Me.btnSave.Enabled = False                
                cmbSalesClerk.SelectedIndex = 0
                count = -1
                btnChart.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MessageBox.Show("Something went wrong" & vbNewLine & "Try again", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                'MessageBox.Show(ex.Message)
                count = -1
            End Try

        End If


    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmModify.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChart.Click
        Try
            'Assign All values to 0
            Dim FC1 As Double = 0
            Dim FC2 As Double = 0
            Dim FC3 As Double = 0
            Dim FC4 As Double = 0
            Dim FC5 As Double = 0
            Dim FC6 As Double = 0
            Dim FC7 As Double = 0
            Dim FC8 As Double = 0
            Dim FC9 As Double = 0
            Dim FC10 As Double = 0
            ColChart.Series.Clear()
            ColChart.Series.Add("Returns")
            ColChart.Palette = DataVisualization.Charting.ChartColorPalette.BrightPastel
            ColChart.Series(0).CustomProperties = "DrawingStyle = Cylinder, LabelStyle = Bottom"
            'assigns all the grade marks to the grade variables
            FC1 = DGVsummary.Rows(0).Cells(3).Value
            FC2 = DGVsummary.Rows(1).Cells(3).Value
            FC3 = DGVsummary.Rows(2).Cells(3).Value
            FC4 = DGVsummary.Rows(3).Cells(3).Value
            FC5 = DGVsummary.Rows(4).Cells(3).Value
            FC6 = DGVsummary.Rows(5).Cells(3).Value
            FC7 = DGVsummary.Rows(6).Cells(3).Value
            FC8 = DGVsummary.Rows(7).Cells(3).Value
            FC9 = DGVsummary.Rows(8).Cells(3).Value
            FC10 = DGVsummary.Rows(9).Cells(3).Value
            Me.ColChart.Series("Grade").Points.AddXY("NSOYEYA RUTH", FC1)
            Me.ColChart.Series("Grade").Points.AddXY("ANAFO LAWRENCIA", FC2)
            Me.ColChart.Series("Grade").Points.AddXY("ANINYIE JUSTINA", FC3)
            Me.ColChart.Series("Grade").Points.AddXY("NSOBILA VERA", FC4)
            Me.ColChart.Series("Grade").Points.AddXY("ATAGOLSAH RAHINATU", FC5)
            Me.ColChart.Series("Grade").Points.AddXY("YARO-KANO ZEENAT", FC6)
            Me.ColChart.Series("Grade").Points.AddXY("AKOLGO FLORENCE", FC7)
            Me.ColChart.Series("Grade").Points.AddXY("ISSAH VICTORIA", FC8)
            Me.ColChart.Series("Grade").Points.AddXY("AYAANE BRIDGET", FC9)
            Me.ColChart.Series("Grade").Points.AddXY("AYINE MONICA", FC10)

            btnChart.Enabled = False
        Catch ex As Exception

        End Try



    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmMeterAbout.Show()
    End Sub

    Private Sub txtDRet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDRet.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk.PerformClick()
        End If
    End Sub

    Private Sub txtDRet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDRet.TextChanged

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub RightClick_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RightClick.Opening

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddFieldCashierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFieldCashierToolStripMenuItem.Click
        frmAddFC.Show()
    End Sub

    Private Sub DTP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP.ValueChanged
        DGVsummary.Rows.Clear()
        btnSave.Enabled = True

        cmbWeek.Enabled = True
        cmbDay.Enabled = True
        cmbSalesClerk.Enabled = True
        txtNewCust.Enabled = True
        txtVis.Enabled = True
        txtDRet.Enabled = True
        txtSunTot.Enabled = True
        txtRemOrEx.Enabled = True
        txtWeeklyTag.Enabled = True
        txtCurStands.Enabled = True

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        frmCreateUser.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FrmLogin2.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        btnSave.Enabled = False
        cmbWeek.Enabled = False
        cmbDay.Enabled = False
        cmbSalesClerk.Enabled = False
        txtNewCust.Enabled = False
        txtVis.Enabled = False
        txtDRet.Enabled = False
        txtSunTot.Enabled = False
        txtRemOrEx.Enabled = False
        txtWeeklyTag.Enabled = False
        txtCurStands.Enabled = False
        AddUserToolStripMenuItem.Enabled = False
        AddFieldCashierToolStripMenuItem.Enabled = False
        CustomizeToolStripMenuItem.Enabled = False
        OptionsToolStripMenuItem.Enabled = False
        ReportsToolStripMenuItem.Enabled = False
    End Sub
End Class

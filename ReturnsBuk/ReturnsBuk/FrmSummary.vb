Imports System.Data.OleDb

Public Class FrmSummary

    Private Sub FrmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connectAccess() 'connect to access database
        

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        Dim misValue As Object
        Try
            'create object of excel
            ExcelApp = CreateObject("Excel.Application")
            ExcelBook = ExcelApp.WorkBooks.Add
            ExcelSheet = ExcelBook.WorkSheets(1)
            misValue = System.Reflection.Missing.Value
            'ExcelApp = New 
            With ExcelSheet
                For i = 1 To DGVRaws.RowCount
                    .cells(i, 1) = DGVRaws.Rows(i - 1).Cells(0).Value
                    For j = 1 To DGVRaws.Columns.Count - 1
                        .cells(i, j + 1) = DGVRaws.Rows(i - 1).Cells(j).Value
                    Next
                Next
            End With
            ExcelApp.Visible = True
            ExcelApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.ToString)
        End Try
        ExcelSheet = Nothing
        ExcelApp = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'validating
        Dim err As New ErrorProvider
        Try
            If txtYear.Text = "" Then
                err.SetError(txtYear, "Required field")
                Exit Sub
            Else
                LoadData() 'load data based on Town & Community
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                LoadData()
            Else
                'nothing
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()
        End If
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If txtYear.Text = "" Then
            Dim err As New ErrorProvider
            err.SetError(txtYear, "required field")
            Exit Sub
        Else
            'nothing
            Err.Clear()

        End If
    End Sub

    Private Sub cmbWeek_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbWeek.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadData()
        End If
    End Sub

    Private Sub cmbWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWeek.SelectedIndexChanged
        If cmbMonth.Text = "" Then
            Dim err As New ErrorProvider
            err.SetError(cmbMonth, "required field")
            Exit Sub
        Else
            'nothing
            Err.Clear()
            ' LoadData()
        End If
    End Sub

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP.ValueChanged
        Try
            accessTable.Clear()
            'select using Year where month and week are null
            ' selectstring = "SELECT [EDD Year], [EDD Month], Week, [EDD Date], [Sales Clerk], [New Customers], Visitation, Returns FROM tblReturns WHERE [EDD Date]=#" & Trim(DTP.Value.Date) & "# order by Returns DESC"
            selectstring = "SELECT [Sales Clerk], [New Customers], Visitation, Returns FROM tblReturns WHERE [EDD Date]=#" & Trim(DTP.Value.Date) & "# order by Returns DESC"
            Dim adapter As New OleDbDataAdapter(selectstring, accessConn)
            adapter.Fill(accessTable)
            DGVData.DataSource = accessTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Something went wrong" & vbNewLine & "Try again", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DGVData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVData.CellContentClick

    End Sub

    Private Sub DGVData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVData.DoubleClick
        'capture the following fields into frmModify        
        'frmModify.Show()
        'frmModify.cmbSalesClerk.Text = DGVData.CurrentRow.Cells(4).Value 'sales clerk
        'frmModify.txtCustomer.Text = DGVData.CurrentRow.Cells(5).Value 'New Customers
        'frmModify.txtVis.Text = DGVData.CurrentRow.Cells(6).Value 'Visitation
        'frmModify.txtReturns.Text = DGVData.CurrentRow.Cells(7).Value 'Returns
        'EDD_Date = DGVData.CurrentRow.Cells(3).Value

        Try
            'capture the following fields into frmModify        
            frmModify.Show()
            frmModify.cmbSalesClerk.Text = DGVData.CurrentRow.Cells(0).Value 'sales clerk
            frmModify.txtCustomer.Text = DGVData.CurrentRow.Cells(1).Value 'New Customers
            frmModify.txtVis.Text = DGVData.CurrentRow.Cells(2).Value 'Visitation
            frmModify.txtReturns.Text = DGVData.CurrentRow.Cells(3).Value 'Returns
        Catch ex As Exception

        End Try



    End Sub

    Private Sub txtYear_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLoad.PerformClick()
        End If
    End Sub

    Private Sub txtYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.SelectedIndexChanged

    End Sub

    Private Sub btnCharts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharts.Click
        'first equate all values to Zero
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
        Try
            'assigns all the grade marks to the grade variables
            FC1 = DGVRaws.Rows(0).Cells(3).Value
            FC2 = DGVRaws.Rows(1).Cells(3).Value
            FC3 = DGVRaws.Rows(2).Cells(3).Value
            FC4 = DGVRaws.Rows(3).Cells(3).Value
            FC5 = DGVRaws.Rows(4).Cells(3).Value
            FC6 = DGVRaws.Rows(5).Cells(3).Value
            FC7 = DGVRaws.Rows(6).Cells(3).Value
            FC8 = DGVRaws.Rows(7).Cells(3).Value
            FC9 = DGVRaws.Rows(8).Cells(3).Value
            FC10 = DGVRaws.Rows(9).Cells(3).Value
            Me.ColChart.Series("Returns").Points.AddXY("NSOYEYA RUTH", FC1)
            Me.ColChart.Series("Returns").Points.AddXY("ANAFO LAWRENCIA", FC2)
            Me.ColChart.Series("Returns").Points.AddXY("ANINYIE JUSTINA", FC3)
            Me.ColChart.Series("Returns").Points.AddXY("NSOBILA VERA", FC4)
            Me.ColChart.Series("Returns").Points.AddXY("ATAGOLSAH RAHINATU", FC5)
            Me.ColChart.Series("Returns").Points.AddXY("YARO-KANO ZEENAT", FC6)
            Me.ColChart.Series("Returns").Points.AddXY("AKOLGO FLORENCE", FC7)
            Me.ColChart.Series("Returns").Points.AddXY("ISSAH VICTORIA", FC8)
            Me.ColChart.Series("Returns").Points.AddXY("AYAANE BRIDGET", FC9)
            Me.ColChart.Series("Returns").Points.AddXY("AYINE MONICA", FC10)
            ColChart.Visible = True
            ColChart.BringToFront()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DGVData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVData.SelectionChanged

    End Sub

    Private Sub btnCompile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompile.Click
        Me.ColChart.Hide()
        CompileData()

    End Sub


    Sub CompileData()


        'assign variables to each sales clerks visitation
        Dim FC1Vis As Double = 0
        Dim FC2Vis As Double = 0
        Dim FC3Vis As Double = 0
        Dim FC4Vis As Double = 0
        Dim FC5Vis As Double = 0
        Dim FC6Vis As Double = 0
        Dim FC7Vis As Double = 0
        Dim FC8Vis As Double = 0
        Dim FC9Vis As Double = 0
        Dim FC10Vis As Double = 0
        'assign Variables for each sales clerks new customers
        Dim FC1NewCust As Double = 0
        Dim FC2NewCust As Double = 0
        Dim FC3NewCust As Double = 0
        Dim FC4NewCust As Double = 0
        Dim FC5NewCust As Double = 0
        Dim FC6NewCust As Double = 0
        Dim FC7NewCust As Double = 0
        Dim FC8NewCust As Double = 0
        Dim FC9NewCust As Double = 0
        Dim FC10NewCust As Double = 0
        'assign variables to each sales clerk returns
        Dim FC1Returns As Double = 0
        Dim FC2Returns As Double = 0
        Dim FC3Returns As Double = 0
        Dim FC4Returns As Double = 0
        Dim FC5Returns As Double = 0
        Dim FC6Returns As Double = 0
        Dim FC7Returns As Double = 0
        Dim FC8Returns As Double = 0
        Dim FC9Returns As Double = 0
        Dim FC10Returns As Double = 0

        'Percentage
        Dim FC1Percent As Double = 0
        Dim FC2Percent As Double = 0
        Dim FC3Percent As Double = 0
        Dim FC4Percent As Double = 0
        Dim FC5Percent As Double = 0
        Dim FC6Percent As Double = 0
        Dim FC7Percent As Double = 0
        Dim FC8Percent As Double = 0
        Dim FC9Percent As Double = 0
        Dim FC10Percent As Double = 0

        'Position

        Dim FC1Position As Double = 0
        Dim FC2Position As Double = 0
        Dim FC3Position As Double = 0
        Dim FC4Position As Double = 0
        Dim FC5Position As Double = 0
        Dim FC6Position As Double = 0
        Dim FC7Position As Double = 0
        Dim FC8Position As Double = 0
        Dim FC9Position As Double = 0
        Dim FC10Position As Double = 0

        DGVRaws.Rows.Clear()
        Try

            For x As Integer = 0 To DGVData.Rows.Count - 1
                'performiong calculations
                'add all the returns of sales clerk 
                If DGVData.Rows(x).Cells(0).Value = "NSOHYEYA RUTH" Then
                    'new customers
                    FC1NewCust = FC1NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC1Vis = FC1Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC1Returns = FC1Returns + DGVData.Rows(x).Cells(3).Value

                ElseIf DGVData.Rows(x).Cells(0).Value = "ANAFO LAWRENCIA" Then
                    'new customers
                    FC2NewCust = FC2NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC2Vis = FC2Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC2Returns = FC2Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "ANINYIE JUSTINA" Then
                    'new customers
                    FC3NewCust = FC3NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC3Vis = FC3Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC3Returns = FC3Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "NSOBILA VERA" Then
                    'new customers
                    FC4NewCust = FC4NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC4Vis = FC4Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC4Returns = FC4Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "ATAGOLSAH RAHINATU" Then
                    'new customers
                    FC5NewCust = FC5NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC5Vis = FC5Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC5Returns = FC5Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "YARO-KANO ZEENAT" Then
                    'new customers
                    FC6NewCust = FC6NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC6Vis = FC6Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC6Returns = FC6Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "AKOLGO FLORENCE" Then
                    'new customers
                    FC7NewCust = FC7NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC7Vis = FC7Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC7Returns = FC7Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "ISSAH VICTORIA" Then
                    'new customers
                    FC8NewCust = FC8NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC8Vis = FC8Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC8Returns = FC8Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "AYAANE BRIDGET" Then
                    'new customers
                    FC9NewCust = FC9NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC9Vis = FC9Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC9Returns = FC9Returns + DGVData.Rows(x).Cells(3).Value
                ElseIf DGVData.Rows(x).Cells(0).Value = "AYINE MONICA" Then
                    'new customers
                    FC10NewCust = FC10NewCust + DGVData.Rows(x).Cells(1).Value
                    'visitation
                    FC10Vis = FC1Vis + DGVData.Rows(x).Cells(2).Value
                    'returns
                    FC10Returns = FC10Returns + DGVData.Rows(x).Cells(3).Value
                End If

            Next
            'POST ALL COMPLIED CALCULATIONS TO DGVRAWS THUS COMPILED DATAGRIDVIEW
            DGVRaws.Rows.Add("NSOHYEYA RUTH", FC1NewCust, FC1Vis, FC1Returns, FC1Percent, FC1Position)
            DGVRaws.Rows.Add("ANAFO LAWRENCIA", FC2NewCust, FC2Vis, FC2Returns, FC2Percent, FC2Position)
            DGVRaws.Rows.Add("ANINYIE JUSTINA", FC3NewCust, FC3Vis, FC3Returns, FC3Percent, FC3Position)
            DGVRaws.Rows.Add("NSOBILA VERA", FC4NewCust, FC4Vis, FC4Returns, FC4Percent, FC4Position)
            DGVRaws.Rows.Add("ATAGOLSAH RAHINATU", FC5NewCust, FC5Vis, FC5Returns, FC5Percent, FC5Position)
            DGVRaws.Rows.Add("YARO-KANO ZEENAT", FC6NewCust, FC6Vis, FC6Returns, FC6Percent, FC6Position)
            DGVRaws.Rows.Add("AKOLGO FLORENCE", FC7NewCust, FC7Vis, FC7Returns, FC7Percent, FC7Position)
            DGVRaws.Rows.Add("ISSAH VICTORIA", FC8NewCust, FC8Vis, FC8Returns, FC8Percent, FC8Position)
            DGVRaws.Rows.Add("AYAANE BRIDGET", FC9NewCust, FC9Vis, FC9Returns, FC9Percent, FC9Position)
            DGVRaws.Rows.Add("AYINE MONICA", FC10NewCust, FC10Vis, FC10Returns, FC10Percent, FC10Position)

            Dim bonus As Double

            For x As Integer = 0 To DGVRaws.Rows.Count - 1
                Dim scenario As Double = DGVRaws.Rows(x).Cells(3).Value

                'calculating bonus
                Select Case scenario
                    Case scenario = 0 To 35000
                        bonus = 0
                    Case scenario = 35001 To 50000
                        bonus = 50
                    Case scenario = 50001 To 60000
                        bonus = 70
                    Case scenario = 60001 To 80000
                        bonus = 80
                    Case scenario = 80001 To 100000
                        bonus = 90
                    Case scenario = 100001 To 150000
                        bonus = 100
                    Case scenario = 150001 To 200000
                        bonus = 110
                    Case scenario = 200001 To 250000
                        bonus = 130
                    Case scenario = 250001 To 300000
                        bonus = 150
                    Case scenario >= 300001
                        bonus = 200
                    Case Else
                        bonus = 0
                End Select

                DGVRaws.Rows(x).Cells(6).Value = bonus + (0.3 * DGVRaws.Rows(x).Cells(1).Value)
            Next

            Dim NCTotal, VSTotal, ReturnsTotal, BonusTotal As Double

            For x As Integer = 0 To DGVRaws.Rows.Count - 1
                ReturnsTotal = ReturnsTotal + DGVRaws.Rows(x).Cells(3).Value
            Next
            'Calculating Percentages
            Dim Percentage As Double
            For x As Integer = 0 To DGVRaws.Rows.Count - 1
                Percentage = (DGVRaws.Rows(x).Cells(3).Value / ReturnsTotal) * 100
                DGVRaws.Rows(x).Cells(4).Value = Math.Round(Percentage, 2)
            Next
            'claculating sums
            For x As Integer = 0 To DGVRaws.Rows.Count - 2
                NCTotal = NCTotal + DGVRaws.Rows(x).Cells(1).Value
                VSTotal = VSTotal + DGVRaws.Rows(x).Cells(2).Value
                ReturnsTotal = ReturnsTotal + DGVRaws.Rows(x).Cells(3).Value
                Percentage = Percentage + DGVRaws.Rows(x).Cells(4).Value
                BonusTotal = BonusTotal + DGVRaws.Rows(x).Cells(6).Value

            Next
            DGVRaws.Rows.Add("TOTAL", NCTotal, VSTotal, ReturnsTotal, Percentage, "", BonusTotal)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub llContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVRaws.CellContentClick

    End Sub

    Private Sub DGVRaws_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVRaws.DoubleClick
     
    End Sub

    Private Sub RightClick_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RightClick.Opening

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            DGVRaws.Rows.RemoveAt(DGVRaws.CurrentRow.Index)
        Catch ex As Exception

        End Try

    End Sub
End Class
'AccessDB Imports
Imports System.Data.OleDb
Module Module_Init    
    Public dbConStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BukDB.accdb;Jet OLEDB:Database Password=Yinpok18@2013"
    Public SecName, Strdbcon, strAccessDB, strSql, selectstring As String
    Public login, maxLimit, RecordID, LoginID As Integer
    'connection to accessDB
    'declarations
    Public accessConn As New OleDbConnection
    Public accessReader As OleDbDataReader
    Public accessDBCommand As New OleDbCommand
    Public accessTable As New DataTable
    Public EDD_Date As Date
    Dim Sales_Clerk As String
    Public Sub TransformerInfo()

    End Sub
    Sub connect()
        'Try
        '    dbConn.ConnectionString = "Data Source=" & Application.StartupPath & "\meterdb.db3;version=3;"
        '    dbConn.Open()
        'Catch ex As Exception
        '    MessageBox.Show("Pleases restart the application... " & vbNewLine & "If error persists contact +233200556605/244806484", "Application error", MessageBoxButtons.OK)
        'End Try
    End Sub
    Sub fillcmbItemName()
        'Try
        '    strSql = "SELECT Record FROM tblRecords order by Record ASC"
        '    dbcmd.CommandText = strSql
        '    dbcmd.Connection = dbConn
        '    dbReader = dbcmd.ExecuteReader
        '    While (dbReader.Read())
        '        Form.cmbRecords.Items.Add(dbReader("Record"))
        '    End While
        '    dbReader.Close()
        'Catch ex As Exception
        '    MsgBox("Error please try again", MsgBoxStyle.Exclamation)
        '    'Exit Sub
        'End Try

    End Sub
    Sub SelectRecord()
        'Try
        '    strSql = "select * from tblRecords where Record='" & Trim(Form.cmbRecords.SelectedItem) & "'"
        '    dbcmd.CommandText = strSql
        '    dbcmd.Connection = ModuleVariables.dbConn
        '    dbReader = dbcmd.ExecuteReader
        '    If (dbReader.Read()) Then
        '        RecordID = (dbReader("ID"))
        '        Form.txtUpdateRec.Text = (dbReader("Record"))
        '        Form.txtDeleteRec.Text = (dbReader("Record"))
        '        If IsDBNull((dbReader("Mobile"))) Then
        '            Form.txtMobile.Text = "____"
        '            Form.txtMobile.ForeColor = Color.DarkRed
        '        Else
        '            Form.txtMobile.Text = (dbReader("Mobile"))
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error please try again", MsgBoxStyle.Exclamation)
        'End Try
        'dbReader.Close()
    End Sub
    Sub getID_Date()

    End Sub

    Sub UpdateRecord()
        'Try
        '    strSql = "Update tblRecords SET Record='" & Trim(Form.txtUpdateRec.Text) & "', Mobile ='" & Trim(Form.txtMobile.Text) & "' where ID='" & RecordID & "'"
        '    dbcmd.CommandText = strSql
        '    dbcmd = New SQLiteCommand(strSql, dbConn)
        '    dbcmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox("Error please try again", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
    Sub connectAccess()
        Try
            accessConn.ConnectionString = dbConStr
            accessConn.Open()
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Pleases restart the application... " & vbNewLine & "If error persists contact +233200556605/244806484", "AccessDB Failure!", MessageBoxButtons.RetryCancel)
        End Try
    End Sub
    Sub InsertAccessDB()
        Try
            strAccessDB = "INSERT INTO tblReturns ([EDD Year], [EDD Month], Week, [EDD Date], [Sales Clerk], [New Customers], [Visitation], Returns, [Weekly Standings]) VALUES ('" & FrmMain.DTP.Value.Year & "','" & FrmMain.DTP.Value.Month & "','" & FrmMain.cmbWeek.SelectedItem & "','" _
                & FrmMain.DTP.Value.Date & "','" & FrmMain.cmbSalesClerk.Text & "','" & Val(FrmMain.txtNewCust.Text) & "','" & Val(FrmMain.txtVis.Text) & "','" & Val(FrmMain.txtDRet.Text) & "','" & Val(FrmMain.txtCurStands.Text) & "')"
            accessDBCommand = New OleDbCommand(strAccessDB, accessConn)
            accessDBCommand.ExecuteNonQuery()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            MessageBox.Show("Please try again", "error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub LoadData()
        accessTable.Clear()
        Try

            'select using Year where month and week are null
            If Not Trim(FrmSummary.txtYear.Text) = "" And Not Trim(FrmSummary.cmbMonth.Text) = "" And Not Trim(FrmSummary.cmbWeek.Text) = "" Then
                selectstring = "SELECT [Sales Clerk], [New Customers], [Visitation], Returns,[EDD Date] FROM tblReturns WHERE [EDD Year]=" _
                 & Val(FrmSummary.txtYear.Text) & " AND [EDD Month]=" & (FrmSummary.cmbMonth.SelectedIndex) + 1 & " AND Week=" & (FrmSummary.cmbWeek.SelectedIndex) + 1 & " order by [EDD Month], [Week], [EDD Date] DESC;"

                'select using month and Year
            ElseIf Not (FrmSummary.txtYear.Text) = "" And Not (FrmSummary.cmbMonth.Text) = "" Then
                selectstring = "SELECT [Sales Clerk], [New Customers], [Visitation], Returns,[EDD Date] FROM tblReturns WHERE [EDD Year]=" _
                 & Trim(FrmSummary.txtYear.Text) & " AND [EDD Month]=" & (FrmSummary.cmbMonth.SelectedIndex) + 1 & " order by [EDD Year], [EDD Month], Week DESC;"  'order by month 1 - 12, week 1 - 2, date 1 - 31

                'select using Year, month, week
            ElseIf Not Trim(FrmSummary.txtYear.Text) = "" And FrmSummary.cmbWeek.Text = "" Then
                selectstring = "SELECT [Sales Clerk], [New Customers], [Visitation], Returns,[EDD Date] FROM tblReturns WHERE [EDD Year]=" _
                 & Val(FrmSummary.txtYear.Text) & " order by [EDD Month], [Week], [EDD Date] DESC;"

            Else
                MessageBox.Show("Enter at least one field", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            Dim adapter As New OleDbDataAdapter(selectstring, accessConn)
            adapter.Fill(accessTable)
            FrmSummary.DGVData.DataSource = accessTable
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
            MessageBox.Show("Something went wrong" & vbNewLine & "Try again", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Sub UpdateSalesClerk()
        'Try
        '    accessDBCommand.Connection = accessConn
        '    accessDBCommand.CommandText = "UPDATE tblReturns SET [New Customers]=?, Visitation=?, Returns=? WHERE [@EDD Date]=? And [@Sales Clerk]=?"
        '    'accessDBCommand.Parameters.AddWithValue("@Sales Clerk", frmModify.cmbSalesClerk.Text)
        '    accessDBCommand.Parameters.AddWithValue("@New Customers", Val(frmModify.txtCustomer.Text))
        '    accessDBCommand.Parameters.AddWithValue("@Visitation", Val(frmModify.txtVis.Text))
        '    accessDBCommand.Parameters.AddWithValue("@Returns", Val(frmModify.txtReturns.Text))
        '    accessDBCommand.Parameters.AddWithValue("@EDD Date", EDD_Date)
        '    accessDBCommand.Parameters.AddWithValue("@Sales Clerk", frmModify.cmbSalesClerk.Text.ToString)

        '    accessDBCommand.ExecuteNonQuery()
        '    accessDBCommand.Parameters.Clear()
        '    frmModify.lblNewCust.Text = frmModify.txtCustomer.Text
        '    frmModify.lblVis.Text = frmModify.txtVis.Text
        '    frmModify.lblReturns.Text = frmModify.txtReturns.Text
        '    frmModify.lblNotify.Text = "Update Successful!!"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        MessageBox.Show("Please logins as Administrator to modify records", "User Error", MessageBoxButtons.AbortRetryIgnore)

    End Sub
    Sub LoadLast()
        '    Try
        '        strSql = "SELECT TOP 1 * FROM Transformer ORDER BY ID DESC" 'get the SQL Query for last index
        '        accessDBCommand.CommandText = strSql
        '        'Dim accessConn As New OleDbConnection
        '        accessDBCommand.Connection = accessConn
        '        accessReader = accessDBCommand.ExecuteReader
        '        While (accessReader.Read())
        '            RecordID = (accessReader(0))
        '            Region = (accessReader(1))
        '            Project = (accessReader(2))
        '            Town = (accessReader(3))
        '            Community = (accessReader(4))
        '            Contractor = (accessReader(5))
        '            SerialNo = (accessReader(6))
        '            Transformer_Rating = (accessReader(7))
        '            Primary_Voltage = (accessReader(8))
        '            Sec_Voltage = (accessReader(9))
        '            VectorGrp = (accessReader(11))
        '            MountType = (accessReader(11))
        '            Year_of_Manufacture = (accessReader(12))
        '            Manufacturer = (accessReader(13))
        '            Date_of_Testing = (accessReader(14))
        '            Date_of_Commissioning = (accessReader(15))
        '            HV_LV_Level = (accessReader(16))
        '            Oil_Level = (accessReader(17))
        '            Paint_Work = (accessReader(18))
        '            Tap_Position = (accessReader(19))
        '            Voltage_Red_Neutral = (accessReader(20))
        '            Voltage_Yellow_Neutral = (accessReader(21))
        '            Voltage_Blue_Neutral = (accessReader(22))
        '            Voltage_Red_Yellow = (accessReader(23))
        '            Voltage_Red_Blue = (accessReader(24))
        '            Voltage_Yellow_Blue = (accessReader(25))
        '            TotalWeight = (accessReader(26))
        '            CurrentRatio = (accessReader(27))
        '            Impedence = (accessReader(28))
        '            MessageBox.Show("Last Saved Record = " & RecordID & " items" & vbNewLine & vbNewLine & Region & vbNewLine & Project & vbNewLine & Town & vbNewLine & Community & vbNewLine & Contractor & _
        '            SerialNo & vbNewLine & Transformer_Rating & vbNewLine & Primary_Voltage & vbNewLine & Sec_Voltage & vbNewLine & _
        '            VectorGrp & vbNewLine & MountType & vbNewLine & Year_of_Manufacture & vbNewLine & Manufacturer & vbNewLine & _
        '            Date_of_Testing & vbNewLine & Date_of_Commissioning & vbNewLine & HV_LV_Level & vbNewLine & Oil_Level & vbNewLine & Paint_Work & vbNewLine & Tap_Position & vbNewLine & Voltage_Red_Neutral & vbNewLine & Voltage_Yellow_Neutral & vbNewLine & Voltage_Blue_Neutral & vbNewLine & Voltage_Red_Yellow & vbNewLine & Voltage_Red_Blue & vbNewLine & Voltage_Yellow_Blue & vbNewLine & TotalWeight & vbNewLine & CurrentRatio & vbNewLine & Impedence
        '            )
        '            FrmMain.lblSubStation.Text = Town
        '            FrmMain.lblSerial.Text = SerialNo
        '            FrmMain.lblProject.Text = Project
        '            FrmMain.lblManufacturer.Text = Manufacturer
        '            FrmMain.lblCommunity.Text = Community
        '            FrmMain.lblContractor.Text = Contractor

        '        End While
        '    Catch ex As Exception
        '        MsgBox("Error please try again", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    End Try
        '    accessReader.Close()
    End Sub
    Sub DeleteID()
        'Try
        '    RecordID = Val(FrmMain.DGVData.CurrentRow.Cells(0).Value)
        '    strSql = "DELETE FROM Transformer WHERE ID=" & RecordID & ""
        '    accessDBCommand.CommandText = strSql
        '    accessDBCommand.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox("Error please try again", MsgBoxStyle.Exclamation)
        'End Try

    End Sub

    Sub compareReturns()
        'year1 = Val(Me.cmbFset.Text) 'set 1st year to year selected on cmbFset
        'year2 = Val(cmbSset.Text) 'set 2nd year to cmb year selected cmbSset
        ''SetA = Val(Me.cmbFset.Text) 'set 1st year to year selected on cmbFset
        ''SetB = Val(cmbSset.Text) 'set 2nd year to cmb year selected cmbSset
        'Table.Columns.Clear() 'clears the columns
        ''when there table contains columns already

        ''else create new columns
        'Table.Columns.AddRange(New DataColumn() {New DataColumn("Subject", GetType(System.String)), New DataColumn("Grade", GetType(System.String)), _
        '                           New DataColumn(year1.ToString, GetType(System.Double)), New DataColumn(year2, GetType(System.Double)), New DataColumn("Summary", GetType(System.Double)), New DataColumn("% Summary", GetType(System.String))})
        ''sets the data source to the created table that has the columns Test performed and test results
        'DGVData.DataSource = Table
        ''sets the datagrid datasource to the binding source
        'DGVSummary.DataSource = Table


        ''error handling
        'If Me.cmbFset.Text = cmbSset.Text Then
        '    MessageBox.Show("Something went wrong" & vbNewLine & "Please make sure academic years are not the same", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If

        'If Not cmbFSubject.Text = cmbSsubject.Text Then
        '    MessageBox.Show("Something went wrong" & vbNewLine & "Please make sure subjects are the same", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If
        ' ''calculates for only academic
        ''If Me.cmbFSubject.Text = "" And Me.cmbSsubject.Text = "" Then

        ''    Try
        ''        If DGVSummary.Rows.Count > 1 Then
        ''            Dim cout As Integer = DGVSummary.Rows.Count
        ''            'we conunt the rows oin the datagrid
        ''            For rm As Integer = 0 To DGVSummary.Rows.Count
        ''                cout = cout - 1
        ''                If cout < 0 Then             
        ''                    'do nothing
        ''                    Exit Sub
        ''                End If
        ''                DGVSummary.Rows.RemoveAt(rm)
        ''                rm = rm - 1 'to keep deleting the first row
        ''            Next
        ''        Else
        ''            'DGVSummary.Visible = True
        ''            Dim v2 As Integer
        ''            Dim Grade As String
        ''            Dim x As Integer
        ''            For x = 0 To DGVFset.Rows.Count - 1
        ''                ' Dim v1 As String
        ''                Grade = DGVFset.Rows(x).Cells(1).Value
        ''                v2 = DGVFset.Rows(x).Cells(2).Value                        
        ''                DGVData.DataTable.Rows.Add(New Object() {Grade, v2, DBNull.Value, DBNull.Value})
        ''            Next
        ''            'checking a value from C4
        ''            Dim rc As Integer = 0 'used to count the rows in DGVSset
        ''            Dim sumtotal As Integer 'total of students to calculate percentage
        ''            For z = 0 To DGVSummary.Rows.Count - 1
        ''                'equate the values in the Sset with the 3rd column cells in DGVSummary
        ''                DGVSummary.Rows(z).Cells(2).Value = DGVSset.Rows(rc).Cells(2).Value.ToString
        ''                'subtracting values
        ''                DGVSummary.Rows(z).Cells(3).Value = Double.Parse(DGVSummary.Rows(z).Cells(2).Value) - Double.Parse(DGVSummary.Rows(z).Cells(1).Value)
        ''                'if - color field red
        ''                'if positive color field green
        ''                'if the same color field blue
        ''                If DGVSummary.Rows(z).Cells(3).Value < 0 Then
        ''                    DGVSummary.Rows(z).Cells(3).Style.BackColor = Color.Red
        ''                    DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Red
        ''                ElseIf DGVSummary.Rows(z).Cells(2).Value > DGVSummary.Rows(z).Cells(1).Value Then
        ''                    'when there is and increase color it green
        ''                    DGVSummary.Rows(z).Cells(3).Style.BackColor = Color.Green
        ''                    DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Green
        ''                    '                    ElseIf DGVSummary.Rows(z).Cells(3).Style.BackColor = Color.Blue Then
        ''                ElseIf DGVSummary.Rows(z).Cells(2).Value = DGVSummary.Rows(z).Cells(1).Value Then
        ''                    'color of cell is blue
        ''                    DGVSummary.Rows(z).Cells(3).Style.BackColor = Color.Blue
        ''                    DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Blue
        ''                End If
        ''                'creating percentages
        ''                'c5=(c2+c3)/c4 * 100
        ''                Dim a, b, c As Double
        ''                a = DGVSummary.Rows(z).Cells(1).Value
        ''                b = DGVSummary.Rows(z).Cells(2).Value
        ''                c = DGVSummary.Rows(z).Cells(3).Value
        ''                sumtotal = (c / (a + b)) * 100
        ''                DGVSummary.Rows(z).Cells(4).Value = sumtotal
        ''                'increase the umber of count by one for the next value in DGVSset
        ''                rc = rc + 1
        ''            Next
        ''            DGVData.MoveNext()
        ''            lblDesc.Text = "Below is a summary of your selection " & vbNewLine & lblAcad_Sub1.Text & " Against " & lblAcad_Sub2.Text
        ''            lblDesc.Visible = True
        ''        End If
        ''    Catch ex As Exception
        ''        MessageBox.Show("Something went wrong" & vbNewLine & "Try again", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ''        ' Me.total = 0
        ''    End Try

        ''Else
        ''if subject is also selected comapre the subject
        'Try
        '    If DGVSummary.Rows.Count > 1 Then
        '        Dim cout As Integer
        '        'we conunt the rows oin the datagrid
        '        For rm As Integer = 0 To DGVSummary.Rows.Count
        '            cout = cout + 1
        '            If cout = 9 Then
        '                'remove the last row and exit the code
        '                DGVSummary.Rows.RemoveAt(rm)
        '                'do nothing
        '                Exit Sub
        '            End If
        '            DGVSummary.Rows.RemoveAt(rm)
        '            rm = rm - 1 'to keep deleting the first row
        '        Next
        '    Else
        '        'DGVSummary.Visible = True
        '        Dim Grade As String
        '        Dim x, v2 As Integer
        '        For x = 0 To DGVFset.Rows.Count - 1
        '            ' Dim v1 As String
        '            'subject
        '            Subject = cmbFSubject.Text
        '            v2 = DGVFset.Rows(x).Cells(1).Value
        '            Grade = DGVFset.Rows(x).Cells(0).Value
        '            DGVData.DataTable.Rows.Add(New Object() {Subject, Grade, v2, DBNull.Value, DBNull.Value, DBNull.Value})
        '        Next
        '        'checking a value from C4
        '        Dim rc As Integer = 0 'used to count the rows in DGVSset
        '        Dim sumtotal As Integer 'total of students to calculate percentage
        '        For z = 0 To DGVSummary.Rows.Count - 1
        '            'equate the values in the Sset with the 3rd column cells in DGVSummary
        '            DGVSummary.Rows(z).Cells(3).Value = DGVSset.Rows(rc).Cells(1).Value.ToString
        '            'subtracting values
        '            DGVSummary.Rows(z).Cells(4).Value = Double.Parse(DGVSummary.Rows(z).Cells(3).Value) - Double.Parse(DGVSummary.Rows(z).Cells(2).Value)
        '            'if - color field red
        '            'if positive color field green
        '            'if the same color field blue
        '            If DGVSummary.Rows(z).Cells(4).Value < 0 Then
        '                DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Red
        '                DGVSummary.Rows(z).Cells(5).Style.BackColor = Color.Red
        '            ElseIf DGVSummary.Rows(z).Cells(3).Value > DGVSummary.Rows(z).Cells(2).Value Then
        '                'when there is and increase color it green
        '                DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Green
        '                DGVSummary.Rows(z).Cells(5).Style.BackColor = Color.Green
        '                '                    ElseIf DGVSummary.Rows(z).Cells(3).Style.BackColor = Color.Blue Then

        '            ElseIf DGVSummary.Rows(z).Cells(3).Value = DGVSummary.Rows(z).Cells(2).Value Then
        '                'color of cell is blue
        '                DGVSummary.Rows(z).Cells(4).Style.BackColor = Color.Blue
        '                DGVSummary.Rows(z).Cells(5).Style.BackColor = Color.Blue
        '            End If
        '            'creating percentages
        '            'c6=(c3+c4)/c5 * 100
        '            Dim a, b, c As Double
        '            a = DGVSummary.Rows(z).Cells(2).Value
        '            b = DGVSummary.Rows(z).Cells(3).Value
        '            c = DGVSummary.Rows(z).Cells(4).Value
        '            sumtotal = (c / (a + b)) * 100
        '            DGVSummary.Rows(z).Cells(5).Value = sumtotal & "%"
        '            'increase the umber of count by one for the next value in DGVSset
        '            rc = rc + 1
        '        Next
        '        DGVData.MoveNext()
        '        lblDesc.Text = "Below is a summary of your selection " & vbNewLine & lblAcad_Sub1.Text & " Against " & lblAcad_Sub2.Text
        '        lblDesc.Visible = True
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Something went wrong" & vbNewLine & "Try again", "Ooops!!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    ' Me.total = 0
        'End Try
        ''  End If
    End Sub
End Module


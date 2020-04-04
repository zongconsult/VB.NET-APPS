Imports System.Data.OleDb
'Imports System.Data.SqlClient

Public Class FrmLogin
    Dim CW As Integer = Me.Width 'gets the width of the form
    Dim CH As Integer = Me.Height 'get the height of the form
    'Public repOfficer As String
    Dim firstName As String
    Public AccessLevel As String

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load    
        'Me.CenterToScreen()
        'Me.WindowState = FormWindowState.Maximized
        Dim x, y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.Location = New Point(x, y)
        'ConState() 'checks connection state
        connectAccess()
    End Sub
    Sub loginmen()
        Try
            Dim da As OleDbDataAdapter
            ' Dim strSQL As String
            Dim ds As DataSet
            selectstring = "SELECT tblUsers.FirstName FROM tblUsers WHERE (tblUsers.UserName = '" & (Me.txtUsername.Text) & "' And tblUsers.UserPass = '" & (Me.txtPassword.Text) & "');"
            da = New OleDbDataAdapter(selectstring, Module_Init.accessConn)
            ds = New DataSet
            da.Fill(ds, "tblUsers")
            For Each rowTest In ds.Tables(0).Rows
                firstName = rowTest("FirstName").ToString
            Next


            Try
                Dim dbcmd As New OleDbCommand
                Dim dbreader As OleDbDataReader
                strSql = "select AccessLevel from tblUsers where UserName='" & Trim(txtUsername.Text.ToString) & "'"
                dbcmd.CommandText = strSql
                dbcmd.Connection = Module_Init.accessConn
                dbReader = dbcmd.ExecuteReader
                If (dbReader.Read()) Then
                    AccessLevel = (dbreader("AccessLevel"))
                End If
            Catch ex As Exception
                MsgBox("Error please try again", MsgBoxStyle.Exclamation)
            End Try


            If firstName <> "" Then
                MessageBox.Show("WELCOME!!! " & firstName.ToUpper & vbNewLine & Date.Today.ToLongDateString, "Login Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'clear login data
                Me.txtUsername.Clear()
                Me.txtPassword.Clear()
                Me.txtUsername.Focus()
                'frmmain.btnLAtt.Enabled = True
                FrmMain.Show()
            Else
                MessageBox.Show("check user name and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPassword.Focus()
            End If

        Catch ex As Exception
            'ex.ToString()
        End Try
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        Label3.Visible = True
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            'show error if the username and password fields are empty
            If Me.txtUsername.Text = "" Then
                Me.ErrorProvider.SetError(Me.txtPassword, "Required Field")
                Exit Sub
            End If
            If Me.txtPassword.Text = "" Then
                Me.ErrorProvider.SetError(Me.txtPassword, "Required Field")
                Exit Sub
            End If
            'executes login name
            loginmen() 'load the login sub
        End If
        
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        Label3.Visible = False
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub FrmLogin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CW = Me.Width
        CH = Me.Height
        If Me.Width <= 406 And Me.Height <= 199 Then
            Me.Width = 406
            Me.Height = 199

        ElseIf Me.Width > 406 Then
            Me.Width = 406

        ElseIf Me.Height > 199 Then
            Me.Height = 199
        End If
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        Me.Label4.Visible = True
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            'show an error when empty
            If Me.txtPassword.Text = "" Then
                Me.ErrorProvider.SetError(Me.txtPassword, "Required Field")
                Me.txtPassword.Focus()
                Exit Sub
            Else
                'executes login name
                loginmen()
            End If
        End If
    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        Me.Label4.Visible = False
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        loginmen()
    End Sub
End Class
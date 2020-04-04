Imports System.Data.OleDb
Public Class FrmLogin2
    Dim dbcmd As New OleDbCommand
    Dim dbreader As OleDbDataReader
    Dim firstname As String
    Public AccessLevel As String
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login2()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Sub login2()
        Try
            Dim da As OleDbDataAdapter
            ' Dim strSQL As String
            Dim ds As DataSet
            selectstring = "SELECT tblUsers.FirstName FROM tblUsers WHERE (tblUsers.UserName = '" & (Me.txtUsername.Text) & "' And tblUsers.UserPass = '" & (Me.txtPassword.Text) & "');"
            da = New OleDbDataAdapter(selectstring, Module_Init.accessConn)
            ds = New DataSet
            da.Fill(ds, "tblUsers")
            For Each rowTest In ds.Tables(0).Rows
                firstname = rowTest("FirstName").ToString
            Next
            Try

                strSql = "select AccessLevel from tblUsers where UserName='" & Trim(txtUsername.Text.ToString) & "'"
                dbcmd.CommandText = strSql
                dbcmd.Connection = Module_Init.accessConn
                dbreader = dbcmd.ExecuteReader
                If (dbreader.Read()) Then
                    AccessLevel = (dbreader("AccessLevel"))
                End If
                dbreader.Close()
            Catch ex As Exception
                MsgBox("Error please try again", MsgBoxStyle.Exclamation)
                ' MessageBox.Show(ex.ToString())
            End Try


            If firstname <> "" Then
                MessageBox.Show("WELCOME!!! " & firstname.ToUpper & vbNewLine & Date.Today.ToLongDateString, "Login Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'clear login data
                Me.txtUsername.Clear()
                Me.txtPassword.Clear()
                Me.txtUsername.Focus()
                If AccessLevel = "Relationship Officer" Then
                    FrmMain.AddFieldCashierToolStripMenuItem.Enabled = True
                Else
                    FrmMain.AddFieldCashierToolStripMenuItem.Enabled = False
                End If

                If AccessLevel = "Credit Officer" Then
                    FrmMain.CustomizeToolStripMenuItem.Enabled = True
                Else
                    FrmMain.CustomizeToolStripMenuItem.Enabled = False
                End If

                If AccessLevel = "Branch Manager" Then
                    FrmMain.CustomizeToolStripMenuItem.Enabled = True
                Else
                    FrmMain.CustomizeToolStripMenuItem.Enabled = False
                End If

                If AccessLevel = "Administrator" Then
                    FrmMain.AddUserToolStripMenuItem.Enabled = True
                    FrmMain.AddFieldCashierToolStripMenuItem.Enabled = True
                    FrmMain.CustomizeToolStripMenuItem.Enabled = True
                    FrmMain.OptionsToolStripMenuItem.Enabled = True
                    FrmMain.ReportsToolStripMenuItem.Enabled = True

                Else
                    FrmMain.AddUserToolStripMenuItem.Enabled = False
                    FrmMain.AddFieldCashierToolStripMenuItem.Enabled = False
                    FrmMain.CustomizeToolStripMenuItem.Enabled = False
                    FrmMain.OptionsToolStripMenuItem.Enabled = False
                    FrmMain.ReportsToolStripMenuItem.Enabled = False
                End If
                Me.Close()
            Else
                MessageBox.Show("check user name and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPassword.Focus()
            End If

        Catch ex As Exception
            'ex.ToString()
        End Try
    End Sub
End Class
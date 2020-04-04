Imports System.Data.OleDb
Public Class frmAddFC
    Private Sub frmCreateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'placeat bottom left
        Dim x, y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Height
        Location = New Point(x, y)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim strSQL As String
            Dim objCmd As New OleDbCommand
            strSQL = "INSERT INTO tblFieldCashiers ([FIRST NAME], [UNIQUE ID], ROUTE, [RELATION OFFICER]) VALUES ('" & (txtFirstName.Text) & "', '" & (txtUnique.Text) & "','" & (txtRoute.Text) & "','" & (txtOfficer.Text) & "');"
            objCmd = New OleDbCommand(strSQL, accessConn)
            objCmd.ExecuteNonQuery()
            MessageBox.Show(txtFirstName.Text + " is successfully REGISTERED!")
            'clear data
            txtFirstName.Text = ""
            txtUnique.Text = ""
            txtRoute.Text = ""
            txtOfficer.Text = ""
            txtFirstName.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class

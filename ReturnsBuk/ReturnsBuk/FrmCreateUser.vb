Imports System.Data.OleDb
Public Class frmCreateUser
    Private Sub frmCreateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'placeat bottom left
        Dim x, y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Height
        Location = New Point(x, y)
        cmbAccType.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not txtPassword.Text.ToString = txtConfirmPassword.Text.ToString Then
            Dim err As New ErrorProvider
            err.SetError(txtConfirmPassword, "Passwords do not match")
            Exit Sub
        Else

            Try
                Dim strSQL As String
                Dim objCmd As New OleDbCommand
                strSQL = "INSERT INTO tblUsers (FirstName, UserName, UserPass, AccessLevel) VALUES ('" & (txtFirstName.Text) & "', '" & (txtUserName.Text) & "','" & (txtPassword.Text) & "','" & (cmbAccType.SelectedItem) & "');"
                objCmd = New OleDbCommand(strSQL, accessConn)
                objCmd.ExecuteNonQuery()
                MessageBox.Show(txtUserName.Text + " is successfully registered As " & cmbAccType.SelectedItem.ToString.ToUpper & vbNewLine & " Please login To Continue...", "User " & txtUserName.Text.ToUpper & " created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'clear data
                txtFirstName.Text = ""
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtConfirmPassword.Text =
                txtFirstName.Focus()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class

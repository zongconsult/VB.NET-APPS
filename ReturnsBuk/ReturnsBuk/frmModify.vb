Public Class frmModify

    Private Sub frmModify_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim err As New ErrorProvider
        If Trim(cmbSalesClerk.Text) = "" Then
            err.SetError(cmbSalesClerk, "Required field")
        ElseIf Trim(txtCustomer.Text) = "" Then
            err.SetError(txtCustomer, "Required field")
        ElseIf Trim(txtVis.Text) = "" Then
            err.SetError(txtVis, "Required field")
        ElseIf Trim(txtReturns.Text) = "" Then
            err.SetError(txtReturns, "Required field")
        Else
            UpdateSalesClerk()
            'clear fields
            txtCustomer.Clear()
            txtReturns.Clear()
            txtVis.Clear()
        End If
    End Sub

    Private Sub OverviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverviewToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub txtMeterNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReturns.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub txtMeterNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturns.TextChanged

    End Sub

    Private Sub cmbSalesClerk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSalesClerk.SelectedIndexChanged
        SelectRecord()
    End Sub
End Class
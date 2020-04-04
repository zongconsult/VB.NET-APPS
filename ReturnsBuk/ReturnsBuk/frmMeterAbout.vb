Public Class frmMeterAbout

    Private Sub frmMeterAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub

    Private Sub frmMeterAbout_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Close()
    End Sub
End Class
Public Class frmPrincipal
    Private Sub RegistrarReservaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarReservaciónToolStripMenuItem.Click
        Dim frmReservacion As New frmReservaciones
        frmReservacion.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frmDetalle As New frmDetalleReservaciones
        frmDetalle.Show()
    End Sub
End Class
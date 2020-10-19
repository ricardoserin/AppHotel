Public Class frmPrincipal
    Private Sub RegistrarReservaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarReservaciónToolStripMenuItem.Click
        Dim frmReservacion As New frmReservaciones
        frmReservacion.Show()
    End Sub
End Class
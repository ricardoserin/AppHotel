Imports Capa_Negocios
Imports Capa_Entidad
Public Class frmDetalleReservaciones
    Private Sub frmDetalleReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrid1.DataSource = ReservacionHabLN.listar_detalle().Tables(0)
    End Sub
End Class
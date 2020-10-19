Imports Capa_Entidad
Imports Capa_AccesoDatos
Public Class ReservacionHabLN
    Public Shared Function listar_detalle() As DataSet
        Dim objAD As New ReservacionHabAD
        Return objAD.listar_detalle()
    End Function
End Class

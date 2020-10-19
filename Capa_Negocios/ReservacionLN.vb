Imports Capa_Entidad
Imports Capa_AccesoDatos
Public Class ReservacionLN
    Public Shared Sub registrar_reservacion(objR As Reservacion)
        Dim objAD As New ReservacionAD
        objAD.registrar_reservacion(objR)
    End Sub
    'Public Shared Sub listar_reservaciones(objP As Persona)
    '    Dim objAD As New ReservacionAD
    '    objAD.listar_reservaciones(objP)
    'End Sub
End Class

Imports Capa_Entidad
Imports Capa_AccesoDatos
Public Class HabitacionLN
    Public Shared Function listarHabitaciones(ObjTH As TipoHabitacion) As List(Of Habitacion)
        Dim objAD As New HabitacionAD
        Return objAD.listarHabitaciones(ObjTH)
    End Function
End Class
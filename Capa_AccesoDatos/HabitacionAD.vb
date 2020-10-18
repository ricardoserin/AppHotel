Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class HabitacionAD
    Public Function listarHabitaciones(objTH As TipoHabitacion) As List(Of Habitacion)
        Dim cn As New SqlConnection("server=.; integrated security=true; Database=BDHotel")
        Dim cmd As New SqlCommand
        Dim lista As New List(Of Habitacion)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_habitacion_tipo_habitacion"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idTipoHabitacion", SqlDbType.Int).Value = objTH.idTipoHabitacion
            Dim oLector As SqlDataReader
            oLector = cmd.ExecuteReader
            While oLector.Read
                lista.Add(New Habitacion With {
                    .idHabitacion = oLector.Item(0),
                    .numero = oLector.Item(1),
                    .piso = oLector.Item(2),
                    .estado = oLector.Item(3),
                    .fechaModificacion = oLector.Item(4),
                    .idTipoHabitacion = oLector.Item(5)
                })
            End While
            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class

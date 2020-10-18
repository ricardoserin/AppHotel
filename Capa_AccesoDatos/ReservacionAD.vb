Imports System.Data.SqlClient
Imports Capa_Entidad
Public Class ReservacionAD
    Public Sub registrar_reservacion(Obj As Reservacion)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=BDHotel")
        Dim cmdR As New SqlCommand("sp_insert_reservacion", cn)
        Dim cmdD As New SqlCommand("sp_insert_reservacion_hab", cn)
        cmdR.CommandType = CommandType.StoredProcedure
        cmdD.CommandType = CommandType.StoredProcedure
        Dim tr As SqlTransaction = Nothing
        Try
            cmdR.Parameters.AddWithValue("@idReservacion", 0).Direction = ParameterDirection.Output
            cmdR.Parameters.AddWithValue("@FechaLlegada", Obj.fechaLlegada)
            cmdR.Parameters.AddWithValue("@HoraLlegada", Obj.horaLlegada)
            cmdR.Parameters.AddWithValue("@idPersona", Obj.idPersona)
            cmdR.Parameters.AddWithValue("@idTipoReservacion", Obj.idTipoReserva)
            cn.Open()
            tr = cn.BeginTransaction
            cmdR.Transaction = tr
            cmdD.Transaction = tr
            cmdR.ExecuteNonQuery()
            cmdD.Parameters.Add("@idReservacion", SqlDbType.Int).Value = cmdR.Parameters.Item("@idReservacion").Value
            For Each det As ReservacionHab In Obj.listDetalle
                cmdD.Parameters.Add("@idReservacion", SqlDbType.Int).Value = det.idReservacion
                cmdD.Parameters.Add("@idHabitacion", SqlDbType.Int).Value = det.idHabitacion
                cmdD.ExecuteNonQuery()
            Next
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class

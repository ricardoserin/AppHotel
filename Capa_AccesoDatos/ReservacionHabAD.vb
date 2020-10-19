Imports System.Data.SqlClient

Public Class ReservacionHabAD
    Public Function listar_detalle() As DataSet
        Dim cn As New SqlConnection("server=.; integrated security=true; Database=BDHotel")
        Dim oDataAdapter As New SqlDataAdapter("", cn)
        Dim oDataSet As New DataSet
        Try
            oDataAdapter.SelectCommand.CommandText = "select * from RESERVACION"
            oDataAdapter.Fill(oDataSet, "Reservacion")
            oDataAdapter.SelectCommand.CommandText = "select * from RESERVACION_HAB"
            oDataAdapter.Fill(oDataSet, "Detalle")
            Dim oDataRelation As New DataRelation("DetalleReservacion", oDataSet.Tables("Reservacion").Columns(0), oDataSet.Tables("Detalle").Columns(0))
            oDataSet.Relations.Add(oDataRelation)
            Return oDataSet
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class

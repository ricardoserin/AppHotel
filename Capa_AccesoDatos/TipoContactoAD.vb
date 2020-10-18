Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class TipoContactoAD
    Public Function listarTipoContacto(objA As TipoContacto) As String
        Dim cn As New SqlConnection("server=.; integrated security=true; Database=BDHotel")
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_search_tipoContacto"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idTipoContacto", SqlDbType.Int).Value = objA
            Dim oLector As SqlDataReader
            oLector = cmd.ExecuteReader
            If (oLector.HasRows = True) Then
                While oLector.Read
                    objA.descripcion = oLector.Item(1)
                End While
            End If
            Return (objA.descripcion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class

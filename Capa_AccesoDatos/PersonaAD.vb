Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class PersonaAD
    Public Function listarPersona(objA As Persona) As String
        Dim cn As New SqlConnection("server=(localhost); integrated security=true; Database=BDHotel")
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_search_persona"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idPersona", SqlDbType.Int).Value = objA.idPersona
            Dim oLector As SqlDataReader
            oLector = cmd.ExecuteReader
            If (oLector.HasRows = True) Then
                While oLector.Read
                    objA.nombres = oLector.Item(1)
                    objA.apellPaterno = oLector.Item(2)
                    objA.apellMaterno = oLector.Item(3)
                End While
            End If
            Return (objA.nombres + objA.apellPaterno + objA.apellMaterno)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class

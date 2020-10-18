Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class InfoContactoAD
    'Public Function listarInfoContacto(objP As Persona) As List(Of InfoContacto)
    '    Dim cn As New SqlConnection("server=(localhost); integrated security=true; Database=BDHotel")
    '    Dim cmd As New SqlCommand
    '    Dim lista As New List(Of InfoContacto)
    '    Try
    '        cn.Open()
    '        cmd.Connection = cn
    '        cmd.CommandText = "sp_persona_info_contacto"
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@idPersona", SqlDbType.Int).Value = objP
    '        Dim oLector As SqlDataReader
    '        oLector = cmd.ExecuteReader
    '        If (oLector.HasRows = True) Then
    '            While oLector.Read
    '                lista.Add(New InfoContacto With {
    '                    .idPersona = oLector.Item(0),
    '                    .idContacto = oLector.Item(1),
    '                    .datoContacto = oLector.Item(2),
    '                    .idTipoContacto = oLector.Item(3)
    '                })
    '            End While
    '        End If
    '        Return lista
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    Finally
    '        cn.Close()
    '    End Try
    'End Function
    'Public Function registrarInfoContacto(objI As InfoContacto)
    '    Dim cn As New SqlConnection("server=(localhost); integrated security=true; Database=BDHotel")
    '    Dim cmd As New SqlCommand("sp_insert_info_contacto", cn)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    Dim tr As SqlTransaction = Nothing
    '    Try
    '        'cmd.Parameters.Add("@idPersona", SqlDbType.Int).Value = objI
    '        cmd.Parameters.AddWithValue("@persona", objI.idPersona)
    '        cmd.Parameters.AddWithValue("@dato", objI.datoContacto)
    '        cmd.Parameters.AddWithValue("@tipo", objI.idTipoContacto)
    '        cn.Open()
    '        tr = cn.BeginTransaction
    '        cmd.Transaction = tr


    '        Dim oLector As SqlDataReader
    '        oLector = cmd.ExecuteReader
    '        If (oLector.HasRows = True) Then
    '            While oLector.Read

    '            End While
    '        End If
    '        Return lista
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    Finally
    '        cn.Close()
    '    End Try
    'End Function
End Class

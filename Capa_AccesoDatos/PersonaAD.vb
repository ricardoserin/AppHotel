Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class PersonaAD
    Public Function listarPersona(objP As Persona) As Persona
        Dim cn As New SqlConnection("server=.; integrated security=true; Database=BDHotel")
        Dim cmd As New SqlCommand
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "sp_search_persona_doc"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@documento", SqlDbType.VarChar, 20).Value = objP.numDocumento
            Dim oLector As SqlDataReader
            oLector = cmd.ExecuteReader
            If (oLector.HasRows = True) Then
                While oLector.Read
                    objP.idPersona = oLector.Item(0)
                    objP.nombres = oLector.Item(1)
                    objP.apellPaterno = oLector.Item(2)
                    objP.apellMaterno = oLector.Item(3)
                End While
            End If
            Return objP
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
    'Public Function registrarPersona(objP As Persona)
    '    Dim cn As New SqlConnection("server=.; integrated security=true; Database=BDHotel")
    '    Dim cmd As New SqlCommand
    '    Try
    '        cn.Open()
    '        cmd.Connection = cn
    '        cmd.CommandText = "sp_insert_persona"
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = objP.nombres
    '        cmd.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 50).Value = objP.apellPaterno
    '        cmd.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 50).Value = objP.apellMaterno
    '        cmd.Parameters.Add("@Sexo", SqlDbType.VarChar, 20).Value = objP.numDocumento
    '        cmd.Parameters.Add("@EstadoCivil", SqlDbType.VarChar, 20).Value = objP.numDocumento
    '        cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = objP.numDocumento
    '        cmd.Parameters.Add("@idTipoDoc", SqlDbType.VarChar, 20).Value = objP.numDocumento
    '        cmd.Parameters.Add("@NumDoc", SqlDbType.VarChar, 20).Value = objP.numDocumento
    '        'Dim oLector As SqlDataReader
    '        'oLector = cmd.ExecuteReader
    '        'If (oLector.HasRows = True) Then
    '        '    While oLector.Read
    '        '        objP.idPersona = oLector.Item(0)
    '        '        objP.nombres = oLector.Item(1)
    '        '        objP.apellPaterno = oLector.Item(2)
    '        '        objP.apellMaterno = oLector.Item(3)
    '        '    End While
    '        'End If
    '        'Return objP
    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    Finally
    '        cn.Close()
    '    End Try
    'End Function
End Class

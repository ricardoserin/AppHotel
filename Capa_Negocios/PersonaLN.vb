Imports Capa_Entidad
Imports Capa_AccesoDatos
Public Class PersonaLN
    Public Shared Function listarPersona(ObjP As Persona) As Persona
        Dim objAD As New PersonaAD
        Return objAD.listarPersona(ObjP)
    End Function
End Class

Public Class Persona
    Private m_idPersona As Integer
    Private m_nombres As String
    Private m_apellPaterno As String
    Private m_apellMaterno As String
    Private m_sexo As String
    Private m_idTipoDocumento As Integer
    Private m_numDocumento As String
    Public Property idPersona() As Integer
        Get
            Return m_idPersona
        End Get
        Set(ByVal value As Integer)
            m_idPersona = value
        End Set
    End Property
    Public Property nombres() As String
        Get
            Return m_nombres
        End Get
        Set(ByVal value As String)
            m_nombres = value
        End Set
    End Property
    Public Property apellPaterno() As String
        Get
            Return m_apellPaterno
        End Get
        Set(ByVal value As String)
            m_apellPaterno = value
        End Set
    End Property
    Public Property apellMaterno() As String
        Get
            Return m_apellMaterno
        End Get
        Set(ByVal value As String)
            m_apellMaterno = value
        End Set
    End Property
    Public Property sexo() As String
        Get
            Return m_sexo
        End Get
        Set(ByVal value As String)
            m_sexo = value
        End Set
    End Property
    Public Property idTipoDocumento() As Integer
        Get
            Return m_idTipoDocumento
        End Get
        Set(ByVal value As Integer)
            m_idTipoDocumento = value
        End Set
    End Property
    Public Property numDocumento() As String
        Get
            Return m_numDocumento
        End Get
        Set(ByVal value As String)
            m_numDocumento = value
        End Set
    End Property
End Class

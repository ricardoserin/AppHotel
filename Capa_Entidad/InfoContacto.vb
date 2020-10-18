Public Class InfoContacto
    Private m_idPersona As Integer
    Private m_idContacto As Integer
    Private m_idTipoContacto As Integer
    Private m_datoContacto As String
    Public Property idPersona() As Integer
        Get
            Return m_idPersona
        End Get
        Set(ByVal value As Integer)
            m_idPersona = value
        End Set
    End Property
    Public Property idContacto() As Integer
        Get
            Return m_idContacto
        End Get
        Set(ByVal value As Integer)
            m_idContacto = value
        End Set
    End Property
    Public Property idTipoContacto() As Integer
        Get
            Return m_idTipoContacto
        End Get
        Set(ByVal value As Integer)
            m_idTipoContacto = value
        End Set
    End Property
    Public Property datoContacto() As String
        Get
            Return m_datoContacto
        End Get
        Set(ByVal value As String)
            m_datoContacto = value
        End Set
    End Property
End Class

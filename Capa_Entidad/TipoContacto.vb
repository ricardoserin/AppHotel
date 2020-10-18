Public Class TipoContacto
    Private m_idTipoContacto As Integer
    Private m_descripcion As String
    Public Property idTipoContacto() As Integer
        Get
            Return m_idTipoContacto
        End Get
        Set(ByVal value As Integer)
            m_idTipoContacto = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
        End Set
    End Property
End Class

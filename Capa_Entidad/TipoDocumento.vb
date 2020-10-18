Public Class TipoDocumento
    Private m_idTipoDocumento As Integer
    Private m_tipoDocumento As String
    Public Property idTipoDocumento() As Integer
        Get
            Return m_idTipoDocumento
        End Get
        Set(ByVal value As Integer)
            m_idTipoDocumento = value
        End Set
    End Property
    Public Property tipoDocumento() As String
        Get
            Return m_tipoDocumento
        End Get
        Set(ByVal value As String)
            m_tipoDocumento = value
        End Set
    End Property
End Class
Public Class Habitacion
    Private m_idHabitacion As Integer
    Private m_numero As Integer
    Private m_piso As Integer
    Private m_fechaModificacion As Date
    Private m_idTipoHabitacion As Integer
    Private m_estado As String
    Public Property estado() As String
        Get
            Return m_estado
        End Get
        Set(ByVal value As String)
            m_estado = value
        End Set
    End Property
    Public Property idTipoHabitacion() As Integer
        Get
            Return m_idTipoHabitacion
        End Get
        Set(ByVal value As Integer)
            m_idTipoHabitacion = value
        End Set
    End Property
    Public Property fechaModificacion() As Date
        Get
            Return m_fechaModificacion
        End Get
        Set(ByVal value As Date)
            m_fechaModificacion = value
        End Set
    End Property
    Public Property piso() As Integer
        Get
            Return m_piso
        End Get
        Set(ByVal value As Integer)
            m_piso = value
        End Set
    End Property
    Public Property numero() As Integer
        Get
            Return m_numero
        End Get
        Set(ByVal value As Integer)
            m_numero = value
        End Set
    End Property
    Public Property idHabitacion() As Integer
        Get
            Return m_idHabitacion
        End Get
        Set(ByVal value As Integer)
            m_idHabitacion = value
        End Set
    End Property
End Class

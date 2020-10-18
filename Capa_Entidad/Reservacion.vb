Public Class Reservacion
    Private m_fechaReserva As Date
    Private m_horaReserva As DateTime
    Private m_fechaVencimiento As Date
    Private m_fechaLlegada As Date
    Private m_horaLlegada As DateTime
    Private m_idPersona As Integer
    Private m_idTipoReserva As Integer
    Private m_detalle As List(Of ReservacionHab)
    Public Property listDetalle() As List(Of ReservacionHab)
        Get
            Return m_detalle
        End Get
        Set(ByVal value As List(Of ReservacionHab))
            m_detalle = value
        End Set
    End Property
    Public Property idTipoReserva() As Integer
        Get
            Return m_idTipoReserva
        End Get
        Set(ByVal value As Integer)
            m_idTipoReserva = value
        End Set
    End Property
    Public Property idPersona() As Integer
        Get
            Return m_idPersona
        End Get
        Set(ByVal value As Integer)
            m_idPersona = value
        End Set
    End Property
    Public Property horaLlegada() As DateTime
        Get
            Return m_horaLlegada
        End Get
        Set(ByVal value As DateTime)
            m_horaLlegada = value
        End Set
    End Property
    Public Property fechaLlegada() As Date
        Get
            Return m_fechaLlegada
        End Get
        Set(ByVal value As Date)
            m_fechaLlegada = value
        End Set
    End Property

    Public Property fechaVencimiento() As Date
        Get
            Return m_fechaVencimiento
        End Get
        Set(ByVal value As Date)
            m_fechaVencimiento = value
        End Set
    End Property
    Public Property horaReservacion() As DateTime
        Get
            Return m_horaReserva
        End Get
        Set(ByVal value As DateTime)
            m_horaReserva = value
        End Set
    End Property
    Public Property fechaReservacion() As Date
        Get
            Return m_fechaReserva
        End Get
        Set(ByVal value As Date)
            m_fechaReserva = value
        End Set
    End Property
End Class

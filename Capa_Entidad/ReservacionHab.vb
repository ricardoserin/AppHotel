Public Class ReservacionHab
    Private m_idReservacion As Integer
    Private m_idHabitacion As Integer
    Public Property idHabitacion() As Integer
        Get
            Return m_idHabitacion
        End Get
        Set(ByVal value As Integer)
            m_idHabitacion = value
        End Set
    End Property
    Public Property idReservacion() As Integer
        Get
            Return m_idReservacion
        End Get
        Set(ByVal value As Integer)
            m_idReservacion = value
        End Set
    End Property
End Class

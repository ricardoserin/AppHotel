Imports Capa_Entidad
Imports System.Data.SqlClient
Public Class TipoHabitacionAD
    Private m_idTipoHabitacion As Integer
    Private m_tipo As String
    Private m_descripcion As String
    Private m_tarifaHora As Double
    Public Property tarifaHora() As Double
        Get
            Return m_tarifaHora
        End Get
        Set(ByVal value As Double)
            m_tarifaHora = value
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
    Public Property tipo() As String
        Get
            Return m_tipo
        End Get
        Set(ByVal value As String)
            m_tipo = value
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
End Class

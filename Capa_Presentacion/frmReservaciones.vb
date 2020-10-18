Imports Capa_Negocios
Imports Capa_Entidad
Public Class frmReservaciones
    Public NHabitaciones As Integer = 0
    Private lista As New List(Of ReservacionHab)

    Private Sub frmReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.TIPO_HABITACION' Puede moverla o quitarla según sea necesario.
        Me.TIPO_HABITACIONTableAdapter.Fill(Me.BDHotelDataSet.TIPO_HABITACION)
        lblFechaActual.Text = Now.Date
    End Sub

    Private Sub btnConsultarHabitaciones_Click(sender As Object, e As EventArgs) Handles btnConsultarHabitaciones.Click
        listarHabitaciones()
    End Sub

    Private Sub listarHabitaciones()
        Dim ObjH = New TipoHabitacion
        ObjH.idTipoHabitacion = cbxTiposHab.SelectedValue
        DTGVHabitaciones.DataSource = HabitacionLN.listarHabitaciones(ObjH)
    End Sub
End Class

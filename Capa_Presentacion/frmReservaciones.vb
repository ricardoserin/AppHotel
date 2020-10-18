Imports Capa_Negocios
Imports Capa_Entidad
Public Class frmReservaciones
    Public NHabitaciones As Integer = 0
    Private lista As New List(Of ReservacionHab)

    Private Sub frmReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDHotelDataSet.TIPO_HABITACION' Puede moverla o quitarla según sea necesario.
        Me.TIPO_HABITACIONTableAdapter.Fill(Me.BDHotelDataSet.TIPO_HABITACION)
        listarHabitaciones()
        lblFechaActual.Text = Now.Date
    End Sub

    Private Sub listarHabitaciones()
        Dim ObjH = New TipoHabitacion
        ObjH.idTipoHabitacion = cbxTiposHab.SelectedValue
        DTGVHabitaciones.DataSource = HabitacionLN.listarHabitaciones(ObjH)
    End Sub

    Private Sub btnAgregarHabitaciones_Click(sender As Object, e As EventArgs) Handles btnAgregarHabitaciones.Click
        If DTGVHabitaciones.SelectedCells.Count = 0 Then Exit Sub
        NHabitaciones += 1
        Dim Estado As String
        If NHabitaciones <= 2 Then
            Dim obj As New ReservacionHab
            obj.idReservacion = 0
            Estado = Me.DTGVHabitaciones.SelectedCells.Item(3).Value
            If Estado.Equals("LIBRE") Then
                obj.idHabitacion = CType(Me.DTGVHabitaciones.SelectedCells.Item(0).Value, Integer)
                obj.numero = CType(Me.DTGVHabitaciones.SelectedCells.Item(1).Value, Integer)
                lista.Add(obj)
                listar_habitaciones_reservadas()
            Else
                MessageBox.Show("Error, habitación no disponible, se encuentra " + Estado.ToLower + ".")
            End If
        End If
    End Sub

    Private Sub listar_habitaciones_reservadas()
        DTGVHabitacionesReservadas.DataSource = Nothing
        DTGVHabitacionesReservadas.DataSource = lista
    End Sub

    Private Sub btnGuardarReserva_Click(sender As Object, e As EventArgs) Handles btnGuardarReserva.Click
        If lista.Count > 0 Then
            Dim obj As New Reservacion
            obj.idPersona = CType(txtIdPersona.Text, Integer)
            obj.fechaReservacion = Now.Date
            obj.horaReservacion = TimeOfDay
            obj.fechaLlegada = Format(DTPFechaLLegada.Value.ToShortDateString)
            obj.horaLlegada = DTPHoraLlegada.Value 'Format(DTPFechaLLegada.Value.ToShortTimeString)
            obj.listDetalle = lista
            obj.idTipoReserva = 1
            ReservacionLN.registrar_reservacion(obj)
            MessageBox.Show("La operación se realizó con éxito, pueden mandar a la mrd a Boy :v")
        Else
            MessageBox.Show("Debe agregar habitaciones a la reserva")
        End If
    End Sub

    Private Sub cbxTiposHab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTiposHab.SelectedIndexChanged
        listarHabitaciones()
    End Sub
End Class

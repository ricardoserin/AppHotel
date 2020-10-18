<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPersona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombrePersona = New System.Windows.Forms.TextBox()
        Me.GBHabitaciones = New System.Windows.Forms.GroupBox()
        Me.DTGVHabitaciones = New System.Windows.Forms.DataGridView()
        Me.btnAgregarHabitaciones = New System.Windows.Forms.Button()
        Me.cbxTiposHab = New System.Windows.Forms.ComboBox()
        Me.TIPOHABITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New Capa_Presentacion.BDHotelDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTGVHabitacionesReservadas = New System.Windows.Forms.DataGridView()
        Me.btnGuardarReserva = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TIPO_HABITACIONTableAdapter = New Capa_Presentacion.BDHotelDataSetTableAdapters.TIPO_HABITACIONTableAdapter()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.DTPFechaLLegada = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPHoraLlegada = New System.Windows.Forms.DateTimePicker()
        Me.GBHabitaciones.SuspendLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGVHabitacionesReservadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Location = New System.Drawing.Point(79, 12)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPersona.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'txtNombrePersona
        '
        Me.txtNombrePersona.Location = New System.Drawing.Point(79, 38)
        Me.txtNombrePersona.Name = "txtNombrePersona"
        Me.txtNombrePersona.Size = New System.Drawing.Size(226, 20)
        Me.txtNombrePersona.TabIndex = 3
        '
        'GBHabitaciones
        '
        Me.GBHabitaciones.Controls.Add(Me.DTPHoraLlegada)
        Me.GBHabitaciones.Controls.Add(Me.Label5)
        Me.GBHabitaciones.Controls.Add(Me.Label4)
        Me.GBHabitaciones.Controls.Add(Me.DTPFechaLLegada)
        Me.GBHabitaciones.Controls.Add(Me.DTGVHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.btnAgregarHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.cbxTiposHab)
        Me.GBHabitaciones.Controls.Add(Me.Label3)
        Me.GBHabitaciones.Location = New System.Drawing.Point(41, 77)
        Me.GBHabitaciones.Name = "GBHabitaciones"
        Me.GBHabitaciones.Size = New System.Drawing.Size(537, 261)
        Me.GBHabitaciones.TabIndex = 4
        Me.GBHabitaciones.TabStop = False
        Me.GBHabitaciones.Text = "Habitaciones"
        '
        'DTGVHabitaciones
        '
        Me.DTGVHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVHabitaciones.Location = New System.Drawing.Point(6, 113)
        Me.DTGVHabitaciones.Name = "DTGVHabitaciones"
        Me.DTGVHabitaciones.Size = New System.Drawing.Size(521, 142)
        Me.DTGVHabitaciones.TabIndex = 4
        '
        'btnAgregarHabitaciones
        '
        Me.btnAgregarHabitaciones.Location = New System.Drawing.Point(395, 14)
        Me.btnAgregarHabitaciones.Name = "btnAgregarHabitaciones"
        Me.btnAgregarHabitaciones.Size = New System.Drawing.Size(136, 23)
        Me.btnAgregarHabitaciones.TabIndex = 3
        Me.btnAgregarHabitaciones.Text = "Seleccionar habitación"
        Me.btnAgregarHabitaciones.UseVisualStyleBackColor = True
        '
        'cbxTiposHab
        '
        Me.cbxTiposHab.DataSource = Me.TIPOHABITACIONBindingSource
        Me.cbxTiposHab.DisplayMember = "Tipo"
        Me.cbxTiposHab.FormattingEnabled = True
        Me.cbxTiposHab.Location = New System.Drawing.Point(110, 86)
        Me.cbxTiposHab.Name = "cbxTiposHab"
        Me.cbxTiposHab.Size = New System.Drawing.Size(417, 21)
        Me.cbxTiposHab.TabIndex = 1
        Me.cbxTiposHab.ValueMember = "IdTipo_Habitacion"
        '
        'TIPOHABITACIONBindingSource
        '
        Me.TIPOHABITACIONBindingSource.DataMember = "TIPO_HABITACION"
        Me.TIPOHABITACIONBindingSource.DataSource = Me.BDHotelDataSet
        '
        'BDHotelDataSet
        '
        Me.BDHotelDataSet.DataSetName = "BDHotelDataSet"
        Me.BDHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de habitación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTGVHabitacionesReservadas)
        Me.GroupBox1.Location = New System.Drawing.Point(584, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 233)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitaciones reservadas"
        '
        'DTGVHabitacionesReservadas
        '
        Me.DTGVHabitacionesReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVHabitacionesReservadas.Location = New System.Drawing.Point(7, 19)
        Me.DTGVHabitacionesReservadas.Name = "DTGVHabitacionesReservadas"
        Me.DTGVHabitacionesReservadas.Size = New System.Drawing.Size(309, 208)
        Me.DTGVHabitacionesReservadas.TabIndex = 0
        '
        'btnGuardarReserva
        '
        Me.btnGuardarReserva.Location = New System.Drawing.Point(771, 316)
        Me.btnGuardarReserva.Name = "btnGuardarReserva"
        Me.btnGuardarReserva.Size = New System.Drawing.Size(135, 23)
        Me.btnGuardarReserva.TabIndex = 6
        Me.btnGuardarReserva.Text = "Guardar reserva"
        Me.btnGuardarReserva.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(463, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Quitar habitación"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(690, 316)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Cerrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TIPO_HABITACIONTableAdapter
        '
        Me.TIPO_HABITACIONTableAdapter.ClearBeforeFill = True
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Location = New System.Drawing.Point(433, 32)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(42, 13)
        Me.lblFechaActual.TabIndex = 9
        Me.lblFechaActual.Text = "FECHA"
        '
        'DTPFechaLLegada
        '
        Me.DTPFechaLLegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaLLegada.Location = New System.Drawing.Point(117, 19)
        Me.DTPFechaLLegada.Name = "DTPFechaLLegada"
        Me.DTPFechaLLegada.Size = New System.Drawing.Size(116, 20)
        Me.DTPFechaLLegada.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha llegada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hora llegada"
        '
        'DTPHoraLlegada
        '
        Me.DTPHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPHoraLlegada.Location = New System.Drawing.Point(117, 48)
        Me.DTPHoraLlegada.Name = "DTPHoraLlegada"
        Me.DTPHoraLlegada.ShowUpDown = True
        Me.DTPHoraLlegada.Size = New System.Drawing.Size(116, 20)
        Me.DTPHoraLlegada.TabIndex = 8
        '
        'frmReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 514)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnGuardarReserva)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBHabitaciones)
        Me.Controls.Add(Me.txtNombrePersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPersona)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReservaciones"
        Me.Text = "RESERVACIONES"
        Me.GBHabitaciones.ResumeLayout(False)
        Me.GBHabitaciones.PerformLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DTGVHabitacionesReservadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPersona As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombrePersona As TextBox
    Friend WithEvents GBHabitaciones As GroupBox
    Friend WithEvents btnAgregarHabitaciones As Button
    Friend WithEvents cbxTiposHab As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardarReserva As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DTGVHabitaciones As DataGridView
    Friend WithEvents DTGVHabitacionesReservadas As DataGridView
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents TIPOHABITACIONBindingSource As BindingSource
    Friend WithEvents TIPO_HABITACIONTableAdapter As BDHotelDataSetTableAdapters.TIPO_HABITACIONTableAdapter
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents DTPFechaLLegada As DateTimePicker
    Friend WithEvents DTPHoraLlegada As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class

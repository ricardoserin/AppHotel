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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarHabitaciones = New System.Windows.Forms.Button()
        Me.DTGVHabitaciones = New System.Windows.Forms.DataGridView()
        Me.cbxTiposHab = New System.Windows.Forms.ComboBox()
        Me.TIPOHABITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New Capa_Presentacion.BDHotelDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPHoraLlegada = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFechaLLegada = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTGVHabitacionesReservadas = New System.Windows.Forms.DataGridView()
        Me.btnGuardarReserva = New System.Windows.Forms.Button()
        Me.TIPO_HABITACIONTableAdapter = New Capa_Presentacion.BDHotelDataSetTableAdapters.TIPO_HABITACIONTableAdapter()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.cbxMedioReserva = New System.Windows.Forms.ComboBox()
        Me.TIPORESERVACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet1 = New Capa_Presentacion.BDHotelDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BDHotelDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOHABITACIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_RESERVACIONTableAdapter = New Capa_Presentacion.BDHotelDataSet1TableAdapters.TIPO_RESERVACIONTableAdapter()
        Me.btnBuscarPersona = New System.Windows.Forms.Button()
        Me.btnRegistrarPersona = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GBHabitaciones.SuspendLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGVHabitacionesReservadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPORESERVACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOHABITACIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Location = New System.Drawing.Point(76, 64)
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(150, 20)
        Me.txtIdPersona.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtNombrePersona
        '
        Me.txtNombrePersona.Location = New System.Drawing.Point(76, 95)
        Me.txtNombrePersona.Name = "txtNombrePersona"
        Me.txtNombrePersona.Size = New System.Drawing.Size(314, 20)
        Me.txtNombrePersona.TabIndex = 3
        '
        'GBHabitaciones
        '
        Me.GBHabitaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBHabitaciones.Controls.Add(Me.Label8)
        Me.GBHabitaciones.Controls.Add(Me.btnAgregarHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.DTGVHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.cbxTiposHab)
        Me.GBHabitaciones.Controls.Add(Me.Label3)
        Me.GBHabitaciones.Location = New System.Drawing.Point(12, 122)
        Me.GBHabitaciones.Name = "GBHabitaciones"
        Me.GBHabitaciones.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GBHabitaciones.Size = New System.Drawing.Size(650, 217)
        Me.GBHabitaciones.TabIndex = 4
        Me.GBHabitaciones.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Habitaciones"
        '
        'btnAgregarHabitaciones
        '
        Me.btnAgregarHabitaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarHabitaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarHabitaciones.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.mas
        Me.btnAgregarHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarHabitaciones.FlatAppearance.BorderSize = 0
        Me.btnAgregarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarHabitaciones.Location = New System.Drawing.Point(611, 32)
        Me.btnAgregarHabitaciones.Name = "btnAgregarHabitaciones"
        Me.btnAgregarHabitaciones.Size = New System.Drawing.Size(32, 32)
        Me.btnAgregarHabitaciones.TabIndex = 3
        Me.btnAgregarHabitaciones.UseVisualStyleBackColor = False
        '
        'DTGVHabitaciones
        '
        Me.DTGVHabitaciones.AllowDrop = True
        Me.DTGVHabitaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGVHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVHabitaciones.Location = New System.Drawing.Point(6, 70)
        Me.DTGVHabitaciones.Name = "DTGVHabitaciones"
        Me.DTGVHabitaciones.ReadOnly = True
        Me.DTGVHabitaciones.Size = New System.Drawing.Size(637, 141)
        Me.DTGVHabitaciones.TabIndex = 4
        '
        'cbxTiposHab
        '
        Me.cbxTiposHab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxTiposHab.DataSource = Me.TIPOHABITACIONBindingSource
        Me.cbxTiposHab.DisplayMember = "Tipo"
        Me.cbxTiposHab.FormattingEnabled = True
        Me.cbxTiposHab.Location = New System.Drawing.Point(125, 38)
        Me.cbxTiposHab.Name = "cbxTiposHab"
        Me.cbxTiposHab.Size = New System.Drawing.Size(480, 21)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de habitación"
        '
        'DTPHoraLlegada
        '
        Me.DTPHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPHoraLlegada.Location = New System.Drawing.Point(529, 69)
        Me.DTPHoraLlegada.Name = "DTPHoraLlegada"
        Me.DTPHoraLlegada.ShowUpDown = True
        Me.DTPHoraLlegada.Size = New System.Drawing.Size(130, 20)
        Me.DTPHoraLlegada.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hora llegada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha llegada"
        '
        'DTPFechaLLegada
        '
        Me.DTPFechaLLegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaLLegada.Location = New System.Drawing.Point(529, 43)
        Me.DTPFechaLLegada.Name = "DTPFechaLLegada"
        Me.DTPFechaLLegada.Size = New System.Drawing.Size(130, 20)
        Me.DTPFechaLLegada.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.menos
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(611, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.DTGVHabitacionesReservadas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 345)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(650, 150)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Lista reservación"
        '
        'DTGVHabitacionesReservadas
        '
        Me.DTGVHabitacionesReservadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGVHabitacionesReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVHabitacionesReservadas.Location = New System.Drawing.Point(6, 49)
        Me.DTGVHabitacionesReservadas.Name = "DTGVHabitacionesReservadas"
        Me.DTGVHabitacionesReservadas.Size = New System.Drawing.Size(637, 95)
        Me.DTGVHabitacionesReservadas.TabIndex = 0
        '
        'btnGuardarReserva
        '
        Me.btnGuardarReserva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarReserva.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarReserva.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.save_2
        Me.btnGuardarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarReserva.FlatAppearance.BorderSize = 0
        Me.btnGuardarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarReserva.ForeColor = System.Drawing.Color.Transparent
        Me.btnGuardarReserva.Location = New System.Drawing.Point(611, 501)
        Me.btnGuardarReserva.Name = "btnGuardarReserva"
        Me.btnGuardarReserva.Size = New System.Drawing.Size(48, 48)
        Me.btnGuardarReserva.TabIndex = 6
        Me.btnGuardarReserva.UseVisualStyleBackColor = False
        '
        'TIPO_HABITACIONTableAdapter
        '
        Me.TIPO_HABITACIONTableAdapter.ClearBeforeFill = True
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.Location = New System.Drawing.Point(581, 16)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFechaActual.Size = New System.Drawing.Size(78, 15)
        Me.lblFechaActual.TabIndex = 9
        Me.lblFechaActual.Text = "XX/XX/XXX"
        '
        'cbxMedioReserva
        '
        Me.cbxMedioReserva.DataSource = Me.TIPORESERVACIONBindingSource
        Me.cbxMedioReserva.DisplayMember = "Tipo_Reservacion"
        Me.cbxMedioReserva.FormattingEnabled = True
        Me.cbxMedioReserva.Location = New System.Drawing.Point(529, 95)
        Me.cbxMedioReserva.Name = "cbxMedioReserva"
        Me.cbxMedioReserva.Size = New System.Drawing.Size(130, 21)
        Me.cbxMedioReserva.TabIndex = 10
        Me.cbxMedioReserva.ValueMember = "IdTipo_Reservacion"
        '
        'TIPORESERVACIONBindingSource
        '
        Me.TIPORESERVACIONBindingSource.DataMember = "TIPO_RESERVACION"
        Me.TIPORESERVACIONBindingSource.DataSource = Me.BDHotelDataSet1
        '
        'BDHotelDataSet1
        '
        Me.BDHotelDataSet1.DataSetName = "BDHotelDataSet1"
        Me.BDHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(405, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Medio de reserva"
        '
        'BDHotelDataSetBindingSource
        '
        Me.BDHotelDataSetBindingSource.DataSource = Me.BDHotelDataSet
        Me.BDHotelDataSetBindingSource.Position = 0
        '
        'TIPOHABITACIONBindingSource1
        '
        Me.TIPOHABITACIONBindingSource1.DataMember = "TIPO_HABITACION"
        Me.TIPOHABITACIONBindingSource1.DataSource = Me.BDHotelDataSetBindingSource
        '
        'TIPO_RESERVACIONTableAdapter
        '
        Me.TIPO_RESERVACIONTableAdapter.ClearBeforeFill = True
        '
        'btnBuscarPersona
        '
        Me.btnBuscarPersona.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarPersona.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.buscar1
        Me.btnBuscarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarPersona.FlatAppearance.BorderSize = 0
        Me.btnBuscarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPersona.Location = New System.Drawing.Point(232, 58)
        Me.btnBuscarPersona.Name = "btnBuscarPersona"
        Me.btnBuscarPersona.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarPersona.TabIndex = 12
        Me.btnBuscarPersona.UseVisualStyleBackColor = False
        '
        'btnRegistrarPersona
        '
        Me.btnRegistrarPersona.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarPersona.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.registrar_user
        Me.btnRegistrarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrarPersona.FlatAppearance.BorderSize = 0
        Me.btnRegistrarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarPersona.Location = New System.Drawing.Point(270, 58)
        Me.btnRegistrarPersona.Name = "btnRegistrarPersona"
        Me.btnRegistrarPersona.Size = New System.Drawing.Size(32, 32)
        Me.btnRegistrarPersona.TabIndex = 13
        Me.btnRegistrarPersona.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(328, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "REGISTRO DE RESERVACIONES"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.close
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(557, 501)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 48)
        Me.btnClose.TabIndex = 15
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(671, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnRegistrarPersona)
        Me.Controls.Add(Me.btnBuscarPersona)
        Me.Controls.Add(Me.DTPHoraLlegada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxMedioReserva)
        Me.Controls.Add(Me.DTPFechaLLegada)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardarReserva)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBHabitaciones)
        Me.Controls.Add(Me.txtNombrePersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPersona)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBHabitaciones.ResumeLayout(False)
        Me.GBHabitaciones.PerformLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DTGVHabitacionesReservadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPORESERVACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOHABITACIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbxMedioReserva As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TIPOHABITACIONBindingSource1 As BindingSource
    Friend WithEvents BDHotelDataSetBindingSource As BindingSource
    Friend WithEvents BDHotelDataSet1 As BDHotelDataSet1
    Friend WithEvents TIPORESERVACIONBindingSource As BindingSource
    Friend WithEvents TIPO_RESERVACIONTableAdapter As BDHotelDataSet1TableAdapters.TIPO_RESERVACIONTableAdapter
    Friend WithEvents btnBuscarPersona As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegistrarPersona As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClose As Button
End Class

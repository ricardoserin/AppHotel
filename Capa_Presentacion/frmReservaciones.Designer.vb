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
        Me.idPersona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombrePersona = New System.Windows.Forms.TextBox()
        Me.GBHabitaciones = New System.Windows.Forms.GroupBox()
        Me.DTGVHabitaciones = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConsultarHabitaciones = New System.Windows.Forms.Button()
        Me.cbxTiposHab = New System.Windows.Forms.ComboBox()
        Me.TIPOHABITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDHotelDataSet = New Capa_Presentacion.BDHotelDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TIPO_HABITACIONTableAdapter = New Capa_Presentacion.BDHotelDataSetTableAdapters.TIPO_HABITACIONTableAdapter()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.GBHabitaciones.SuspendLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'idPersona
        '
        Me.idPersona.Location = New System.Drawing.Point(83, 44)
        Me.idPersona.Name = "idPersona"
        Me.idPersona.Size = New System.Drawing.Size(100, 20)
        Me.idPersona.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'txtNombrePersona
        '
        Me.txtNombrePersona.Location = New System.Drawing.Point(83, 70)
        Me.txtNombrePersona.Name = "txtNombrePersona"
        Me.txtNombrePersona.Size = New System.Drawing.Size(226, 20)
        Me.txtNombrePersona.TabIndex = 3
        '
        'GBHabitaciones
        '
        Me.GBHabitaciones.Controls.Add(Me.DTGVHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.Button2)
        Me.GBHabitaciones.Controls.Add(Me.btnConsultarHabitaciones)
        Me.GBHabitaciones.Controls.Add(Me.cbxTiposHab)
        Me.GBHabitaciones.Controls.Add(Me.Label3)
        Me.GBHabitaciones.Location = New System.Drawing.Point(41, 114)
        Me.GBHabitaciones.Name = "GBHabitaciones"
        Me.GBHabitaciones.Size = New System.Drawing.Size(537, 196)
        Me.GBHabitaciones.TabIndex = 4
        Me.GBHabitaciones.TabStop = False
        Me.GBHabitaciones.Text = "Habitaciones"
        '
        'DTGVHabitaciones
        '
        Me.DTGVHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGVHabitaciones.Location = New System.Drawing.Point(13, 48)
        Me.DTGVHabitaciones.Name = "DTGVHabitaciones"
        Me.DTGVHabitaciones.Size = New System.Drawing.Size(518, 142)
        Me.DTGVHabitaciones.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Seleccionar habitación"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnConsultarHabitaciones
        '
        Me.btnConsultarHabitaciones.Location = New System.Drawing.Point(275, 14)
        Me.btnConsultarHabitaciones.Name = "btnConsultarHabitaciones"
        Me.btnConsultarHabitaciones.Size = New System.Drawing.Size(111, 23)
        Me.btnConsultarHabitaciones.TabIndex = 2
        Me.btnConsultarHabitaciones.Text = "Listar Habitaciones"
        Me.btnConsultarHabitaciones.UseVisualStyleBackColor = True
        '
        'cbxTiposHab
        '
        Me.cbxTiposHab.DataSource = Me.TIPOHABITACIONBindingSource
        Me.cbxTiposHab.DisplayMember = "Tipo"
        Me.cbxTiposHab.FormattingEnabled = True
        Me.cbxTiposHab.Location = New System.Drawing.Point(47, 17)
        Me.cbxTiposHab.Name = "cbxTiposHab"
        Me.cbxTiposHab.Size = New System.Drawing.Size(221, 21)
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
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 209)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitaciones reservadas"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(524, 183)
        Me.DataGridView2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(230, 541)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Guardar reserva"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(372, 541)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Quitar habitación"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(484, 541)
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
        'frmReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 615)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBHabitaciones)
        Me.Controls.Add(Me.txtNombrePersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idPersona)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReservaciones"
        Me.Text = "RESERVACIONES"
        Me.GBHabitaciones.ResumeLayout(False)
        Me.GBHabitaciones.PerformLayout()
        CType(Me.DTGVHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOHABITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDHotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents idPersona As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombrePersona As TextBox
    Friend WithEvents GBHabitaciones As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConsultarHabitaciones As Button
    Friend WithEvents cbxTiposHab As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DTGVHabitaciones As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BDHotelDataSet As BDHotelDataSet
    Friend WithEvents TIPOHABITACIONBindingSource As BindingSource
    Friend WithEvents TIPO_HABITACIONTableAdapter As BDHotelDataSetTableAdapters.TIPO_HABITACIONTableAdapter
    Friend WithEvents lblFechaActual As Label
End Class

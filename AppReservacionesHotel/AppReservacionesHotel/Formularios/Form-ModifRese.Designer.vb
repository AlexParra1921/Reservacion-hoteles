<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ModifRese
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_dias = New System.Windows.Forms.TextBox()
        Me.bt_buscarCliente = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_costoTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lb_no_habitaciones = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_habitacionReservadas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.date_salida = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_entrada = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_agregarMasHabitaciones = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.panel_habitaciones = New System.Windows.Forms.Panel()
        Me.dgv_habtiacionesAgregadas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bt_limpiar = New System.Windows.Forms.Button()
        Me.bt_res_guar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.data_reservacion = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_idreservacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.dgv_habitacionReservadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panel_habitaciones.SuspendLayout()
        CType(Me.dgv_habtiacionesAgregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_dias
        '
        Me.txt_dias.Enabled = False
        Me.txt_dias.Location = New System.Drawing.Point(472, 37)
        Me.txt_dias.Multiline = True
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.Size = New System.Drawing.Size(103, 20)
        Me.txt_dias.TabIndex = 27
        Me.txt_dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bt_buscarCliente
        '
        Me.bt_buscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_buscarCliente.Location = New System.Drawing.Point(602, 81)
        Me.bt_buscarCliente.Name = "bt_buscarCliente"
        Me.bt_buscarCliente.Size = New System.Drawing.Size(160, 23)
        Me.bt_buscarCliente.TabIndex = 2
        Me.bt_buscarCliente.Text = "Buscar"
        Me.bt_buscarCliente.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(426, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Dias :"
        '
        'lb_costoTotal
        '
        Me.lb_costoTotal.AutoSize = True
        Me.lb_costoTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_costoTotal.Location = New System.Drawing.Point(632, 332)
        Me.lb_costoTotal.Name = "lb_costoTotal"
        Me.lb_costoTotal.Size = New System.Drawing.Size(31, 20)
        Me.lb_costoTotal.TabIndex = 25
        Me.lb_costoTotal.Text = "$ 0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(524, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Costo Total:"
        '
        'lb_no_habitaciones
        '
        Me.lb_no_habitaciones.AutoSize = True
        Me.lb_no_habitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_no_habitaciones.Location = New System.Drawing.Point(8, 332)
        Me.lb_no_habitaciones.Name = "lb_no_habitaciones"
        Me.lb_no_habitaciones.Size = New System.Drawing.Size(144, 16)
        Me.lb_no_habitaciones.TabIndex = 20
        Me.lb_no_habitaciones.Text = "No. Habitaciones: 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "HABITACIONES"
        '
        'txt_idcliente
        '
        Me.txt_idcliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_idcliente.Enabled = False
        Me.txt_idcliente.Location = New System.Drawing.Point(20, 40)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(166, 20)
        Me.txt_idcliente.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Fecha Salida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha Entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'dgv_habitacionReservadas
        '
        Me.dgv_habitacionReservadas.AllowUserToAddRows = False
        Me.dgv_habitacionReservadas.AllowUserToDeleteRows = False
        Me.dgv_habitacionReservadas.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv_habitacionReservadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_habitacionReservadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_habitacionReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habitacionReservadas.Location = New System.Drawing.Point(8, 70)
        Me.dgv_habitacionReservadas.Name = "dgv_habitacionReservadas"
        Me.dgv_habitacionReservadas.RowHeadersVisible = False
        Me.dgv_habitacionReservadas.Size = New System.Drawing.Size(803, 103)
        Me.dgv_habitacionReservadas.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(602, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellido Materno"
        '
        'date_salida
        '
        Me.date_salida.Checked = False
        Me.date_salida.CustomFormat = "yyyy-MM-dd"
        Me.date_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_salida.Location = New System.Drawing.Point(234, 37)
        Me.date_salida.Name = "date_salida"
        Me.date_salida.Size = New System.Drawing.Size(168, 20)
        Me.date_salida.TabIndex = 16
        Me.date_salida.Value = New Date(2021, 11, 19, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apellido Paterno"
        '
        'date_entrada
        '
        Me.date_entrada.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_entrada.Checked = False
        Me.date_entrada.CustomFormat = "yyyy-MM-dd"
        Me.date_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_entrada.Location = New System.Drawing.Point(8, 37)
        Me.date_entrada.Name = "date_entrada"
        Me.date_entrada.Size = New System.Drawing.Size(166, 20)
        Me.date_entrada.TabIndex = 15
        Me.date_entrada.Value = New Date(2021, 11, 19, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CLIENTE"
        '
        'bt_agregarMasHabitaciones
        '
        Me.bt_agregarMasHabitaciones.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bt_agregarMasHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_agregarMasHabitaciones.Location = New System.Drawing.Point(669, 181)
        Me.bt_agregarMasHabitaciones.Margin = New System.Windows.Forms.Padding(5)
        Me.bt_agregarMasHabitaciones.Name = "bt_agregarMasHabitaciones"
        Me.bt_agregarMasHabitaciones.Size = New System.Drawing.Size(132, 25)
        Me.bt_agregarMasHabitaciones.TabIndex = 14
        Me.bt_agregarMasHabitaciones.Text = "Agregar mas"
        Me.bt_agregarMasHabitaciones.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_telefono)
        Me.Panel2.Controls.Add(Me.txt_materno)
        Me.Panel2.Controls.Add(Me.txt_paterno)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_idcliente)
        Me.Panel2.Controls.Add(Me.bt_buscarCliente)
        Me.Panel2.Location = New System.Drawing.Point(6, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(819, 117)
        Me.Panel2.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefono"
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_telefono.Enabled = False
        Me.txt_telefono.Location = New System.Drawing.Point(20, 81)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(166, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'txt_materno
        '
        Me.txt_materno.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_materno.Enabled = False
        Me.txt_materno.Location = New System.Drawing.Point(602, 40)
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(166, 20)
        Me.txt_materno.TabIndex = 8
        '
        'txt_paterno
        '
        Me.txt_paterno.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_paterno.Enabled = False
        Me.txt_paterno.Location = New System.Drawing.Point(408, 40)
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(166, 20)
        Me.txt_paterno.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(214, 40)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(166, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'panel_habitaciones
        '
        Me.panel_habitaciones.Controls.Add(Me.dgv_habtiacionesAgregadas)
        Me.panel_habitaciones.Controls.Add(Me.Label13)
        Me.panel_habitaciones.Controls.Add(Me.txt_dias)
        Me.panel_habitaciones.Controls.Add(Me.Label12)
        Me.panel_habitaciones.Controls.Add(Me.lb_costoTotal)
        Me.panel_habitaciones.Controls.Add(Me.Label11)
        Me.panel_habitaciones.Controls.Add(Me.lb_no_habitaciones)
        Me.panel_habitaciones.Controls.Add(Me.Label9)
        Me.panel_habitaciones.Controls.Add(Me.dgv_habitacionReservadas)
        Me.panel_habitaciones.Controls.Add(Me.Label8)
        Me.panel_habitaciones.Controls.Add(Me.Label7)
        Me.panel_habitaciones.Controls.Add(Me.date_salida)
        Me.panel_habitaciones.Controls.Add(Me.date_entrada)
        Me.panel_habitaciones.Controls.Add(Me.bt_agregarMasHabitaciones)
        Me.panel_habitaciones.Location = New System.Drawing.Point(6, 196)
        Me.panel_habitaciones.Name = "panel_habitaciones"
        Me.panel_habitaciones.Padding = New System.Windows.Forms.Padding(5)
        Me.panel_habitaciones.Size = New System.Drawing.Size(819, 370)
        Me.panel_habitaciones.TabIndex = 21
        '
        'dgv_habtiacionesAgregadas
        '
        Me.dgv_habtiacionesAgregadas.AllowUserToAddRows = False
        Me.dgv_habtiacionesAgregadas.AllowUserToDeleteRows = False
        Me.dgv_habtiacionesAgregadas.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv_habtiacionesAgregadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_habtiacionesAgregadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_habtiacionesAgregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habtiacionesAgregadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgv_habtiacionesAgregadas.Location = New System.Drawing.Point(8, 214)
        Me.dgv_habtiacionesAgregadas.Name = "dgv_habtiacionesAgregadas"
        Me.dgv_habtiacionesAgregadas.ReadOnly = True
        Me.dgv_habtiacionesAgregadas.RowHeadersVisible = False
        Me.dgv_habtiacionesAgregadas.Size = New System.Drawing.Size(803, 103)
        Me.dgv_habtiacionesAgregadas.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#Habitacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Capacidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Camas Matrimoniales"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Camas Individuales"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hotel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo Habitacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 26
        '
        'bt_limpiar
        '
        Me.bt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_limpiar.Location = New System.Drawing.Point(625, 572)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(94, 23)
        Me.bt_limpiar.TabIndex = 19
        Me.bt_limpiar.Text = "Limpiar"
        Me.bt_limpiar.UseVisualStyleBackColor = True
        '
        'bt_res_guar
        '
        Me.bt_res_guar.Enabled = False
        Me.bt_res_guar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_res_guar.Location = New System.Drawing.Point(734, 572)
        Me.bt_res_guar.Name = "bt_res_guar"
        Me.bt_res_guar.Size = New System.Drawing.Size(94, 23)
        Me.bt_res_guar.TabIndex = 20
        Me.bt_res_guar.Text = "Actualizar"
        Me.bt_res_guar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.data_reservacion)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_idreservacion)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(7, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(818, 55)
        Me.Panel1.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(559, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Fecha de Reservacion"
        '
        'data_reservacion
        '
        Me.data_reservacion.Location = New System.Drawing.Point(559, 24)
        Me.data_reservacion.Name = "data_reservacion"
        Me.data_reservacion.Size = New System.Drawing.Size(188, 20)
        Me.data_reservacion.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(318, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "ID"
        '
        'txt_idreservacion
        '
        Me.txt_idreservacion.Enabled = False
        Me.txt_idreservacion.Location = New System.Drawing.Point(321, 24)
        Me.txt_idreservacion.Name = "txt_idreservacion"
        Me.txt_idreservacion.Size = New System.Drawing.Size(163, 20)
        Me.txt_idreservacion.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(62, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 31)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Reservacion"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form_ModifRese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 607)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_habitaciones)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.bt_res_guar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_ModifRese"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion Reservacion"
        CType(Me.dgv_habitacionReservadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_habitaciones.ResumeLayout(False)
        Me.panel_habitaciones.PerformLayout()
        CType(Me.dgv_habtiacionesAgregadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_dias As TextBox
    Friend WithEvents bt_buscarCliente As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lb_costoTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lb_no_habitaciones As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_habitacionReservadas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents date_salida As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents date_entrada As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_agregarMasHabitaciones As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents panel_habitaciones As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents bt_limpiar As Button
    Friend WithEvents bt_res_guar As Button
    Friend WithEvents dgv_habtiacionesAgregadas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents data_reservacion As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_idreservacion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class

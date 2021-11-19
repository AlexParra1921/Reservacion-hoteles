<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_reservaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_idreservacion = New System.Windows.Forms.Label()
        Me.lb_fecha = New System.Windows.Forms.Label()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.bt_buscarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_agregarCliente = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_limpiar = New System.Windows.Forms.Button()
        Me.bt_res_guar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.date_entrada = New System.Windows.Forms.DateTimePicker()
        Me.date_salida = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_no_habitaciones = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lb_costo = New System.Windows.Forms.Label()
        Me.lb_costIva = New System.Windows.Forms.Label()
        Me.lb_costoTotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.lb_fecha)
        Me.Panel1.Controls.Add(Me.lb_idreservacion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 28)
        Me.Panel1.TabIndex = 0
        '
        'lb_idreservacion
        '
        Me.lb_idreservacion.AutoSize = True
        Me.lb_idreservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_idreservacion.Location = New System.Drawing.Point(12, 9)
        Me.lb_idreservacion.Name = "lb_idreservacion"
        Me.lb_idreservacion.Size = New System.Drawing.Size(116, 13)
        Me.lb_idreservacion.TabIndex = 1
        Me.lb_idreservacion.Text = "ID RESERVACION:"
        '
        'lb_fecha
        '
        Me.lb_fecha.AutoSize = True
        Me.lb_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha.Location = New System.Drawing.Point(713, 9)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(118, 13)
        Me.lb_fecha.TabIndex = 2
        Me.lb_fecha.Text = "Fecha: 22/10/2021"
        '
        'txt_idcliente
        '
        Me.txt_idcliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_idcliente.Location = New System.Drawing.Point(9, 25)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(166, 20)
        Me.txt_idcliente.TabIndex = 1
        '
        'bt_buscarCliente
        '
        Me.bt_buscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_buscarCliente.Location = New System.Drawing.Point(242, 7)
        Me.bt_buscarCliente.Name = "bt_buscarCliente"
        Me.bt_buscarCliente.Size = New System.Drawing.Size(94, 23)
        Me.bt_buscarCliente.TabIndex = 2
        Me.bt_buscarCliente.Text = "Buscar"
        Me.bt_buscarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CLIENTE"
        '
        'bt_agregarCliente
        '
        Me.bt_agregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_agregarCliente.Location = New System.Drawing.Point(242, 33)
        Me.bt_agregarCliente.Name = "bt_agregarCliente"
        Me.bt_agregarCliente.Size = New System.Drawing.Size(94, 23)
        Me.bt_agregarCliente.TabIndex = 4
        Me.bt_agregarCliente.Text = "Agregar"
        Me.bt_agregarCliente.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_telefono)
        Me.Panel2.Controls.Add(Me.txt_materno)
        Me.Panel2.Controls.Add(Me.txt_paterno)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.bt_agregarCliente)
        Me.Panel2.Controls.Add(Me.txt_idcliente)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.bt_buscarCliente)
        Me.Panel2.Location = New System.Drawing.Point(12, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(819, 124)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_nombre.Location = New System.Drawing.Point(9, 77)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(166, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_paterno
        '
        Me.txt_paterno.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_paterno.Location = New System.Drawing.Point(200, 77)
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(201, 20)
        Me.txt_paterno.TabIndex = 7
        '
        'txt_materno
        '
        Me.txt_materno.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_materno.Location = New System.Drawing.Point(428, 77)
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(201, 20)
        Me.txt_materno.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_telefono.Location = New System.Drawing.Point(648, 77)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(166, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(197, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(425, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(645, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefono"
        '
        'bt_limpiar
        '
        Me.bt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_limpiar.Location = New System.Drawing.Point(599, 458)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(94, 23)
        Me.bt_limpiar.TabIndex = 14
        Me.bt_limpiar.Text = "Limpiar"
        Me.bt_limpiar.UseVisualStyleBackColor = True
        '
        'bt_res_guar
        '
        Me.bt_res_guar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_res_guar.Location = New System.Drawing.Point(737, 458)
        Me.bt_res_guar.Name = "bt_res_guar"
        Me.bt_res_guar.Size = New System.Drawing.Size(94, 23)
        Me.bt_res_guar.TabIndex = 15
        Me.bt_res_guar.Text = "Reservar"
        Me.bt_res_guar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lb_costoTotal)
        Me.Panel3.Controls.Add(Me.lb_costIva)
        Me.Panel3.Controls.Add(Me.lb_costo)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.label)
        Me.Panel3.Controls.Add(Me.lb_no_habitaciones)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.date_salida)
        Me.Panel3.Controls.Add(Me.date_entrada)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(12, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(819, 288)
        Me.Panel3.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(677, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Buscar Habitaciones"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'date_entrada
        '
        Me.date_entrada.Checked = False
        Me.date_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_entrada.Location = New System.Drawing.Point(8, 37)
        Me.date_entrada.Name = "date_entrada"
        Me.date_entrada.Size = New System.Drawing.Size(166, 20)
        Me.date_entrada.TabIndex = 15
        Me.date_entrada.Value = New Date(2021, 11, 19, 0, 0, 0, 0)
        '
        'date_salida
        '
        Me.date_salida.Checked = False
        Me.date_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_salida.Location = New System.Drawing.Point(234, 37)
        Me.date_salida.Name = "date_salida"
        Me.date_salida.Size = New System.Drawing.Size(168, 20)
        Me.date_salida.TabIndex = 16
        Me.date_salida.Value = New Date(2021, 11, 19, 0, 0, 0, 0)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Fecha Salida"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(803, 162)
        Me.DataGridView1.TabIndex = 19
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
        'lb_no_habitaciones
        '
        Me.lb_no_habitaciones.AutoSize = True
        Me.lb_no_habitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_no_habitaciones.Location = New System.Drawing.Point(7, 255)
        Me.lb_no_habitaciones.Name = "lb_no_habitaciones"
        Me.lb_no_habitaciones.Size = New System.Drawing.Size(132, 16)
        Me.lb_no_habitaciones.TabIndex = 20
        Me.lb_no_habitaciones.Text = "No. Habitaciones:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(295, 236)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(59, 18)
        Me.label.TabIndex = 21
        Me.label.Text = "Costo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(251, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Costo + IVA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(491, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Costo Total:"
        '
        'lb_costo
        '
        Me.lb_costo.AutoSize = True
        Me.lb_costo.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_costo.Location = New System.Drawing.Point(360, 235)
        Me.lb_costo.Name = "lb_costo"
        Me.lb_costo.Size = New System.Drawing.Size(45, 20)
        Me.lb_costo.TabIndex = 14
        Me.lb_costo.Text = "$500"
        '
        'lb_costIva
        '
        Me.lb_costIva.AutoSize = True
        Me.lb_costIva.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_costIva.Location = New System.Drawing.Point(360, 261)
        Me.lb_costIva.Name = "lb_costIva"
        Me.lb_costIva.Size = New System.Drawing.Size(91, 20)
        Me.lb_costIva.TabIndex = 24
        Me.lb_costIva.Text = "$500 + 150"
        '
        'lb_costoTotal
        '
        Me.lb_costoTotal.AutoSize = True
        Me.lb_costoTotal.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_costoTotal.Location = New System.Drawing.Point(599, 253)
        Me.lb_costoTotal.Name = "lb_costoTotal"
        Me.lb_costoTotal.Size = New System.Drawing.Size(45, 20)
        Me.lb_costoTotal.TabIndex = 25
        Me.lb_costoTotal.Text = "$650"
        '
        'Form_reservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 493)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bt_res_guar)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_reservaciones"
        Me.Text = "Form_reservaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lb_fecha As Label
    Friend WithEvents lb_idreservacion As Label
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents bt_buscarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_agregarCliente As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents bt_limpiar As Button
    Friend WithEvents bt_res_guar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents date_entrada As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents date_salida As DateTimePicker
    Friend WithEvents lb_no_habitaciones As Label
    Friend WithEvents lb_costIva As Label
    Friend WithEvents lb_costo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents label As Label
    Friend WithEvents lb_costoTotal As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bt_habitaciones = New System.Windows.Forms.Button()
        Me.bt_reservaciones = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.bt_cliente = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.bt_salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabitacionesDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarHabitacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuespedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarHuespedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarTelefonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleinteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUbicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HuespedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Button3.Location = New System.Drawing.Point(6, 369)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.MaximumSize = New System.Drawing.Size(182, 430)
        Me.Button3.MinimumSize = New System.Drawing.Size(182, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(5)
        Me.Button3.Size = New System.Drawing.Size(182, 119)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Huespedes"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bt_habitaciones
        '
        Me.bt_habitaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bt_habitaciones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_habitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_habitaciones.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_habitaciones.ForeColor = System.Drawing.Color.LightSlateGray
        Me.bt_habitaciones.Location = New System.Drawing.Point(6, 248)
        Me.bt_habitaciones.Margin = New System.Windows.Forms.Padding(1)
        Me.bt_habitaciones.MaximumSize = New System.Drawing.Size(182, 430)
        Me.bt_habitaciones.MinimumSize = New System.Drawing.Size(182, 72)
        Me.bt_habitaciones.Name = "bt_habitaciones"
        Me.bt_habitaciones.Padding = New System.Windows.Forms.Padding(2)
        Me.bt_habitaciones.Size = New System.Drawing.Size(182, 119)
        Me.bt_habitaciones.TabIndex = 1
        Me.bt_habitaciones.Text = "Habitaciones"
        Me.bt_habitaciones.UseVisualStyleBackColor = False
        '
        'bt_reservaciones
        '
        Me.bt_reservaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bt_reservaciones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_reservaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_reservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_reservaciones.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reservaciones.ForeColor = System.Drawing.Color.LightSlateGray
        Me.bt_reservaciones.Location = New System.Drawing.Point(6, 6)
        Me.bt_reservaciones.Margin = New System.Windows.Forms.Padding(1)
        Me.bt_reservaciones.MaximumSize = New System.Drawing.Size(182, 430)
        Me.bt_reservaciones.MinimumSize = New System.Drawing.Size(182, 72)
        Me.bt_reservaciones.Name = "bt_reservaciones"
        Me.bt_reservaciones.Padding = New System.Windows.Forms.Padding(5)
        Me.bt_reservaciones.Size = New System.Drawing.Size(182, 119)
        Me.bt_reservaciones.TabIndex = 0
        Me.bt_reservaciones.Text = "Reservaciones"
        Me.bt_reservaciones.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.FlowLayoutPanel1.Controls.Add(Me.bt_reservaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.bt_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.bt_habitaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.bt_salir)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(185, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(193, 617)
        Me.FlowLayoutPanel1.TabIndex = 4
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'bt_cliente
        '
        Me.bt_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bt_cliente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cliente.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cliente.ForeColor = System.Drawing.Color.LightSlateGray
        Me.bt_cliente.Location = New System.Drawing.Point(6, 127)
        Me.bt_cliente.Margin = New System.Windows.Forms.Padding(1)
        Me.bt_cliente.MaximumSize = New System.Drawing.Size(182, 430)
        Me.bt_cliente.MinimumSize = New System.Drawing.Size(182, 72)
        Me.bt_cliente.Name = "bt_cliente"
        Me.bt_cliente.Padding = New System.Windows.Forms.Padding(5)
        Me.bt_cliente.Size = New System.Drawing.Size(182, 119)
        Me.bt_cliente.TabIndex = 3
        Me.bt_cliente.Text = "Clientes"
        Me.bt_cliente.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'bt_salir
        '
        Me.bt_salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bt_salir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bt_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_salir.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_salir.ForeColor = System.Drawing.Color.LightSlateGray
        Me.bt_salir.Location = New System.Drawing.Point(6, 490)
        Me.bt_salir.Margin = New System.Windows.Forms.Padding(1)
        Me.bt_salir.MaximumSize = New System.Drawing.Size(182, 430)
        Me.bt_salir.MinimumSize = New System.Drawing.Size(182, 72)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Padding = New System.Windows.Forms.Padding(2)
        Me.bt_salir.Size = New System.Drawing.Size(182, 119)
        Me.bt_salir.TabIndex = 4
        Me.bt_salir.Text = "Salir"
        Me.bt_salir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(193, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 52)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(193, 604)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 37)
        Me.Panel2.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ReservacionesToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.HabitacionToolStripMenuItem, Me.HuespedToolStripMenuItem, Me.MasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(193, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(761, 528)
        Me.Panel3.TabIndex = 8
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReservacionesToolStripMenuItem
        '
        Me.ReservacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.ReservacionesToolStripMenuItem.Name = "ReservacionesToolStripMenuItem"
        Me.ReservacionesToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ReservacionesToolStripMenuItem.Text = "Reservaciones"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.EliminarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar cliente"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar cliente"
        '
        'HabitacionToolStripMenuItem
        '
        Me.HabitacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HabitacionesDisponiblesToolStripMenuItem, Me.AdministrarHabitacionesToolStripMenuItem, Me.CancelarHabitacionToolStripMenuItem})
        Me.HabitacionToolStripMenuItem.Name = "HabitacionToolStripMenuItem"
        Me.HabitacionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.HabitacionToolStripMenuItem.Text = "Habitaciones"
        '
        'HabitacionesDisponiblesToolStripMenuItem
        '
        Me.HabitacionesDisponiblesToolStripMenuItem.Name = "HabitacionesDisponiblesToolStripMenuItem"
        Me.HabitacionesDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.HabitacionesDisponiblesToolStripMenuItem.Text = "Habitaciones disponibles"
        '
        'AdministrarHabitacionesToolStripMenuItem
        '
        Me.AdministrarHabitacionesToolStripMenuItem.Name = "AdministrarHabitacionesToolStripMenuItem"
        Me.AdministrarHabitacionesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AdministrarHabitacionesToolStripMenuItem.Text = "Administrar Habitaciones"
        '
        'CancelarHabitacionToolStripMenuItem
        '
        Me.CancelarHabitacionToolStripMenuItem.Name = "CancelarHabitacionToolStripMenuItem"
        Me.CancelarHabitacionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CancelarHabitacionToolStripMenuItem.Text = "Cancelar Habitacion"
        '
        'HuespedToolStripMenuItem
        '
        Me.HuespedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarHuespedesToolStripMenuItem})
        Me.HuespedToolStripMenuItem.Name = "HuespedToolStripMenuItem"
        Me.HuespedToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HuespedToolStripMenuItem.Text = "Huesped"
        '
        'AdministrarHuespedesToolStripMenuItem
        '
        Me.AdministrarHuespedesToolStripMenuItem.Name = "AdministrarHuespedesToolStripMenuItem"
        Me.AdministrarHuespedesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarHuespedesToolStripMenuItem.Text = "Administrar Huespedes"
        '
        'MasToolStripMenuItem
        '
        Me.MasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUbicacionToolStripMenuItem, Me.AgregarCategoriasToolStripMenuItem, Me.BuscarTelefonoToolStripMenuItem})
        Me.MasToolStripMenuItem.Name = "MasToolStripMenuItem"
        Me.MasToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.MasToolStripMenuItem.Text = "Mas"
        '
        'AgregarCategoriasToolStripMenuItem
        '
        Me.AgregarCategoriasToolStripMenuItem.Name = "AgregarCategoriasToolStripMenuItem"
        Me.AgregarCategoriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarCategoriasToolStripMenuItem.Text = "Agregar categorias"
        '
        'BuscarTelefonoToolStripMenuItem
        '
        Me.BuscarTelefonoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleinteToolStripMenuItem, Me.HuespedToolStripMenuItem1})
        Me.BuscarTelefonoToolStripMenuItem.Name = "BuscarTelefonoToolStripMenuItem"
        Me.BuscarTelefonoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarTelefonoToolStripMenuItem.Text = "Buscar telefono"
        '
        'CleinteToolStripMenuItem
        '
        Me.CleinteToolStripMenuItem.Name = "CleinteToolStripMenuItem"
        Me.CleinteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CleinteToolStripMenuItem.Text = "Cliente"
        '
        'AgregarUbicacionToolStripMenuItem
        '
        Me.AgregarUbicacionToolStripMenuItem.Name = "AgregarUbicacionToolStripMenuItem"
        Me.AgregarUbicacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarUbicacionToolStripMenuItem.Text = "Agregar Ubicacion"
        '
        'HuespedToolStripMenuItem1
        '
        Me.HuespedToolStripMenuItem1.Name = "HuespedToolStripMenuItem1"
        Me.HuespedToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.HuespedToolStripMenuItem1.Text = "Huesped"
        '
        'ControlEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(954, 641)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.Name = "ControlEmpleado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Reservaciones y Habitaciones"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents bt_habitaciones As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents bt_reservaciones As Button
    Friend WithEvents bt_cliente As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents bt_salir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HabitacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HabitacionesDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarHabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarHabitacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HuespedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarHuespedesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUbicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarTelefonoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleinteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HuespedToolStripMenuItem1 As ToolStripMenuItem
End Class

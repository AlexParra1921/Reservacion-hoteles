﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BuscarHabitaciones
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
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.dgv_BusquedaHabitacion = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_habitacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_hotel = New System.Windows.Forms.ComboBox()
        Me.dgv_habitacionSeleccionadas = New System.Windows.Forms.DataGridView()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_BusquedaHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_habitacionSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_cancelar
        '
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Location = New System.Drawing.Point(670, 489)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(106, 37)
        Me.bt_cancelar.TabIndex = 10
        Me.bt_cancelar.Text = "Salir"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'dgv_BusquedaHabitacion
        '
        Me.dgv_BusquedaHabitacion.AllowUserToAddRows = False
        Me.dgv_BusquedaHabitacion.AllowUserToDeleteRows = False
        Me.dgv_BusquedaHabitacion.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_BusquedaHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_BusquedaHabitacion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_BusquedaHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BusquedaHabitacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_BusquedaHabitacion.Location = New System.Drawing.Point(6, 86)
        Me.dgv_BusquedaHabitacion.Name = "dgv_BusquedaHabitacion"
        Me.dgv_BusquedaHabitacion.ReadOnly = True
        Me.dgv_BusquedaHabitacion.RowHeadersVisible = False
        Me.dgv_BusquedaHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_BusquedaHabitacion.Size = New System.Drawing.Size(752, 160)
        Me.dgv_BusquedaHabitacion.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Buscar Habitaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cb_habitacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_categoria)
        Me.GroupBox1.Controls.Add(Me.dgv_BusquedaHabitacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_hotel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 252)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(531, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Habitacion"
        '
        'cb_habitacion
        '
        Me.cb_habitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_habitacion.FormattingEnabled = True
        Me.cb_habitacion.Location = New System.Drawing.Point(534, 41)
        Me.cb_habitacion.Name = "cb_habitacion"
        Me.cb_habitacion.Size = New System.Drawing.Size(214, 24)
        Me.cb_habitacion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Categoria Habitacion"
        '
        'cb_categoria
        '
        Me.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(258, 41)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(214, 24)
        Me.cb_categoria.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hotel"
        '
        'cb_hotel
        '
        Me.cb_hotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cb_hotel.FormattingEnabled = True
        Me.cb_hotel.Location = New System.Drawing.Point(9, 41)
        Me.cb_hotel.Name = "cb_hotel"
        Me.cb_hotel.Size = New System.Drawing.Size(214, 24)
        Me.cb_hotel.TabIndex = 0
        '
        'dgv_habitacionSeleccionadas
        '
        Me.dgv_habitacionSeleccionadas.AllowUserToAddRows = False
        Me.dgv_habitacionSeleccionadas.AllowUserToDeleteRows = False
        Me.dgv_habitacionSeleccionadas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_habitacionSeleccionadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_habitacionSeleccionadas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_habitacionSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habitacionSeleccionadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_habitacionSeleccionadas.Location = New System.Drawing.Point(24, 331)
        Me.dgv_habitacionSeleccionadas.Name = "dgv_habitacionSeleccionadas"
        Me.dgv_habitacionSeleccionadas.ReadOnly = True
        Me.dgv_habitacionSeleccionadas.RowHeadersVisible = False
        Me.dgv_habitacionSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_habitacionSeleccionadas.Size = New System.Drawing.Size(752, 152)
        Me.dgv_habitacionSeleccionadas.TabIndex = 7
        '
        'bt_agregar
        '
        Me.bt_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_agregar.Location = New System.Drawing.Point(670, 288)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(106, 37)
        Me.bt_agregar.TabIndex = 18
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_eliminar.Location = New System.Drawing.Point(539, 288)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(106, 37)
        Me.bt_eliminar.TabIndex = 19
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Form_BuscarHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 541)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.dgv_habitacionSeleccionadas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bt_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_BuscarHabitaciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Habitaciones"
        CType(Me.dgv_BusquedaHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_habitacionSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_cancelar As Button
    Friend WithEvents dgv_BusquedaHabitacion As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_hotel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_habitacion As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_categoria As ComboBox
    Friend WithEvents dgv_habitacionSeleccionadas As DataGridView
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_eliminar As Button
End Class

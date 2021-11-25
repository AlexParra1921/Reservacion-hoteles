<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHabitacion
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
        Me.lb_telefono = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxHab = New System.Windows.Forms.MaskedTextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.TextBoxDisponibilidad = New System.Windows.Forms.TextBox()
        Me.dgv_hab = New System.Windows.Forms.DataGridView()
        Me.ComboBoxHotel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_hab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_telefono
        '
        Me.lb_telefono.AutoSize = True
        Me.lb_telefono.ForeColor = System.Drawing.Color.Red
        Me.lb_telefono.Location = New System.Drawing.Point(12, 146)
        Me.lb_telefono.Name = "lb_telefono"
        Me.lb_telefono.Size = New System.Drawing.Size(0, 13)
        Me.lb_telefono.TabIndex = 36
        Me.lb_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Introduce la habitacion"
        '
        'TextBoxHab
        '
        Me.TextBoxHab.BackColor = System.Drawing.Color.White
        Me.TextBoxHab.Location = New System.Drawing.Point(405, 79)
        Me.TextBoxHab.Mask = "99999999999999999999999"
        Me.TextBoxHab.Name = "TextBoxHab"
        Me.TextBoxHab.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TextBoxHab.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxHab.TabIndex = 28
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(658, 164)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 30
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Hotel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Numero de Habitacion"
        '
        'Limpiar
        '
        Me.Limpiar.AllowDrop = True
        Me.Limpiar.Location = New System.Drawing.Point(658, 120)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 25
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Eliminar.Location = New System.Drawing.Point(658, 91)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 26
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(658, 62)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 24
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'TextBoxDisponibilidad
        '
        Me.TextBoxDisponibilidad.Location = New System.Drawing.Point(12, 148)
        Me.TextBoxDisponibilidad.Name = "TextBoxDisponibilidad"
        Me.TextBoxDisponibilidad.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxDisponibilidad.TabIndex = 23
        '
        'dgv_hab
        '
        Me.dgv_hab.AllowUserToAddRows = False
        Me.dgv_hab.AllowUserToDeleteRows = False
        Me.dgv_hab.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_hab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hab.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_hab.Location = New System.Drawing.Point(12, 191)
        Me.dgv_hab.Name = "dgv_hab"
        Me.dgv_hab.ReadOnly = True
        Me.dgv_hab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgv_hab.RowHeadersVisible = False
        Me.dgv_hab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_hab.Size = New System.Drawing.Size(776, 214)
        Me.dgv_hab.TabIndex = 27
        '
        'ComboBoxHotel
        '
        Me.ComboBoxHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxHotel.FormattingEnabled = True
        Me.ComboBoxHotel.Location = New System.Drawing.Point(9, 79)
        Me.ComboBoxHotel.Name = "ComboBoxHotel"
        Me.ComboBoxHotel.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxHotel.TabIndex = 38
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(209, 79)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxCat.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Habitaciones"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BackColor = System.Drawing.Color.White
        Me.TextBoxBuscar.Location = New System.Drawing.Point(405, 148)
        Me.TextBoxBuscar.Mask = "99999999999999999999999"
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TextBoxBuscar.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxBuscar.TabIndex = 42
        '
        'FormHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxCat)
        Me.Controls.Add(Me.ComboBoxHotel)
        Me.Controls.Add(Me.lb_telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxHab)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.TextBoxDisponibilidad)
        Me.Controls.Add(Me.dgv_hab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHabitacion"
        Me.Text = "FormHabitacion"
        CType(Me.dgv_hab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_telefono As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxHab As MaskedTextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Limpiar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents TextBoxDisponibilidad As TextBox
    Friend WithEvents dgv_hab As DataGridView
    Friend WithEvents ComboBoxHotel As ComboBox
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxBuscar As MaskedTextBox
End Class

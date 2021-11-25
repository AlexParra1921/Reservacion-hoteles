<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCategoriaHabitacion
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
        Me.NumCat = New System.Windows.Forms.Label()
        Me.CamasMatri = New System.Windows.Forms.Label()
        Me.CamasIndiv = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCM = New System.Windows.Forms.TextBox()
        Me.TextBoxCI = New System.Windows.Forms.TextBox()
        Me.TextBoxCat = New System.Windows.Forms.TextBox()
        Me.dgvCat = New System.Windows.Forms.DataGridView()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumCat
        '
        Me.NumCat.AutoSize = True
        Me.NumCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCat.Location = New System.Drawing.Point(28, 51)
        Me.NumCat.Name = "NumCat"
        Me.NumCat.Size = New System.Drawing.Size(113, 18)
        Me.NumCat.TabIndex = 1
        Me.NumCat.Text = "N° de Categoría"
        '
        'CamasMatri
        '
        Me.CamasMatri.AutoSize = True
        Me.CamasMatri.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamasMatri.Location = New System.Drawing.Point(28, 89)
        Me.CamasMatri.Name = "CamasMatri"
        Me.CamasMatri.Size = New System.Drawing.Size(178, 18)
        Me.CamasMatri.TabIndex = 3
        Me.CamasMatri.Text = "N° Camas Matrimoniales:"
        '
        'CamasIndiv
        '
        Me.CamasIndiv.AutoSize = True
        Me.CamasIndiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamasIndiv.Location = New System.Drawing.Point(364, 48)
        Me.CamasIndiv.Name = "CamasIndiv"
        Me.CamasIndiv.Size = New System.Drawing.Size(160, 18)
        Me.CamasIndiv.TabIndex = 5
        Me.CamasIndiv.Text = "N° Camas Individuales:"
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.Location = New System.Drawing.Point(364, 86)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(92, 18)
        Me.Precio.TabIndex = 6
        Me.Precio.Text = "Precio Total:"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(474, 83)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(129, 24)
        Me.TextBoxPrecio.TabIndex = 7
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(480, 323)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(90, 30)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(576, 323)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(90, 30)
        Me.Limpiar.TabIndex = 9
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Datos de Categoría"
        '
        'TextBoxCM
        '
        Me.TextBoxCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCM.Location = New System.Drawing.Point(208, 86)
        Me.TextBoxCM.Name = "TextBoxCM"
        Me.TextBoxCM.Size = New System.Drawing.Size(129, 24)
        Me.TextBoxCM.TabIndex = 12
        '
        'TextBoxCI
        '
        Me.TextBoxCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCI.Location = New System.Drawing.Point(530, 45)
        Me.TextBoxCI.Name = "TextBoxCI"
        Me.TextBoxCI.Size = New System.Drawing.Size(129, 24)
        Me.TextBoxCI.TabIndex = 13
        '
        'TextBoxCat
        '
        Me.TextBoxCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCat.Location = New System.Drawing.Point(170, 48)
        Me.TextBoxCat.Name = "TextBoxCat"
        Me.TextBoxCat.Size = New System.Drawing.Size(129, 24)
        Me.TextBoxCat.TabIndex = 14
        '
        'dgvCat
        '
        Me.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCat.Location = New System.Drawing.Point(31, 165)
        Me.dgvCat.Name = "dgvCat"
        Me.dgvCat.Size = New System.Drawing.Size(628, 150)
        Me.dgvCat.TabIndex = 15
        '
        'Buscar
        '
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(288, 321)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(90, 30)
        Me.Buscar.TabIndex = 16
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(384, 322)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(90, 30)
        Me.Guardar.TabIndex = 17
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBusca.Location = New System.Drawing.Point(530, 135)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(129, 24)
        Me.TextBoxBusca.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Busca el N° de Cat"
        '
        'formCategoriaHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 356)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBusca)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.dgvCat)
        Me.Controls.Add(Me.TextBoxCat)
        Me.Controls.Add(Me.TextBoxCI)
        Me.Controls.Add(Me.TextBoxCM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.CamasIndiv)
        Me.Controls.Add(Me.CamasMatri)
        Me.Controls.Add(Me.NumCat)
        Me.Name = "formCategoriaHabitacion"
        Me.Text = "Categoría de Habitación"
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumCat As Label
    Friend WithEvents CamasMatri As Label
    Friend WithEvents CamasIndiv As Label
    Friend WithEvents Precio As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents Eliminar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCM As TextBox
    Friend WithEvents TextBoxCI As TextBox
    Friend WithEvents TextBoxCat As TextBox
    Friend WithEvents dgvCat As DataGridView
    Friend WithEvents Buscar As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents Label2 As Label
End Class

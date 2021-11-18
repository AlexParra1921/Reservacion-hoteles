<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(474, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 24)
        Me.TextBox1.TabIndex = 7
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(480, 285)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(90, 30)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(576, 285)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(90, 30)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
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
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(208, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(129, 24)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(530, 45)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(129, 24)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(170, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(129, 24)
        Me.TextBox4.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(628, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'Nuevo
        '
        Me.Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Location = New System.Drawing.Point(288, 283)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(90, 30)
        Me.Nuevo.TabIndex = 16
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(384, 284)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(90, 30)
        Me.Guardar.TabIndex = 17
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 321)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.CamasIndiv)
        Me.Controls.Add(Me.CamasMatri)
        Me.Controls.Add(Me.NumCat)
        Me.Name = "Categoria"
        Me.Text = "Categoría de Habitación"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumCat As Label
    Friend WithEvents CamasMatri As Label
    Friend WithEvents CamasIndiv As Label
    Friend WithEvents Precio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Eliminar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nuevo As Button
    Friend WithEvents Guardar As Button
End Class

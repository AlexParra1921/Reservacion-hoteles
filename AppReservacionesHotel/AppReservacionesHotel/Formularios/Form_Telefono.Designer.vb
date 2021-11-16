<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Telefono
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_telefonoCliente = New System.Windows.Forms.DataGridView()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_seleccionar = New System.Windows.Forms.Button()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        CType(Me.dgv_telefonoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de telefono"
        '
        'dgv_telefonoCliente
        '
        Me.dgv_telefonoCliente.AllowUserToAddRows = False
        Me.dgv_telefonoCliente.AllowUserToDeleteRows = False
        Me.dgv_telefonoCliente.AllowUserToResizeColumns = False
        Me.dgv_telefonoCliente.AllowUserToResizeRows = False
        Me.dgv_telefonoCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgv_telefonoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_telefonoCliente.Location = New System.Drawing.Point(12, 66)
        Me.dgv_telefonoCliente.Name = "dgv_telefonoCliente"
        Me.dgv_telefonoCliente.RowHeadersVisible = False
        Me.dgv_telefonoCliente.Size = New System.Drawing.Size(610, 261)
        Me.dgv_telefonoCliente.TabIndex = 4
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(194, 20)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(92, 36)
        Me.bt_agregar.TabIndex = 6
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'bt_seleccionar
        '
        Me.bt_seleccionar.Location = New System.Drawing.Point(530, 20)
        Me.bt_seleccionar.Name = "bt_seleccionar"
        Me.bt_seleccionar.Size = New System.Drawing.Size(92, 34)
        Me.bt_seleccionar.TabIndex = 8
        Me.bt_seleccionar.Text = "Seleccionar"
        Me.bt_seleccionar.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(12, 28)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(163, 20)
        Me.txt_numero.TabIndex = 9
        '
        'Form_Telefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 339)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.bt_seleccionar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.dgv_telefonoCliente)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form_Telefono"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar telefono"
        CType(Me.dgv_telefonoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_telefonoCliente As DataGridView
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_seleccionar As Button
    Friend WithEvents txt_numero As TextBox
End Class

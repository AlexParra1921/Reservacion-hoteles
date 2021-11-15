<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cliente
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
        Me.dgv_cliente = New System.Windows.Forms.DataGridView()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txtbox_apellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtbox_apellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtbox_id = New System.Windows.Forms.TextBox()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_cliente
        '
        Me.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cliente.Location = New System.Drawing.Point(12, 136)
        Me.dgv_cliente.Name = "dgv_cliente"
        Me.dgv_cliente.Size = New System.Drawing.Size(776, 302)
        Me.dgv_cliente.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(12, 77)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txtbox_apellidoPaterno
        '
        Me.txtbox_apellidoPaterno.Location = New System.Drawing.Point(202, 77)
        Me.txtbox_apellidoPaterno.Name = "txtbox_apellidoPaterno"
        Me.txtbox_apellidoPaterno.Size = New System.Drawing.Size(184, 20)
        Me.txtbox_apellidoPaterno.TabIndex = 2
        '
        'txtbox_apellidoMaterno
        '
        Me.txtbox_apellidoMaterno.Location = New System.Drawing.Point(392, 77)
        Me.txtbox_apellidoMaterno.Name = "txtbox_apellidoMaterno"
        Me.txtbox_apellidoMaterno.Size = New System.Drawing.Size(191, 20)
        Me.txtbox_apellidoMaterno.TabIndex = 3
        '
        'txtbox_id
        '
        Me.txtbox_id.Location = New System.Drawing.Point(12, 25)
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.Size = New System.Drawing.Size(137, 20)
        Me.txtbox_id.TabIndex = 4
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(658, 22)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_agregar.TabIndex = 5
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(658, 51)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 6
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'bt_guardar
        '
        Me.bt_guardar.AllowDrop = True
        Me.bt_guardar.Location = New System.Drawing.Point(658, 80)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 7
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ID "
        '
        'Form_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.txtbox_id)
        Me.Controls.Add(Me.txtbox_apellidoMaterno)
        Me.Controls.Add(Me.txtbox_apellidoPaterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.dgv_cliente)
        Me.Name = "Form_cliente"
        Me.Text = "Cliente"
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_cliente As DataGridView
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txtbox_apellidoPaterno As TextBox
    Friend WithEvents txtbox_apellidoMaterno As TextBox
    Friend WithEvents txtbox_id As TextBox
    Friend WithEvents bt_agregar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_guardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class

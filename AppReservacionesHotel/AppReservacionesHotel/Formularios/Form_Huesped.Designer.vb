<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Huesped
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.txtbox_id = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_BuscarID = New System.Windows.Forms.MaskedTextBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_limpiar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.txtbox_apellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtbox_apellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dgv_cliente = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Telefono"
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(12, 109)
        Me.txt_numero.Mask = "000-000-0000"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(184, 26)
        Me.txt_numero.TabIndex = 22
        Me.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_id
        '
        Me.txtbox_id.BackColor = System.Drawing.Color.White
        Me.txtbox_id.Location = New System.Drawing.Point(12, 17)
        Me.txtbox_id.Mask = "99999999999999999999999"
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtbox_id.Size = New System.Drawing.Size(184, 20)
        Me.txtbox_id.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Introduce el ID"
        '
        'txt_BuscarID
        '
        Me.txt_BuscarID.BackColor = System.Drawing.Color.White
        Me.txt_BuscarID.Location = New System.Drawing.Point(392, 148)
        Me.txt_BuscarID.Mask = "99999999999999999999999"
        Me.txt_BuscarID.Name = "txt_BuscarID"
        Me.txt_BuscarID.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_BuscarID.Size = New System.Drawing.Size(191, 20)
        Me.txt_BuscarID.TabIndex = 27
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(658, 148)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(75, 23)
        Me.bt_buscar.TabIndex = 29
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Apellido Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre"
        '
        'bt_limpiar
        '
        Me.bt_limpiar.AllowDrop = True
        Me.bt_limpiar.Location = New System.Drawing.Point(658, 75)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.bt_limpiar.TabIndex = 24
        Me.bt_limpiar.Text = "Limpiar"
        Me.bt_limpiar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_eliminar.Location = New System.Drawing.Point(658, 46)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.bt_eliminar.TabIndex = 25
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'bt_agregar
        '
        Me.bt_agregar.Location = New System.Drawing.Point(658, 17)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_agregar.TabIndex = 23
        Me.bt_agregar.Text = "Guardar"
        Me.bt_agregar.UseVisualStyleBackColor = True
        '
        'txtbox_apellidoMaterno
        '
        Me.txtbox_apellidoMaterno.Location = New System.Drawing.Point(392, 67)
        Me.txtbox_apellidoMaterno.Name = "txtbox_apellidoMaterno"
        Me.txtbox_apellidoMaterno.Size = New System.Drawing.Size(191, 20)
        Me.txtbox_apellidoMaterno.TabIndex = 21
        '
        'txtbox_apellidoPaterno
        '
        Me.txtbox_apellidoPaterno.Location = New System.Drawing.Point(202, 67)
        Me.txtbox_apellidoPaterno.Name = "txtbox_apellidoPaterno"
        Me.txtbox_apellidoPaterno.Size = New System.Drawing.Size(184, 20)
        Me.txtbox_apellidoPaterno.TabIndex = 20
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(12, 67)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre.TabIndex = 19
        '
        'dgv_cliente
        '
        Me.dgv_cliente.AllowUserToAddRows = False
        Me.dgv_cliente.AllowUserToDeleteRows = False
        Me.dgv_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cliente.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_cliente.Location = New System.Drawing.Point(12, 180)
        Me.dgv_cliente.Name = "dgv_cliente"
        Me.dgv_cliente.ReadOnly = True
        Me.dgv_cliente.RowHeadersVisible = False
        Me.dgv_cliente.Size = New System.Drawing.Size(776, 253)
        Me.dgv_cliente.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "ID "
        '
        'Form_Huesped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.txtbox_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_BuscarID)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_agregar)
        Me.Controls.Add(Me.txtbox_apellidoMaterno)
        Me.Controls.Add(Me.txtbox_apellidoPaterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.dgv_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Huesped"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Huesped"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_numero As MaskedTextBox
    Friend WithEvents txtbox_id As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_BuscarID As MaskedTextBox
    Friend WithEvents bt_buscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_limpiar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_agregar As Button
    Friend WithEvents txtbox_apellidoMaterno As TextBox
    Friend WithEvents txtbox_apellidoPaterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents dgv_cliente As DataGridView
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_buscarCliente
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
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.dgv_BusquedaCliente = New System.Windows.Forms.DataGridView()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.bt_seleccionar = New System.Windows.Forms.Button()
        Me.bt_Buscar = New System.Windows.Forms.Button()
        Me.lb_error = New System.Windows.Forms.Label()
        CType(Me.dgv_BusquedaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_idcliente
        '
        Me.txt_idcliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_idcliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idcliente.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idcliente.Location = New System.Drawing.Point(12, 30)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(643, 20)
        Me.txt_idcliente.TabIndex = 1
        Me.txt_idcliente.Text = "Buscar ID"
        '
        'dgv_BusquedaCliente
        '
        Me.dgv_BusquedaCliente.AllowUserToAddRows = False
        Me.dgv_BusquedaCliente.AllowUserToDeleteRows = False
        Me.dgv_BusquedaCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_BusquedaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_BusquedaCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_BusquedaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BusquedaCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_BusquedaCliente.Location = New System.Drawing.Point(12, 67)
        Me.dgv_BusquedaCliente.Name = "dgv_BusquedaCliente"
        Me.dgv_BusquedaCliente.ReadOnly = True
        Me.dgv_BusquedaCliente.RowHeadersVisible = False
        Me.dgv_BusquedaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_BusquedaCliente.Size = New System.Drawing.Size(764, 339)
        Me.dgv_BusquedaCliente.TabIndex = 0
        '
        'bt_cancelar
        '
        Me.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_cancelar.Location = New System.Drawing.Point(549, 412)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(106, 37)
        Me.bt_cancelar.TabIndex = 5
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'bt_seleccionar
        '
        Me.bt_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.bt_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_seleccionar.Location = New System.Drawing.Point(670, 412)
        Me.bt_seleccionar.Name = "bt_seleccionar"
        Me.bt_seleccionar.Size = New System.Drawing.Size(106, 37)
        Me.bt_seleccionar.TabIndex = 4
        Me.bt_seleccionar.Text = "Seleccionar"
        Me.bt_seleccionar.UseVisualStyleBackColor = True
        '
        'bt_Buscar
        '
        Me.bt_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.bt_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Buscar.Location = New System.Drawing.Point(670, 22)
        Me.bt_Buscar.Name = "bt_Buscar"
        Me.bt_Buscar.Size = New System.Drawing.Size(106, 37)
        Me.bt_Buscar.TabIndex = 3
        Me.bt_Buscar.Text = "Buscar"
        Me.bt_Buscar.UseVisualStyleBackColor = True
        '
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(13, 11)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(0, 13)
        Me.lb_error.TabIndex = 6
        '
        'Form_buscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bt_cancelar
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.bt_Buscar)
        Me.Controls.Add(Me.bt_seleccionar)
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.dgv_BusquedaCliente)
        Me.Controls.Add(Me.txt_idcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_buscarCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_buscarCliente"
        Me.TopMost = True
        CType(Me.dgv_BusquedaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents dgv_BusquedaCliente As DataGridView
    Friend WithEvents bt_cancelar As Button
    Friend WithEvents bt_seleccionar As Button
    Friend WithEvents bt_Buscar As Button
    Friend WithEvents lb_error As Label
End Class

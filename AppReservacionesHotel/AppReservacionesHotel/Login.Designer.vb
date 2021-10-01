<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Button_Conectar = New System.Windows.Forms.Button()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.TextBox_Cuenta = New System.Windows.Forms.TextBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox_Hotel = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox_Hotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Conectar
        '
        Me.Button_Conectar.Location = New System.Drawing.Point(244, 118)
        Me.Button_Conectar.Name = "Button_Conectar"
        Me.Button_Conectar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Conectar.TabIndex = 0
        Me.Button_Conectar.Text = "Conectar"
        Me.Button_Conectar.UseVisualStyleBackColor = True
        '
        'Button_Salir
        '
        Me.Button_Salir.Location = New System.Drawing.Point(53, 118)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Button_Salir.TabIndex = 1
        Me.Button_Salir.Text = "Salir"
        Me.Button_Salir.UseVisualStyleBackColor = True
        '
        'TextBox_Cuenta
        '
        Me.TextBox_Cuenta.Location = New System.Drawing.Point(201, 24)
        Me.TextBox_Cuenta.Name = "TextBox_Cuenta"
        Me.TextBox_Cuenta.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_Cuenta.TabIndex = 2
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(201, 66)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_Contraseña.TabIndex = 3
        '
        'PictureBox_Hotel
        '
        Me.PictureBox_Hotel.Image = Global.AppReservacionesHotel.My.Resources.Resources.login_habitacion
        Me.PictureBox_Hotel.Location = New System.Drawing.Point(26, 16)
        Me.PictureBox_Hotel.Name = "PictureBox_Hotel"
        Me.PictureBox_Hotel.Size = New System.Drawing.Size(132, 78)
        Me.PictureBox_Hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Hotel.TabIndex = 4
        Me.PictureBox_Hotel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 166)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_Hotel)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.TextBox_Cuenta)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.Button_Conectar)
        Me.Name = "LoginForm"
        Me.Text = "Login-Reservacion-Hotel"
        CType(Me.PictureBox_Hotel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Conectar As Button
    Friend WithEvents Button_Salir As Button
    Friend WithEvents TextBox_Cuenta As TextBox
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents PictureBox_Hotel As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

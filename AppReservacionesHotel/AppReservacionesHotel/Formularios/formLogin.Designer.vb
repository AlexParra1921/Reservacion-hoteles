<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.Button_Conectar = New System.Windows.Forms.Button()
        Me.Button_Salir = New System.Windows.Forms.Button()
        Me.TextBox_Cuenta = New System.Windows.Forms.TextBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox_Hotel = New System.Windows.Forms.PictureBox()
        Me.label_error_user = New System.Windows.Forms.Label()
        Me.check_remember = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox_Hotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Conectar
        '
        Me.Button_Conectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Conectar.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button_Conectar.Location = New System.Drawing.Point(389, 45)
        Me.Button_Conectar.Name = "Button_Conectar"
        Me.Button_Conectar.Size = New System.Drawing.Size(102, 41)
        Me.Button_Conectar.TabIndex = 0
        Me.Button_Conectar.Text = "Conectar"
        Me.Button_Conectar.UseVisualStyleBackColor = True
        '
        'Button_Salir
        '
        Me.Button_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salir.ForeColor = System.Drawing.Color.Crimson
        Me.Button_Salir.Location = New System.Drawing.Point(206, 132)
        Me.Button_Salir.Name = "Button_Salir"
        Me.Button_Salir.Size = New System.Drawing.Size(83, 41)
        Me.Button_Salir.TabIndex = 1
        Me.Button_Salir.Text = "Salir"
        Me.Button_Salir.UseVisualStyleBackColor = True
        '
        'TextBox_Cuenta
        '
        Me.TextBox_Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Cuenta.Location = New System.Drawing.Point(201, 28)
        Me.TextBox_Cuenta.Name = "TextBox_Cuenta"
        Me.TextBox_Cuenta.Size = New System.Drawing.Size(167, 24)
        Me.TextBox_Cuenta.TabIndex = 2
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(201, 78)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(167, 24)
        Me.TextBox_Contraseña.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'PictureBox_Hotel
        '
        Me.PictureBox_Hotel.Image = Global.AppReservacionesHotel.My.Resources.Resources.login_habitacion
        Me.PictureBox_Hotel.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox_Hotel.Name = "PictureBox_Hotel"
        Me.PictureBox_Hotel.Size = New System.Drawing.Size(196, 187)
        Me.PictureBox_Hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Hotel.TabIndex = 4
        Me.PictureBox_Hotel.TabStop = False
        '
        'label_error_user
        '
        Me.label_error_user.AutoSize = True
        Me.label_error_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_error_user.ForeColor = System.Drawing.Color.Crimson
        Me.label_error_user.Location = New System.Drawing.Point(219, 105)
        Me.label_error_user.Name = "label_error_user"
        Me.label_error_user.Size = New System.Drawing.Size(0, 24)
        Me.label_error_user.TabIndex = 7
        '
        'check_remember
        '
        Me.check_remember.AutoSize = True
        Me.check_remember.Location = New System.Drawing.Point(332, 146)
        Me.check_remember.Name = "check_remember"
        Me.check_remember.Size = New System.Drawing.Size(176, 17)
        Me.check_remember.TabIndex = 8
        Me.check_remember.Text = "Recordar Usuario Y Contraseña"
        Me.check_remember.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(520, 184)
        Me.Controls.Add(Me.check_remember)
        Me.Controls.Add(Me.label_error_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_Hotel)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.TextBox_Cuenta)
        Me.Controls.Add(Me.Button_Salir)
        Me.Controls.Add(Me.Button_Conectar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents label_error_user As Label
    Friend WithEvents check_remember As CheckBox
End Class

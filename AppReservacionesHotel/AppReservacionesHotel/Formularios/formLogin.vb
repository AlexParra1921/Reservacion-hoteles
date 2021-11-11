Public Class LoginForm


    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        'Verificamos lo campos si estan vacios 
        If TextBox_Cuenta.Text.Count < 1 Then
            label_error_user.Text = My.Resources.Vacio_Usuario.ToString
            Return
        End If

        If TextBox_Contraseña.Text.Count < 1 Then
            label_error_user.Text = My.Resources.Vacio_Contraseña
            Return
        End If



        'Realizamos la conexion a la base de datos y verificamos que usuario es el que se autentificado
        'Si es empleado abrira el Formulario de control, si es Administrador Abrira el Control para Administrador
        Dim conex As New Mysql()

        'Realiza la conexion a la base de datos con un usuario
        Try
            conex.conectar(TextBox_Cuenta.Text, TextBox_Contraseña.Text, database_name)
            If userAuthenticated.getSetTipo = 0 Then
                Me.Hide()
                ControlEmpleado.Show()
            ElseIf userAuthenticated.getSetTipo = 1 Then
                MsgBox("Usted es administrador", MsgBoxStyle.Information, "Conexion sastifactoria")
            End If


        Catch ex As Exception
            label_error_user.Text = My.Resources.No_Usuario_contraseña

            'Si hay un error en los textbox no guardar valores
            check_remember.Checked = False
        End Try


    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Me.Close()
    End Sub


    Private Sub TextBox_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Contraseña.TextChanged
        label_error_user.Text = ""
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_remember.Checked = My.Settings.check_usrpass

        If My.Settings.usuario <> "" Then
                TextBox_Cuenta.Text = My.Settings.usuario
            End If

        If My.Settings.contrasena <> "" Then
            TextBox_Contraseña.Text = My.Settings.contrasena
        End If


    End Sub


    Private Sub TextBox_Cuenta_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Cuenta.TextChanged
        label_error_user.Text = ""

    End Sub

    Private Sub FormLogin_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim answer As MsgBoxResult
        answer = MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.YesNo, "Salir")
        If answer = MsgBoxResult.No Then
            e.Cancel = True
        End If
        'Guarda usuario y contraseña
        If check_remember.Checked Then
            My.Settings.usuario = TextBox_Cuenta.Text
            My.Settings.contrasena = TextBox_Contraseña.Text
            My.Settings.check_usrpass = True
        Else
            My.Settings.usuario = ""
            My.Settings.contrasena = ""
            My.Settings.check_usrpass = False
        End If
    End Sub

End Class

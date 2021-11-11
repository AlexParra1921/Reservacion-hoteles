Public Class LoginForm


    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        'Realizamos la conexion a la base de datos y verificamos que usuario es el que se autentificado
        'Si es empleado abrira el Formulario de control, si es Administrador Abrira el Control para Administrador
        Dim conex As New ConexionMYSQL()

        'Verificamos lo campos si estan vacios 
        If TextBox_Cuenta.Text.Count < 1 Then
            label_error_user.Text = My.Resources.Vacio_Usuario.ToString
            Return
        End If
        If TextBox_Contraseña.Text.Count < 1 Then
            label_error_user.Text = My.Resources.Vacio_Contraseña
            Return
        End If

        'Guarda usuario y contraseña
        If check_remember.Checked Then
            My.Settings.usuario = TextBox_Cuenta.Text
            My.Settings.contrasena = TextBox_Contraseña.Text

        Else
            My.Settings.usuario = ""
            My.Settings.contrasena = ""

        End If



        Try
            conex.conectar(TextBox_Cuenta.Text, TextBox_Contraseña.Text, "reservaciones_hotel")
            If conex.userAuthenticated.getSetTipo = 0 Then
                Finalize()
                ControlEmpleado.Show()
            ElseIf conex.userAuthenticated.getSetTipo = 1 Then
                MsgBox("Usted es administrador", MsgBoxStyle.Information, "Conexion sastifactoria")
            End If
        Catch ex As Exception
            label_error_user.Text = My.Resources.No_Usuario_contraseña
        End Try




    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub TextBox_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Contraseña.TextChanged
        label_error_user.Text = ""
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


End Class

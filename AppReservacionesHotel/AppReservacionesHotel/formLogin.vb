Public Class LoginForm


    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        'Realizamos la conexion a la base de datos y verificamos que usuario es el que se autentificado
        'Si es empleado abrira el Formulario de control, si es Administrador Abrira el Control para Administrador
        Dim conex As New ConexionMYSQL()
        If conex.conectar(TextBox_Cuenta.Text, TextBox_Contraseña.Text, "reservaciones_hotel") = True Then
            If conex.userAuthenticated.getSetTipo = 0 Then
                Finalize()
                ControlEmpleado.Show()
            ElseIf conex.userAuthenticated.getSetTipo = 1 Then
                MsgBox("Usted es administrador", MsgBoxStyle.Information, "Conexion sastifactoria")
            End If
        End If
    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub TextBox_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Contraseña.TextChanged

    End Sub
End Class

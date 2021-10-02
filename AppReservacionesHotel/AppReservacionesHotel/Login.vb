Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        Dim conex As New ConexionMYSQL()
        conex.conectar(TextBox_Cuenta.Text, TextBox_Contraseña.Text)
    End Sub

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Dim answer As MsgBoxResult
        answer = MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Finalize()
            End
        End If

    End Sub


End Class

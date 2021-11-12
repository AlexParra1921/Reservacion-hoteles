Public Class ControlEmpleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ControlEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ControlEmpleado_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim answer As MsgBoxResult
        answer = MsgBox("¿Desea cerrar la aplicacion?", MsgBoxStyle.YesNo, "Salir")
        If answer = MsgBoxResult.No Then
            e.Cancel = True
            Return
        End If
        LoginForm.Show()

    End Sub
End Class
Public Class ControlEmpleado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_habitaciones.Click

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

    Private Sub Control_Click(sender As Object, e As EventArgs) Handles bt_reservaciones.Click

        Form_reservaciones.MdiParent = Me
        panel_main.Controls.Add(Form_reservaciones)
        Form_reservaciones.Show()
        Form_reservaciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub HabitacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitacionToolStripMenuItem.Click

    End Sub

    Private Sub CleinteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleinteToolStripMenuItem.Click

    End Sub

    Private Sub bt_cliente_Click(sender As Object, e As EventArgs) Handles bt_cliente.Click
        'My.Application.OpenForms.Cast(Of Form)().Except((Me)).ToList().ForEach(Sub(Form) Form.Close())


        Form_cliente.MdiParent = Me
        panel_main.Controls.Add(Form_cliente)
        Form_cliente.Show()
        Form_cliente.WindowState = FormWindowState.Maximized



    End Sub
End Class
Public Class ControlEmpleado


    Private Sub ControlEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_ventana.Text = ""
        lb_ventana.Text = "Reservaciones"
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

    Private Sub HabitacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitacionToolStripMenuItem.Click

    End Sub

    Private Sub CleinteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleinteToolStripMenuItem.Click

    End Sub

    Private Sub bt_cliente_Click(sender As Object, e As EventArgs) Handles bt_clientes.Click
        'My.Application.OpenForms.Cast(Of Form)().Except((Me)).ToList().ForEach(Sub(Form) Form.Close())
        lb_ventana.Text = ""
        lb_ventana.Text = "Clientes"
        Form_cliente.MdiParent = Me
        panel_main.Controls.Add(Form_cliente)
        Form_cliente.Show()
        Form_cliente.WindowState = FormWindowState.Maximized



    End Sub

    Private Sub bt_huesped_Click(sender As Object, e As EventArgs) Handles bt_huesped.Click
        lb_ventana.Text = ""
        lb_ventana.Text = "Huespedes"
        Form_Huesped.MdiParent = Me
        panel_main.Controls.Add(Form_Huesped)
        Form_Huesped.Show()
        Form_Huesped.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bt_reservaciones_Click(sender As Object, e As EventArgs) Handles bt_reservaciones.Click
        lb_ventana.Text = ""
        lb_ventana.Text = "Reservaciones"
        Form_reservaciones.MdiParent = Me
        panel_main.Controls.Add(Form_reservaciones)
        Form_reservaciones.Show()
        Form_reservaciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bt_habitaciones_Click(sender As Object, e As EventArgs) Handles bt_habitaciones.Click
        lb_ventana.Text = ""
        lb_ventana.Text = "Habitaciones"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
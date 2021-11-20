Public Class Form_reservaciones
    Dim cliente As Cliente
    Private Sub bt_buscarCliente_Click(sender As Object, e As EventArgs) Handles bt_buscarCliente.Click
        If Form_buscarCliente.ShowDialog() = DialogResult.OK Then
            'Si se realiza la seleccion del cliente entonces se guardara su informacion 
            ' y se realizara la busqueda del telefono 
            cliente = Form_buscarCliente.cliente
            txt_idcliente.Text = cliente.getSetidCliente
            txt_nombre.Text = cliente.getSetNombre
            txt_paterno.Text = cliente.getSetApellidoPaterno
            txt_materno.Text = cliente.getSetApellidoMaterno

            Dim telefono As New Telefono()
            telefono.getSetIdDueño = cliente.getSetidCliente
            telefono.getSetTipoDueño = Persona.tipoPersona.Cliente

            If telefono.consultaTel_tel Then
                txt_telefono.Text = telefono.getSetNumero
            End If

            panel_habitaciones.Enabled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_BuscarHabitaciones.ShowDialog()
    End Sub


End Class
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

    Private Sub bt_buscarHabitaciones_Click(sender As Object, e As EventArgs) Handles bt_buscarHabitaciones.Click
        If Form_BuscarHabitaciones.ShowDialog() Then
            Dim numeroHabitaciones As Integer
            Dim costo As Decimal
            Dim costoTotal As Decimal
            numeroHabitaciones = dgv_habitacionesCostos.Rows.Count

            For Each row As DataGridViewRow In dgv_habitacionesCostos.Rows.Cast(Of DataGridViewRow)
                costo += row.Cells(4).Value
            Next

            Dim iva = costo * 0.16
            costoTotal = iva + costo

            lb_no_habitaciones.Text = String.Format("No. Habitaciones: {0}", numeroHabitaciones)
            lb_costoTotal.Text = String.Format("$ {0}", costo)
            lb_costIva.Text = String.Format("$ {0} + ${1}", costo, iva)
            lb_costoTotal.Text = String.Format("$ {0}", costoTotal)


        End If
    End Sub

    Private Sub Form_reservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub date_entrada_ValueChanged(sender As Object, e As EventArgs) Handles date_entrada.ValueChanged
        MsgBox(date_entrada.Text)
    End Sub
End Class
Public Class Form_reservaciones
    Dim cliente As Cliente
    Dim reservacion As New Reservaciones

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

            'Limpia todo el dataGridView
            dgv_habitacionesCostos.Rows.Clear()

            'Copia las filas del dataGridView de habitaciones seleccionadas al DGV de formulario de reservaciones
            For Each row As DataGridViewRow In Form_BuscarHabitaciones.dgv_habitacionSeleccionadas.Rows.Cast(Of DataGridViewRow)().Reverse()

                Dim index As Integer = dgv_habitacionesCostos.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

                For Each cell As DataGridViewCell In row.Cells
                    dgv_habitacionesCostos.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
                Next
            Next



            Dim numeroHabitaciones As Integer
            Dim costo As Decimal
            Dim costoTotal As Decimal
            numeroHabitaciones = dgv_habitacionesCostos.Rows.Count
            reservacion.gs_No_habitaciones = numeroHabitaciones
            For Each row As DataGridViewRow In dgv_habitacionesCostos.Rows.Cast(Of DataGridViewRow)
                costo += row.Cells(4).Value
            Next

            Dim iva = costo * 0.16
            costoTotal = iva + costo

            lb_no_habitaciones.Text = String.Format("No. Habitaciones: {0}", numeroHabitaciones)
            lb_costo.Text = String.Format("$ {0}", costo)
            lb_costIva.Text = String.Format("$ {0} + ${1}", costo, iva)
            lb_costoTotal.Text = String.Format("$ {0}", costoTotal)

            reservacion.gs_costo = costoTotal
            bt_res_guar.Enabled = True
        End If
    End Sub

    Private Sub Form_reservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reservacion.asignarIdReservacion()
        lb_idreservacion.Text = "ID RESERVACION: #" & reservacion.gs_id_reservacion
        lb_fecha.Text = String.Format("Fecha: {2}/{1}/{0}", (DateTime.Now).Year, (DateTime.Now).Month, (DateTime.Now).Day)

    End Sub

    Private Sub bt_res_guar_Click(sender As Object, e As EventArgs) Handles bt_res_guar.Click

        If bt_res_guar.Text = "Reservar" Then
            reservacion.gs_id_empleado = 1
            reservacion.gs_id_cliente = cliente.getSetidCliente
            reservacion.gs_fechaEntrada = date_entrada.Text
            reservacion.gs_fechaSalida = date_salida.Text
            reservacion.gs_FechaReservacion = String.Format("{0}-{1}-{2}", (DateTime.Now).Year, (DateTime.Now).Month, (DateTime.Now).Day)

            Dim listidhabitaciones As New List(Of Integer)
            For Each row As DataGridViewRow In dgv_habitacionesCostos.Rows.Cast(Of DataGridViewRow)
                listidhabitaciones.Add(row.Cells(0).Value)
            Next

            If reservacion.reservar(listidhabitaciones) Then
                MsgBox("Se ha realizado la reservacion sastifactoriamente.", MsgBoxStyle.Information, "Reservacion")
            End If

        End If




    End Sub


    Private Sub date_salida_CloseUp(sender As Object, e As EventArgs) Handles date_salida.CloseUp
        Dim fecha_entrada As Date = DateTime.Parse(date_entrada.Value)
        Dim fecha_salida As Date = DateTime.Parse(date_salida.Value)

        Dim numDias As Integer = fecha_salida.Subtract(fecha_entrada).TotalDays
        If numDias > 0 Then
            txt_dias.Text = numDias
            reservacion.gs_num_dias = fecha_salida.Subtract(fecha_entrada).TotalDays
        Else
            MsgBox("La fecha de entrada y la fecha de salida estan incorrectas, la fecha de salida esta atrasada",
                   MsgBoxStyle.Information, "Advertencia")
            txt_dias.Text = ""
            reservacion.gs_num_dias = 0
        End If
    End Sub

    Private Sub date_entrada_CloseUp(sender As Object, e As EventArgs) Handles date_entrada.CloseUp
        Dim fecha_entrada As Date = DateTime.Parse(date_entrada.Value)
        Dim fecha_salida As Date = DateTime.Parse(date_salida.Value)
        Dim numDias As Integer = fecha_salida.Subtract(fecha_entrada).TotalDays
        If numDias > 0 Then
            txt_dias.Text = numDias
            reservacion.gs_num_dias = fecha_entrada.Subtract(fecha_salida).TotalDays
        Else
            txt_dias.Text = ""
            reservacion.gs_num_dias = 0
        End If
    End Sub

    Private Sub bt_limpiar_Click(sender As Object, e As EventArgs) Handles bt_limpiar.Click
        txt_idcliente.Text = ""
        txt_nombre.Text = ""
        txt_paterno.Text = ""
        txt_materno.Text = ""
        txt_telefono.Text = ""
        txt_dias.Text = ""
        lb_costo.Text = ""
        lb_costoTotal.Text = ""
        lb_no_habitaciones.Text = ""
        dgv_habitacionesCostos.Rows.Clear()
        lb_costIva.Text = ""
    End Sub
End Class
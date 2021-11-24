Public Class Form_ModifRese

    Private Sub Form_ModifRese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Extraemos del anterior formulario el id de la fila seleccionada del DGV
        Try
            Dim row = Form_AdminRese.dgv_reservaciones.SelectedRows(0)
            Dim id_reservacion = row.Cells(0).Value
            Dim reservacion As New Reservaciones()
            reservacion.gs_id_reservacion = id_reservacion
            reservacion.consultarReservacion()

            'Coloca los datos en los campos
            txt_idreservacion.Text = reservacion.gs_id_reservacion()
            data_reservacion.Value = Date.Parse(reservacion.gs_FechaReservacion)

            Dim cliente As New Cliente()
            cliente.getSetidCliente = reservacion.gs_id_cliente()
            If cliente.consultaCliente() = False Then
                Throw New Exception("No existe el cliente")
            End If

            '-> CLIENTE
            txt_idcliente.Text = cliente.getSetidCliente()
            txt_nombre.Text = cliente.getSetNombre()
            txt_paterno.Text = cliente.getSetApellidoPaterno()
            txt_materno.Text = cliente.getSetApellidoMaterno()
            '-> TELEFONO
            Dim telefono As New Telefono()
            telefono.getSetTipoDueño = Persona.tipoPersona.Cliente
            telefono.getSetIdDueño = cliente.getSetidCliente
            telefono.consultaTel_tel()

            txt_telefono.Text = telefono.getSetNumero()
            '-> FECHAS
            date_entrada.Value = Date.Parse(reservacion.gs_fechaEntrada)
            date_salida.Value = Date.Parse(reservacion.gs_fechaSalida)
            '->Datos
            lb_no_habitaciones.Text = "No. Habitaciones: " & reservacion.gs_No_habitaciones
            txt_dias.Text = reservacion.gs_num_dias
            lb_costoTotal.Text = "$" & reservacion.gs_costo
            '-> RECUPERAR HABITACIONES
            Dim hbHasRese As New Habitacion_has_reservacion(reservacion)
            Dim columnaDesocupar = New DataGridViewCheckBoxColumn()
            columnaDesocupar.HeaderText = "Desocupar"
            columnaDesocupar.Width = 70
            dgv_habitacionReservadas.Columns.Add(columnaDesocupar)
            dgv_habitacionReservadas.DataSource = hbHasRese.consultarHabitaciones()
            dgv_habitacionReservadas.Columns(6).Width = 170

        Catch ex As Exception
            Console.WriteLine("Error al consultar todos los datos de la reservacion:" + vbCrLf + ex.Message)
            MsgBox("No se puede realizar la modifacion de la reservacion", MsgBoxStyle.Exclamation, "Error Modifacion Reservacion")
            Me.Close()
        End Try

    End Sub

    'Funcion convierte un string de fecha con formato YYYY/MM/DD a Objecto
    Public Function convertirFecha(ByVal fechaString As String) As Date
        Dim strFecha = fechaString.Split("/")
        Dim año = strFecha(0)
        Dim mes = strFecha(1)
        Dim dia = strFecha(2)
        Return Date.Parse(String.Format("{0}/{1}/{2}", dia, mes, año))
    End Function

    Private Sub bt_agregarMasHabitaciones_Click(sender As Object, e As EventArgs) Handles bt_agregarMasHabitaciones.Click
        If Form_BuscarHabitaciones.ShowDialog() Then
            Dim numeroHabitaciones As Integer
            Dim costo As Decimal
            Dim costoTotal As Decimal
            numeroHabitaciones = dgv_habtiacionesAgregadas.Rows.Count
            For Each row As DataGridViewRow In dgv_habtiacionesAgregadas.Rows.Cast(Of DataGridViewRow)
                costo += row.Cells(4).Value
            Next
            Dim iva = costo * 0.16
            costoTotal = iva + costo
            lb_no_habitaciones.Text = String.Format("No. Habitaciones: {0}", numeroHabitaciones)
            lb_costoTotal.Text = String.Format("$ {0}", costoTotal)

        End If
    End Sub

    Private Sub dgv_habitacionReservadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_habitacionReservadas.CellContentClick
        If dgv_habitacionReservadas.CurrentCell.ColumnIndex = 0 Then
            Dim cellCheckBox As DataGridViewCheckBoxCell = dgv_habitacionReservadas.CurrentCell
            If Convert.ToBoolean(cellCheckBox.Value) Then
                Dim id_habitacion = dgv_habitacionReservadas.Rows(dgv_habitacionReservadas.CurrentCellAddress.Y).Cells(1).Value
                Console.WriteLine(id_habitacion)
            End If

        End If
    End Sub
End Class
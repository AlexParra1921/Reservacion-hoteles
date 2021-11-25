Public Class Form_ModifRese
    Private lista_habitacion As New List(Of DataGridViewRow)
    Private lista_habitacionDesocupadas As New List(Of DataGridViewRow)
    Dim reser As New Reservaciones()
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
            lb_no_habitaciones.Text = reservacion.gs_No_habitaciones
            txt_dias.Text = reservacion.gs_num_dias
            lb_costoTotal.Text = reservacion.gs_costo
            '-> RECUPERAR HABITACIONES
            Dim hbHasRese As New Habitacion_has_reservacion(reservacion)
            Dim columnaDesocupar = New DataGridViewCheckBoxColumn()
            columnaDesocupar.HeaderText = "Desocupar"
            columnaDesocupar.Width = 70
            dgv_habitacionReservadas.Columns.Add(columnaDesocupar)
            dgv_habitacionReservadas.DataSource = hbHasRese.consultarHabitaciones()
            dgv_habitacionReservadas.Columns(6).Width = 170
            For Each ro As DataGridViewRow In dgv_habitacionReservadas.Rows
                lista_habitacion.Add(ro)
            Next

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
            'Limpia todo el dataGridView
            dgv_habtiacionesAgregadas.Rows.Clear()

            'Copia las filas del dataGridView de habitaciones seleccionadas al DGV de formulario de reservaciones
            For Each row As DataGridViewRow In Form_BuscarHabitaciones.dgv_habitacionSeleccionadas.Rows.Cast(Of DataGridViewRow)().Reverse()

                Dim index As Integer = dgv_habtiacionesAgregadas.Rows.Add(DirectCast(row.Clone(), DataGridViewRow))

                For Each cell As DataGridViewCell In row.Cells
                    dgv_habtiacionesAgregadas.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
                Next
            Next



            calcularDatosHabitaciones()
        End If
    End Sub

    Private Sub dgv_habitacionReservadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_habitacionReservadas.CellContentClick
        'Verifica si se ha seleccionado el header de la grilla
        If (e.RowIndex = -1) Then
            Return
        End If

        'Si la actual celda modficada esta en la columna de Desocupar
        If dgv_habitacionReservadas.CurrentCell.ColumnIndex = 0 Then
            'Extraemos la fila
            Dim row As DataGridViewRow = dgv_habitacionReservadas.Rows(e.RowIndex)


            Dim cellCheckBox As DataGridViewCheckBoxCell = row.Cells(0)
            'Verificamos si ha sido Checked

            If Convert.ToBoolean(cellCheckBox.Value) Then
                lista_habitacion.Remove(row)
                lista_habitacionDesocupadas.Add(row)
            Else
                lista_habitacion.Add(row)
                lista_habitacionDesocupadas.Remove(row)
            End If
            calcularDatosHabitaciones()

        End If
    End Sub



    Public Sub calcularDatosHabitaciones()
        Dim numeroHabitaciones As Integer = 0
        Dim costo As Decimal = 0
        Dim costoTotal As Decimal = 0
        numeroHabitaciones = dgv_habtiacionesAgregadas.Rows.Count + lista_habitacion.Count
        'Realiza el calculo de las dos lista de costos
        For Each row As DataGridViewRow In dgv_habtiacionesAgregadas.Rows.Cast(Of DataGridViewRow)
            costo += row.Cells(4).Value
        Next
        For Each row As DataGridViewRow In lista_habitacion
            costo += row.Cells(5).Value
        Next

        'Actualiza los datos en el formulario
        costoTotal = costo + (costo * iva)
        lb_no_habitaciones.Text = String.Format("{0}", numeroHabitaciones)
        lb_costoTotal.Text = String.Format("{0}", costoTotal)
    End Sub



    Private Sub dgv_habitacionReservadas_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_habitacionReservadas.CurrentCellDirtyStateChanged
        'Verifica si hay celdas modifcadas, si lo esta acepta los cambios antes que pierda el foco
        If (dgv_habitacionReservadas.IsCurrentCellDirty) Then
            dgv_habitacionReservadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If


    End Sub

    Private Sub bt_res_guar_Click(sender As Object, e As EventArgs) Handles bt_res_guar.Click
        reser.gs_id_reservacion = txt_idreservacion.Text

        '->ID Empleado
        reser.gs_id_empleado = 1
        '-> CLIENTE
        reser.gs_id_cliente = txt_idcliente.Text

        '-> FECHAS 
        reser.gs_fechaEntrada = date_entrada.Text
        reser.gs_fechaSalida = date_salida.Text
        reser.gs_FechaReservacion = data_reservacion.Text

        '-> DATOS
        reser.gs_No_habitaciones = lb_no_habitaciones.Text
        reser.gs_num_dias = txt_dias.Text
        reser.gs_costo = lb_costoTotal.Text

        'Lista de habitaciones

        Dim numsHabitacionesDesocupadas As New List(Of Integer)
        Dim numsHabitacionesAgregadas As New List(Of Integer)
        For Each no_habitacionDesocupada As DataGridViewRow In lista_habitacionDesocupadas
            numsHabitacionesDesocupadas.Add(no_habitacionDesocupada.Cells(1).Value)
        Next
        For Each no_habitacionAgregada As DataGridViewRow In dgv_habtiacionesAgregadas.Rows
            numsHabitacionesAgregadas.Add(no_habitacionAgregada.Cells(1).Value)
        Next

        If reser.actualizar(numsHabitacionesDesocupadas, numsHabitacionesAgregadas) Then
            MsgBox("Se ha actualizado correctamente la habitacion", MsgBoxStyle.Information, "Actualizacion de Reservaciones")
        End If

    End Sub

    Private Sub bt_buscarCliente_Click(sender As Object, e As EventArgs) Handles bt_buscarCliente.Click
        Dim Cliente As New Cliente
        If Form_buscarCliente.ShowDialog() = DialogResult.OK Then
            'Si se realiza la seleccion del cliente entonces se guardara su informacion 
            ' y se realizara la busqueda del telefono 
            Cliente = Form_buscarCliente.cliente
            txt_idcliente.Text = Cliente.getSetidCliente
            txt_nombre.Text = Cliente.getSetNombre
            txt_paterno.Text = Cliente.getSetApellidoPaterno
            txt_materno.Text = Cliente.getSetApellidoMaterno

            Dim telefono As New Telefono()
            telefono.getSetIdDueño = Cliente.getSetidCliente
            telefono.getSetTipoDueño = Persona.tipoPersona.Cliente

            If telefono.consultaTel_tel Then
                txt_telefono.Text = telefono.getSetNumero
            End If

            panel_habitaciones.Enabled = True

        End If
    End Sub



    Private Sub date_entrada_CloseUp(sender As Object, e As EventArgs) Handles date_entrada.CloseUp
        Dim fecha_entrada As Date = DateTime.Parse(date_entrada.Value)
        Dim fecha_salida As Date = DateTime.Parse(date_salida.Value)
        Dim numDias As Integer = fecha_salida.Subtract(fecha_entrada).TotalDays
        If numDias > 0 Then
            txt_dias.Text = numDias
        Else
            txt_dias.Text = ""
        End If
    End Sub

    Private Sub date_salida_CloseUp(sender As Object, e As EventArgs) Handles date_salida.CloseUp
        Dim fecha_entrada As Date = DateTime.Parse(date_entrada.Value)
        Dim fecha_salida As Date = DateTime.Parse(date_salida.Value)

        Dim numDias As Integer = fecha_salida.Subtract(fecha_entrada).TotalDays
        If numDias > 0 Then
            txt_dias.Text = numDias

        Else
            MsgBox("La fecha de entrada y la fecha de salida estan incorrectas, la fecha de salida esta atrasada",
                   MsgBoxStyle.Information, "Advertencia")
            txt_dias.Text = ""

        End If
    End Sub
End Class
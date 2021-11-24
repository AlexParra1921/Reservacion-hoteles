Public Class Form_ModifRese
    Private lista_habitacion As New List(Of DataGridViewRow)
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
            Else
                lista_habitacion.Add(row)
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
        lb_no_habitaciones.Text = String.Format("No. Habitaciones: {0}", numeroHabitaciones)
        lb_costoTotal.Text = String.Format("$ {0}", costoTotal)
    End Sub



    Private Sub dgv_habitacionReservadas_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_habitacionReservadas.CurrentCellDirtyStateChanged
        'Verifica si hay celdas modifcadas, si lo esta acepta los cambios antes que pierda el foco
        If (dgv_habitacionReservadas.IsCurrentCellDirty) Then
            dgv_habitacionReservadas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If


    End Sub
End Class
Public Class Form_BuscarHabitaciones
    Private habitacion As New Habitaciones
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form_BuscarHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario se cargaran los nombres de las habitaciones

        habitacion.poblarComboHotel(cb_hotel)

    End Sub

    Private Sub cb_hotel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_hotel.SelectedIndexChanged
        'Al seleccionar un hotel se cargar el combo de las categorias

        mihotel = cb_hotel.SelectedItem
        habitacion.consultarIdHotel()
        habitacion.poblarComboCategoria(cb_categoria)
        cb_habitacion.Text = ""
        cb_categoria.Text = ""
    End Sub

    Private Sub cb_habitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_habitacion.SelectedIndexChanged
        'Al seleccionar una habitacion se realizara una seleccion en el DataViewGrid para habilitar
        'la el boton de seleccionar
        mihabitacion = CInt(cb_habitacion.Text)


        For i As Integer = 0 To dgv_BusquedaHabitacion.Rows.Count - 1

            If dgv_BusquedaHabitacion.Rows(i).Cells(0).Value = mihabitacion Then
                'Mueve el cursor a dicha fila

                dgv_BusquedaHabitacion.CurrentCell = dgv_BusquedaHabitacion.Item(0, i)
                'Pinta de color azul la fila para indicar al usuario que esa celda está seleccionada (Opcional)

                dgv_BusquedaHabitacion.Rows(i).Selected = True
            End If
        Next
    End Sub

    Private Sub cb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_categoria.SelectedIndexChanged
        'Al seleccionar una habitacion se cargara el combo de habitaciones 
        'y se realizara un QUERY para poblar el data view grid

        micategoria = cb_categoria.SelectedItem
        habitacion.consultaridCategoria()
        habitacion.poblarComboHabitacion(cb_habitacion)

        habitacion.poblarDGVBusquedaHabitacion(dgv_BusquedaHabitacion)

        cb_habitacion.Text = ""



    End Sub

    Private Sub dgv_BusquedaHabitacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_BusquedaHabitacion.CellClick
        'Cuando se realice una seleccion los valores del renglon se cargaran en los combos

        Dim renglon As Integer

        renglon = dgv_BusquedaHabitacion.CurrentCellAddress.Y

        cb_habitacion.Text = dgv_BusquedaHabitacion.Rows(renglon).Cells(0).Value


    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click


        Me.Hide()



    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click

        'Verifica si no hay columnas dentro del datagridView para habitaciones seleccionadas
        If dgv_habitacionSeleccionadas.ColumnCount = 0 Then
            'Si no hay copiara las columnas del datagridView de habiaciones buscadas
            For Each col As DataGridViewColumn In dgv_BusquedaHabitacion.Columns
                dgv_habitacionSeleccionadas.Columns.Add(DirectCast(col.Clone(), DataGridViewColumn))
            Next
        End If

        'Creas una lista 
        Dim cellValues As New List(Of String)
        'Guardas el valor de la primera celda de cada fila de las habitaciones seleccionadas
        For Each row As DataGridViewRow In dgv_habitacionSeleccionadas.Rows
            cellValues.Add(row.Cells(0).Value.ToString())
        Next

        'Realizas una copia de las filas del datagridview de busqueda de habitaciones al
        'datagridview de habitaciones seleccionadas
        For Each row As DataGridViewRow In
            dgv_BusquedaHabitacion.SelectedRows.Cast(Of DataGridViewRow)().Reverse()

            'Verificas si alguna de las filas que se copiara no esta ya en el datagridview de destino
            If cellValues.Contains(row.Cells(0).Value) Then
                Continue For
            End If
            'Copia el esquema de la fila 
            Dim index As Integer = dgv_habitacionSeleccionadas.Rows.Add(DirectCast(row.Clone,
                                                                       DataGridViewRow))
            'Realiza la copia celda por celda de la fila
            For Each cell As DataGridViewCell In row.Cells
                dgv_habitacionSeleccionadas.Rows(index).Cells(cell.ColumnIndex).Value = cell.Value
            Next

        Next

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        'Realiza la eliminacion de las filas seleccionadas
        For Each r As DataGridViewRow In dgv_habitacionSeleccionadas.SelectedRows
            dgv_habitacionSeleccionadas.Rows.Remove(r)
        Next

    End Sub
End Class
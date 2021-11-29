Public Class FormHabitacion
    Private habitacion As New Habitaciones
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If ComboBoxCat.SelectedItem = "" Then
            MessageBox.Show("Capturar la Categoria")
        ElseIf TextBoxHab.Text = "" Then
            MessageBox.Show("Capturar el Numero de Habitación")
        ElseIf ComboBoxHotel.SelectedItem = "" Then
            MessageBox.Show("Capturar el hotel")
        ElseIf TextBoxDisponibilidad.Text = "" Then
            MessageBox.Show("Capturar si esta disponible")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos
            Dim habitacion As New Habitaciones(TextBoxHab.Text, ComboBoxCat.SelectedIndex + 1, ComboBoxHotel.SelectedIndex + 1, TextBoxDisponibilidad.Text)

            'En el siguiente IF, usamos un método para verificar si la categoria está registrada
            If habitacion.consultarHabitacion() = False Then
                'Si la ctageoria NO está registrada, la inserta como una nueva
                Try
                    habitacion.insertarHabitacion() 'INSERTA NUEVA CATEGORIA
                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("Habitacion Registrada")
                Catch ex As Exception
                    MsgBox("Error al realizar el registro de la categoria:" & ex.Message)
                End Try

            Else
                If MessageBox.Show("¿Esta seguro modifcar el registro de la Habitacion=[" & TextBoxHab.Text & "]?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Try
                        'Si la categoria se encuentra registrada, se modifica la información
                        habitacion.actualizarHabitacion()
                        MsgBox("Habitacion modificada")
                    Catch ex As Exception
                        MsgBox("Error al realizar la actualizacion de la habitacion: /n" & ex.Message)
                    End Try

                End If

            End If
            habitacion.poblarDGVBusquedaHabitacion(dgv_hab)
        End If
    End Sub

    Private Sub Form_habitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim habitacion As New Habitaciones
        'Poblamos el Data Grid View para los clientes

        habitacion.poblarDGVBusquedaHabitacion(dgv_hab)
        cnx.Close()
    End Sub

    Private Sub cb_hotel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxHotel.SelectedIndexChanged
        'Al seleccionar un hotel se cargar el combo de las categorias

        mihotel = ComboBoxHotel.SelectedItem
        habitacion.consultarIdHotel()
        habitacion.poblarComboCategoria(ComboBoxCat)
        TextBoxHab.Text = ""
        ComboBoxCat.Text = ""
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim habitacion As New Habitaciones()

        If TextBoxBuscar.Text <> "" Then
            habitacion.getSetHabitacion = CInt(TextBoxBuscar.Text)
            Dim id As Integer = TextBoxBuscar.Text
            Dim founded = False
            For Each row As DataGridViewRow In dgv_hab.Rows
                If id = row.Cells(0).Value Then
                    dgv_hab.CurrentCell = dgv_hab.Item(0, row.Index)
                    dgv_hab.Rows(row.Index).Selected = True
                    founded = True
                End If
            Next
            If founded = False Then
                MsgBox("Reservacion  no encontrada", MsgBoxStyle.Information, "Busqueda De Reservacion")
            End If
        End If



    End Sub

    Private Sub ComboBoxCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCat.SelectedIndexChanged
        'Al seleccionar una habitacion se cargara el combo de habitaciones 
        'y se realizara un QUERY para poblar el data view grid

        micategoria = ComboBoxCat.SelectedItem
        habitacion.consultaridCategoria()

        habitacion.poblarDGVBusquedaHabitacion(dgv_hab)

        TextBoxHab.Text = ""
    End Sub

    Private Sub Form_BuscarHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario se cargaran los nombres de las habitaciones

        habitacion.poblarComboHotel(ComboBoxHotel)

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        ComboBoxCat.Text = ""
        ComboBoxHotel.Text = ""
        TextBoxHab.Text = ""
        TextBoxDisponibilidad.Text = ""
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim habitacion As New Habitaciones(TextBoxHab.Text, ComboBoxCat.SelectedIndex + 1, ComboBoxHotel.SelectedIndex + 1, TextBoxDisponibilidad.Text)


        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            'Llamamos al método que elimina el registro
            habitacion.eliminarHabitacion()
            MessageBox.Show("Registro Eliminado")

            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            habitacion.poblarDGVBusquedaHabitacion(dgv_hab)
        End If

    End Sub

    Private Sub dgv_hab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hab.CellClick
        Dim renglon As Integer


        renglon = dgv_hab.CurrentCellAddress.Y

        TextBoxHab.Text = dgv_hab.Rows(renglon).Cells(0).Value
        TextBoxDisponibilidad.Text = 1
    End Sub
End Class
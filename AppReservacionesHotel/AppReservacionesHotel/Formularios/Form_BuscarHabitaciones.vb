Public Class Form_BuscarHabitaciones
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form_BuscarHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario se cargaran los nombres de las habitaciones

    End Sub

    Private Sub cb_hotel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_hotel.SelectedIndexChanged
        'Al seleccionar un hotel se cargar el combo de las categorias

    End Sub

    Private Sub cb_habitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_habitacion.SelectedIndexChanged
        'Al seleccionar una habitacion se realizara una seleccion en el DataViewGrid para habilitar
        'la el boton de seleccionar

    End Sub

    Private Sub cb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_categoria.SelectedIndexChanged
        'Al seleccionar una habitacion se cargara el combo de habitaciones 
        'y se realizara un QUERY para poblar el data view grid


    End Sub

    Private Sub dgv_BusquedaHabitacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_BusquedaHabitacion.CellClick
        'Cuando se realice una seleccion los valores del renglon se cargaran en los combos
        'SE NECESITARA REALIZAR UN QUERY
    End Sub


End Class
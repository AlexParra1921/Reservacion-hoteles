Public Class formCategoriaHabitacion
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If TextBoxCat.Text = "" Then
            MessageBox.Show("Capturar el id de la Categoria")
        ElseIf TextBoxCI.Text = "" Then
            MessageBox.Show("Capturar el numero de camas individuales")
        ElseIf TextBoxCM.Text = "" Then
            MessageBox.Show("Capturar el numero de camas matrimoniales")
        ElseIf TextBoxPrecio.Text = "" Then
            MessageBox.Show("Cpturar el precio total de la categoria")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos
            Dim categoria As New CategoriaHabitacion(TextBoxCat.Text, TextBoxPrecio.Text, TextBoxCM.Text, TextBoxCI.Text)

            'En el siguiente IF, usamos un método para verificar si la categoria está registrada
            If categoria.consultaCategoria() = False Then
                'Si la ctageoria NO está registrada, la inserta como una nueva
                Try
                    categoria.insertarCategoria() 'INSERTA NUEVA CATEGORIA
                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("Categoria Registrada")
                Catch ex As Exception
                    MsgBox("Error al realizar el registro de la categoria:" & ex.Message)
                End Try

            Else
                If MessageBox.Show("¿Esta seguro modifcar el registro con ID=[" & TextBoxCat.Text & "]?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Try
                        'Si la categoria se encuentra registrada, se modifica la información
                        categoria.actualizarCategoria()
                        MsgBox("Categoria modificada")
                    Catch ex As Exception
                        MsgBox("Error al realizar la actualizacion de la categoria: /n" & ex.Message)
                    End Try

                End If

            End If
            categoria.PoblarDataGridCategoria(dgvCat)
        End If
    End Sub

    Private Sub Form_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim categoria As New CategoriaHabitacion
        'Poblamos el Data Grid View para los clientes

        categoria.PoblarDataGridCategoria(dgvCat)
        cnx.Close()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        Dim categoria As New CategoriaHabitacion(TextBoxCat.Text, TextBoxPrecio.Text, TextBoxCM.Text, TextBoxCI.Text)

        If categoria.validarCategorias() = True Then
            MsgBox("No se puede eliminar la categoria seleccionada, esta asociada a algunas habitaciones")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Llamamos al método que elimina el registro
                categoria.eliminarCategoria()
                MessageBox.Show("Registro Eliminado")

                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                categoria.PoblarDataGridCategoria(dgvCat)
            End If
        End If
    End Sub

    Private Sub dgvCate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCat.CellContentClick
        Dim renglon As Integer
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        renglon = dgvCat.CurrentCellAddress.Y

        TextBoxCat.Text = dgvCat.Rows(renglon).Cells(0).Value
        TextBoxPrecio.Text = dgvCat.Rows(renglon).Cells(1).Value
        TextBoxCM.Text = dgvCat.Rows(renglon).Cells(2).Value
        TextBoxCI.Text = dgvCat.Rows(renglon).Cells(3).Value
    End Sub


    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim categoria As New CategoriaHabitacion()

        If TextBoxBusca.Text <> "" Then
            categoria.getSetCategoria = CInt(TextBoxBusca.Text)
        End If

        If categoria.consultaCategoria() Then
            MsgBox("Categoria encontrada!")
        Else
            MsgBox("Categoria no encontrada!")
        End If

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        TextBoxCat.Text = ""
        TextBoxBusca.Text = ""
        TextBoxPrecio.Text = ""
        TextBoxCM.Text = ""
        TextBoxCI.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCat.CellContentClick

    End Sub

    Private Sub Categoria_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CamasMatri_Click(sender As Object, e As EventArgs) Handles CamasMatri.Click

    End Sub

End Class
Public Class Form_buscarCliente

    Dim cliente As New Cliente
    Dim clienteSeleccionado As Boolean = False
    Private Sub txt_idcliente_Enter(sender As Object, e As EventArgs) Handles txt_idcliente.Enter
        If txt_idcliente.Text = "Buscar ID" Then
            txt_idcliente.Text = ""
        End If
    End Sub

    Private Sub txt_idcliente_Leave(sender As Object, e As EventArgs) Handles txt_idcliente.Leave
        If txt_idcliente.Text = "" Then
            txt_idcliente.Text = "Buscar ID"
        End If
    End Sub

    Private Sub bt_Buscar_Click(sender As Object, e As EventArgs) Handles bt_Buscar.Click
        'Realizaremos la verifiacion del campo txt_idcliente para saber si se ha introducido un
        'id de cliente, depues realizaremos la busqueda del cliente con el id en la base de datos
        'finalmente seleccionaremos automaticamente el registro con el id

        If txt_idcliente.Text = "" Or txt_idcliente.Text = "Buscar ID" Then
            MsgBox("Caputure un id para realizar la busqueda del cliente!", MsgBoxStyle.Information, "Information")
        Else

            cliente.getSetidCliente = txt_idcliente.Text

            If cliente.consultaClientePoblarDGV(dgv_BusquedaCliente) Then
                lb_error.Text = "Se ha encontrado el cliente"
                dgv_BusquedaCliente.CurrentCell = dgv_BusquedaCliente.Item(0, 0)
                dgv_BusquedaCliente.Rows(0).Selected = True
                clienteSeleccionado = True
            Else
                lb_error.Text = "No se ha encontrado ningun cliente con ese ID"
            End If

        End If

    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        Me.Close()
    End Sub

    Private Sub bt_seleccionar_Click(sender As Object, e As EventArgs) Handles bt_seleccionar.Click
        If clienteSeleccionado = False Then
            MsgBox("Seleccione un cliente para continuar")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub dgv_BusquedaCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_BusquedaCliente.CellClick
        Dim renglon As Integer
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        renglon = dgv_BusquedaCliente.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVclientes.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        cliente.getSetidCliente = dgv_BusquedaCliente.Rows(renglon).Cells(0).Value
        txt_idcliente.Text = cliente.getSetidCliente
        cliente.getSetNombre = dgv_BusquedaCliente.Rows(renglon).Cells(1).Value
        cliente.getSetApellidoPaterno = dgv_BusquedaCliente.Rows(renglon).Cells(2).Value
        cliente.getSetApellidoMaterno = dgv_BusquedaCliente.Rows(renglon).Cells(3).Value
        clienteSeleccionado = True

    End Sub

    Private Sub Form_buscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente.PoblarDataGridCliente(dgv_BusquedaCliente)

    End Sub
End Class
Public Class Form_cliente
    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto

        If txtbox_id.Text = "" Then
            MessageBox.Show("Capturar el id para el cliente !!")
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Capturar nombre del cliente!!")
        ElseIf txtbox_apellidoPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del cliente!!")
        ElseIf txtbox_apellidoMaterno.Text = "" Then
            MessageBox.Show("Capturar apéllido materno del cliente !!")
        ElseIf txt_numero.Text = "(   )   -  -" Then
            MessageBox.Show("Seleccione un telefono para el cliente !!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos

            Dim cliente As New Cliente(txtbox_id.Text, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text)


            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If cliente.consultaCliente() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                cliente.insertarCliente() 'INSERTA NUEVA CIUDAD

                'Con ésta función mandamos una ventana de notificación al usuario final
                MessageBox.Show("Cliente Registrado ...")
            Else
                If MessageBox.Show("¿Esta seguro modifcar el registro con ID=[" & txtbox_id.Text & "]?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    'Si la ciudad se encuentra registrada, se modifica la información
                    cliente.actualizaCliente() 'ACTUALIZA LA CIUDAD

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MsgBox("Cliente modificado ...")
                End If

            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            cliente.PoblarDataGridCliente(dgv_cliente)

        End If
    End Sub

    Private Sub Form_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As New Cliente
        'Poblamos el Data Grid View para los clientes

        cliente.PoblarDataGridCliente(dgv_cliente)

        cnx.Close()

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        'Validamos que esa ciudad no tenga colonias dadas de alta, es decir que no tenga hijos.
        'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
        'hay que controlar esa validación y mandar un mensaje apropiado al usuario final

        Dim cliente As New Cliente(txtbox_id.Text, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text)

        If cliente.validarClientes() = True Then
            MsgBox("No se puede dar de baja el cliente seleccionado, tiene reservaciones registradas...")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Llamamos al método que elimina el registro de la ciudad
                cliente.eliminarCliente()
                MessageBox.Show("Registro Eliminado")

                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                cliente.PoblarDataGridCliente(dgv_cliente)
            End If
        End If

    End Sub

    Private Sub dgv_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick
        Dim renglon As Integer
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        renglon = dgv_cliente.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVclientes.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        txtbox_id.Text = dgv_cliente.Rows(renglon).Cells(0).Value
        txt_nombre.Text = dgv_cliente.Rows(renglon).Cells(1).Value
        txtbox_apellidoPaterno.Text = dgv_cliente.Rows(renglon).Cells(2).Value
        txtbox_apellidoMaterno.Text = dgv_cliente.Rows(renglon).Cells(3).Value

        'Realizamos la busqueda del telefono
        Dim telefono As New Telefono
        telefono.getSetIdDueño = txtbox_id.Text
        telefono.getSetTipoDueño = Persona.tipoPersona.Cliente

        If telefono.consultaTel_tel() Then
            txt_numero.Text = telefono.getSetNumero
        Else
            txt_numero.Text = ""
        End If




    End Sub




    'Realiza una busqueda en la base de datos y si encuentra el cliente con ese id rellena los campos y muestra el me
    'mensaje de que se ha encontrado
    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim cliente As New Cliente()
        cliente.getSetidCliente = CInt(txt_BuscarID.Text)

        If cliente.consultaCliente() Then
            MsgBox("Cliente encontrado!")
        Else
            MsgBox("Cliente no encontrado!")
        End If

    End Sub

    Private Sub bt_limpiar_Click(sender As Object, e As EventArgs) Handles bt_limpiar.Click
        txtbox_id.Text = ""
        txt_BuscarID.Text = ""
        txt_nombre.Text = ""
        txtbox_apellidoPaterno.Text = ""
        txtbox_apellidoMaterno.Text = ""

    End Sub

    Private Sub bt_selectTel_Click(sender As Object, e As EventArgs) Handles bt_selectTel.Click
        Form_Telefono.Show()
    End Sub


    Private Sub txtbox_id_TextChanged(sender As Object, e As EventArgs) Handles txtbox_id.TextChanged
        If txtbox_id.Text <> "" Then
            bt_selectTel.Enabled = True
        Else
            bt_selectTel.Enabled = False
        End If
    End Sub


End Class
Public Class Form_Huesped
    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto

        If txtbox_id.Text = "" Then
            MessageBox.Show("Capturar el id para el Huesped !!")
        ElseIf txt_nombre.Text = "" Then
            MessageBox.Show("Capturar nombre del Huesped!!")
        ElseIf txtbox_apellidoPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del Huesped!!")
        ElseIf txtbox_apellidoMaterno.Text = "" Then
            MessageBox.Show("Capturar apéllido materno del Huesped!!")
        ElseIf txt_numero.Text = "(   )   -  -" Then
            MessageBox.Show("Seleccione un telefono para el Huesped!!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos
            Dim strTel = limpiar_caracteresCampoTelefono()

            Dim id_reservacion = cb_reservaciones.SelectedItem

            Dim huesped As New Huesped(txtbox_id.Text, id_reservacion, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno)
            'Dim cliente As New Cliente(txtbox_id.Text, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text)
            Dim telefono As New Telefono(txtbox_id.Text, strTel, "+52", Persona.tipoPersona.Cliente)

            'En el siguiente IF, usamos un método para verificar si la ciudad está registrada
            ' en esa ciudad de ese estado

            If huesped.consultaHuesped() = False Then
                'Si la ciudad NO está registrada, la inserta como una nueva
                Try
                    huesped.insertarCliente() 'INSERTA NUEVA CIUDAD
                    'Verificamos si los campos estan llenos y si tenemos el id del dueño para indicar de quiens sera el telefono
                    If telefono.consultaTel_tel() Then
                        lb_telefono.Text = "Este numero ya pertenece a un cliente"
                        huesped.eliminarCliente()
                        Return
                    Else
                        telefono.insertarTel()
                    End If

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("Cliente Registrado ...")
                Catch ex As Exception
                    MsgBox("Error la realizar el registro del cliente:" & ex.Message)
                End Try

            Else

                If MessageBox.Show("¿Esta seguro modifcar el registro con ID=[" & txtbox_id.Text & "]?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Try
                        'Si el telefono del cliente existe pero pertnece a otro cliente no actualizar cliente
                        If telefono.consultaTel_id() Then
                            If telefono.getSetIdDueño <> huesped.getSetidCliente Then
                                lb_telefono.Text = "Este numero ya pertenece a un cliente"
                                Return
                            End If
                        Else
                            If telefono.consultaTel_tel() Then
                                telefono.eliminaTelefono()
                            End If
                            telefono.getSetNumero = strTel
                            'Si el telefono no existe entonces agregar el nuevo 
                            telefono.insertarTel()
                        End If

                        'Si el cliente se encuentra registrada, se modifica la información
                        huesped.actualizaCliente() 'ACTUALIZA LA CIUDAD

                        'Con ésta función mandamos una ventana de notificación al usuario final
                        MsgBox("Cliente modificado ...")
                    Catch ex As Exception
                        MsgBox("Error al realizar la actualizacion del cliente: /n" & ex.Message)
                    End Try

                End If

            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            huesped.PoblarDataGridCliente(dgv_huesped)

        End If
    End Sub

    Private Sub Form_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As New huespeda
        'Poblamos el Data Grid View para los clientes
        cliente.PoblarDataGridCliente(dgv_huesped)

        cnx.Close()

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        'Validamos que esa ciudad no tenga colonias dadas de alta, es decir que no tenga hijos.
        'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
        'hay que controlar esa validación y mandar un mensaje apropiado al usuario final

        Dim cliente As New huespeda(txtbox_id.Text, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text)

        If cliente.validarClientes() = True Then
            MsgBox("No se puede dar de baja el cliente seleccionado, tiene reservaciones registradas...")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'Llamamos al método que elimina el registro de la ciudad
                cliente.eliminarCliente()
                MessageBox.Show("Registro Eliminado")

                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                cliente.PoblarDataGridCliente(dgv_huesped)
            End If
        End If

    End Sub

    Private Sub dgv_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick
        Dim renglon As Integer
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        renglon = dgv_huesped.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVclientes.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente

        txtbox_id.Text = dgv_huesped.Rows(renglon).Cells(0).Value
        txt_nombre.Text = dgv_huesped.Rows(renglon).Cells(1).Value
        txtbox_apellidoPaterno.Text = dgv_huesped.Rows(renglon).Cells(2).Value
        txtbox_apellidoMaterno.Text = dgv_huesped.Rows(renglon).Cells(3).Value

        Dim telefono As New Telefono
        If txtbox_id.Text <> "" Then

            telefono.getSetIdDueño = txtbox_id.Text
            telefono.getSetTipoDueño = Persona.tipoPersona.Cliente

            If telefono.consultaTel_tel() Then
                txt_numero.Text = telefono.getSetNumero
            Else
                txt_numero.Text = ""
            End If
        End If




    End Sub




    'Realiza una busqueda en la base de datos y si encuentra el cliente con ese id rellena los campos y muestra el me
    'mensaje de que se ha encontrado
    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim cliente As New huespeda()
        Dim telefono As New Telefono
        If txt_BuscarID.Text <> "" Then
            cliente.getSetidCliente = CInt(txt_BuscarID.Text)
            telefono.getSetIdDueño = txt_BuscarID.Text
            telefono.getSetTipoDueño = Persona.tipoPersona.Cliente
        End If
        If cliente.consultaCliente() Then
            MsgBox("Cliente encontrado!")
            If telefono.consultaTel_tel() Then
                txt_numero.Text = telefono.getSetNumero
            Else
                txt_numero.Text = ""
            End If
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
        txt_numero.Text = ""
    End Sub

    Private Sub bt_selectTel_Click(sender As Object, e As EventArgs)
        Form_Telefono.Show()
    End Sub




    Private Sub txt_numero_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_numero.MaskInputRejected

    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        'Si se intenta modificar el telefono se borra el mensaje de error
        lb_telefono.Text = ""
    End Sub

    Public Function limpiar_caracteresCampoTelefono() As String
        Return Replace(txt_numero.Text, "-", "")
    End Function



    Private Sub txtbox_id_TextChanged(sender As Object, e As EventArgs) Handles txtbox_id.TextChanged
        'Realizamos la busqueda del telefono

    End Sub
End Class
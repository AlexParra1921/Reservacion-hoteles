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
            MessageBox.Show("Capture un telefono para el Huesped!!")
        ElseIf cb_reservaciones.Text = "" Then
            MessageBox.Show("Seleccione una reservacion para el Huesped!!")
        ElseIf txt_edad.Text = "" Then
            MessageBox.Show("Captura la edad para el Huesped!!")
        Else
            'instanciamos la clase y le pasamos como parámetros los cuatro datos
            Dim strTel = limpiar_caracteresCampoTelefono()

            Dim id_reservacion = cb_reservaciones.Text

            Dim huesped As New Huesped(txtbox_id.Text, id_reservacion, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text, txt_edad.Text)
            If huesped.consultaIdReservacion() = False Then
                MsgBox("El numero de reservacion no existe, corrigalo.")
                Return
            End If

            Dim telefono As New Telefono(txtbox_id.Text, strTel, "+52", Persona.tipoPersona.Huesped)



            'En el siguiente IF, usamos un método para verificar si el huesped está registrado
            ' en esa huesped de ese estado

            If huesped.consultaHuesped() = False Then
                'Si el huesped NO está registrada, la inserta como una nueva
                Try
                    huesped.insertarhuesped() 'INSERTA NUEVA CIUDAD
                    'Verificamos si los campos estan llenos y si tenemos el id del dueño para indicar de quiens sera el telefono
                    If telefono.consultaTel_tel() Then
                        lb_telefono.Text = "Este numero ya pertenece a un Huesped"
                        huesped.elmininarHuesped()
                        Return
                    Else
                        telefono.insertarTel()
                    End If

                    'Con ésta función mandamos una ventana de notificación al usuario final
                    MessageBox.Show("Huesped Registrado ...")
                Catch ex As Exception
                    MsgBox("Error la realizar el registro del Huesped:" & ex.Message)
                End Try

            Else

                If MessageBox.Show("¿Esta seguro modifcar el registro con ID=[" & txtbox_id.Text & "]?",
                                   "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Try



                        'Si el telefono del huesped existe pero pertnece a otro huesped no actualizar huesped
                        If telefono.consultaTel_id() Then
                            If telefono.getSetIdDueño <> huesped.getSetIdHuesped Then
                                lb_telefono.Text = "Este numero ya pertenece a un huesped"
                                Return
                            End If
                        Else
                            'Si algun numero existe en la BD perteneciente al cliente eliminarlo
                            If telefono.consultaTel_tel() Then
                                telefono.eliminaTelefono()
                            End If
                            telefono.getSetNumero = strTel
                            'Si el telefono no existe entonces agregar el nuevo 
                            telefono.insertarTel()
                        End If

                        'Si el huesped se encuentra registrada, se modifica la información
                        huesped.actualizarHuesped() 'ACTUALIZA el huesped

                        'Con ésta función mandamos una ventana de notificación al usuario final
                        MsgBox("huesped modificado ...")
                    Catch ex As Exception
                        MsgBox("Error al realizar la actualizacion del huesped: /n" & ex.Message)
                    End Try

                End If

            End If

            'Una vez realizada la accion del Insert o Update, debemos de presentar
            'la información de nueva cuenta en el DGV correspondiente

            huesped.PoblarDataGridhuesped(dgv_huesped)

        End If
    End Sub

    Private Sub Form_huesped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim huesped As New Huesped

        'Poblamos el combo de reservaciones
        huesped.poblarComboReservacion(cb_reservaciones)
        'Poblamos el Data Grid View para los huespeds
        huesped.PoblarDataGridHuesped(dgv_huesped)

        cnx.Close()

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        'Validamos que ese huesped no tenga colonias dadas de alta, es decir que no tenga hijos.
        'Si tu BD tiene las reglas de integridad referencial, el DBMS hará la validación, pero
        'hay que controlar esa validación y mandar un mensaje apropiado al usuario final
        Dim id_reservacion = cb_reservaciones.SelectedItem
        Dim Huesped As New Huesped(txtbox_id.Text, id_reservacion, txt_nombre.Text, txtbox_apellidoPaterno.Text, txtbox_apellidoMaterno.Text, txt_edad.Text)
        Dim telefono As New Telefono
        telefono.getSetIdDueño = txtbox_id.Text
        telefono.getSetTipoDueño = Persona.tipoPersona.Huesped


        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            If telefono.consultaTel_tel() Then
                telefono.eliminaTelefono()
            End If
            'Llamamos al método que elimina el registro de el huesped
            Huesped.elmininarHuesped()

            MessageBox.Show("Registro Eliminado")

            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
            huesped.PoblarDataGridhuesped(dgv_huesped)
        End If


    End Sub






    'Realiza una busqueda en la base de datos y si encuentra el huesped con ese id rellena los campos y muestra el me
    'mensaje de que se ha encontrado
    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim huesped As New Huesped()
        Dim telefono As New Telefono
        If txt_BuscarID.Text <> "" Then
            huesped.getSetidhuesped = CInt(txt_BuscarID.Text)
            telefono.getSetIdDueño = txt_BuscarID.Text
            telefono.getSetTipoDueño = Persona.tipoPersona.Huesped
        End If
        If huesped.consultahuesped() Then
            MsgBox("huesped encontrado!")
            If telefono.consultaTel_tel() Then
                txt_numero.Text = telefono.getSetNumero
            Else
                txt_numero.Text = ""
            End If
        Else
            MsgBox("huesped no encontrado!")
        End If

    End Sub

    Private Sub bt_limpiar_Click(sender As Object, e As EventArgs) Handles bt_limpiar.Click
        txtbox_id.Text = ""
        txt_BuscarID.Text = ""
        txt_nombre.Text = ""
        txtbox_apellidoPaterno.Text = ""
        txtbox_apellidoMaterno.Text = ""
        cb_reservaciones.Text = ""
        txt_edad.Text = ""
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



    Private Sub txtbox_id_TextChanged(sender As Object, e As EventArgs)
        'Realizamos la busqueda del telefono

    End Sub



    Private Sub txtbox_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_id.KeyPress
        If Not IsNumeric(e.KeyChar) Then

            If Not e.KeyChar.GetHashCode = 522496 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_BuscarID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarID.KeyPress
        If Not IsNumeric(e.KeyChar) Then

            If Not e.KeyChar.GetHashCode = 522496 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_edad.KeyPress
        If Not IsNumeric(e.KeyChar) Then

            If Not e.KeyChar.GetHashCode = 522496 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub dgv_huesped_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_huesped.CellClick
        Dim renglon As Integer
        'Con éste código podemos seleccionar los datos que están mostrados
        'en un DGV, la variable renglón no sirve para saber en qué renglón se da clic

        renglon = dgv_huesped.CurrentCellAddress.Y

        'Al darle clic al renglón mostramos los datos en las cajas de texto
        'DGVhuespeds.Rows(renglon) nos dice cual renglón se ha dado clic
        'Cells(0).Value recupera el DATO de la celda o columna del DGV y lo 
        'dejamos en la caja de texto correspondiente
        cb_reservaciones.Text = dgv_huesped.Rows(renglon).Cells(0).Value
        txtbox_id.Text = dgv_huesped.Rows(renglon).Cells(1).Value
        txt_nombre.Text = dgv_huesped.Rows(renglon).Cells(3).Value
        txtbox_apellidoPaterno.Text = dgv_huesped.Rows(renglon).Cells(4).Value
        txtbox_apellidoMaterno.Text = dgv_huesped.Rows(renglon).Cells(5).Value
        txt_edad.Text = dgv_huesped.Rows(renglon).Cells(6).Value
        Dim telefono As New Telefono
        If txtbox_id.Text <> "" Then

            telefono.getSetIdDueño = txtbox_id.Text
            telefono.getSetTipoDueño = Persona.tipoPersona.Huesped

            If telefono.consultaTel_tel() Then
                txt_numero.Text = telefono.getSetNumero
            Else
                txt_numero.Text = ""
            End If
        End If


    End Sub
End Class
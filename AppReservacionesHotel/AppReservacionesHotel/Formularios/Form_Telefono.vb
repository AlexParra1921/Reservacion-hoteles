Public Class Form_Telefono
    Private Sub Form_Telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vamos a poblar el DGV de los telefonos de cliente
        Dim tel As New Telefono
        tel.getSetTipoDueño = Persona.tipoPersona.Cliente
        tel.PoblarDataGridTel(dgv_telefonoCliente)
    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        'Verificamos si los campos estan llenos y si tenemos el id del dueño para indicar de quiens sera el telefono
        If txt_numero.Text <> "" And Form_cliente.txtbox_id.Text <> "" Then
            Dim telefono As New Telefono(Form_cliente.txtbox_id.Text, txt_numero.Text, "+52", Persona.tipoPersona.Cliente)
            Try
                telefono.insertarTel()
            Catch ex As Exception
                MsgBox("Error al agregar telefono, mensaje de erro" & ex.Message)
            End Try
            telefono.PoblarDataGridTel(dgv_telefonoCliente)
        End If
    End Sub



    Private Sub txt_numero_TextChanged_1(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        'Verificamos si los campos estan llenos de lo contrario no s realizara la busqueda
        If txt_numero.Text <> "" And Form_cliente.txtbox_id.Text <> "" Then
            Dim telefono As New Telefono(Form_cliente.txtbox_id.Text, txt_numero.Text, "+52", Persona.tipoPersona.Cliente)
            telefono.consultaTel_Poblando(dgv_telefonoCliente)
        End If
    End Sub

    Private Sub bt_seleccionar_Click(sender As Object, e As EventArgs) Handles bt_seleccionar.Click

    End Sub
End Class
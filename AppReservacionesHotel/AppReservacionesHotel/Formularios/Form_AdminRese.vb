Public Class Form_AdminRese
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form_AdminRese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se cargara las reservaciones de los hoteles y habitaciones
        'Poblar DGV reservaciones
        Dim reservacion As New Reservaciones
        reservacion.poblarDGVReservaciones(dgv_reservaciones)

    End Sub

    Private Sub txt_busquedaID_TextChanged(sender As Object, e As EventArgs) Handles txt_busquedaID.TextChanged
        'Se captura el id de reservacion y se realiza una
        'busqueda de la reservacion en el DGV
        If txt_busquedaID.Text <> "" Then
            Dim id As Integer = txt_busquedaID.Text
            Dim founded = False
            For Each row As DataGridViewRow In dgv_reservaciones.Rows
                If id = row.Cells(0).Value Then
                    dgv_reservaciones.CurrentCell = dgv_reservaciones.Item(0, row.Index)
                    dgv_reservaciones.Rows(row.Index).Selected = True
                    founded = True
                End If
            Next

            If founded = False Then
                MsgBox("Reservacion  no encontrada", MsgBoxStyle.Information, "Busqueda De Reservacion")
            End If

        End If
    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click
        'Se abre un formulario parecido al de reservaciones
        Form_ModifRese.Show()

    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        'Muestra una ventana donde pide confirmacion de la cancelacion

        Dim id_reservacion As Integer = dgv_reservaciones.SelectedRows.Item(0).Cells(0).Value
        Dim reservacion As New Reservaciones
        reservacion.gs_id_reservacion = id_reservacion
        If reservacion.consultarReservacion Then
            Dim rembolso = reservacion.gs_costo * 0.3
            Dim fechaReservacion = String.Format("{0}-{1}-{2}", (DateTime.Now).Year, (DateTime.Now).Month, (DateTime.Now).Day)
            Dim can As New Cancelacion(id_reservacion, rembolso, fechaReservacion)

            If reservacion.cancelacion(can) Then
                MsgBox(String.Format("Se ha realizado la cancelacion de la reservacion con el ID=[{0}]", id_reservacion),
                                    MsgBoxStyle.Critical, "Cancelacion")
                reservacion.poblarDGVReservaciones(dgv_reservaciones)
            End If


        End If






    End Sub
End Class
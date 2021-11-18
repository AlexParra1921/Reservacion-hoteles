Public Class formUbicacion

    Private Sub formUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ubicacion As New Ubicacion

        'Poblamos el DGV de los países, la clase ciudades tiene un método llamado poblarcombopaises
        'y para que sepa que combo queremos llenar con datos le pasamos como parámetro el nombre del combo

        ubicacion.poblarComboPais(Cmb_pais)

        'Para cerrar la BD, la variable que tiene el nombre de la BD y el usuario con la palabra CLOSE
        cnx.Close()

        'Definimos mensaje de ayuda en los botones

        'la palabre Me, hace referencia al nombre del formulario, es como cuando hablamos en primera persona
        'y decimos yo, para no decir Juan Perez y Parez

        'ToolTip1 es un objeto que se encuentra en el cuadro o caja de herramientas, nos ayuda a
        'resentar pequeños mensajes en los objetos cuando el cursor está arriba del objeto

        'lo que está entre comillas es el mensaje de ayuda

    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        'Se puede limpiar una caja de textos de diferente manera, aquí les muestro dos,
        'ambas hacen lo mismo, quita el contenido de las cajas de texto 

        Txt_noUbi.Text = vbNullString
        Txt_dir.Text = ""

        'Para poner o mandar el cursor a una caja de textos
        Txt_noUbi.Focus()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click

    End Sub


End Class
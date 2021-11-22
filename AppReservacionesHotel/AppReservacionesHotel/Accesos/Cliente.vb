Public Class Cliente
    Inherits Persona

    Private id_cliente As Integer



    Public Sub New(id_cliente As Integer, nombre As String, apellidoPaterno As String, apellidoMaterno As String)
        MyBase.New(nombre, apellidoPaterno, apellidoMaterno, 0)
        Me.id_cliente = id_cliente

    End Sub

    Public Sub New()
    End Sub

    Public Property getSetidCliente() As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            Me.id_cliente = value
        End Set
    End Property


    'Metodo para realizar insert de Clientes
    Public Sub insertarCliente()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If id_cliente <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoPaterno <> "" Then
            strSql = "INSERT INTO cliente values(" & id_cliente & ",'" & getSetNombre & "','" & getSetApellidoPaterno & "', '" & getSetApellidoMaterno & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el cliente, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If

    End Sub

    'SQL para actualizar cliente

    Public Sub actualizaCliente()
        Dim strSql As New String("")
        Dim xCnx As New Mysql
        If id_cliente <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoMaterno <> "" Then
            strSql = "UPDATE cliente set ID_cliente=" & id_cliente & ", nombre='" & getSetNombre & "', paterno='" & getSetApellidoPaterno &
                "', materno='" & getSetApellidoMaterno & "' WHERE id_cliente=" & id_cliente



            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el cliente, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Function consultaCliente() As Boolean
        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        strSQL = "Select id_cliente as ID, nombre, paterno as 'apellido paterno', materno as 'apellido materno' FROM cliente" &
                    " WHERE id_cliente=" & getSetidCliente
        consultaCliente = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("ID")) Then
                'Mantiene los campos limpios en caso de que el ID sea nu
                id_cliente = 0
                getSetNombre = ""
                getSetApellidoPaterno = ""
                getSetApellidoMaterno = ""

            Else
                ' Actualiza los txt box en caso de que el registro recibido concida con el ID y sea real
                Form_cliente.txtbox_id.Text = xDT.Rows(0)("ID")
                Form_cliente.txt_nombre.Text = xDT.Rows(0)("nombre")
                Form_cliente.txtbox_apellidoPaterno.Text = xDT.Rows(0)("apellido paterno")
                Form_cliente.txtbox_apellidoMaterno.Text = xDT.Rows(0)("apellido materno")

            End If
            consultaCliente = True
        End If
    End Function

    Public Function consultaTodosCliente() As Object
        Dim strSQL As String
        Dim xCnx As New Mysql
        strSQL = "SELECT id_cliente as ID, nombre, paterno as 'Apellido paterno', materno as 'Apellido materno' FROM cliente ORDER BY id_cliente asc"

        consultaTodosCliente = xCnx.objetoDataAdapter(strSQL)

    End Function

    Public Sub PoblarDataGridCliente(ByVal GDVcliente As DataGridView)
        GDVcliente.DataSource = consultaTodosCliente()

        GDVcliente.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba
        GDVcliente.Columns.Item(0).Width = 30
        GDVcliente.Columns.Item(1).Width = 250
        GDVcliente.Columns.Item(2).Width = 250
        GDVcliente.Columns.Item(3).Width = 250


    End Sub

    Public Sub eliminarCliente()
        Dim strSql As String
        Dim xCnx As New Mysql

        If id_cliente <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoPaterno <> "" Then
            strSql = "DELETE FROM cliente where id_cliente=" & id_cliente
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del cliente, verifique!!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Este metodo se para validar si el cliente tiene reservaciones en el hotel

    Public Function validarClientes() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        strSql = "SELECT * FROM reservacion where id_cliente=" & id_cliente

        validarClientes = False
        xCnx.objetoCommand(strSql)
        xDT = xCnx.objetoDataAdapter(strSql)


        If xDT.Rows.Count >= 1 Then
            validarClientes = True
        End If


    End Function

    Public Function consultaClientePoblarDGV(ByVal DGVcliente As DataGridView) As Boolean
        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable



        strSQL = "Select id_cliente as ID, nombre, paterno as 'apellido paterno', materno as 'apellido materno' FROM cliente" &
                    " WHERE id_cliente=" & getSetidCliente
        consultaClientePoblarDGV = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("ID")) Then
                'Mantiene los campos limpios en caso de que el ID sea nu
                id_cliente = 0
                getSetNombre = ""
                getSetApellidoPaterno = ""
                getSetApellidoMaterno = ""

            Else
                'Guardar la busqueda del cliente en el DGVCliente
                id_cliente = xDT.Rows(0)("ID")
                getSetNombre = xDT.Rows(0)("nombre")
                getSetApellidoPaterno = xDT.Rows(0)("apellido paterno")
                getSetApellidoMaterno = xDT.Rows(0)("apellido materno")


                DGVcliente.DataSource = xDT
                DGVcliente.Refresh()

                'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
                ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
                ' estarán determinadas por el Query (select) de arriba
                DGVcliente.Columns.Item(0).Width = 30
                DGVcliente.Columns.Item(1).Width = 250
                DGVcliente.Columns.Item(2).Width = 250
                DGVcliente.Columns.Item(3).Width = 250

            End If
            consultaClientePoblarDGV = True
        End If
    End Function
End Class

Public Class Telefono

    Private numero As String
    Private lada As String
    Private idDueño As Integer
    Private tipoDueño As Persona.tipoPersona

    Public Sub New()
        numero = ""
        lada = ""
        idDueño = 0
    End Sub

    Public Sub New(IdDueño As Integer, numero As String, lada As String, tipoDueño As Persona.tipoPersona)
        Me.numero = numero
        Me.lada = lada
        Me.idDueño = IdDueño
        Me.tipoDueño = tipoDueño
    End Sub

    Public Property getSetNumero() As String
        Get
            Return Me.numero
        End Get
        Set(value As String)
            Me.numero = value
        End Set
    End Property

    Public Property getSetlada() As String
        Get
            Return lada
        End Get
        Set(value As String)
            Me.lada = value
        End Set
    End Property

    Public Property getSetIdDueño As Integer
        Get
            Return idDueño
        End Get
        Set(value As Integer)
            Me.idDueño = value
        End Set
    End Property

    Public Property getSetTipoDueño As Persona.tipoPersona
        Get
            Return tipoDueño
        End Get
        Set(value As Persona.tipoPersona)
            Me.tipoDueño = value
        End Set
    End Property

    'Inserta nueva ciudad en la tabla correspondiente
    'la tabla tiene 4 atributos, por lo tanto se requieren de 4 valores

    ' ----------------------------------------------------------------------------------------------------------
    'La parte que corresponde a la sintaxis del INSERT se escriben entre comillas 
    '        "INSERT INTO nombretabla VALUES(" 
    ' para indicar que hay continuación en la sintaxis se usa el simbolo & 
    ' Si el dato entra en un atributo tipo NUMERICO, ENTERO se escribe sin apóstrofe 
    '   "INSERT INTO nombretabla VALUES(" & primerdato 
    ' la como es parte de la sintaxis del INSERT entonces se escribe entre comillas
    '   "INSERT INTO nombretabla VALUES(" & primerdato & ", " 
    ' los datos que entran en campos VARCHAR o DATE se encierran entre apóstrofe
    ' ----------------------------------------------------------------------------------------------------------

    'Insertar telefono en la tabla del tipo de dueño
    Public Sub insertarTel()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If idDueño <> 0 And numero <> "" And tipoDueño <> 0 Then

            Select Case tipoDueño
                Case Persona.tipoPersona.Administrador
                    strSql = "INSERT INTO telefono_administrador values('" & numero & "', " & idDueño & ")"
                Case Persona.tipoPersona.Cliente
                    strSql = "INSERT INTO telefono_cliente values('" & numero & "', " & idDueño & ")"
                Case Persona.tipoPersona.Empleado
                    strSql = "INSERT INTO telefono_empleado values('" & numero & "', " & idDueño & ")"
                Case Persona.tipoPersona.Huesped
                    strSql = "INSERT INTO telefono_huesped values('" & numero & "', " & idDueño & ")"
            End Select

            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para el telefono del dueño , verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If


    End Sub
    'SQL para actualizar telefonos
    Public Sub actualizaTel()
        Dim strSql As String
        Dim xCnx As New Mysql
        If idDueño <> 0 And numero <> "" And tipoDueño <> 0 Then

            Select Case tipoDueño
                Case Persona.tipoPersona.Administrador
                    strSql = "UPDATE telefono_administrador set Telefono='" & numero & "', ID_Cliente=" & idDueño &
                             " WHERE telefono='" & numero & "'"
                Case Persona.tipoPersona.Cliente
                    strSql = "UPDATE telefono_cliente set Telefono='" & numero & "', ID_Cliente=" & idDueño &
                             " WHERE telefono='" & numero & "'"
                Case Persona.tipoPersona.Empleado
                    strSql = "UPDATE telefono_empleado set Telefono='" & numero & "', ID_Cliente=" & idDueño &
                             " WHERE telefono='" & numero & "'"
                Case Persona.tipoPersona.Huesped
                    strSql = "UPDATE telefono_huesped set Telefono='" & numero & "', ID_Cliente=" & idDueño &
                             " WHERE telefono='" & numero & "'"
            End Select

            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para el telefono del dueño seleccionado, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If

    End Sub
    'Consultar telefonos
    Public Function consultaTel_tel() As Boolean

        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        Select Case tipoDueño
            Case Persona.tipoPersona.Administrador

                strSQL = "SELECT tel.id_administrador as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_administrador as tel, administrador as ad " &
                          "WHERE tel.id_administrador=ad.id_cliente and ad.id_cliente=" & idDueño

            Case Persona.tipoPersona.Cliente
                strSQL = "SELECT tel.id_cliente as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_cliente as tel, cliente as cl " &
                          "WHERE tel.id_cliente=cl.id_cliente  and cl.id_cliente=" & idDueño

            Case Persona.tipoPersona.Empleado

                strSQL = "SELECT tel.id_empleado as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_empleado as tel, empleado as ep " &
                          "WHERE tel.id_empleado=ep.id_empleado  and ep.id_cliente=" & idDueño

            Case Persona.tipoPersona.Huesped

                strSQL = "SELECT tel.id_huesped as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_huesped as tel, huesped as hp " &
                          "WHERE tel.id_huesped=hp.id_huesped  and hp.id_cliente=" & idDueño

        End Select


        consultaTel_tel = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id")) Then
                numero = ""
                idDueño = 0
            Else
                numero = CStr(xDT.Rows(0)("telefono"))
                idDueño = xDT.Rows(0)("ID")
            End If

            consultaTel_tel = True
        End If
    End Function
    Public Function consultaTel_id() As Boolean

        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        Select Case tipoDueño
            Case Persona.tipoPersona.Administrador

                strSQL = "SELECT tel.id_administrador as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_administrador as tel, administrador as ad " &
                          "WHERE tel.id_administrador=ad.id_cliente  and telefono='" & numero & "'"

            Case Persona.tipoPersona.Cliente
                strSQL = "SELECT tel.id_cliente as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_cliente as tel, cliente as cl " &
                          "WHERE tel.id_cliente=cl.id_cliente  and telefono='" & numero & "'"

            Case Persona.tipoPersona.Empleado

                strSQL = "SELECT tel.id_empleado as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_empleado as tel, empleado as cl " &
                          "WHERE tel.id_empleado=cl.id_empleado  and telefono='" & numero & "'"

            Case Persona.tipoPersona.Huesped

                strSQL = "SELECT tel.id_huesped as id, telefono, nombre, paterno, materno " &
                          "FROM telefono_huesped as tel, huesped as cl " &
                          "WHERE tel.id_huesped=cl.id_huesped  and telefono='" & numero & "'"

        End Select


        consultaTel_id = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("telefono")) Then
                numero = ""
                idDueño = 0
            Else
                numero = CStr(xDT.Rows(0)("telefono"))
                idDueño = xDT.Rows(0)("ID")
            End If

            consultaTel_id = True
        End If
    End Function

    Public Function consultaTel_Poblando(ByVal GDV_telefono As DataGridView) As Boolean

        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        Select Case tipoDueño
            Case Persona.tipoPersona.Administrador
                strSQL = "SELECT telefono_administrador.ID_Cliente, telefono, nombre, paterno, materno" &
                         " FROM telefono_administrador, administrador " &
                         "WHERE telefono='" & numero & "'"
            Case Persona.tipoPersona.Cliente
                strSQL = "SELECT telefono_cliente.ID_Cliente, telefono, nombre, paterno, materno" &
                         " FROM telefono_cliente, cliente " &
                         "WHERE telefono='" & numero & "'"
            Case Persona.tipoPersona.Empleado
                strSQL = "SELECT telefono_empleado.ID_Cliente, telefono, nombre, paterno, materno" &
                         " FROM telefono_empleado, empleado " &
                         "WHERE telefono='" & numero & "'"
            Case Persona.tipoPersona.Huesped
                strSQL = "SELECT telefono_huesped.ID_Cliente, telefono, nombre, paterno, materno" &
                         " FROM telefono_huesped, huesped" &
                         "WHERE telefono='" & numero & "'"
        End Select


        consultaTel_Poblando = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            If Not IsDBNull(xDT.Rows(0)("telefono")) Then
                GDV_telefono.DataSource = xDT
                GDV_telefono.Refresh()
            End If
            consultaTel_Poblando = True
        End If
    End Function






    Public Function consultaTodosTelefono() As Object
        Dim strSQL As String
        Dim xCnx As New Mysql
        ' strSQL = "SELECT id_ciudad as ID, ciudades.nombre as Ciudad " &
        '          " FROM paises, estados, ciudades " &
        '          " WHERE paises.id_pais = estados.id_pais AND " &
        '                " estados.id_pais = ciudades.id_pais and " &
        '                " estados.id_estado = ciudades.id_estado and " &
        '                " paises.nombre = '" & Frm_ciudades.Cmb_paises.Text & "' and " &
        '                " estados.nombre = '" & Frm_ciudades.Cmb_estados.Text & "'" &
        '                " ORDER BY ciudades.nombre asc"

        Select Case tipoDueño
            Case Persona.tipoPersona.Administrador
                strSQL = "SELECT telefono_administrador.ID_administrador, telefono, nombre, paterno, materno" &
                         " FROM telefono_administrador tel, administrador ad where tel.ID_administrador=ad.ID_administrador" &
                         " ORDER BY nombre asc"
            Case Persona.tipoPersona.Cliente
                strSQL = "SELECT tel.ID_Cliente, telefono, nombre, paterno, materno" &
                         " FROM telefono_cliente as tel, cliente as cl where tel.id_cliente=cl.id_cliente ORDER BY nombre asc"
            Case Persona.tipoPersona.Empleado
                strSQL = "SELECT telefono_empleado.ID_empleado, telefono, nombre, paterno, materno" &
                         " FROM telefono_empleado, empleado where telefono_empleado.id_empleado=empleado.id_empleado" &
                         "ORDER BY nombre asc"
            Case Persona.tipoPersona.Huesped
                strSQL = "SELECT telefono_huesped.ID_huesped, telefono, nombre, paterno, materno" &
                         " FROM telefono_huesped, huesped where telefono_huesped.id_huesped=huesped.id_huesped " &
                         " ORDER BY nombre asc"

        End Select
        consultaTodosTelefono = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridTel(ByVal GDVtelefonos As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV

        GDVtelefonos.DataSource = consultaTodosTelefono()

        'Con el refresh actualiza el contenido del DGV

        GDVtelefonos.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        GDVtelefonos.Columns.Item(0).Width = 200
        GDVtelefonos.Columns.Item(1).Width = 900
    End Sub

    Public Sub eliminaTelefono()
        Dim strSql As String
        Dim xCnx As New Mysql

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes
        If idDueño <> 0 And numero <> "" And tipoDueño <> 0 Then
            Select Case tipoDueño
                Case Persona.tipoPersona.Administrador
                    strSql = "DELETE FROM telefono_administrador" &
                          "where telefono='" & numero & "'"

                Case Persona.tipoPersona.Cliente
                    strSql = "DELETE FROM telefono_cliente" &
                          "where telefono='" & numero & "'"
                Case Persona.tipoPersona.Empleado
                    strSql = "DELETE FROM telefono_empleado" &
                          "where telefono='" & numero & "'"
                Case Persona.tipoPersona.Huesped
                    strSql = "DELETE FROM telefono_huesped" &
                          "where telefono='" & numero & "'"
            End Select

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos de la ciudad !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub


End Class

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

    Public Sub New(IdDueño As String, numero As String, lada As String, tipoDueño As Persona.tipoPersona)
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

    Public Property getSetIdDueño As String
        Get
            Return idDueño
        End Get
        Set(value As String)
            Me.idDueño = idDueño
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
                    strSql = "INSERT INTO telefono_administrador values(" & idDueño & ", '" & numero & "' )"
                Case Persona.tipoPersona.Cliente
                    strSql = "INSERT INTO telefono_cliente values(" & idDueño & ", '" & numero & "' )"
                Case Persona.tipoPersona.Empleado
                    strSql = "INSERT INTO telefono_empleado values(" & idDueño & ", '" & numero & "' )"
                Case Persona.tipoPersona.Huesped
                    strSql = "INSERT INTO telefono_huesped values(" & idDueño & ", '" & numero & "' )"
            End Select

            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para el telefono del dueño seleccionado, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If


    End Sub
    'SQL para actualizar telefonos
    Public Sub actualizaTel()
        Dim strSql As String
        Dim xCnx As New Mysql
        If idDueño <> 0 And numero <> "" And tipoDueño <> 0 Then

            Select Case tipoDueño
                Case Persona.tipoPersona.Administrador
                    strSql = "UPDATE telefono_administrador set Telefono='" & numero & "', ID_Cliente=" & idDueño & ")"
                Case Persona.tipoPersona.Cliente
                    strSql = "UPDATE telefono_cliente set Telefono='" & numero & "', ID_Cliente=" & idDueño & ")"
                Case Persona.tipoPersona.Empleado
                    strSql = "UPDATE telefono_empleado set Telefono='" & numero & "', ID_Cliente=" & idDueño & ")"
                Case Persona.tipoPersona.Huesped
                    strSql = "UPDATE telefono_huesped set Telefono='" & numero & "', ID_Cliente=" & idDueño & ")"
            End Select

            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para el telefono del dueño seleccionado, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If

    End Sub
    'Consultar telefonos
    Public Function consultaTel() As Boolean

        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        Select Case tipoDueño
            Case Persona.tipoPersona.Administrador
                strSQL = "SELECT ID_Cliente, telefono, nombre, Apellido_paterno, Apellido_materno" &
                         " FROM telefono_administrador, administrador " &
                         "WHERE telefono='" & numero &
                         "' and ID_Cliente='" & idDueño & "'"
            Case Persona.tipoPersona.Cliente
                strSQL = "SELECT ID_Cliente, telefono, nombre, Apellido_paterno, Apellido_materno" &
                         " FROM telefono_cliente, cliente " &
                         "WHERE telefono='" & numero &
                         "' and ID_Cliente='" & idDueño & "'"
            Case Persona.tipoPersona.Empleado
                strSQL = "SELECT ID_Cliente, telefono, nombre, Apellido_paterno, Apellido_materno" &
                         " FROM telefono_empleado, empleado " &
                         "WHERE telefono='" & numero &
                         "' and ID_Cliente='" & idDueño & "'"

            Case Persona.tipoPersona.Huesped
                strSQL = "SELECT ID_Cliente, telefono, nombre, Apellido_paterno, Apellido_materno" &
                         " FROM telefono_huesped, huesped" &
                         "WHERE telefono='" & numero &
                         "' and ID_Cliente='" & idDueño & "'"
        End Select


        consultaTel = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("telefono")) Then
                numero = ""
            Else
                numero = CStr(xDT.Rows(0)("telefono"))
                '  Frm_ciudades.TxtDescripcion.Text = CStr(xDT.Rows(0)("nombre"))
            End If

            consultaTel = True
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
        consultaTodosTelefono = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCd(ByVal GDVtelefonos As DataGridView)
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

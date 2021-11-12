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


End Class

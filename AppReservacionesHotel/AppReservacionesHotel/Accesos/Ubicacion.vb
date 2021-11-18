Public Class Ubicacion
    Private id_ubicacion As Integer
    Private id_colonia As Integer
    Private ubicacion As String

    'Constructor

    Public Sub New()
        Me.id_ubicacion = 0
        Me.id_colonia = 0
        Me.ubicacion = ""
    End Sub

    Public Sub New(id_ubicacion As Integer, id_colonia As Integer, ubicacion As String)
        Me.id_ubicacion = id_ubicacion
        Me.id_colonia = id_colonia
        Me.ubicacion = ubicacion
    End Sub

    'Métodos Getter and Setter

    Public Property getSetId_ubicacion() As Integer
        Get
            Return id_ubicacion
        End Get
        Set(ByVal value As Integer)
            id_ubicacion = value
        End Set
    End Property

    Public Property getSetId_colonia() As Integer
        Get
            Return id_colonia
        End Get
        Set(ByVal value As Integer)
            id_colonia = value
        End Set
    End Property

    Public Property getSetUbicacion() As String
        Get
            Return ubicacion
        End Get
        Set(ByVal value As String)
            ubicacion = value
        End Set
    End Property

    'metodos para realizar consultas
    Public Sub insertaCd()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        If idPais <> 0 And idEstado <> 0 And idCiudad <> 0 And nombre <> "" Then
            'Realiza inserción de datos

            ' ----------------------------------------------------------------------------------------------------------
            'La parte que corresponde a la sintaxis del INSERT se escriben entre comillas 
            '        "INSERT INTO nombretabla VALUES(" 
            ' para indicar que hay continuación en la sintaxis se usa el simbolo & 
            ' Si el dato entra en un atributo tipo NUMERICO, ENTERO se escribe sin apóstrofe 
            '   "INSERT INTO nombretabla VALUES(" & primerdato 
            ' la como es parte de la sintaxis del INSERT entonces se escribe entre comillas
            '   "INSERT INTO nombretabla VALUES(" & primerdato & ", " 
            ' los datos que entran en campos VARCHAR o DATE se encierran entre apóstrofe
            '"INSERT INTO Ciudades VALUES(" & idPais & ", " & idEstado & ", " & idCiudad & ", '" & nombre & "')"
            ' ----------------------------------------------------------------------------------------------------------

            strSql = "INSERT INTO Ciudades VALUES(" & idPais & ", " & idEstado & ", " & idCiudad & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            'Notificamos al usuario final por medio de un mensaje 

            MsgBox("Faltan datos para la ciudad del estado seleccionado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

End Class

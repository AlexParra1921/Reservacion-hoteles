Public Class Administrador
    Private nombre
    Private apellido_paterno
    Private apellido_materno
    Private idAdministrador
    Private CuentaLogin

    Public Sub New()
        Me.idAdministrador = 0
        Me.nombre = ""
        Me.apellido_paterno = ""
        Me.apellido_materno = ""
        Me.CuentaLogin = ""
    End Sub

    Public Sub New(idAdministrador As Integer, nombre As String, apellido_paterno As String, apellido_materno As String, cuentaLogin As String)
        Me.idAdministrador = idAdministrador
        Me.nombre = nombre
        Me.apellido_materno = apellido_materno
        Me.apellido_paterno = apellido_paterno
        Me.CuentaLogin = cuentaLogin
    End Sub

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property getSetApellidoPaterno() As String
        Get
            Return apellido_paterno
        End Get
        Set(value As String)
            Me.apellido_paterno = value
        End Set
    End Property

    Public Property getSetApellidoMaterno() As String
        Get
            Return apellido_materno
        End Get
        Set(value As String)
            Me.apellido_materno = value
        End Set
    End Property

    Public Property getSetIdAdministrador() As Integer
        Get
            Return Me.idAdministrador
        End Get
        Set(value As Integer)
            Me.idAdministrador = value
        End Set
    End Property

    Public Property getSetCuentaLogin() As String
        Get
            Return CuentaLogin
        End Get
        Set(value As String)
            Me.CuentaLogin = CuentaLogin
        End Set
    End Property

End Class

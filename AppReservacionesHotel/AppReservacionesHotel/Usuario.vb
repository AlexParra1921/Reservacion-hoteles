Public Class Usuario
    Private cuenta As String
    Private contraseña As String
    Private tipo As Short
    'Constructor


    Public Sub New()
        Me.cuenta = ""
        Me.contraseña = ""
        Me.tipo = 0
    End Sub

    Public Sub New(cuenta As String, contraseña As String, tipo As Short)
        Me.cuenta = cuenta
        Me.contraseña = contraseña
        Me.tipo = tipo
    End Sub

    'Metodos Get and Setter

    Public Property getSetCuenta() As String
        Get
            Return cuenta

        End Get
        Set(ByVal value As String)
            cuenta = value
        End Set
    End Property

    Public Property getSetContraseña() As String
        Get
            Return contraseña
        End Get
        Set(ByVal value As String)
            contraseña = value
        End Set
    End Property

    Public Property getSetTipo() As Short
        Get
            Return tipo
        End Get
        Set(value As Short)
            tipo = value
        End Set
    End Property
End Class

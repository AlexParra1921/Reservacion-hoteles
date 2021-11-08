Public Class Cliente
    Inherits Persona

    Private id_cliente As Integer
    Private id_Login As Integer

    Public Sub New()
        id_cliente = 0
        id_Login = 0
    End Sub

    Public Sub New(id_cliente As Integer, id_login As Integer, nombre As String, apellidoPaterno As String, apellidoMaterno As String, edad As Integer)
        MyBase.New(nombre, apellidoPaterno, apellidoMaterno, edad)
        Me.id_cliente = id_cliente
        Me.id_Login = id_login
    End Sub


    Public Property getSetidCliente() As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            Me.id_cliente = value
        End Set
    End Property

    Public Property getSetIdLogin() As Integer
        Get
            Return id_Login
        End Get
        Set(value As Integer)
            Me.id_Login = id_Login
        End Set
    End Property

End Class

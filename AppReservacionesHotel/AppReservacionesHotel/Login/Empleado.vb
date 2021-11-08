Public Class Empleado
    Inherits Persona

    Private id_login
    Private id_Empleado

    Public Sub New()
        Me.id_Empleado = ""
        Me.id_login = ""
    End Sub

    Public Sub New(ByVal id_Empleado As Integer, ByVal id_login As Integer, ByVal nombre As String, ByVal apellidoPaterno As String, ByVal apellidoMaterno As String, ByVal edad)
        MyBase.New(nombre, apellidoPaterno, apellidoMaterno, edad)
        Me.id_Empleado = id_Empleado
        Me.id_login = id_login
    End Sub

    Public Property getSetIdEmpleado() As Integer
        Get
            Return id_Empleado
        End Get
        Set(value As Integer)
            Me.id_Empleado = value
        End Set
    End Property

    Public Property getSetIdLogin() As Integer
        Get
            Return id_login
        End Get
        Set(value As Integer)
            Me.id_login = id_login
        End Set
    End Property

End Class



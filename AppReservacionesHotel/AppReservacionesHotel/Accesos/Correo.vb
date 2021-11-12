Public Class Correo
    Private Correo As String
    Private id_dueño As Integer
    Private tipoDueño As Persona.tipoPersona


    Public Sub New()
        Correo = 0
        id_dueño = 0
        tipoDueño = Persona.tipoPersona.NoAssign
    End Sub

    Public Sub New(ByVal id_dueño As Integer, ByVal correo As String, ByVal tipoDueño As Persona.tipoPersona)
        Me.id_dueño = id_dueño
        Me.Correo = correo
        Me.tipoDueño = tipoDueño
    End Sub

    Public Property getSetIdDueño() As Integer
        Get
            Return id_dueño
        End Get
        Set(value As Integer)
            Me.id_dueño = id_dueño
        End Set
    End Property

    Public Property getSetCorreo() As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Me.Correo = value
        End Set
    End Property

    Public Property getSetTipoDueño() As Persona.tipoPersona
        Get
            Return tipoDueño
        End Get
        Set(value As Persona.tipoPersona)
            Me.tipoDueño = value
        End Set
    End Property

End Class

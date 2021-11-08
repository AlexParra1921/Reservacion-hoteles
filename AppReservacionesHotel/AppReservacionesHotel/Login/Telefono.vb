Public Class Telefono

    Private numero As String
    Private lada As String
    Private idDueño As Short
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


End Class

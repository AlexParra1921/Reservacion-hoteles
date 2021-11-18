Public Class Ciudad
    Private id_ciudad As Integer
    Private id_estado As Integer
    Private colonia As String

    'Constructor

    Public Sub New()
        Me.id_ciudad = 0
        Me.id_estado = 0
        Me.colonia = ""
    End Sub

    Public Sub New(id_ciudad As Integer, id_estado As Integer, colonia As String)
        Me.id_ciudad = id_ciudad
        Me.id_estado = id_estado
        Me.colonia = colonia
    End Sub

    'Métodos Getter and Setter

    Public Property getSetId_ciudad() As Integer
        Get
            Return id_ciudad
        End Get
        Set(ByVal value As Integer)
            id_ciudad = value
        End Set
    End Property

    Public Property getSetId_estado() As Integer
        Get
            Return id_estado
        End Get
        Set(ByVal value As Integer)
            id_estado = value
        End Set
    End Property

    Public Property getSetColonia() As String
        Get
            Return colonia
        End Get
        Set(ByVal value As String)
            colonia = value
        End Set
    End Property

End Class

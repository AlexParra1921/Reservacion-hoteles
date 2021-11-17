Public Class Estado
    Private id_estado As Integer
    Private id_pais As Integer
    Private estado As String

    'Constructor

    Public Sub New()
        Me.id_estado =
        Me.id_pais = 0
        Me.estado = ""
    End Sub

    Public Sub New(id_estado As Integer, id_pais As Integer, colonia As String)
        Me.id_estado = id_estado
        Me.id_pais = id_pais
        Me.estado = estado
    End Sub

    'Métodos Getter and Setter

    Public Property getSetId_estado() As Integer
        Get
            Return id_estado
        End Get
        Set(ByVal value As Integer)
            id_estado = value
        End Set
    End Property

    Public Property getSetId_pais() As Integer
        Get
            Return id_pais
        End Get
        Set(ByVal value As Integer)
            id_pais = value
        End Set
    End Property

    Public Property getSetEstado() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property

End Class

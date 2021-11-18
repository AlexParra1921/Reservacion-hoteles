Public Class Pais
    Private id_pais As Integer
    Private pais As String

    'Constructor

    Public Sub New()
        Me.id_pais = 0
        Me.pais = ""
    End Sub

    Public Sub New(id_pais As Integer, pais As String)
        Me.id_pais = id_pais
        Me.pais = pais
    End Sub

    'Métodos Getter and Setter

    Public Property getSetId_pais() As Integer
        Get
            Return id_pais
        End Get
        Set(ByVal value As Integer)
            id_pais = value
        End Set
    End Property

    Public Property getSetPais() As String
        Get
            Return pais
        End Get
        Set(ByVal value As String)
            pais = value
        End Set
    End Property
    'estado, ciudad, ubicacion



End Class

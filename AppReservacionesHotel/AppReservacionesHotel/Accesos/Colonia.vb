Public Class Colonia
    Private id_colonia As Integer
    Private id_ciudad As Integer
    Private nombre As String
    Private codigo_postal As Integer

    'Constructor

    Public Sub New()
        Me.id_colonia = 0
        Me.id_ciudad = 0
        Me.nombre = ""
        Me.codigo_postal = 0
    End Sub

    Public Sub New(id_colonia As Integer, id_ciudad As Integer, nombre As String, codigo_postal As Integer)
        Me.id_colonia = id_colonia
        Me.id_ciudad = id_ciudad
        Me.nombre = nombre
        Me.codigo_postal = codigo_postal
    End Sub

    'Métodos Getter and Setter

    Public Property getSetId_colonia() As Integer
        Get
            Return id_colonia
        End Get
        Set(ByVal value As Integer)
            id_colonia = value
        End Set
    End Property

    Public Property getSetId_ciudad() As Integer
        Get
            Return id_ciudad
        End Get
        Set(ByVal value As Integer)
            id_ciudad = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property getSetCodigo_postal() As Integer
        Get
            Return codigo_postal
        End Get
        Set(ByVal value As Integer)
            codigo_postal = value
        End Set
    End Property


End Class

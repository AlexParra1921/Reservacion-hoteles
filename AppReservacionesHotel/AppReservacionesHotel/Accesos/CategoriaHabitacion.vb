Public Class CategoriaHabitacion
    Private Id_Categoria As Integer
    Private Precio As Decimal
    Private NumCamasI As Integer
    Private NumCamasM As Integer

    Public Sub New()
        Me.Id_Categoria = 0
        Me.Precio = 0
        Me.NumCamasI = 0
        Me.NumCamasM = 0
    End Sub

    Public Sub New(Id_Categoria As Integer, Precio As Decimal, NumCamasI As Integer, NumCamasM As Integer)
        Me.Id_Categoria = Id_Categoria
        Me.Precio = Precio
        Me.NumCamasI = NumCamasI
        Me.NumCamasM = NumCamasM
    End Sub

    Public Property getSetCategoria() As Integer
        Get
            Return Id_Categoria
        End Get
        Set(value As Integer)
            Id_Categoria = value
        End Set
    End Property

    Public Property getSetPrecio() As Integer
        Get
            Return Precio
        End Get
        Set(value As Integer)
            Precio = value
        End Set
    End Property

    Public Property getSetCamasI() As Integer
        Get
            Return NumCamasI
        End Get
        Set(value As Integer)
            NumCamasI = value
        End Set
    End Property

    Public Property getSetCamasM() As Integer
        Get
            Return NumCamasM
        End Get
        Set(value As Integer)
            NumCamasM = value
        End Set
    End Property

End Class

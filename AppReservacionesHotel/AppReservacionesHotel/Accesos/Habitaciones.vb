Public Class Habitaciones

    Private no_habitacion As Integer
    Private id_categoria As Integer
    Private id_hotel As Integer
    Private disponible As Boolean = False
    Private capacidad As Integer

    Public Sub New(no_habitacion As Integer, id_categoria As Integer, id_hotel As Integer, disponible As Boolean)
        Me.no_habitacion = no_habitacion
        Me.id_categoria = id_categoria
        Me.id_hotel = id_hotel
        Me.disponible = disponible
        Me.capacidad = capacidadCategoria()
    End Sub

    Public Property getSetCapacidad As Integer
        Get
            Return capacidad
        End Get
        Set(value As Integer)
            capacidad = value
        End Set
    End Property

    Public Property getSetDisponible As Boolean
        Get
            Return disponible
        End Get
        Set(value As Boolean)
            disponible = value
        End Set
    End Property

    Public Property getSetIdHotel As Integer
        Get
            Return id_hotel
        End Get
        Set(value As Integer)
            id_hotel = value
        End Set
    End Property

    Public Property getSetIdCategoria As Integer
        Get
            Return id_categoria
        End Get
        Set(value As Integer)
            id_categoria = value
        End Set
    End Property

    Public Property getSetHabitacion As Integer
        Get
            Return no_habitacion
        End Get
        Set(value As Integer)
            no_habitacion = value
        End Set
    End Property

    'Metodo para obtener la capacidad apartir de la categoria
    Private Function capacidadCategoria() As Integer
        Dim strSql As New String("")
        Dim xCnx As New Mysql
        Dim xDT As New DataTable
        Dim capacidad As Integer = 0
        strSql = String.Format("select id_categoria,descripcion,no_camas_m, no_camas_i from categoria where id_categoria={0}", id_categoria)

        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_categoria")) Then
                id_categoria = 0
            Else
                Dim cama_i = xDT.Rows(0)("no_camas_i")
                Dim cama_m = xDT.Rows(0)("no_camas_m")
                capacidad = (cama_i * 1) + (cama_m * 2)
            End If

        End If
        Return capacidad
    End Function

    'METOOD PARA POBLAR COMBO HOTEL
    Public Sub poblarComboHotel(ByVal cb_hotel As ComboBox)

    End Sub



End Class

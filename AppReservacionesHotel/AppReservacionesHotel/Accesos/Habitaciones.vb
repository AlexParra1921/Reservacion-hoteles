Imports MySql.Data.MySqlClient

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

    Public Sub New()
        no_habitacion = 0
        id_categoria = 0
        id_hotel = 0
        disponible = False
        capacidad = 0
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
        If id_categoria <> 0 Then
            Dim strSql As New String("")
            Dim xCnx As New Mysql
            Dim xDT As New DataTable
            Dim capacidad As Integer = 0
            strSql = String.Format("select id_categoria,descripcion,no_camas_m, 
                                no_camas_i from categoria 
                                where id_categoria={0}", id_categoria)

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
        End If
    End Function

    'METODO PARA CONSULTAR HABITACION
    Public Function consultarHabitacion() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As New DataTable

        strSql = String.Format("select * from habitacion where no_habitacion={0}", no_habitacion)

        consultarHabitacion = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("no_habitacion")) Then
                no_habitacion = 0
            Else
                no_habitacion = xDT.Rows(0)("no_habitacion")
                id_categoria = xDT.Rows(0)("id_categoria")
                id_hotel = xDT.Rows(0)("id_hotel")
                capacidad = capacidadCategoria()
                disponible = xDT.Rows(0)("Disponibilidad")
            End If
            consultarHabitacion = True
        End If


    End Function


    'METODO PARA CONSULTAR ID HOTEL
    Public Function consultarIdHotel() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As New DataTable
        If mihotel = "" Then
            MsgBox("No se ha seleccionado un Hotel")
            Return False
        End If
        strSql = String.Format(" select id_hotel from hotel where nombre='{0}'", mihotel)
        consultarIdHotel = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_hotel")) Then
                id_hotel = 0
            Else
                id_hotel = xDT.Rows(0)("id_hotel")
            End If
            consultarIdHotel = True
        End If
    End Function
    'METODO PARA CONSULTAR ID CATEGORIA

    Public Function consultaridCategoria() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As New DataTable
        If micategoria = "" Then
            MsgBox("No se ha seleccionado una Categoria de Habitacion", MsgBoxStyle.Information, "Informacion")
            Return False
        End If
        strSql = String.Format("select id_categoria from categoria where descripcion='{0}'", micategoria)
        consultaridCategoria = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_categoria")) Then
                id_categoria = 0
            Else
                id_categoria = xDT.Rows(0)("id_categoria")
            End If
            consultaridCategoria = True
        End If
    End Function


    'METOOD PARA POBLAR COMBO HOTEL
    Public Sub poblarComboHotel(ByVal cb_hotel As ComboBox)
        Dim lista As MySqlDataReader
        Dim strSQL As String
        Dim xCnx As New Mysql

        strSQL = String.Format("select nombre from hotel")

        lista = xCnx.objetoDataReader(strSQL)

        'Limpiamos el combo
        cb_hotel.Items.Clear()
        While lista.Read()
            cb_hotel.Items.Add(lista.GetValue(0))
        End While
        lista.Close()
    End Sub
    'METOOD PARA POBLAR COMBO CATEGORIA
    Public Sub poblarComboCategoria(ByVal cb_categoria As ComboBox)
        Dim lista As MySqlDataReader
        Dim strSQL As String
        Dim xCnx As New Mysql

        strSQL = String.Format("select distinct ca.descripcion from categoria as ca, habitacion hb where  hb.id_categoria=ca.id_categoria and  hb.id_hotel={0}", id_hotel)

        lista = xCnx.objetoDataReader(strSQL)
        'Limpiamos el combo

        cb_categoria.Items.Clear()
        While lista.Read()
            cb_categoria.Items.Add(lista.GetValue(0))
        End While
        lista.Close()
    End Sub
    'METOOD PARA POBLAR COMBO HABITACION
    Public Sub poblarComboHabitacion(ByVal cb_habitacion As ComboBox)
        Dim lista As MySqlDataReader
        Dim strSQL As String
        Dim xCnx As New Mysql

        strSQL = String.Format("select no_habitacion 
                                from categoria as ca,hotel as ht, habitacion hb 
                                where hb.id_hotel=ht.id_hotel and hb.id_categoria=ca.id_categoria 
                                and ht.id_hotel={0} and ca.id_categoria={1}", id_hotel, id_categoria)

        lista = xCnx.objetoDataReader(strSQL)
        'Limpiamos el combo

        cb_habitacion.Items.Clear()
        While lista.Read()
            cb_habitacion.Items.Add(lista.GetValue(0))
        End While
        lista.Close()
    End Sub

    'METODO PARA CONSULTAR TODAS LAS HABITACIONES
    Private Function consultarTodasHabitaciones() As Object


        Dim strSQL As String
        Dim xCnx As New Mysql
        strSQL = String.Format("select no_habitacion,capacidad, no_camas_m as 'Camas Matrimoniales', no_camas_i as 'Camas Individuales', precio, nombre as Hotel,descripcion 'Tipo Habitacion' 
                                    from categoria as ca, hotel as ht, habitacion as hb 
                                    where ht.id_hotel=hb.id_hotel and ca.id_categoria=hb.id_categoria 
                                    and hb.id_hotel={0} and hb.id_categoria={1}", id_hotel, id_categoria)

        consultarTodasHabitaciones = xCnx.objetoDataAdapter(strSQL)

    End Function

    'SOLO USO EN FORMULARIO DE BUSQUEDA DE HABITACIONES
    Private Function consultarTodasLasHabitacionesDisponibles() As Object
        Dim strSQL As String
        Dim xCnx As New Mysql
        strSQL = String.Format("select no_habitacion,capacidad, no_camas_m as 'Camas Matrimoniales', no_camas_i as 'Camas Individuales', precio, nombre as Hotel,descripcion 'Tipo Habitacion' 
                                    from categoria as ca, hotel as ht, habitacion as hb 
                                    where ht.id_hotel=hb.id_hotel and ca.id_categoria=hb.id_categoria and hb.disponibilidad=1 
                                    and hb.id_hotel={0} and hb.id_categoria={1};", id_hotel, id_categoria)

        consultarTodasLasHabitacionesDisponibles = xCnx.objetoDataAdapter(strSQL)
    End Function



    'METODO PARA POBLAR EL DATAVIEWGRID DE HABITACIONES - SOLO USO EN FORMULARIO DE BUSQUEDA DE HABITACIONES
    Public Sub poblarDGVBusquedaHabitacion(ByVal dgv_bh As DataGridView)
        dgv_bh.DataSource = consultarTodasLasHabitacionesDisponibles()
        dgv_bh.Refresh()

        dgv_bh.Columns.Item(5).Width = 150
    End Sub

End Class

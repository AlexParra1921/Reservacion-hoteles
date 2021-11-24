Imports AppReservacionesHotel

Public Class Habitacion_has_reservacion
    Public Sub New(habitacion As Habitaciones)
        If habitacion.getSetHabitacion <> 0 Then
            Me.habitacion = habitacion
        Else
            Throw New ArgumentException("Habitacion no contiene el id")
        End If
    End Sub

    Public Sub New(reservacion As Reservaciones)
        If reservacion.gs_id_reservacion <> 0 Then
            Me.reservacion = reservacion
        Else
            Throw New ArgumentException("Reservacion no contiene el id")
        End If
    End Sub

    Public Sub New(reservacion As Reservaciones, habitacion As Habitaciones)
        If reservacion.gs_id_reservacion <> 0 Then
            Me.reservacion = reservacion
        Else
            Throw New ArgumentException("Reservacion no contiene el id")
        End If
        If habitacion.getSetHabitacion <> 0 Then
            Me.habitacion = habitacion
        Else
            Throw New ArgumentException("Habitacion no contiene el id")
        End If
    End Sub

    Private Property reservacion As Reservaciones
    Private Property habitacion As Habitaciones

    Public Function consultarHabitaciones() As DataTable
        Dim strSql As New String("")
        Dim xCnx As New Mysql
        Dim xDT As New DataTable

        strSql = String.Format("select hb.no_habitacion as '#Habitacion',Capacidad, no_camas_m as 'Camas Matrimoniales', no_camas_i as 'Camas Individuales', Precio, nombre as Hotel,descripcion 'Tipo Habitacion' 
                                    from categoria as ca, hotel as ht, habitacion as hb, habitacion_has_reservacion hs 
                                    where ht.id_hotel=hb.id_hotel and ca.id_categoria=hb.id_categoria
                                    and hb.no_habitacion=hs.no_habitacion and hs.id_reservacion={0}", reservacion.gs_id_reservacion)
        consultarHabitaciones = xCnx.objetoDataAdapter(strSql)
    End Function

    Public Function consultarReservaciones() As DataTable
        Dim strSql As New String("")
        Dim xCnx As New Mysql
        Dim xDT As New DataTable

        consultarReservaciones = xCnx.objetoDataAdapter(strSql)
    End Function




End Class

Public Class Reservaciones
    Private id_reservaciones As Integer
    Private id_empleado As Integer
    Private id_cliente As Integer
    Private fechaEntrada As DateTime
    Private fechaSalida As DateTime
    Private fechaReservacion As DateTime
    Private costo As Decimal
    Private num_dias As Integer
    Private no_habitaciones As Integer



    Public Sub New(id_reservaciones As Integer, id_empleado As Integer, id_cliente As Integer, fechaEntrada As Date, fechaSalida As Date, fechaReservacion As Date, costo As Decimal, num_dias As Integer, no_habitaciones As Integer)
        Me.id_reservaciones = id_reservaciones
        Me.id_empleado = id_empleado
        Me.id_cliente = id_cliente
        Me.fechaEntrada = fechaEntrada
        Me.fechaSalida = fechaSalida
        Me.fechaReservacion = fechaReservacion
        Me.costo = costo
        Me.num_dias = num_dias
        Me.no_habitaciones = no_habitaciones
    End Sub

    Public Property gs_id_reservacion As Integer
        Get
            Return id_reservaciones
        End Get
        Set(value As Integer)
            id_reservaciones = value
        End Set
    End Property

    Public Property gs_id_empleado As Integer
        Get
            Return id_empleado
        End Get
        Set(value As Integer)
            id_empleado = value
        End Set
    End Property

    Public Property gs_id_cliente As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            id_cliente = value
        End Set
    End Property

    Public Property gs_fechaEntrada As Date
        Get
            Return fechaEntrada
        End Get
        Set(value As Date)
            fechaEntrada = value
        End Set
    End Property

    Public Property gs_fechaSalida As Date
        Get
            Return fechaSalida
        End Get
        Set(value As Date)
            fechaSalida = value
        End Set
    End Property

    Public Property gs_FechaReservacion As Date
        Get
            Return fechaReservacion
        End Get
        Set(value As Date)
            fechaReservacion = value
        End Set
    End Property

    Public Property gs_costo As Decimal
        Get
            Return costo
        End Get
        Set(value As Decimal)
            costo = value
        End Set
    End Property

    Public Property gs_num_dias As Integer
        Get
            Return num_dias
        End Get
        Set(value As Integer)
            num_dias = value
        End Set
    End Property

    Public Property gs_No_habitaciones As Integer
        Get
            Return no_habitaciones
        End Get
        Set(value As Integer)
            no_habitaciones = value
        End Set
    End Property

    Private Function validarCampos() As Boolean
        If gs_id_reservacion = 0 Then
        ElseIf gs_id_cliente = 0 Then
            Throw New ArgumentException("Id de reservacion invalido")
        ElseIf gs_id_empleado = 0 Then
            Throw New ArgumentException("Id de empleado invalido")
        ElseIf gs_No_habitaciones = 0 Then
            Throw New ArgumentException("Numero de habitaciones invalidas")
        ElseIf gs_num_dias = 0 Then
            Throw New ArgumentException("Numero de dias Invalido")
        ElseIf gs_FechaReservacion <> DateTime.Now Then
            Throw New ArgumentException("Fecha de Reservacion Invalida")
        ElseIf gs_fechaEntrada = DateTime.Now Then
            Throw New ArgumentException("Fecha de entrada invalida")
        ElseIf fechaSalida = DateTime.Now Then
            Throw New ArgumentException("Fecha de salida invalida")
        End If

        Return True


    End Function






    'METODO PARA REALIZAR INSERCCION DE RESERVACIONES

    Public Sub insertarReservacion()
        Dim strSQL As String
        Dim xCnx As Mysql

        Try
            validarCampos()

            strSQL = String.Format("insert into reservacion values({0},{1},{2},'{3}','{4}','{5}',{6},{7},{8})", id_reservaciones, id_empleado, id_cliente,
                                   fechaEntrada.ToString, fechaSalida.ToString, fechaReservacion.ToString, costo, num_dias, no_habitaciones)

            xCnx.objetoCommand(strSQL)
        Catch ex As ArgumentException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Invalido Campo")
        Catch ex As Exception
            MsgBox("Error al realizar la inserccion", MsgBoxStyle.Information, "Advertencia")
        End Try

    End Sub

    'METODO PARA REALIZAR INSERCCION EN TABLA HABITACION_HAS_RESERVACION

    Public Sub reservarHabitaciones(ByVal listaId_habitaciones As List(Of Integer))
        Dim strSQL As String
        Dim xCnx As New Mysql

        Try
            If listaId_habitaciones.Count = 0 Then
                Throw New ArgumentException("Habitaciones ingresadas '0'")
            End If
            validarCampos()
            For Each id_habitacion As Integer In listaId_habitaciones
                strSQL = String.Format("insert into habitacion_has_reservacion values({0},{1})", id_reservaciones, id_habitacion)
                Try
                    xCnx.objetoCommand(strSQL)
                Catch ex As Exception
                    MsgBox(String.Format("Error al reservar habitacion {0} \n {1}", id_habitacion, ex.Message))
                End Try
            Next

        Catch ex As ArgumentException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Invalido Campo")
        Catch ex As Exception
            MsgBox("Error al reservar habitaciones: \n" & ex.Message, MsgBoxStyle.Information, "Advertencia")
        End Try

    End Sub
    'METODO PARA MARCAR HABTIACIONES OCUPADAS
    Public Sub marcarHabitacionOcupada(ByVal listaId_habitaciones As List(Of Integer))
        Dim strSQL As String
        Dim xCnx As New Mysql
        Try
            If listaId_habitaciones.Count = 0 Then
                Throw New ArgumentException("Habitaciones ingresadas '0'")
            End If
            validarCampos()
            For Each id_habitacion As Integer In listaId_habitaciones
                strSQL = String.Format("update habitacion set disponibilidad=0 where No_habitacion={0};", id_habitacion)
                Try
                    xCnx.objetoCommand(strSQL)
                Catch ex As Exception
                    MsgBox(String.Format("Error al marcar habitacion Ocupada habitacion {0} \n {1}", id_habitacion, ex.Message))
                End Try
            Next
        Catch ex As ArgumentException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Invalido Campo")
        Catch ex As Exception
            MsgBox("Error al marcar habitaciones ocupadas: \n" & ex.Message, MsgBoxStyle.Information, "Advertencia")
        End Try
    End Sub

End Class

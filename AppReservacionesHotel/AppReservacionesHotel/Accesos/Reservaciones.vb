Imports MySql.Data.MySqlClient

Public Class Reservaciones
    Private id_reservaciones As Integer
    Private id_empleado As Integer
    Private id_cliente As Integer
    Private fechaEntrada As String
    Private fechaSalida As String
    Private fechaReservacion As String
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

    Public Sub New()
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

    Public Property gs_fechaEntrada As String
        Get
            Return fechaEntrada
        End Get
        Set(value As String)
            fechaEntrada = value
        End Set
    End Property

    Public Property gs_fechaSalida As String
        Get
            Return fechaSalida
        End Get
        Set(value As String)
            fechaSalida = value
        End Set
    End Property

    Public Property gs_FechaReservacion As String
        Get
            Return fechaReservacion
        End Get
        Set(value As String)
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
            Throw New ArgumentException("Id de reservacion invalido")
        ElseIf gs_id_cliente = 0 Then
            Throw New ArgumentException("Id de cliente Invalido")
        ElseIf gs_id_empleado = 0 Then
            Throw New ArgumentException("Id de empleado invalido")
        ElseIf gs_No_habitaciones = 0 Then
            Throw New ArgumentException("Numero de habitaciones invalidas")
        ElseIf gs_num_dias = 0 Then
            Throw New ArgumentException("Numero de dias Invalido")
        ElseIf gs_FechaReservacion = "" Then
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

    'Metodo para realizar la reservacion de las habitacion, se utilizara transacciones para agrupar todas 
    'las consultas en una sola, en caso de que falle alguna se realizara un rollback
    'Utilizamos una lista que contiene  el listado de id de habitaciones

    Public Function reservar(ByVal listaId_habitaciones As List(Of Integer)) As Boolean
        Dim command As MySqlCommand = cnx.CreateCommand()
        Dim Transac As MySqlTransaction

        'CREAMOS LA TRANSACCION
        Transac = cnx.BeginTransaction()
        command.Connection = cnx
        command.Transaction = Transac

        Try
            'VALIDAMOS QUE LOS CAMPOS PARA LA RESERVACION ESTEN CORRECTOS
            validarCampos()
            If listaId_habitaciones.Count = 0 Then
                Throw New ArgumentException("Habitaciones ingresadas '0'")
            End If

            Try
                command.CommandText = String.Format("insert into reservacion values({0},{1},{2},'{3}','{4}','{5}',{6},{7},{8})", id_reservaciones, id_empleado, id_cliente,
                                   fechaEntrada.ToString, fechaSalida.ToString, fechaReservacion.ToString, costo, num_dias, no_habitaciones)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            For Each id_habitacion As Integer In listaId_habitaciones
                'REALIZA LA RESERVACION DE CADA HABITACION INSERTANDO EN LA TABLA UN REGISTRO QUE MARCA QUE HABITACION TIENE RESERVACION 
                Try
                    command.CommandText = String.Format("insert into habitacion_has_reservacion values({0},{1})", id_reservaciones, id_habitacion)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception(String.Format("Error al reservar habitacion {0} \n {1}", id_habitacion, ex.Message))
                End Try
                'MARCA LA HABITACION COMO OCUPADA
                Try
                    command.CommandText = String.Format("update habitacion set disponibilidad=0 where No_habitacion={0};", id_habitacion)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception(String.Format("Error al marcar habitacion Ocupada habitacion {0} \n {1}", id_habitacion, ex.Message))
                End Try

            Next

            'SI TODAS LAS TRANSACCIONES SE REALIZARON SE REALIZA EL COMMIT
            Transac.Commit()
            reservar = True
        Catch ex As Exception
            Console.WriteLine("Error al realizar reservacion de las habitaciones \n Mensaje de error ----> " & ex.Message)
            reservar = False
            Try
                Transac.Rollback()
            Catch ex2 As Exception
                MsgBox("Hubo un erro al realizar la reservacion de habitaciones, la reservacion esta incompleta, comunicace con su DBA!" & ex2.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End Try
    End Function






    'METODO PARA BUSCAR EL ULTIMO ID DE RESERVACION
    Public Sub asignarIdReservacion()
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        strSql = String.Format("Select MAX(id_reservacion) as 'last id' from reservacion")

        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            id_reservaciones = xDT.Rows(0)("last id") + 1
        End If


    End Sub
End Class

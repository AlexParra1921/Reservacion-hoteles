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
    Public Property cancelada As Int16


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

    'METOD PARA CONSULTAR RESERVACION
    Public Function consultarReservacion() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        If id_reservaciones = 0 Then
            Return False
        End If
        strSql = String.Format("select * from reservacion where id_reservacion={0}", id_reservaciones)

        xDT = xCnx.objetoDataAdapter(strSql)
        consultarReservacion = False
        If xDT.Rows.Count = 1 Then
            id_reservaciones = xDT.Rows(0)("ID_Reservacion")
            id_empleado = xDT.Rows(0)("ID_Empleado")
            id_cliente = xDT.Rows(0)("ID_Cliente")
            fechaEntrada = xDT.Rows(0)("Fecha_Entrada")
            fechaSalida = xDT.Rows(0)("Fecha_Salida")
            fechaReservacion = xDT.Rows(0)("Fecha_Reservacion")
            costo = xDT.Rows(0)("costo")
            num_dias = xDT.Rows(0)("No_Dias")
            no_habitaciones = xDT.Rows(0)("No_habitaciones")
            cancelada = xDT.Rows(0)("cancelada")
            consultarReservacion = True
        End If
    End Function





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
                command.CommandText = String.Format("insert into reservacion values({0},{1},{2},'{3}','{4}','{5}',{6},{7},{8},0)", id_reservaciones, id_empleado, id_cliente,
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
            If IsDBNull(xDT.Rows(0)("last id")) Then
                id_reservaciones = 0
            Else
                id_reservaciones = xDT.Rows(0)("last id") + 1
            End If
        End If

    End Sub


    'METODO PARA CONSULTAR LAS RESERVACIONES MOSTRANDO COLUMNAS DESCRIPTAS

    Public Function consultaReservacionesDGV() As Object

        Dim strSql As String
        Dim xCnx As New Mysql
        strSql = String.Format(" SELECT res.id_reservacion '#', concat_ws(' ', cl.nombre , cl.paterno ,cl.materno ) 'Cliente', fecha_entrada 'Fecha Entrada', fecha_salida 'Fecha Salida', fecha_reservacion 'Fecha reservacion', ht.nombre 'Hotel', no_dias 'Dias' 
from reservacion res,habitacion hb ,habitacion_has_reservacion hs,hotel ht,cliente cl 
where ht.id_hotel=hb.id_hotel and hb.no_habitacion=hs.no_habitacion and hs.id_reservacion=res.id_reservacion and cl.id_cliente=res.id_cliente  and res.cancelada=0 
order by res.id_reservacion")


        consultaReservacionesDGV = xCnx.objetoDataAdapter(strSql)


    End Function


    'METODO PARA POBLAR DGV de reservaciones 
    Public Sub poblarDGVReservaciones(ByVal dgv_reservaciones As DataGridView)

        dgv_reservaciones.DataSource = consultaReservacionesDGV()

        dgv_reservaciones.Refresh()

        dgv_reservaciones.Columns.Item(1).Width = 200


    End Sub


    'METODO PARA REALIZAR UNA CANCELACION- SE REALIZARA MEDIANTE TRANSACCION

    Public Function cancelacion(ByVal can As Cancelacion) As Boolean
        Dim command As MySqlCommand = cnx.CreateCommand()
        Dim Transac As MySqlTransaction

        'CREAMOS LA TRANSACCION
        Transac = cnx.BeginTransaction()
        command.Connection = cnx
        command.Transaction = Transac
        Try
            If id_reservaciones = 0 Then
                Throw New ArgumentException("ID de reservacion invalido")
            End If
            'Realizara la actualizacion de habitaciones como disponibles
            Try
                command.CommandText = String.Format("update habitacion set disponibilidad=1 where No_habitacion=(select no_habitacion from habitacion_has_reservacion hs where id_reservacion={0})",
                                                      id_reservaciones)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al marcar habitacion disponible")
            End Try

            Try
                command.CommandText = String.Format("update reservacion set cancelada=1 where id_reservacion={0}",
                                                      id_reservaciones)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error al marcar reservacion cancelada ")
            End Try

            If can.getSetIdreservacion = 0 Or can.getSetRembolso = 0 Or can.getSetFecha = "" Then
                Throw New ArgumentException("La cancelacion tiene campos invalidos")
            End If

            Try
                command.CommandText = String.Format("insert into cancelacion (id_reservacion,rembolso,fecha_cancelacion) values ({0},{1},'{2}')",
                                                      can.getSetIdreservacion, can.getSetRembolso, can.getSetFecha)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("No se puedo realizar la cancelacion")
            End Try


            'SI TODAS LAS TRANSACCIONES SE REALIZARON SE REALIZA EL COMMIT
            Transac.Commit()
            cancelacion = True
        Catch ex As Exception
            Console.WriteLine("Error cancelacion:\n Mensaje de error ----> " & ex.Message)
            cancelacion = False

            Try
                Transac.Rollback()
            Catch ex2 As Exception
                MsgBox("Hubo un erro al realizar la cancelacion de la reservacion, la cancelacion esta incompleta, comunicace con su DBA!" & ex2.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End Try

    End Function




End Class

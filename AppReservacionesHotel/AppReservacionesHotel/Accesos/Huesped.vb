Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class Huesped
    Inherits Persona
    'Atributos
    Private id_reservacion As Integer
    Private id_huesped As Integer

    'Constructor Defualt
    Public Sub New()
        Me.id_huesped = 0
        Me.id_reservacion = 0
    End Sub

    'Constructor
    Public Sub New(id_huesped As Integer, id_reservacion As Integer, ByVal nombre As String, ByVal apellido_paterno As String, ByVal apellido_materno As String, ByVal edad As Integer)
        MyBase.New(nombre, apellido_paterno, apellido_materno, edad)
        Me.id_huesped = id_huesped
        Me.id_reservacion = id_reservacion
    End Sub

    'Getters y Setters

    Public Property getSetIdHuesped() As Integer
        Get
            Return id_huesped
        End Get
        Set(value As Integer)
            Me.id_huesped = value
        End Set
    End Property

    Public Property getSetIdReservacion As Integer
        Get
            Return id_reservacion
        End Get
        Set(value As Integer)
            Me.id_reservacion = value
        End Set
    End Property


    'METODOS PARA REALIZAR CONSULTAR Y QUERYS CON LOS HUESPEDS

    'METODO PARA INSERTAR
    Public Sub insertarHuesped()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If id_huesped <> 0 And id_reservacion <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoPaterno <> "" And getSetEdad <> 0 Then
            strSql = "INSERT INTO huesped values(" & id_huesped & "," & id_reservacion & ",'" & getSetNombre & "','" &
                                                getSetApellidoPaterno & "', '" & getSetApellidoMaterno & "' ," & getSetEdad & ")"

            xCnx.objetoCommand(strSql)


        Else
            MsgBox("Faltan datos para el huesped, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub
    'METODO PARA ACTUALIZAR
    Public Sub actualizarHuesped()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If id_huesped <> 0 And id_reservacion <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoPaterno <> "" And getSetEdad <> 0 Then
            strSql = "UPDATE huesped set id_huesped=" & id_huesped & ",id_reservacion=" & id_reservacion & ", nombre='" & getSetNombre & "', paterno='" & getSetApellidoPaterno &
                "', materno='" & getSetApellidoMaterno & "', edad=" & getSetEdad & " WHERE id_huesped=" & id_huesped

            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos para el huesped, verifique!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'METODO PARA ELIMINAR
    Public Sub elmininarHuesped()
        Dim strSql As String
        Dim xCnx As New Mysql

        If id_huesped <> 0 And id_reservacion <> 0 And getSetNombre <> "" And getSetApellidoPaterno <> "" And getSetApellidoPaterno <> "" And getSetEdad <> 0 Then

            strSql = "DELETE FROM huesped where id_huesped=" & id_huesped
            xCnx.objetoCommand(strSql)

        Else
            MsgBox("Faltan datos del huesped, verifique!!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'METODO PARA CONSULTAR
    Public Function consultaHuesped() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        strSql = "Select id_reservacion as 'ID-Reservacion', id_huesped as 'ID',  Nombre, paterno as 'Apellido paterno', materno as 'Apellido materno', edad" &
               " FROM huesped " &
               " WHERE id_huesped=" & id_huesped

        consultaHuesped = False
        'Si llega haber una excepcion la atrapara al realizar el query

        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("ID")) Then
                'Mantiene los campos limpios en caso de que el ID sea nu
                id_huesped = 0
                id_reservacion = 0
                getSetEdad = 0
                getSetNombre = ""
                getSetApellidoPaterno = ""
                getSetApellidoMaterno = ""

            Else
                ' Actualiza los txt box en caso de que el registro recibido concida con el ID y sea real
                Form_Huesped.txtbox_id.Text = xDT.Rows(0)("ID")
                Form_Huesped.txt_nombre.Text = xDT.Rows(0)("nombre")
                Form_Huesped.txtbox_apellidoPaterno.Text = xDT.Rows(0)("Apellido paterno")
                Form_Huesped.txtbox_apellidoMaterno.Text = xDT.Rows(0)("Apellido materno")
                Form_Huesped.txt_edad.Text = xDT.Rows(0)("Edad")
            End If
            consultaHuesped = True
        End If


    End Function


    'METODO PARA CONSULTAR TODOS LOS HUESPED
    Public Function consultaTodosHuesped() As Object
        Dim strSQL As String
        Dim xCnx As New Mysql

        strSQL = "SELECT huesped.id_reservacion as 'ID-Reservacion', id_huesped as ID ,no_habitacion as '#Habitacion',  Nombre, paterno as 'Apellido paterno', materno as 'Apellido materno', edad FROM huesped, habitacion_has_reservacion as habitacion " &
                  "WHERE habitacion.id_reservacion=huesped.id_reservacion"

        consultaTodosHuesped = xCnx.objetoDataAdapter(strSQL)
    End Function

    'METODO PARA CONSULTAR ID_RESERVACION   
    Public Function consultaIdReservacion() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        strSql = "SELECT * FROM habitacion_has_reservacion WHERE id_reservacion=" & id_reservacion

        consultaIdReservacion = False
        'Si llega haber una excepcion la atrapara al realizar el query

        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count >= 1 Then
            consultaIdReservacion = True
        End If


    End Function



    'METODO PARA VERIFICAR SI LOS HUESPEDES TIENEN TELEFONOS
    Public Function huesped_has_reservaciones() As Boolean
        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        strSQL = "SELECT * FROM telefono_huesped " &
                    " WHERE id_huesped=" & id_huesped
        huesped_has_reservaciones = False

        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count >= 1 Then
            huesped_has_reservaciones = True
        End If
    End Function



    'METODO PARA POBLAR EL DATAGRIDHUESPED
    Public Sub PoblarDataGridHuesped(ByVal GDVhuesped As DataGridView)
        'Método que lee todas los huesped del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV
        GDVhuesped.DataSource = consultaTodosHuesped()

        GDVhuesped.Refresh()

        GDVhuesped.Columns.Item(3).Width = 150
        GDVhuesped.Columns.Item(4).Width = 150
        GDVhuesped.Columns.Item(5).Width = 170

    End Sub

    'METODO PARA POBLAR COMBO DE HABITACION
    Public Sub poblarComboHabitacion(ByVal objeto As ComboBox)
        Dim lista As MySqlDataReader
        Dim strSQL As String
        Dim xCnx As New Mysql

        'De acuerdo al id_reservacion seleccionado en el combo de reservacion
        'se realizara la carga en el combo de habitacion
        strSQL = "SELECT No_habitacion FROM habitacion_has_reservacion " &
            "WHERE id_reservacion=" & Form_Huesped.cb_reservaciones.SelectedItem

        lista = xCnx.objetoDataReader(strSQL)
        'Limpiamos el combo de habitaciones
        objeto.Items.Clear()
        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
        lista.Close()

    End Sub

    'METODO PARA POBLAR COMBO DE HABITACION
    Public Sub poblarComboReservacion(ByVal objeto As ComboBox)
        Dim lista As MySqlDataReader
        Dim strSQL As String
        Dim xCnx As New Mysql


        'Se llenara el combo de reservaciones con el id_reservacion
        strSQL = "SELECT id_reservacion FROM habitacion_has_reservacion ORDER BY
                    id_reservacion asc"

        lista = xCnx.objetoDataReader(strSQL)
        'Limpiamos el combo de habitaciones
        objeto.Items.Clear()
        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
        lista.Close()

    End Sub



End Class

Imports MySql.Data.MySqlClient



Public Class ConexionMYSQL

    'Direccion del servidor MySQL , Objecto de conexion
    Private host = "localhost"
    Public mySqlConex As New MySqlConnection
    Dim query As MySqlCommand = New MySqlCommand
    Public userAuthenticated As Usuario


    'Subproceso para realizar la conexion
    Function conectar(user As String, pass As String, database As String) As Boolean
        mySqlConex = New MySqlConnection("Server=" + host + ";" + "database=reservaciones_hotel;" + "user=" + user + ";" + "password=" + pass + ";")
        Try
            mySqlConex.Open()


            'Realizamos un query sobre la base de datos Reservaciones_hotel para dectectar que usuario
            ' se ha intentado logear
            query.CommandText = "SELECT TIPO FROM LOGIN WHERE cuenta='" & user & "'"

            'Determinmos en que conexion se realiza el query
            query.Connection = mySqlConex

            'Se realiza la consulta por medio del adpatador
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(query)

            'Recuperamos los registros del query realizado
            Dim dt As DataTable = New DataTable
            da.Fill(dt)

            Dim tipo = CInt(dt.Rows(0)("tipo"))
            userAuthenticated = New Usuario(user, pass, tipo)
            Return True
        Catch ex As MySqlException
            MsgBox("Error en la conexion:" + ex.Message)
            Return False
        Finally
            mySqlConex.Close()
        End Try

    End Function
End Class

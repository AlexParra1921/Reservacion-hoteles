Imports MySql.Data.MySqlClient



Public Class Mysql

    'Direccion del servidor MySQL , Objecto de conexion
    Private host = "localhost"
    Dim query As MySqlCommand = New MySqlCommand



    'Subproceso para realizar la conexion
    Sub conectar(user As String, pass As String, database As String)
        cnx = New MySqlConnection("Server=" + host + ";" + "database=reservaciones_hotel;" + "user=" + user + ";" + "password=" + pass + ";")


        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                'Realizamos un query sobre la base de datos Reservaciones_hotel para dectectar que usuario
                ' se ha intentado logear
                query.CommandText = "SELECT TIPO FROM LOGIN WHERE cuenta='" & user & "'"

                'Determinmos en que conexion se realiza el query
                query.Connection = cnx

                'Se realiza la consulta por medio del adpatador
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(query)

                'Recuperamos los registros del query realizado
                Dim dt As DataTable = New DataTable
                da.Fill(dt)


                Dim tipo = CInt(dt.Rows(0)("tipo"))
                userAuthenticated = New Usuario(user, pass, tipo)
            Catch ex1 As InvalidOperationException
                Throw ex1
            Catch ex2 As MySqlException
                Throw ex2
            Catch ex3 As Exception
                'Excepcion en caso de que no surga algo imprevisto no manejado y lo muestre en la pantalla
                MsgBox(ex3.Message, MsgBoxStyle.Critical, "No se puedo conectar a la Base de Datos, contacte al D.B.A.")
            Finally
                cnx.Close()
            End Try

        End If



    End Sub
End Class

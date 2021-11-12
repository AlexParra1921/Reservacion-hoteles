Imports MySql.Data.MySqlClient



Public Class Mysql

    'Direccion del servidor MySQL , Objecto de conexion
    Private host = "localhost"
    Dim query As MySqlCommand = New MySqlCommand



    'Subproceso para realizar la conexion
    Sub New(user As String, pass As String, database As String)
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

    'METODOS PARA ACCESO A DATOS
    'Método para efectuar consultas a base de datos recibiendo el string del DML

    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable

        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            'en la variable sqlcmd traemos el QUERY y en la variable 
            'cnx la cadena de conexión a la BD, entonces con la línea de abajo le decimos al VB
            'que se conecte a la BD con el usuario y ejecute el query
            'A ESTE CODIGO NO HAY QUE MOVERLE NADA

            DA = New MySqlDataAdapter(sqlcmd, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT 'retorna el conjunto de dato
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
        DT.Dispose()
    End Function

    'Método que ejecuta un comando INSERT, UPDATE o DELETE a base de datos

    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New MySqlCommand(strcmd, cnx)

        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)

            sqlcmd.Dispose()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    'todos los select invocan este método y aqui se ejecutan

    Function objetoDataReader(ByVal strcmd As String) As MySqlDataReader
        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Dim sqlcmd As New MySqlCommand(strcmd, cnx)
        Dim resultadoSQL As MySqlDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    'cuando se hace un GROUP BY en el select

    Public Function objetoScalar(ByVal strcmd As String) As Object
        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Dim sqlcmd As New MySqlCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function




End Class

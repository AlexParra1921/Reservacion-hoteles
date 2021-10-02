Imports MySql.Data.MySqlClient



Public Class ConexionMYSQL
    'Creo una variable la cual contendra los parametros que se necesitan para realizar la conexion a la base de datas
    'MYSQL
    Private connStr As String = "Server=localhost;user=root;password=159753"
    'Pasamos los parametros al Constructor MysqlConnectio para realizar una conexion
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connStr)


    'Creo su constructor
    Public Sub pruebaConn()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("Error en la conexion")
        End Try
    End Sub
End Class

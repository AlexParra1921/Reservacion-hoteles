Imports MySql.Data.MySqlClient



Public Class ConexionMYSQL

    'Direccion del servidor MySQL , Objecto de conexion
    Private host = "localhost"
    Public MysqlConexion As New MySqlConnection



    'Subproceso para realizar la conexion
    Public Sub conectar(user As String, pass As String)
        MysqlConexion = New MySqlConnection("Server=" + host + ";" + "user=" + user + ";" + "password=" + pass + ";")
        Try
            MysqlConexion.Open()
            MsgBox("Conexion exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("Error en la conexion")
        End Try
    End Sub
End Class

Imports MySql.Data.MySqlClient

Module Globales
    Enum tipoUser As Short
        Administrador = 1
        Empleado = 2
        Cliente = 3
        Huespede = 4
    End Enum
    'Globales para conexion
    Public database_name = "reservaciones_hotel"
    Public cnx As New MySqlConnection
    Public userAuthenticated As Usuario


End Module

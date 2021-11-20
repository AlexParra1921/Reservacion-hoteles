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

    'Globales para uso de formulario de busqueda de habitacion
    Public mihotel As String
    Public micategoria As String
    Public mihabitacion As Integer







End Module

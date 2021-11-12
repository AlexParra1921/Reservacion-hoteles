Imports Microsoft.VisualBasic

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

End Class

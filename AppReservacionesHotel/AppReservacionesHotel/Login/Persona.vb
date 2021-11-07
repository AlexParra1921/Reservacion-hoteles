Public Class Persona
    'Atributos de persona     
    Private nombre As String
    Private apellido_paterno As String
    Private apellido_materno As String
    Private edad As Short
    
    'Constructor Default
    Public Sub New()
       nombre = ""
       apellido_paterno = ""
       apellido_materno = ""
       edad = 0 
    End Sub

    'Constructor con parametros
    Public Sub New(ByVal nombre As String, ByVal apellido_paterno As String, ByVal apellido_materno As String, ByVal edad )
       Me.nombre = nombre
       Me.apellido_paterno = apellido_paterno
       Me.apellido_materno = apellido_materno
       Me.edad = edad
    End Sub
    
    'Getters y Setters 
    Public Property getSetNombre() As String
        Get
         Return nombre          
        End Get
        Set (ByVal value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property getSetApellidoPaterno() As String
        Get
            Return apellido_paterno
        End Get
        Set (ByVal value As String)
            Me.apellido_paterno = value
        End Set
    End Property
    

    Public Property getSetApellidoMaterno() As String
        Get
            Return apellido_materno
        End Get
        Set (ByVal value As String)
            Me.apellido_materno = value
        End Set
    End Property
        
    Public Property getSetEdad() As Short
        Get
            Return edad
        End Get
        Set (value As Short )
           Me.edad = value     
        End
    End Property

End Class

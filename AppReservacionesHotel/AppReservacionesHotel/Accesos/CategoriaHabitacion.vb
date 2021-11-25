Public Class CategoriaHabitacion
    Private Id_Categoria As Integer
    Private Precio As Decimal
    Private NumCamasI As Integer
    Private NumCamasM As Integer

    Public Sub New()
        Me.Id_Categoria = 0
        Me.Precio = 0
        Me.NumCamasI = 0
        Me.NumCamasM = 0
    End Sub

    Public Sub New(Id_Categoria As Integer, Precio As Decimal, NumCamasI As Integer, NumCamasM As Integer)
        Me.Id_Categoria = Id_Categoria
        Me.Precio = Precio
        Me.NumCamasI = NumCamasI
        Me.NumCamasM = NumCamasM
    End Sub

    Public Property getSetCategoria() As Integer
        Get
            Return Id_Categoria
        End Get
        Set(value As Integer)
            Id_Categoria = value
        End Set
    End Property

    Public Property getSetPrecio() As Integer
        Get
            Return Precio
        End Get
        Set(value As Integer)
            Precio = value
        End Set
    End Property

    Public Property getSetCamasI() As Integer
        Get
            Return NumCamasI
        End Get
        Set(value As Integer)
            NumCamasI = value
        End Set
    End Property

    Public Property getSetCamasM() As Integer
        Get
            Return NumCamasM
        End Get
        Set(value As Integer)
            NumCamasM = value
        End Set
    End Property

    'Metodo para insertar las categorías
    Public Sub insertarCategoria()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If Id_Categoria <> 0 And getSetPrecio <> 0 And getSetCamasI <> 0 And getSetCamasM <> 0 Then
            strSql = "INSERT INTO Categoria values(" & Id_Categoria & "," & getSetPrecio & "," & getSetCamasM & "," & getSetCamasI & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("¡Faltan datos para crear la categoría!", MsgBoxStyle.Critical, "¡¡ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar Categoria
    Public Sub actualizarCategoria()
        Dim strSql As New String("")
        Dim xCnx As New Mysql

        If Id_Categoria <> 0 And getSetPrecio <> 0 And getSetCamasM <> 0 And getSetCamasI <> 0 Then
            strSql = "UPDATE Categoria set ID_Categoria=" & Id_Categoria & ", Precio=" & getSetPrecio & ", No_Camas_M=" & getSetCamasM &
                ", No_Camas_I=" & getSetCamasI & " WHERE ID_Categoria=" & Id_Categoria

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("¡Faltan datos para actualizar la categoria!", MsgBoxStyle.Critical, "¡¡ATENCION!!")
        End If
    End Sub

    'Consultar la categoria
    Public Function consultaCategoria() As Boolean
        Dim strSQL As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable

        strSQL = "Select ID_Categoria as ID, Precio, No_Camas_M as 'Camas Matrim', No_Camas_I as 'Camas Indiv' FROM Categoria" &
                    " WHERE ID_Categoria=" & getSetCategoria

        consultaCategoria = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("ID")) Then
                Id_Categoria = 0
                getSetPrecio = 0
                getSetCamasM = 0
                getSetCamasI = 0
            Else
                formCategoriaHabitacion.TextBoxCat.Text = xDT.Rows(0)("ID")
                formCategoriaHabitacion.TextBoxPrecio.Text = xDT.Rows(0)("Precio")
                formCategoriaHabitacion.TextBoxCM.Text = xDT.Rows(0)("Camas Matrim")
                formCategoriaHabitacion.TextBoxCI.Text = xDT.Rows(0)("Camas Indiv")

                Id_Categoria = xDT.Rows(0)("ID")
                getSetPrecio = xDT.Rows(0)("Precio")
                getSetCamasM = xDT.Rows(0)("Camas Matrim")
                getSetCamasI = xDT.Rows(0)("Camas Indiv")
            End If
            consultaCategoria = True
        End If
    End Function

    Public Function consultaTodasCategorias() As Object
        Dim strSQL As String
        Dim xCnx As New Mysql
        strSQL = "SELECT ID_Categoria as ID, Precio, No_Camas_M as 'Camas Matrim.', No_Camas_I as 'Camas Indiv' FROM Categoria ORDER BY ID_Categoria asc"

        consultaTodasCategorias = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCategoria(ByVal GDVcategoria As DataGridView)
        GDVcategoria.DataSource = consultaTodasCategorias()

        GDVcategoria.Refresh()

        GDVcategoria.Columns.Item(0).Width = 100
        GDVcategoria.Columns.Item(1).Width = 100
        GDVcategoria.Columns.Item(2).Width = 100
        GDVcategoria.Columns.Item(3).Width = 100
    End Sub

    Public Sub eliminarCategoria()
        Dim strSql As String
        Dim xCnx As New Mysql

        If Id_Categoria <> 0 And getSetPrecio <> 0 And getSetCamasM <> 0 And getSetCamasI <> 0 Then
            strSql = "DELETE FROM cliente where ID_Categoria=" & Id_Categoria
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("¡Faltan datos para eliminar la categoria!", MsgBoxStyle.Critical, "¡¡ATENCION!!")
        End If
    End Sub

    Public Function validarCategorias() As Boolean
        Dim strSql As String
        Dim xCnx As New Mysql
        Dim xDT As DataTable
        strSql = "SELECT * FROM Habitacion where ID_Categoria=" & Id_Categoria

        validarCategorias = False
        xCnx.objetoCommand(strSql)
        xDT = xCnx.objetoDataAdapter(strSql)


        If xDT.Rows.Count >= 1 Then
            validarCategorias = True
        End If


    End Function

End Class
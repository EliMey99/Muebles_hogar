Public Class categorias
    Private id_categorias As Integer
    Private nombre_categoria As String

    Public Property Id_categorias1 As Integer
        Get
            Return id_categorias
        End Get
        Set(value As Integer)
            id_categorias = value
        End Set
    End Property

    Public Property Nombre_categoria1 As String
        Get
            Return nombre_categoria
        End Get
        Set(value As String)
            nombre_categoria = value
        End Set
    End Property
End Class

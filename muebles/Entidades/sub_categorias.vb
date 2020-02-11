Public Class sub_categorias

    Private id_sub_categoria_in As Integer
    Private id_categoria_in As Integer
    Private stock_maximo As Integer
    Private stock_minimo As Integer
    Private stock_critico As Integer

    Public Property Id_sub_categoria_in1 As Integer
        Get
            Return id_sub_categoria_in
        End Get
        Set(value As Integer)
            id_sub_categoria_in = value
        End Set
    End Property

    Public Property Id_categoria_in1 As Integer
        Get
            Return id_categoria_in
        End Get
        Set(value As Integer)
            id_categoria_in = value
        End Set
    End Property

    Public Property Stock_maximo1 As Integer
        Get
            Return stock_maximo
        End Get
        Set(value As Integer)
            stock_maximo = value
        End Set
    End Property

    Public Property Stock_minimo1 As Integer
        Get
            Return stock_minimo
        End Get
        Set(value As Integer)
            stock_minimo = value
        End Set
    End Property

    Public Property Stock_critico1 As Integer
        Get
            Return stock_critico
        End Get
        Set(value As Integer)
            stock_critico = value
        End Set
    End Property
End Class

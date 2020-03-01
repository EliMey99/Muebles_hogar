Public Class clase_insumos

    Private id_insumos As Integer
    Private id_sub_categoria As Integer
    Private id_tipo_in As Integer
    Private id_dimension_in As Integer
    Private id_marca_insumo As Integer
    Private nombre_insumo As String
    Private descripcion_insumo As String
    Private color_insumo As String

    Public Property Id_insumos1 As Integer
        Get
            Return id_insumos
        End Get
        Set(value As Integer)
            id_insumos = value
        End Set
    End Property

    Public Property Id_sub_categoria1 As Integer
        Get
            Return id_sub_categoria
        End Get
        Set(value As Integer)
            id_sub_categoria = value
        End Set
    End Property

    Public Property Id_tipo_in1 As Integer
        Get
            Return id_tipo_in
        End Get
        Set(value As Integer)
            id_tipo_in = value
        End Set
    End Property

    Public Property Id_dimension_in1 As Integer
        Get
            Return id_dimension_in
        End Get
        Set(value As Integer)
            id_dimension_in = value
        End Set
    End Property

    Public Property Id_marca_insumo1 As Integer
        Get
            Return id_marca_insumo
        End Get
        Set(value As Integer)
            id_marca_insumo = value
        End Set
    End Property

    Public Property Nombre_insumo1 As String
        Get
            Return nombre_insumo
        End Get
        Set(value As String)
            nombre_insumo = value
        End Set
    End Property

    Public Property Descripcion_insumo1 As String
        Get
            Return descripcion_insumo
        End Get
        Set(value As String)
            descripcion_insumo = value
        End Set
    End Property

    Public Property Color_insumo1 As String
        Get
            Return color_insumo
        End Get
        Set(value As String)
            color_insumo = value
        End Set
    End Property
End Class

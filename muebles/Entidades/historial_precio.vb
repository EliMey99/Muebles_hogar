Public Class historial_precio

    Private id_insumos As Integer
    Private id_proveedor As Integer
    Private precio_unidad As Integer
    Private fecha_inicio As Date
    Private fecha_termino As Date

    Public Property Id_insumos1 As Integer
        Get
            Return id_insumos
        End Get
        Set(value As Integer)
            id_insumos = value
        End Set
    End Property

    Public Property Id_proveedor1 As Integer
        Get
            Return id_proveedor
        End Get
        Set(value As Integer)
            id_proveedor = value
        End Set
    End Property

    Public Property Precio_unidad1 As Integer
        Get
            Return precio_unidad
        End Get
        Set(value As Integer)
            precio_unidad = value
        End Set
    End Property

    Public Property Fecha_inicio1 As Date
        Get
            Return fecha_inicio
        End Get
        Set(value As Date)
            fecha_inicio = value
        End Set
    End Property

    Public Property Fecha_termino1 As Date
        Get
            Return fecha_termino
        End Get
        Set(value As Date)
            fecha_termino = value
        End Set
    End Property
End Class

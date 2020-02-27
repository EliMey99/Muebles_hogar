Public Class bodega_insumos

    Private id_bodega As Integer
    Private id_insumos As Integer
    Private cantidad_insumos As Integer
    Private monto_insumos As Integer

    Public Property Id_bodega1 As Integer
        Get
            Return id_bodega
        End Get
        Set(value As Integer)
            id_bodega = value
        End Set
    End Property

    Public Property Id_insumos1 As Integer
        Get
            Return id_insumos
        End Get
        Set(value As Integer)
            id_insumos = value
        End Set
    End Property

    Public Property Cantidad_insumos1 As Integer
        Get
            Return cantidad_insumos
        End Get
        Set(value As Integer)
            cantidad_insumos = value
        End Set
    End Property

    Public Property Monto_insumos1 As Integer
        Get
            Return monto_insumos
        End Get
        Set(value As Integer)
            monto_insumos = value
        End Set
    End Property
End Class

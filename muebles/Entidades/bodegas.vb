Public Class bodegas

    Private id_bodega As Integer
    Private nombre_bodega As String
    Private direccion As String
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

    Public Property Nombre_bodega1 As String
        Get
            Return nombre_bodega
        End Get
        Set(value As String)
            nombre_bodega = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
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

Public Class comprobantes

    Private id_doc As Integer
    Private id_proveedor As Integer
    Private fecha_recepcion As Date
    Private total_doc As Integer
    Private fecha_hasta As Date
    Private id_docs2 As Integer

    Public Property Id_doc1 As Integer
        Get
            Return id_doc
        End Get
        Set(value As Integer)
            id_doc = value
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

    Public Property Fecha_recepcion1 As Date
        Get
            Return fecha_recepcion
        End Get
        Set(value As Date)
            fecha_recepcion = value
        End Set
    End Property

    Public Property Total_doc1 As Integer
        Get
            Return total_doc
        End Get
        Set(value As Integer)
            total_doc = value
        End Set
    End Property

    Public Property Fecha_hasta1 As Date
        Get
            Return fecha_hasta
        End Get
        Set(value As Date)
            fecha_hasta = value
        End Set
    End Property

    Public Property Id_docs21 As Integer
        Get
            Return id_docs2
        End Get
        Set(value As Integer)
            id_docs2 = value
        End Set
    End Property
End Class

Public Class proveedor

    Private id_proveedor As Integer
    Private nombre As String
    Private apellido As String
    Private direccion As String
    Private telefono As String
    Private correo As String
    Private rut As String


    Public Property Id_proveedor1 As Integer
        Get
            Return id_proveedor
        End Get
        Set(value As Integer)
            id_proveedor = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
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

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property Rut1 As String
        Get
            Return rut
        End Get
        Set(value As String)
            rut = value
        End Set
    End Property
End Class

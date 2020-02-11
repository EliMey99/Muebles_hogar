Imports Npgsql
Module Conexion_PosgtreSQLvb

    Dim estado As Boolean = True
    Dim conex As New Npgsql.NpgsqlConnection

    Public Function Conectar() As Boolean

        Try
            conex.ConnectionString = "Server=192.168.1.128;Port=5432;Database=Muebles_hogar;UserId=postgres;Password=postgres;"
            conex.Open()

            If conex.State = ConnectionState.Open Then
                MessageBox.Show("Conectado")
            Else
                MessageBox.Show("Error de conexion")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        End Try

        Return estado
    End Function
    Public Sub cerrar()
        conex.Close()
    End Sub


End Module

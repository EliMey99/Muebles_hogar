Imports Npgsql
Module Conexion_PosgtreSQLvb


    Dim estado As Boolean = True

    Public conex As New NpgsqlConnection

    Public Function Conectar() As Boolean

        Try
            'Conexión a PostgreSQL 
            'conex.ConnectionString = "server=localhost;userid=postgres;password=pollitopio02;database=muebles;"
            conex.ConnectionString = "server=localhost;userid=postgres;password=postgres;database=Muebles_hogar;"
            conex.Open()

            If conex.State = ConnectionState.Open Then

            Else
                MessageBox.Show("Error de conexión")
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

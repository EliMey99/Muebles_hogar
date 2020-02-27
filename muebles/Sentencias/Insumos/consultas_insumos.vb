Imports Npgsql

Module consultas_insumos

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public datos As New DataSet
    Public datos1 As New DataSet

    Public _dtvdatos As New DataView
    Public _dtvdatos1 As New DataView


    Public Sub consulta_datos()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("SELECT * FROM categorias_insumos", conex)
            adaptador.Fill(datos)
            _dtvdatos.Table = datos.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub


    Public Sub consulta_datos_sub()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from sub_categorias_insu", conex)
            adaptador.Fill(datos1)
            _dtvdatos1.Table = datos1.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub


End Module

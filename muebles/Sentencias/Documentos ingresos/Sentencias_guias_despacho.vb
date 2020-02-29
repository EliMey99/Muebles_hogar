
Imports Npgsql

Public Class sentencias_guias_despacho

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'AÑADIR GUÍA DESPACHO
    Public Function Crear_factura(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO guia_despacho (id_guia_despacho,id_proveedor_guia,recepcion_guia,
                                                         total_guia,id_factura_guia)  VALUES (@id_guia,@prove,@recep,@total,@id_fac)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_guia", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.InsertCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.InsertCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.InsertCommand.Parameters.Add("@id_fac", NpgsqlTypes.NpgsqlDbType.Integer).Value = 0
            adaptador.InsertCommand.Connection = conex
            adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

End Class

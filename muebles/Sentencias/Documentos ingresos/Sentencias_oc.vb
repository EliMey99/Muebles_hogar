
Imports Npgsql

Public Class Sentencias_oc

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'Crear ORDEN DE COMPRA
    Public Function Crear_orden(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO orden_compra (id_orden_compra,id_proveedor_oc,emision_orden,total_orden) 
                                                    VALUES (@id_oc,@prove,@emision,@total)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_oc", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.InsertCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@emision", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.InsertCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
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

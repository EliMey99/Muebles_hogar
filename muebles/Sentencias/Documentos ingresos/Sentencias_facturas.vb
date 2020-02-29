
Imports muebles
Imports Npgsql

Public Class Sentencias_facturas

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'AÑADIR FACTURA
    Public Function Crear_factura(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO factura (id_factura,id_proveedor_fact,recepcion_factura,total_factura) 
                                                    VALUES (@id_factura,@prove,@recep,@total)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_factura", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.InsertCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
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

    '-------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------- U P D A T E ---------------------------------------------------------

    'Actualizar FACTURA
    Public Function Actualizar_factura(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Dim estado_guia As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE factura SET id_factura=@factura_after,id_proveedor_fact=@prov,recepcion_factura=@recep,total_factura=@total)
                                                        WHERE id_factura=@factura_before", conex)

            adaptador.UpdateCommand.Parameters.Add("@factura_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.UpdateCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.UpdateCommand.Parameters.Add("@factura_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

            'Actualiza la id de las guias asociadas (si existen)
            Actualizar_campo_guia(datos)
            'Actualiza la id del "detalle factura"
            Actualizar_detalle_factura(datos)

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado

    End Function

    Private Sub Actualizar_detalle_factura(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE detalle_factura SET id_det_factura=@id_after)
                                                        WHERE id_det_factura=@id_before", conex)
            adaptador.UpdateCommand.Parameters.Add("@id_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@id_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub

    Private Sub Actualizar_campo_guia(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE guia_despacho SET id_guia_factura=@id_after)
                                                        WHERE id_guia_factura=@id_before", conex)

            adaptador.UpdateCommand.Parameters.Add("@id_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@id_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try

    End Sub

End Class

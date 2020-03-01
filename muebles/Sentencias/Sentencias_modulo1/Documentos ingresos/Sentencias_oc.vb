
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


    '-------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------- U P D A T E ---------------------------------------------------------

    'Actualizar ORDEN DE COMPRA
    Public Function Actualizar_orden_compra(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Dim estado_guia As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE orden_compra SET id_orden_compra=@orden_after,id_proveedor_oc=@prov,emision_orden=@recep,total_orden=@total)
                                                        WHERE id_orden_compra=@orden_before", conex)

            adaptador.UpdateCommand.Parameters.Add("@orden_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.UpdateCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.UpdateCommand.Parameters.Add("@orden_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

            If datos.Id_doc1 <> datos.Id_docs21 Then
                'Actualiza la id del "detalle orden"
                Actualizar_detalle_orden(datos)
            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado

    End Function


    'ACTUALIZA LA ID DE DETALLE ORDEN_COMPRA
    Private Sub Actualizar_detalle_orden(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE detalle_orden SET id_det_orden=@id_after)
                                                        WHERE id_det_orden=@id_before", conex)
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


    '----------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------ D E L E T E ---------------------------------------------------------------

    'Eliminar ORDEN COMPRA
    Public Function Eliminar_detalle_orden(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        'Detalle primero
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM detalle_orden WHERE id_det_orden = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

            'Luego el "encabezado"
            Eliminar_orden(datos)

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    Private Sub Eliminar_orden(datos As comprobantes)
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM orden_compra WHERE  id_orden_compra = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
    End Sub

End Class

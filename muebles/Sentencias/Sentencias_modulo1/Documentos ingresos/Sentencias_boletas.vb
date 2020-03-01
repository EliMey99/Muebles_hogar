
Imports muebles
Imports Npgsql

Public Class Sentencias_boletas

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'INGRESO BOLETA
    Public Function Crear_boleta(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO boleta (id_boleta,id_proveedor_bol,recepcion_boleta,total_boleta) 
                                                    VALUES (@id_boleta,@prove,@recep,@total)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_boleta", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
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

    'INGRESO DETALLE BOLETA
    'PENDIENTESSSS TODOS LOS INGRESOS DE DETALLES 

    '-------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------- U P D A T E ---------------------------------------------------------

    'Actualizar BOLETA
    Public Function Actualizar_boleta(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE boleta SET id_boleta=@boleta_after,id_proveedor_bol=@prov,recepcion_boleta=@recep,total_boleta=@total)
                                                        WHERE id_boleta=@boleta_before", conex)

            adaptador.UpdateCommand.Parameters.Add("@boleta_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.UpdateCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.UpdateCommand.Parameters.Add("@boleta_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

            If datos.Id_docs21 <> datos.Id_doc1 Then
                'Actualiza la id del detalle de la boleta
                Actualiza_detalle_boleta(datos)
            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado
    End Function

    'ACTUALIZA  ID DETALLE BOLETA
    Private Sub Actualiza_detalle_boleta(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE detalle_boleta SET id_det_boleta=@id_after)
                                                        WHERE id_det_boleta=@id_before", conex)
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

    'Eliminar BOLETA
    Public Function Eliminar_detalle_bol(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        'Detalle primero
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM detalle_boleta WHERE id_det_boleta = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

            'Luego el "encabezado"
            Eliminar_boleta(datos)

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    Private Sub Eliminar_boleta(datos As comprobantes)
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM boleta WHERE id_boleta = @id", conex)
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

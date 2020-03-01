
Imports Npgsql

Public Class Sentencias_cotizacion

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------


    'Ingreso Cotización
    Public Function Crear_cotizacion(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO cotizacion (id_cotizacion,id_proveedor_cot,recepcion_cotiza,valida_hasta,total_cotiza) 
                                                         VALUES (@id_cotiza,@prove,@recep,@hasta,@total)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_cotiza", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.InsertCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.InsertCommand.Parameters.Add("@hasta", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_hasta1
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

    'Actualizar Cotizacion
    Public Function Actualizar_cotizacion(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE cotizacion SET id_cotizacion=@cotiza_after,id_proveedor_cot=@prov,recepcion_cotiza=@recep
                                                        valida_hasta=@hasta,total_cotiza=@total WHERE id_cotizacion=@cotiza_before", conex)


            adaptador.UpdateCommand.Parameters.Add("@cotiza_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.UpdateCommand.Parameters.Add("@hasta", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_hasta1
            adaptador.UpdateCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.UpdateCommand.Parameters.Add("@cotiza_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

            If datos.Id_doc1 <> datos.Id_docs21 Then
                Actualiza_detalle_cotiza(datos)
            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado
    End Function


    'ACTUALIZA ID DETALLE COTIZACIÓN
    Private Sub Actualiza_detalle_cotiza(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE detalle_cotizacion SET id_det_cotiza=@id_after)
                                                        WHERE id_det_cotiza=@id_before", conex)
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

    'Eliminar COTIZACION
    Public Function Eliminar_detalle_cot(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        'Detalle primero
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM detalle_cotizacion WHERE id_det_cotiza = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

            'Luego el "encabezado"
            Eliminar_cotizacion(datos)

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    Private Sub Eliminar_cotizacion(datos As comprobantes)
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM cotizacion WHERE id_cotizacion = @id", conex)
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

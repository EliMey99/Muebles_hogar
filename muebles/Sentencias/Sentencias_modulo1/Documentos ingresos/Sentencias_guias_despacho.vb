
Imports muebles
Imports Npgsql

Public Class sentencias_guias_despacho

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'AÑADIR GUÍA DESPACHO
    Public Function Crear_guia_despacho(ByVal datos As comprobantes) As Boolean
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


    '-------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------- U P D A T E ---------------------------------------------------------

    'Actualizar GUIA DE DESPACHO
    Public Function Actualizar_guia_despacho(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE guia_despacho SET id_guia_despacho=@guia_after,id_proveedor_guia=@prov,recepcion_guia=@recep
                                                        total_guia=@total WHERE id_guia_despacho=@guia_before", conex)

            adaptador.UpdateCommand.Parameters.Add("@guia_after", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.UpdateCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@recep", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_recepcion1
            adaptador.UpdateCommand.Parameters.Add("@total", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Total_doc1
            adaptador.UpdateCommand.Parameters.Add("@guia_before", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_docs21
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

            If (datos.Id_doc1 <> datos.Id_docs21) Then
                'Actuliza la id del detalle guia
                Actualiza_detalle_guia(datos)
            End If


        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado
    End Function

    'ACTUALIZA LA ID DE DETALLE GUIA
    Private Sub Actualiza_detalle_guia(datos As comprobantes)

        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE detalle_guia SET id_det_guia=@id_after)
                                                        WHERE id_det_guia=@id_before", conex)
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

    'Eliminar GUIA DESPACHO
    Public Function Eliminar_detalle_guia(ByVal datos As comprobantes) As Boolean
        Dim estado As Boolean = True
        'Detalle primero
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM detalle_guia WHERE id_det_guia = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_doc1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

            'Luego el "encabezado"
            Eliminar_guia_despacho(datos)

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    Private Sub Eliminar_guia_despacho(datos As comprobantes)
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM guia_despacho WHERE id_guia_despacho = @id", conex)
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


Imports Npgsql

Public Class Sentencias_dimensiones_vb

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    'CREAR
    Public Function Creacion_dimension(ByVal datos As dimensiones_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO dimensiones_insu (diametro,espesor,largo,ancho, alto) 
                                                       VALUES (@dia,@espe,@largo,@ancho,@alto)", conex)

            adaptador.InsertCommand.Parameters.Add("@dia", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Diametro1
            adaptador.InsertCommand.Parameters.Add("@espe", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Espesor1
            adaptador.InsertCommand.Parameters.Add("@largo", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Largo1
            adaptador.InsertCommand.Parameters.Add("@ancho", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Ancho1
            adaptador.InsertCommand.Parameters.Add("@alto", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Alto1
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

    'ACTUALIZAR
    Public Function Actualizar_dimension(ByVal datos As dimensiones_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE dimensiones_insu SET diametro=@dia,espesor=@espe,largo=@largo,ancho=@ancho,alto=@alto WHERE id_dimension=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_dimension1
            adaptador.UpdateCommand.Parameters.Add("@dia", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Diametro1
            adaptador.UpdateCommand.Parameters.Add("@espe", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Espesor1
            adaptador.UpdateCommand.Parameters.Add("@largo", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Largo1
            adaptador.UpdateCommand.Parameters.Add("@ancho", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Ancho1
            adaptador.UpdateCommand.Parameters.Add("@alto", NpgsqlTypes.NpgsqlDbType.Double, 10, 3).Value = datos.Alto1
            conex.Open()
            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado
    End Function

    'ELIMINAR
    Public Function Eliminar_dimension(ByVal datos As dimensiones_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM dimensiones_insu WHERE id_dimension = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_dimension1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

End Class

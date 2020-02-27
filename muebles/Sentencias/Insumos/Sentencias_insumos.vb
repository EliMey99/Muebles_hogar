Imports Npgsql

Public Class Sentencias_insumos


    Private adaptador As New Npgsql.NpgsqlDataAdapter

    'Creación de INSUMOS
    Public Function Creacion_Insumos(ByVal datos As clase_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO insumos (id_insumo,id_sub_categoria,id_tipo_in,id_dimension_in,
                                                    id_marca_insumo,nombre_insumo,descripcion_insumo,color_insumo) 
                                                    VALUES (@id_insumo,@id_sub_cat,@id_tipo,@id_dimension,@marca,@nombre,@descripcion,@color)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_insumo", NpgsqlTypes.NpgsqlDbType.Integer, 6).Value = datos.Id_insumos1
            adaptador.InsertCommand.Parameters.Add("@id_sub_cat", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_sub_categoria1
            adaptador.InsertCommand.Parameters.Add("@id_tipo", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_tipo_in1
            adaptador.InsertCommand.Parameters.Add("@id_dimension", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_dimension_in1
            adaptador.InsertCommand.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_marca_insumo1
            adaptador.InsertCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_insumo1
            adaptador.InsertCommand.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Descripcion_insumo1
            adaptador.InsertCommand.Parameters.Add("@color", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Color_insumo1
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

    'Actualizar INSUMO
    Public Function Actualizar_Insumos(ByVal datos As clase_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE insumos SET id_tipo_in=@tipo,id_dimension_in=@dimension,id_marca_insumo=@marca,nombre_insumo=@nombre
                                                           ,descripcion_insumo=@descripcion,color_insumo=@color WHERE id_insumo=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_insumos1
            adaptador.UpdateCommand.Parameters.Add("@tipo_in", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo_in1
            adaptador.UpdateCommand.Parameters.Add("@dimension", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_dimension_in1
            adaptador.UpdateCommand.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca_insumo1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_insumo1
            adaptador.UpdateCommand.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 55).Value = datos.Descripcion_insumo1
            adaptador.UpdateCommand.Parameters.Add("@color", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Color_insumo1
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

    'Eliminar INSUMOS
    Public Function Eliminar_insumo(ByVal datos As clase_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM insumos WHERE id_insumo = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_insumos1
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


Imports Npgsql

Public Class Sentencias_marcas
    Private adaptador As New Npgsql.NpgsqlDataAdapter

    'Creación de MARCAS
    Public Function Creacion_marcas(ByVal datos As marcas_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO marcas_insumos(nombre_marca) VALUES (@name)", conex)
            adaptador.InsertCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_marca1
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

    'Actualizar MARCAS
    Public Function Actualizar_marca(ByVal datos As marcas_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE marcas_insumos SET nombre_marca=@name WHERE id_marca_insumos=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca_insumo1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_marca1

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

    'Eliminar MARCAS
    Public Function Eliminar_marcas(ByVal datos As marcas_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM marcas_insumos WHERE id_marca_insumos= @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca_insumo1
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

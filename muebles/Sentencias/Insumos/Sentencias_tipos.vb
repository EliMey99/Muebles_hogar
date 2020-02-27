
Imports Npgsql

Public Class Sentencias_tipos

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    'Creación de TIPOS INSUMOS
    Public Function Creacion_tipos(ByVal datos As tipos_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO tipos_insumos(nombre_tipo) VALUES (@nombres)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_tipo1
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

    'Actualizar TIPOS
    Public Function Actualizar_tipos(ByVal datos As tipos_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE tipos_insumos SET nombre_tipo=@name WHERE id_tipos=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_tipo1

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

    'Eliminar TIPOS
    Public Function Eliminar_tipos(ByVal datos As tipos_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM tipos_insumos WHERE id_tipos= @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo1
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

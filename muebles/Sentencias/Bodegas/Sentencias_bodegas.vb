
Imports Npgsql

Public Class Sentencias_bodegas

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------- I N S E R T --------------------------------------------------

    'CREAR BODEGA
    Public Function Creacion_bodega(ByVal datos As bodegas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO bodegas (nombre,direccion) VALUES (@name,@dire)", conex)

            adaptador.InsertCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_bodega1
            adaptador.InsertCommand.Parameters.Add("@dire", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Direccion1
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

    'CREAR BODEGA - INSUMOS
    Public Function Creacion_bodega_insumos(ByVal datos As bodega_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO bodega_insumos (id_insumos_bod,id_bodegas_insu,cantidad_insumos,monto_insumos) 
                                                        VALUES (@insu,@bode,@cantidad,@montos);", conex)

            adaptador.UpdateCommand.Parameters.Add("@insu", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_insumos1
            adaptador.UpdateCommand.Parameters.Add("@bode", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_bodega1
            adaptador.UpdateCommand.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Cantidad_insumos1
            adaptador.UpdateCommand.Parameters.Add("@montos", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Monto_insumos1
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

    '-------------------------------------------------- U P D A T E -----------------------------------------------------------------

    'ACTUALIZAR BODEGA  
    Public Function Actualizar_bodega(ByVal datos As bodegas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE bodegas SET nombre=@name, direccion=@dire WHERE id_bodega=@id;", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_bodega1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_bodega1
            adaptador.UpdateCommand.Parameters.Add("@dire", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Direccion1
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

    'ACTUALIZAR BODEGA INSUMOS
    Public Function Actualizar_bodega_insu(ByVal datos As bodega_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE bodega_insumos SET cantidad_insumos=@canti, monto_insumos=@montos 
                                                        WHERE id_insumos_bod=@insu AND id_bodegas_insu=@bode;", conex)
            adaptador.UpdateCommand.Parameters.Add("@insu", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_insumos1
            adaptador.UpdateCommand.Parameters.Add("@bode", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_bodega1
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

    '----------------------------------------- D E L E T E ---------------------------------------------------------------------------------------

    'ELIMINAR BODEGA
    Public Function Eliminar_bodega(ByVal datos As bodegas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM bodegas WHERE id_bodega = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_bodega1
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


    'ELIMINAR BODEGA - INSUMOS
    Public Function Eliminar_bodega_insu(ByVal datos As bodega_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM bodega_insumos WHERE id_insumos_bod=@insu AND id_bodegas_insu=@bode;", conex)
            adaptador.DeleteCommand.Parameters.Add("@insu", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_insumos1
            adaptador.DeleteCommand.Parameters.Add("@bode", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_bodega1
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

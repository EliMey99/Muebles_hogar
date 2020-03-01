
Imports Npgsql

Public Class sentencias_proveedores

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- I N S E R T S -----------------------------------------------------------

    'Creación de PROVEEDORES
    Public Function Creacion_proveedor(ByVal datos As proveedor) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO proveedor (id_proveedor,nombre,apellido,direccion,
                                                    telefono,correo,rut) VALUES (@id,@name,@ape,@direc,@tel,@correo,@rut)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre1
            adaptador.InsertCommand.Parameters.Add("@ape", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Apellido1
            adaptador.InsertCommand.Parameters.Add("@direc", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Direccion1
            adaptador.InsertCommand.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Telefono1
            adaptador.InsertCommand.Parameters.Add("@correo", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Correo1
            adaptador.InsertCommand.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Rut1
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

    'Creación de PROVEEDOR - INSUMOS (rompimiento)
    Public Function Creacion_proveedor(ByVal datos As historial_precio) As Boolean
        Dim estado As Boolean = True

        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO proveedor_insumos (id_insumos,id_proveedor) 
                                            VALUES (@insumos,@proveedor)", conex)
            adaptador.InsertCommand.Parameters.Add("@insumos", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_insumos1
            adaptador.InsertCommand.Parameters.Add("@proveedor", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
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

    'Creación de Historial Precios
    Public Function Historial_precio(ByVal datos As historial_precio) As Boolean
        Dim estado As Boolean = True

        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO historial_precios_prov (id_proveedor,id_insumos, precio_unidad_insumo,
                                                   fecha_inicio,fecha_termino) VALUES (@prove,@insu,@precio,@inicio,@termino)", conex)
            adaptador.InsertCommand.Parameters.Add("@prove", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_proveedor1
            adaptador.InsertCommand.Parameters.Add("@insu", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_insumos1
            adaptador.InsertCommand.Parameters.Add("@precio", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Precio_unidad1
            adaptador.InsertCommand.Parameters.Add("@inicio", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Fecha_inicio1
            adaptador.InsertCommand.Parameters.Add("@termino", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Fecha_termino1
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


    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- U P D A T E S  ----------------------------------------------------------

    'Actualizar PROVEEDOR
    Public Function Actualizar_proveedores(ByVal prove As proveedor) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE proveedor SET nombre=@name,apellido=@ape,direccion=@dire,telefono=@tel
                                                           ,correo=@correo,rut=@rut WHERE id_proveedor=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = prove.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Nombre1
            adaptador.UpdateCommand.Parameters.Add("@ape", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Apellido1
            adaptador.UpdateCommand.Parameters.Add("@dire", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Direccion1
            adaptador.UpdateCommand.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Telefono1
            adaptador.UpdateCommand.Parameters.Add("@correo", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Correo1
            adaptador.UpdateCommand.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = prove.Rut1
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

    'Actualizar HISTORIAL DE PRECIOS
    Public Function Actualizar_historial(ByVal insux As historial_precio) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE historial_precio_prov SET precio_unidad_insumo=@precio WHERE id_insumos=@id  AND id_proveedor=@prov", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = insux.Id_insumos1
            adaptador.UpdateCommand.Parameters.Add("@prov", NpgsqlTypes.NpgsqlDbType.Integer).Value = insux.Id_proveedor1
            adaptador.UpdateCommand.Parameters.Add("@precio", NpgsqlTypes.NpgsqlDbType.Integer).Value = insux.Precio_unidad1
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


    '---------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- D E L E T E  ------------------------------------------------------------

    'ELIMINAR PROVEEDOR
    Public Function Eliminar_proveedor(ByVal datos As proveedor) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("DELETE FROM proveedor WHERE id_proveedor = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_proveedor1
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

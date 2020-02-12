Imports Npgsql

Public Class Sentencias_insumos


    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '--------------------------------------------------- I N S E  R T S ------------------------------------------------------------- 
    'Creación de INSUMOS
    Public Function Creacion_Insumos(ByVal datos As clase_insumos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO insumos (id_insumo,id_sub_categoria,id_tipo_in,id_dimension_in,
                                                    id_marca_insumo,nombre_insumo,descripcion_insumo,color_insumo) 
                                                    VALUES (@id_insumo,@id_sub_cat,@id_tipo,@id_dimension,@marca,@nombre,@descripcion,@color)", conex)
            adaptador.InsertCommand.Parameters.Add("@id_insumo", NpgsqlTypes.NpgsqlDbType.Integer, 3).Value = datos.Id_insumos1

            conex.Open()
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

    'Creación de CATEGORÍAS
    Public Function Creacion_Categoria(ByRef datos As categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO categorias_insumos (nombre_categoria)VALUES (@nombres)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1
        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    'Creación de SUB CATEGORÍAS
    Public Function Creacion_sub_categoria(ByRef datos As sub_categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO sub_categorias_insu (id_sub_categoria_in,id_categoria_in,stock_maximo,stock_minimo,stock_critico)
                                                            VALUES (@sub_categoria,@categoria,minimo,maximo,critico)", conex)
            adaptador.InsertCommand.Parameters.Add("@sub_categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sub_categoria_in1
            adaptador.InsertCommand.Parameters.Add("@categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria_in1
            adaptador.InsertCommand.Parameters.Add("@minimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_minimo1
            adaptador.InsertCommand.Parameters.Add("@maximo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_maximo1
            adaptador.InsertCommand.Parameters.Add("@critico", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_critico1
        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    '---------------------------------------------------------------------------------------------------------------------------------- 
    '-------------------------------------------------------- U P D A T E S ------------------------------------------------------------- 

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

    'Actualizar CATEGORÍAS
    Public Function Actualzar_Categorias(ByVal datos As categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE categorias_insumo SET nombre_categoria=@name WHERE id_categorias=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categorias1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1
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

    'Actualizar SUB CATEGORÍAS
    Public Function Actualizar_Categorias(ByVal datos As sub_categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE sub_categorias_insu SET stock_maximo=@maximo,stock_minimo=@minimo,stock_critico=@critico
                                                          WHERE id_sub_categoria_in=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sub_categoria_in1
            adaptador.UpdateCommand.Parameters.Add("@maximo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_maximo1
            adaptador.UpdateCommand.Parameters.Add("@minimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_minimo1
            adaptador.UpdateCommand.Parameters.Add("@critico", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_critico1
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

End Class


Imports Npgsql

Public Class Sentencias_categorias
    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '--------------------------------------------- I N S E R T ----------------------------------------------------------------

    'Creación de CATEGORÍAS
    Public Function Creacion_Categoria(ByVal datos As categoria) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into categorias_insumos(nombre_categoria) VALUES (@nombres)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1
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

    'Creación de SUB CATEGORÍAS
    Public Function Creacion_sub_categoria(ByRef datos As sub_categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO sub_categorias_insu (id_sub_categoria_in,id_categoria_in,stock_maximo,stock_minimo,stock_critico,nombre_sub_cate)
                                                            VALUES (@sub_categoria,@categoria,@minimo,@maximo,@critico,@nombre)", conex)
            adaptador.InsertCommand.Parameters.Add("@sub_categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sub_categoria_in1
            adaptador.InsertCommand.Parameters.Add("@categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria_in1
            adaptador.InsertCommand.Parameters.Add("@minimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_minimo1
            adaptador.InsertCommand.Parameters.Add("@maximo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_maximo1
            adaptador.InsertCommand.Parameters.Add("@critico", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_critico1
            adaptador.InsertCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_sub_cate1

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

    '---------------------------------------------- U P D A T E --------------------------------------------------------------------


    'Actualizar CATEGORÍAS
    Public Function Actualizar_Categorias(ByVal datos As categoria) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE categorias_insumos SET nombre_categoria=@name WHERE id_categorias=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria1
            adaptador.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1

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
    Public Function Actualizar_Subcategorias(ByVal datos As sub_categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE sub_categorias_insu SET stock_maximo=@maximo,stock_minimo=@minimo,stock_critico=@critico,nombre_sub_cate=@nombre
                                                          WHERE id_sub_categoria_in=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sub_categoria_in1
            adaptador.UpdateCommand.Parameters.Add("@maximo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_maximo1
            adaptador.UpdateCommand.Parameters.Add("@minimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_minimo1
            adaptador.UpdateCommand.Parameters.Add("@critico", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Stock_critico1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_sub_cate1
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

    '------------------------------------------------------ D E L E T E ------------------------------------------------------

    'Eliminar CATEGORÍA
    Public Function Eliminar_Categoria(ByVal datos As categoria) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From categorias_insumos Where id_categorias = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria1
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

    'Eliminar SUB-CATEGORÍA
    Public Function Eliminar_Subcategoria(ByVal datos As sub_categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From sub_categorias_insu Where id_sub_categoria_in= @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sub_categoria_in1
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

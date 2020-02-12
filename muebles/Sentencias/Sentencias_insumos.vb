Imports Npgsql

Public Class Sentencias_insumos

    'Creación de insumos
    Private adaptador As New Npgsql.NpgsqlDataAdapter


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
End Class

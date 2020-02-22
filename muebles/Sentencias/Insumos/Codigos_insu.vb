
Imports Npgsql

Module Codigos_insu

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    Public Sub Consulta_sub_cates()
        Dim sql_select As String
        Dim codex As Integer

        Try
            Conectar()
            'Cuenta los registros 
            sql_select = ("SELECT count(*) FROM sub_categorias_insu;")

            'Se prepara la sentencia 
            Dim consulta As New NpgsqlCommand(sql_select, conex)

            'Nos aseguramos que no exista ninguna conexión abierta previa
            If Not conex Is Nothing Then conex.Close()

            'Abrimos conexión 
            conex.Open()

            'Declaramos la variable (De tipo entero) que contendrá los datos de los campos de los registros
            Dim Datos As NpgsqlDataReader = consulta.ExecuteReader

            'EjecutAmos el comando CONSULTA
            If Datos.Read Then
                'Declaramos y llenamos
                codex = Trim(Datos("count"))
            End If

            BuscarUltimo(codex)
            conex.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()

        End Try


    End Sub


    Public Sub BuscarUltimo(codex As Integer)
        Dim sql_select2 As String
        Dim cod As New DataSet
        Dim cont As Integer

        'Sentencia sql
        sql_select2 = ("SELECT id_sub_categoria_in FROM sub_categorias_insu;")
        'Se prepara la sentencia 
        Dim consulta2 As New NpgsqlCommand(sql_select2, conex)

        'Nos aseguramos que no exista ninguna conexión abierta previa
        If Not conex Is Nothing Then conex.Close()

        'Abrimos conexión 
        conex.Open()

        'Declaramos la variable (De tipo entero) que contendrá los datos de los campos de los registros
        Dim Datos As NpgsqlDataReader = consulta2.ExecuteReader

        'EjecutAmos el comando CONSULTA
        While Datos.Read

            cont += 1
            If cont = codex Then
                'obtiene la ultima id de la tabla 
                Dim id As String = Trim(Datos("id_sub_categoria_in"))
            Else

            End If

        End While

    End Sub

End Module

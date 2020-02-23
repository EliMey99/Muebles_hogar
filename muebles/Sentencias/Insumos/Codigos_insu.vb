
Imports Npgsql

Module Codigos_insu

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    Public Sub Consulta_sub_cates(subcat As sub_categorias)
        Dim sql_select As String
        Dim codex As Integer
        Dim id_sub As String

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

            If codex = 0 Then
                'Si no hay registros
                id_sub = subcat.Id_categoria_in1 & "001"
                subcat.Id_sub_categoria_in1 = id_sub
            Else
                BuscarUltimo(codex, subcat)
            End If


            conex.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()

        End Try


    End Sub


    Public Sub BuscarUltimo(codex As Integer, ByVal dato As sub_categorias)
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

                'Comprobar el largo del identificador
                Select Case id.Length

                    Case 6
                        'Cortar el ultimo codigo para realizar comparaciones
                        'array
                        Dim cut(0 To 4) As String
                        cut(0) = Mid(id, 4, 1)
                        cut(1) = Mid(id, 5, 1)
                        cut(2) = Mid(id, 6)
                        'Concatenar con la categoria y los ceros correspondientes
                        If cut(0) = 0 And cut(1) = 0 Then

                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "00" & cut(2) + 1

                        ElseIf cut(0) = 0 And cut(1) > 0 Then

                            cut(3) = Mid(id, 5, 4)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "0" & cut(3) + 1

                        Else

                            cut(3) = Mid(id, 5, 6)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & cut(3) + 1

                        End If
                    Case 5
                        'Cortar el ultimo codigo para realizar comparaciones
                        'array
                        Dim cut(0 To 4) As String
                        cut(0) = Mid(id, 3, 1)
                        cut(1) = Mid(id, 4, 1)
                        cut(2) = Mid(id, 5)
                        'Concatenar con la categoria y los ceros correspondientes
                        If cut(0) = 0 And cut(1) = 0 Then

                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "00" & cut(2) + 1

                        ElseIf cut(0) = 0 And cut(1) > 0 Then

                            cut(3) = Mid(id, 3, 4)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "0" & cut(3) + 1

                        Else

                            cut(3) = Mid(id, 3, 5)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & cut(3) + 1

                        End If

                    Case 4
                        'array
                        Dim cut(0 To 4) As String
                        cut(0) = Mid(id, 2, 1)
                        cut(1) = Mid(id, 3, 1)
                        cut(2) = Mid(id, 4)
                        'Concatenar con la categoria y los ceros correspondientes
                        If cut(0) = 0 And cut(1) = 0 Then

                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "00" & cut(2) + 1

                        ElseIf cut(0) = 0 And cut(1) > 0 Then

                            cut(3) = Mid(id, 2, 3)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & "0" & cut(3) + 1

                        Else

                            cut(3) = Mid(id, 2, 4)
                            dato.Id_sub_categoria_in1 = dato.Id_categoria_in1 & cut(3) + 1

                        End If

                End Select


            Else

            End If

        End While

    End Sub

End Module

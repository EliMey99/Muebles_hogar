Public Class categorias

    Dim idcategoria As String
    Dim nombrecategoria As String
    Dim idsubcategoria As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        crearcategoria.Show()

    End Sub

    Private Sub categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        datos.Reset()
        datos1.Reset()
        consulta_datos()
        dgvcategorias.DataSource = _dtvdatos
        consulta_datos_sub()
        dgvsubcategorias.DataSource = _dtvdatos1

    End Sub




    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

        datos.Reset()

        crearsubcategoria.Show()

    End Sub

    Private Sub dgvcategorias_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorias.CellEndEdit

        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        idcategoria = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(0).Value.ToString
        nombrecategoria = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(nombrecategoria)) Then
            MessageBox.Show("Ingrese un nombre para actualizar categoria")
        Else

            Dim datoscategoria As New categoria
            Dim sentencia As New Sentencias_insumos

            datoscategoria.Id_categoria1 = idcategoria
            datoscategoria.Nombre_categoria1 = nombrecategoria

            If sentencia.Actualizar_Categorias(datoscategoria) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If




    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        Dim datoscategoria As New categoria
        Dim sentencia As New Sentencias_insumos

        idcategoria = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idcategoria)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datoscategoria.Id_categoria1 = idcategoria

                If sentencia.Eliminar_Categoria(datoscategoria) Then
                    MessageBox.Show("Datos Guardados")
                    datos.Reset()

                    consulta_datos()
                    dgvcategorias.DataSource = _dtvdatos
                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else

                MessageBox.Show("opcion no")

            End If

        End If

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click

        Dim datosubcategoria As New sub_categorias
        Dim sentencia As New Sentencias_insumos

        idsubcategoria = dgvsubcategorias.Rows(dgvsubcategorias.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idsubcategoria)) Then
            MessageBox.Show("Debe seleccionar un registro para continuar")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datosubcategoria.Id_sub_categoria_in1 = idsubcategoria

                If sentencia.Eliminar_Subcategoria(datosubcategoria) Then
                    MessageBox.Show("Datos Guardados")
                    datos.Reset()

                    consulta_datos_sub()
                    dgvsubcategorias.DataSource = _dtvdatos1
                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else

                MessageBox.Show("opcion no")

            End If

        End If
    End Sub
End Class
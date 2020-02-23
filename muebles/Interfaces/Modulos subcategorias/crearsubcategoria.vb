Public Class crearsubcategoria

    Dim idcategoria As String

    Private Sub crearsubcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        consulta_datos()

        dgvsubcategorias.DataSource = _dtvdatos

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim datossubcategoria As New sub_categorias
        Dim sentencia As New Sentencias_insumos

        'controlar que se haya seleccionado la opcion en el datagridview
        If (String.IsNullOrEmpty(idcategoria)) Then
            MessageBox.Show("Seleccione una categoria para continuar")
        Else

            If (String.IsNullOrEmpty(txtcritico.Text) Or String.IsNullOrEmpty(txtminimo.Text) Or String.IsNullOrEmpty(txtmaximo.Text) Or String.IsNullOrEmpty(txtid.Text)) Then
                MessageBox.Show("Rellene todos los campos para continuar")
            Else

                'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

                datossubcategoria.Id_sub_categoria_in1 = txtid.Text
                datossubcategoria.Nombre_sub_cate1 = txtnombre.Text
                datossubcategoria.Id_categoria_in1 = idcategoria
                datossubcategoria.Stock_critico1 = txtcritico.Text
                datossubcategoria.Stock_minimo1 = txtminimo.Text
                datossubcategoria.Stock_maximo1 = txtmaximo.Text

                If sentencia.Creacion_sub_categoria(datossubcategoria) Then
                    MessageBox.Show("Datos Guardados")
                    datos.Reset()
                Else
                    MessageBox.Show("Error al Guardar")
                End If


            End If

        End If



    End Sub

    Private Sub dgvsubcategorias_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsubcategorias.CellContentDoubleClick

        Dim subcat As New sub_categorias

        idcategoria = dgvsubcategorias.Rows(dgvsubcategorias.CurrentRow.Index).Cells(0).Value
        subcat.Id_categoria_in1 = idcategoria
        Consulta_sub_cates(subcat)
        txtid.Text = subcat.Id_Sub_categoria_in1

    End Sub

End Class
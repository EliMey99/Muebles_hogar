Public Class crearcategoria


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim datoscategoria As New categoria
        Dim sentencia As New Sentencias_insumos



        If (String.IsNullOrEmpty(txtboxcrear.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datoscategoria.Nombre_categoria1 = txtboxcrear.Text

            If sentencia.Creacion_Categoria(datoscategoria) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If




    End Sub

    Private Sub crearcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
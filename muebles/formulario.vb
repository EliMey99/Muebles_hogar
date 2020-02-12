Imports Npgsql
Public Class formulario_principal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()
        panel_insumos.Visible = False

    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private currentform As Form = Nothing
    Private Sub abrirpanelhijo(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        panel_hijo.Controls.Add(childform)
        panel_hijo.Tag = childform
        childform.BringToFront()
        childform.Show()


    End Sub

    Private Sub botoncrearinsumos_Click(sender As Object, e As EventArgs) Handles botoncrearinsumos.Click
        'hideSubmenu()
        abrirpanelhijo(New insumos_clase())
    End Sub

    Private Sub botoninsumos_Click(sender As Object, e As EventArgs) Handles botoninsumos.Click
        showSubmenu(panel_insumos)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)
        Conectar()

    End Sub

    Private Sub botonadministrarcategorias_Click(sender As Object, e As EventArgs) Handles botonadministrarcategorias.Click
        abrirpanelhijo(New categorias())
    End Sub
End Class

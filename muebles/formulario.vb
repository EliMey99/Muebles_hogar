Public Class formulario_principal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

    Private Sub hideSubmenu()
        panel_insumos.Visible = False
        panel_produccion.Visible = False
        panel_ventas.Visible = False
        panel_cuentas.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub boton_insumos_Click(sender As Object, e As EventArgs) Handles boton_insumos.Click
        showSubmenu(panel_insumos)

    End Sub

    Private Sub boton_produccion_Click(sender As Object, e As EventArgs) Handles boton_produccion.Click
        showSubmenu(panel_produccion)




    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        showSubmenu(panel_ventas)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hideSubmenu()
        abrirpanelhijo(New insumos())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hideSubmenu()
        login.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hideSubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        hideSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        hideSubmenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideSubmenu()
    End Sub

    Private Sub boton_configuracion_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub boton_cuentas_Click(sender As Object, e As EventArgs) Handles boton_cuentas.Click
        showSubmenu(panel_cuentas)
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

End Class

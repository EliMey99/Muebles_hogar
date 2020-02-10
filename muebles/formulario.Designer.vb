<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formulario_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panel_hijo = New System.Windows.Forms.Panel()
        Me.Panel_lateral = New System.Windows.Forms.Panel()
        Me.botoncuentas = New FontAwesome.Sharp.IconButton()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.panel_ventas = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_ventas = New System.Windows.Forms.Button()
        Me.panel_produccion = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.boton_produccion = New System.Windows.Forms.Button()
        Me.panel_insumos = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.boton_insumos = New System.Windows.Forms.Button()
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_lateral.SuspendLayout()
        Me.panel_ventas.SuspendLayout()
        Me.panel_produccion.SuspendLayout()
        Me.panel_insumos.SuspendLayout()
        Me.panel_logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_hijo
        '
        Me.panel_hijo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panel_hijo.BackgroundImage = Global.muebles.My.Resources.Resources.FONDOPANEL5
        Me.panel_hijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_hijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hijo.Location = New System.Drawing.Point(220, 0)
        Me.panel_hijo.Name = "panel_hijo"
        Me.panel_hijo.Size = New System.Drawing.Size(1258, 796)
        Me.panel_hijo.TabIndex = 1
        '
        'Panel_lateral
        '
        Me.Panel_lateral.AutoScroll = True
        Me.Panel_lateral.BackColor = System.Drawing.SystemColors.Info
        Me.Panel_lateral.BackgroundImage = Global.muebles.My.Resources.Resources.Sin_título_8
        Me.Panel_lateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_lateral.Controls.Add(Me.botoncuentas)
        Me.Panel_lateral.Controls.Add(Me.Button10)
        Me.Panel_lateral.Controls.Add(Me.panel_ventas)
        Me.Panel_lateral.Controls.Add(Me.btn_ventas)
        Me.Panel_lateral.Controls.Add(Me.panel_produccion)
        Me.Panel_lateral.Controls.Add(Me.boton_produccion)
        Me.Panel_lateral.Controls.Add(Me.panel_insumos)
        Me.Panel_lateral.Controls.Add(Me.boton_insumos)
        Me.Panel_lateral.Controls.Add(Me.panel_logo)
        Me.Panel_lateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_lateral.Location = New System.Drawing.Point(0, 0)
        Me.Panel_lateral.Name = "Panel_lateral"
        Me.Panel_lateral.Size = New System.Drawing.Size(220, 796)
        Me.Panel_lateral.TabIndex = 0
        '
        'botoncuentas
        '
        Me.botoncuentas.BackColor = System.Drawing.Color.Transparent
        Me.botoncuentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.botoncuentas.FlatAppearance.BorderSize = 0
        Me.botoncuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botoncuentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.botoncuentas.Font = New System.Drawing.Font("Arial", 10.8!)
        Me.botoncuentas.ForeColor = System.Drawing.Color.DimGray
        Me.botoncuentas.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.botoncuentas.IconColor = System.Drawing.Color.BurlyWood
        Me.botoncuentas.IconSize = 30
        Me.botoncuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botoncuentas.Location = New System.Drawing.Point(0, 694)
        Me.botoncuentas.Name = "botoncuentas"
        Me.botoncuentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.botoncuentas.Rotation = 0R
        Me.botoncuentas.Size = New System.Drawing.Size(220, 45)
        Me.botoncuentas.TabIndex = 9
        Me.botoncuentas.Text = "Cuentas"
        Me.botoncuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botoncuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.botoncuentas.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.DimGray
        Me.Button10.Location = New System.Drawing.Point(0, 649)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button10.Size = New System.Drawing.Size(220, 45)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "Gastos"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'panel_ventas
        '
        Me.panel_ventas.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel_ventas.Controls.Add(Me.Button4)
        Me.panel_ventas.Controls.Add(Me.Button8)
        Me.panel_ventas.Controls.Add(Me.Button9)
        Me.panel_ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_ventas.Location = New System.Drawing.Point(0, 518)
        Me.panel_ventas.Name = "panel_ventas"
        Me.panel_ventas.Size = New System.Drawing.Size(220, 131)
        Me.panel_ventas.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button4.Location = New System.Drawing.Point(0, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(220, 40)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Button4"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Info
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button8.Location = New System.Drawing.Point(0, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(220, 40)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Button8"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Info
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button9.Location = New System.Drawing.Point(0, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(220, 40)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Button9"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btn_ventas
        '
        Me.btn_ventas.BackColor = System.Drawing.Color.Transparent
        Me.btn_ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ventas.FlatAppearance.BorderSize = 0
        Me.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ventas.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ventas.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ventas.Location = New System.Drawing.Point(0, 473)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_ventas.Size = New System.Drawing.Size(220, 45)
        Me.btn_ventas.TabIndex = 5
        Me.btn_ventas.Text = "Ventas"
        Me.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ventas.UseVisualStyleBackColor = False
        '
        'panel_produccion
        '
        Me.panel_produccion.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel_produccion.Controls.Add(Me.Button5)
        Me.panel_produccion.Controls.Add(Me.Button6)
        Me.panel_produccion.Controls.Add(Me.Button7)
        Me.panel_produccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_produccion.Location = New System.Drawing.Point(0, 342)
        Me.panel_produccion.Name = "panel_produccion"
        Me.panel_produccion.Size = New System.Drawing.Size(220, 131)
        Me.panel_produccion.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button5.Location = New System.Drawing.Point(0, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(220, 40)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Button5"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button6.Location = New System.Drawing.Point(0, 40)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(220, 40)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Button6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Info
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(220, 40)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Button7"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'boton_produccion
        '
        Me.boton_produccion.BackColor = System.Drawing.Color.Transparent
        Me.boton_produccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.boton_produccion.FlatAppearance.BorderSize = 0
        Me.boton_produccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.boton_produccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_produccion.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_produccion.ForeColor = System.Drawing.Color.DimGray
        Me.boton_produccion.Location = New System.Drawing.Point(0, 297)
        Me.boton_produccion.Name = "boton_produccion"
        Me.boton_produccion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.boton_produccion.Size = New System.Drawing.Size(220, 45)
        Me.boton_produccion.TabIndex = 3
        Me.boton_produccion.Text = "Produccion"
        Me.boton_produccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_produccion.UseVisualStyleBackColor = False
        '
        'panel_insumos
        '
        Me.panel_insumos.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel_insumos.Controls.Add(Me.Button3)
        Me.panel_insumos.Controls.Add(Me.Button2)
        Me.panel_insumos.Controls.Add(Me.Button1)
        Me.panel_insumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_insumos.Location = New System.Drawing.Point(0, 166)
        Me.panel_insumos.Name = "panel_insumos"
        Me.panel_insumos.Size = New System.Drawing.Size(220, 131)
        Me.panel_insumos.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button3.Location = New System.Drawing.Point(0, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(220, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Control inventario"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(220, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Registro proveedores"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(220, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Administrar insumos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'boton_insumos
        '
        Me.boton_insumos.BackColor = System.Drawing.Color.Transparent
        Me.boton_insumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.boton_insumos.FlatAppearance.BorderSize = 0
        Me.boton_insumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.boton_insumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_insumos.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_insumos.ForeColor = System.Drawing.Color.DimGray
        Me.boton_insumos.Location = New System.Drawing.Point(0, 121)
        Me.boton_insumos.Name = "boton_insumos"
        Me.boton_insumos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.boton_insumos.Size = New System.Drawing.Size(220, 45)
        Me.boton_insumos.TabIndex = 1
        Me.boton_insumos.Text = "Materiales"
        Me.boton_insumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boton_insumos.UseVisualStyleBackColor = False
        '
        'panel_logo
        '
        Me.panel_logo.Controls.Add(Me.PictureBox1)
        Me.panel_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_logo.Location = New System.Drawing.Point(0, 0)
        Me.panel_logo.Name = "panel_logo"
        Me.panel_logo.Size = New System.Drawing.Size(220, 121)
        Me.panel_logo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.muebles.My.Resources.Resources.logo4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'formulario_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 796)
        Me.Controls.Add(Me.panel_hijo)
        Me.Controls.Add(Me.Panel_lateral)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.MinimumSize = New System.Drawing.Size(1039, 542)
        Me.Name = "formulario_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel_lateral.ResumeLayout(False)
        Me.panel_ventas.ResumeLayout(False)
        Me.panel_produccion.ResumeLayout(False)
        Me.panel_insumos.ResumeLayout(False)
        Me.panel_logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_lateral As Panel
    Friend WithEvents panel_insumos As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents boton_insumos As Button
    Friend WithEvents panel_logo As Panel
    Friend WithEvents panel_ventas As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_ventas As Button
    Friend WithEvents panel_produccion As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents boton_produccion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents panel_hijo As Panel
    Friend WithEvents botoncuentas As FontAwesome.Sharp.IconButton
End Class

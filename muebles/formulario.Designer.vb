﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_lateral = New System.Windows.Forms.Panel()
        Me.panel_insumos = New System.Windows.Forms.Panel()
        Me.botonadministrarcategorias = New FontAwesome.Sharp.IconButton()
        Me.botoncrearinsumos = New FontAwesome.Sharp.IconButton()
        Me.botoninsumos = New FontAwesome.Sharp.IconButton()
        Me.panel_logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_hijo.SuspendLayout()
        Me.Panel_lateral.SuspendLayout()
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
        Me.panel_hijo.Controls.Add(Me.Label1)
        Me.panel_hijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hijo.Location = New System.Drawing.Point(220, 0)
        Me.panel_hijo.Name = "panel_hijo"
        Me.panel_hijo.Size = New System.Drawing.Size(1258, 796)
        Me.panel_hijo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(67, 630)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "proveedores - bodega - produccion - cuentas - item de gastos - obras"
        '
        'Panel_lateral
        '
        Me.Panel_lateral.AutoScroll = True
        Me.Panel_lateral.BackColor = System.Drawing.SystemColors.Info
        Me.Panel_lateral.BackgroundImage = Global.muebles.My.Resources.Resources.Sin_título_8
        Me.Panel_lateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_lateral.Controls.Add(Me.panel_insumos)
        Me.Panel_lateral.Controls.Add(Me.botoninsumos)
        Me.Panel_lateral.Controls.Add(Me.panel_logo)
        Me.Panel_lateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_lateral.Location = New System.Drawing.Point(0, 0)
        Me.Panel_lateral.MinimumSize = New System.Drawing.Size(220, 796)
        Me.Panel_lateral.Name = "Panel_lateral"
        Me.Panel_lateral.Size = New System.Drawing.Size(220, 796)
        Me.Panel_lateral.TabIndex = 0
        '
        'panel_insumos
        '
        Me.panel_insumos.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel_insumos.Controls.Add(Me.botonadministrarcategorias)
        Me.panel_insumos.Controls.Add(Me.botoncrearinsumos)
        Me.panel_insumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_insumos.Location = New System.Drawing.Point(0, 166)
        Me.panel_insumos.Name = "panel_insumos"
        Me.panel_insumos.Size = New System.Drawing.Size(220, 165)
        Me.panel_insumos.TabIndex = 4
        '
        'botonadministrarcategorias
        '
        Me.botonadministrarcategorias.BackColor = System.Drawing.SystemColors.Info
        Me.botonadministrarcategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.botonadministrarcategorias.FlatAppearance.BorderSize = 0
        Me.botonadministrarcategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonadministrarcategorias.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.botonadministrarcategorias.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.botonadministrarcategorias.ForeColor = System.Drawing.Color.Goldenrod
        Me.botonadministrarcategorias.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.botonadministrarcategorias.IconColor = System.Drawing.Color.DarkGray
        Me.botonadministrarcategorias.IconSize = 26
        Me.botonadministrarcategorias.Location = New System.Drawing.Point(0, 40)
        Me.botonadministrarcategorias.Name = "botonadministrarcategorias"
        Me.botonadministrarcategorias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.botonadministrarcategorias.Rotation = 0R
        Me.botonadministrarcategorias.Size = New System.Drawing.Size(220, 40)
        Me.botonadministrarcategorias.TabIndex = 5
        Me.botonadministrarcategorias.Text = "Administrar categorias"
        Me.botonadministrarcategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonadministrarcategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.botonadministrarcategorias.UseVisualStyleBackColor = False
        '
        'botoncrearinsumos
        '
        Me.botoncrearinsumos.BackColor = System.Drawing.SystemColors.Info
        Me.botoncrearinsumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.botoncrearinsumos.FlatAppearance.BorderSize = 0
        Me.botoncrearinsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botoncrearinsumos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.botoncrearinsumos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.botoncrearinsumos.ForeColor = System.Drawing.Color.Goldenrod
        Me.botoncrearinsumos.IconChar = FontAwesome.Sharp.IconChar.Cubes
        Me.botoncrearinsumos.IconColor = System.Drawing.Color.DarkGray
        Me.botoncrearinsumos.IconSize = 28
        Me.botoncrearinsumos.Location = New System.Drawing.Point(0, 0)
        Me.botoncrearinsumos.Name = "botoncrearinsumos"
        Me.botoncrearinsumos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.botoncrearinsumos.Rotation = 0R
        Me.botoncrearinsumos.Size = New System.Drawing.Size(220, 40)
        Me.botoncrearinsumos.TabIndex = 4
        Me.botoncrearinsumos.Text = "Administrar insumo"
        Me.botoncrearinsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botoncrearinsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.botoncrearinsumos.UseVisualStyleBackColor = False
        '
        'botoninsumos
        '
        Me.botoninsumos.BackColor = System.Drawing.Color.Transparent
        Me.botoninsumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.botoninsumos.FlatAppearance.BorderSize = 0
        Me.botoninsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botoninsumos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.botoninsumos.Font = New System.Drawing.Font("Arial", 10.8!)
        Me.botoninsumos.ForeColor = System.Drawing.Color.DimGray
        Me.botoninsumos.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.botoninsumos.IconColor = System.Drawing.Color.DarkGray
        Me.botoninsumos.IconSize = 26
        Me.botoninsumos.Location = New System.Drawing.Point(0, 121)
        Me.botoninsumos.Name = "botoninsumos"
        Me.botoninsumos.Rotation = 0R
        Me.botoninsumos.Size = New System.Drawing.Size(220, 45)
        Me.botoninsumos.TabIndex = 3
        Me.botoninsumos.Text = "Insumos"
        Me.botoninsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botoninsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.botoninsumos.UseVisualStyleBackColor = False
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
        Me.MaximumSize = New System.Drawing.Size(1496, 843)
        Me.MinimumSize = New System.Drawing.Size(1296, 643)
        Me.Name = "formulario_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel_hijo.ResumeLayout(False)
        Me.panel_hijo.PerformLayout()
        Me.Panel_lateral.ResumeLayout(False)
        Me.panel_insumos.ResumeLayout(False)
        Me.panel_logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_lateral As Panel
    Friend WithEvents panel_logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panel_hijo As Panel
    Friend WithEvents panel_insumos As Panel
    Friend WithEvents botoninsumos As FontAwesome.Sharp.IconButton
    Friend WithEvents botoncrearinsumos As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents botonadministrarcategorias As FontAwesome.Sharp.IconButton
End Class

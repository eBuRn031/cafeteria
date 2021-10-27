<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.cbunidadmedida = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbimagen = New System.Windows.Forms.PictureBox()
        Me.btnimagen = New System.Windows.Forms.Button()
        Me.nudprecio1 = New System.Windows.Forms.NumericUpDown()
        Me.nudprecio2 = New System.Windows.Forms.NumericUpDown()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudprecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudprecio2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(13, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Categoria"
        '
        'txtruta
        '
        Me.txtruta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtruta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruta.Location = New System.Drawing.Point(15, 305)
        Me.txtruta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtruta.MaxLength = 20
        Me.txtruta.Name = "txtruta"
        Me.txtruta.ReadOnly = True
        Me.txtruta.Size = New System.Drawing.Size(216, 23)
        Me.txtruta.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(13, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Imagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(153, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Precio 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(13, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Precio 1"
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(14, 30)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombre.MaxLength = 100
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(274, 23)
        Me.txtnombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Image = Global.cafeteria.My.Resources.Resources._85350_accept_icon
        Me.btnAgregar.Location = New System.Drawing.Point(14, 344)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(533, 49)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cbcategoria
        '
        Me.cbcategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Location = New System.Drawing.Point(15, 162)
        Me.cbcategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(274, 24)
        Me.cbcategoria.TabIndex = 3
        '
        'cbunidadmedida
        '
        Me.cbunidadmedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbunidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbunidadmedida.FormattingEnabled = True
        Me.cbunidadmedida.Location = New System.Drawing.Point(15, 210)
        Me.cbunidadmedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbunidadmedida.Name = "cbunidadmedida"
        Me.cbunidadmedida.Size = New System.Drawing.Size(274, 24)
        Me.cbunidadmedida.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Indigo
        Me.Label7.Location = New System.Drawing.Point(13, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Unidad Medida"
        '
        'pbimagen
        '
        Me.pbimagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbimagen.Image = Global.cafeteria.My.Resources.Resources.Sin_imagen_disponible
        Me.pbimagen.Location = New System.Drawing.Point(294, 13)
        Me.pbimagen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbimagen.Name = "pbimagen"
        Me.pbimagen.Size = New System.Drawing.Size(253, 317)
        Me.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbimagen.TabIndex = 31
        Me.pbimagen.TabStop = False
        '
        'btnimagen
        '
        Me.btnimagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimagen.Image = Global.cafeteria.My.Resources.Resources.photoicon
        Me.btnimagen.Location = New System.Drawing.Point(239, 289)
        Me.btnimagen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.Size = New System.Drawing.Size(50, 41)
        Me.btnimagen.TabIndex = 8
        Me.btnimagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimagen.UseVisualStyleBackColor = True
        '
        'nudprecio1
        '
        Me.nudprecio1.DecimalPlaces = 2
        Me.nudprecio1.Location = New System.Drawing.Point(15, 258)
        Me.nudprecio1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudprecio1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudprecio1.Name = "nudprecio1"
        Me.nudprecio1.Size = New System.Drawing.Size(134, 23)
        Me.nudprecio1.TabIndex = 5
        Me.nudprecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudprecio2
        '
        Me.nudprecio2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudprecio2.DecimalPlaces = 2
        Me.nudprecio2.Location = New System.Drawing.Point(155, 258)
        Me.nudprecio2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudprecio2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudprecio2.Name = "nudprecio2"
        Me.nudprecio2.Size = New System.Drawing.Size(134, 23)
        Me.nudprecio2.TabIndex = 6
        Me.nudprecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(14, 77)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdescripcion.MaxLength = 250
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(274, 64)
        Me.txtdescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Descripcion"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(553, 406)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudprecio2)
        Me.Controls.Add(Me.nudprecio1)
        Me.Controls.Add(Me.btnimagen)
        Me.Controls.Add(Me.pbimagen)
        Me.Controls.Add(Me.cbunidadmedida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmProductos"
        Me.Text = "PRODUCTOS"
        CType(Me.pbimagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudprecio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudprecio2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents cbunidadmedida As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pbimagen As PictureBox
    Friend WithEvents btnimagen As Button
    Friend WithEvents nudprecio1 As NumericUpDown
    Friend WithEvents nudprecio2 As NumericUpDown
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label1 As Label
End Class

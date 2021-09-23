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
        CType(Me.pbimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudprecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudprecio2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Categoria"
        '
        'txtruta
        '
        Me.txtruta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruta.Location = New System.Drawing.Point(86, 146)
        Me.txtruta.MaxLength = 20
        Me.txtruta.Name = "txtruta"
        Me.txtruta.ReadOnly = True
        Me.txtruta.Size = New System.Drawing.Size(135, 20)
        Me.txtruta.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Imagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Precio 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Precio 1"
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(86, 12)
        Me.txtnombre.MaxLength = 20
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(184, 20)
        Me.txtnombre.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 172)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(481, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbcategoria
        '
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Location = New System.Drawing.Point(86, 38)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(184, 21)
        Me.cbcategoria.TabIndex = 28
        '
        'cbunidadmedida
        '
        Me.cbunidadmedida.FormattingEnabled = True
        Me.cbunidadmedida.Location = New System.Drawing.Point(86, 67)
        Me.cbunidadmedida.Name = "cbunidadmedida"
        Me.cbunidadmedida.Size = New System.Drawing.Size(184, 21)
        Me.cbunidadmedida.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Unidad Medida"
        '
        'pbimagen
        '
        Me.pbimagen.Image = Global.cafeteria.My.Resources.Resources.Sin_imagen_disponible
        Me.pbimagen.Location = New System.Drawing.Point(276, 12)
        Me.pbimagen.Name = "pbimagen"
        Me.pbimagen.Size = New System.Drawing.Size(217, 150)
        Me.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbimagen.TabIndex = 31
        Me.pbimagen.TabStop = False
        '
        'btnimagen
        '
        Me.btnimagen.Location = New System.Drawing.Point(227, 144)
        Me.btnimagen.Name = "btnimagen"
        Me.btnimagen.Size = New System.Drawing.Size(43, 23)
        Me.btnimagen.TabIndex = 32
        Me.btnimagen.Text = "X"
        Me.btnimagen.UseVisualStyleBackColor = True
        '
        'nudprecio1
        '
        Me.nudprecio1.DecimalPlaces = 2
        Me.nudprecio1.Location = New System.Drawing.Point(86, 95)
        Me.nudprecio1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudprecio1.Name = "nudprecio1"
        Me.nudprecio1.Size = New System.Drawing.Size(184, 20)
        Me.nudprecio1.TabIndex = 33
        Me.nudprecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudprecio2
        '
        Me.nudprecio2.DecimalPlaces = 2
        Me.nudprecio2.Location = New System.Drawing.Point(86, 121)
        Me.nudprecio2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudprecio2.Name = "nudprecio2"
        Me.nudprecio2.Size = New System.Drawing.Size(184, 20)
        Me.nudprecio2.TabIndex = 34
        Me.nudprecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 202)
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
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
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
End Class

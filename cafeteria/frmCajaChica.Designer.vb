<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaChica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaChica))
        Me.txtfechafinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfechainicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudmontoinicio = New System.Windows.Forms.NumericUpDown()
        Me.nudmontofinal = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.nudmontoinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmontofinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfechafinal
        '
        Me.txtfechafinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfechafinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfechafinal.Location = New System.Drawing.Point(17, 173)
        Me.txtfechafinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfechafinal.MaxLength = 20
        Me.txtfechafinal.Name = "txtfechafinal"
        Me.txtfechafinal.Size = New System.Drawing.Size(213, 23)
        Me.txtfechafinal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(14, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Fin"
        '
        'txtfechainicio
        '
        Me.txtfechainicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfechainicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfechainicio.Location = New System.Drawing.Point(17, 126)
        Me.txtfechainicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfechainicio.MaxLength = 20
        Me.txtfechainicio.Name = "txtfechainicio"
        Me.txtfechainicio.Size = New System.Drawing.Size(213, 23)
        Me.txtfechainicio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(14, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Inicio"
        '
        'dtpfecha
        '
        Me.dtpfecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpfecha.Location = New System.Drawing.Point(17, 79)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(331, 23)
        Me.dtpfecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(14, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(14, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Usuario"
        '
        'cbUsuarios
        '
        Me.cbUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(17, 31)
        Me.cbUsuarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(331, 24)
        Me.cbUsuarios.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(233, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Monto Inicial"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(233, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Monto Final"
        '
        'nudmontoinicio
        '
        Me.nudmontoinicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudmontoinicio.Location = New System.Drawing.Point(236, 127)
        Me.nudmontoinicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudmontoinicio.Name = "nudmontoinicio"
        Me.nudmontoinicio.Size = New System.Drawing.Size(112, 23)
        Me.nudmontoinicio.TabIndex = 4
        Me.nudmontoinicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudmontofinal
        '
        Me.nudmontofinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudmontofinal.Location = New System.Drawing.Point(236, 173)
        Me.nudmontofinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudmontofinal.Name = "nudmontofinal"
        Me.nudmontofinal.Size = New System.Drawing.Size(112, 23)
        Me.nudmontofinal.TabIndex = 6
        Me.nudmontofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Indigo
        Me.Label7.Location = New System.Drawing.Point(14, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Comentario"
        '
        'txtcomentario
        '
        Me.txtcomentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcomentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomentario.Location = New System.Drawing.Point(17, 220)
        Me.txtcomentario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcomentario.MaxLength = 20
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(275, 65)
        Me.txtcomentario.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(14, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 26)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "* Fecha Inicio y Fin deben de tener el formato " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dd/MM/yyyy HH:MM:ss"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.cafeteria.My.Resources.Resources._85350_accept_icon
        Me.btnAgregar.Location = New System.Drawing.Point(298, 220)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(50, 65)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmCajaChica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(361, 321)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudmontofinal)
        Me.Controls.Add(Me.nudmontoinicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbUsuarios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.txtfechafinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfechainicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCajaChica"
        Me.Text = "CAJA CHICA"
        CType(Me.nudmontoinicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudmontofinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfechafinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfechainicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbUsuarios As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudmontoinicio As NumericUpDown
    Friend WithEvents nudmontofinal As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcomentario As TextBox
    Friend WithEvents Label8 As Label
End Class

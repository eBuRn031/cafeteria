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
        Me.txtfechafinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfechainicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
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
        CType(Me.nudmontoinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmontofinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfechafinal
        '
        Me.txtfechafinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfechafinal.Location = New System.Drawing.Point(95, 125)
        Me.txtfechafinal.MaxLength = 20
        Me.txtfechafinal.Name = "txtfechafinal"
        Me.txtfechafinal.Size = New System.Drawing.Size(183, 20)
        Me.txtfechafinal.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Fin"
        '
        'txtfechainicio
        '
        Me.txtfechainicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfechainicio.Location = New System.Drawing.Point(95, 72)
        Me.txtfechainicio.MaxLength = 20
        Me.txtfechainicio.Name = "txtfechainicio"
        Me.txtfechainicio.Size = New System.Drawing.Size(183, 20)
        Me.txtfechainicio.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Inicio"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(266, 23)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(95, 37)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(183, 20)
        Me.dtpfecha.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Usuario"
        '
        'cbUsuarios
        '
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(95, 6)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(183, 21)
        Me.cbUsuarios.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Monto Inicial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Monto Final"
        '
        'nudmontoinicio
        '
        Me.nudmontoinicio.Location = New System.Drawing.Point(95, 101)
        Me.nudmontoinicio.Name = "nudmontoinicio"
        Me.nudmontoinicio.Size = New System.Drawing.Size(183, 20)
        Me.nudmontoinicio.TabIndex = 34
        Me.nudmontoinicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudmontofinal
        '
        Me.nudmontofinal.Location = New System.Drawing.Point(95, 156)
        Me.nudmontofinal.Name = "nudmontofinal"
        Me.nudmontofinal.Size = New System.Drawing.Size(183, 20)
        Me.nudmontofinal.TabIndex = 35
        Me.nudmontofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Comentario"
        '
        'txtcomentario
        '
        Me.txtcomentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomentario.Location = New System.Drawing.Point(95, 182)
        Me.txtcomentario.MaxLength = 20
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(183, 20)
        Me.txtcomentario.TabIndex = 37
        '
        'frmCajaChica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 251)
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
        Me.Name = "frmCajaChica"
        Me.Text = "frmCajaChica"
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
End Class

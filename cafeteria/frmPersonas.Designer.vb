﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonas))
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtdni
        '
        Me.txtdni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdni.Location = New System.Drawing.Point(17, 33)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdni.MaxLength = 20
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(346, 23)
        Me.txtdni.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Image = Global.cafeteria.My.Resources.Resources._85350_accept_icon
        Me.btnAgregar.Location = New System.Drawing.Point(17, 205)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(346, 42)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dni"
        '
        'txtnombres
        '
        Me.txtnombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombres.Location = New System.Drawing.Point(17, 80)
        Me.txtnombres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnombres.MaxLength = 20
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(146, 23)
        Me.txtnombres.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombres"
        '
        'txtapellidos
        '
        Me.txtapellidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtapellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellidos.Location = New System.Drawing.Point(177, 80)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtapellidos.MaxLength = 20
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(186, 23)
        Me.txtapellidos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(174, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apellidos"
        '
        'txtcelular
        '
        Me.txtcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcelular.Location = New System.Drawing.Point(17, 127)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcelular.MaxLength = 20
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(146, 23)
        Me.txtcelular.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(14, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Celular"
        '
        'txtcorreo
        '
        Me.txtcorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcorreo.Location = New System.Drawing.Point(177, 127)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcorreo.MaxLength = 20
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(186, 23)
        Me.txtcorreo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(174, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Correo"
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(17, 174)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdireccion.MaxLength = 20
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(346, 23)
        Me.txtdireccion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(14, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Direccion"
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(375, 254)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcelular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPersonas"
        Me.Text = "PERSONAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdni As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label6 As Label
End Class

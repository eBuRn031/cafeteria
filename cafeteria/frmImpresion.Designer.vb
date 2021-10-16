<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpresion))
        Me.PD_TICKETS = New System.Drawing.Printing.PrintDocument()
        Me.PPC_MUESTRA = New System.Windows.Forms.PrintPreviewControl()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.CB_ZOOM = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PD_TICKETS
        '
        '
        'PPC_MUESTRA
        '
        Me.PPC_MUESTRA.AutoZoom = False
        Me.PPC_MUESTRA.BackColor = System.Drawing.Color.Gainsboro
        Me.PPC_MUESTRA.Dock = System.Windows.Forms.DockStyle.Left
        Me.PPC_MUESTRA.Location = New System.Drawing.Point(0, 0)
        Me.PPC_MUESTRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PPC_MUESTRA.Name = "PPC_MUESTRA"
        Me.PPC_MUESTRA.Size = New System.Drawing.Size(548, 484)
        Me.PPC_MUESTRA.TabIndex = 78
        Me.PPC_MUESTRA.Zoom = 0.43199315654405473R
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(557, 348)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(124, 124)
        Me.btn_crear.TabIndex = 79
        Me.btn_crear.Text = "Imprimir"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'CB_ZOOM
        '
        Me.CB_ZOOM.BackColor = System.Drawing.Color.White
        Me.CB_ZOOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ZOOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ZOOM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ZOOM.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CB_ZOOM.FormattingEnabled = True
        Me.CB_ZOOM.Items.AddRange(New Object() {"50%", "75%", "100%", "150%", "200%", "300%", "400%", "500%"})
        Me.CB_ZOOM.Location = New System.Drawing.Point(592, 22)
        Me.CB_ZOOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_ZOOM.Name = "CB_ZOOM"
        Me.CB_ZOOM.Size = New System.Drawing.Size(89, 22)
        Me.CB_ZOOM.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(554, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Zoom"
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(296, 205)
        Me.QrCodeImgControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(100, 75)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrCodeImgControl1.TabIndex = 84
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'frmImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 484)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_ZOOM)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.PPC_MUESTRA)
        Me.Controls.Add(Me.QrCodeImgControl1)
        Me.Name = "frmImpresion"
        Me.Text = "frmImpresion"
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PD_TICKETS As Printing.PrintDocument
    Friend WithEvents PPC_MUESTRA As PrintPreviewControl
    Friend WithEvents btn_crear As Button
    Friend WithEvents CB_ZOOM As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
End Class

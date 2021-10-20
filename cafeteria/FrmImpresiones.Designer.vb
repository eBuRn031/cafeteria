<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpresiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpresiones))
        Me.PD_TICKETS = New System.Drawing.Printing.PrintDocument()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_ZOOM = New System.Windows.Forms.ComboBox()
        Me.PPC_MUESTRA = New System.Windows.Forms.PrintPreviewControl()
        Me.PD_OrdenVenta = New System.Drawing.Printing.PrintDocument()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PD_TICKETS
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(406, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "ZOOM"
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
        Me.CB_ZOOM.Location = New System.Drawing.Point(406, 28)
        Me.CB_ZOOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_ZOOM.Name = "CB_ZOOM"
        Me.CB_ZOOM.Size = New System.Drawing.Size(87, 22)
        Me.CB_ZOOM.TabIndex = 1
        '
        'PPC_MUESTRA
        '
        Me.PPC_MUESTRA.AutoZoom = False
        Me.PPC_MUESTRA.BackColor = System.Drawing.Color.Gainsboro
        Me.PPC_MUESTRA.Location = New System.Drawing.Point(14, 14)
        Me.PPC_MUESTRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PPC_MUESTRA.Name = "PPC_MUESTRA"
        Me.PPC_MUESTRA.Size = New System.Drawing.Size(386, 474)
        Me.PPC_MUESTRA.TabIndex = 97
        Me.PPC_MUESTRA.Zoom = 0.43199315654405473R
        '
        'PD_OrdenVenta
        '
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Image = Global.cafeteria.My.Resources.Resources._39263_print_printer_icon
        Me.btnImprimir.Location = New System.Drawing.Point(406, 418)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 71)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(215, 206)
        Me.QrCodeImgControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(117, 92)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrCodeImgControl1.TabIndex = 101
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'FrmImpresiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(504, 502)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_ZOOM)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.PPC_MUESTRA)
        Me.Controls.Add(Me.QrCodeImgControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImpresiones"
        Me.Text = "IMPRIMIR"
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PD_TICKETS As Printing.PrintDocument
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_ZOOM As ComboBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PPC_MUESTRA As PrintPreviewControl
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents PD_OrdenVenta As Printing.PrintDocument
End Class

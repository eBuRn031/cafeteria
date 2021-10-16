<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCanjeComprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCanjeComprobante))
        Me.PPC_MUESTRA = New System.Windows.Forms.PrintPreviewControl()
        Me.PD_TICKETS = New System.Drawing.Printing.PrintDocument()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.CB_ZOOM = New System.Windows.Forms.ComboBox()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.lblmesa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbpago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PPC_MUESTRA
        '
        Me.PPC_MUESTRA.AutoZoom = False
        Me.PPC_MUESTRA.BackColor = System.Drawing.Color.Gainsboro
        Me.PPC_MUESTRA.Location = New System.Drawing.Point(12, 194)
        Me.PPC_MUESTRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PPC_MUESTRA.Name = "PPC_MUESTRA"
        Me.PPC_MUESTRA.Size = New System.Drawing.Size(331, 258)
        Me.PPC_MUESTRA.TabIndex = 78
        Me.PPC_MUESTRA.Zoom = 0.43199315654405473R
        '
        'PD_TICKETS
        '
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(375, 393)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 58)
        Me.btnImprimir.TabIndex = 79
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.CB_ZOOM.Location = New System.Drawing.Point(369, 211)
        Me.CB_ZOOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_ZOOM.Name = "CB_ZOOM"
        Me.CB_ZOOM.Size = New System.Drawing.Size(75, 22)
        Me.CB_ZOOM.TabIndex = 81
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(92, 208)
        Me.QrCodeImgControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(100, 75)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrCodeImgControl1.TabIndex = 84
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "ORDENES PENDIENTES"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(333, 15)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(10, 13)
        Me.lblusuario.TabIndex = 95
        Me.lblusuario.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "COMPROBANTE"
        '
        'cbTipoComprobante
        '
        Me.cbTipoComprobante.FormattingEnabled = True
        Me.cbTipoComprobante.Location = New System.Drawing.Point(110, 42)
        Me.cbTipoComprobante.Name = "cbTipoComprobante"
        Me.cbTipoComprobante.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoComprobante.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "ZOOM"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(6, 88)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDatos.Size = New System.Drawing.Size(438, 101)
        Me.dgvDatos.TabIndex = 97
        '
        'lblmesa
        '
        Me.lblmesa.AutoSize = True
        Me.lblmesa.Location = New System.Drawing.Point(334, 42)
        Me.lblmesa.Name = "lblmesa"
        Me.lblmesa.Size = New System.Drawing.Size(10, 13)
        Me.lblmesa.TabIndex = 99
        Me.lblmesa.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "MESA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "PAGO"
        '
        'cbpago
        '
        Me.cbpago.FormattingEnabled = True
        Me.cbpago.Location = New System.Drawing.Point(110, 12)
        Me.cbpago.Name = "cbpago"
        Me.cbpago.Size = New System.Drawing.Size(121, 21)
        Me.cbpago.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "SERIE"
        '
        'cbSerie
        '
        Me.cbSerie.FormattingEnabled = True
        Me.cbSerie.Location = New System.Drawing.Point(323, 64)
        Me.cbSerie.Name = "cbSerie"
        Me.cbSerie.Size = New System.Drawing.Size(121, 21)
        Me.cbSerie.TabIndex = 102
        '
        'frmCanjeComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 463)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbpago)
        Me.Controls.Add(Me.lblmesa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipoComprobante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_ZOOM)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.PPC_MUESTRA)
        Me.Controls.Add(Me.QrCodeImgControl1)
        Me.Name = "frmCanjeComprobante"
        Me.Text = "frmCanjeComprobante"
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PPC_MUESTRA As PrintPreviewControl
    Friend WithEvents PD_TICKETS As Printing.PrintDocument
    Friend WithEvents btnImprimir As Button
    Friend WithEvents CB_ZOOM As ComboBox
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTipoComprobante As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents lblmesa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbpago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSerie As ComboBox
End Class

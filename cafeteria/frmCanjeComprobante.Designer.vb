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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.lblmesa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbpago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ClientSize = New System.Drawing.Size(463, 204)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbpago)
        Me.Controls.Add(Me.lblmesa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipoComprobante)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCanjeComprobante"
        Me.Text = "frmCanjeComprobante"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTipoComprobante As ComboBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents lblmesa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbpago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSerie As ComboBox
End Class

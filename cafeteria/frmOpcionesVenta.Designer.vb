<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionesVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcionesVenta))
        Me.btnCanjearComprobante = New System.Windows.Forms.Button()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCanjearComprobante
        '
        Me.btnCanjearComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCanjearComprobante.Image = Global.cafeteria.My.Resources.Resources._6071845_folder_progress_task_update_update_task_progress_icon
        Me.btnCanjearComprobante.Location = New System.Drawing.Point(141, 13)
        Me.btnCanjearComprobante.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCanjearComprobante.Name = "btnCanjearComprobante"
        Me.btnCanjearComprobante.Size = New System.Drawing.Size(110, 107)
        Me.btnCanjearComprobante.TabIndex = 2
        Me.btnCanjearComprobante.Text = "Canjear Comprobante"
        Me.btnCanjearComprobante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCanjearComprobante.UseVisualStyleBackColor = True
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevoPedido.Image = Global.cafeteria.My.Resources.Resources._3298601_document_new_new_document_plus_icon
        Me.btnNuevoPedido.Location = New System.Drawing.Point(25, 13)
        Me.btnNuevoPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(110, 107)
        Me.btnNuevoPedido.TabIndex = 1
        Me.btnNuevoPedido.Text = "Nuevo Pedido"
        Me.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'frmOpcionesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(263, 133)
        Me.Controls.Add(Me.btnCanjearComprobante)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionesVenta"
        Me.Text = "OPCIONES DE VENTA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevoPedido As Button
    Friend WithEvents btnCanjearComprobante As Button
End Class

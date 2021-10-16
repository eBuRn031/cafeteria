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
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.btnCanjearComprobante = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Location = New System.Drawing.Point(22, 8)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(132, 64)
        Me.btnNuevoPedido.TabIndex = 0
        Me.btnNuevoPedido.Text = "Nuevo Pedido"
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'btnCanjearComprobante
        '
        Me.btnCanjearComprobante.Location = New System.Drawing.Point(172, 8)
        Me.btnCanjearComprobante.Name = "btnCanjearComprobante"
        Me.btnCanjearComprobante.Size = New System.Drawing.Size(132, 64)
        Me.btnCanjearComprobante.TabIndex = 1
        Me.btnCanjearComprobante.Text = "Canjear Comprobante"
        Me.btnCanjearComprobante.UseVisualStyleBackColor = True
        '
        'frmOpcionesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 84)
        Me.Controls.Add(Me.btnCanjearComprobante)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Name = "frmOpcionesVenta"
        Me.Text = "frmOpcionesVenta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevoPedido As Button
    Friend WithEvents btnCanjearComprobante As Button
End Class

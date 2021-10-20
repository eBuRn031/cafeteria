<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMesasSeleccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMesasSeleccion))
        Me.pnMesas = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnMesas
        '
        Me.pnMesas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnMesas.AutoScroll = True
        Me.pnMesas.Location = New System.Drawing.Point(14, 15)
        Me.pnMesas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnMesas.Name = "pnMesas"
        Me.pnMesas.Size = New System.Drawing.Size(763, 414)
        Me.pnMesas.TabIndex = 1
        '
        'frmMesasSeleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 443)
        Me.Controls.Add(Me.pnMesas)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMesasSeleccion"
        Me.Text = "frmMesasSeleccion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnMesas As Panel
End Class

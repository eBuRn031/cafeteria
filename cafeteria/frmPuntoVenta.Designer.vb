﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuntoVenta
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
        Me.pncategoria = New System.Windows.Forms.Panel()
        Me.pnproductos = New System.Windows.Forms.Panel()
        Me.pnventa = New System.Windows.Forms.Panel()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.nudtotal = New System.Windows.Forms.NumericUpDown()
        Me.nuddescuento = New System.Windows.Forms.NumericUpDown()
        Me.nudimpuesto = New System.Windows.Forms.NumericUpDown()
        Me.nudsubtotal = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbprecio1 = New System.Windows.Forms.RadioButton()
        Me.rbprecio2 = New System.Windows.Forms.RadioButton()
        Me.lblNombreMesa = New System.Windows.Forms.Label()
        Me.pnventa.SuspendLayout()
        CType(Me.nudtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuddescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudimpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudsubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pncategoria
        '
        Me.pncategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pncategoria.AutoScroll = True
        Me.pncategoria.BackColor = System.Drawing.SystemColors.Control
        Me.pncategoria.Location = New System.Drawing.Point(402, 37)
        Me.pncategoria.Name = "pncategoria"
        Me.pncategoria.Size = New System.Drawing.Size(332, 55)
        Me.pncategoria.TabIndex = 0
        '
        'pnproductos
        '
        Me.pnproductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnproductos.AutoScroll = True
        Me.pnproductos.BackColor = System.Drawing.SystemColors.Control
        Me.pnproductos.Location = New System.Drawing.Point(400, 124)
        Me.pnproductos.Name = "pnproductos"
        Me.pnproductos.Size = New System.Drawing.Size(332, 348)
        Me.pnproductos.TabIndex = 1
        '
        'pnventa
        '
        Me.pnventa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnventa.BackColor = System.Drawing.SystemColors.Control
        Me.pnventa.Controls.Add(Me.txtdireccion)
        Me.pnventa.Controls.Add(Me.Label9)
        Me.pnventa.Controls.Add(Me.btnAceptar)
        Me.pnventa.Controls.Add(Me.nudtotal)
        Me.pnventa.Controls.Add(Me.nuddescuento)
        Me.pnventa.Controls.Add(Me.nudimpuesto)
        Me.pnventa.Controls.Add(Me.nudsubtotal)
        Me.pnventa.Controls.Add(Me.Label8)
        Me.pnventa.Controls.Add(Me.Label7)
        Me.pnventa.Controls.Add(Me.Label6)
        Me.pnventa.Controls.Add(Me.Label5)
        Me.pnventa.Controls.Add(Me.btnconsultar)
        Me.pnventa.Controls.Add(Me.txtcliente)
        Me.pnventa.Controls.Add(Me.Label4)
        Me.pnventa.Controls.Add(Me.dgvDatos)
        Me.pnventa.Controls.Add(Me.Label3)
        Me.pnventa.Controls.Add(Me.txtdocumento)
        Me.pnventa.Controls.Add(Me.Label2)
        Me.pnventa.Location = New System.Drawing.Point(12, 12)
        Me.pnventa.Name = "pnventa"
        Me.pnventa.Size = New System.Drawing.Size(382, 460)
        Me.pnventa.TabIndex = 2
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(3, 112)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(376, 20)
        Me.txtdireccion.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "DIRECCION"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(6, 417)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(373, 32)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "Procesar Venta"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'nudtotal
        '
        Me.nudtotal.DecimalPlaces = 2
        Me.nudtotal.Location = New System.Drawing.Point(92, 392)
        Me.nudtotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudtotal.Name = "nudtotal"
        Me.nudtotal.ReadOnly = True
        Me.nudtotal.Size = New System.Drawing.Size(287, 20)
        Me.nudtotal.TabIndex = 19
        Me.nudtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nuddescuento
        '
        Me.nuddescuento.DecimalPlaces = 2
        Me.nuddescuento.Location = New System.Drawing.Point(92, 366)
        Me.nuddescuento.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nuddescuento.Name = "nuddescuento"
        Me.nuddescuento.ReadOnly = True
        Me.nuddescuento.Size = New System.Drawing.Size(287, 20)
        Me.nuddescuento.TabIndex = 18
        Me.nuddescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudimpuesto
        '
        Me.nudimpuesto.DecimalPlaces = 2
        Me.nudimpuesto.Location = New System.Drawing.Point(92, 340)
        Me.nudimpuesto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudimpuesto.Name = "nudimpuesto"
        Me.nudimpuesto.ReadOnly = True
        Me.nudimpuesto.Size = New System.Drawing.Size(287, 20)
        Me.nudimpuesto.TabIndex = 17
        Me.nudimpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudsubtotal
        '
        Me.nudsubtotal.DecimalPlaces = 2
        Me.nudsubtotal.Location = New System.Drawing.Point(92, 314)
        Me.nudsubtotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudsubtotal.Name = "nudsubtotal"
        Me.nudsubtotal.ReadOnly = True
        Me.nudsubtotal.Size = New System.Drawing.Size(287, 20)
        Me.nudsubtotal.TabIndex = 16
        Me.nudsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "IMPUESTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DESCUENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SUBTOTAL"
        '
        'btnconsultar
        '
        Me.btnconsultar.Location = New System.Drawing.Point(312, 13)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(67, 48)
        Me.btnconsultar.TabIndex = 11
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(6, 67)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(373, 20)
        Me.txtcliente.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CLIENTE"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombreProducto, Me.precioProducto, Me.cantidadProducto, Me.totalVenta})
        Me.dgvDatos.Location = New System.Drawing.Point(6, 151)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDatos.Size = New System.Drawing.Size(373, 151)
        Me.dgvDatos.TabIndex = 8
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'nombreProducto
        '
        Me.nombreProducto.HeaderText = "PRODUCTO"
        Me.nombreProducto.Name = "nombreProducto"
        Me.nombreProducto.ReadOnly = True
        '
        'precioProducto
        '
        Me.precioProducto.HeaderText = "PRECIO"
        Me.precioProducto.Name = "precioProducto"
        Me.precioProducto.ReadOnly = True
        '
        'cantidadProducto
        '
        Me.cantidadProducto.HeaderText = "CANTIDAD"
        Me.cantidadProducto.Name = "cantidadProducto"
        '
        'totalVenta
        '
        Me.totalVenta.HeaderText = "TOTAL"
        Me.totalVenta.Name = "totalVenta"
        Me.totalVenta.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRODUCTO"
        '
        'txtdocumento
        '
        Me.txtdocumento.Location = New System.Drawing.Point(6, 28)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(300, 20)
        Me.txtdocumento.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DOCUMENTO"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.Location = New System.Drawing.Point(473, 98)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(121, 20)
        Me.txtbusqueda.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PRODUCTO"
        '
        'rbprecio1
        '
        Me.rbprecio1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbprecio1.AutoSize = True
        Me.rbprecio1.Checked = True
        Me.rbprecio1.Location = New System.Drawing.Point(600, 99)
        Me.rbprecio1.Name = "rbprecio1"
        Me.rbprecio1.Size = New System.Drawing.Size(64, 17)
        Me.rbprecio1.TabIndex = 5
        Me.rbprecio1.TabStop = True
        Me.rbprecio1.Text = "Precio 1"
        Me.rbprecio1.UseVisualStyleBackColor = True
        '
        'rbprecio2
        '
        Me.rbprecio2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbprecio2.AutoSize = True
        Me.rbprecio2.Location = New System.Drawing.Point(670, 99)
        Me.rbprecio2.Name = "rbprecio2"
        Me.rbprecio2.Size = New System.Drawing.Size(64, 17)
        Me.rbprecio2.TabIndex = 6
        Me.rbprecio2.TabStop = True
        Me.rbprecio2.Text = "Precio 2"
        Me.rbprecio2.UseVisualStyleBackColor = True
        '
        'lblNombreMesa
        '
        Me.lblNombreMesa.AutoSize = True
        Me.lblNombreMesa.Location = New System.Drawing.Point(488, 12)
        Me.lblNombreMesa.Name = "lblNombreMesa"
        Me.lblNombreMesa.Size = New System.Drawing.Size(10, 13)
        Me.lblNombreMesa.TabIndex = 7
        Me.lblNombreMesa.Text = "-"
        '
        'frmPuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 484)
        Me.Controls.Add(Me.lblNombreMesa)
        Me.Controls.Add(Me.rbprecio2)
        Me.Controls.Add(Me.rbprecio1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnventa)
        Me.Controls.Add(Me.pnproductos)
        Me.Controls.Add(Me.pncategoria)
        Me.Name = "frmPuntoVenta"
        Me.Text = "frmPuntoVenta"
        Me.pnventa.ResumeLayout(False)
        Me.pnventa.PerformLayout()
        CType(Me.nudtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuddescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudimpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudsubtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pncategoria As Panel
    Friend WithEvents pnproductos As Panel
    Friend WithEvents pnventa As Panel
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnconsultar As Button
    Friend WithEvents nudtotal As NumericUpDown
    Friend WithEvents nuddescuento As NumericUpDown
    Friend WithEvents nudimpuesto As NumericUpDown
    Friend WithEvents nudsubtotal As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rbprecio1 As RadioButton
    Friend WithEvents rbprecio2 As RadioButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents precioProducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidadProducto As DataGridViewTextBoxColumn
    Friend WithEvents totalVenta As DataGridViewTextBoxColumn
    Friend WithEvents lblNombreMesa As Label
End Class

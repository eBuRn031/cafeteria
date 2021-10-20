<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosEgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaChicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblruc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblempresa = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.PersonasToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.IngresosEgresosToolStripMenuItem, Me.MesasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(602, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarDeUsuarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CambiarDeUsuarioToolStripMenuItem
        '
        Me.CambiarDeUsuarioToolStripMenuItem.Name = "CambiarDeUsuarioToolStripMenuItem"
        Me.CambiarDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem1, Me.CategoriasToolStripMenuItem, Me.UnidadesDeMedidaToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'UnidadesDeMedidaToolStripMenuItem
        '
        Me.UnidadesDeMedidaToolStripMenuItem.Name = "UnidadesDeMedidaToolStripMenuItem"
        Me.UnidadesDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UnidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'IngresosEgresosToolStripMenuItem
        '
        Me.IngresosEgresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaChicaToolStripMenuItem, Me.ReporteVentasToolStripMenuItem})
        Me.IngresosEgresosToolStripMenuItem.Name = "IngresosEgresosToolStripMenuItem"
        Me.IngresosEgresosToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.IngresosEgresosToolStripMenuItem.Text = "Ingresos/Egresos"
        '
        'CajaChicaToolStripMenuItem
        '
        Me.CajaChicaToolStripMenuItem.Name = "CajaChicaToolStripMenuItem"
        Me.CajaChicaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CajaChicaToolStripMenuItem.Text = "Caja chica"
        '
        'ReporteVentasToolStripMenuItem
        '
        Me.ReporteVentasToolStripMenuItem.Name = "ReporteVentasToolStripMenuItem"
        Me.ReporteVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReporteVentasToolStripMenuItem.Text = "Reporte Ventas"
        '
        'MesasToolStripMenuItem
        '
        Me.MesasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MesasToolStripMenuItem1, Me.EmpresaToolStripMenuItem})
        Me.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem"
        Me.MesasToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MesasToolStripMenuItem.Text = "Configuracion"
        '
        'MesasToolStripMenuItem1
        '
        Me.MesasToolStripMenuItem1.Name = "MesasToolStripMenuItem1"
        Me.MesasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MesasToolStripMenuItem1.Text = "Mesas"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_fecha.Location = New System.Drawing.Point(20, 262)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(48, 17)
        Me.lbl_fecha.TabIndex = 5
        Me.lbl_fecha.Text = "Fecha"
        '
        'lbl_hora
        '
        Me.lbl_hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Tahoma", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.Black
        Me.lbl_hora.Location = New System.Drawing.Point(12, 188)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(187, 65)
        Me.lbl_hora.TabIndex = 4
        Me.lbl_hora.Text = "HORA"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobantesPedidosToolStripMenuItem})
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ComprobantesToolStripMenuItem.Text = "Comprobantes"
        '
        'ComprobantesPedidosToolStripMenuItem
        '
        Me.ComprobantesPedidosToolStripMenuItem.Name = "ComprobantesPedidosToolStripMenuItem"
        Me.ComprobantesPedidosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ComprobantesPedidosToolStripMenuItem.Text = "Comprobantes/Pedidos"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblUsuario.Location = New System.Drawing.Point(183, 98)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(16, 19)
        Me.LblUsuario.TabIndex = 8
        Me.LblUsuario.Text = "-"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.ForeColor = System.Drawing.Color.Black
        Me.lbltipo.Location = New System.Drawing.Point(183, 129)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(16, 19)
        Me.lbltipo.TabIndex = 9
        Me.lbltipo.Text = "-"
        '
        'lblruc
        '
        Me.lblruc.AutoSize = True
        Me.lblruc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruc.ForeColor = System.Drawing.Color.Black
        Me.lblruc.Location = New System.Drawing.Point(183, 41)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(16, 19)
        Me.lblruc.TabIndex = 10
        Me.lblruc.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RUC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bienvenido usuario"
        '
        'lblempresa
        '
        Me.lblempresa.AutoSize = True
        Me.lblempresa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempresa.ForeColor = System.Drawing.Color.Black
        Me.lblempresa.Location = New System.Drawing.Point(183, 70)
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Size = New System.Drawing.Size(16, 19)
        Me.lblempresa.TabIndex = 15
        Me.lblempresa.Text = "-"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 289)
        Me.Controls.Add(Me.lblempresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblruc)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadesDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosEgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaChicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComprobantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobantesPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblUsuario As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblruc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblempresa As Label
End Class

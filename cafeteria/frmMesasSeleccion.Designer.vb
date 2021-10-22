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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.btnturno = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btncomprobantes = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnMesas
        '
        Me.pnMesas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnMesas.AutoScroll = True
        Me.pnMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnMesas.Location = New System.Drawing.Point(12, 136)
        Me.pnMesas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnMesas.Name = "pnMesas"
        Me.pnMesas.Size = New System.Drawing.Size(607, 267)
        Me.pnMesas.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Controls.Add(Me.lbltipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 95)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Bienvenido"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblUsuario.Location = New System.Drawing.Point(96, 30)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(12, 13)
        Me.LblUsuario.TabIndex = 15
        Me.LblUsuario.Text = "-"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.ForeColor = System.Drawing.Color.Black
        Me.lbltipo.Location = New System.Drawing.Point(96, 61)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(12, 13)
        Me.lbltipo.TabIndex = 16
        Me.lbltipo.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.btnturno)
        Me.GroupBox2.Controls.Add(Me.btnclientes)
        Me.GroupBox2.Controls.Add(Me.btncomprobantes)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 95)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnreporte
        '
        Me.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreporte.Image = Global.cafeteria.My.Resources.Resources._379342_increase_money_icon
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnreporte.Location = New System.Drawing.Point(264, 16)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(80, 73)
        Me.btnreporte.TabIndex = 22
        Me.btnreporte.Text = "Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreporte.UseVisualStyleBackColor = True
        '
        'btnturno
        '
        Me.btnturno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnturno.Image = Global.cafeteria.My.Resources.Resources._2824441_clock_stopwatch_time_timer_icon
        Me.btnturno.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnturno.Location = New System.Drawing.Point(178, 16)
        Me.btnturno.Name = "btnturno"
        Me.btnturno.Size = New System.Drawing.Size(80, 73)
        Me.btnturno.TabIndex = 21
        Me.btnturno.Text = "Turno"
        Me.btnturno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnturno.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclientes.Image = Global.cafeteria.My.Resources.Resources._4714992_avatar_man_people_person_profile_icon
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclientes.Location = New System.Drawing.Point(92, 16)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(80, 73)
        Me.btnclientes.TabIndex = 20
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btncomprobantes
        '
        Me.btncomprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncomprobantes.Image = Global.cafeteria.My.Resources.Resources._39263_print_printer_icon
        Me.btncomprobantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncomprobantes.Location = New System.Drawing.Point(6, 16)
        Me.btncomprobantes.Name = "btncomprobantes"
        Me.btncomprobantes.Size = New System.Drawing.Size(80, 73)
        Me.btncomprobantes.TabIndex = 19
        Me.btncomprobantes.Text = "Reimprimir"
        Me.btncomprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncomprobantes.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SsToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.InicioToolStripMenuItem.Text = "Login"
        '
        'SsToolStripMenuItem
        '
        Me.SsToolStripMenuItem.Name = "SsToolStripMenuItem"
        Me.SsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SsToolStripMenuItem.Text = "Cambiar de Usuario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmMesasSeleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(631, 416)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnMesas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMesasSeleccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA CAFETERIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnMesas As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btncomprobantes As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnclientes As Button
    Friend WithEvents btnturno As Button
    Friend WithEvents btnreporte As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class

Public Class frmPrincipal
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = Date.Now.ToLongTimeString
        lbl_fecha.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblruc.Text = "RUC : " & _ruc_empresa
        lblempresa.Text = " EMPRESA : " & _razon_social
        LblUsuario.Text = _nombreusuario
        If _tipoUsuario = "A" Then lbltipo.Text = "Administrador" Else lbltipo.Text = "Vendedor"
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CambiarDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click
        Dim f As New frmLogin
        f.Show()
        Me.Close()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim f As New frmProductosVista
        f.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim f As New frmCategoriasVista
        f.ShowDialog()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        Dim f As New frmUnidadMedidaVista
        f.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim f As New frmPersonasVista
        f.ShowDialog()
    End Sub

    Private Sub ComprobantesPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobantesPedidosToolStripMenuItem.Click
        Dim f As New frmComprobantes
        f.ShowDialog()
    End Sub

    Private Sub CajaChicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaChicaToolStripMenuItem.Click
        Dim f As New frmCajaChicaVista
        f.ShowDialog()
    End Sub

    Private Sub ReporteVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasToolStripMenuItem.Click
        MsgBox("Seguimos trabajando ...")
    End Sub

    Private Sub MesasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MesasToolStripMenuItem1.Click
        Dim f As New frmMesasVista
        f.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim f As New frmEmpresa
        f.ShowDialog()
    End Sub

End Class
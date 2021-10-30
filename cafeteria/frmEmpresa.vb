Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmEmpresa
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cf As New Transaccion_empresa
        If cf.SP_empresa(New CE_empresa With {.Tipo = 2,
                         .idempresa = 1,
                         .ruc = txtruc.Text,
                         .razonsocial = txtrazonsocial.Text,
                         .titulo = txttitulo.Text,
                         .direccion = txtdireccion.Text,
                         .telefono = txttelefono.Text,
                         .correo = txtcorreo.Text,
                         .paginaweb = txtpaginaweb.Text,
                         .ubigeo = txtubigeo.Text,
                         .piepagina = txtpiepagina.Text}) Then MsgBox("Datos Actualizados! Debe de reiniciar el soft para aplicar los cambios realizados.") Else MsgBox("Error al actualizar")
    End Sub

    Sub cargarEmpresa()
        Try
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable
            dt = cf.DT_leer(New CE_dgv With {.Tipo = 28})
            txtruc.Text = dt.Rows(0).Item("ruc")
            txtrazonsocial.Text = dt.Rows(0).Item("razonsocial")
            txttitulo.Text = dt.Rows(0).Item("titulo")
            txtdireccion.Text = dt.Rows(0).Item("direccion")
            txttelefono.Text = dt.Rows(0).Item("telefono")
            txtcorreo.Text = dt.Rows(0).Item("correo")
            txtpaginaweb.Text = dt.Rows(0).Item("paginaweb")
            txtubigeo.Text = dt.Rows(0).Item("ubigeo")
            txtpiepagina.Text = dt.Rows(0).Item("piepagina")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarPrincipal()
        Me.TopMost = True
        cargarEmpresa()
    End Sub
    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mostrarPrincipal()
    End Sub
End Class
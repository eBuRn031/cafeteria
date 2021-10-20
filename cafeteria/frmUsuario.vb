Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Public Class frmUsuario
    Dim idusuario, idpersonas As Integer

    Public Sub New(ByVal _idpersonas As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        idpersonas = _idpersonas
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_usuarios
        Select Case idusuario
            Case 0
                If cd.SP_usuarios(New CE_usuarios With {.TipoAccion = 1, .idpersonas = idpersonas, .user = txtusuario.Text, .password = txtpassword.Text, .perfil = txtperfil.Text, .tipo = cbtipo.SelectedValue, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
            Case Else
                If cd.SP_usuarios(New CE_usuarios With {.TipoAccion = 2, .idpersonas = idpersonas, .user = txtusuario.Text, .password = txtpassword.Text, .perfil = txtperfil.Text, .tipo = cbtipo.SelectedValue, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmPersonasVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            idusuario = 0
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 6, .Codigo_1 = idpersonas})
            txtdni.Text = dt.Rows(0).Item("dni")
            txtnombres.Text = dt.Rows(0).Item("nombre")
            txtapellidos.Text = dt.Rows(0).Item("apellidos")
            txtperfil.Text = dt.Rows(0).Item("nombre")

            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 7, .Codigo_1 = idpersonas})

            If dt.Rows.Count > 0 Then
                idusuario = dt.Rows(0).Item("idusuarios")
                txtusuario.Text = dt.Rows(0).Item("user")
                txtpassword.Text = dt.Rows(0).Item("password")
                txtperfil.Text = dt.Rows(0).Item("perfil")
                cbtipo.SelectedValue = dt.Rows(0).Item("tipo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("id") = "V"
        dr("nombre") = "Vendedor"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "A"
        dr("nombre") = "Administrador"
        dt.Rows.Add(dr)

        cbtipo.DataSource = dt
        cbtipo.ValueMember = "id"
        cbtipo.DisplayMember = "nombre"

        cbtipo.SelectedIndex = 0
        cargarDatosConsulta()
    End Sub

End Class
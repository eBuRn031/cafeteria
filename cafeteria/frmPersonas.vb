Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmPersonas
    Dim id As Integer

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_personas
        Select Case id
            Case 0
                If cd.SP_personas(New CE_personas With {.Tipo = 1, .dni = txtdni.Text, .nombre = txtnombres.Text, .apellidos = txtapellidos.Text, .celular = txtcelular.Text, .correo = txtcorreo.Text, .direccion = txtdireccion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
            Case Else
                If cd.SP_personas(New CE_personas With {.Tipo = 2, .idpersonas = id, .dni = txtdni.Text, .nombre = txtnombres.Text, .apellidos = txtapellidos.Text, .celular = txtcelular.Text, .correo = txtcorreo.Text, .direccion = txtdireccion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
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
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 6, .Codigo_1 = id})
            txtdni.Text = dt.Rows(0).Item("dni")
            txtnombres.Text = dt.Rows(0).Item("nombre")
            txtapellidos.Text = dt.Rows(0).Item("apellidos")
            txtcelular.Text = dt.Rows(0).Item("celular")
            txtcorreo.Text = dt.Rows(0).Item("correo")
            txtdireccion.Text = dt.Rows(0).Item("direccion")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub

End Class
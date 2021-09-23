Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmUnidadMedida
    Dim id As String

    Public Sub New(ByVal _id As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_unidadmedida
        Select Case id.Length
            Case 0
                If cd.SP_unidadmedida(New CE_unidadmedida With {.Tipo = 1, .idunidadmedida = txtcodigo.Text, .nombre = txtunidadmedida.Text}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar Categoria")
            Case Else
                If cd.SP_unidadmedida(New CE_unidadmedida With {.Tipo = 2, .idunidadmedida = id, .nombre = txtunidadmedida.Text}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar Categoria")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmUnidadMedidaVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 4, .Codigo_1 = id})
            txtcodigo.Text = id
            txtcodigo.Enabled = False
            txtunidadmedida.Text = dt.Rows(0).Item("nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id.Length <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub
End Class
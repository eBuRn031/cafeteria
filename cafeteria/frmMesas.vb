Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Public Class frmMesas
    Dim id As Integer

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_mesa
        Select Case id
            Case 0
                If cd.SP_mesa(New CE_mesa With {.Tipo = 1, .nombre = txtnombre.Text, .descripcion = txtdescripcion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
            Case Else
                If cd.SP_mesa(New CE_mesa With {.Tipo = 2, .idmesa = id, .nombre = txtnombre.Text, .descripcion = txtdescripcion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmMesasVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 11, .Codigo_1 = id})
            txtnombre.Text = dt.Rows(0).Item("nombre")
            txtdescripcion.Text = dt.Rows(0).Item("descripcion")
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
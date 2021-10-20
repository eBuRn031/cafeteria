Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmCategoria

    Dim id As Integer

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_categoria
        Select Case id
            Case 0
                If cd.SP_categoria(New CE_categoria With {.Tipo = 1, .nombre = txtcategoria.Text}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar Categoria")
            Case Else
                If cd.SP_categoria(New CE_categoria With {.Tipo = 2, .idcategoria = id, .nombre = txtcategoria.Text}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar Categoria")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmCategoriasVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 2, .Codigo_1 = id})
            txtcategoria.Text = dt.Rows(0).Item("nombre")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If id <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub

End Class
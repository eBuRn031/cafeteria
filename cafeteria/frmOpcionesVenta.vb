Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Imports System.Linq

Public Class frmOpcionesVenta
    Private id As Integer
    Private nombreMesa As String

    Sub New(_id As Integer, _nombreMesa As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
        nombreMesa = _nombreMesa
    End Sub

    Private Sub btnNuevoPedido_Click(sender As Object, e As EventArgs) Handles btnNuevoPedido.Click
        Dim dts As New DataTable
        Dim cf As New Transaccion_lectura
        Dim dtNew As New DataTable
        Dim rows As DataRow()
        dts = cf.DT_leer(New CE_dgv With {.Tipo = 15})
        dtNew = New DataTable
        dtNew = dts.Clone()
        rows = dts.Select("idmesa = '" & id & "'")
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        If dtNew.Rows.Count > 0 Then
            If MsgBox("La mesa seleccionada ya tiene una orden pendiente, ¿desea cancelarlo y crear una nueva orden?", MsgBoxStyle.OkCancel, "Advertencia") = MsgBoxResult.Ok Then
                Dim cx As New Transaccion_pedido
                If cx.SP_pedido(New CE_pedido With {.Tipo = 6, .idmesa = id, .estado = 0}) Then
                    MsgBox("Pedido(s) anulados correctamente")
                End If
            End If
        End If

        Dim frm As New frmPuntoVenta(id, nombreMesa)
        frm.Show()
        cerrarPrincipal()
    End Sub

    Private Sub btnCanjearComprobante_Click(sender As Object, e As EventArgs) Handles btnCanjearComprobante.Click
        Dim dts As New DataTable
        Dim cf As New Transaccion_lectura
        Dim dtNew As New DataTable
        Dim rows As DataRow()
        dts = cf.DT_leer(New CE_dgv With {.Tipo = 15})
        dtNew = New DataTable
        dtNew = dts.Clone()
        rows = dts.Select("idmesa = '" & id & "'")
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        If dtNew.Rows.Count = 0 Or dtNew.Rows.Count = Nothing Then
            MsgBox("La mesa seleccionada no tiene una orden pendiente, cree una")
            Exit Sub
        End If
        Dim frm As New frmCanjeComprobante(id, nombreMesa)
        frm.Show()
        cerrarPrincipal()
    End Sub

    Sub cerrarPrincipal()
        Dim frmCollection As New FormCollection()
        frmCollection = Application.OpenForms()
        If frmCollection.Item("frmMesasSeleccion").IsHandleCreated Then
            Dim frmx As Form = frmCollection.Item("frmMesasSeleccion")
            frmx.Close()
        End If
        Me.Close()
    End Sub


End Class
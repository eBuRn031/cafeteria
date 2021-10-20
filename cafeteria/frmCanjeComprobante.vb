Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmCanjeComprobante
    Private id As Integer
    Private nombremesa As String
    Private dtpedidos As New DataTable
    Private persona As New CE_personas
    Private comprobantes As New CE_ventas
    Private detalle As New List(Of CE_detalleventas)
    Public form_apertura As Integer

    'Public Sub cargar_datos(p As CE_personas, ByVal c As CE_ventas, ByVal d As List(Of CE_detalleventas))
    '    persona = p
    '    comprobantes = c
    '    detalle = d
    'End Sub

    Sub New(_id As Integer, _nombremesa As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
        nombremesa = _nombremesa
    End Sub

    Private Sub Impresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        cargarcombo()
        lblmesa.Text = nombremesa
        lblusuario.Text = _nombreusuario
    End Sub

    Sub cargarcombo()
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("id") = "03"
        dr("nombre") = "BOLETA"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "01"
        dr("nombre") = "FACTURA"
        dt.Rows.Add(dr)

        cbTipoComprobante.DataSource = dt
        cbTipoComprobante.ValueMember = "id"
        cbTipoComprobante.DisplayMember = "nombre"

        cbTipoComprobante.SelectedIndex = 0


        Dim dtx As New DataTable
        dtx.Columns.Add("id")
        dtx.Columns.Add("nombre")

        Dim drx As DataRow

        drx = dtx.NewRow()
        drx("id") = "E"
        drx("nombre") = "EFECTIVO"
        dtx.Rows.Add(drx)

        drx = dtx.NewRow()
        drx("id") = "Q"
        drx("nombre") = "PAGO QR"
        dtx.Rows.Add(drx)

        cbpago.DataSource = dtx
        cbpago.ValueMember = "id"
        cbpago.DisplayMember = "nombre"

        cbpago.SelectedIndex = 0
    End Sub

    Sub cargarSerie(_idtipocomprobante As String)
        Try
            cbSerie.DataSource = Nothing

            Dim dt As New DataTable
            dt.Columns.Add("id")
            dt.Columns.Add("nombre")

            Dim dr As DataRow
            If _idtipocomprobante = "03" Then
                dr = dt.NewRow()
                dr("id") = "11"
                dr("nombre") = "B001"
                dt.Rows.Add(dr)
            ElseIf _idtipocomprobante = "01" Then
                dr = dt.NewRow()
                dr("id") = "22"
                dr("nombre") = "F001"
                dt.Rows.Add(dr)
            Else
                Exit Sub
            End If

            cbSerie.DataSource = dt
            cbSerie.ValueMember = "id"
            cbSerie.DisplayMember = "nombre"
            cbSerie.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub AgregarFilasDGV(ByVal dgv As DataGridView, ByVal dt As DataTable)
        Try
            AgregarColumnasDGV(dgv)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgv.Rows.Add(dt.Rows(i).Item("idpedido"), dt.Rows(i).Item("nombre"), dt.Rows(i).Item("total"))
                Next
            End If

            Dim colComprobante As New DataGridViewButtonColumn()
            Dim colEliminar As New DataGridViewButtonColumn()
            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Text = "Eliminar"
            colEliminar.UseColumnTextForButtonValue = True

            colComprobante.Name = "colComprobante"
            colComprobante.HeaderText = "COMPROBANTE"
            colComprobante.Text = "Canjear"
            colComprobante.UseColumnTextForButtonValue = True

            dgv.Columns.Add(colEliminar)
            dgv.Columns.Add(colComprobante)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CargarDatos()
        Try
            If dgvDatos.DataSource IsNot Nothing Then
                dgvDatos.DataSource = Nothing
            End If
            Dim cd As New Transaccion_lectura
            dtpedidos = New DataTable
            dtpedidos = cd.DT_leer(New CE_dgv With {.Tipo = 20, .Codigo_1 = id})
            AgregarFilasDGV(dgvDatos, dtpedidos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarColumnasDGV(ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            dgv.Columns.Clear()
            dgv.Columns.Add("id", "id")
            dgv.Columns.Add("nombre", "CLIENTE")
            dgv.Columns.Add("total", "IMPORTE")
            dgv.Columns("id").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Select Case sender.COLUMNS(e.ColumnIndex).NAME
                Case "colEliminar"
                    If MsgBox("¿Desea eliminar el pedido de " & sender.ROWS(e.RowIndex).CELLS("nombre").value & " con el monto " & sender.ROWS(e.RowIndex).CELLS("total").value & "?", MsgBoxResult.Ok, "Advertencia") = MsgBoxResult.Ok Then
                        PedidoAnulado(sender.ROWS(e.RowIndex).CELLS("id").value)
                        CargarDatos()
                    End If
                Case "colComprobante"
                    If MsgBox("¿Desea convertir a una " & cbTipoComprobante.Text & " el pedido de " & sender.ROWS(e.RowIndex).CELLS("nombre").value & " con el monto " & sender.ROWS(e.RowIndex).CELLS("total").value & "?", MsgBoxResult.Ok, "Advertencia") = MsgBoxResult.Ok Then
                        ventaProcesada(sender.ROWS(e.RowIndex).CELLS("id").value)
                        CargarDatos()
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub PedidoAnulado(_idpedido As Integer)
        Try
            Dim ce_pedido As New CE_pedido
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable

            dt = cf.DT_leer(New CE_dgv With {.Tipo = 21, .Codigo_1 = _idpedido})

            ce_pedido = New CE_pedido
            ce_pedido.Tipo = 7
            ce_pedido.idpedido = _idpedido
            ce_pedido.estado = 0


            Dim listaCe_ProductosStock As New List(Of CE_productostock)

            For i = 0 To dt.Rows.Count - 1
                Dim cex As New CE_productostock
                cex.Tipo = 6
                cex.idproducto = dt.Rows(0).Item("producto_idproducto")
                cex.idusuarios = _idusuario
                cex.fechahora = Now()
                cex.entrada = dt.Rows(0).Item("cantidad")
                cex.salida = 0
                cex.total = 0
                cex.comentario = "Anulación de pedido mesa " & nombremesa
                listaCe_ProductosStock.Add(cex)
            Next

            Dim cx As New Transaccion_pedido
            If cx.SP_pedidoAnulado(ce_pedido, listaCe_ProductosStock) Then
                MsgBox("Registro Eliminado")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ventaProcesada(_idpedido As Integer)
        Try
            Dim ce_pedido As New CE_pedido
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable

            dt = cf.DT_leer(New CE_dgv With {.Tipo = 21, .Codigo_1 = _idpedido})

            ce_pedido = New CE_pedido
            ce_pedido.Tipo = 7
            ce_pedido.idpedido = _idpedido
            ce_pedido.estado = 2

            persona = New CE_personas
            persona.dni = dt.Rows(0).Item("dni")
            persona.nombre = dt.Rows(0).Item("nombre")
            persona.apellidos = dt.Rows(0).Item("apellidos")
            persona.direccion = dt.Rows(0).Item("direccion")

            comprobantes = New CE_ventas
            comprobantes.Tipo = 4
            comprobantes.idpedido = _idpedido
            comprobantes.idusuarios = _idusuario
            comprobantes.idpersonas = dt.Rows(0).Item("idpersonas")
            comprobantes.tipocomprobante = cbTipoComprobante.SelectedValue
            comprobantes.fechahora = Now()
            comprobantes.serie = cbSerie.Text
            comprobantes.numero = 1
            comprobantes.subtotal = dt.Rows(0).Item("total")
            comprobantes.igv = 0
            comprobantes.descuento = 0
            comprobantes.total = dt.Rows(0).Item("total")
            comprobantes.estado = 1

            Dim listaCe_ProductosStock As New List(Of CE_productostock)
            detalle = New List(Of CE_detalleventas)

            For i = 0 To dt.Rows.Count - 1
                Dim ce As New CE_detalleventas
                ce.Tipo = 1
                ce.ventas_idventas = 1
                ce.producto_idproducto = dt.Rows(0).Item("producto_idproducto")
                ce.cantidad = dt.Rows(0).Item("cantidad")
                ce.precio = dt.Rows(0).Item("precio")
                ce.total = dt.Rows(0).Item("total")
                detalle.Add(ce)

                Dim cex As New CE_productostock
                cex.Tipo = 1
                cex.idproducto = dt.Rows(0).Item("producto_idproducto")
                cex.idusuarios = _idusuario
                cex.fechahora = Now()
                cex.entrada = 0
                cex.salida = dt.Rows(0).Item("cantidad")
                cex.total = 0
                cex.comentario = "Venta mesa " & nombremesa
                listaCe_ProductosStock.Add(cex)
            Next

            Dim cef As New CE_dinero
            cef.Tipo = 1
            cef.idusuarios = _idusuario
            cef.idventas = 1
            cef.compraventa = "V"
            cef.fechahora = Now()
            cef.tipopago = cbpago.SelectedValue
            cef.monto = dt.Rows(0).Item("total")

            Dim cx As New Transaccion_ventas
            If cx.SP_CanjeVentas(ce_pedido, comprobantes, detalle, cef) Then
                Dim f As New FrmImpresiones
                f.cargar_datosComprobante("Mesa01", persona, comprobantes, detalle)
                f.PPC_MUESTRA.Document = f.PD_TICKETS
                f.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoComprobante.SelectedIndexChanged
        Try
            cargarSerie(cbTipoComprobante.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmMesasSeleccion
        frm.Show()
    End Sub


End Class
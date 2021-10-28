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
    Public idform As Integer

    Sub New(_id As Integer, _nombremesa As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
        nombremesa = _nombremesa
    End Sub

    Private Sub Impresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_grilla(dgvDatos)
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
        Cargar_Combobox_General(cbTipoComprobante, dt, "nombre", "id")
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
        Cargar_Combobox_General(cbpago, dtx, "nombre", "id")
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
            Cargar_Combobox_General(cbSerie, dt, "nombre", "id")
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

            Dim colEditar As New DataGridViewImageColumn()
            Dim colComprobante As New DataGridViewImageColumn()
            Dim colEliminar As New DataGridViewImageColumn()

            colEditar.Name = "colEditar"
            colEditar.HeaderText = "EDITAR"
            colEditar.Image = My.Resources.editicon
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom

            colComprobante.Name = "colComprobante"
            colComprobante.HeaderText = "COMPROBANTE"
            colComprobante.Image = My.Resources._5027832_document_file_page_paper_icon
            colComprobante.ImageLayout = DataGridViewImageCellLayout.Zoom

            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Image = My.Resources.deleteicon
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom

            dgv.Columns.Add(colEditar)
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
                Case "colEditar"
                    If MsgBox("¿Desea editar el pedido de " & sender.ROWS(e.RowIndex).CELLS("nombre").value & " con el monto " & sender.ROWS(e.RowIndex).CELLS("total").value & "?", MsgBoxResult.Ok, "Advertencia") = MsgBoxResult.Ok Then
                        idform = 1
                        Dim frm As New frmPuntoVenta(1, "")
                        frm.Show()
                        frm.cargarDatosPedido(sender.ROWS(e.RowIndex).CELLS("id").value)
                        Me.Close()
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
                ce.producto_idproducto = dt.Rows(i).Item("producto_idproducto")
                ce.cantidad = dt.Rows(i).Item("cantidad")
                ce.precio = dt.Rows(i).Item("precio")
                ce.total = dt.Rows(i).Item("total")
                detalle.Add(ce)

                Dim cex As New CE_productostock
                cex.Tipo = 1
                cex.idproducto = dt.Rows(i).Item("producto_idproducto")
                cex.idusuarios = _idusuario
                cex.fechahora = Now()
                cex.entrada = 0
                cex.salida = dt.Rows(i).Item("cantidad")
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

    Private Sub cbTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoComprobante.SelectedValueChanged
        Try
            cargarSerie(cbTipoComprobante.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If idform <> 1 Then
            Dim frm As New frmMesasSeleccion
            frm.Show()
        End If
    End Sub

    Private Sub DgvCajas_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDatos.RowPostPaint
        Try
            Dim NumeroFila As String = (e.RowIndex + 1).ToString 'Obtiene el número de filas
            While NumeroFila.Length < sender.RowCount.ToString.Length
                NumeroFila = "0" & NumeroFila 'Agrega un cero a los que tienen un dígito menos
            End While
            Dim size As SizeF = e.Graphics.MeasureString(NumeroFila, Me.Font)
            If sender.RowHeadersWidth < CInt(size.Width + 20) Then
                sender.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim Obj As Brush = SystemBrushes.ControlText
            'Dibuja el número dentro del controltext
            e.Graphics.DrawString(NumeroFila, Me.Font, Obj, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub dgvDatos_CellMouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellMouseEnter
        If e.RowIndex >= 0 Then
            sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    Private Sub dgvDatos_CellMouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDatos.CellMouseLeave
        If e.RowIndex >= 0 Then
            Dim fila As Integer = e.RowIndex + 1
            If fila Mod 2 = 0 Then
                sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = colorAlternado
            Else
                sender.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

End Class
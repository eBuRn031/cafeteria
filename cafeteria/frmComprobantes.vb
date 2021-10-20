Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmComprobantes
    Dim dtcomprobantes As New DataTable

    Private Sub frmCategoriasVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombobox()
        CargarDatos()
    End Sub

    Sub CargarDatos()
        Try
            If dgvDatos.DataSource IsNot Nothing Then
                dgvDatos.DataSource = Nothing
            End If
            Dim cd As New Transaccion_lectura
            dtcomprobantes = New DataTable
            Select Case cbTipo.SelectedValue
                Case "01"
                    dtcomprobantes = cd.DT_leer(New CE_dgv With {.Tipo = 22, .Codigo_1 = Convert.ToDateTime(dtpFecha.Value).ToString("yyyy-MM-dd")})
                Case "02"
                    dtcomprobantes = cd.DT_leer(New CE_dgv With {.Tipo = 23, .Codigo_1 = Convert.ToDateTime(dtpFecha.Value).ToString("yyyy-MM-dd")})
            End Select
            AgregarFilasDGV(dgvDatos, dtcomprobantes)
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarFilasDGV(ByVal dgv As DataGridView, ByVal dt As DataTable)
        Try
            AgregarColumnasDGV(dgv)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    Select Case cbTipo.SelectedValue
                        Case "01"
                            dgv.Rows.Add(dt.Rows(i).Item("idventas"), dt.Rows(i).Item("idpersonas"), dt.Rows(i).Item("idmesa"), dt.Rows(i).Item("tipocomprobante"), dt.Rows(i).Item("fechahora"), dt.Rows(i).Item("cliente"), dt.Rows(i).Item("SerieNumero"), dt.Rows(i).Item("total"), dt.Rows(i).Item("estado"))
                        Case "02"
                            dgv.Rows.Add(dt.Rows(i).Item("idpedido"), dt.Rows(i).Item("idpersonas"), dt.Rows(i).Item("idmesa"), dt.Rows(i).Item("tipocomprobante"), dt.Rows(i).Item("fechahora"), dt.Rows(i).Item("cliente"), dt.Rows(i).Item("SerieNumero"), dt.Rows(i).Item("total"), dt.Rows(i).Item("estado"))
                    End Select
                Next
            End If
            Dim colImprimir As New DataGridViewButtonColumn()
            Dim colEliminar As New DataGridViewButtonColumn()

            colImprimir.Name = "colImprimir"
            colImprimir.HeaderText = "Imprimir"
            colImprimir.Text = "Imprimir"
            colImprimir.UseColumnTextForButtonValue = True
            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Text = "Eliminar"
            colEliminar.UseColumnTextForButtonValue = True

            dgv.Columns.Add(colImprimir)
            dgv.Columns.Add(colEliminar)

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarColumnasDGV(ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            dgv.Columns.Clear()
            dgv.Columns.Add("id", "id")
            dgv.Columns.Add("idpersona", "idpersona")
            dgv.Columns.Add("idmesa", "idemesa")
            dgv.Columns.Add("comprobante", "TIPO")
            dgv.Columns.Add("fechahora", "FECHA HORA")
            dgv.Columns.Add("cliente", "CLIENTE")
            dgv.Columns.Add("serienumero", "SERIENUMERO")
            dgv.Columns.Add("total", "TOTAL")
            dgv.Columns.Add("estado", "ESTADO")
            dgv.Columns("id").Visible = False
            dgv.Columns("idpersona").Visible = False
            dgv.Columns("idmesa").Visible = False
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Select Case sender.COLUMNS(e.ColumnIndex).NAME
                Case "colImprimir"

                    Select Case cbTipo.SelectedValue
                        Case "01"
                            Dim cf As New Transaccion_lectura
                            Dim dtx As New DataTable
                            dtx = cf.DT_leer(New CE_dgv With {.Tipo = 24, .Codigo_1 = sender.ROWS(e.RowIndex).CELLS("id").value})

                            Dim ce_p As New CE_personas
                            Dim ce_v As New CE_ventas
                            Dim ce_d As New List(Of CE_detalleventas)

                            If dtx.Rows.Count > 0 Then
                                ce_p.dni = dtx.Rows(0).Item("dni")
                                ce_p.nombre = dtx.Rows(0).Item("nombre")
                                ce_p.apellidos = dtx.Rows(0).Item("apellidos")
                                ce_p.direccion = dtx.Rows(0).Item("direccion")

                                ce_v.idusuarios = dtx.Rows(0).Item("idusuarios")
                                ce_v.tipocomprobante = dtx.Rows(0).Item("tipocomprobante")
                                ce_v.fechahora = dtx.Rows(0).Item("fechahora")
                                ce_v.serie = dtx.Rows(0).Item("serie")
                                ce_v.numero = dtx.Rows(0).Item("numero")
                                ce_v.subtotal = dtx.Rows(0).Item("subtotal")
                                ce_v.igv = dtx.Rows(0).Item("igv")
                                ce_v.descuento = dtx.Rows(0).Item("descuento")
                                ce_v.total = dtx.Rows(0).Item("TotalV")

                                For i = 0 To dtx.Rows.Count - 1
                                    Dim d As New CE_detalleventas
                                    d.producto_idproducto = dtx.Rows(i).Item("producto_idproducto")
                                    d.cantidad = dtx.Rows(i).Item("cantidad")
                                    d.precio = dtx.Rows(i).Item("precio")
                                    d.total = dtx.Rows(i).Item("TotalD")
                                    ce_d.Add(d)
                                Next

                            End If

                            Dim f As New FrmImpresiones
                            f.cargar_datosComprobante("Mesa01", ce_p, ce_v, ce_d)
                            f.PPC_MUESTRA.Document = f.PD_TICKETS
                            f.Show()

                        Case "02"
                            Dim cf As New Transaccion_lectura
                            Dim dtx As New DataTable
                            dtx = cf.DT_leer(New CE_dgv With {.Tipo = 25, .Codigo_1 = sender.ROWS(e.RowIndex).CELLS("id").value})

                            Dim mesa As String
                            Dim ce_p As New CE_personas
                            Dim ce_v As New CE_pedido
                            Dim ce_d As New List(Of CE_detallepedido)

                            If dtx.Rows.Count > 0 Then
                                mesa = dtx.Rows(0).Item("mesa")

                                ce_p.dni = dtx.Rows(0).Item("dni")
                                ce_p.nombre = dtx.Rows(0).Item("cliente")
                                ce_p.apellidos = dtx.Rows(0).Item("apellidos")
                                ce_p.direccion = dtx.Rows(0).Item("direccion")

                                ce_v.idusuarios = dtx.Rows(0).Item("idusuarios")
                                ce_v.fechahora = dtx.Rows(0).Item("fechahora")
                                ce_v.numero = dtx.Rows(0).Item("numero")
                                ce_v.total = dtx.Rows(0).Item("TotalV")

                                For i = 0 To dtx.Rows.Count - 1
                                    Dim d As New CE_detallepedido
                                    d.producto_idproducto = dtx.Rows(i).Item("producto_idproducto")
                                    d.cantidad = dtx.Rows(i).Item("cantidad")
                                    d.precio = dtx.Rows(i).Item("precio")
                                    d.total = dtx.Rows(i).Item("TotalD")
                                    ce_d.Add(d)
                                Next

                            End If

                            Dim f As New FrmImpresiones
                            f.cargar_datosPedido(mesa, ce_p, ce_v, ce_d)
                            f.PPC_MUESTRA.Document = f.PD_OrdenVenta
                            f.Show()
                    End Select

                Case "colEliminar"
                    MsgBox("Aqui eliminamos el comprobante .... seguimos trabajando")
            End Select
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusquedaProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        ' creamos un array
        Dim rows As DataRow()

        ' creamos donde almacenaremos la consulta sin editar el dt_cliente
        Dim dtNew As DataTable

        ' copiamos la estructura al nuevo dt
        dtNew = dtcomprobantes.Clone()

        ' realizamos la consulta con select
        rows = dtcomprobantes.Select("SerieNumero like '%" & sender.Text & "%' Or cliente Like '%" & sender.Text & "%'")

        ' recorremos la consulta dada y agregamos sus valores al nuevo dt creado(dtNew)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        ' enviamos para que llene el datagridview
        AgregarFilasDGV(dgvDatos, dtNew)
    End Sub

    Sub cargarCombobox()
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("id") = "01"
        dr("nombre") = "Comprobantes"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "02"
        dr("nombre") = "Pedidos"
        dt.Rows.Add(dr)

        cbTipo.DataSource = dt
        cbTipo.ValueMember = "id"
        cbTipo.DisplayMember = "nombre"

        cbTipo.SelectedIndex = 0
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Try
            CargarDatos()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Try
            CargarDatos()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

End Class
Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmComprobantes
    Dim dtcomprobantes As New DataTable

    Private Sub frmCategoriasVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarPrincipal()
        style_grilla(dgvDatos)
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
                Case "01" 'comprobantes
                    dtcomprobantes = cd.DT_leer(New CE_dgv With {.Tipo = 22, .Codigo_1 = Convert.ToDateTime(dtpFecha.Value).ToString("yyyy-MM-dd")})
                Case "02" 'pedidos
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
            Dim colImprimir As New DataGridViewImageColumn()
            Dim colEliminar As New DataGridViewImageColumn()

            colImprimir.Name = "colImprimir"
            colImprimir.HeaderText = "IMPRIMIR"
            colImprimir.Image = My.Resources._39263_print_printer_icon
            colImprimir.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgv.Columns.Add(colImprimir)

            If _tipoUsuario = "A" Then
                colEliminar.Name = "colEliminar"
                colEliminar.HeaderText = "ELIMINAR"
                colEliminar.Image = My.Resources.deleteicon
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom
                dgv.Columns.Add(colEliminar)
            End If
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
            dgv.Columns("cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
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
        rows = dtcomprobantes.Select("cliente like '%" & sender.Text & "%'")

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

        Cargar_Combobox_General(cbTipo, dt, "nombre", "id")
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

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mostrarPrincipal()
    End Sub

End Class
Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmProductosVista
    Dim dtproductos As New DataTable

    Private Sub frmCategoriasVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        style_grilla(dgvDatos)
        CargarDatos()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New frmProductos(0)
        frm.Show()
        Me.Close()
    End Sub

    Sub CargarDatos()
        Try
            If dgvDatos.DataSource IsNot Nothing Then
                dgvDatos.DataSource = Nothing
            End If
            Dim cd As New Transaccion_lectura
            dtproductos = New DataTable
            dtproductos = cd.DT_leer(New CE_dgv With {.Tipo = 8})
            AgregarFilasDGV(dgvDatos, dtproductos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarFilasDGV(ByVal dgv As DataGridView, ByVal dt As DataTable)
        Try
            AgregarColumnasDGV(dgv)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgv.Rows.Add(dt.Rows(i).Item("idproducto"), dt.Rows(i).Item("nombrecategoria"), dt.Rows(i).Item("nombreproducto"), dt.Rows(i).Item("precio1"), dt.Rows(i).Item("precio2"))
                Next
            End If

            Dim colEditar As New DataGridViewImageColumn()
            Dim colEliminar As New DataGridViewImageColumn()
            Dim colImagen As New DataGridViewImageColumn()

            colEditar.Name = "colEditar"
            colEditar.HeaderText = "EDITAR"
            colEditar.Image = My.Resources.editicon
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom

            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Image = My.Resources.deleteicon
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom

            colImagen.Name = "colImagen"
            colImagen.HeaderText = "IMAGEN"
            colImagen.Image = My.Resources.photoicon
            colImagen.ImageLayout = DataGridViewImageCellLayout.Normal

            dgv.Columns.Add(colEditar)
            dgv.Columns.Add(colEliminar)
            dgv.Columns.Add(colImagen)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarColumnasDGV(ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            dgv.Columns.Clear()
            dgv.Columns.Add("id", "id")
            dgv.Columns.Add("nombrecategoria", "CATEGORIA")
            dgv.Columns.Add("nombreproducto", "PRODUCTO")
            dgv.Columns.Add("precio1", "PRECIO 1")
            dgv.Columns.Add("precio2", "PRECIO 2")
            dgv.Columns("id").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Select Case sender.COLUMNS(e.ColumnIndex).NAME
                Case "colEditar"
                    Dim frm As New frmProductos(sender.ROWS(e.RowIndex).CELLS("id").value)
                    frm.Show()
                    Me.Close()
                Case "colEliminar"
                    ' NOTA NO DEBERIA DE PERMITIR ELIMINAR UN PRODUCTO, YA QUE INFLUYE 
                    ' EN MULTIPLES CAMPOS, SE DEBE REALIZAR PRUEBAS
                    If MsgBox("Solo se pueden eliminar productos que no tengan una venta. ¿Desea eliminar el producto " & sender.ROWS(e.RowIndex).CELLS("nombreproducto").value & "?", MsgBoxStyle.OkCancel, "Advertencia") = MsgBoxResult.Ok Then
                        Dim cd As New Transaccion_producto
                        If cd.SP_producto(New CE_producto With {.Tipo = 3, .idproducto = sender.ROWS(e.RowIndex).CELLS("id").value}) Then MsgBox("Registro Eliminado") Else MsgBox("Error al eliminar")
                        CargarDatos()
                    End If
                Case "colImagen"

                    MsgBox("Se debe de mostrar la imagen del producto")

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusquedaProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        ' creamos un array
        Dim rows As DataRow()

        ' creamos donde almacenaremos la consulta sin editar el dt_cliente
        Dim dtNew As DataTable

        ' copiamos la estructura al nuevo dt
        dtNew = dtproductos.Clone()

        ' realizamos la consulta con select
        rows = dtproductos.Select("nombreproducto like '%" & sender.Text & "%' Or nombrecategoria Like '%" & sender.Text & "%'")

        ' recorremos la consulta dada y agregamos sus valores al nuevo dt creado(dtNew)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        ' enviamos para que llene el datagridview
        AgregarFilasDGV(dgvDatos, dtNew)
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
Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmCajaChicaVista

    Dim dtcajachica As New DataTable

    Private Sub frmCategoriasVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New frmCajaChica(0)
        frm.Show()
        Me.Close()
    End Sub

    Sub CargarDatos()
        Try
            If dgvDatos.DataSource IsNot Nothing Then
                dgvDatos.DataSource = Nothing
            End If
            Dim cd As New Transaccion_lectura
            dtcajachica = New DataTable
            dtcajachica = cd.DT_leer(New CE_dgv With {.Tipo = 12})
            AgregarFilasDGV(dgvDatos, dtcajachica)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarFilasDGV(ByVal dgv As DataGridView, ByVal dt As DataTable)
        Try
            AgregarColumnasDGV(dgv)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgv.Rows.Add(dt.Rows(i).Item("idcajadinero"), dt.Rows(i).Item("perfil"), dt.Rows(i).Item("fecha"), dt.Rows(i).Item("montoinicio"), dt.Rows(i).Item("montofinal"), dt.Rows(i).Item("comentario"))
                Next
            End If
            Dim colEditar As New DataGridViewButtonColumn()
            Dim colEliminar As New DataGridViewButtonColumn()

            colEditar.Name = "colEditar"
            colEditar.HeaderText = "EDITAR"
            colEditar.Text = "Editar"
            colEditar.UseColumnTextForButtonValue = True
            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Text = "Eliminar"
            colEliminar.UseColumnTextForButtonValue = True

            dgv.Columns.Add(colEditar)
            dgv.Columns.Add(colEliminar)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarColumnasDGV(ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            dgv.Columns.Clear()
            dgv.Columns.Add("id", "id")
            dgv.Columns.Add("usuario", "USUARIO")
            dgv.Columns.Add("fecha", "FECHA")
            dgv.Columns.Add("montoinicial", "APERTURA")
            dgv.Columns.Add("montofin", "CIERRE")
            dgv.Columns.Add("comentario", "COMENTARIO")
            dgv.Columns("id").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Select Case sender.COLUMNS(e.ColumnIndex).NAME
                Case "colEditar"
                    Dim frm As New frmCajaChica(sender.ROWS(e.RowIndex).CELLS("id").value)
                    frm.Show()
                    Me.Close()
                Case "colEliminar"
                    Dim cd As New Transaccion_cajachica
                    If cd.SP_cajachica(New CE_cajachica With {.Tipo = 3, .idcajadinero = sender.ROWS(e.RowIndex).CELLS("id").value}) Then MsgBox("Registro Eliminado")
                    CargarDatos()
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
        dtNew = dtcajachica.Clone()

        ' realizamos la consulta con select
        rows = dtcajachica.Select("perfil like '%" & sender.Text & "%'")

        ' recorremos la consulta dada y agregamos sus valores al nuevo dt creado(dtNew)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        ' enviamos para que llene el datagridview
        AgregarFilasDGV(dgvDatos, dtNew)
    End Sub

End Class
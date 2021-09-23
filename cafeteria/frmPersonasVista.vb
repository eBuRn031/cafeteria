Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmPersonasVista

    Dim dtpersonas As New DataTable


    Private Sub frmCategoriasVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim frm As New frmPersonas(0)
        frm.Show()
        Me.Close()
    End Sub

    Sub CargarDatos()
        Try
            If dgvDatos.DataSource IsNot Nothing Then
                dgvDatos.DataSource = Nothing
            End If
            Dim cd As New Transaccion_lectura
            dtpersonas = New DataTable
            dtpersonas = cd.DT_leer(New CE_dgv With {.Tipo = 5})
            AgregarFilasDGV(dgvDatos, dtpersonas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarFilasDGV(ByVal dgv As DataGridView, ByVal dt As DataTable)
        Try
            AgregarColumnasDGV(dgv)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgv.Rows.Add(dt.Rows(i).Item("idpersonas"), dt.Rows(i).Item("dni"), dt.Rows(i).Item("nombre"), dt.Rows(i).Item("apellidos"), dt.Rows(i).Item("celular"))
                Next
            End If
            Dim colEditar As New DataGridViewButtonColumn()
            Dim colEliminar As New DataGridViewButtonColumn()
            Dim colUsuario As New DataGridViewButtonColumn()

            colEditar.Name = "colEditar"
            colEditar.HeaderText = "EDITAR"
            colEditar.Text = "Editar"
            colEditar.UseColumnTextForButtonValue = True
            colEliminar.Name = "colEliminar"
            colEliminar.HeaderText = "ELIMINAR"
            colEliminar.Text = "Eliminar"
            colEliminar.UseColumnTextForButtonValue = True
            colUsuario.Name = "colUsuario"
            colUsuario.HeaderText = "USUARIO"
            colUsuario.Text = "Usuario"
            colUsuario.UseColumnTextForButtonValue = True

            dgv.Columns.Add(colEditar)
            dgv.Columns.Add(colEliminar)
            dgv.Columns.Add(colUsuario)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AgregarColumnasDGV(ByVal dgv As DataGridView)
        Try
            dgv.Rows.Clear()
            dgv.Columns.Clear()
            dgv.Columns.Add("id", "id")
            dgv.Columns.Add("dni", "DNI")
            dgv.Columns.Add("nombre", "NOMBRE")
            dgv.Columns.Add("apellidos", "APELLIDO")
            dgv.Columns.Add("celular", "CELULAR")
            dgv.Columns("id").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        Try
            Select Case sender.COLUMNS(e.ColumnIndex).NAME
                Case "colEditar"
                    Dim frm As New frmPersonas(sender.ROWS(e.RowIndex).CELLS("id").value)
                    frm.Show()
                    Me.Close()
                Case "colEliminar"
                    Dim cd As New Transaccion_personas
                    If cd.SP_personas(New CE_personas With {.Tipo = 3, .idpersonas = sender.ROWS(e.RowIndex).CELLS("id").value}) Then MsgBox("Registro Eliminado")
                    CargarDatos()
                Case "colUsuario"
                    Dim frm As New frmUsuario(sender.ROWS(e.RowIndex).CELLS("id").value)
                    frm.Show()
                    Me.Close()
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
        dtNew = dtpersonas.Clone()

        ' realizamos la consulta con select
        rows = dtpersonas.Select("dni like '%" & sender.Text & "%' Or nombre Like '%" & sender.Text & "%'Or apellidos Like '%" & sender.Text & "%'")

        ' recorremos la consulta dada y agregamos sus valores al nuevo dt creado(dtNew)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        ' enviamos para que llene el datagridview
        AgregarFilasDGV(dgvDatos, dtNew)
    End Sub


End Class
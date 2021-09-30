Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmCajaChica
    Dim id As Integer

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_cajachica
        Select Case id
            Case 0
                If cd.SP_cajachica(New CE_cajachica With {.Tipo = 1, .idusuarios = cbUsuarios.SelectedValue, .fecha = dtpfecha.Value, .fechaInicio = CDate(txtfechainicio.Text), .fechaFinal = CDate(txtfechafinal.Text), .montoinicio = nudmontoinicio.Value, .montofinal = nudmontofinal.Value, .comentario = txtcomentario.Text}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
            Case Else
                If cd.SP_cajachica(New CE_cajachica With {.Tipo = 2, .idcajadinero = id, .idusuarios = cbUsuarios.SelectedValue, .fecha = dtpfecha.Value, .fechaInicio = CDate(txtfechainicio.Text), .fechaFinal = CDate(txtfechafinal.Text), .montoinicio = nudmontoinicio.Value, .montofinal = nudmontofinal.Value, .comentario = txtcomentario.Text}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmCajaChicaVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 13, .Codigo_1 = id})
            cbUsuarios.SelectedValue = dt.Rows(0).Item("idusuarios")
            dtpfecha.Value = dt.Rows(0).Item("fecha")
            txtfechainicio.Text = dt.Rows(0).Item("fechainicio")
            txtfechafinal.Text = dt.Rows(0).Item("fechafinal")
            nudmontoinicio.Value = dt.Rows(0).Item("montoinicio")
            nudmontofinal.Value = dt.Rows(0).Item("montofinal")
            txtcomentario.Text = dt.Rows(0).Item("comentario")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirComboboxProductos()
        If id <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub

    Sub abrirComboboxProductos()
        Cargar_Combobox_General(cbUsuarios, New CE_dgv With {.Tipo = 14}, "perfil", "idusuarios")
    End Sub

End Class
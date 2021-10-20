Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmProductos
    Dim id As Integer

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cd As New Transaccion_producto
        Select Case id
            Case 0
                If cd.SP_producto(New CE_producto With {.Tipo = 1, .idcategoria = cbcategoria.SelectedValue, .idunidadmedida = cbunidadmedida.SelectedValue, .nombre = txtnombre.Text, .precio1 = nudprecio1.Value, .precio2 = nudprecio2.Value, .idusuarios = _idusuario, .imagen = Imagen_Bytes(pbimagen.Image), .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
            Case Else
                If cd.SP_producto(New CE_producto With {.Tipo = 2, .idproducto = id, .idcategoria = cbcategoria.SelectedValue, .idunidadmedida = cbunidadmedida.SelectedValue, .nombre = txtnombre.Text, .precio1 = nudprecio1.Value, .precio2 = nudprecio2.Value, .idusuarios = _idusuario, .imagen = Imagen_Bytes(pbimagen.Image), .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
        End Select
        Me.Close()
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmProductosVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 9, .Codigo_1 = id})
            cbcategoria.SelectedValue = dt.Rows(0).Item("idcategoria")
            cbunidadmedida.SelectedValue = dt.Rows(0).Item("idunidadmedida")
            txtnombre.Text = dt.Rows(0).Item("nombre")
            nudprecio1.Value = dt.Rows(0).Item("precio1")
            nudprecio2.Value = dt.Rows(0).Item("precio2")
            pbimagen.Image = Bytes_Imagen(dt.Rows(0).Item("imagen"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        abrirComboboxProductos()
        If id <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub

    Sub abrirComboboxProductos()
        Cargar_Combobox_General(cbcategoria, New CE_dgv With {.Tipo = 1}, "nombre", "idcategoria")
        Cargar_Combobox_General(cbunidadmedida, New CE_dgv With {.Tipo = 3}, "nombre", "idunidadmedida")
    End Sub

    Private Sub btnimagen_Click(sender As Object, e As EventArgs) Handles btnimagen.Click
        Dim opd_pfx As New OpenFileDialog
        opd_pfx.Filter = "Archivos de imagen(*.jpg)|*.jpg|All Files (*.*)|*.*"
        If opd_pfx.ShowDialog = DialogResult.OK Then
            txtruta.Text = opd_pfx.FileName
            Me.pbimagen.Image = Image.FromFile(opd_pfx.FileName)
            Me.pbimagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

End Class
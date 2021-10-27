Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmPersonas
    Dim id As Integer
    'variables para el autocompletado de RUC y Razon Social
    Private ruc_coleccion As AutoCompleteStringCollection

    Public Sub New(ByVal _id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = _id
    End Sub
    Sub cargar_coleccion()
        Dim cf As New Transaccion_lectura
        Dim dt As New DataTable
        ruc_coleccion = New AutoCompleteStringCollection

        dt = cf.DT_leer(New CE_dgv With {.Tipo = 5})
        For i = 0 To dt.Rows.Count - 1
            ruc_coleccion.Add(dt.Rows(i).Item("dni").ToString)
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If MsgBox("¿Guardar Cambios?", MsgBoxStyle.OkCancel, "Advertencia") = MsgBoxResult.Ok Then
            validar_persona()
            Dim cd As New Transaccion_personas
            Select Case id
                Case 0
                    If cd.SP_personas(New CE_personas With {.Tipo = 1, .dni = txtdni.Text, .nombre = txtnombres.Text, .apellidos = "", .celular = txtcelular.Text, .correo = txtcorreo.Text, .direccion = txtdireccion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Agrego Correctamente") Else MsgBox("Error al Agregar")
                Case Else
                    If cd.SP_personas(New CE_personas With {.Tipo = 2, .idpersonas = id, .dni = txtdni.Text, .nombre = txtnombres.Text, .apellidos = "", .celular = txtcelular.Text, .correo = txtcorreo.Text, .direccion = txtdireccion.Text, .fecreg = Now(), .fecmod = Now()}) Then MsgBox("Se Actualizó Correctamente") Else MsgBox("Error al Actualizar")
            End Select
            Me.Close()
        End If
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Dim frm As New frmPersonasVista
        frm.Show()
    End Sub

    Sub cargarDatosConsulta()
        Try
            Dim cd As New Transaccion_lectura
            Dim dt As New DataTable
            dt = New DataTable
            dt = cd.DT_leer(New CE_dgv With {.Tipo = 6, .Codigo_1 = id})
            txtdni.Text = dt.Rows(0).Item("dni")
            txtnombres.Text = dt.Rows(0).Item("nombre") & " " & dt.Rows(0).Item("apellidos")
            txtcelular.Text = dt.Rows(0).Item("celular")
            txtcorreo.Text = dt.Rows(0).Item("correo")
            txtdireccion.Text = dt.Rows(0).Item("direccion")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        cargar_coleccion()
        ' AGREGAMOS LA PROPIEDAD AUTOCOMPLETE A LOS TEXTBOX TXT_DOCUMENTO Y TXT_NOMBRE
        txtdni.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdni.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdni.AutoCompleteCustomSource = ruc_coleccion

        If id <> 0 Then
            cargarDatosConsulta()
        End If
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Select Case txtdni.Text.Length
            Case 8
                txtnombres.Text = ConsultaDNI(txtdni.Text)
                txtdireccion.Text = ""
            Case 11
                Dim persona As Object = ConsultaRUC(txtdni.Text)

                If persona IsNot Nothing Then
                    txtnombres.Text = persona.NombreORazonSocial
                    txtdireccion.Text = persona.Direccion
                End If
            Case Else
        End Select
    End Sub

    Private Sub txt_documento_Properties_Leave(sender As Object, e As EventArgs) Handles txtdni.Leave
        If String.IsNullOrEmpty(txtdni.Text.Replace(" ", String.Empty)) = False Then
            If txtdni.Text.Length = 8 Or txtdni.Text.Length = 11 Then
                Dim cf As New Transaccion_lectura
                Dim dt As New DataTable
                dt = cf.DT_leer(New CE_dgv With {.Tipo = 17, .Codigo_1 = txtdni.Text})
                If dt.Rows.Count > 0 Then
                    id = CInt(dt.Rows(0).Item("idpersonas").ToString)
                    txtnombres.Text = dt.Rows(0).Item("nombre").ToString & " " & dt.Rows(0).Item("apellidos").ToString
                    txtcelular.Text = dt.Rows(0).Item("celular").ToString
                    txtcorreo.Text = dt.Rows(0).Item("correo").ToString
                    txtdireccion.Text = dt.Rows(0).Item("direccion").ToString
                End If
            End If
        End If
    End Sub
    Sub validar_persona()
        If String.IsNullOrEmpty(txtdni.Text.Replace(" ", String.Empty)) And String.IsNullOrEmpty(txtnombres.Text.Replace(" ", String.Empty)) Then
            id = 2 ' persona vacia en la bd, en caso de no cumplir esta condicion se creará un nuevo registro para el usuario
        ElseIf String.IsNullOrEmpty(txtdni.Text.Replace(" ", String.Empty)) And String.IsNullOrEmpty(txtnombres.Text.Replace(" ", String.Empty)) = False Then
            id = 0
        End If
    End Sub

End Class
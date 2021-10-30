Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmPuntoVenta
    ' OPTIENE LAS PROPIEDADES Y EVENTOS DE LOS TEXTBOX DE LA GRILLA DGV_DATOS
    Private WithEvents Text_Box_ As DataGridViewTextBoxEditingControl
    ' INSTANCIA DE LOS EVENTOS
    Private eventos As New Eventos

    'RECIBE COMO PARAMETRO EL ID DE LA MESA A VENDER
    Private _id_mesa As Integer
    Private _nombre_mesa As String

    Private Cantidad_ As Decimal
    Private dtproducto As New DataTable
    Private _id_personas As Integer
    'variables para el autocompletado de RUC y Razon Social
    Private ruc_coleccion As AutoCompleteStringCollection
    'variable que nos indica que se abrio la pantalla desde canjeo de comprobante
    Private idform As Integer '0 ventas, 1 canje de comprobante, 2 reimpresion
    Private idPedidoEdit As Integer

    Sub New(id As Integer, nombre_mesa As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _id_mesa = id
        _nombre_mesa = nombre_mesa
    End Sub
    Private Sub frmPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' TRAS UNA CONSULTA TRAE DE LA BD LOS DOCUMENTOS Y NOMBRES DE TODOS LOS CLIENTES 
        cargar_coleccion()

        ' AGREGAMOS LA PROPIEDAD AUTOCOMPLETE A LOS TEXTBOX TXT_DOCUMENTO Y TXT_NOMBRE
        txtdocumento.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdocumento.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdocumento.AutoCompleteCustomSource = ruc_coleccion

        style_grilla(dgvDatos)
        CreaBotonesCategoria()
        busquedaproducto("todo")
        lblNombreMesa.Text = _nombre_mesa
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

    Private Sub CreaBotonesCategoria()

        Dim cf As New Transaccion_lectura
        Dim dt As New DataTable
        dt = cf.DT_leer(New CE_dgv With {.Tipo = 1})
        Dim xx, yy As Integer
        xx = 10
        yy = 10

        Dim tamaniobotonx, tamaniobotony As Integer
        tamaniobotonx = 150
        tamaniobotony = 27

        Dim tamaniopanelx, tamaniopanely As Integer
        tamaniopanelx = pncategoria.Width
        tamaniopanely = pncategoria.Height

        Dim btn As New Button()
        With btn
            .Name = "todo" ' Asignas el nombre del objeto
            .Text = "TODO"     ' Asignas el texto del objeto
            .Location = New System.Drawing.Point(xx, yy) ' Asignas la posición del objeto
            .Size = New System.Drawing.Size(tamaniobotonx, tamaniobotony) ' Asignas el tamaño del objeto
            .TextAlign = ContentAlignment.MiddleCenter
            .FlatStyle = FlatStyle.Popup
        End With
        AddHandler btn.Click, AddressOf Button_Click
        pncategoria.Controls.Add(btn)  ' Agregas el botón al formulario.

        xx = tamaniobotonx + 10

        If dt.Rows.Count > Nothing Then
            Dim ncolumnas As Integer = 2
            For i = 0 To dt.Rows.Count - 1
                btn = New Button()   ' Creas el objeto boton
                With btn
                    .Name = "categoria_" & dt.Rows(i).Item("idcategoria") ' Asignas el nombre del objeto
                    .Text = dt.Rows(i).Item("nombre")     ' Asignas el texto del objeto
                    .Location = New System.Drawing.Point(xx, yy) ' Asignas la posición del objeto
                    .Size = New System.Drawing.Size(tamaniobotonx, tamaniobotony) ' Asignas el tamaño del objeto
                    .TextAlign = ContentAlignment.MiddleCenter
                    .FlatStyle = FlatStyle.Popup
                End With

                AddHandler btn.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click

                pncategoria.Controls.Add(btn)  ' Agregas el botón al formulario.

                xx = ncolumnas * tamaniobotonx + 10
                ncolumnas += 1
            Next
        End If
    End Sub

    Sub busquedaproducto(nombre As String)
        Dim cf As New Transaccion_lectura
        dtproducto = New DataTable
        If nombre = "todo" Then
            dtproducto = cf.DT_leer(New CE_dgv With {.Tipo = 8})
        Else
            dtproducto = cf.DT_leer(New CE_dgv With {.Tipo = 16, .Codigo_1 = nombre})
        End If
        CreaBotonesProductos(dtproducto)
        '  MsgBox(nombre)
    End Sub

    Private Sub CreaBotonesProductos(dt As DataTable)
        pnproductos.Controls.Clear()
        Dim xx, yy As Integer
        xx = 10
        yy = 10

        Dim tamaniobotonx, tamaniobotony As Integer
        tamaniobotonx = 75
        tamaniobotony = 90

        Dim tamaniopanelx, tamaniopanely As Integer
        tamaniopanelx = pnproductos.Width
        tamaniopanely = pnproductos.Height

        Dim MyFont As New Font(Label1.Font.FontFamily, 7, FontStyle.Regular)
        Dim limite As Integer = CInt(tamaniopanelx / tamaniobotonx) - 1

        If dt.Rows.Count > Nothing Then
            Dim filas As Integer = CInt(dt.Rows.Count / limite)
            Dim nfilas As Integer = 1
            Dim ncolumnas As Integer = 1
            For i = 0 To dt.Rows.Count - 1
                Dim btn As New Button()   ' Creas el objeto boton

                With btn
                    .Name = dt.Rows(i).Item("idproducto") & "_" & dt.Rows(i).Item("nombreproducto") & "_" & dt.Rows(i).Item("precio1") & "_" & dt.Rows(i).Item("precio2") ' Asignas el nombre del objeto
                    .Text = dt.Rows(i).Item("nombreproducto")     ' Asignas el texto del objeto
                    .Location = New System.Drawing.Point(xx, yy) ' Asignas la posición del objeto
                    .Size = New System.Drawing.Size(tamaniobotonx, tamaniobotony) ' Asignas el tamaño del objeto
                    .TextAlign = ContentAlignment.BottomCenter
                    .Font = MyFont
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .BackgroundImage = Bytes_Imagen(dt.Rows(i).Item("imagen"))
                End With

                AddHandler btn.Click, AddressOf Button_Clickprod   ' Asocias el evento al método Button_Click

                pnproductos.Controls.Add(btn)  ' Agregas el botón al formulario.

                If ncolumnas >= limite Then
                    xx = 10
                    yy = nfilas * tamaniobotony + 10
                    nfilas += 1
                    ncolumnas = 1
                Else
                    xx = ncolumnas * tamaniobotonx + 10
                    ncolumnas += 1
                End If
            Next
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim cadena() As String
        Dim nombre As String = CType(sender, System.Windows.Forms.Button).Name
        If nombre = "todo" Then
            busquedaproducto(CType(sender, System.Windows.Forms.Button).Name)
        Else
            cadena = nombre.Split("_")
            busquedaproducto(cadena(1))
        End If
    End Sub

    Private Sub Button_Clickprod(ByVal sender As Object, ByVal e As EventArgs)
        AgregarProductoSeleccionado(CType(sender, System.Windows.Forms.Button).Name)
    End Sub

    Sub AgregarProductoSeleccionado(nombre As String)
        Dim cadena() As String
        cadena = nombre.Split("_")
        Dim id As Integer = CInt(cadena(0))
        Dim nombreproducto As String = cadena(1)
        Dim precio1 As Decimal = CDec(cadena(2))
        Dim precio2 As Decimal = CDec(cadena(3))

        If dgvDatos.Rows.Count > 0 Then
            For i = 0 To dgvDatos.Rows.Count - 1
                If CInt(dgvDatos.Rows(i).Cells(0).Value) = id Then
                    MsgBox("Este producto ya fue ingresado, seleccione otro...")
                    Exit Sub
                End If
            Next
        End If

        If rbprecio1.Checked Then
            dgvDatos.Rows.Add(id, nombreproducto, precio1, 1, precio1)
        End If
        If rbprecio2.Checked Then
            dgvDatos.Rows.Add(id, nombreproducto, precio2, 1, precio2)
        End If
        'SELECCIONA LA CANTIDAD EN LA GRILLA 1 PARA QUE EDITE
        dgvDatos.Rows(dgvDatos.RowCount - 1).Selected = True
        dgvDatos.CurrentCell = dgvDatos.Rows(dgvDatos.RowCount - 1).Cells(3)
        dgvDatos.Focus()
        sumatorias()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        Dim cf As New Transaccion_lectura
        dtproducto = New DataTable
        dtproducto = cf.DT_leer(New CE_dgv With {.Tipo = 8})
        ' creamos un array
        Dim rows As DataRow()

        ' creamos donde almacenaremos la consulta sin editar el dt_cliente
        Dim dtNew As DataTable

        ' copiamos la estructura al nuevo dt
        dtNew = dtproducto.Clone()

        ' realizamos la consulta con select
        rows = dtproducto.Select("nombreproducto like '%" & sender.Text & "%'")

        ' recorremos la consulta dada y agregamos sus valores al nuevo dt creado(dtNew)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        ' enviamos para que llene el datagridview
        CreaBotonesProductos(dtNew)
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Select Case txtdocumento.Text.Length
            Case 8

                txtcliente.Text = ConsultaDNI(txtdocumento.Text)
                txtdireccion.Text = ""
            Case 11
                Dim persona As Object = ConsultaRUC(txtdocumento.Text)

                If persona IsNot Nothing Then
                    txtcliente.Text = persona.NombreORazonSocial
                    txtdireccion.Text = persona.Direccion
                End If
            Case Else
        End Select
    End Sub

    ' CUANDO SALE DE FOCO EL TEXTBOX DOCUMENTO SE HACE BUSQUEDA POR DOCUMENTO
    Private Sub txt_documento_Properties_Leave(sender As Object, e As EventArgs) Handles txtdocumento.Leave
        If String.IsNullOrEmpty(txtdocumento.Text.Replace(" ", String.Empty)) = False Then
            If txtdocumento.Text.Length = 8 Or txtdocumento.Text.Length = 11 Then
                Dim cf As New Transaccion_lectura
                Dim dt As New DataTable
                dt = cf.DT_leer(New CE_dgv With {.Tipo = 17, .Codigo_1 = txtdocumento.Text})
                If dt.Rows.Count > 0 Then
                    _id_personas = CInt(dt.Rows(0).Item("idpersonas").ToString)
                    txtcliente.Text = dt.Rows(0).Item("nombre").ToString & " " & dt.Rows(0).Item("apellidos").ToString
                    txtdireccion.Text = dt.Rows(0).Item("direccion").ToString
                End If
            End If
        End If
    End Sub

    'SI SE ESTÁ EDITANDO Y SE ESTA EN LA ULTIMA FILA SE CONSIDERÁ COMO TAB
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            If keyData = Keys.Enter Then
                If dgvDatos.RowCount > Nothing Then
                    If dgvDatos.CurrentCell.IsInEditMode Then
                        dgvDatos.EndEdit()
                        eventos.enviar_tab()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' SI SE SALE DE FOCO EL DGV_DATOS SE SELECCIONA EL TEXTBOX PRODUCTO
    Private Sub DGV_VENTA_RowLeave(sender As Object, e As EventArgs) Handles dgvDatos.Leave
        txtbusqueda.Focus()
        txtbusqueda.SelectAll()
    End Sub

    ' convierte a la fila actual o el casillero editabdose en un textbox y con ellos atrae todos sus eventos a modificar
    Private Sub DGV_VENTA_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDatos.EditingControlShowing
        Text_Box_ = TryCast(e.Control, DataGridViewTextBoxEditingControl)
    End Sub

    ' A LA CELDA SELECCIONADA EN DGV_DATOS SE LE DA FORMATO DE NUMEROS
    Private Sub cellTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Box_.KeyPress
        eventos.decimales(sender, e)
    End Sub

    ' CUANDO SALE DE FOCO UNA CELDA EDITADA DE DGV_DATOS SE LLAMA A VARIAS FUNCIONES
    Private Sub cellTextBox_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Text_Box_.Leave
        ' eventos que se ejecutaran cuando salga de la casilla editable del datagridview dgv_datos
        cargar_calculos()
        sumatorias()
    End Sub

    ' CUANDO ENTRA EN FOCO UNA FILA DEL DGV_DATOS SE COPIA SUS VALORES PARA LOS CALCULOS
    Private Sub dgv_datos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellEnter
        Try
            If dgvDatos.RowCount > Nothing Then
                If dgvDatos.Item(3, dgvDatos.CurrentRow.Index).Value.ToString = String.Empty Then
                    Cantidad_ = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cargar_calculos()
        Try
            If dgvDatos.Rows.Count > 0 Then
                Dim cantidad As Decimal
                Dim precio As Decimal
                For i = 0 To dgvDatos.Rows.Count - 1
                    cantidad = CDec(dgvDatos.Rows(i).Cells(3).Value)
                    precio = CDec(dgvDatos.Rows(i).Cells(2).Value)
                    dgvDatos.Rows(i).Cells(4).Value = Math.Round(cantidad * precio, 2)
                Next
            Else
                nudsubtotal.Value = 0
                nuddescuento.Value = 0
                nudimpuesto.Value = 0
                nudtotal.Value = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub sumatorias()
        Try
            If dgvDatos.Rows.Count > 0 Then
                Dim suma As Decimal
                For i = 0 To dgvDatos.Rows.Count - 1
                    suma += CDec(dgvDatos.Rows(i).Cells(4).Value)
                Next
                nudsubtotal.Value = suma
                nuddescuento.Value = 0.00
                nudimpuesto.Value = 0.00
                nudtotal.Value = suma
            Else
                nudsubtotal.Value = 0.00
                nuddescuento.Value = 0.00
                nudimpuesto.Value = 0.00
                nudtotal.Value = 0.00
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCategoria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim frm As New frmMesasSeleccion
        frm.Show()
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("¿Desea realizar la venta?", MsgBoxStyle.OkCancel, "VENTAS") = MsgBoxResult.Ok Then
            validar_persona()
            If idform <> 1 Then
                insertar_datos()
            ElseIf idform = 1 Then
                editar_datos()
            End If
            imprimirVenta()
            limpiar_form()
        End If
    End Sub

    Sub validar_persona()
        If String.IsNullOrEmpty(txtdocumento.Text.Replace(" ", String.Empty)) And String.IsNullOrEmpty(txtcliente.Text.Replace(" ", String.Empty)) Then
            _id_personas = 2 ' persona vacia en la bd, en caso de no cumplir esta condicion se creará un nuevo registro para el usuario
        ElseIf String.IsNullOrEmpty(txtdocumento.Text.Replace(" ", String.Empty)) And String.IsNullOrEmpty(txtcliente.Text.Replace(" ", String.Empty)) = False Then
            _id_personas = 0
        End If
    End Sub

    Sub insertar_datos()

        ' llamada a las entidades
        Dim CE_personas As New CE_personas
        Dim CE_pedido As New CE_pedido

        'listas
        Dim list_CE_detallepedido As New List(Of CE_detallepedido)
        Dim Lista_CE_productostock As New List(Of CE_productostock)
        Dim CE_detallepedido As New CE_detallepedido
        Dim CE_productostock As New CE_productostock


        ' campos de personas
        CE_personas.Tipo = 4
        CE_personas.idpersonas = _id_personas
        CE_personas.dni = txtdocumento.Text
        CE_personas.nombre = txtcliente.Text
        CE_personas.apellidos = ""
        CE_personas.direccion = txtdireccion.Text
        CE_personas.correo = ""
        CE_personas.celular = ""

        'campos de comprobante
        CE_pedido.Tipo = 4
        CE_pedido.idpedido = 0
        CE_pedido.idmesa = _id_mesa
        CE_pedido.idpersonas = _id_personas
        CE_pedido.idusuarios = _idusuario
        CE_pedido.numero = 1
        CE_pedido.total = nudtotal.Value
        CE_pedido.fechahora = Now()
        CE_pedido.estado = 1

        ' detalle del comprobante
        For i = 0 To dgvDatos.Rows.Count - 1
            CE_detallepedido = New CE_detallepedido
            CE_detallepedido.Tipo = 1
            CE_detallepedido.pedido_idpedido = 0
            CE_detallepedido.producto_idproducto = CInt(dgvDatos.Rows(i).Cells(0).Value)
            CE_detallepedido.cantidad = CDec(dgvDatos.Rows(i).Cells(3).Value)
            CE_detallepedido.precio = CDec(dgvDatos.Rows(i).Cells(2).Value)
            CE_detallepedido.total = CDec(dgvDatos.Rows(i).Cells(4).Value)
            list_CE_detallepedido.Add(CE_detallepedido)

            CE_productostock = New CE_productostock
            CE_productostock.Tipo = 1
            CE_productostock.idproducto = CInt(dgvDatos.Rows(i).Cells(0).Value)
            CE_productostock.idusuarios = _idusuario
            CE_productostock.fechahora = Now()
            CE_productostock.entrada = 0
            CE_productostock.salida = CDec(dgvDatos.Rows(i).Cells(3).Value)
            CE_productostock.total = 0
            CE_productostock.comentario = String.Empty
            Lista_CE_productostock.Add(CE_productostock)
        Next

        ' llamada a las funciones
        Dim Transaccion_pedido As New Transaccion_pedido
        If Transaccion_pedido.SP_ventas(CE_personas, CE_pedido, list_CE_detallepedido, Lista_CE_productostock) Then
            MsgBox("Pedido guardado")
        Else
            MsgBox("Error al guardar la venta")
        End If

    End Sub

    Sub editar_datos()

        ' llamada a las entidades
        Dim CE_personas As New CE_personas
        Dim CE_pedido As New CE_pedido

        'listas
        Dim list_CE_detallepedido As New List(Of CE_detallepedido)
        Dim Lista_CE_productostock As New List(Of CE_productostock)
        Dim CE_detallepedido As New CE_detallepedido
        Dim CE_productostock As New CE_productostock

        ' campos de personas
        CE_personas.Tipo = 4
        CE_personas.idpersonas = _id_personas
        CE_personas.dni = txtdocumento.Text
        CE_personas.nombre = txtcliente.Text
        CE_personas.apellidos = ""
        CE_personas.direccion = txtdireccion.Text
        CE_personas.correo = ""
        CE_personas.celular = ""

        'campos de comprobante
        CE_pedido.Tipo = 2
        CE_pedido.idpedido = idPedidoEdit
        CE_pedido.idpersonas = _id_personas
        CE_pedido.idusuarios = _idusuario
        CE_pedido.total = nudtotal.Value
        CE_pedido.fechahora = Now()
        CE_pedido.estado = 1

        ' Quitamos al kardex los productos anteiormente agregados
        Dim cf As New Transaccion_lectura
        Dim dt As New DataTable
        dt = cf.DT_leer(New CE_dgv With {.Tipo = 21, .Codigo_1 = idPedidoEdit})
        For i = 0 To dt.Rows.Count - 1
            Dim cex As New CE_productostock
            cex.Tipo = 6
            cex.idproducto = dt.Rows(0).Item("producto_idproducto")
            cex.idusuarios = _idusuario
            cex.fechahora = Now()
            cex.entrada = dt.Rows(0).Item("cantidad")
            cex.salida = 0
            cex.total = 0
            cex.comentario = "Edicion de pedido " & lblNombreMesa.Text
            Lista_CE_productostock.Add(cex)
        Next

        CE_detallepedido = New CE_detallepedido
        CE_detallepedido.Tipo = 3
        CE_detallepedido.pedido_idpedido = idPedidoEdit
        list_CE_detallepedido.Add(CE_detallepedido)

        ' detalle del comprobante
        For i = 0 To dgvDatos.Rows.Count - 1
            CE_detallepedido = New CE_detallepedido
            CE_detallepedido.Tipo = 1
            CE_detallepedido.pedido_idpedido = 0
            CE_detallepedido.producto_idproducto = CInt(dgvDatos.Rows(i).Cells(0).Value)
            CE_detallepedido.cantidad = CDec(dgvDatos.Rows(i).Cells(3).Value)
            CE_detallepedido.precio = CDec(dgvDatos.Rows(i).Cells(2).Value)
            CE_detallepedido.total = CDec(dgvDatos.Rows(i).Cells(4).Value)
            list_CE_detallepedido.Add(CE_detallepedido)

            CE_productostock = New CE_productostock
            CE_productostock.Tipo = 1
            CE_productostock.idproducto = CInt(dgvDatos.Rows(i).Cells(0).Value)
            CE_productostock.idusuarios = _idusuario
            CE_productostock.fechahora = Now()
            CE_productostock.entrada = 0
            CE_productostock.salida = CDec(dgvDatos.Rows(i).Cells(3).Value)
            CE_productostock.total = 0
            CE_productostock.comentario = String.Empty
            Lista_CE_productostock.Add(CE_productostock)
        Next

        ' llamada a las funciones
        Dim Transaccion_pedido As New Transaccion_pedido
        If Transaccion_pedido.SP_ventasEdit(CE_personas, CE_pedido, list_CE_detallepedido, Lista_CE_productostock) Then
            MsgBox("Pedido editado correctamete")
        Else
            MsgBox("Error al guardar la venta")
        End If

    End Sub

    Sub limpiar_form()
        _id_personas = 0
        txtdocumento.Text = String.Empty
        txtcliente.Text = String.Empty
        txtdireccion.Text = String.Empty
        txtbusqueda.Text = String.Empty
        dgvDatos.Rows.Clear()
        nudsubtotal.Value = 0
        nuddescuento.Value = 0
        nudimpuesto.Value = 0
        nudtotal.Value = 0
        idform = 0
        idPedidoEdit = 0
        busquedaproducto("todo")
    End Sub

    Sub imprimirVenta()
        Try
            Dim cf As New Transaccion_lectura
            Dim dtx As New DataTable

            If idform <> 1 Then
                dtx = cf.DT_leer(New CE_dgv With {.Tipo = 26, .Codigo_1 = _id_mesa})
            ElseIf idform = 1 Then
                dtx = cf.DT_leer(New CE_dgv With {.Tipo = 25, .Codigo_1 = idPedidoEdit})
            End If

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
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub btnLimpiarVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarVenta.Click
        Try
            Dim i As Integer

            If dgvDatos.SelectedCells.Count > 0 Then
                i = dgvDatos.CurrentCell.RowIndex
                If MsgBox("¿Desea eliminar el producto " & dgvDatos.Rows(i).Cells("nombreProducto").Value & " de la lista?", MsgBoxStyle.OkCancel, "Advertencia") = MsgBoxResult.Ok Then
                    dgvDatos.Rows.RemoveAt(i)
                    cargar_calculos()
                    sumatorias()
                End If
            Else
                MessageBox.Show("Selecciona una fila de la tabla")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cargarDatosPedido(ByVal _idpedidoEditar As Integer)
        Try
            idform = 1 'indicamos que estamos abriendo desde otro formulario diferente al punto de venta
            idPedidoEdit = _idpedidoEditar
            Dim cf As New Transaccion_lectura
            Dim dtx As New DataTable
            dtx = cf.DT_leer(New CE_dgv With {.Tipo = 25, .Codigo_1 = _idpedidoEditar})

            If dtx.Rows.Count > 0 Then
                lblNombreMesa.Text = dtx.Rows(0).Item("mesa")
                _id_personas = dtx.Rows(0).Item("idpersonas")
                txtdocumento.Text = dtx.Rows(0).Item("dni")
                txtcliente.Text = dtx.Rows(0).Item("cliente")
                txtdireccion.Text = dtx.Rows(0).Item("direccion")

                For i = 0 To dtx.Rows.Count - 1
                    Dim cx As New Transaccion_lectura
                    Dim dtxx As New DataTable
                    dtxx = cx.DT_leer(New CE_dgv With {.Tipo = 18, .Codigo_1 = dtx.Rows(i).Item("producto_idproducto")})
                    Dim producto As String = dtxx.Rows(0).Item("nombre").ToString
                    dgvDatos.Rows.Add(dtx.Rows(i).Item("producto_idproducto"),
                                      producto,
                                      dtx.Rows(i).Item("precio"),
                                      dtx.Rows(i).Item("cantidad"),
                                      dtx.Rows(i).Item("TotalD"))
                Next
                cargar_calculos()
                sumatorias()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
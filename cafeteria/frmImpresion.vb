Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class frmImpresion
    Private personas As New CE_personas
    Private comprobantes As New CE_ventas
    Private detalle As New List(Of CE_detalleventas)
    Public form_apertura As Integer

    Public Sub cargar_datos(p As CE_personas, ByVal c As CE_ventas, ByVal d As List(Of CE_detalleventas))
        personas = p
        comprobantes = c
        detalle = d
    End Sub

    Private Sub Formulario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Impresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_ZOOM.SelectedIndex = 2
        Me.TopMost = True
    End Sub

    Private Sub CB_ZOOM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ZOOM.SelectedIndexChanged
        Select Case CB_ZOOM.SelectedIndex
            Case 0
                PPC_MUESTRA.Zoom = 0.5
            Case 1
                PPC_MUESTRA.Zoom = 0.75
            Case 2
                PPC_MUESTRA.Zoom = 1.0
            Case 3
                PPC_MUESTRA.Zoom = 1.5
            Case 4
                PPC_MUESTRA.Zoom = 2.0
            Case 5
                PPC_MUESTRA.Zoom = 3.0
            Case 6
                PPC_MUESTRA.Zoom = 4.0
            Case 7
                PPC_MUESTRA.Zoom = 5.0
        End Select
    End Sub

    Private Sub PD_TICKETS_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_TICKETS.PrintPage
        '---------------------------------------------- COMPROBANTE ELECTRONICO ----------------------------------------------------

        'COMPROBAMOS QUE SEA CON IGV Y ASIGNAMOS EL TEXTO DE LA PARTE DE ABAJO DEL COMPROBANTE

        Dim fontTitulo As New Font("Tahoma", 10, FontStyle.Bold)
        Dim fontEncabezado As New Font("Tahoma", 7, FontStyle.Regular)
        Dim fontCuerpo As New Font("Tahoma", 7, FontStyle.Regular)
        Dim fontTituloColumna As New Font("Tahoma", 7, FontStyle.Bold)
        Dim fontPiePagina As New Font("Tahoma", 5, FontStyle.Bold)


        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = StringAlignment.Center
        FormatoCentro.LineAlignment = StringAlignment.Center
        Dim FormatoIzquierda As New StringFormat()
        FormatoIzquierda.Alignment = StringAlignment.Near
        FormatoIzquierda.LineAlignment = StringAlignment.Center
        Dim FormatoDerecha As New StringFormat()
        FormatoDerecha.Alignment = StringAlignment.Far
        FormatoDerecha.LineAlignment = StringAlignment.Center


        Dim Cliente As String = String.Empty
        Dim Documento As String = String.Empty
        Dim direccion_ As String = String.Empty
        Dim Pie_Pagina As String = String.Empty
        Dim Pagina_Web As String = String.Empty
        Dim Nombre_Caja As String = String.Empty
        Dim Subtotal As Decimal = Nothing
        Dim Descuento As Decimal = Nothing
        Dim IGV As Decimal = Nothing
        Dim Total As Decimal = Nothing
        Dim cont As Integer = Nothing
        Dim Parrafo As Rectangle


        Documento = personas.dni
        Cliente = personas.nombre & " " & personas.apellidos
        direccion_ = personas.apellidos


        Dim Linea_cliente_1 As String = String.Empty
        Dim Linea_cliente_2 As String = String.Empty
        Dim Linea_cliente_3 As String = String.Empty
        Dim Linea_cliente_4 As String = String.Empty
        Dim Linea_Direccion_1 As String = String.Empty
        Dim Linea_Direccion_2 As String = String.Empty
        Dim Linea_Direccion_3 As String = String.Empty
        Dim Linea_Direccion_4 As String = String.Empty

        If Cliente.Length <= 35 Then
            Linea_cliente_1 = Cliente
        ElseIf Cliente.Length > 35 And Cliente.Length <= 78 Then
            Linea_cliente_1 = Cliente.Substring(0, 35)
            Linea_cliente_2 = Cliente.Substring(35, Cliente.Length - 35)
        ElseIf Cliente.Length > 78 And Cliente.Length <= 121 Then
            Linea_cliente_1 = Cliente.Substring(0, 35)
            Linea_cliente_2 = Cliente.Substring(35, 43)
            Linea_cliente_3 = Cliente.Substring(78, Cliente.Length - 78)
        ElseIf Cliente.Length > 121 Then
            Linea_cliente_1 = Cliente.Substring(0, 35)
            Linea_cliente_2 = Cliente.Substring(35, 43)
            Linea_cliente_3 = Cliente.Substring(78, 43)
            Linea_cliente_4 = Cliente.Substring(121, Cliente.Length - 121)
        End If

        If direccion_.Length <= 33 Then
            Linea_Direccion_1 = direccion_
        ElseIf direccion_.Length > 33 And direccion_.Length <= 76 Then
            Linea_Direccion_1 = direccion_.Substring(0, 33)
            Linea_Direccion_2 = direccion_.Substring(33, direccion_.Length - 33)
        ElseIf direccion_.Length > 76 And direccion_.Length <= 119 Then
            Linea_Direccion_1 = direccion_.Substring(0, 33)
            Linea_Direccion_2 = direccion_.Substring(33, 43)
            Linea_Direccion_3 = direccion_.Substring(76, direccion_.Length - 76)
        ElseIf direccion_.Length > 119 Then
            Linea_Direccion_1 = direccion_.Substring(0, 33)
            Linea_Direccion_2 = direccion_.Substring(33, 43)
            Linea_Direccion_3 = direccion_.Substring(76, 43)
            Linea_Direccion_4 = direccion_.Substring(119, direccion_.Length - 119)
        End If

        Pagina_Web = "www.mipaginaweb.com.pe"

        Parrafo = New Rectangle(0, 5, 255, 30)
        e.Graphics.DrawString("Titulo", fontTitulo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 35, 255, 15)
        e.Graphics.DrawString("Nombre Empresa", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 50, 255, 25)
        e.Graphics.DrawString("Dirección Empresa", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 75, 255, 15)
        e.Graphics.DrawString("Ubigeo Empresa", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 90, 255, 15)
        e.Graphics.DrawString("Telefono empresa", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 105, 255, 15)
        e.Graphics.DrawString("correoelectronico@hotmail.com", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)

        Parrafo = New Rectangle(0, 120, 255, 15)
        e.Graphics.DrawString("RUC : 12345678910", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)

        Subtotal = comprobantes.subtotal
        Descuento = comprobantes.descuento
        IGV = comprobantes.igv
        Total = comprobantes.total
        Pie_Pagina = "Pie de pagina comprobante"

        Parrafo = New Rectangle(0, 135, 255, 15)
        e.Graphics.DrawString("FECHA Y HORA : " & comprobantes.fechahora, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 150, 255, 15)
        e.Graphics.DrawString("N° INTERNO " & (comprobantes.numero + 10), fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        If comprobantes.tipocomprobante = "01" Then
            Parrafo = New Rectangle(0, 165, 255, 15)
            e.Graphics.DrawString("FACTURA ELECTRÓNICA", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        Else
            Parrafo = New Rectangle(0, 165, 255, 15)
            e.Graphics.DrawString("BOLETA ELECTRÓNICA", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        End If
        Parrafo = New Rectangle(0, 180, 255, 15)
        e.Graphics.DrawString("SERIE: " & comprobantes.serie & "     NUMERO: " & comprobantes.numero, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 200, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 215, 255, 15)
        e.Graphics.DrawString("DOCUMENTO: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(35, 215, 235, 15)
        e.Graphics.DrawString("           " & Documento, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 230, 255, 15)
        e.Graphics.DrawString("CLIENTE: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(25, 230, 235, 15)
        e.Graphics.DrawString("         " & Linea_cliente_1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        If Linea_cliente_2.Length = Nothing Then
            cont = 230
        Else
            cont = 245
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_cliente_2, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        If Linea_cliente_3.Length = Nothing Then
            cont = cont
        Else
            cont = cont + 15
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_cliente_3, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        If Linea_cliente_4.Length = Nothing Then
            cont = cont
        Else
            cont = cont + 15
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_cliente_4, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        Parrafo = New Rectangle(0, cont + 15, 255, 15)
        e.Graphics.DrawString("DIRECCION: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(30, cont + 15, 235, 15)
        e.Graphics.DrawString("           " & Linea_Direccion_1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        If Linea_Direccion_2.Length = Nothing Then
            cont = cont + 15
        Else
            cont = cont + 30
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_Direccion_2, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        If Linea_Direccion_3.Length = Nothing Then
            cont = cont
        Else
            cont = cont + 15
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_Direccion_3, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        If Linea_Direccion_4.Length = Nothing Then
            cont = cont
        Else
            cont = cont + 15
        End If
        Parrafo = New Rectangle(0, cont, 255, 15)
        e.Graphics.DrawString(Linea_Direccion_4, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        cont = cont + 15
        Parrafo = New Rectangle(0, cont, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)

        Parrafo = New Rectangle(0, cont + 23, 120, 12)
        e.Graphics.DrawString("PRODUCTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(135, cont + 23, 40, 12)
        e.Graphics.DrawString("CANT.", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(175, cont + 23, 40, 12)
        e.Graphics.DrawString("PREC.", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(210, cont + 23, 45, 12)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)

        Dim Linea As Integer = cont + 38
        Dim CantLinea As Integer = 0
        Dim contador As Integer = 0
        Dim n As Integer = 0

        For Each item As CE_detalleventas In detalle
            Dim producto As String = ConsultaProducto(item.producto_idproducto)

            If producto.Length <= 21 Then
                Parrafo = New Rectangle(0, Linea + (n * 12), 130, 12)
                e.Graphics.DrawString(producto, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                Parrafo = New Rectangle(135, Linea + (n * 12), 40, 12)
                e.Graphics.DrawString(Convert.ToString(item.cantidad).ToString, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                Parrafo = New Rectangle(175, Linea + (n * 12), 40, 12)
                e.Graphics.DrawString(item.precio, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                Parrafo = New Rectangle(210, Linea + (n * 12), 45, 12)
                e.Graphics.DrawString(item.total, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                contador += 1
                Linea += 5
            Else
                Dim linea1, linea2, linea3 As String
                If producto.Length > 42 And producto.Length <= 63 Then

                    linea1 = producto.Substring(0, 21)
                    linea2 = producto.Substring(21, 21)
                    linea3 = producto.Substring(42, producto.Length - 42)

                    Parrafo = New Rectangle(0, Linea + (n * 12), 130, 12)
                    e.Graphics.DrawString(linea1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                    Parrafo = New Rectangle(0, Linea + (n * 12) + 12, 130, 12)
                    e.Graphics.DrawString(linea2, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                    Parrafo = New Rectangle(0, Linea + (n * 12) + 24, 130, 12)
                    e.Graphics.DrawString(linea3, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                    Parrafo = New Rectangle(135, Linea + (n * 12), 40, 12)
                    e.Graphics.DrawString(Convert.ToString(item.cantidad).ToString, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Parrafo = New Rectangle(175, Linea + (n * 12), 40, 12)
                    e.Graphics.DrawString(item.precio, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Parrafo = New Rectangle(210, Linea + (n * 12), 45, 12)
                    e.Graphics.DrawString(item.total, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Linea += 29
                    contador += 1
                End If
                If producto.Length > 21 And producto.Length <= 42 Then

                    linea1 = producto.Substring(0, 21)
                    linea2 = producto.Substring(21, producto.Length - 21)

                    Parrafo = New Rectangle(0, Linea + (n * 12), 130, 12)
                    e.Graphics.DrawString(linea1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                    Parrafo = New Rectangle(0, Linea + (n * 12) + 10, 130, 12)
                    e.Graphics.DrawString(linea2, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
                    Parrafo = New Rectangle(135, Linea + (n * 12), 40, 12)
                    e.Graphics.DrawString(Convert.ToString(item.cantidad).ToString, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Parrafo = New Rectangle(175, Linea + (n * 12), 40, 12)
                    e.Graphics.DrawString(item.precio, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Parrafo = New Rectangle(210, Linea + (n * 12), 45, 12)
                    e.Graphics.DrawString(item.total, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
                    Linea += 17
                    contador += 1
                End If
            End If
            CantLinea = (contador * 12)
            n = n + 1

        Next

        Linea += CantLinea

        Parrafo = New Rectangle(200, Linea, 45, 12)
        e.Graphics.DrawString("---------------", fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 10
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("SUBTOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        e.Graphics.DrawString(Subtotal.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("DESCUENTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(Descuento.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("IGV", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(IGV.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        'Aqui se MUESTRA el precio TOTAL EN EFECTIVO
        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(Total.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(0, Linea, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)

        Linea += 12
        Parrafo = New Rectangle(0, Linea, 260, 25)
        e.Graphics.DrawString(MdlGlobal.Letras(Total.ToString, "SOLES"), fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)


        QrCodeImgControl1.Text = comprobantes.serie & "_" & comprobantes.numero & "_" & comprobantes.total & "_" & personas.nombre
        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)

        Linea += 20
        e.Graphics.DrawImage(img, 0, Linea)

        Parrafo = New Rectangle(78, Linea, 180, 50)
        If comprobantes.tipocomprobante = "01" Then
            e.Graphics.DrawString("REPRESENTACIÓN IMPRESA DE FACTURA ELECTRÓNICA, CONSULTE EN : " & Pagina_Web, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Else
            e.Graphics.DrawString("REPRESENTACIÓN IMPRESA DE BOLETA ELECTRÓNICA, CONSULTE EN : " & Pagina_Web, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        End If
        Linea += 50
        Parrafo = New Rectangle(75, Linea, 180, 15)
        e.Graphics.DrawString("AUTORIZADO MEDIANTE RESOLU-", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 15
        Parrafo = New Rectangle(70, Linea, 180, 15)
        e.Graphics.DrawString("CIÓN XXXXXXXXXXXXXX", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 18
        Parrafo = New Rectangle(0, Linea, 250, 50)
        e.Graphics.DrawString("------------------", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 50
        Parrafo = New Rectangle(0, Linea, 250, 15)
        e.Graphics.DrawString("GRACIAS POR SU COMPRA, VUELVA PRONTO", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 25
        Parrafo = New Rectangle(0, Linea, 250, 25)
        e.Graphics.DrawString("NO SE ACEPTAN DEVOLUCIONES NI CAMBIO DE PRODUCTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 30
        Parrafo = New Rectangle(0, Linea, 250, 15)
        e.Graphics.DrawString("VENDEDOR :" & _nombreusuario, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
    End Sub


    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        PD_TICKETS.Print()
        Me.Close()
    End Sub

    Private Function ConsultaProducto(id As Integer) As String
        Try
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable
            dt = cf.DT_leer(New CE_dgv With {.Tipo = 9, .Codigo_1 = id})
            Return dt.Rows(0).Item("nombre").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
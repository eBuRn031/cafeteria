Imports CapaEntidades.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Public Class FrmImpresiones
    Private nombreMesa As String
    Private persona As New CE_personas
    Private comprobantes As New CE_ventas
    Private detalle As New List(Of CE_detalleventas)
    Private pedido As New CE_pedido
    Private detallepedido As New List(Of CE_detallepedido)
    Private formulario As Integer

    Public Sub cargar_datosComprobante(_nombreMesa As String, p As CE_personas, ByVal c As CE_ventas, ByVal d As List(Of CE_detalleventas))
        nombreMesa = _nombreMesa
        persona = p
        comprobantes = c
        detalle = d
    End Sub

    Public Sub cargar_datosPedido(_nombreMesa As String, p As CE_personas, ByVal c As CE_pedido, ByVal d As List(Of CE_detallepedido))
        nombreMesa = _nombreMesa
        persona = p
        pedido = c
        detallepedido = d
    End Sub

    Private Sub FrmImpresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim cont As Integer = Nothing
        Dim Parrafo As Rectangle


        Documento = persona.dni
        Cliente = persona.nombre & " " & persona.apellidos
        direccion_ = persona.direccion


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

        Parrafo = New Rectangle(0, 5, 255, 30)
        e.Graphics.DrawString(_titulo_impresion, fontTitulo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 35, 255, 15)
        e.Graphics.DrawString(_razon_social, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 50, 255, 25)
        e.Graphics.DrawString(_direccion_empresa, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 75, 255, 15)
        e.Graphics.DrawString(_ubigeo_sucursal, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 90, 255, 15)
        e.Graphics.DrawString(_telefono_empresa, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 105, 255, 15)
        e.Graphics.DrawString(_correo_empresa, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)

        Parrafo = New Rectangle(0, 120, 255, 15)
        e.Graphics.DrawString("RUC : " & _ruc_empresa, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 135, 255, 15)
        e.Graphics.DrawString("FECHA Y HORA : " & comprobantes.fechahora, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 150, 255, 15)
        If comprobantes.tipocomprobante = "03" Then
            e.Graphics.DrawString("BOLETA ELECTRÓNICA", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        ElseIf comprobantes.tipocomprobante = "01" Then
            e.Graphics.DrawString("FACTURA ELECTRÓNICA", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        End If
        Parrafo = New Rectangle(0, 165, 255, 15)
        e.Graphics.DrawString("SERIE: " & comprobantes.serie & "     NUMERO: " & completando_ceros(comprobantes.numero), fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 185, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 200, 255, 15)
        e.Graphics.DrawString("DOCUMENTO: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(35, 200, 235, 15)
        e.Graphics.DrawString("           " & Documento, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 215, 255, 15)
        e.Graphics.DrawString("CLIENTE: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(25, 215, 235, 15)
        e.Graphics.DrawString("         " & Linea_cliente_1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        If Linea_cliente_2.Length = Nothing Then
            cont = 215
        Else
            cont = 230
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
            Dim cx As New Transaccion_lectura
            Dim dtx As New DataTable
            dtx = cx.DT_leer(New CE_dgv With {.Tipo = 18, .Codigo_1 = item.producto_idproducto})
            Dim producto As String = dtx.Rows(0).Item("nombre").ToString

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
        e.Graphics.DrawString(comprobantes.subtotal.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("DESCUENTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(comprobantes.descuento.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("IGV", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(comprobantes.igv.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        'Aqui se MUESTRA el precio TOTAL EN EFECTIVO
        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(comprobantes.total.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(0, Linea, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Linea += 12
        Parrafo = New Rectangle(0, Linea, 260, 25)
        e.Graphics.DrawString(Letras(comprobantes.total.ToString, "SOLES"), fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)


        QrCodeImgControl1.Text = _ruc_empresa & "\" & persona.dni & "\" & comprobantes.serie & "\" & comprobantes.numero & "\" & comprobantes.total & "\" & persona.dni & "\" & comprobantes.serie & "\" & comprobantes.numero & "\" & comprobantes.total
        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)

        Linea += 20
        e.Graphics.DrawImage(img, 0, Linea)
        If comprobantes.tipocomprobante = "03" Then
            Parrafo = New Rectangle(78, Linea, 180, 50)
            e.Graphics.DrawString("REPRESENTACIÓN IMPRESA DE BOLETA ELECTRÓNICA, CONSULTE EN : " & _pagina_web, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        ElseIf comprobantes.tipocomprobante = "01" Then
            Parrafo = New Rectangle(78, Linea, 180, 50)
            e.Graphics.DrawString("REPRESENTACIÓN IMPRESA DE FACTURA ELECTRÓNICA, CONSULTE EN : " & _pagina_web, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        End If
        Linea += 50
        Parrafo = New Rectangle(75, Linea, 180, 15)
        e.Graphics.DrawString("AUTORIZADO MEDIANTE RESOLU-", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 15
        Parrafo = New Rectangle(70, Linea, 180, 15)
        e.Graphics.DrawString("CIÓN 546-1AS546232645876", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 10
        Parrafo = New Rectangle(0, Linea, 250, 50)
        e.Graphics.DrawString(_pie_pagina, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 35
        Parrafo = New Rectangle(0, Linea, 250, 15)
        e.Graphics.DrawString("GRACIAS POR SU COMPRA, VUELVA PRONTO", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)

        Dim cxx As New Transaccion_lectura
        Dim dtxx As New DataTable
        dtxx = cxx.DT_leer(New CE_dgv With {.Tipo = 19, .Codigo_1 = comprobantes.idusuarios})

        Linea += 15
        Parrafo = New Rectangle(0, Linea, 250, 15)
        e.Graphics.DrawString("Vendedor : " & dtxx.Rows(0).Item("perfil").ToString, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PD_TICKETS.Print()
    End Sub

    Private Sub PD_ORDENVENTA_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_OrdenVenta.PrintPage
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
        Dim cont As Integer = Nothing
        Dim Parrafo As Rectangle


        Documento = persona.dni
        Cliente = persona.nombre & " " & persona.apellidos
        direccion_ = persona.direccion


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

        Parrafo = New Rectangle(0, 5, 255, 30)
        e.Graphics.DrawString(_titulo_impresion, fontTitulo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 30, 255, 15)
        e.Graphics.DrawString("RUC : " & _ruc_empresa, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 45, 255, 15)
        e.Graphics.DrawString("FECHA Y HORA : " & pedido.fechahora, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 60, 255, 15)
        e.Graphics.DrawString("PEDIDO " & nombreMesa, fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 75, 255, 15)
        e.Graphics.DrawString("NUMERO: " & completando_ceros(pedido.numero), fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 95, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)


        Parrafo = New Rectangle(0, 110, 255, 15)
        e.Graphics.DrawString("DOCUMENTO: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(35, 110, 235, 15)
        e.Graphics.DrawString("           " & Documento, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 125, 255, 15)
        e.Graphics.DrawString("CLIENTE: ", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(25, 125, 235, 15)
        e.Graphics.DrawString("         " & Linea_cliente_1, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        If Linea_cliente_2.Length = Nothing Then
            cont = 125
        Else
            cont = 140
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

        For Each item As CE_detallepedido In detallepedido
            Dim cx As New Transaccion_lectura
            Dim dtx As New DataTable
            dtx = cx.DT_leer(New CE_dgv With {.Tipo = 18, .Codigo_1 = item.producto_idproducto})
            Dim producto As String = dtx.Rows(0).Item("nombre").ToString

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


        'Aqui se MUESTRA el precio TOTAL EN EFECTIVO
        Linea += 15
        Parrafo = New Rectangle(45, Linea, 100, 12)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(190, Linea, 50, 12)
        'Aqui se MUESTRA el precio TOTAL DEL VUELTO
        e.Graphics.DrawString(pedido.total.ToString(“##,##0.00”), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 15
        Parrafo = New Rectangle(0, Linea, 255, 12)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)

        Dim cxx As New Transaccion_lectura
        Dim dtxx As New DataTable
        dtxx = cxx.DT_leer(New CE_dgv With {.Tipo = 19, .Codigo_1 = pedido.idusuarios})

        Linea += 15
        Parrafo = New Rectangle(0, Linea, 250, 15)
        e.Graphics.DrawString("Vendedor : " & dtxx.Rows(0).Item("perfil").ToString, fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
    End Sub

End Class
Imports System.IO
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Module MdlGlobal

    Public _idusuario As Integer
    Public _nombreusuario As String
    Public _tipoUsuario As String

    'datos de la empresa y sucursal
    Public _ruc_empresa As String
    Public _razon_social As String
    Public _titulo_impresion As String
    Public _direccion_empresa As String
    Public _telefono_empresa As String
    Public _correo_empresa As String
    Public _pagina_web As String
    Public _ubigeo_sucursal As String
    Public _pie_pagina As String

    Public colorSeleccion As Color = Color.Teal
    Public colorAlternado As Color = Color.Lavender

#Region "CARGAR COMBOBOX"

    ' todas las consultas deben de contener los campos codigo y nombre
    Sub Cargar_Combobox_General(ByVal com As ComboBox, ByVal CE_dgv As CE_dgv, ByVal texto As String, ByVal valor As String)
        Try
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable
            dt = cf.DT_leer(CE_dgv)
            If (dt.Rows.Count > Nothing) Then
                com.DataSource = dt
                com.DisplayMember = texto
                com.ValueMember = valor
                com.DropDownWidth = DropDownWidth(com)
            Else
                com.DataSource = Nothing
                com.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Cargar_Combobox_General(ByVal com As ComboBox, ByVal dt As DataTable, ByVal texto As String, ByVal valor As String)
        Try
            If (dt.Rows.Count > Nothing) Then
                com.DataSource = dt
                com.DisplayMember = texto
                com.ValueMember = valor
                com.DropDownWidth = DropDownWidth(com)
            Else
                com.DataSource = Nothing
                com.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' le da tamaño al desplegable del combobox
    Public Function DropDownWidth(ByVal myCombo As ComboBox) As Integer
        Dim maxWidth As Integer = 0
        For Each obj In myCombo.Items
            Dim temp As Integer = TextRenderer.MeasureText(myCombo.GetItemText(obj), myCombo.Font).Width
            If temp > maxWidth Then
                maxWidth = temp
            End If
        Next
        Return maxWidth
    End Function

#End Region

#Region "Imagen"

    'convertir binario a imágen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'CONVERTIR IMAGEN EN BINARIO
    'convertir imagen a binario
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Reniec"
    Public Function ConsultaDNI(ByVal dni As String) As String
        Try
            Dim ce As New Reniec
            Return ce.Consulta(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Sunat"
    Public Function ConsultaRUC(ByVal ruc As String) As Object
        Try
            Dim ce As New Sunat
            Return ce.Consulta(ruc)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

#End Region

#Region "DE NUMERO A LETRAS"
    Public Function Letras(ByVal numero As String, ByVal moneda As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length).ToString
            palabras = "MENOS "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "CIEN "
                                Else
                                    palabras = palabras & "CIENTO "
                                End If
                            Case "2"
                                palabras = palabras & "DOSCIENTOS "
                            Case "3"
                                palabras = palabras & "TRESCIENTOS "
                            Case "4"
                                palabras = palabras & "CUATROCIENTOS "
                            Case "5"
                                palabras = palabras & "QUINIENTOS "
                            Case "6"
                                palabras = palabras & "SEISCIENTOS "
                            Case "7"
                                palabras = palabras & "SETECIENTOS "
                            Case "8"
                                palabras = palabras & "OCHOCIENTOS "
                            Case "9"
                                palabras = palabras & "NOVECIENTOS "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "DIEZ "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "ONCE "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "DOCE "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "TRECE "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "CATORCE "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "QUINCE "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "DIECI"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "VEINTE "
                                    flag = "S"
                                Else
                                    palabras = palabras & "VEINTI"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "TREINTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "TREINTA Y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "CUARENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "CUARENTA Y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "CINCUENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "CINCUENTA Y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "SESENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "SESENTA Y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "SETENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "SETENTA Y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "OCHENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "OCHENTA Y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "NOVENTA "
                                    flag = "S"
                                Else
                                    palabras = palabras & "NOVENTA Y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "UNO "
                                    Else
                                        palabras = palabras & "UN "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "DOS "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "TRES "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "CUATRO "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "CINCO "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "SEIS "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "SIETE "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "OCHO "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "NUEVE "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                Len(entero) <= 6) Then palabras = palabras & "MIL "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "MILLÓN "
                    Else
                        palabras = palabras & "MILLONES "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = "SON : " & palabras & "CON " & dec & "/100 " & moneda
            Else
                Letras = "SON : " & palabras & " " & moneda
            End If
        Else
            Letras = ""
        End If
    End Function

#End Region

#Region "COMPLETANDO CON CEROS"
    Public Function completando_ceros(ByVal cad As String) As String
        If cad.Length = 1 Then
            cad = "0000000" & cad
        End If
        If cad.Length = 2 Then
            cad = "000000" & cad
        End If
        If cad.Length = 3 Then
            cad = "00000" & cad
        End If
        If cad.Length = 4 Then
            cad = "0000" & cad
        End If
        If cad.Length = 5 Then
            cad = "000" & cad
        End If
        If cad.Length = 6 Then
            cad = "00" & cad
        End If
        If cad.Length = 7 Then
            cad = "0" & cad
        End If
        Return cad
    End Function
#End Region

#Region "ESTILO GRILLAS"
    Sub style_grilla(ByVal dgv As DataGridView)
        dgv.AllowUserToAddRows = False
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.EnableHeadersVisualStyles = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = colorAlternado
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = colorSeleccion
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
           Or System.Windows.Forms.AnchorStyles.Left) _
           Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    End Sub
#End Region

#Region "PRINCIPAL"
    Sub mostrarPrincipal()
        Dim frmCollection As New FormCollection()
        frmCollection = Application.OpenForms()
        Try
            If frmCollection.Item("frmPrincipal").IsHandleCreated Then
                Dim frmx As Form = frmCollection.Item("frmPrincipal")
                frmx.BringToFront()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub ocultarPrincipal()
        'Dim frmCollection As New FormCollection()
        'frmCollection = Application.OpenForms()
        'Try
        '    If frmCollection.Item("frmPrincipal").IsHandleCreated Then
        '        Dim frmx As Form = frmCollection.Item("frmPrincipal")
        '        frmx.SendToBack()
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

#End Region

End Module

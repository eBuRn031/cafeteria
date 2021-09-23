Imports System.IO
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Module MdlGlobal

    Public _idusuario As Integer = 1

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

#Region "DGV"
    Sub AlternarColoresDgv(ByVal dgv As DataGridView)
        dgv.RowsDefaultCellStyle.BackColor = Color.LightGray
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
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

End Module

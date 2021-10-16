Imports RestSharp

Public Class Sunat
    Public Function Consulta(ByVal ruc As String) As Persona
        Try
            ' PAGINA DE LA API https://api.migo.pe
            'DESDE AQUI
            Dim token As String = "46R9JKhwVIGRsviCcSWCOS4Cf4vfLx92ZwDOkuj89Xmc2es8UBmYPIyffDG0"

            Dim client As New RestClient()
            client.BaseUrl = New Uri("https://api.migo.pe/api/v1")

            Dim request = New RestRequest("/ruc", Method.POST)
            request.AddHeader("Accept", "application/json")
            request.AddParameter("token", token)
            request.AddParameter("ruc", ruc)

            ' Usar este bloque si solo quiere ver los valores devueltos
            'Dim responseData As IRestResponse = client.Execute(request)
            'System.Console.WriteLine(responseData.Content)

            Dim response As IRestResponse(Of Persona) = client.Execute(Of Persona)(request)

            If response.IsSuccessful Then
                Dim content As Persona = response.Data
                Return content
                'Console.WriteLine(content.Dni)
                'Console.WriteLine(content.Nombre)
                'Console.Read()
            Else
                Return Nothing
                'Console.WriteLine(response.ErrorMessage)
                'Console.Read()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Class Persona
        Public Property Ruc
        Public Property NombreORazonSocial
        Public Property EstadoDelContribuyente
        Public Property CondicionDeDomicilio
        Public Property Ubigeo
        Public Property TipoDeVia
        Public Property NombreDeVia
        Public Property CodigoDeZona
        Public Property TipoDeZona
        Public Property Numero
        Public Property Interior
        Public Property Lote
        Public Property Dpto
        Public Property Manzana
        Public Property Kilometro
        Public Property Distrito
        Public Property Provincia
        Public Property Departamento
        Public Property Direccion
    End Class

End Class

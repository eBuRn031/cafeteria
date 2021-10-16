Imports RestSharp

Public Class Reniec
    Public Function Consulta(ByVal dni As String) As String
        Try
            ' PAGINA DE LA API https://api.migo.pe
            'DESDE AQUI
            Dim token As String = "46R9JKhwVIGRsviCcSWCOS4Cf4vfLx92ZwDOkuj89Xmc2es8UBmYPIyffDG0"

            Dim client As New RestClient()
            client.BaseUrl = New Uri("https://api.migo.pe/api/v1")

            Dim request = New RestRequest("/dni", Method.POST)
            request.AddHeader("Accept", "application/json")
            request.AddParameter("token", token)
            request.AddParameter("dni", dni)

            ' Usar este bloque si solo quiere ver los valores devueltos
            'Dim responseData As IRestResponse = client.Execute(request)
            'System.Console.WriteLine(responseData.Content)

            Dim response As IRestResponse(Of Persona) = client.Execute(Of Persona)(request)

            If response.IsSuccessful Then
                Dim content As Persona = response.Data
                Return content.Nombre
                'Console.WriteLine(content.Dni)
                'Console.WriteLine(content.Nombre)
                'Console.Read()
            Else
                Return String.Empty
                'Console.WriteLine(response.ErrorMessage)
                'Console.Read()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Class Persona
        Public Property Dni As String
        Public Property Nombre As String
    End Class

End Class

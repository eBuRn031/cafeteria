Imports System.Net
Imports MySql.Data.MySqlClient

Namespace ClaseCodeDOM
    Public Class Conexion
        Protected cnn As MySqlConnection

        Public SERVERNAME As String = "localhost"
        Public DATABASENAME As String = "cafeteria"
        Public USEID As String = "root"
        Public Password As String = "root"
        Public SERVERIP As String = IpComputadora()
        Public conexion_base As String = "server=" & SERVERNAME & ";database=" & DATABASENAME & ";user id=" & USEID & ";password=" & Password & ";"

        Private Function IpComputadora() As String
            Dim Ip_Pc As String
            Ip_Pc = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
            Return Ip_Pc
        End Function

        Public Function Conectar()
            Try
                cnn = New MySqlConnection(conexion_base)
                cnn.Open()
                Return True
            Catch ex As Exception
                MsgBox("ERROR AL CONECTARSE. ERROR : " + ex.Message)
                Return False
            End Try
        End Function

        Public Function Desconectar()
            Try
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                    cnn.Dispose()
                Else
                    Return True
                End If
            Catch ex As Exception
                MsgBox("ERROR : " + ex.Message)
                Return False
            End Try
            Return False
        End Function

    End Class

End Namespace


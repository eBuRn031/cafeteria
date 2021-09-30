'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports MySql.Data.MySqlClient
Imports System.Transactions

Namespace ClaseCodeDOM

    Public Class Transaccion_pedido
        Inherits Conexion

        Private cmd As MySqlCommand

        Public Overridable Function SP_pedido(ByVal CE_pedido As CE_pedido) As Boolean

            Dim boolpedido As Boolean
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_pedido As New CD_pedido ' =  ----------------------DEFINE pedido ---------------
                        boolpedido = cd_pedido.SP_pedido(CE_pedido, conexion) ' =  ---------------------- VALOR PARA pedido ---------------

                        If boolpedido Then
                            boolvalidador = True
                            Scope.Complete()
                        Else
                            boolvalidador = False
                        End If
                        Return boolvalidador
                    Catch ex As Exception
                        boolvalidador = False
                        Return boolvalidador
                    Finally
                        conexion.Close()
                    End Try
                End Using

            End Using

            ' =  ------------ INSTRUCCIONES ------------
        End Function

        Public Overridable Function DT_pedido(ByVal CE_pedido As CE_pedido) As DataTable

            Dim dtpedido As New DataTable
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_pedido As New CD_pedido ' =  ----------------------DEFINE pedido ---------------
                        dtpedido = cd_pedido.DT_pedido(CE_pedido, conexion) ' =  ---------------------- VALOR PARA pedido ---------------

                        If dtpedido.Rows.Count > 0 Then
                            boolvalidador = True
                            Scope.Complete()
                        Else
                            boolvalidador = False
                        End If
                        Return dtpedido
                    Catch ex As Exception
                        boolvalidador = False
                        'return  dtpedido
                    Finally
                        conexion.Close()
                    End Try
                End Using

            End Using

            ' =  ------------ INSTRUCCIONES ------------
        End Function
    End Class
End Namespace

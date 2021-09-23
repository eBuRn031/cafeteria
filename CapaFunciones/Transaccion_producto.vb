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

    Public Class Transaccion_producto
        Inherits Conexion

        Private cmd As MySqlCommand

        Public Overridable Function SP_producto(ByVal CE_producto As CE_producto) As Boolean

            Dim boolproducto As Boolean
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_producto As New CD_producto ' =  ----------------------DEFINE producto ---------------
                        boolproducto = cd_producto.SP_producto(CE_producto, conexion) ' =  ---------------------- VALOR PARA producto ---------------

                        If boolproducto Then
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

        Public Overridable Function DT_producto(ByVal CE_producto As CE_producto) As DataTable

            Dim dtproducto As New DataTable
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_producto As New CD_producto ' =  ----------------------DEFINE producto ---------------
                        dtproducto = cd_producto.DT_producto(CE_producto, conexion) ' =  ---------------------- VALOR PARA producto ---------------

                        If dtproducto.Rows.Count > 0 Then
                            boolvalidador = True
                            Scope.Complete()
                        Else
                            boolvalidador = False
                        End If
                        Return dtproducto
                    Catch ex As Exception
                        boolvalidador = False
                        'return  dtproducto
                    Finally
                        conexion.Close()
                    End Try
                End Using

            End Using

            ' =  ------------ INSTRUCCIONES ------------
        End Function
    End Class
End Namespace

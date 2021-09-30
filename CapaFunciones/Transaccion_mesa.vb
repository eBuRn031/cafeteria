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

    Public Class Transaccion_mesa
        Inherits Conexion

        Private cmd As MySqlCommand

        Public Overridable Function SP_mesa(ByVal CE_mesa As CE_mesa) As Boolean

            Dim boolmesa As Boolean
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_mesa As New CD_mesa ' =  ----------------------DEFINE mesa ---------------
                        boolmesa = cd_mesa.SP_mesa(CE_mesa, conexion) ' =  ---------------------- VALOR PARA mesa ---------------

                        If boolmesa Then
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

        Public Overridable Function DT_mesa(ByVal CE_mesa As CE_mesa) As DataTable

            Dim dtmesa As New DataTable
            Dim boolvalidador As Boolean

            Using Scope As New TransactionScope()
                Using conexion As New MySqlConnection(conexion_base)
                    Try
                        conexion.Open() ' = ABRIENDO CONEXION
                        Dim cd_mesa As New CD_mesa ' =  ----------------------DEFINE mesa ---------------
                        dtmesa = cd_mesa.DT_mesa(CE_mesa, conexion) ' =  ---------------------- VALOR PARA mesa ---------------

                        If dtmesa.Rows.Count > 0 Then
                            boolvalidador = True
                            Scope.Complete()
                        Else
                            boolvalidador = False
                        End If
                        Return dtmesa
                    Catch ex As Exception
                        boolvalidador = False
                        'return  dtmesa
                    Finally
                        conexion.Close()
                    End Try
                End Using

            End Using

            ' =  ------------ INSTRUCCIONES ------------
        End Function
    End Class
End Namespace

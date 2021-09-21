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
    
    Public Class Transaccion_detalleventas
        Inherits Conexion
        
        Private cmd As MySqlCommand
        
        Public Overridable Function SP_detalleventas(ByVal CE_detalleventas As CE_detalleventas) As Boolean
            
Dim booldetalleventas as Boolean
Dim boolvalidador as Boolean

Using Scope As New TransactionScope()
       Using conexion As New MySqlConnection(conexion_base)
try
       conexion.Open() ' = ABRIENDO CONEXION
            Dim cd_detalleventas as new cd_detalleventas' =  ----------------------DEFINE detalleventas ---------------
            booldetalleventas = CD_detalleventas.SP_detalleventas(CE_detalleventas, conexion)' =  ---------------------- VALOR PARA detalleventas ---------------
                   
if booldetalleventas then    
boolvalidador = true
Scope.Complete()
else
boolvalidador = false
end if
return boolvalidador
Catch ex As Exception
boolvalidador = false
return boolvalidador
Finally
 conexion.Close()
 End Try
End Using

       End Using
 
      ' =  ------------ INSTRUCCIONES ------------
        End Function
        
        Public Overridable Function DT_detalleventas(ByVal CE_detalleventas As CE_detalleventas) As DataTable
            
Dim dtdetalleventas as new DataTable
Dim boolvalidador as Boolean

Using Scope As New TransactionScope()
       Using conexion As New MySqlConnection(conexion_base)
try
       conexion.Open() ' = ABRIENDO CONEXION
            Dim cd_detalleventas as new cd_detalleventas' =  ----------------------DEFINE detalleventas ---------------
            dtdetalleventas = CD_detalleventas.DT_detalleventas(CE_detalleventas, conexion)' =  ---------------------- VALOR PARA detalleventas ---------------
                   
if dtdetalleventas.rows.count > 0 then    
boolvalidador = true
Scope.Complete()
else
boolvalidador = false
end if
return dtdetalleventas
Catch ex As Exception
boolvalidador = false
'return  dtdetalleventas
Finally
 conexion.Close()
 End Try
End Using

       End Using
 
      ' =  ------------ INSTRUCCIONES ------------
        End Function
    End Class
End Namespace

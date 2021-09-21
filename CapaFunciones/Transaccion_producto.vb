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
            
Dim boolproducto as Boolean
Dim boolvalidador as Boolean

Using Scope As New TransactionScope()
       Using conexion As New MySqlConnection(conexion_base)
try
       conexion.Open() ' = ABRIENDO CONEXION
            Dim cd_producto as new cd_producto' =  ----------------------DEFINE producto ---------------
            boolproducto = CD_producto.SP_producto(CE_producto, conexion)' =  ---------------------- VALOR PARA producto ---------------
                   
if boolproducto then    
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
        
        Public Overridable Function DT_producto(ByVal CE_producto As CE_producto) As DataTable
            
Dim dtproducto as new DataTable
Dim boolvalidador as Boolean

Using Scope As New TransactionScope()
       Using conexion As New MySqlConnection(conexion_base)
try
       conexion.Open() ' = ABRIENDO CONEXION
            Dim cd_producto as new cd_producto' =  ----------------------DEFINE producto ---------------
            dtproducto = CD_producto.DT_producto(CE_producto, conexion)' =  ---------------------- VALOR PARA producto ---------------
                   
if dtproducto.rows.count > 0 then    
boolvalidador = true
Scope.Complete()
else
boolvalidador = false
end if
return dtproducto
Catch ex As Exception
boolvalidador = false
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

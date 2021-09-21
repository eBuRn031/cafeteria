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

Imports CapaEntidades.ClaseCodeDOM
Imports MySql.Data.MySqlClient

Namespace ClaseCodeDOM
    
    Public Class CD_usuarios
        
        Private cmd As MySqlCommand
        
        Public Overridable Function SP_usuarios(ByVal dts As CE_usuarios, ByVal cnn As MySqlConnection) As Boolean
            Try
cmd = New MySqlCommand("SP_usuarios")
cmd.CommandType = CommandType.StoredProcedure
cmd.Connection = cnn

cmd.Parameters.AddWithValue("_Tipo",dts.Tipo)' = --- BD ---
            cmd.Parameters.AddWithValue("_idusuarios", dts.idusuarios) ' =  --- VALOR PARA idusuarios | 
            cmd.Parameters.AddWithValue("_idpersonas", dts.idpersonas) ' =  --- VALOR PARA idpersonas | 
            cmd.Parameters.AddWithValue("_user", dts.user) ' =  --- VALOR PARA user | 
            cmd.Parameters.AddWithValue("_password", dts.password) ' =  --- VALOR PARA password | 
            cmd.Parameters.AddWithValue("_perfil", dts.perfil) ' =  --- VALOR PARA perfil | 
                cmd.Parameters.AddWithValue("_tipo", dts.tipo) ' =  --- VALOR PARA tipo | V vendedor
                'A administrador
                cmd.Parameters.AddWithValue("_fecreg", dts.fecreg) ' =  --- VALOR PARA fecreg | 
                cmd.Parameters.AddWithValue("_fecmod", dts.fecmod) ' =  --- VALOR PARA fecmod | 
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try ' =  --- INSTRUCCIONES ---
        End Function

        Public Overridable Function DT_usuarios(ByVal dts As CE_usuarios, ByVal cnn As MySqlConnection) As DataTable
            Try

                cmd = New MySqlCommand("SP_usuarios")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)


                cmd.Parameters.AddWithValue("_Tipo", dts.tipo) ' = --- BD ---
                cmd.Parameters.AddWithValue("_idusuarios", dts.idusuarios) ' =  --- VALOR PARA idusuarios | 
                cmd.Parameters.AddWithValue("_idpersonas", dts.idpersonas) ' =  --- VALOR PARA idpersonas | 
                cmd.Parameters.AddWithValue("_user", dts.user) ' =  --- VALOR PARA user | 
                cmd.Parameters.AddWithValue("_password", dts.password) ' =  --- VALOR PARA password | 
                cmd.Parameters.AddWithValue("_perfil", dts.perfil) ' =  --- VALOR PARA perfil | 
                cmd.Parameters.AddWithValue("_tipo", dts.tipo) ' =  --- VALOR PARA tipo | V vendedor
                'A administrador
                cmd.Parameters.AddWithValue("_fecreg", dts.fecreg) ' =  --- VALOR PARA fecreg | 
                cmd.Parameters.AddWithValue("_fecmod", dts.fecmod) ' =  --- VALOR PARA fecmod | 
                Dim dataReader = cmd.ExecuteReader()


                dt.Load(dataReader) ' =  --- INSTRUCCIONES ---
                dataReader.Close() ' =  cerrando datareader
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try' =  retorno---
        End Function
    End Class
End Namespace
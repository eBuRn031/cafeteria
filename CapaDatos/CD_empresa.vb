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

    Public Class CD_empresa

        Private cmd As MySqlCommand

        Public Overridable Function SP_empresa(ByVal dts As CE_empresa, ByVal cnn As MySqlConnection) As Boolean
            Try
                cmd = New MySqlCommand("SP_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn

                cmd.Parameters.AddWithValue("_Tipo", dts.Tipo) ' = --- BD ---
                cmd.Parameters.AddWithValue("_idempresa", dts.idempresa) ' =  --- VALOR PARA idempresa | 
                cmd.Parameters.AddWithValue("_ruc", dts.ruc) ' =  --- VALOR PARA ruc | 
                cmd.Parameters.AddWithValue("_razonsocial", dts.razonsocial) ' =  --- VALOR PARA razonsocial | 
                cmd.Parameters.AddWithValue("_titulo", dts.titulo) ' =  --- VALOR PARA titulo | 
                cmd.Parameters.AddWithValue("_direccion", dts.direccion) ' =  --- VALOR PARA direccion | 
                cmd.Parameters.AddWithValue("_telefono", dts.telefono) ' =  --- VALOR PARA telefono | 
                cmd.Parameters.AddWithValue("_correo", dts.correo) ' =  --- VALOR PARA correo | 
                cmd.Parameters.AddWithValue("_paginaweb", dts.paginaweb) ' =  --- VALOR PARA paginaweb | 
                cmd.Parameters.AddWithValue("_ubigeo", dts.ubigeo) ' =  --- VALOR PARA ubigeo | 
                cmd.Parameters.AddWithValue("_piepagina", dts.piepagina) ' =  --- VALOR PARA piepagina | 
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try ' =  --- INSTRUCCIONES ---
        End Function

        Public Overridable Function DT_empresa(ByVal dts As CE_empresa, ByVal cnn As MySqlConnection) As DataTable
            Try

                cmd = New MySqlCommand("SP_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)


                cmd.Parameters.AddWithValue("_Tipo", dts.Tipo) ' = --- BD ---
                cmd.Parameters.AddWithValue("_idempresa", dts.idempresa) ' =  --- VALOR PARA idempresa | 
                cmd.Parameters.AddWithValue("_ruc", dts.ruc) ' =  --- VALOR PARA ruc | 
                cmd.Parameters.AddWithValue("_razonsocial", dts.razonsocial) ' =  --- VALOR PARA razonsocial | 
                cmd.Parameters.AddWithValue("_titulo", dts.titulo) ' =  --- VALOR PARA titulo | 
                cmd.Parameters.AddWithValue("_direccion", dts.direccion) ' =  --- VALOR PARA direccion | 
                cmd.Parameters.AddWithValue("_telefono", dts.telefono) ' =  --- VALOR PARA telefono | 
                cmd.Parameters.AddWithValue("_correo", dts.correo) ' =  --- VALOR PARA correo | 
                cmd.Parameters.AddWithValue("_paginaweb", dts.paginaweb) ' =  --- VALOR PARA paginaweb | 
                cmd.Parameters.AddWithValue("_ubigeo", dts.ubigeo) ' =  --- VALOR PARA ubigeo | 
                cmd.Parameters.AddWithValue("_piepagina", dts.piepagina) ' =  --- VALOR PARA piepagina | 
                Dim dataReader = cmd.ExecuteReader()


                dt.Load(dataReader) ' =  --- INSTRUCCIONES ---
                dataReader.Close() ' =  cerrando datareader
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try ' =  retorno---
        End Function
    End Class
End Namespace

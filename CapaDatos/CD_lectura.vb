Imports MySql.Data.MySqlClient
Imports CapaEntidades.ClaseCodeDOM
Namespace ClaseCodeDOM
    Public Class CD_lectura
        Inherits Conexion
        Dim cmd As New MySqlCommand

        Public Function SP_DatagridView(ByVal dts As CE_dgv, ByVal cnn As MySqlConnection) As DataTable
            Try

                cmd = New MySqlCommand("SP_DGV")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.SelectCommand.Parameters.Add("_Tipo", MySqlDbType.Int32)
                da.SelectCommand.Parameters("_Tipo").Value = dts.Tipo
                da.SelectCommand.Parameters.Add("_Codigo_1", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Codigo_1").Value = dts.Codigo_1
                da.SelectCommand.Parameters.Add("_Codigo_2", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Codigo_2").Value = dts.Codigo_2
                da.SelectCommand.Parameters.Add("_Codigo_3", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Codigo_3").Value = dts.Codigo_3
                da.SelectCommand.Parameters.Add("_Nombre_1", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Nombre_1").Value = dts.Nombre_1
                da.SelectCommand.Parameters.Add("_Nombre_2", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Nombre_2").Value = dts.Nombre_2
                da.SelectCommand.Parameters.Add("_Documento", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Documento").Value = dts.Documento
                da.SelectCommand.Parameters.Add("_Marca", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Marca").Value = dts.Marca
                da.SelectCommand.Parameters.Add("_Direccion", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Direccion").Value = dts.Direccion
                da.SelectCommand.Parameters.Add("_Correo", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Correo").Value = dts.Correo
                da.SelectCommand.Parameters.Add("_Celular", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Celular").Value = dts.Celular
                da.SelectCommand.Parameters.Add("_Pagina_Web", MySqlDbType.VarChar)
                da.SelectCommand.Parameters("_Pagina_Web").Value = dts.Pagina_Web
                da.SelectCommand.Parameters.Add("_Fecha_Inicio", MySqlDbType.DateTime)
                da.SelectCommand.Parameters("_Fecha_Inicio").Value = Convert.ToDateTime(dts.Fecha_Inicio).ToString("yyyy-MM-dd HH:mm:ss")
                da.SelectCommand.Parameters.Add("_Fecha_Final", MySqlDbType.DateTime)
                da.SelectCommand.Parameters("_Fecha_Final").Value = Convert.ToDateTime(dts.Fecha_Final).ToString("yyyy-MM-dd HH:mm:ss")
                da.Fill(dt)
                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            Return Nothing
        End Function
    End Class

End Namespace

Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM
Imports CapaDatos.ClaseCodeDOM

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim cf As New Transaccion_lectura
            Dim dt As New DataTable

            dt = cf.DT_leer(New CE_dgv With {.Tipo = 27, .Codigo_1 = txtUser.Text, .Codigo_2 = txtPassword.Text})
            If dt.Rows.Count = 1 Then
                _idusuario = dt.Rows(0).Item("idusuarios")
                _nombreusuario = dt.Rows(0).Item("perfil")
                _tipoUsuario = dt.Rows(0).Item("tipo")

                Dim dtx As New DataTable
                dtx = cf.DT_leer(New CE_dgv With {.Tipo = 28})
                MdlGlobal._ruc_empresa = dtx.Rows(0).Item("ruc")
                MdlGlobal._razon_social = dtx.Rows(0).Item("razonsocial")
                MdlGlobal._titulo_impresion = dtx.Rows(0).Item("titulo")
                MdlGlobal._direccion_empresa = dtx.Rows(0).Item("direccion")
                MdlGlobal._telefono_empresa = dtx.Rows(0).Item("telefono")
                MdlGlobal._correo_empresa = dtx.Rows(0).Item("correo")
                MdlGlobal._pagina_web = dtx.Rows(0).Item("paginaweb")
                MdlGlobal._ubigeo_sucursal = dtx.Rows(0).Item("ubigeo")
                MdlGlobal._pie_pagina = dtx.Rows(0).Item("piepagina")

                If _tipoUsuario = "A" Then ' ADMINISTRADOR
                    Dim f As New frmPrincipal
                    f.Show()
                    Me.Close()
                Else ' VENDEDOR
                    Dim f As New frmMesasSeleccion
                    f.Show()
                    Me.Close()
                End If

            Else
                MsgBox("Usuario o Contraseña incorrecta, vuelva a intentar ...")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress, txtPassword.KeyPress
        ' Matriz de caracteres que deseamos controlar
        '
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c, "'"c, "="c, "¡"c, "!"c, "*"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then
            ' Deshechamos el carácter
            e.Handled = True
        End If
    End Sub

    Private Sub txt_usuario_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter, txtPassword.Enter
#Disable Warning BC42017 ' Late bound resolution
        sender.SelectAll()
#Enable Warning BC42017 ' Late bound resolution
    End Sub

End Class
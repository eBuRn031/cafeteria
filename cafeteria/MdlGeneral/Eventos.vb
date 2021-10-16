Public Class Eventos

    Sub enteros(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub decimales(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not sender.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub down(e As KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
            SendKeys.Send("{DOWN}")
        End If
    End Sub

    Sub up(e As KeyEventArgs) ' aun no lo uso
        SendKeys.Send("{TAB}")
        SendKeys.Send("{UP}")
    End Sub

    Sub left(e As KeyEventArgs) ' aun no lo uso
        SendKeys.Send("{TAB}")
        SendKeys.Send("{LEFT}")
    End Sub

    Sub right(e As KeyEventArgs) ' aun no lo uso
        SendKeys.Send("{TAB}")
        SendKeys.Send("{RIGHT}")
    End Sub

    Sub nombres(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub enter_tab(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Sub enter_tab_keydown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Sub numeric_up_seleccion(sender As Object)
        sender.Select(0, sender.Text.Length)
    End Sub

    Sub textbox_seleccion(sender As Object)
        sender.focus()
        sender.selectall()
    End Sub

    Sub enviar_tab()
        SendKeys.Send("{TAB}")
    End Sub

    Sub Decimal_Punto()
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        r.NumberFormat.NumberGroupSeparator = ""
        System.Threading.Thread.CurrentThread.CurrentCulture = r
    End Sub

    Sub abrir_pantalla_tactil()
        'Dim progFiles As String = "C:\Program Files\Common Files\Microsoft Shared\ink"
        'Dim keyboardPath As String = Path.Combine(progFiles, "TabTip.exe")
        'Process.Start(keyboardPath)
    End Sub



End Class

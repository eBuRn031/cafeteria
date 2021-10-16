Imports CapaDatos.ClaseCodeDOM
Imports CapaEntidades.ClaseCodeDOM
Imports CapaFunciones.ClaseCodeDOM

Public Class frmMesasSeleccion

    Private Sub CreaBotones()

        pnMesas.Controls.Clear()
        Dim cf As New Transaccion_lectura
        Dim dt As New DataTable
        Dim dts As New DataTable
        Dim dtNew As New DataTable
        Dim rows As DataRow()
        dt = cf.DT_leer(New CE_dgv With {.Tipo = 10})
        dts = cf.DT_leer(New CE_dgv With {.Tipo = 15})
        Dim xx, yy As Integer
        xx = 10
        yy = 10

        Dim tamaniobotonx, tamaniobotony As Integer
        tamaniobotonx = 75
        tamaniobotony = 90

        Dim tamaniopanelx, tamaniopanely As Integer
        tamaniopanelx = pnMesas.Width
        tamaniopanely = pnMesas.Height


        Dim limite As Integer = CInt(tamaniopanelx / tamaniobotonx) - 1

        If dt.Rows.Count > Nothing Then
            Dim filas As Integer = CInt(dt.Rows.Count / limite)
            Dim nfilas As Integer = 1
            Dim ncolumnas As Integer = 1
            For i = 0 To dt.Rows.Count - 1
                Dim btn As New Button()   ' Creas el objeto boton

                dtNew = New DataTable
                dtNew = dts.Clone()
                rows = dts.Select("idmesa = '" & dt.Rows(i).Item("idmesa") & "'")
                For Each dr As DataRow In rows
                    dtNew.ImportRow(dr)
                Next

                With btn
                    .Name = dt.Rows(i).Item("idmesa") ' Asignas el nombre del objeto
                    .Text = dt.Rows(i).Item("nombre")     ' Asignas el texto del objeto
                    .Location = New System.Drawing.Point(xx, yy) ' Asignas la posición del objeto
                    .Size = New System.Drawing.Size(tamaniobotonx, tamaniobotony) ' Asignas el tamaño del objeto
                    .TextAlign = ContentAlignment.BottomCenter
                    If dtNew.Rows.Count > 0 Then
                        .Image = My.Resources.mesallena
                    Else
                        .Image = My.Resources.mesavacia
                    End If

                End With

                AddHandler btn.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click

                pnMesas.Controls.Add(btn)  ' Agregas el botón al formulario.

                If ncolumnas >= limite Then
                    xx = 10
                    yy = nfilas * tamaniobotony + 10
                    nfilas += 1
                    ncolumnas = 1
                Else
                    xx = ncolumnas * tamaniobotonx + 10
                    ncolumnas += 1
                End If
            Next
        End If
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim id As Integer = CInt(CType(sender, System.Windows.Forms.Button).Name)
        Dim nombre As String = CType(sender, System.Windows.Forms.Button).Text
        Dim frm As New frmOpcionesVenta(id, nombre)
        frm.ShowDialog()
    End Sub

    Private Sub frmMesasSeleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaBotones()
    End Sub

End Class
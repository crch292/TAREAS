Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles vender.Click

        If (IsNumeric(tcantidad.Text)) Then
            asignarPrecio(CChar(cbcine.SelectedItem), CInt(cbfuncion.SelectedItem), Val(tcantidad.Text))
            tcantidad.Clear()
            cbcine.Refresh()
            cbfuncion.Refresh()
        Else
            MsgBox("Ingrese unicamente valores numericos enteros", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim a As Char
        a = cbcine.SelectedItem
        ListaPrecios.Items.Add(Precios(1))


    End Sub



    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiarListasyvectores()
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        If (MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok) Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class

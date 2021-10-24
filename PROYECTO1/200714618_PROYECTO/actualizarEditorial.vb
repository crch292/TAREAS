Public Class actualizar_Editorial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizarEditorial()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GestionarEditorial.Show()
        cargarEditorial()
        Me.Close()
    End Sub
End Class
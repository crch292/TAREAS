Public Class Consultas
    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        buscarNit(tnitconsulta.Text)
    End Sub

    Private Sub bregresar_Click(sender As Object, e As EventArgs) Handles bregresar.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
Public Class PrestarLibros
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub bregresarprestarlibros_Click(sender As Object, e As EventArgs) Handles bregresarprestarlibros.Click
        cliente.Show()
        Me.Close()
    End Sub
End Class
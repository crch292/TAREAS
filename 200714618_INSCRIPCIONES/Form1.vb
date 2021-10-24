Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cnivel.SelectedIndexChanged
        If cnivel.SelectedIndex = 1 Then
            Label4.Visible = True
            ccarrera.Visible = True
        Else
            Label4.Visible = False
            ccarrera.Visible = False
        End If
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        nombre = tnombre.Text
        carnet = tcarnet.Text
        nivel = cnivel.SelectedItem
        carrera = ccarrera.SelectedItem
        data(indice, 0) = nombre
        data(indice, 1) = carnet
        data(indice, 2) = nivel
        data(indice, 3) = carrera
        indice = indice + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        t.Text = data(2, 0)
    End Sub
End Class

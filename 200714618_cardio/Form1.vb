Public Class Form1
    Private Sub PROCESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESARToolStripMenuItem.Click
        Dim la As String
        If (ComboBox1.SelectedIndex = 0) Then
            la = "Majadas"
        Else
            la = "Multimedica"
        End If
        VerExamenes()
        asignarPrecio()
        llenarVectores(TextBox1.Text, TextBox2.Text, ComboBox2.SelectedText, la)



    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiarvectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()
    End Sub
End Class

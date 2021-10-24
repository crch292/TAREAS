Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datos(4, 2) As String
        Dim fila As Integer
        For fila = 0 To 3
            datos(fila, 0) = "carlos"
            datos(fila, 1) = "carrera"
            dat.Rows.Add(datos(fila, 0), datos(fila, 1))
        Next


    End Sub
End Class

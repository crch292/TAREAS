Imports System.Data.SqlClient
Public Class administrador
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarEditorial()
        GestionarEditorial.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cadena As String
        Dim elementos(10) As String
        cadena = "SELECT nombre FROM Editorial"
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        Dim registro As SqlDataReader
        registro = micomando.ExecuteReader()
        Do While registro.Read() = True
            GestionarLibros.comboeditorial.Items.Add(registro("nombre"))
        Loop
        miconexion.Close()
        GestionarLibros.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Reportes.Show()
        Me.Close()

    End Sub
End Class
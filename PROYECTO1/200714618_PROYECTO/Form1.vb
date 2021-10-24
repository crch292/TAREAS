Imports System.Data.SqlClient
Public Class Login
    Private Sub bingresar_Click(sender As Object, e As EventArgs) Handles bingresar.Click
        Dim usua As String
        Dim contra As String
        Dim cadena As String
        usua = tusuario.Text
        contra = tcontrasenia.Text
        cadena = "SELECT usuario, contrasenia, tipo_usr FROM Usuario Where usuario='" + usua + "' And contrasenia='" + contra + "'"
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        Dim registro As SqlDataReader
        registro = micomando.ExecuteReader()
        Do While registro.Read() = True
            loginusuario = registro("usuario")
            logincontrasenia = registro("contrasenia")
            logintipo = registro("tipo_usr")
        Loop
        miconexion.Close()

        If usua = loginusuario And contra = logincontrasenia Then
            If logintipo = "Administrador" Then
                administrador.Show()
                Me.Visible = False
            Else
                If logintipo = "Cliente" Then
                    cliente.Show()
                    Me.Visible = False
                End If
            End If
        Else
            MsgBox("Usuario no esta registrado, ingrese a registrarse", MsgBoxStyle.OkOnly, "Usuario Nuevo")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        probarConexion()
    End Sub

    Private Sub bregistrarse_Click(sender As Object, e As EventArgs) Handles bregistrarse.Click
        RegistrarUsuario.Show()
        Me.Visible = False
    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        If (MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub
End Class

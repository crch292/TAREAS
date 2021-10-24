Imports System.Data.SqlClient
Module logica
    Public miconexion As SqlConnection
    Public micomando As SqlCommand
    Public loginusuario As String
    Public logincontrasenia As String
    Public logintipo As String
    Public nombreeditorial As String
    Public direccioneditorial As String
    Public telefonoeditorial As String
    Public ideditorial As String
    Public nombreem As String
    Public direccionem As String
    Public telefonoem As String
    Public Sub Conexion()
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")

        Try
            'Open the connection.
            miconexion.Open()

            If miconexion.State() = 1 Then
                MsgBox("se conecto exitosamente")
            Else
                MsgBox("error")
            End If

            miconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "error")
        End Try

    End Sub

    Public Sub cargarEditorial()
        Dim cadena As String
        cadena = "SELECT * FROM Editorial"
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        Dim registro As SqlDataReader
        registro = micomando.ExecuteReader()
        Do While registro.Read() = True
            GestionarEditorial.datagestionareditorial.Rows.Add(registro("id_editorial"), registro("nombre"), registro("direccion"), registro("telefono"))

        Loop
        miconexion.Close()
    End Sub

    Public Sub insertarEditorial()
        Dim cadena As String
        nombreeditorial = GestionarEditorial.tnombreeditorial.Text
        direccioneditorial = GestionarEditorial.tdireccioneditorial.Text
        telefonoeditorial = GestionarEditorial.ttelefonoeditorial.Text
        cadena = "insert into Editorial(nombre,direccion,telefono) values('" + nombreeditorial + "','" + direccioneditorial + "'," + telefonoeditorial + ")"
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        micomando.ExecuteNonQuery()
        miconexion.Close()
    End Sub

    Public Sub actualizarEditorial()
        Dim cadena As String
        nombreeditorial = actualizar_Editorial.tnombreae.Text
        direccioneditorial = actualizar_Editorial.tdireccionae.Text
        telefonoeditorial = actualizar_Editorial.ttelefonoae.Text
        cadena = "Update Editorial set nombre='" + nombreeditorial + "',direccion ='" + direccioneditorial + "', telefono=" + telefonoeditorial + " Where id_editorial=" + ideditorial
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        micomando.ExecuteNonQuery()
        miconexion.Close()
    End Sub

    Public Sub eliminarEditorial()
        Dim cadena As String
        cadena = "Delete From Editorial Where id_editorial=" + ideditorial
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")
        miconexion.Open()
        micomando = New SqlCommand(cadena, miconexion)
        micomando.ExecuteNonQuery()
        miconexion.Close()
    End Sub

    Public Sub probarConexion()
        miconexion = New SqlConnection("server=CARLOS\SQLEXPRESS ; database=BD_200714618 ; integrated security = true")

        Try
            miconexion.Open()

            If miconexion.State() = 1 Then
                MsgBox("CONEXION EXITOSA")
            Else
                MsgBox("VERIFIQUE CONEXION")
            End If

            miconexion.Close()

        Catch excepcion As Exception
            MsgBox(excepcion.Message(), , "ERROR")
        End Try

    End Sub

End Module

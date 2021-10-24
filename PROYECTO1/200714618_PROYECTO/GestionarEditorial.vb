Imports System.Data.SqlClient
Public Class GestionarEditorial
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        administrador.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AgregarEditorial.Click
        If tnombreeditorial.Text = " " And tdireccioneditorial.Text = " " Then
            MsgBox("No puede ingresar datos nulos", MsgBoxStyle.OkOnly)
        Else
            insertarEditorial()
            tnombreeditorial.Clear()
            tdireccioneditorial.Clear()
            tdireccioneditorial.Clear()
            tnombreeditorial.Focus()
            datagestionareditorial.Rows.Clear()
            cargarEditorial()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ModificarEditorial.Click
        ideditorial = datagestionareditorial.Rows(datagestionareditorial.CurrentRow.Index).Cells(0).Value
        direccionem = datagestionareditorial.Rows(datagestionareditorial.CurrentRow.Index).Cells(2).Value
        nombreem = datagestionareditorial.Rows(datagestionareditorial.CurrentRow.Index).Cells(1).Value
        telefonoem = datagestionareditorial.Rows(datagestionareditorial.CurrentRow.Index).Cells(3).Value
        actualizar_Editorial.tnombreae.Text = nombreem
        actualizar_Editorial.tdireccionae.Text = direccionem
        actualizar_Editorial.ttelefonoae.Text = telefonoem
        actualizar_Editorial.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Eliminareditorial.Click
        ideditorial = datagestionareditorial.Rows(datagestionareditorial.CurrentRow.Index).Cells(0).Value
        logica.eliminarEditorial()
        cargarEditorial()
    End Sub
End Class
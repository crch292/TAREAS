Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (IsNumeric(tnit.Text) = True) And (IsNumeric(tdias.Text) = True) And (IsNumeric(thonorarios.Text) = True) Then
            IngresarDatos(tnombre.Text, tnit.Text, tdias.Text, thonorarios.Text, combohabitacion.SelectedItem, combopago.SelectedItem)
        Else
            MsgBox("ingrese valores numericos en Nit, dias hospitalizado, honorarios", MsgBoxStyle.OkOnly, "Datos erroneos")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tnombre.Clear()
        tnit.Clear()
        tdias.Clear()
        thonorarios.Clear()
        combohabitacion.Refresh()
        combopago.Refresh()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        dvista.Rows.Clear()
        Dim i As Integer
        i = 0
        Do While i < 6
            dvista.Rows.Add(pacientes(i, 0), pacientes(i, 1), pacientes(i, 2), pacientes(i, 3), pacientes(i, 4), pacientes(i, 5), pacientes(i, 6), pacientes(i, 7))
            i = i + 1
        Loop
        dvista.Visible = True
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Consultas.Show()
        Me.Visible = False
    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        Estadisticas.Show()
        cargarEstadisticas()
        Me.Visible = False
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        If MsgBox("Desea cerrar aplicacion", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub EstadisticasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem1.Click
        limpiarestadistica()
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrizToolStripMenuItem.Click
        limpiarmatriz()
    End Sub
End Class

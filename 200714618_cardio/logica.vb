Module logica
    Public Const precioecomajadas = 200.99
    Public Const preciopruebamajadas = 150.5
    Public Const precioelectromajadas = 100.99
    Public Const precioecomulti = 210.9
    Public Const preciopruebamulti = 145.5
    Public Const precioelectromulti = 110.99
    Public examen1 As String
    Public examen2 As String
    Public examen3 As String
    Public precio1 As Double
    Public precio2 As Double
    Public precio3 As Double
    Public des = 0
    Public rec = 0

    Public nombres(6) As String
    Public edades(6) As Integer
    Public generos(6) As String
    Public laboratorios(6) As String
    Public examenes(6) As String
    Public parciales(6) As Double
    Public totales(6) As Double

    Public indice = 0


    Public Sub VerExamenes()
        If (Form1.CheckBox1.Checked) Then
            examen1 = " ecocardiograma,"

        Else
            examen1 = " "
        End If
        If (Form1.CheckBox2.Checked) Then
            examen2 = " prueba esfuerzo,"
        Else
            examen2 = " "
        End If
        If (Form1.CheckBox3.Checked) Then
            examen3 = " prueba esfuerzo"
        Else
            examen3 = " "
        End If
    End Sub

    Public Sub asignarPrecio()
        If (Form1.CheckBox1.Checked = True And Form1.ComboBox1.SelectedIndex = 0) Then
            precio1 = precioecomajadas
        End If
        If (Form1.CheckBox1.Checked = True And Form1.ComboBox1.SelectedIndex = 1) Then
            precio1 = precioecomulti
        End If
        If (Form1.CheckBox2.Checked = True And Form1.ComboBox1.SelectedIndex = 0) Then
            precio2 = preciopruebamajadas
        End If
        If (Form1.CheckBox2.Checked = True And Form1.ComboBox1.SelectedIndex = 1) Then
            precio2 = preciopruebamulti
        End If
        If (Form1.CheckBox3.Checked = True And Form1.ComboBox1.SelectedIndex = 0) Then
            precio3 = precioelectromajadas
        End If
        If (Form1.CheckBox3.Checked = True And Form1.ComboBox1.SelectedIndex = 1) Then
            precio3 = precioelectromajadas
        End If
    End Sub

    Public Sub llenarVectores(ByVal nom As String, ByVal ed As Integer, ByVal gen As String, ByVal lab As String)
        nombres(indice) = nom
        edades(indice) = ed
        generos(indice) = gen
        examenes(indice) = examen1 + examen2 + examen3
        laboratorios(indice) = lab
        parciales(indice) = precio1 + precio2 + precio3
        calcularEnvio()
        Form1.ListBox1.Items.Add(nombres(indice))
        Form1.ListBox2.Items.Add(edades(indice))
        Form1.ListBox4.Items.Add(examenes(indice))
        Form1.ListBox3.Items.Add(laboratorios(indice))
        Form1.ListBox5.Items.Add(parciales(indice))
        Form1.ListBox6.Items.Add(Format(totales(indice), "0.00"))
        indice = indice + 1


    End Sub

    Public Sub calcularEnvio()
        If (Form1.RadioButton1.Checked = True) Then
            rec = 0.05
            totales(indice) = parciales(indice) + parciales(indice) * rec
        End If
        If (Form1.RadioButton2.Checked = True) Then
            rec = 0.06
            totales(indice) = parciales(indice) + parciales(indice) * rec
        End If
        If (Form1.RadioButton3.Checked = True) Then
            des = 0.25
            totales(indice) = parciales(indice) - parciales(indice) * des
        End If
    End Sub

    Public Sub Limpiar()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()

    End Sub

    Public Sub limpiarvectores()
        Dim i As Integer

        For i = 0 To 6
            nombres(i) = " "
            edades(i) = 0
            generos(i) = " "
            examenes(i) = " "
            laboratorios(i) = " "
            parciales(i) = 0
            totales(i) = 0
        Next
    End Sub

    Public Sub salir()
        If MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            Form1.Close()
        End If
    End Sub
End Module

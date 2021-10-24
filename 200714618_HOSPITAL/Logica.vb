Module Logica
    Public pacientes(6, 8) As String
    Public indice = 0
    Public contador1 = 0
    Public contador2 = 0
    Public contador3 = 0



    Public Sub IngresarDatos(ByVal n As String, ByVal ni As String, ByVal d As String, ByVal h As String, ByVal th As String, ByVal tp As String)
        If verificaringreso(ni) = False Then
            pacientes(indice, 0) = n
            pacientes(indice, 1) = ni
            pacientes(indice, 2) = d
            pacientes(indice, 3) = h
            pacientes(indice, 4) = th
            pacientes(indice, 5) = tp
            pacientes(indice, 6) = String.Format(CStr((preciohab(th) * d) + h), "f")
            pacientes(indice, 7) = Val(pacientes(indice, 6)) + Val(pacientes(indice, 6)) * descuentorecargo(tp)
            indice = indice + 1
        Else
            MsgBox("Nit ya fue ingresado en sistema", MsgBoxStyle.OkOnly, "Error")
        End If


    End Sub

    Public Function preciohab(ByVal s As String) As Integer
        Select Case s
            Case "privada"
                Return 350
            Case "semiprivada"
                Return 250
            Case "no privada"
                Return 150
        End Select
    End Function

    Public Function descuentorecargo(ByVal p As String) As Double
        Select Case p
            Case "efectivo"
                Return -0.1
            Case "deposito bancario"
                Return -0.1
            Case "transferencia ACH"
                Return -0.08
            Case "tarjeta credito"
                Return +0.015
            Case "seguro medico"
                Return 0
        End Select
    End Function

    Public Sub buscarNit(ByVal n As String)
        Dim i As Integer
        Dim control As Integer
        i = 0
        control = 0
        Do While i < 6
            If String.Compare(pacientes(i, 1), n) = 0 Then
                Consultas.dconsulta.Rows.Add(pacientes(i, 0), pacientes(i, 1), pacientes(i, 2), pacientes(i, 3), pacientes(i, 4), pacientes(i, 5), pacientes(i, 6), pacientes(i, 7))
                control = 1
            End If
            i = i + 1
        Loop
        If control = 0 Then
            MsgBox("no exiten registros", MsgBoxStyle.OkOnly, "resultado")
            Consultas.dconsulta.Rows.Clear()
        End If

    End Sub

    Public Function verificaringreso(ByVal nnit As String) As Boolean
        Dim f As Integer
        For f = 0 To indice - 1
            If String.Compare(pacientes(f, 1), nnit) = 0 Then
                Return True
            Else
                Return False
            End If
        Next
    End Function

    Public Sub cargarEstadisticas()
        Dim i As Integer
        For i = 0 To 5
            If String.Compare(pacientes(i, 4), "privada") = 0 Then
                contador1 = contador1 + 1
            End If
            If String.Compare(pacientes(i, 5), "transferencia ACH") = 0 Then
                contador2 = contador2 + pacientes(i, 7)
            End If
            If String.Compare(pacientes(i, 4), "no privada") = 0 Then
                contador3 = contador3 + pacientes(i, 2)
            End If
        Next
        Estadisticas.destadistica.Rows.Add(contador1, contador2, contador3)
    End Sub

    Public Sub limpiarmatriz()
        Dim fila As Integer
        Dim columna As Integer
        For fila = 0 To 5
            For columna = 0 To 7
                pacientes(fila, columna) = Nothing
            Next
        Next
    End Sub

    Public Sub limpiarestadistica()
        contador1 = 0
        contador2 = 0
        contador3 = 0
    End Sub


End Module

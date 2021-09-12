Module LOGICA
    Public Precios(9) As Double
    Public descuentos1(9) As Double
    Public descuentos2(9) As Double
    Public totales(9) As Double
    Public indice = 0
    Public descuento = 0.00




    Public Sub asignarPrecio(ByVal cine As Char, ByVal funcion As Integer, ByVal cantidad As Integer)
        If (cine = "A") Then
            Select Case funcion
                Case 1
                    Precios(indice) = 30 * cantidad
                    descuentos1(indice) = 0.00
                Case 2
                    Precios(indice) = 35 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.015
                Case 3
                    Precios(indice) = 40 * cantidad
                    descuentos1(indice) = 0.00
                Case 4
                    Precios(indice) = 40 * cantidad
                    descuentos1(indice) = 0.00
            End Select
            Select Case Precios(indice)
                Case 100 To 300
                    descuentos2(indice) = Precios(indice) * 0.02
                Case 301 To 500
                    descuentos2(indice) = Precios(indice) * 0.04
                Case 501 To 1000
                    descuentos2(indice) = Precios(indice) * 0.06
                Case Is > 1000
                    descuentos2(indice) = 0.00
            End Select

        End If

        If (cine = "B") Then
            Select Case funcion
                Case 1
                    Precios(indice) = 24 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.03
                Case 2
                    Precios(indice) = 34 * cantidad
                    descuentos1(indice) = 0.00
                Case 3
                    Precios(indice) = 44 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.055
                Case 4
                    Precios(indice) = 44 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.055
            End Select
            Select Case Precios(indice)
                Case 100 To 300
                    descuentos2(indice) = Precios(indice) * 0.02
                Case 301 To 500
                    descuentos2(indice) = Precios(indice) * 0.04
                Case 501 To 1000
                    descuentos2(indice) = Precios(indice) * 0.06
                Case Is > 1000
                    descuentos2(indice) = 0.00
            End Select

        End If

        If (cine = "C") Then
            Select Case funcion
                Case 1
                    Precios(indice) = 35 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.03
                Case 2
                    Precios(indice) = 40 * cantidad
                    descuentos1(indice) = 0.00
                Case 3
                    Precios(indice) = 50 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.055
                Case 4
                    Precios(indice) = 50 * cantidad
                    descuentos1(indice) = Precios(indice) * 0.055
            End Select
            Select Case Precios(indice)
                Case 100 To 300
                    descuentos2(indice) = Precios(indice) * 0.02
                Case 301 To 500
                    descuentos2(indice) = Precios(indice) * 0.04
                Case 501 To 1000
                    descuentos2(indice) = Precios(indice) * 0.06
                Case Is > 1000
                    descuentos2(indice) = 0.00
            End Select

        End If
        totales(indice) = Precios(indice) - descuentos1(indice) - descuentos2(indice)
        Form1.ListaPrecios.Items.Add(Format(Precios(indice), "Q0.00"))
        Form1.listadescuentos1.Items.Add(Format(descuentos1(indice), "Q0.00"))
        Form1.listadescuentos2.Items.Add(Format(descuentos2(indice), "Q0.00"))
        Form1.listatotales.Items.Add(Format(totales(indice), "Q0.00"))
        indice = indice + 1

    End Sub

    Public Sub limpiarListasyvectores()
        Dim indice1 As Integer
        For indice1 = 0 To 8
            Precios(indice1) = 0
            descuentos1(indice1) = 0
            descuentos2(indice1) = 0
            totales(indice1) = 0
            indice1 = indice1 + 1
        Next
        indice = 0
        Form1.ListaPrecios.Items.Clear()
        Form1.listadescuentos1.Items.Clear()
        Form1.listadescuentos2.Items.Clear()
        Form1.listatotales.Items.Clear()
    End Sub



End Module

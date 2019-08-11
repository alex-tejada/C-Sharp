Public Class Preguntar

    Dim ndia As Integer

    Public Sub LeerEvaluar()

        Console.WriteLine("Escriba un numero de dia")
        ndia = Integer.Parse(Console.ReadLine())

        Select Case ndia

            Case 1
                Console.WriteLine("El dia es dia lunes")
            Case 2
                Console.WriteLine("El dia es dia Martes")
            Case 3
                Console.WriteLine("El dia es dia Miercoles")
            Case 4
                Console.WriteLine("El dia es dia Jueves")
            Case 5
                Console.WriteLine("El dia es dia Viernes")
            Case 6
                Console.WriteLine("El dia es dia Sabado")
            Case 7
                Console.WriteLine("El dia es dia Domingo")
            Case Else
                Console.WriteLine("EL DIA ES INCORRECTO")
        End Select
    End Sub
End Class

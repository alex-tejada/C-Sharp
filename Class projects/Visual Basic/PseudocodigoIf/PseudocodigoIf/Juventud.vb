Public Class Juventud

    Dim edad As Integer

    Public Sub LeerPreguntar()

        Console.WriteLine("Cual es tu edad?")
        edad = Integer.Parse(Console.ReadLine())
        If edad >= 18 Then

            Console.WriteLine("Eres mayor de EDAD")

        Else

            Console.WriteLine("Eres menor de EDAD")
        End If
        Console.WriteLine("Fin de Algoritmo")
    End Sub

End Class

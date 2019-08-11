Public Class Palabra

    Dim conta, num As Integer

    Public Sub LeerEvaluar()

        Console.WriteLine("Escribe un numero")
        num = Integer.Parse(Console.ReadLine())
        conta = 1
        Do
            Console.WriteLine("Gato")
            conta += 1

        Loop While conta <= num
        Console.WriteLine("Se ha impreso la palabra gato " & num & " veces")
    End Sub
End Class

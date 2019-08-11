Public Class Numeros

    Dim conta, num As Integer

    Public Sub LeerContar()
        Console.WriteLine("Escribe un numero")
        num = Integer.Parse(Console.ReadLine())
        For conta = 0 To num Step 1
            Console.WriteLine("Mi valor es: " & conta)

        Next
    End Sub
End Class

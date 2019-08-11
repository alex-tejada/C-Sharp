Public Class Numeros

    Dim num, suma, i As Integer


    Public Sub LeerCalcular()
        Console.WriteLine("Escribe un numero: ")
        num = Integer.Parse(Console.ReadLine())
        suma = 0
        i = 1
        Do
            suma = suma + i
            i += 1
        Loop While i <= num
        Console.WriteLine("La suma es: " & suma)
    End Sub
End Class

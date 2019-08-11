Public Class Analizar

    Dim pass, contra As String

    Public Sub LeerSecreto()

        contra = "QWER"
        Console.WriteLine("Escribe una contrasena ")
        pass = Console.ReadLine()
        While pass <> contra
            Console.WriteLine("La contrasena es incorrecta")
            Console.WriteLine("Escribe denuevo una contrasena ")
            pass = Console.ReadLine()
        End While
        Console.WriteLine("La contrasena es correcta")
    End Sub
End Class

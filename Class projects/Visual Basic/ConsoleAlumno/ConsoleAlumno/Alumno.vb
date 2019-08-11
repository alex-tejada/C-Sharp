Public Class Alumno
    Dim nombre, apellido, grupo As String

    Public Sub RegistrarNombre()

        Console.WriteLine("Dame el nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Dame el apellido")
        apellido = Console.ReadLine()
        Console.WriteLine("Dame el grupo")
        grupo = Console.ReadLine()
    End Sub
    Public Sub MostrarNombre()

        Console.WriteLine("El nombre del alumno es: " & nombre)
        Console.WriteLine("El apellido del alumno es: " & apellido)
        Console.WriteLine("El grupo del alumno es: " & grupo)
    End Sub
End Class

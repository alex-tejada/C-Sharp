Public Class Alimentos

    Dim clave, ingredientes As String
    Dim cantidad As Integer
    Dim precio, importe As Double

    Public Sub RegistrarAlimentos()
        Console.WriteLine("Dame la clave del alimento")
        clave = Console.ReadLine()
        Console.WriteLine("Dame los ingredientes")
        ingredientes = Console.ReadLine()
        Console.WriteLine("Dame la cantidad")
        cantidad = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Dame el precio del alimento")
        precio = Double.Parse(Console.ReadLine())
    End Sub
    Public Sub MostrarAlimentos()

        Console.WriteLine("La clave del producto es: " & clave)
        Console.WriteLine("Los ingredientes son: " & ingredientes)
        Console.WriteLine("La cantidad es: " & cantidad)
        Console.WriteLine("El precio del alimento es: {0:C}", precio)
        Console.WriteLine("")
    End Sub
    Public Sub CalcularImporte()

        importe = precio * cantidad
    End Sub
    Public Sub MostrarImporte()

        Console.WriteLine("El importe total es: {0:C}", importe)
    End Sub

End Class

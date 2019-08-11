Public Class Productos

    Dim codigo As String
    Dim cantidad As Integer
    Dim precio, importe, descuento, imporpor, importetot As Double

    Public Sub RegistrarProducto()
        Console.WriteLine("Dame el codigo del producto")
        codigo = Console.ReadLine()
        Console.WriteLine("Dame la cantidad de producto")
        cantidad = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Dame el precio del producto")
        precio = Double.Parse(Console.ReadLine())
        Console.WriteLine("Dame el descuento")
        descuento = Double.Parse(Console.ReadLine())
        importe = precio * cantidad
        imporpor = (importe * descuento) / 100
        importetot = importe - imporpor
    End Sub

    Public Sub MostrarProducto()
        Console.WriteLine("El codigo del producto es: " & codigo)
        Console.WriteLine("La cantidad del producto es: " & cantidad)
        Console.WriteLine("El precio del producto es: " & precio)
        Console.WriteLine("El descuento del producto es: " & descuento)
        Console.WriteLine("El importe del producto es: {0:C}", Convert.ToString(importe))
        Console.WriteLine("El importe a descontar del producto es: {0:C}", Convert.ToString(imporpor))
        Console.WriteLine("El importe total es: {0:C}", Convert.ToString(importetot))
    End Sub

End Class

Public Class Control

    Public Shared direccion As String() = New String(7) {}
    Public Shared velocidad As Double() = New Double(7) {}
    Sub Cargar()
        For i = 0 To 5 Step 1
            Console.Write("Ingresa la velocidad del dia [" & (1 + i) & "]:")
            velocidad(i) = Double.Parse(Console.ReadLine())
            Console.Write("Ingresa la velocidad del viento [" & (1 + i) & "]:")
            direccion(i) = Console.ReadLine()
        Next
    End Sub
    Sub VelocidadMayor()
        Dim mayor As Double
        mayor = velocidad(0)
        Dim posicion As Integer
        posicion = 0

        For i = 0 To direccion.Length - 1 Step 1
            If velocidad(i) > mayor Then

                mayor = velocidad(i)
                posicion = i
            End If
        Next
        Console.WriteLine("La velocidad mayor es:" & velocidad(posicion))
        Console.WriteLine("Con direccion: " & direccion(posicion))


    End Sub
End Class

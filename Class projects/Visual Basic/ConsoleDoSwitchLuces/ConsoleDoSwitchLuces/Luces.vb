Public Class Luces

    Dim eleccion As Integer
    Public Sub LeerEvaluar()
        Do

            Console.WriteLine("==========================")
            Console.WriteLine("=MENU SEMAFORO=")
            Console.WriteLine("1 para elegir Color Verde")
            Console.WriteLine("2 para elegir Color Amarillo")
            Console.WriteLine("3 para elegir Color Rojo")
            Console.WriteLine("4 cerrar el Semaforo")
            Console.WriteLine("5 para salir")
            Console.WriteLine("==========================")
            Console.WriteLine("")
            Console.Write("Opcion: ")
            eleccion = Integer.Parse(Console.ReadLine())
            Select Case (eleccion)

                Case 1
                    Console.WriteLine("Se eligio el color verde, puede avanzar")
                Case 2
                    Console.WriteLine("Se eligio el color amarillo, puede avanzar con precaucion")
                Case 3
                    Console.WriteLine("Se eligio el color rojo,alto total")
                Case 4
                    Console.WriteLine("Se cerro el semaforo")
                Case 5
                    Console.WriteLine("Salir del menu")
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select

        Loop While (eleccion <> 5)
        Console.WriteLine("Presione cualquier tecla para salir")
    End Sub
End Class

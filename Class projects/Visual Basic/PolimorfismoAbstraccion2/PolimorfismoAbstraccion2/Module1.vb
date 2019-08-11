Module Module1

    Sub Main()
        Dim _Chihuahua1 As New Chihuahua()
        Dim _Chihuahua2 As New Chihuahua()
        Dim _Bulldog1 As New Bulldog()
        Dim _Bulldog2 As New Bulldog()
        Dim _Perrera As Perro() = {_Chihuahua1, _Chihuahua2, _Bulldog1, _Bulldog2}


        For Each Perro As Perro In _Perrera
            Console.WriteLine(Perro.Ladrar())
            Console.WriteLine(Perro.Dormir())
        Next

        Console.ReadKey()
    End Sub

End Module

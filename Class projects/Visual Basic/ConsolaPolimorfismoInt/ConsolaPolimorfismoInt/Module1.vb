Module Module1

    Sub Main()
        Dim _Chihuahua1 As New Chihuahua()
        Dim _Chihuahua2 As New Chihuahua()
        Dim _Bulldog1 As New Bulldog()
        Dim _Bulldog2 As New Bulldog()
        Dim _Perrera As IPerro() = {_Chihuahua1, _Chihuahua2, _Bulldog1, _Bulldog2}
        For Each perro As IPerro In _Perrera
            Console.WriteLine(perro.Ladrar())
            Console.WriteLine(perro.Dormir())
        Next
        Console.ReadKey()
    End Sub

End Module

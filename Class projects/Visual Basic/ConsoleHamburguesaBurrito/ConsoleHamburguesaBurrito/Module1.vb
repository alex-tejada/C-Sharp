Module Module1

    Sub Main()

        Dim burrito As New Alimentos()
        Dim hamburguesa As New Alimentos()

        burrito.RegistrarAlimentos()
        burrito.MostrarAlimentos()
        burrito.CalcularImporte()
        burrito.MostrarImporte()

        hamburguesa.RegistrarAlimentos()
        hamburguesa.MostrarAlimentos()
        hamburguesa.CalcularImporte()
        hamburguesa.MostrarImporte()

        Console.ReadKey()
    End Sub

End Module

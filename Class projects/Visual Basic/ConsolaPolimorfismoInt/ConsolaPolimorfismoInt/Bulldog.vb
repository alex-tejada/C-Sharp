Imports ConsolaPolimorfismoInt

Public Class Bulldog
    Implements IPerro

    Public Function Ladrar() As Object Implements IPerro.Ladrar
        Return "Bulldog Ladrando"
    End Function

    Public Function Dormir() As Object Implements IPerro.Dormir
        Return "Bulldog Durmiendo"
    End Function
End Class

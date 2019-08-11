Imports ConsolaPolimorfismoInt

Public Class Chihuahua
    Implements IPerro


    Public Function Ladrar() As Object Implements IPerro.Ladrar
        Return "Chihuahua Ladrando"
    End Function

    Public Function Dormir() As Object Implements IPerro.Dormir
        Return "Chihuahua Durmiendo"
    End Function
End Class

Imports COnsolaPatDirRobotCo

Public Class NoCaminar
    Implements ICaminarBehavior

    Public Sub Caminar() Implements ICaminarBehavior.Caminar
        Console.WriteLine("No caminar")
    End Sub
End Class

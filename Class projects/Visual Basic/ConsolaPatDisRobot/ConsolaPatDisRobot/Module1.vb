Module Module1

    Sub Main()
        Dim rv As New RobotVigilante()
        Dim rm As New RobotMilitar()
        Dim rc As New RobotCasero()

        rv.Caminar()
        rv.Disparar()
        rm.Caminar()
        rm.Disparar()
        rc.Caminar()
        rc.Disparar()

        Console.ReadKey()
    End Sub

End Module

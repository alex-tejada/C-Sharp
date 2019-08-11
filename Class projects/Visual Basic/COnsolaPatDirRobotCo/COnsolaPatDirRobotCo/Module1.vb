Module Module1

    Sub Main()
        Dim rc As New RobotCasero()
        Dim rv As New RobotVigilante()
        Dim rjc As New RobotJohnConnor()
        Dim rm As New RobotMilitar()

        rc.Caminar()
        rc.Disparar()
        rv.Caminar()
        rv.Disparar()
        rjc.Caminar()
        rjc.Disparar()
        rm.Caminar()
        rm.Disparar()

        Console.ReadKey()
    End Sub

End Module

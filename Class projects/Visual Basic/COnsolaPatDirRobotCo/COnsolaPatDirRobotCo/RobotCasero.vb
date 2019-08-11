Public Class RobotCasero
    Inherits Robot
    Public Sub New()
        _disparar = New NoDisparar()
        _caminar = New CaminarNormal()

    End Sub
End Class

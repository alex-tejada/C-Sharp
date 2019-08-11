Public Class RobotVigilante
    Inherits Robot
    Public Sub New()
        _disparar = New DispararNormal()
        _caminar = New CaminarNormal()
    End Sub
End Class

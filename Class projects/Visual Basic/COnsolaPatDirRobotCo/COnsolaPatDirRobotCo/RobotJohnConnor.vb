Public Class RobotJohnConnor
    Inherits Robot
    Public Sub New()
        _disparar = New DispararAmetralladora()
        _caminar = New CaminarNormal()
    End Sub
End Class

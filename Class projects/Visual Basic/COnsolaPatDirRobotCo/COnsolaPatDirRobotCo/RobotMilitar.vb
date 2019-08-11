Public Class RobotMilitar
    Inherits Robot
    Public Sub New()
        _disparar = New DispararAmetralladora()
        _caminar = New CaminarDeMedioLado()
    End Sub
End Class

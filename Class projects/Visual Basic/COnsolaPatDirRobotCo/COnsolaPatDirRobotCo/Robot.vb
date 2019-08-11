Public MustInherit Class Robot

    Protected _caminar As ICaminarBehavior
        Protected _disparar As IDispararBehavior
        Public Sub New()

        End Sub
        Public Sub Caminar()
            _caminar.Caminar()
        End Sub
    Public Sub Disparar()
        _disparar.Disparar()
    End Sub
End Class

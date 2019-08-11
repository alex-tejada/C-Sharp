Public Class Form1
    Private Sub lbDestinos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDestinos.SelectedIndexChanged
        txtDestinos.Text = lbDestinos.SelectedItem.ToString()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim a, n, ip, pa, pn As Double
        a = 0
        n = 0
        ip = 0
        pa = 0
        pn = 0
        Select Case txtDestinos.Text
            Case "Aguascalientes"
                pa = 745.5
                pn = 500.8
            Case "Guadalarajara"
                pa = 985.1
                pn = 625.1
            Case "Mexico"
                pa = 2000.3
                pn = 1300.1
            Case Else

        End Select
        a = Double.Parse(txtAdultos.Text)
        n = Double.Parse(txtNinos.Text)
        ip = (a * pa) + (n * pn)
        txtImporte.Text = ip.ToString("C")
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAdultos.Clear()
        txtDestinos.Clear()
        txtNinos.Clear()
        txtImporte.Clear()
        lbDestinos.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub
End Class

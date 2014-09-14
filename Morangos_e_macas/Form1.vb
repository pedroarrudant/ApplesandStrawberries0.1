Public Class Form1

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim ValorMaca As Double, ValorMorango As Double, ValorTotal As Double
        ValorMaca = Convert.ToDouble(TxtqntdMaca.Text)
        If ValorMaca > 5 Then
            ValorMaca = ValorMaca * 1.5
            LblValorMaca.Text = ValorMaca.ToString("F")
            PctMaca.Image = My.Resources.maca
        Else
            ValorMaca = ValorMaca * 1.8
            LblValorMaca.Text = ValorMaca.ToString("F")
            PctMaca.Image = My.Resources.maca
        End If
        ValorMorango = Convert.ToDouble(TxtqntdMorango.Text)
        If ValorMorango > 5 Then
            ValorMorango = ValorMorango * 2.2
            LblValorMorango.Text = ValorMorango.ToString("F")
            PctMorango.Image = My.Resources.morango
        Else
            ValorMorango = ValorMorango * 2.5
            LblValorMorango.Text = ValorMorango.ToString("F")
            PctMorango.Image = My.Resources.morango
        End If
        If ValorMaca + ValorMorango > 25 Then
            ValorTotal = (ValorMaca + ValorMorango) - (((ValorMaca + ValorMorango) / 100) * 10)
            LblTotalCompra.Text = ValorTotal.ToString("F")
        Else
            ValorTotal = ValorMaca + ValorMorango
            LblTotalCompra.Text = ValorTotal.ToString("F")
        End If
    End Sub
End Class

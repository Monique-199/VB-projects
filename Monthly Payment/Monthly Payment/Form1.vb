Public Class Form1
    Private Sub lblCalculate_Click(sender As Object, e As EventArgs) Handles lblCalculate.Click
        Dim dblPay As Double
        lblPay.Text = String.Empty
        dblPay = -Financial.Pmt(0.05 / 12, 3 * 12, 50000)
        lblPay.Text = dblPay.ToString("C2")

    End Sub
End Class

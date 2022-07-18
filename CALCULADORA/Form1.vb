Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        lblResultado.Text = Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        lblResultado.Text = Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub btnVezes_Click(sender As Object, e As EventArgs) Handles btnVezes.Click
        lblResultado.Text = Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        lblResultado.Text = Convert.ToInt32(txtNumero1.Text) / Convert.ToInt32(txtNumero2.Text)
    End Sub
End Class

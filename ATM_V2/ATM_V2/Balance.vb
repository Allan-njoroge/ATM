Public Class Balance
    Dim balance As Double = 10000.0

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBalance.Text = "Balance: KES " & balance
    End Sub
End Class
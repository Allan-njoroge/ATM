Public Class Main
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Auth.Show()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Me.Hide()
        Withdraw.Show()
    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Me.Hide()
        Balance.Show()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Me.Hide()
        Deposit.Show()
    End Sub

    Private Sub btnChangePin_Click(sender As Object, e As EventArgs) Handles btnChangePin.Click
        Me.Hide()
        ChangePin.Show()
    End Sub

    Private Sub btnStatement_Click(sender As Object, e As EventArgs) Handles btnStatement.Click
        Me.Hide()
        MiniStatement.Show()
    End Sub
End Class
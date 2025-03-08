Public Class Withdraw
    ' Initialized the balance of the account
    Dim balance As Double = 10000.0

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        If txtWithdrawAmount.Text = "" Then
            MsgBox("Amount cannot be empty", vbCritical, "Input Error")
            Return
            Exit Sub
        End If

        If Not IsNumeric(txtWithdrawAmount.Text) Or txtWithdrawAmount.Text < 100 Then
            MsgBox("Please enter a valid amount", vbCritical, "Input Error")
            Return
            Exit Sub
        End If

        If txtWithdrawAmount.Text > balance Then
            MsgBox("Insufficient funds", vbCritical, "Withdrawal Error")
            Return
            Exit Sub
        End If

        MessageBox.Show("KES: " + txtWithdrawAmount.Text + " successfully withdrawn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtWithdrawAmount.Clear()
    End Sub
End Class
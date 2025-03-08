Public Class Deposit
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        If Not IsNumeric(txtDepositAmount.Text) Or txtDepositAmount.Text < 1 Then
            MsgBox("Please enter a valid amount", vbCritical, "Input Error")
            Return
            Exit Sub
        End If

        MessageBox.Show("KES: " + txtDepositAmount.Text + " Successfully Desposited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtDepositAmount.Clear()
    End Sub
End Class
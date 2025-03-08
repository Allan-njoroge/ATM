Public Class ChangePin
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if the current PIN input is valid
        If Not IsNumeric(txtCurrentPin.Text) Or txtCurrentPin.Text.Length <> 4 Then
            MsgBox("Please enter a valid PIN", vbCritical, "Input Error")
            txtCurrentPin.Clear()
            Return
        End If

        ' New PIN 1 input validation
        If Not IsNumeric(txtPin1.Text) Or txtPin1.Text.Length <> 4 Then
            MsgBox("Please enter a valid PIN", vbCritical, "Input Error")
            txtPin1.Clear()
            Return
        End If

        ' New PIN 2 input validation
        If Not IsNumeric(txtPin2.Text) Or txtPin2.Text.Length <> 4 Then
            MsgBox("Please enter a valid PIN", vbCritical, "Input Error")
            txtPin2.Clear()
            Return
        End If

        ' Check if the new PINs match
        If txtPin1.Text <> txtPin2.Text Then
            MsgBox("New PINs do not match", vbCritical, "Input Error")
            txtPin1.Clear()
            txtPin2.Clear()
            Return
        End If

        'check if PIN is the same as the current PIN
        If txtCurrentPin.Text = txtPin1.Text Then
            MsgBox("New PIN cannot be the same as the current PIN", vbCritical, "Input Error")
            txtPin1.Clear()
            txtPin2.Clear()
            Return
        End If

        MessageBox.Show("PIN Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtCurrentPin.Clear()
        txtCurrentPin.Clear()
        txtPin2.Clear()

    End Sub
End Class
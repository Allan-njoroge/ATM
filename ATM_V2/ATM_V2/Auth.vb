Public Class Auth

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Check if the input fields are empty
        If txtAccountNumber.Text = "" Or txtPinNumber.Text = "" Then
            MsgBox("All fields are required", vbCritical, "Login Error")
            txtAccountNumber.Clear()
            txtAccountNumber.Focus()
            Return
            Exit Sub
        End If

        ' Check if account number is numeric and 10 charcters long
        If Not IsNumeric(txtAccountNumber.Text) Or Len(txtAccountNumber.Text) <> 10 Then
            MsgBox("Invalid Account Number", vbCritical, "Input Error")
            txtAccountNumber.Clear()
            txtAccountNumber.Focus()
            Return
            Exit Sub
        End If


        ' Check if pin number is numeric and 4 charcters long
        If Not IsNumeric(txtPinNumber.Text) Or Len(txtPinNumber.Text) <> 4 Then
            MsgBox("Invalid Pin Number", vbCritical, "Input Error")
            txtPinNumber.Clear()
            txtPinNumber.Focus()
            Return
            Exit Sub
        End If

        Me.Hide()
        Main.Show()

        txtAccountNumber.Clear()
        txtPinNumber.Clear()
    End Sub

End Class

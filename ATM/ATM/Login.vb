Public Class Login

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If txtPin.UseSystemPasswordChar Then
            txtPin.UseSystemPasswordChar = False
        Else
            txtPin.UseSystemPasswordChar = True
        End If
    End Sub
End Class
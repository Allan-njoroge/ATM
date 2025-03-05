Public Class Register
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txtPin1.UseSystemPasswordChar = True Then
            txtPin1.UseSystemPasswordChar = False
        Else
            txtPin1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If txtPin2.UseSystemPasswordChar = True Then
            txtPin2.UseSystemPasswordChar = False
        Else
            txtPin2.UseSystemPasswordChar = True
        End If
    End Sub
End Class

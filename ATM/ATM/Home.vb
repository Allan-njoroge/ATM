Public Class Home
    Private show As Boolean = True
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If show Then
            lblAmount1.BackColor = Color.FromArgb(0, 0, 64)
            lblAmount2.BackColor = Color.FromArgb(0, 0, 64)
        Else
            lblAmount1.BackColor = Color.FromArgb(128, 128, 255)
            lblAmount2.BackColor = Color.FromArgb(128, 128, 255)
        End If

        show = Not show
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Transactions.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        More.Show()
    End Sub
End Class
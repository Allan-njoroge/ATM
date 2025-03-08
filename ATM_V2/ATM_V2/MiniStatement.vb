Public Class MiniStatement
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub MiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statementsTable.Rows.Add("2025-03-05 06:20 PM", "Deposit", "3000.00", "10000.00") ' Most recent transaction
        statementsTable.Rows.Add("2025-03-05 04:00 PM", "Withdrawal", "5000.00", "7000.00")
        statementsTable.Rows.Add("2025-03-05 01:45 PM", "Deposit", "7000.00", "12000.00")
        statementsTable.Rows.Add("2025-03-05 10:15 AM", "Withdrawal", "4000.00", "5000.00")
        statementsTable.Rows.Add("2025-03-05 08:30 AM", "Deposit", "5000.00", "9000.00")
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnWithdraw = New Button()
        btnDeposit = New Button()
        btnBalance = New Button()
        btnStatement = New Button()
        btnChangePin = New Button()
        btnExit = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.White
        btnWithdraw.FlatStyle = FlatStyle.Popup
        btnWithdraw.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnWithdraw.Location = New Point(167, 176)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(300, 80)
        btnWithdraw.TabIndex = 0
        btnWithdraw.Text = "WITHDRAW"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.White
        btnDeposit.FlatStyle = FlatStyle.Popup
        btnDeposit.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnDeposit.Location = New Point(167, 326)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(300, 80)
        btnDeposit.TabIndex = 1
        btnDeposit.Text = "DEPOSIT"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnBalance
        ' 
        btnBalance.BackColor = Color.White
        btnBalance.FlatStyle = FlatStyle.Popup
        btnBalance.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBalance.Location = New Point(167, 478)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(300, 80)
        btnBalance.TabIndex = 2
        btnBalance.Text = "CHECK BALANCE"
        btnBalance.UseVisualStyleBackColor = False
        ' 
        ' btnStatement
        ' 
        btnStatement.BackColor = Color.White
        btnStatement.FlatStyle = FlatStyle.Popup
        btnStatement.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnStatement.Location = New Point(734, 176)
        btnStatement.Name = "btnStatement"
        btnStatement.Size = New Size(300, 80)
        btnStatement.TabIndex = 3
        btnStatement.Text = "MINI STATEMENT"
        btnStatement.UseVisualStyleBackColor = False
        ' 
        ' btnChangePin
        ' 
        btnChangePin.BackColor = Color.White
        btnChangePin.FlatStyle = FlatStyle.Popup
        btnChangePin.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnChangePin.Location = New Point(734, 326)
        btnChangePin.Name = "btnChangePin"
        btnChangePin.Size = New Size(300, 80)
        btnChangePin.TabIndex = 4
        btnChangePin.Text = "CHANGE PIN"
        btnChangePin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnExit.Location = New Point(734, 478)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(300, 80)
        btnExit.TabIndex = 5
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label1.Location = New Point(482, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 47)
        Label1.TabIndex = 6
        Label1.Text = "SWIFT BANK"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1178, 107)
        Panel1.TabIndex = 7
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 644)
        Controls.Add(Panel1)
        Controls.Add(btnExit)
        Controls.Add(btnChangePin)
        Controls.Add(btnStatement)
        Controls.Add(btnBalance)
        Controls.Add(btnDeposit)
        Controls.Add(btnWithdraw)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents btnStatement As Button
    Friend WithEvents btnChangePin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Panel1 = New Panel()
        Label1 = New Label()
        btnBack = New Button()
        Label2 = New Label()
        txtWithdrawAmount = New TextBox()
        Label3 = New Label()
        btnWithdraw = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1178, 107)
        Panel1.TabIndex = 8
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
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBack.Location = New Point(604, 413)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(280, 60)
        btnBack.TabIndex = 7
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(443, 273)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 21)
        Label2.TabIndex = 11
        Label2.Text = "Enter the amount to withdraw"
        ' 
        ' txtWithdrawAmount
        ' 
        txtWithdrawAmount.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtWithdrawAmount.BorderStyle = BorderStyle.FixedSingle
        txtWithdrawAmount.Location = New Point(275, 332)
        txtWithdrawAmount.Name = "txtWithdrawAmount"
        txtWithdrawAmount.Size = New Size(609, 30)
        txtWithdrawAmount.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(455, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(249, 38)
        Label3.TabIndex = 9
        Label3.Text = "Withdraw Cash"
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnWithdraw.FlatStyle = FlatStyle.Popup
        btnWithdraw.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnWithdraw.Location = New Point(275, 413)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(280, 60)
        btnWithdraw.TabIndex = 12
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' Withdraw
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 645)
        Controls.Add(btnBack)
        Controls.Add(btnWithdraw)
        Controls.Add(Label2)
        Controls.Add(txtWithdrawAmount)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Withdraw"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdraw"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWithdrawAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnWithdraw As Button
End Class

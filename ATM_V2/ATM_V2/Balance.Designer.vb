<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
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
        Panel2 = New Panel()
        Panel5 = New Panel()
        lblBalance = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        btnPrint = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label1.Location = New Point(484, 31)
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
        btnBack.Location = New Point(607, 498)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(350, 50)
        btnBack.TabIndex = 7
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(lblBalance)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(216, 160)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(741, 291)
        Panel2.TabIndex = 11
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel5.Location = New Point(14, 267)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(715, 2)
        Panel5.TabIndex = 15
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(30, 228)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(227, 21)
        lblBalance.TabIndex = 15
        lblBalance.Text = "Balance:     KES 10,000.00"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel4.Location = New Point(14, 196)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(715, 2)
        Panel4.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(260, 21)
        Label4.TabIndex = 13
        Label4.Text = "Account NO:     XXXXXX7890"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 21)
        Label2.TabIndex = 12
        Label2.Text = "Account Type:     Savings"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel3.Controls.Add(Label3)
        Panel3.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(741, 72)
        Panel3.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(244, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(286, 38)
        Label3.TabIndex = 14
        Label3.Text = "Account Balance"
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnPrint.BackgroundImageLayout = ImageLayout.None
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnPrint.Location = New Point(216, 498)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(350, 50)
        btnPrint.TabIndex = 12
        btnPrint.Text = "PRINT BALANCE"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Balance
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 644)
        Controls.Add(btnPrint)
        Controls.Add(btnBack)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "Balance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Balance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblBalance As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPrint As Button
End Class

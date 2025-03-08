<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePin
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
        Label2 = New Label()
        txtCurrentPin = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtPin1 = New TextBox()
        Label5 = New Label()
        txtPin2 = New TextBox()
        btnUpdate = New Button()
        btnBack = New Button()
        Label6 = New Label()
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
        Panel1.TabIndex = 11
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 21)
        Label2.TabIndex = 18
        Label2.Text = "Enter Current PIN"
        ' 
        ' txtCurrentPin
        ' 
        txtCurrentPin.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCurrentPin.BorderStyle = BorderStyle.FixedSingle
        txtCurrentPin.Location = New Point(433, 249)
        txtCurrentPin.MaxLength = 4
        txtCurrentPin.Name = "txtCurrentPin"
        txtCurrentPin.Size = New Size(443, 30)
        txtCurrentPin.TabIndex = 17
        txtCurrentPin.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(467, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(335, 38)
        Label3.TabIndex = 16
        Label3.Text = "Change PIN Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(291, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 21)
        Label4.TabIndex = 20
        Label4.Text = "Enter New PIN"
        ' 
        ' txtPin1
        ' 
        txtPin1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtPin1.BorderStyle = BorderStyle.FixedSingle
        txtPin1.Location = New Point(433, 337)
        txtPin1.MaxLength = 4
        txtPin1.Name = "txtPin1"
        txtPin1.Size = New Size(443, 30)
        txtPin1.TabIndex = 19
        txtPin1.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(267, 397)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 21)
        Label5.TabIndex = 22
        Label5.Text = "Confirm New PIN"
        ' 
        ' txtPin2
        ' 
        txtPin2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtPin2.BorderStyle = BorderStyle.FixedSingle
        txtPin2.Location = New Point(433, 392)
        txtPin2.MaxLength = 4
        txtPin2.Name = "txtPin2"
        txtPin2.Size = New Size(443, 30)
        txtPin2.TabIndex = 21
        txtPin2.UseSystemPasswordChar = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnUpdate.BackgroundImageLayout = ImageLayout.None
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnUpdate.Location = New Point(267, 474)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(314, 50)
        btnUpdate.TabIndex = 24
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBack.Location = New Point(622, 474)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(254, 50)
        btnBack.TabIndex = 23
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(467, 583)
        Label6.Name = "Label6"
        Label6.Size = New Size(315, 21)
        Label6.TabIndex = 25
        Label6.Text = "* For security, do not share you PIN"
        ' 
        ' ChangePin
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 644)
        Controls.Add(Label6)
        Controls.Add(btnUpdate)
        Controls.Add(btnBack)
        Controls.Add(Label5)
        Controls.Add(txtPin2)
        Controls.Add(Label4)
        Controls.Add(txtPin1)
        Controls.Add(Label2)
        Controls.Add(txtCurrentPin)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "ChangePin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChangePin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurrentPin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPin1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPin2 As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class

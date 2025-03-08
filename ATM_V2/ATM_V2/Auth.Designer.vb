<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Auth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtAccountNumber = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPinNumber = New TextBox()
        btnLogin = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(279, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 38)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO SWIFT BANK ATM SYSTEM"
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtAccountNumber.BorderStyle = BorderStyle.FixedSingle
        txtAccountNumber.Location = New Point(279, 204)
        txtAccountNumber.MaxLength = 10
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.Size = New Size(609, 30)
        txtAccountNumber.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(279, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 21)
        Label2.TabIndex = 2
        Label2.Text = "Account Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(279, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 21)
        Label3.TabIndex = 4
        Label3.Text = "PIN Number"
        ' 
        ' txtPinNumber
        ' 
        txtPinNumber.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtPinNumber.BorderStyle = BorderStyle.FixedSingle
        txtPinNumber.Location = New Point(279, 301)
        txtPinNumber.MaxLength = 4
        txtPinNumber.Name = "txtPinNumber"
        txtPinNumber.Size = New Size(609, 30)
        txtPinNumber.TabIndex = 3
        txtPinNumber.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnLogin.Location = New Point(279, 377)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(609, 59)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Location = New Point(279, 522)
        Label4.Name = "Label4"
        Label4.Size = New Size(338, 21)
        Label4.TabIndex = 6
        Label4.Text = "Forgot PIN?  Contact Customer Care"
        ' 
        ' Auth
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 645)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(Label3)
        Controls.Add(txtPinNumber)
        Controls.Add(Label2)
        Controls.Add(txtAccountNumber)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "Auth"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPinNumber As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label

End Class

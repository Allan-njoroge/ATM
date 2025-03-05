<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Panel1 = New Panel()
        Panel9 = New Panel()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        Panel7 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Panel6 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        lblAmount1 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        PictureBox9 = New PictureBox()
        Panel4 = New Panel()
        lblAmount2 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel5 = New Panel()
        Label13 = New Label()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1325, 95)
        Panel1.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(PictureBox4)
        Panel9.Controls.Add(Label4)
        Panel9.Location = New Point(837, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(115, 113)
        Panel9.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(35, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(45, 45)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 23)
        Label4.TabIndex = 0
        Label4.Text = "More"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(PictureBox2)
        Panel7.Controls.Add(Label2)
        Panel7.Location = New Point(614, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(135, 113)
        Panel7.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(48, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 23)
        Label2.TabIndex = 0
        Label2.Text = "Transactions"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel6.Controls.Add(PictureBox1)
        Panel6.Controls.Add(Label1)
        Panel6.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel6.Location = New Point(430, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(129, 113)
        Panel6.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(46, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 23)
        Label1.TabIndex = 0
        Label1.Text = "Accounts"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label5.Location = New Point(387, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 30)
        Label5.TabIndex = 1
        Label5.Text = "Hello John Doe"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel2.Controls.Add(lblAmount1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(387, 251)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(607, 187)
        Panel2.TabIndex = 2
        ' 
        ' lblAmount1
        ' 
        lblAmount1.AutoSize = True
        lblAmount1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmount1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblAmount1.Location = New Point(514, 130)
        lblAmount1.Name = "lblAmount1"
        lblAmount1.Size = New Size(72, 30)
        lblAmount1.TabIndex = 6
        lblAmount1.Text = "Ksh 0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label8.Location = New Point(512, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 21)
        Label8.TabIndex = 5
        Label8.Text = "Balance"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label7.Location = New Point(19, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(143, 30)
        Label7.TabIndex = 4
        Label7.Text = "1234567890"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(657, 65)
        Panel3.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label6.Location = New Point(129, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(348, 30)
        Label6.TabIndex = 3
        Label6.Text = "Swift Bank Personal Account"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Center
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(950, 178)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(44, 29)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 62
        PictureBox9.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel4.Controls.Add(lblAmount2)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(387, 482)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(607, 187)
        Panel4.TabIndex = 63
        ' 
        ' lblAmount2
        ' 
        lblAmount2.AutoSize = True
        lblAmount2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmount2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblAmount2.Location = New Point(514, 130)
        lblAmount2.Name = "lblAmount2"
        lblAmount2.Size = New Size(72, 30)
        lblAmount2.TabIndex = 6
        lblAmount2.Text = "Ksh 0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label11.Location = New Point(512, 85)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 21)
        Label11.TabIndex = 5
        Label11.Text = "Balance"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label12.Location = New Point(19, 126)
        Label12.Name = "Label12"
        Label12.Size = New Size(143, 30)
        Label12.TabIndex = 4
        Label12.Text = "1987654321"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Silver
        Panel5.Controls.Add(Label13)
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(657, 65)
        Panel5.TabIndex = 0
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label13.Location = New Point(148, 17)
        Label13.Name = "Label13"
        Label13.Size = New Size(311, 30)
        Label13.TabIndex = 3
        Label13.Text = "Swift Bank Digital Savings"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(1325, 803)
        Controls.Add(Panel4)
        Controls.Add(PictureBox9)
        Controls.Add(Panel2)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAmount1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAmount2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
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
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        colAccFrom = New DataGridViewTextBoxColumn()
        colAccTo = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        Button8 = New Button()
        Button9 = New Button()
        Label7 = New Label()
        Button7 = New Button()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Size = New Size(1324, 101)
        Panel1.TabIndex = 1
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(PictureBox4)
        Panel9.Controls.Add(Label4)
        Panel9.Location = New Point(844, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(112, 113)
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
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Location = New Point(21, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 23)
        Label4.TabIndex = 0
        Label4.Text = "More"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel7.Controls.Add(PictureBox2)
        Panel7.Controls.Add(Label2)
        Panel7.Location = New Point(647, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(135, 113)
        Panel7.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
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
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label2.Location = New Point(3, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 23)
        Label2.TabIndex = 0
        Label2.Text = "Transactions"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel6.Controls.Add(PictureBox1)
        Panel6.Controls.Add(Label1)
        Panel6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel6.Location = New Point(450, 3)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label3.Location = New Point(450, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 28)
        Label3.TabIndex = 2
        Label3.Text = "Pay and Buy"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(450, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 51)
        Button1.TabIndex = 3
        Button1.Text = "Buy Airtime"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(611, 198)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 51)
        Button2.TabIndex = 4
        Button2.Text = "Paybill"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(913, 198)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 51)
        Button3.TabIndex = 5
        Button3.Text = "Pay a Loan"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(766, 341)
        Button4.Name = "Button4"
        Button4.Size = New Size(158, 51)
        Button4.TabIndex = 9
        Button4.Text = "Swift to Other"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(611, 341)
        Button5.Name = "Button5"
        Button5.Size = New Size(129, 51)
        Button5.TabIndex = 8
        Button5.Text = "Swift to Swift"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(450, 341)
        Button6.Name = "Button6"
        Button6.Size = New Size(129, 51)
        Button6.TabIndex = 7
        Button6.Text = "Mpesa"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label5.Location = New Point(450, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 28)
        Label5.TabIndex = 6
        Label5.Text = "Send Money"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label6.Location = New Point(446, 576)
        Label6.Name = "Label6"
        Label6.Size = New Size(239, 28)
        Label6.TabIndex = 10
        Label6.Text = "Transactions History"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colAccFrom, colAccTo, colAmount, colTime})
        DataGridView1.GridColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridView1.Location = New Point(450, 612)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(664, 86)
        DataGridView1.TabIndex = 11
        ' 
        ' colAccFrom
        ' 
        colAccFrom.HeaderText = "FROM"
        colAccFrom.MinimumWidth = 8
        colAccFrom.Name = "colAccFrom"
        colAccFrom.Width = 150
        ' 
        ' colAccTo
        ' 
        colAccTo.HeaderText = "TO"
        colAccTo.MinimumWidth = 8
        colAccTo.Name = "colAccTo"
        colAccTo.Width = 150
        ' 
        ' colAmount
        ' 
        colAmount.HeaderText = "AMOUNT"
        colAmount.MinimumWidth = 8
        colAmount.Name = "colAmount"
        colAmount.Width = 150
        ' 
        ' colTime
        ' 
        colTime.HeaderText = "TIME"
        colTime.MinimumWidth = 8
        colTime.Name = "colTime"
        colTime.Width = 150
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(611, 487)
        Button8.Name = "Button8"
        Button8.Size = New Size(129, 51)
        Button8.TabIndex = 14
        Button8.Text = "From Agent"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button9.ForeColor = Color.White
        Button9.Location = New Point(450, 487)
        Button9.Name = "Button9"
        Button9.Size = New Size(129, 51)
        Button9.TabIndex = 13
        Button9.Text = "To Mpesa"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label7.Location = New Point(450, 438)
        Label7.Name = "Label7"
        Label7.Size = New Size(207, 28)
        Label7.TabIndex = 12
        Label7.Text = "Withdraw Money"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button7.ForeColor = Color.White
        Button7.Location = New Point(755, 198)
        Button7.Name = "Button7"
        Button7.Size = New Size(129, 51)
        Button7.TabIndex = 15
        Button7.Text = "Buy Goods"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Transactions
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(1324, 758)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "Transactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transactions"
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colAccFrom As DataGridViewTextBoxColumn
    Friend WithEvents colAccTo As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
End Class

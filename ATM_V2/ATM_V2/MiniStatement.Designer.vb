<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiniStatement
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
        Label3 = New Label()
        statementsTable = New DataGridView()
        colDate = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colBalance = New DataGridViewTextBoxColumn()
        btnPrint = New Button()
        btnBack = New Button()
        Panel1.SuspendLayout()
        CType(statementsTable, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 9
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(397, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(391, 21)
        Label2.TabIndex = 13
        Label2.Text = "This shows 5 of the most recent transactions"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(465, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(247, 38)
        Label3.TabIndex = 12
        Label3.Text = "Mini Statement"
        ' 
        ' statementsTable
        ' 
        statementsTable.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        statementsTable.BorderStyle = BorderStyle.None
        statementsTable.ColumnHeadersHeight = 50
        statementsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        statementsTable.Columns.AddRange(New DataGridViewColumn() {colDate, colType, colAmount, colBalance})
        statementsTable.Location = New Point(195, 256)
        statementsTable.Name = "statementsTable"
        statementsTable.RowHeadersWidth = 62
        statementsTable.Size = New Size(893, 246)
        statementsTable.TabIndex = 14
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 10
        colDate.Name = "colDate"
        colDate.Width = 200
        ' 
        ' colType
        ' 
        colType.HeaderText = "Type"
        colType.MinimumWidth = 8
        colType.Name = "colType"
        colType.Width = 200
        ' 
        ' colAmount
        ' 
        colAmount.HeaderText = "Amount"
        colAmount.MinimumWidth = 8
        colAmount.Name = "colAmount"
        colAmount.Width = 200
        ' 
        ' colBalance
        ' 
        colBalance.HeaderText = "Balance"
        colBalance.MinimumWidth = 8
        colBalance.Name = "colBalance"
        colBalance.Width = 200
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnPrint.BackgroundImageLayout = ImageLayout.None
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnPrint.Location = New Point(210, 529)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(389, 50)
        btnPrint.TabIndex = 16
        btnPrint.Text = "PRINT STATEMENT"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBack.Location = New Point(640, 529)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(436, 50)
        btnBack.TabIndex = 15
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' MiniStatement
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(1178, 644)
        Controls.Add(btnPrint)
        Controls.Add(btnBack)
        Controls.Add(statementsTable)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Name = "MiniStatement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MiniStatement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(statementsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents statementsTable As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
End Class

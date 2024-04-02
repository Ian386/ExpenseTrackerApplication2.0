<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        btnClose = New Button()
        lblGreeting = New Label()
        btnTransaction = New Button()
        btnWallet = New Button()
        btnHelp = New Button()
        btnReports = New Button()
        btnBudget = New Button()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        btnHome = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = SystemColors.Control
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(51, 548)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(82, 43)
        btnClose.TabIndex = 16
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblGreeting
        ' 
        lblGreeting.AutoSize = True
        lblGreeting.BackColor = Color.Transparent
        lblGreeting.Font = New Font("Freestyle Script", 22F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblGreeting.ForeColor = Color.Black
        lblGreeting.Location = New Point(263, 102)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(97, 52)
        lblGreeting.TabIndex = 15
        lblGreeting.Text = "Label1"
        ' 
        ' btnTransaction
        ' 
        btnTransaction.AutoSize = True
        btnTransaction.BackColor = Color.White
        btnTransaction.Font = New Font("Segoe UI", 9F)
        btnTransaction.ForeColor = Color.Black
        btnTransaction.Location = New Point(518, 329)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(166, 76)
        btnTransaction.TabIndex = 14
        btnTransaction.Text = "+ Add Transaction"
        btnTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnWallet
        ' 
        btnWallet.AutoSize = True
        btnWallet.BackColor = Color.White
        btnWallet.BackgroundImageLayout = ImageLayout.None
        btnWallet.Font = New Font("Segoe UI", 9F)
        btnWallet.ForeColor = Color.Black
        btnWallet.Location = New Point(263, 329)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(165, 76)
        btnWallet.TabIndex = 13
        btnWallet.Text = "Create New Wallet"
        btnWallet.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.AutoSize = True
        btnHelp.BackColor = Color.Transparent
        btnHelp.FlatStyle = FlatStyle.Popup
        btnHelp.ForeColor = Color.White
        btnHelp.Location = New Point(55, 417)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(112, 41)
        btnHelp.TabIndex = 12
        btnHelp.Text = "Settings"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.AutoSize = True
        btnReports.BackColor = Color.Transparent
        btnReports.FlatStyle = FlatStyle.Popup
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(55, 347)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(112, 41)
        btnReports.TabIndex = 11
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.AutoSize = True
        btnBudget.BackColor = Color.Transparent
        btnBudget.FlatStyle = FlatStyle.Popup
        btnBudget.ForeColor = Color.White
        btnBudget.Location = New Point(55, 281)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(112, 41)
        btnBudget.TabIndex = 10
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnHelp)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(180, 649)
        Panel1.TabIndex = 17
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(23, 31)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(142, 123)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(11, 347)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 37)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 217)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(11, 417)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 37)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' btnHome
        ' 
        btnHome.AutoSize = True
        btnHome.BackColor = Color.Transparent
        btnHome.FlatStyle = FlatStyle.Popup
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(55, 217)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 41)
        btnHome.TabIndex = 9
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 281)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(766, 649)
        Controls.Add(Panel1)
        Controls.Add(lblGreeting)
        Controls.Add(btnTransaction)
        Controls.Add(btnWallet)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnWallet As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class

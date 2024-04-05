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
        btnHelp = New Button()
        btnReports = New Button()
        btnBudget = New Button()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnWallet = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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

        btnClose.Location = New Point(53, 484)

        btnClose.Name = "btnClose"
        btnClose.Size = New Size(57, 26)
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
        lblGreeting.Location = New Point(184, 61)
        lblGreeting.Margin = New Padding(2, 0, 2, 0)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(64, 36)
        lblGreeting.TabIndex = 15
        lblGreeting.Text = "Label1"
        ' 
        ' btnTransaction
        ' 
        btnTransaction.AutoSize = True
        btnTransaction.BackColor = Color.White
        btnTransaction.FlatAppearance.BorderSize = 0
        btnTransaction.FlatStyle = FlatStyle.Flat
        btnTransaction.Font = New Font("Segoe UI", 9F)
        btnTransaction.ForeColor = Color.Black

        btnTransaction.Location = New Point(456, 312)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(168, 76)

        btnTransaction.TabIndex = 14
        btnTransaction.Text = "+ Add Transaction"
        btnTransaction.UseVisualStyleBackColor = False
        ' 


        ' btnHelp
        ' 
        btnHelp.AutoSize = True
        btnHelp.BackColor = Color.Transparent
        btnHelp.FlatAppearance.BorderSize = 0
        btnHelp.FlatStyle = FlatStyle.Flat
        btnHelp.ForeColor = Color.White

        btnHelp.Location = New Point(59, 380)

        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(78, 25)
        btnHelp.TabIndex = 12
        btnHelp.Text = "Settings"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.AutoSize = True
        btnReports.BackColor = Color.Transparent
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.ForeColor = Color.White

        btnReports.Location = New Point(59, 310)

        btnReports.Name = "btnReports"
        btnReports.Size = New Size(78, 25)
        btnReports.TabIndex = 11
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.AutoSize = True
        btnBudget.BackColor = Color.Transparent
        btnBudget.FlatAppearance.BorderSize = 0
        btnBudget.FlatStyle = FlatStyle.Flat
        btnBudget.ForeColor = Color.White

        btnBudget.Location = New Point(59, 244)

        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(78, 25)
        btnBudget.TabIndex = 10
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black

        Panel1.BackgroundImage = My.Resources.Resources.download

        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnHelp)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"

        Panel1.Size = New Size(186, 638)

        Panel1.TabIndex = 17
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(16, 19)
        PictureBox5.Margin = New Padding(2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(99, 74)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)

        PictureBox3.Location = New Point(15, 310)

        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)

        PictureBox4.Location = New Point(15, 380)

        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(27, 22)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)

        PictureBox2.Location = New Point(15, 244)

        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' btnWallet
        ' 
        btnWallet.AutoSize = True
        btnWallet.BackColor = Color.White
        btnWallet.BackgroundImageLayout = ImageLayout.None
        btnWallet.FlatAppearance.BorderSize = 0
        btnWallet.FlatStyle = FlatStyle.Flat
        btnWallet.Font = New Font("Segoe UI", 9F)
        btnWallet.ForeColor = Color.Black
        btnWallet.Location = New Point(230, 312)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(167, 76)
        btnWallet.TabIndex = 13
        btnWallet.Text = "Create New Wallet"
        btnWallet.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None

        ClientSize = New Size(690, 638)

        Controls.Add(btnTransaction)
        Controls.Add(btnWallet)
        Controls.Add(Panel1)
        Controls.Add(lblGreeting)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnWallet As Button
End Class

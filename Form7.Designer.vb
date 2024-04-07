<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Label1 = New Label()
        Button2 = New Button()
        cbWalletSelector = New ComboBox()
        pnlIndividualSummary = New Panel()
        tbxBalance = New TextBox()
        tbxSpent = New TextBox()
        tbxAmount = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        cbBudgetSelector = New ComboBox()
        pbExpenses = New ProgressBar()
        lblWalletName = New Label()
        Label3 = New Label()
        pnlNoWalletsMessage = New Panel()
        btnRedirectToForm5 = New Button()
        TextBox1 = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox6 = New PictureBox()
        btnSettings = New Button()
        PictureBox8 = New PictureBox()
        btnWallets = New Button()
        btnHome = New Button()
        Panel2 = New Panel()
        pnlIndividualSummary.SuspendLayout()
        pnlNoWalletsMessage.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Freestyle Script", 20F, FontStyle.Underline)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(224, 27)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 32)
        Label1.TabIndex = 4
        Label1.Text = "Monthly Spend Per Category"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderColor = Color.Red
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(879, 11)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(28, 22)
        Button2.TabIndex = 42
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' cbWalletSelector
        ' 
        cbWalletSelector.FormattingEnabled = True
        cbWalletSelector.Location = New Point(306, 108)
        cbWalletSelector.Name = "cbWalletSelector"
        cbWalletSelector.Size = New Size(121, 23)
        cbWalletSelector.TabIndex = 43
        ' 
        ' pnlIndividualSummary
        ' 
        pnlIndividualSummary.Controls.Add(tbxBalance)
        pnlIndividualSummary.Controls.Add(tbxSpent)
        pnlIndividualSummary.Controls.Add(tbxAmount)
        pnlIndividualSummary.Controls.Add(Label5)
        pnlIndividualSummary.Controls.Add(Label4)
        pnlIndividualSummary.Controls.Add(Label2)
        pnlIndividualSummary.Controls.Add(cbBudgetSelector)
        pnlIndividualSummary.Controls.Add(pbExpenses)
        pnlIndividualSummary.Controls.Add(lblWalletName)
        pnlIndividualSummary.Controls.Add(Label3)
        pnlIndividualSummary.Location = New Point(306, 149)
        pnlIndividualSummary.Name = "pnlIndividualSummary"
        pnlIndividualSummary.Size = New Size(404, 316)
        pnlIndividualSummary.TabIndex = 44
        ' 
        ' tbxBalance
        ' 
        tbxBalance.Location = New Point(116, 206)
        tbxBalance.Name = "tbxBalance"
        tbxBalance.ReadOnly = True
        tbxBalance.Size = New Size(160, 23)
        tbxBalance.TabIndex = 55
        ' 
        ' tbxSpent
        ' 
        tbxSpent.Location = New Point(116, 166)
        tbxSpent.Name = "tbxSpent"
        tbxSpent.ReadOnly = True
        tbxSpent.Size = New Size(160, 23)
        tbxSpent.TabIndex = 54
        ' 
        ' tbxAmount
        ' 
        tbxAmount.Location = New Point(116, 125)
        tbxAmount.Name = "tbxAmount"
        tbxAmount.ReadOnly = True
        tbxAmount.Size = New Size(160, 23)
        tbxAmount.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(14, 133)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 52
        Label5.Text = "Budget Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(14, 174)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 51
        Label4.Text = "Amount Spent"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(14, 214)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 50
        Label2.Text = "Balance"
        ' 
        ' cbBudgetSelector
        ' 
        cbBudgetSelector.FormattingEnabled = True
        cbBudgetSelector.Location = New Point(14, 88)
        cbBudgetSelector.Name = "cbBudgetSelector"
        cbBudgetSelector.Size = New Size(121, 23)
        cbBudgetSelector.TabIndex = 46
        ' 
        ' pbExpenses
        ' 
        pbExpenses.Location = New Point(14, 277)
        pbExpenses.Name = "pbExpenses"
        pbExpenses.Size = New Size(364, 23)
        pbExpenses.TabIndex = 49
        ' 
        ' lblWalletName
        ' 
        lblWalletName.AutoSize = True
        lblWalletName.BackColor = Color.Transparent
        lblWalletName.Font = New Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWalletName.ForeColor = Color.Black
        lblWalletName.Location = New Point(14, 24)
        lblWalletName.Margin = New Padding(2, 0, 2, 0)
        lblWalletName.Name = "lblWalletName"
        lblWalletName.Size = New Size(88, 19)
        lblWalletName.TabIndex = 48
        lblWalletName.Text = "Wallet Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(14, 60)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 47
        Label3.Text = "Budgets"
        ' 
        ' pnlNoWalletsMessage
        ' 
        pnlNoWalletsMessage.BackColor = Color.White
        pnlNoWalletsMessage.Controls.Add(btnRedirectToForm5)
        pnlNoWalletsMessage.Controls.Add(TextBox1)
        pnlNoWalletsMessage.Location = New Point(375, 176)
        pnlNoWalletsMessage.Name = "pnlNoWalletsMessage"
        pnlNoWalletsMessage.Size = New Size(335, 215)
        pnlNoWalletsMessage.TabIndex = 45
        ' 
        ' btnRedirectToForm5
        ' 
        btnRedirectToForm5.BackColor = Color.Honeydew
        btnRedirectToForm5.BackgroundImage = My.Resources.Resources.buttons
        btnRedirectToForm5.BackgroundImageLayout = ImageLayout.Stretch
        btnRedirectToForm5.FlatAppearance.BorderSize = 0
        btnRedirectToForm5.FlatStyle = FlatStyle.Flat
        btnRedirectToForm5.Font = New Font("Segoe UI", 9F)
        btnRedirectToForm5.ForeColor = Color.Black
        btnRedirectToForm5.Location = New Point(117, 164)
        btnRedirectToForm5.Margin = New Padding(2)
        btnRedirectToForm5.Name = "btnRedirectToForm5"
        btnRedirectToForm5.Size = New Size(96, 23)
        btnRedirectToForm5.TabIndex = 49
        btnRedirectToForm5.Text = "Create Wallet"
        btnRedirectToForm5.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(3, 0)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(330, 146)
        TextBox1.TabIndex = 47
        TextBox1.Text = "You have not created any wallets, create a wallet to proceed"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(306, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(260, 15)
        Label6.TabIndex = 48
        Label6.Text = "Select a wallet from the drop down menu below"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 31)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 304)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(26, 181)
        PictureBox6.Margin = New Padding(2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(27, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 23
        PictureBox6.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.White
        btnSettings.Location = New Point(40, 301)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(89, 33)
        btnSettings.TabIndex = 20
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(26, 242)
        PictureBox8.Margin = New Padding(2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(27, 22)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 20
        PictureBox8.TabStop = False
        ' 
        ' btnWallets
        ' 
        btnWallets.BackColor = Color.Transparent
        btnWallets.FlatAppearance.BorderSize = 0
        btnWallets.FlatStyle = FlatStyle.Flat
        btnWallets.ForeColor = Color.White
        btnWallets.Location = New Point(40, 240)
        btnWallets.Name = "btnWallets"
        btnWallets.Size = New Size(89, 33)
        btnWallets.TabIndex = 21
        btnWallets.Text = "Wallets"
        btnWallets.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Transparent
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(40, 176)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(89, 33)
        btnHome.TabIndex = 22
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImage = My.Resources.Resources.download
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(btnSettings)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Controls.Add(btnWallets)
        Panel2.Controls.Add(btnHome)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(155, 570)
        Panel2.TabIndex = 49
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(918, 570)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(cbWalletSelector)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(pnlIndividualSummary)
        Controls.Add(pnlNoWalletsMessage)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Analysis"
        pnlIndividualSummary.ResumeLayout(False)
        pnlIndividualSummary.PerformLayout()
        pnlNoWalletsMessage.ResumeLayout(False)
        pnlNoWalletsMessage.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cbWalletSelector As ComboBox
    Friend WithEvents pnlIndividualSummary As Panel
    Friend WithEvents lblNoWalletsMessage As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pbExpenses As ProgressBar
    Friend WithEvents lblWalletName As Label
    Friend WithEvents cbBudgetSelector As ComboBox
    Friend WithEvents tbxBalance As TextBox
    Friend WithEvents tbxSpent As TextBox
    Friend WithEvents tbxAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlNoWalletsMessage As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRedirectToForm5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnWallets As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel2 As Panel
End Class
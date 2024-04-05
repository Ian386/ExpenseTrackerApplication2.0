<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label4 = New Label()
        Label2 = New Label()
        lbHealthCare = New Label()
        Label3 = New Label()
        clbOtherExpenses = New CheckedListBox()
        clbHealthCare = New CheckedListBox()
        clbEnjoyments = New CheckedListBox()
        lbBasics = New Label()
        clbBasics = New CheckedListBox()
        btnSaveNewBudget = New Button()
        Label1 = New Label()
        btnGoBackHome = New Button()
        cbChooseWalllet = New ComboBox()
        lbChooseWallet = New Label()
        txtEndDate = New TextBox()
        lbEndDate = New Label()
        txtStartDate = New TextBox()
        lbStartDate = New Label()
        cbTimeRange = New ComboBox()
        lbTimeRange = New Label()
        txtBudgetAmount = New TextBox()
        lbAmount = New Label()
        txtEnterBudgetName = New TextBox()
        lbBudgetName = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Freestyle Script", 20F, FontStyle.Underline)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(105, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 47)
        Label4.TabIndex = 50
        Label4.Text = "Basic Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(833, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 49
        Label2.Text = "Other expenses"
        ' 
        ' lbHealthCare
        ' 
        lbHealthCare.AutoSize = True
        lbHealthCare.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbHealthCare.ForeColor = Color.Black
        lbHealthCare.Location = New Point(557, 376)
        lbHealthCare.Name = "lbHealthCare"
        lbHealthCare.Size = New Size(112, 25)
        lbHealthCare.TabIndex = 48
        lbHealthCare.Text = "Health Care"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(833, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 47
        Label3.Text = "Enjoyment/Give"
        ' 
        ' clbOtherExpenses
        ' 
        clbOtherExpenses.BackColor = Color.White
        clbOtherExpenses.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbOtherExpenses.ForeColor = Color.ForestGreen
        clbOtherExpenses.FormattingEnabled = True
        clbOtherExpenses.Items.AddRange(New Object() {"Fee & charge", "Investments", "Kids", "Other"})
        clbOtherExpenses.Location = New Point(833, 416)
        clbOtherExpenses.Name = "clbOtherExpenses"
        clbOtherExpenses.Size = New Size(198, 120)
        clbOtherExpenses.TabIndex = 46
        ' 
        ' clbHealthCare
        ' 
        clbHealthCare.BackColor = Color.White
        clbHealthCare.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbHealthCare.ForeColor = Color.ForestGreen
        clbHealthCare.FormattingEnabled = True
        clbHealthCare.Items.AddRange(New Object() {"Doctor", "Sport", "Insurance", "Gym Membership"})
        clbHealthCare.Location = New Point(557, 416)
        clbHealthCare.Name = "clbHealthCare"
        clbHealthCare.Size = New Size(236, 120)
        clbHealthCare.TabIndex = 45
        ' 
        ' clbEnjoyments
        ' 
        clbEnjoyments.BackColor = Color.White
        clbEnjoyments.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbEnjoyments.ForeColor = Color.ForestGreen
        clbEnjoyments.FormattingEnabled = True
        clbEnjoyments.Items.AddRange(New Object() {"Entertainment", "Fashion", "Travel", "Beauty Care", "Party", "Gift", "Donation"})
        clbEnjoyments.Location = New Point(833, 132)
        clbEnjoyments.Name = "clbEnjoyments"
        clbEnjoyments.Size = New Size(198, 207)
        clbEnjoyments.TabIndex = 44
        ' 
        ' lbBasics
        ' 
        lbBasics.AutoSize = True
        lbBasics.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbBasics.ForeColor = Color.Black
        lbBasics.Location = New Point(557, 93)
        lbBasics.Name = "lbBasics"
        lbBasics.Size = New Size(64, 25)
        lbBasics.TabIndex = 43
        lbBasics.Text = "Basics"
        ' 
        ' clbBasics
        ' 
        clbBasics.BackColor = Color.White
        clbBasics.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbBasics.ForeColor = Color.ForestGreen
        clbBasics.FormattingEnabled = True
        clbBasics.Items.AddRange(New Object() {"Food & Drinks", "Bill", "Transport", "House Rent", "Fix & Maintenance", "Utilities", "Groceries"})
        clbBasics.Location = New Point(557, 132)
        clbBasics.Name = "clbBasics"
        clbBasics.Size = New Size(236, 207)
        clbBasics.TabIndex = 28
        ' 
        ' btnSaveNewBudget
        ' 
        btnSaveNewBudget.BackColor = Color.Honeydew
        btnSaveNewBudget.BackgroundImage = My.Resources.Resources.buttons
        btnSaveNewBudget.BackgroundImageLayout = ImageLayout.Stretch
        btnSaveNewBudget.FlatAppearance.BorderSize = 0
        btnSaveNewBudget.FlatStyle = FlatStyle.Flat
        btnSaveNewBudget.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSaveNewBudget.ForeColor = Color.Black
        btnSaveNewBudget.Location = New Point(748, 593)
        btnSaveNewBudget.Name = "btnSaveNewBudget"
        btnSaveNewBudget.Size = New Size(148, 47)
        btnSaveNewBudget.TabIndex = 42
        btnSaveNewBudget.Text = "SAVE BUDGET"
        btnSaveNewBudget.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Freestyle Script", 20F, FontStyle.Underline)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(748, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 47)
        Label1.TabIndex = 41
        Label1.Text = "Categories"
        ' 
        ' btnGoBackHome
        ' 
        btnGoBackHome.BackColor = Color.Honeydew
        btnGoBackHome.BackgroundImage = My.Resources.Resources.buttons
        btnGoBackHome.BackgroundImageLayout = ImageLayout.Stretch
        btnGoBackHome.FlatAppearance.BorderSize = 0
        btnGoBackHome.FlatStyle = FlatStyle.Flat
        btnGoBackHome.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGoBackHome.ForeColor = Color.Black
        btnGoBackHome.Location = New Point(130, 593)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(137, 47)
        btnGoBackHome.TabIndex = 40
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = False
        ' 
        ' cbChooseWalllet
        ' 
        cbChooseWalllet.BackColor = Color.White
        cbChooseWalllet.Font = New Font("Tahoma", 9F)
        cbChooseWalllet.ForeColor = Color.Black
        cbChooseWalllet.FormattingEnabled = True
        cbChooseWalllet.Items.AddRange(New Object() {"wallet 1", "wallet 2"})
        cbChooseWalllet.Location = New Point(201, 271)
        cbChooseWalllet.Name = "cbChooseWalllet"
        cbChooseWalllet.Size = New Size(210, 30)
        cbChooseWalllet.TabIndex = 39
        ' 
        ' lbChooseWallet
        ' 
        lbChooseWallet.AutoSize = True
        lbChooseWallet.BackColor = Color.White
        lbChooseWallet.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbChooseWallet.ForeColor = Color.Black
        lbChooseWallet.Location = New Point(32, 276)
        lbChooseWallet.Name = "lbChooseWallet"
        lbChooseWallet.Size = New Size(135, 25)
        lbChooseWallet.TabIndex = 38
        lbChooseWallet.Text = "Choose wallet:"
        ' 
        ' txtEndDate
        ' 
        txtEndDate.BackColor = Color.White
        txtEndDate.Font = New Font("Tahoma", 9F)
        txtEndDate.ForeColor = Color.Black
        txtEndDate.Location = New Point(201, 508)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.Size = New Size(210, 29)
        txtEndDate.TabIndex = 37
        txtEndDate.Text = "yyyy-MM-dd"
        ' 
        ' lbEndDate
        ' 
        lbEndDate.AutoSize = True
        lbEndDate.BackColor = Color.White
        lbEndDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEndDate.ForeColor = Color.Black
        lbEndDate.Location = New Point(32, 512)
        lbEndDate.Name = "lbEndDate"
        lbEndDate.Size = New Size(92, 25)
        lbEndDate.TabIndex = 36
        lbEndDate.Text = "End date:"
        ' 
        ' txtStartDate
        ' 
        txtStartDate.BackColor = Color.White
        txtStartDate.Font = New Font("Tahoma", 9F)
        txtStartDate.ForeColor = Color.Black
        txtStartDate.Location = New Point(201, 423)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(210, 29)
        txtStartDate.TabIndex = 35
        txtStartDate.Text = "yyyy-MM-dd"
        ' 
        ' lbStartDate
        ' 
        lbStartDate.AutoSize = True
        lbStartDate.BackColor = Color.White
        lbStartDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbStartDate.ForeColor = Color.Black
        lbStartDate.Location = New Point(33, 427)
        lbStartDate.Name = "lbStartDate"
        lbStartDate.Size = New Size(102, 25)
        lbStartDate.TabIndex = 34
        lbStartDate.Text = "Start date:"
        ' 
        ' cbTimeRange
        ' 
        cbTimeRange.BackColor = Color.White
        cbTimeRange.Font = New Font("Tahoma", 9F)
        cbTimeRange.ForeColor = Color.Black
        cbTimeRange.FormattingEnabled = True
        cbTimeRange.Items.AddRange(New Object() {"One time", "Weekly", "Monthly", "Yearly"})
        cbTimeRange.Location = New Point(201, 346)
        cbTimeRange.Name = "cbTimeRange"
        cbTimeRange.Size = New Size(210, 30)
        cbTimeRange.TabIndex = 33
        ' 
        ' lbTimeRange
        ' 
        lbTimeRange.AutoSize = True
        lbTimeRange.BackColor = Color.White
        lbTimeRange.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTimeRange.ForeColor = Color.Black
        lbTimeRange.Location = New Point(32, 351)
        lbTimeRange.Name = "lbTimeRange"
        lbTimeRange.Size = New Size(118, 25)
        lbTimeRange.TabIndex = 32
        lbTimeRange.Text = "Time Range:"
        ' 
        ' txtBudgetAmount
        ' 
        txtBudgetAmount.BackColor = Color.White
        txtBudgetAmount.Font = New Font("Tahoma", 9F)
        txtBudgetAmount.ForeColor = Color.Black
        txtBudgetAmount.Location = New Point(201, 197)
        txtBudgetAmount.Name = "txtBudgetAmount"
        txtBudgetAmount.Size = New Size(210, 29)
        txtBudgetAmount.TabIndex = 31
        ' 
        ' lbAmount
        ' 
        lbAmount.AutoSize = True
        lbAmount.BackColor = Color.White
        lbAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbAmount.ForeColor = Color.Black
        lbAmount.Location = New Point(32, 201)
        lbAmount.Name = "lbAmount"
        lbAmount.Size = New Size(86, 25)
        lbAmount.TabIndex = 30
        lbAmount.Text = "Amount:"
        ' 
        ' txtEnterBudgetName
        ' 
        txtEnterBudgetName.BackColor = Color.White
        txtEnterBudgetName.Font = New Font("Tahoma", 9F)
        txtEnterBudgetName.ForeColor = Color.Black
        txtEnterBudgetName.Location = New Point(201, 127)
        txtEnterBudgetName.Name = "txtEnterBudgetName"
        txtEnterBudgetName.Size = New Size(210, 29)
        txtEnterBudgetName.TabIndex = 29
        ' 
        ' lbBudgetName
        ' 
        lbBudgetName.AutoSize = True
        lbBudgetName.BackColor = Color.White
        lbBudgetName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBudgetName.ForeColor = Color.Black
        lbBudgetName.Location = New Point(32, 128)
        lbBudgetName.Name = "lbBudgetName"
        lbBudgetName.Size = New Size(134, 25)
        lbBudgetName.TabIndex = 27
        lbBudgetName.Text = "Budget Name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1072, 85)
        Panel1.TabIndex = 51
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1072, 674)
        Controls.Add(Label2)
        Controls.Add(lbHealthCare)
        Controls.Add(Label3)
        Controls.Add(clbOtherExpenses)
        Controls.Add(clbHealthCare)
        Controls.Add(clbEnjoyments)
        Controls.Add(lbBasics)
        Controls.Add(clbBasics)
        Controls.Add(btnSaveNewBudget)
        Controls.Add(btnGoBackHome)
        Controls.Add(cbChooseWalllet)
        Controls.Add(lbChooseWallet)
        Controls.Add(txtEndDate)
        Controls.Add(lbEndDate)
        Controls.Add(txtStartDate)
        Controls.Add(lbStartDate)
        Controls.Add(cbTimeRange)
        Controls.Add(lbTimeRange)
        Controls.Add(txtBudgetAmount)
        Controls.Add(lbAmount)
        Controls.Add(txtEnterBudgetName)
        Controls.Add(lbBudgetName)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbHealthCare As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents clbOtherExpenses As CheckedListBox
    Friend WithEvents clbHealthCare As CheckedListBox
    Friend WithEvents clbEnjoyments As CheckedListBox
    Friend WithEvents lbBasics As Label
    Friend WithEvents clbBasics As CheckedListBox
    Friend WithEvents btnSaveNewBudget As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoBackHome As Button
    Friend WithEvents cbChooseWalllet As ComboBox
    Friend WithEvents lbChooseWallet As Label
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents lbEndDate As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents lbStartDate As Label
    Friend WithEvents cbTimeRange As ComboBox
    Friend WithEvents lbTimeRange As Label
    Friend WithEvents txtBudgetAmount As TextBox
    Friend WithEvents lbAmount As Label
    Friend WithEvents txtEnterBudgetName As TextBox
    Friend WithEvents lbBudgetName As Label
    Friend WithEvents Panel1 As Panel
End Class

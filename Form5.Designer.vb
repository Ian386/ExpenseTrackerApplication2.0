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
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Linen
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(88, 22)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 15)
        Label4.TabIndex = 50
        Label4.Text = "BASIC INFORMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.ForestGreen
        Label2.Location = New Point(600, 214)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 49
        Label2.Text = "Other expenses"
        ' 
        ' lbHealthCare
        ' 
        lbHealthCare.AutoSize = True
        lbHealthCare.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbHealthCare.ForeColor = Color.ForestGreen
        lbHealthCare.Location = New Point(366, 214)
        lbHealthCare.Margin = New Padding(2, 0, 2, 0)
        lbHealthCare.Name = "lbHealthCare"
        lbHealthCare.Size = New Size(72, 15)
        lbHealthCare.TabIndex = 48
        lbHealthCare.Text = "Health Care"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(600, 44)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 15)
        Label3.TabIndex = 47
        Label3.Text = "Enjoyment/Give"
        ' 
        ' clbOtherExpenses
        ' 
        clbOtherExpenses.BackColor = Color.Linen
        clbOtherExpenses.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbOtherExpenses.ForeColor = Color.ForestGreen
        clbOtherExpenses.FormattingEnabled = True
        clbOtherExpenses.Items.AddRange(New Object() {"Fee & charge", "Investments", "Kids", "Other"})
        clbOtherExpenses.Location = New Point(600, 238)
        clbOtherExpenses.Margin = New Padding(2, 2, 2, 2)
        clbOtherExpenses.Name = "clbOtherExpenses"
        clbOtherExpenses.Size = New Size(140, 61)
        clbOtherExpenses.TabIndex = 46
        ' 
        ' clbHealthCare
        ' 
        clbHealthCare.BackColor = Color.Linen
        clbHealthCare.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbHealthCare.ForeColor = Color.ForestGreen
        clbHealthCare.FormattingEnabled = True
        clbHealthCare.Items.AddRange(New Object() {"Doctor", "Sport", "Insurance", "Gym Membership"})
        clbHealthCare.Location = New Point(366, 238)
        clbHealthCare.Margin = New Padding(2, 2, 2, 2)
        clbHealthCare.Name = "clbHealthCare"
        clbHealthCare.Size = New Size(166, 61)
        clbHealthCare.TabIndex = 45
        ' 
        ' clbEnjoyments
        ' 
        clbEnjoyments.BackColor = Color.Linen
        clbEnjoyments.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbEnjoyments.ForeColor = Color.ForestGreen
        clbEnjoyments.FormattingEnabled = True
        clbEnjoyments.Items.AddRange(New Object() {"Entertainment", "Fashion", "Travel", "Beauty Care", "Party", "Gift", "Donation"})
        clbEnjoyments.Location = New Point(600, 67)
        clbEnjoyments.Margin = New Padding(2, 2, 2, 2)
        clbEnjoyments.Name = "clbEnjoyments"
        clbEnjoyments.Size = New Size(140, 118)
        clbEnjoyments.TabIndex = 44
        ' 
        ' lbBasics
        ' 
        lbBasics.AutoSize = True
        lbBasics.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbBasics.ForeColor = Color.ForestGreen
        lbBasics.Location = New Point(366, 44)
        lbBasics.Margin = New Padding(2, 0, 2, 0)
        lbBasics.Name = "lbBasics"
        lbBasics.Size = New Size(40, 15)
        lbBasics.TabIndex = 43
        lbBasics.Text = "Basics"
        ' 
        ' clbBasics
        ' 
        clbBasics.BackColor = Color.Linen
        clbBasics.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clbBasics.ForeColor = Color.ForestGreen
        clbBasics.FormattingEnabled = True
        clbBasics.Items.AddRange(New Object() {"Food & Drinks", "Bill", "Transport", "House Rent", "Fix & Maintenance", "Utilities", "Groceries"})
        clbBasics.Location = New Point(366, 67)
        clbBasics.Margin = New Padding(2, 2, 2, 2)
        clbBasics.Name = "clbBasics"
        clbBasics.Size = New Size(166, 118)
        clbBasics.TabIndex = 28
        ' 
        ' btnSaveNewBudget
        ' 
        btnSaveNewBudget.BackColor = Color.Honeydew
        btnSaveNewBudget.FlatStyle = FlatStyle.Flat
        btnSaveNewBudget.Font = New Font("Tahoma", 10F, FontStyle.Bold)
        btnSaveNewBudget.ForeColor = Color.MintCream
        btnSaveNewBudget.Image = My.Resources.Resources.abf9697f_d88a_45dd_b3de_32a3d56397ce
        btnSaveNewBudget.Location = New Point(622, 356)
        btnSaveNewBudget.Margin = New Padding(2, 2, 2, 2)
        btnSaveNewBudget.Name = "btnSaveNewBudget"
        btnSaveNewBudget.Size = New Size(97, 35)
        btnSaveNewBudget.TabIndex = 42
        btnSaveNewBudget.Text = "SAVE BUDGET"
        btnSaveNewBudget.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.ForestGreen
        Label1.Location = New Point(499, 20)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 19)
        Label1.TabIndex = 41
        Label1.Text = "CATEGORIES"
        ' 
        ' btnGoBackHome
        ' 
        btnGoBackHome.BackColor = Color.Honeydew
        btnGoBackHome.FlatStyle = FlatStyle.Flat
        btnGoBackHome.Font = New Font("Tahoma", 10F, FontStyle.Bold)
        btnGoBackHome.ForeColor = Color.MintCream
        btnGoBackHome.Image = My.Resources.Resources.abf9697f_d88a_45dd_b3de_32a3d56397ce1
        btnGoBackHome.Location = New Point(73, 356)
        btnGoBackHome.Margin = New Padding(2, 2, 2, 2)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(107, 35)
        btnGoBackHome.TabIndex = 40
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = False
        ' 
        ' cbChooseWalllet
        ' 
        cbChooseWalllet.BackColor = Color.Green
        cbChooseWalllet.Font = New Font("Tahoma", 9F)
        cbChooseWalllet.ForeColor = SystemColors.Window
        cbChooseWalllet.FormattingEnabled = True
        cbChooseWalllet.Items.AddRange(New Object() {"demowallet1", "demowallet2", "demowallet3"})
        cbChooseWalllet.Location = New Point(141, 154)
        cbChooseWalllet.Margin = New Padding(2, 2, 2, 2)
        cbChooseWalllet.Name = "cbChooseWalllet"
        cbChooseWalllet.Size = New Size(148, 22)
        cbChooseWalllet.TabIndex = 39
        ' 
        ' lbChooseWallet
        ' 
        lbChooseWallet.AutoSize = True
        lbChooseWallet.BackColor = Color.Green
        lbChooseWallet.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbChooseWallet.ForeColor = Color.Snow
        lbChooseWallet.Location = New Point(22, 155)
        lbChooseWallet.Margin = New Padding(2, 0, 2, 0)
        lbChooseWallet.Name = "lbChooseWallet"
        lbChooseWallet.Size = New Size(87, 15)
        lbChooseWallet.TabIndex = 38
        lbChooseWallet.Text = "Choose wallet:"
        ' 
        ' txtEndDate
        ' 
        txtEndDate.BackColor = Color.Green
        txtEndDate.Font = New Font("Tahoma", 9F)
        txtEndDate.ForeColor = SystemColors.Window
        txtEndDate.Location = New Point(141, 296)
        txtEndDate.Margin = New Padding(2, 2, 2, 2)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.Size = New Size(148, 22)
        txtEndDate.TabIndex = 37
        txtEndDate.Text = "yyyy-MM-dd"
        ' 
        ' lbEndDate
        ' 
        lbEndDate.AutoSize = True
        lbEndDate.BackColor = Color.Green
        lbEndDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEndDate.ForeColor = Color.Snow
        lbEndDate.Location = New Point(30, 298)
        lbEndDate.Margin = New Padding(2, 0, 2, 0)
        lbEndDate.Name = "lbEndDate"
        lbEndDate.Size = New Size(58, 15)
        lbEndDate.TabIndex = 36
        lbEndDate.Text = "End date:"
        ' 
        ' txtStartDate
        ' 
        txtStartDate.BackColor = Color.Green
        txtStartDate.Font = New Font("Tahoma", 9F)
        txtStartDate.ForeColor = SystemColors.Window
        txtStartDate.Location = New Point(141, 245)
        txtStartDate.Margin = New Padding(2, 2, 2, 2)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(148, 22)
        txtStartDate.TabIndex = 35
        txtStartDate.Text = "yyyy-MM-dd"
        ' 
        ' lbStartDate
        ' 
        lbStartDate.AutoSize = True
        lbStartDate.BackColor = Color.Green
        lbStartDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbStartDate.ForeColor = Color.Snow
        lbStartDate.Location = New Point(22, 247)
        lbStartDate.Margin = New Padding(2, 0, 2, 0)
        lbStartDate.Name = "lbStartDate"
        lbStartDate.Size = New Size(66, 15)
        lbStartDate.TabIndex = 34
        lbStartDate.Text = "Start date:"
        ' 
        ' cbTimeRange
        ' 
        cbTimeRange.BackColor = Color.Green
        cbTimeRange.Font = New Font("Tahoma", 9F)
        cbTimeRange.ForeColor = SystemColors.Window
        cbTimeRange.FormattingEnabled = True
        cbTimeRange.Items.AddRange(New Object() {"One time", "Weekly", "Monthly", "Yearly"})
        cbTimeRange.Location = New Point(141, 199)
        cbTimeRange.Margin = New Padding(2, 2, 2, 2)
        cbTimeRange.Name = "cbTimeRange"
        cbTimeRange.Size = New Size(148, 22)
        cbTimeRange.TabIndex = 33
        ' 
        ' lbTimeRange
        ' 
        lbTimeRange.AutoSize = True
        lbTimeRange.BackColor = Color.Green
        lbTimeRange.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTimeRange.ForeColor = Color.Snow
        lbTimeRange.Location = New Point(22, 200)
        lbTimeRange.Margin = New Padding(2, 0, 2, 0)
        lbTimeRange.Name = "lbTimeRange"
        lbTimeRange.Size = New Size(76, 15)
        lbTimeRange.TabIndex = 32
        lbTimeRange.Text = "Time Range:"
        ' 
        ' txtBudgetAmount
        ' 
        txtBudgetAmount.BackColor = Color.Green
        txtBudgetAmount.Font = New Font("Tahoma", 9F)
        txtBudgetAmount.ForeColor = SystemColors.Window
        txtBudgetAmount.Location = New Point(141, 109)
        txtBudgetAmount.Margin = New Padding(2, 2, 2, 2)
        txtBudgetAmount.Name = "txtBudgetAmount"
        txtBudgetAmount.Size = New Size(148, 22)
        txtBudgetAmount.TabIndex = 31
        ' 
        ' lbAmount
        ' 
        lbAmount.AutoSize = True
        lbAmount.BackColor = Color.Green
        lbAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbAmount.ForeColor = Color.Snow
        lbAmount.Location = New Point(22, 109)
        lbAmount.Margin = New Padding(2, 0, 2, 0)
        lbAmount.Name = "lbAmount"
        lbAmount.Size = New Size(55, 15)
        lbAmount.TabIndex = 30
        lbAmount.Text = "Amount:"
        ' 
        ' txtEnterBudgetName
        ' 
        txtEnterBudgetName.BackColor = Color.Green
        txtEnterBudgetName.Font = New Font("Tahoma", 9F)
        txtEnterBudgetName.ForeColor = SystemColors.Window
        txtEnterBudgetName.Location = New Point(141, 67)
        txtEnterBudgetName.Margin = New Padding(2, 2, 2, 2)
        txtEnterBudgetName.Name = "txtEnterBudgetName"
        txtEnterBudgetName.Size = New Size(148, 22)
        txtEnterBudgetName.TabIndex = 29
        ' 
        ' lbBudgetName
        ' 
        lbBudgetName.AutoSize = True
        lbBudgetName.BackColor = Color.Green
        lbBudgetName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBudgetName.ForeColor = Color.Snow
        lbBudgetName.Location = New Point(22, 67)
        lbBudgetName.Margin = New Padding(2, 0, 2, 0)
        lbBudgetName.Name = "lbBudgetName"
        lbBudgetName.Size = New Size(87, 15)
        lbBudgetName.TabIndex = 27
        lbBudgetName.Text = "Budget Name:"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources._54e4ecde_8739_4e27_99ab_90a136f3e070
        ClientSize = New Size(760, 404)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(lbHealthCare)
        Controls.Add(Label3)
        Controls.Add(clbOtherExpenses)
        Controls.Add(clbHealthCare)
        Controls.Add(clbEnjoyments)
        Controls.Add(lbBasics)
        Controls.Add(clbBasics)
        Controls.Add(btnSaveNewBudget)
        Controls.Add(Label1)
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
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form5"
        Text = "Form5"
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
End Class

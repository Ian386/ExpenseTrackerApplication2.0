﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(126, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 25)
        Label4.TabIndex = 50
        Label4.Text = "BASIC INFORMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(857, 356)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 49
        Label2.Text = "Other expenses"
        ' 
        ' lbHealthCare
        ' 
        lbHealthCare.AutoSize = True
        lbHealthCare.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbHealthCare.Location = New Point(523, 356)
        lbHealthCare.Name = "lbHealthCare"
        lbHealthCare.Size = New Size(112, 25)
        lbHealthCare.TabIndex = 48
        lbHealthCare.Text = "Health Care"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(857, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 47
        Label3.Text = "Enjoyment/Give"
        ' 
        ' clbOtherExpenses
        ' 
        clbOtherExpenses.BackColor = SystemColors.Control
        clbOtherExpenses.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbOtherExpenses.ForeColor = SystemColors.WindowText
        clbOtherExpenses.FormattingEnabled = True
        clbOtherExpenses.Items.AddRange(New Object() {"Fee & charge", "Investments", "Kids", "Other"})
        clbOtherExpenses.Location = New Point(857, 396)
        clbOtherExpenses.Name = "clbOtherExpenses"
        clbOtherExpenses.Size = New Size(198, 128)
        clbOtherExpenses.TabIndex = 46
        ' 
        ' clbHealthCare
        ' 
        clbHealthCare.BackColor = SystemColors.Control
        clbHealthCare.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbHealthCare.ForeColor = SystemColors.WindowText
        clbHealthCare.FormattingEnabled = True
        clbHealthCare.Items.AddRange(New Object() {"Doctor", "Sport", "Insurance", "Gym Membership"})
        clbHealthCare.Location = New Point(523, 396)
        clbHealthCare.Name = "clbHealthCare"
        clbHealthCare.Size = New Size(236, 128)
        clbHealthCare.TabIndex = 45
        ' 
        ' clbEnjoyments
        ' 
        clbEnjoyments.BackColor = SystemColors.Control
        clbEnjoyments.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbEnjoyments.ForeColor = SystemColors.WindowText
        clbEnjoyments.FormattingEnabled = True
        clbEnjoyments.Items.AddRange(New Object() {"Entertainment", "Fashion", "Travel", "Beauty Care", "Party", "Gift", "Donation"})
        clbEnjoyments.Location = New Point(857, 112)
        clbEnjoyments.Name = "clbEnjoyments"
        clbEnjoyments.Size = New Size(198, 221)
        clbEnjoyments.TabIndex = 44
        ' 
        ' lbBasics
        ' 
        lbBasics.AutoSize = True
        lbBasics.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbBasics.Location = New Point(523, 73)
        lbBasics.Name = "lbBasics"
        lbBasics.Size = New Size(64, 25)
        lbBasics.TabIndex = 43
        lbBasics.Text = "Basics"
        ' 
        ' clbBasics
        ' 
        clbBasics.BackColor = SystemColors.Control
        clbBasics.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbBasics.ForeColor = SystemColors.WindowText
        clbBasics.FormattingEnabled = True
        clbBasics.Items.AddRange(New Object() {"Food & Drinks", "Bill", "Transport", "House Rent", "Fix & Maintenance", "Utilities", "Groceries"})
        clbBasics.Location = New Point(523, 112)
        clbBasics.Name = "clbBasics"
        clbBasics.Size = New Size(236, 221)
        clbBasics.TabIndex = 28
        ' 
        ' btnSaveNewBudget
        ' 
        btnSaveNewBudget.Location = New Point(889, 593)
        btnSaveNewBudget.Name = "btnSaveNewBudget"
        btnSaveNewBudget.Size = New Size(136, 47)
        btnSaveNewBudget.TabIndex = 42
        btnSaveNewBudget.Text = "SAVE BUDGET"
        btnSaveNewBudget.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(713, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 28)
        Label1.TabIndex = 41
        Label1.Text = "CATEGORIES"
        ' 
        ' btnGoBackHome
        ' 
        btnGoBackHome.Location = New Point(104, 593)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(106, 47)
        btnGoBackHome.TabIndex = 40
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = True
        ' 
        ' cbChooseWalllet
        ' 
        cbChooseWalllet.FormattingEnabled = True
        cbChooseWalllet.Location = New Point(201, 256)
        cbChooseWalllet.Name = "cbChooseWalllet"
        cbChooseWalllet.Size = New Size(210, 33)
        cbChooseWalllet.TabIndex = 39
        ' 
        ' lbChooseWallet
        ' 
        lbChooseWallet.AutoSize = True
        lbChooseWallet.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbChooseWallet.Location = New Point(32, 259)
        lbChooseWallet.Name = "lbChooseWallet"
        lbChooseWallet.Size = New Size(135, 25)
        lbChooseWallet.TabIndex = 38
        lbChooseWallet.Text = "Choose wallet:"
        ' 
        ' txtEndDate
        ' 
        txtEndDate.Location = New Point(201, 493)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.Size = New Size(210, 31)
        txtEndDate.TabIndex = 37
        txtEndDate.Text = "yyyy-MM-dd"
        ' 
        ' lbEndDate
        ' 
        lbEndDate.AutoSize = True
        lbEndDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEndDate.Location = New Point(43, 496)
        lbEndDate.Name = "lbEndDate"
        lbEndDate.Size = New Size(92, 25)
        lbEndDate.TabIndex = 36
        lbEndDate.Text = "End date:"
        ' 
        ' txtStartDate
        ' 
        txtStartDate.Location = New Point(201, 408)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(210, 31)
        txtStartDate.TabIndex = 35
        txtStartDate.Text = "yyyy-MM-dd"
        ' 
        ' lbStartDate
        ' 
        lbStartDate.AutoSize = True
        lbStartDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbStartDate.Location = New Point(32, 411)
        lbStartDate.Name = "lbStartDate"
        lbStartDate.Size = New Size(102, 25)
        lbStartDate.TabIndex = 34
        lbStartDate.Text = "Start date:"
        ' 
        ' cbTimeRange
        ' 
        cbTimeRange.FormattingEnabled = True
        cbTimeRange.Items.AddRange(New Object() {"One time", "Weekly", "Monthly", "Yearly"})
        cbTimeRange.Location = New Point(201, 331)
        cbTimeRange.Name = "cbTimeRange"
        cbTimeRange.Size = New Size(210, 33)
        cbTimeRange.TabIndex = 33
        ' 
        ' lbTimeRange
        ' 
        lbTimeRange.AutoSize = True
        lbTimeRange.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTimeRange.Location = New Point(32, 334)
        lbTimeRange.Name = "lbTimeRange"
        lbTimeRange.Size = New Size(118, 25)
        lbTimeRange.TabIndex = 32
        lbTimeRange.Text = "Time Range:"
        ' 
        ' txtBudgetAmount
        ' 
        txtBudgetAmount.Location = New Point(201, 182)
        txtBudgetAmount.Name = "txtBudgetAmount"
        txtBudgetAmount.Size = New Size(210, 31)
        txtBudgetAmount.TabIndex = 31
        ' 
        ' lbAmount
        ' 
        lbAmount.AutoSize = True
        lbAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbAmount.Location = New Point(32, 182)
        lbAmount.Name = "lbAmount"
        lbAmount.Size = New Size(86, 25)
        lbAmount.TabIndex = 30
        lbAmount.Text = "Amount:"
        ' 
        ' txtEnterBudgetName
        ' 
        txtEnterBudgetName.Location = New Point(201, 112)
        txtEnterBudgetName.Name = "txtEnterBudgetName"
        txtEnterBudgetName.Size = New Size(210, 31)
        txtEnterBudgetName.TabIndex = 29
        ' 
        ' lbBudgetName
        ' 
        lbBudgetName.AutoSize = True
        lbBudgetName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBudgetName.Location = New Point(32, 112)
        lbBudgetName.Name = "lbBudgetName"
        lbBudgetName.Size = New Size(134, 25)
        lbBudgetName.TabIndex = 27
        lbBudgetName.Text = "Budget Name:"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 674)
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

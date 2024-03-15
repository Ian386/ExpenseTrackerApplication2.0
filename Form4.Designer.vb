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
        btnClose = New Button()
        lblGreeting = New Label()
        btnTransaction = New Button()
        btnWallet = New Button()
        btnHelp = New Button()
        btnReports = New Button()
        btnBudget = New Button()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = SystemColors.Control
        btnClose.Font = New Font("Segoe UI", 9F)
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(508, 36)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(60, 43)
        btnClose.TabIndex = 16
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblGreeting
        ' 
        lblGreeting.AutoSize = True
        lblGreeting.BackColor = Color.Transparent
        lblGreeting.Font = New Font("Freestyle Script", 20F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblGreeting.ForeColor = SystemColors.ControlText
        lblGreeting.Location = New Point(47, 36)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(88, 47)
        lblGreeting.TabIndex = 15
        lblGreeting.Text = "Label1"
        ' 
        ' btnTransaction
        ' 
        btnTransaction.AutoSize = True
        btnTransaction.BackColor = SystemColors.Control
        btnTransaction.Font = New Font("Segoe UI", 9F)
        btnTransaction.ForeColor = Color.Black
        btnTransaction.Location = New Point(404, 154)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(166, 76)
        btnTransaction.TabIndex = 14
        btnTransaction.Text = "+ Add Transaction"
        btnTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnWallet
        ' 
        btnWallet.AutoSize = True
        btnWallet.BackColor = SystemColors.Control
        btnWallet.BackgroundImageLayout = ImageLayout.None
        btnWallet.Font = New Font("Segoe UI", 9F)
        btnWallet.ForeColor = Color.Black
        btnWallet.Location = New Point(47, 154)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(165, 76)
        btnWallet.TabIndex = 13
        btnWallet.Text = "Create New Wallet"
        btnWallet.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.AutoSize = True
        btnHelp.BackColor = SystemColors.Control
        btnHelp.ForeColor = Color.Black
        btnHelp.Location = New Point(485, 413)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(112, 41)
        btnHelp.TabIndex = 12
        btnHelp.Text = "Settings"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.AutoSize = True
        btnReports.BackColor = SystemColors.Control
        btnReports.ForeColor = Color.Black
        btnReports.Location = New Point(338, 413)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(112, 41)
        btnReports.TabIndex = 11
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.AutoSize = True
        btnBudget.BackColor = SystemColors.Control
        btnBudget.ForeColor = Color.Black
        btnBudget.Location = New Point(191, 413)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(112, 41)
        btnBudget.TabIndex = 10
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.AutoSize = True
        btnHome.BackColor = SystemColors.Control
        btnHome.ForeColor = Color.Black
        btnHome.Location = New Point(47, 413)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 41)
        btnHome.TabIndex = 9
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 519)
        Controls.Add(btnClose)
        Controls.Add(lblGreeting)
        Controls.Add(btnTransaction)
        Controls.Add(btnWallet)
        Controls.Add(btnHelp)
        Controls.Add(btnReports)
        Controls.Add(btnBudget)
        Controls.Add(btnHome)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
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
    Friend WithEvents btnHome As Button
End Class

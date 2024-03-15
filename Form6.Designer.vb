<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnHome = New Button()
        btnSave = New Button()
        txtAmount = New TextBox()
        lblAmount = New Label()
        comboBoxCategory = New ComboBox()
        lblCategory = New Label()
        lblBudget = New Label()
        comboBoxBudget = New ComboBox()
        lbl = New Label()
        SuspendLayout()
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(62, 354)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 26
        btnHome.Text = "Go Back"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Control
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(401, 350)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 43)
        btnSave.TabIndex = 24
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(209, 246)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(182, 31)
        txtAmount.TabIndex = 23
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(62, 246)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(77, 25)
        lblAmount.TabIndex = 22
        lblAmount.Text = "Amount"
        ' 
        ' comboBoxCategory
        ' 
        comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCategory.FormattingEnabled = True
        comboBoxCategory.Location = New Point(209, 163)
        comboBoxCategory.Name = "comboBoxCategory"
        comboBoxCategory.Size = New Size(182, 33)
        comboBoxCategory.TabIndex = 21
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(62, 165)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(84, 25)
        lblCategory.TabIndex = 20
        lblCategory.Text = "Category"
        ' 
        ' lblBudget
        ' 
        lblBudget.AutoSize = True
        lblBudget.Location = New Point(62, 94)
        lblBudget.Name = "lblBudget"
        lblBudget.Size = New Size(120, 25)
        lblBudget.TabIndex = 19
        lblBudget.Text = "Select Budget"
        ' 
        ' comboBoxBudget
        ' 
        comboBoxBudget.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxBudget.FormattingEnabled = True
        comboBoxBudget.Location = New Point(209, 97)
        comboBoxBudget.Name = "comboBoxBudget"
        comboBoxBudget.Size = New Size(182, 33)
        comboBoxBudget.TabIndex = 18
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Freestyle Script", 20F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl.ForeColor = SystemColors.ControlText
        lbl.Location = New Point(62, 9)
        lbl.Name = "lbl"
        lbl.Size = New Size(188, 47)
        lbl.TabIndex = 27
        lbl.Text = "New transaction"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 450)
        Controls.Add(lbl)
        Controls.Add(btnHome)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(comboBoxCategory)
        Controls.Add(lblCategory)
        Controls.Add(lblBudget)
        Controls.Add(comboBoxBudget)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents comboBoxCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblBudget As Label
    Friend WithEvents comboBoxBudget As ComboBox
    Friend WithEvents lbl As Label
End Class

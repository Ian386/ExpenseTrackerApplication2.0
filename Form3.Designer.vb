<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        bthHome = New Button()
        btnSave = New Button()
        txtAmount = New TextBox()
        lblAmount = New Label()
        ComboBoxCurrency = New ComboBox()
        lblCurrency = New Label()
        txtName = New TextBox()
        lblName = New Label()
        SuspendLayout()
        ' 
        ' bthHome
        ' 
        bthHome.BackColor = Color.White
        bthHome.Location = New Point(508, 268)
        bthHome.Name = "bthHome"
        bthHome.Size = New Size(75, 23)
        bthHome.TabIndex = 15
        bthHome.Text = "Home"
        bthHome.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.White
        btnSave.Location = New Point(266, 258)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.White
        txtAmount.Location = New Point(80, 143)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(187, 23)
        txtAmount.TabIndex = 13
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.White
        lblAmount.Location = New Point(16, 151)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 12
        lblAmount.Text = "Amount"
        ' 
        ' ComboBoxCurrency
        ' 
        ComboBoxCurrency.BackColor = Color.White
        ComboBoxCurrency.FormattingEnabled = True
        ComboBoxCurrency.Location = New Point(80, 96)
        ComboBoxCurrency.Name = "ComboBoxCurrency"
        ComboBoxCurrency.Size = New Size(187, 23)
        ComboBoxCurrency.TabIndex = 11
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.BackColor = Color.White
        lblCurrency.Location = New Point(11, 104)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(55, 15)
        lblCurrency.TabIndex = 10
        lblCurrency.Text = "Currency"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Location = New Point(80, 52)
        txtName.Name = "txtName"
        txtName.Size = New Size(187, 23)
        txtName.TabIndex = 9
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.White
        lblName.Location = New Point(13, 60)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 361)
        Controls.Add(bthHome)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(ComboBoxCurrency)
        Controls.Add(lblCurrency)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bthHome As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents ComboBoxCurrency As ComboBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
End Class

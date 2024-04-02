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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
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
        bthHome.BackColor = Color.Green
        bthHome.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        bthHome.ForeColor = Color.Transparent
        bthHome.Location = New Point(391, 435)
        bthHome.Margin = New Padding(4, 5, 4, 5)
        bthHome.Name = "bthHome"
        bthHome.Size = New Size(107, 63)
        bthHome.TabIndex = 15
        bthHome.Text = "Home"
        bthHome.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Green
        btnSave.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnSave.ForeColor = Color.Transparent
        btnSave.Location = New Point(80, 435)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(107, 63)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.White
        txtAmount.Font = New Font("Tahoma", 9.75F)
        txtAmount.ForeColor = Color.Black
        txtAmount.Location = New Point(213, 291)
        txtAmount.Margin = New Padding(4, 5, 4, 5)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(265, 31)
        txtAmount.TabIndex = 13
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.Transparent
        lblAmount.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblAmount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblAmount.Location = New Point(83, 292)
        lblAmount.Margin = New Padding(4, 0, 4, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(104, 28)
        lblAmount.TabIndex = 12
        lblAmount.Text = "Amount"
        ' 
        ' ComboBoxCurrency
        ' 
        ComboBoxCurrency.BackColor = Color.White
        ComboBoxCurrency.Font = New Font("Tahoma", 9.75F)
        ComboBoxCurrency.ForeColor = Color.Black
        ComboBoxCurrency.FormattingEnabled = True
        ComboBoxCurrency.Location = New Point(213, 204)
        ComboBoxCurrency.Margin = New Padding(4, 5, 4, 5)
        ComboBoxCurrency.Name = "ComboBoxCurrency"
        ComboBoxCurrency.Size = New Size(265, 32)
        ComboBoxCurrency.TabIndex = 11
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.BackColor = Color.Transparent
        lblCurrency.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblCurrency.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblCurrency.Location = New Point(82, 203)
        lblCurrency.Margin = New Padding(4, 0, 4, 0)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(116, 28)
        lblCurrency.TabIndex = 10
        lblCurrency.Text = "Currency"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Tahoma", 9.75F)
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(213, 122)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 31)
        txtName.TabIndex = 9
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblName.Location = New Point(88, 127)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(80, 28)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(597, 599)
        Controls.Add(bthHome)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(ComboBoxCurrency)
        Controls.Add(lblCurrency)
        Controls.Add(txtName)
        Controls.Add(lblName)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = " "
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

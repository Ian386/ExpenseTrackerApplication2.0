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
        bthHome.Location = New Point(457, 266)
        bthHome.Name = "bthHome"
        bthHome.Size = New Size(75, 38)
        bthHome.TabIndex = 15
        bthHome.Text = "Home"
        bthHome.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Green
        btnSave.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnSave.ForeColor = Color.Transparent
        btnSave.Location = New Point(116, 266)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 38)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.White
        txtAmount.Font = New Font("Tahoma", 9.75F)
        txtAmount.ForeColor = Color.Black
        txtAmount.Location = New Point(102, 151)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(187, 23)
        txtAmount.TabIndex = 13
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.White
        lblAmount.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblAmount.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblAmount.Location = New Point(15, 151)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(64, 18)
        lblAmount.TabIndex = 12
        lblAmount.Text = "Amount"
        ' 
        ' ComboBoxCurrency
        ' 
        ComboBoxCurrency.BackColor = Color.White
        ComboBoxCurrency.Font = New Font("Tahoma", 9.75F)
        ComboBoxCurrency.ForeColor = Color.Black
        ComboBoxCurrency.FormattingEnabled = True
        ComboBoxCurrency.Location = New Point(102, 99)
        ComboBoxCurrency.Name = "ComboBoxCurrency"
        ComboBoxCurrency.Size = New Size(187, 24)
        ComboBoxCurrency.TabIndex = 11
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.BackColor = Color.White
        lblCurrency.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblCurrency.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblCurrency.Location = New Point(11, 99)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(76, 18)
        lblCurrency.TabIndex = 10
        lblCurrency.Text = "Currency"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Tahoma", 9.75F)
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(102, 50)
        txtName.Name = "txtName"
        txtName.Size = New Size(187, 23)
        txtName.TabIndex = 9
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.White
        lblName.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblName.Location = New Point(15, 55)
        lblName.Name = "lblName"
        lblName.Size = New Size(51, 18)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
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

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
        btnSave = New Button()
        txtAmount = New TextBox()
        lblAmount = New Label()
        ComboBoxCurrency = New ComboBox()
        lblCurrency = New Label()
        txtName = New TextBox()
        lblName = New Label()
        lbl = New Label()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnClose = New Button()
        btnBudget = New Button()
        Button1 = New Button()
        btnReports = New Button()
        btnHelp = New Button()
        PictureBox5 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Green
        btnSave.BackgroundImage = My.Resources.Resources.buttons
        btnSave.BackgroundImageLayout = ImageLayout.Stretch
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Microsoft Sans Serif", 9F)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(501, 420)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 41)
        btnSave.TabIndex = 14
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.White
        txtAmount.Font = New Font("Tahoma", 9.75F)
        txtAmount.ForeColor = Color.Black
        txtAmount.Location = New Point(348, 338)
        txtAmount.Margin = New Padding(4, 5, 4, 5)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(265, 31)
        txtAmount.TabIndex = 13
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.BackColor = Color.Transparent
        lblAmount.Font = New Font("Segoe UI", 11F)
        lblAmount.ForeColor = Color.Black
        lblAmount.Location = New Point(238, 337)
        lblAmount.Margin = New Padding(4, 0, 4, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(90, 30)
        lblAmount.TabIndex = 12
        lblAmount.Text = "Amount"
        ' 
        ' ComboBoxCurrency
        ' 
        ComboBoxCurrency.BackColor = Color.White
        ComboBoxCurrency.Font = New Font("Tahoma", 9.75F)
        ComboBoxCurrency.ForeColor = Color.Black
        ComboBoxCurrency.FormattingEnabled = True
        ComboBoxCurrency.Location = New Point(348, 283)
        ComboBoxCurrency.Margin = New Padding(4, 5, 4, 5)
        ComboBoxCurrency.Name = "ComboBoxCurrency"
        ComboBoxCurrency.Size = New Size(265, 32)
        ComboBoxCurrency.TabIndex = 11
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.BackColor = Color.Transparent
        lblCurrency.Font = New Font("Segoe UI", 11F)
        lblCurrency.ForeColor = Color.Black
        lblCurrency.Location = New Point(238, 282)
        lblCurrency.Margin = New Padding(4, 0, 4, 0)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(100, 30)
        lblCurrency.TabIndex = 10
        lblCurrency.Text = "Currency"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Tahoma", 9.75F)
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(348, 225)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 31)
        txtName.TabIndex = 9
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 11F)
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(238, 224)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(71, 30)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Freestyle Script", 20F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl.ForeColor = Color.Black
        lbl.Location = New Point(223, 85)
        lbl.Name = "lbl"
        lbl.Size = New Size(148, 47)
        lbl.TabIndex = 29
        lbl.Text = "New Wallet"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnHelp)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(198, 638)
        Panel1.TabIndex = 30
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(15, 340)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 37)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 201)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(15, 401)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 37)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(15, 265)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = SystemColors.Control
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(64, 496)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(82, 37)
        btnClose.TabIndex = 16
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.AutoSize = True
        btnBudget.BackColor = Color.Transparent
        btnBudget.FlatAppearance.BorderSize = 0
        btnBudget.FlatStyle = FlatStyle.Flat
        btnBudget.ForeColor = SystemColors.Control
        btnBudget.Location = New Point(49, 266)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(112, 41)
        btnBudget.TabIndex = 10
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(49, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 41)
        Button1.TabIndex = 9
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.AutoSize = True
        btnReports.BackColor = Color.Transparent
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.ForeColor = SystemColors.Control
        btnReports.Location = New Point(49, 328)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(112, 41)
        btnReports.TabIndex = 11
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.AutoSize = True
        btnHelp.BackColor = Color.Transparent
        btnHelp.FlatAppearance.BorderSize = 0
        btnHelp.FlatStyle = FlatStyle.Flat
        btnHelp.ForeColor = SystemColors.Control
        btnHelp.Location = New Point(49, 397)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(112, 41)
        btnHelp.TabIndex = 12
        btnHelp.Text = "Settings"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(19, 30)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(142, 123)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 31
        PictureBox5.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(690, 638)
        Controls.Add(Panel1)
        Controls.Add(lbl)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(ComboBoxCurrency)
        Controls.Add(lblCurrency)
        Controls.Add(txtName)
        Controls.Add(lblName)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents ComboBoxCurrency As ComboBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class

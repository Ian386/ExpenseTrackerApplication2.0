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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        btnSave = New Button()
        txtAmount = New TextBox()
        lblAmount = New Label()
        lblBudget = New Label()
        cmbBudgets = New ComboBox()
        lbl = New Label()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnBudget = New Button()
        btnClose = New Button()
        Button1 = New Button()
        btnReports = New Button()
        btnHelp = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Control
        btnSave.BackgroundImageLayout = ImageLayout.Stretch
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(307, 190)
        btnSave.Margin = New Padding(2, 2, 2, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(78, 22)
        btnSave.TabIndex = 24
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(258, 142)
        txtAmount.Margin = New Padding(2, 2, 2, 2)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(129, 23)
        txtAmount.TabIndex = 23
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(155, 140)
        lblAmount.Margin = New Padding(2, 0, 2, 0)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 22
        lblAmount.Text = "Amount"
        ' 
        ' lblBudget
        ' 
        lblBudget.AutoSize = True
        lblBudget.Location = New Point(155, 98)
        lblBudget.Margin = New Padding(2, 0, 2, 0)
        lblBudget.Name = "lblBudget"
        lblBudget.Size = New Size(79, 15)
        lblBudget.TabIndex = 19
        lblBudget.Text = "Select Budget"
        ' 
        ' cmbBudgets
        ' 
        cmbBudgets.BackColor = Color.White
        cmbBudgets.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBudgets.FormattingEnabled = True
        cmbBudgets.Location = New Point(258, 96)
        cmbBudgets.Margin = New Padding(2, 2, 2, 2)
        cmbBudgets.Name = "cmbBudgets"
        cmbBudgets.Size = New Size(129, 23)
        cmbBudgets.TabIndex = 18
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Freestyle Script", 20F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl.ForeColor = Color.Black
        lbl.Location = New Point(169, 39)
        lbl.Margin = New Padding(2, 0, 2, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(124, 32)
        lbl.TabIndex = 27
        lbl.Text = "New transaction"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnHelp)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(130, 260)
        Panel1.TabIndex = 28
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(7, 108)
        PictureBox3.Margin = New Padding(2, 2, 2, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 22)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 25)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(7, 145)
        PictureBox4.Margin = New Padding(2, 2, 2, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(27, 22)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(7, 63)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' btnBudget
        ' 
        btnBudget.AutoSize = True
        btnBudget.BackColor = Color.Transparent
        btnBudget.FlatStyle = FlatStyle.Popup
        btnBudget.ForeColor = SystemColors.Control
        btnBudget.Location = New Point(43, 63)
        btnBudget.Margin = New Padding(2, 2, 2, 2)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(78, 25)
        btnBudget.TabIndex = 10
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
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
        btnClose.Location = New Point(41, 202)
        btnClose.Margin = New Padding(2, 2, 2, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(57, 26)
        btnClose.TabIndex = 16
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(43, 22)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 25)
        Button1.TabIndex = 9
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.AutoSize = True
        btnReports.BackColor = Color.Transparent
        btnReports.FlatStyle = FlatStyle.Popup
        btnReports.ForeColor = SystemColors.Control
        btnReports.Location = New Point(43, 100)
        btnReports.Margin = New Padding(2, 2, 2, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(78, 25)
        btnReports.TabIndex = 11
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.AutoSize = True
        btnHelp.BackColor = Color.Transparent
        btnHelp.FlatStyle = FlatStyle.Popup
        btnHelp.ForeColor = SystemColors.Control
        btnHelp.Location = New Point(43, 142)
        btnHelp.Margin = New Padding(2, 2, 2, 2)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(78, 25)
        btnHelp.TabIndex = 12
        btnHelp.Text = "Settings"
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(435, 260)
        Controls.Add(Panel1)
        Controls.Add(lbl)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(lblBudget)
        Controls.Add(cmbBudgets)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form6"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblBudget As Label
    Friend WithEvents cmbBudgets As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnHelp As Button
End Class

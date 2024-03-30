<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Label1 = New Label()
        Label3 = New Label()
        ProfilePicture = New PictureBox()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        BtnSubmit = New Button()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        btnChangeProfile = New Button()
        userName = New TextBox()
        GroupBox3 = New GroupBox()
        btnChangePassword = New Button()
        Label2 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtCurrentPassword = New TextBox()
        Label11 = New Label()
        btnEditWallets = New Button()
        btnHome = New Button()
        btnBudget = New Button()
        btnReports = New Button()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(250, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 0
        Label1.Text = "Profile Settings"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(250, 444)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 2
        Label3.Text = "Security Settings"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(250, 12)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(150, 139)
        ProfilePicture.TabIndex = 4
        ProfilePicture.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 42)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 38)
        TextBox1.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(BtnSubmit)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(426, 191)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 219)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "My Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(225, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 15)
        Label8.TabIndex = 14
        Label8.Text = "Mailing Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(225, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 15)
        Label7.TabIndex = 13
        Label7.Text = "Email Address"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(225, 121)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(178, 38)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(225, 42)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(178, 38)
        TextBox4.TabIndex = 11
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(6, 178)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(120, 33)
        BtnSubmit.TabIndex = 10
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 121)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 38)
        TextBox2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 8
        Label6.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 7
        Label5.Text = "Display Name"
        ' 
        ' btnChangeProfile
        ' 
        btnChangeProfile.Location = New Point(406, 82)
        btnChangeProfile.Name = "btnChangeProfile"
        btnChangeProfile.Size = New Size(146, 22)
        btnChangeProfile.TabIndex = 11
        btnChangeProfile.Text = "Change Profile Photo"
        btnChangeProfile.UseVisualStyleBackColor = True
        ' 
        ' userName
        ' 
        userName.Location = New Point(406, 29)
        userName.Multiline = True
        userName.Name = "userName"
        userName.Size = New Size(228, 38)
        userName.TabIndex = 11
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnChangePassword)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtConfirmPassword)
        GroupBox3.Controls.Add(txtNewPassword)
        GroupBox3.Controls.Add(txtCurrentPassword)
        GroupBox3.Location = New Point(426, 444)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(437, 231)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Change Password"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Location = New Point(6, 193)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(89, 33)
        btnChangePassword.TabIndex = 15
        btnChangePassword.Text = "Submit"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 15)
        Label2.TabIndex = 14
        Label2.Text = "Confirm New Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(18, 79)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 15)
        Label9.TabIndex = 15
        Label9.Text = "New Password"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 15)
        Label10.TabIndex = 16
        Label10.Text = "Current Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(178, 132)
        txtConfirmPassword.Multiline = True
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(170, 38)
        txtConfirmPassword.TabIndex = 17
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(178, 76)
        txtNewPassword.Multiline = True
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(170, 38)
        txtNewPassword.TabIndex = 15
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Location = New Point(178, 22)
        txtCurrentPassword.Multiline = True
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.Size = New Size(170, 38)
        txtCurrentPassword.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(250, 704)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 15)
        Label11.TabIndex = 14
        Label11.Text = "Wallet Settings"
        ' 
        ' btnEditWallets
        ' 
        btnEditWallets.Location = New Point(426, 704)
        btnEditWallets.Name = "btnEditWallets"
        btnEditWallets.Size = New Size(126, 33)
        btnEditWallets.TabIndex = 18
        btnEditWallets.Text = "Edit Wallets"
        btnEditWallets.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Black
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(97, 235)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(109, 36)
        btnHome.TabIndex = 19
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.BackColor = SystemColors.ActiveCaptionText
        btnBudget.ForeColor = SystemColors.Control
        btnBudget.Location = New Point(97, 327)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(109, 37)
        btnBudget.TabIndex = 20
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = SystemColors.ActiveCaptionText
        btnReports.ForeColor = SystemColors.Control
        btnReports.Location = New Point(97, 419)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(109, 33)
        btnReports.TabIndex = 21
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnBudget)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 761)
        Panel1.TabIndex = 22
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(30, 327)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(42, 38)
        PictureBox4.TabIndex = 26
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(30, 414)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(42, 38)
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(30, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 38)
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(910, 761)
        Controls.Add(Panel1)
        Controls.Add(btnEditWallets)
        Controls.Add(Label11)
        Controls.Add(GroupBox3)
        Controls.Add(userName)
        Controls.Add(btnChangeProfile)
        Controls.Add(GroupBox1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form8"
        Text = "Settings"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnChangeProfile As Button
    Friend WithEvents userName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEditWallets As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

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
        Label1 = New Label()
        Label3 = New Label()
        ProfilePicture = New PictureBox()
        txtName = New TextBox()
        GroupBox1 = New GroupBox()
        btnShow = New Button()
        Label13 = New Label()
        txtPass = New TextBox()
        Button7 = New Button()
        Button9 = New Button()
        Label12 = New Label()
        txtUser = New TextBox()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtEmailAddress = New TextBox()
        txtFirstName = New TextBox()
        btnSubmitProfile = New Button()
        txtLastName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        btnChangeProfilePhoto = New Button()
        txtDisplayName = New TextBox()
        GroupBox3 = New GroupBox()
        txtUserName1 = New TextBox()
        btnSee = New Button()
        btnS2 = New Button()
        btnS3 = New Button()
        Label14 = New Label()
        txtConfirmPassword = New TextBox()
        btnChangePassword = New Button()
        Label2 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtNewPassword = New TextBox()
        txtCurrentPassword = New TextBox()
        Label11 = New Label()
        btnEditWallets = New Button()
        Panel1 = New Panel()
        Label15 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        btnReports = New Button()
        btnBudget = New Button()
        btnHome = New Button()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(318, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 0
        Label1.Text = "Profile Settings"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(318, 442)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 2
        Label3.Text = "Security Settings"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(498, 8)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(107, 92)
        ProfilePicture.TabIndex = 4
        ProfilePicture.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(6, 42)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(148, 38)
        txtName.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(Button9)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtEmailAddress)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(btnSubmitProfile)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Location = New Point(498, 111)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(433, 305)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "My Details"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(363, 222)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(44, 33)
        btnShow.TabIndex = 34
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(6, 173)
        Label13.Name = "Label13"
        Label13.Size = New Size(244, 15)
        Label13.TabIndex = 19
        Label13.Text = "Confirm User Login Details to Change Details"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(203, 217)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(209, 38)
        txtPass.TabIndex = 30
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(363, 217)
        Button7.Name = "Button7"
        Button7.Size = New Size(44, 33)
        Button7.TabIndex = 29
        Button7.Text = "Show"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(363, 222)
        Button9.Name = "Button9"
        Button9.Size = New Size(44, 33)
        Button9.TabIndex = 31
        Button9.Text = "Show"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(203, 199)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 15)
        Label12.TabIndex = 17
        Label12.Text = "Password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(6, 217)
        txtUser.Multiline = True
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(148, 38)
        txtUser.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 15
        Label4.Text = "Username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(203, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 15)
        Label8.TabIndex = 14
        Label8.Text = "New Email Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(203, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 15)
        Label7.TabIndex = 13
        Label7.Text = "New First Name"
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(203, 121)
        txtEmailAddress.Multiline = True
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(209, 38)
        txtEmailAddress.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(203, 42)
        txtFirstName.Multiline = True
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(209, 38)
        txtFirstName.TabIndex = 11
        ' 
        ' btnSubmitProfile
        ' 
        btnSubmitProfile.Location = New Point(6, 266)
        btnSubmitProfile.Name = "btnSubmitProfile"
        btnSubmitProfile.Size = New Size(89, 33)
        btnSubmitProfile.TabIndex = 10
        btnSubmitProfile.Text = "change"
        btnSubmitProfile.UseVisualStyleBackColor = True
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(6, 121)
        txtLastName.Multiline = True
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(148, 38)
        txtLastName.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 15)
        Label6.TabIndex = 8
        Label6.Text = "New Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 7
        Label5.Text = "New Username"
        ' 
        ' btnChangeProfilePhoto
        ' 
        btnChangeProfilePhoto.Location = New Point(621, 52)
        btnChangeProfilePhoto.Name = "btnChangeProfilePhoto"
        btnChangeProfilePhoto.Size = New Size(146, 22)
        btnChangeProfilePhoto.TabIndex = 11
        btnChangeProfilePhoto.Text = "Change Profile Photo"
        btnChangeProfilePhoto.UseVisualStyleBackColor = True
        ' 
        ' txtDisplayName
        ' 
        txtDisplayName.Location = New Point(621, 8)
        txtDisplayName.Multiline = True
        txtDisplayName.Name = "txtDisplayName"
        txtDisplayName.Size = New Size(228, 38)
        txtDisplayName.TabIndex = 11
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtUserName1)
        GroupBox3.Controls.Add(btnSee)
        GroupBox3.Controls.Add(btnS2)
        GroupBox3.Controls.Add(btnS3)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(txtConfirmPassword)
        GroupBox3.Controls.Add(btnChangePassword)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtNewPassword)
        GroupBox3.Controls.Add(txtCurrentPassword)
        GroupBox3.Location = New Point(493, 442)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(438, 309)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Change Password"
        ' 
        ' txtUserName1
        ' 
        txtUserName1.Location = New Point(208, 20)
        txtUserName1.Multiline = True
        txtUserName1.Name = "txtUserName1"
        txtUserName1.PasswordChar = "*"c
        txtUserName1.Size = New Size(209, 38)
        txtUserName1.TabIndex = 35
        ' 
        ' btnSee
        ' 
        btnSee.Location = New Point(368, 76)
        btnSee.Name = "btnSee"
        btnSee.Size = New Size(44, 33)
        btnSee.TabIndex = 39
        btnSee.Text = "Show"
        btnSee.UseVisualStyleBackColor = True
        ' 
        ' btnS2
        ' 
        btnS2.Location = New Point(368, 140)
        btnS2.Name = "btnS2"
        btnS2.Size = New Size(44, 33)
        btnS2.TabIndex = 36
        btnS2.Text = "Show"
        btnS2.UseVisualStyleBackColor = True
        ' 
        ' btnS3
        ' 
        btnS3.Location = New Point(368, 211)
        btnS3.Name = "btnS3"
        btnS3.Size = New Size(44, 33)
        btnS3.TabIndex = 38
        btnS3.Text = "Show"
        btnS3.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(27, 220)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 15)
        Label14.TabIndex = 18
        Label14.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(208, 206)
        txtConfirmPassword.Multiline = True
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(209, 38)
        txtConfirmPassword.TabIndex = 37
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Location = New Point(15, 266)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(89, 33)
        btnChangePassword.TabIndex = 15
        btnChangePassword.Text = "Submit"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 14
        Label2.Text = "New Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(27, 99)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 15)
        Label9.TabIndex = 15
        Label9.Text = "Current Password"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(25, 43)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 16
        Label10.Text = "Username"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(208, 135)
        txtNewPassword.Multiline = True
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(209, 38)
        txtNewPassword.TabIndex = 22
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Location = New Point(208, 76)
        txtCurrentPassword.Multiline = True
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.PasswordChar = "*"c
        txtCurrentPassword.Size = New Size(209, 38)
        txtCurrentPassword.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(318, 767)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 15)
        Label11.TabIndex = 14
        Label11.Text = "Wallet Settings"
        ' 
        ' btnEditWallets
        ' 
        btnEditWallets.Location = New Point(493, 767)
        btnEditWallets.Name = "btnEditWallets"
        btnEditWallets.Size = New Size(89, 33)
        btnEditWallets.TabIndex = 18
        btnEditWallets.Text = "Edit Wallets"
        btnEditWallets.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(btnReports)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(btnHome)
        Panel1.Location = New Point(-3, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(286, 814)
        Panel1.TabIndex = 19
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(49, 31)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 15)
        Label15.TabIndex = 20
        Label15.Text = "Profile Settings"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(49, 479)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 47)
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Location = New Point(49, 390)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(51, 47)
        PictureBox5.TabIndex = 23
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(49, 296)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(51, 47)
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(141, 479)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(89, 33)
        btnReports.TabIndex = 20
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnBudget
        ' 
        btnBudget.Location = New Point(141, 390)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(89, 33)
        btnBudget.TabIndex = 21
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(141, 310)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(89, 33)
        btnHome.TabIndex = 22
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 812)
        Controls.Add(Panel1)
        Controls.Add(btnEditWallets)
        Controls.Add(Label11)
        Controls.Add(GroupBox3)
        Controls.Add(txtDisplayName)
        Controls.Add(btnChangeProfilePhoto)
        Controls.Add(GroupBox1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form8"
        Text = "Form8"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmitProfile As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnChangeProfilePhoto As Button
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbxNewPassword As TextBox
    Friend WithEvents tbxCurrentPassword As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEditWallets As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxConfirmPassword As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnS1 As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnS2 As Button
    Friend WithEvents btnS3 As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSee As Button

    Friend WithEvents txtUserName1 As TextBox


End Class

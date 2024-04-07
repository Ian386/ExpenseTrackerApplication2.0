<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Label1 = New Label()
        Label3 = New Label()
        ProfilePicture = New PictureBox()
        txtName = New TextBox()
        GroupBox1 = New GroupBox()
        btnShow = New Button()
        Label13 = New Label()
        txtPass = New TextBox()
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
        btnReports = New Button()
        btnBudget = New Button()
        btnHome = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        btnClose = New Button()
        Panel1 = New Panel()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(261, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 0
        Label1.Text = "Profile Settings"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(261, 359)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 15)
        Label3.TabIndex = 2
        Label3.Text = "Security Settings"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(3, 3)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(72, 52)
        ProfilePicture.TabIndex = 4
        ProfilePicture.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(6, 42)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(148, 24)
        txtName.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(txtPass)
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
        GroupBox1.Location = New Point(380, 90)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(433, 250)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "My Details"
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.White
        btnShow.FlatAppearance.BorderColor = Color.Chartreuse
        btnShow.FlatAppearance.BorderSize = 2
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.Location = New Point(358, 174)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(60, 25)
        btnShow.TabIndex = 34
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(6, 133)
        Label13.Name = "Label13"
        Label13.Size = New Size(244, 15)
        Label13.TabIndex = 19
        Label13.Text = "Confirm User Login Details to Change Details"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(202, 178)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(148, 24)
        txtPass.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(202, 160)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 15)
        Label12.TabIndex = 17
        Label12.Text = "Password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(6, 178)
        txtUser.Multiline = True
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(148, 24)
        txtUser.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 15
        Label4.Text = "Username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(203, 79)
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
        txtEmailAddress.Location = New Point(203, 97)
        txtEmailAddress.Multiline = True
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(148, 24)
        txtEmailAddress.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(203, 42)
        txtFirstName.Multiline = True
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(148, 24)
        txtFirstName.TabIndex = 11
        ' 
        ' btnSubmitProfile
        ' 
        btnSubmitProfile.BackgroundImage = My.Resources.Resources.buttons
        btnSubmitProfile.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmitProfile.FlatAppearance.BorderSize = 0
        btnSubmitProfile.FlatStyle = FlatStyle.Flat
        btnSubmitProfile.Location = New Point(6, 215)
        btnSubmitProfile.Name = "btnSubmitProfile"
        btnSubmitProfile.Size = New Size(89, 25)
        btnSubmitProfile.TabIndex = 10
        btnSubmitProfile.Text = "change"
        btnSubmitProfile.UseVisualStyleBackColor = True
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(6, 97)
        txtLastName.Multiline = True
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(148, 24)
        txtLastName.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 79)
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
        btnChangeProfilePhoto.Location = New Point(161, 33)
        btnChangeProfilePhoto.Name = "btnChangeProfilePhoto"
        btnChangeProfilePhoto.Size = New Size(146, 31)
        btnChangeProfilePhoto.TabIndex = 11
        btnChangeProfilePhoto.Text = "Change Profile Photo"
        btnChangeProfilePhoto.UseVisualStyleBackColor = True
        ' 
        ' txtDisplayName
        ' 
        txtDisplayName.Location = New Point(80, 3)
        txtDisplayName.Multiline = True
        txtDisplayName.Name = "txtDisplayName"
        txtDisplayName.Size = New Size(228, 27)
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
        GroupBox3.Location = New Point(375, 359)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(438, 221)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Change Password"
        ' 
        ' txtUserName1
        ' 
        txtUserName1.Location = New Point(208, 20)
        txtUserName1.Multiline = True
        txtUserName1.Name = "txtUserName1"
        txtUserName1.Size = New Size(148, 24)
        txtUserName1.TabIndex = 35
        ' 
        ' btnSee
        ' 
        btnSee.BackColor = Color.White
        btnSee.FlatAppearance.BorderColor = Color.Chartreuse
        btnSee.FlatAppearance.BorderSize = 2
        btnSee.FlatStyle = FlatStyle.Flat
        btnSee.Location = New Point(363, 50)
        btnSee.Name = "btnSee"
        btnSee.Size = New Size(60, 27)
        btnSee.TabIndex = 39
        btnSee.Text = "Show"
        btnSee.UseVisualStyleBackColor = False
        ' 
        ' btnS2
        ' 
        btnS2.BackColor = Color.White
        btnS2.FlatAppearance.BorderColor = Color.Chartreuse
        btnS2.FlatAppearance.BorderSize = 2
        btnS2.FlatStyle = FlatStyle.Flat
        btnS2.Location = New Point(363, 97)
        btnS2.Name = "btnS2"
        btnS2.Size = New Size(60, 26)
        btnS2.TabIndex = 36
        btnS2.Text = "Show"
        btnS2.UseVisualStyleBackColor = False
        ' 
        ' btnS3
        ' 
        btnS3.BackColor = Color.White
        btnS3.FlatAppearance.BorderColor = Color.Chartreuse
        btnS3.FlatAppearance.BorderSize = 2
        btnS3.FlatStyle = FlatStyle.Flat
        btnS3.Location = New Point(363, 148)
        btnS3.Name = "btnS3"
        btnS3.Size = New Size(60, 26)
        btnS3.TabIndex = 38
        btnS3.Text = "Show"
        btnS3.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(26, 142)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 15)
        Label14.TabIndex = 18
        Label14.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(207, 152)
        txtConfirmPassword.Multiline = True
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(148, 24)
        txtConfirmPassword.TabIndex = 37
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackgroundImage = My.Resources.Resources.buttons
        btnChangePassword.BackgroundImageLayout = ImageLayout.Stretch
        btnChangePassword.FlatAppearance.BorderSize = 0
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.Location = New Point(26, 185)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(89, 22)
        btnChangePassword.TabIndex = 15
        btnChangePassword.Text = "Submit"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 14
        Label2.Text = "New Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(26, 56)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 15)
        Label9.TabIndex = 15
        Label9.Text = "Current Password"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(26, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 16
        Label10.Text = "Username"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(207, 101)
        txtNewPassword.Multiline = True
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(148, 24)
        txtNewPassword.TabIndex = 22
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Location = New Point(207, 54)
        txtCurrentPassword.Multiline = True
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.PasswordChar = "*"c
        txtCurrentPassword.Size = New Size(148, 24)
        txtCurrentPassword.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(270, 614)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 15)
        Label11.TabIndex = 14
        Label11.Text = "App Settings"
        ' 
        ' btnEditWallets
        ' 
        btnEditWallets.Location = New Point(375, 605)
        btnEditWallets.Name = "btnEditWallets"
        btnEditWallets.Size = New Size(89, 33)
        btnEditWallets.TabIndex = 18
        btnEditWallets.Text = "Edit Wallets"
        btnEditWallets.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Transparent
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.ForeColor = Color.White
        btnReports.Location = New Point(40, 301)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(89, 33)
        btnReports.TabIndex = 20
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnBudget
        ' 
        btnBudget.BackColor = Color.Transparent
        btnBudget.FlatAppearance.BorderSize = 0
        btnBudget.FlatStyle = FlatStyle.Flat
        btnBudget.ForeColor = Color.White
        btnBudget.Location = New Point(40, 240)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(89, 33)
        btnBudget.TabIndex = 21
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Transparent
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(40, 176)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(89, 33)
        btnHome.TabIndex = 22
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImage = My.Resources.Resources.download
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(btnReports)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Controls.Add(btnBudget)
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(btnHome)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(155, 661)
        Panel2.TabIndex = 31
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 31)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(99, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 304)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 22)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(26, 181)
        PictureBox6.Margin = New Padding(2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(27, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 23
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(26, 242)
        PictureBox8.Margin = New Padding(2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(27, 22)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 20
        PictureBox8.TabStop = False
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
        btnClose.Location = New Point(46, 379)
        btnClose.Margin = New Padding(2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(57, 26)
        btnClose.TabIndex = 16
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtDisplayName)
        Panel1.Controls.Add(btnChangeProfilePhoto)
        Panel1.Controls.Add(ProfilePicture)
        Panel1.Location = New Point(498, 8)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(316, 67)
        Panel1.TabIndex = 32
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(885, 661)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(btnEditWallets)
        Controls.Add(Label11)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        WindowState = FormWindowState.Maximized
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnS2 As Button
    Friend WithEvents btnS3 As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSee As Button

    Friend WithEvents txtUserName1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel


End Class
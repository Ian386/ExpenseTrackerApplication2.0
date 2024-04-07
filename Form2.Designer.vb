<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        firstname = New TextBox()
        lastname = New TextBox()
        username = New TextBox()
        Email = New TextBox()
        password = New TextBox()
        cfm_password = New TextBox()
        Button1 = New Button()
        Panel1 = New Panel()
        lbl = New Label()
        btnClose = New Button()
        btnGoBackHome = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(136, 81)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(136, 113)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(136, 149)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(136, 184)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(136, 218)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 4
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(136, 255)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 15)
        Label6.TabIndex = 5
        Label6.Text = "Confirm Password"
        ' 
        ' firstname
        ' 
        firstname.Location = New Point(256, 77)
        firstname.Margin = New Padding(2, 2, 2, 2)
        firstname.Name = "firstname"
        firstname.Size = New Size(159, 23)
        firstname.TabIndex = 6
        ' 
        ' lastname
        ' 
        lastname.Location = New Point(256, 113)
        lastname.Margin = New Padding(2, 2, 2, 2)
        lastname.Name = "lastname"
        lastname.Size = New Size(159, 23)
        lastname.TabIndex = 7
        ' 
        ' username
        ' 
        username.Location = New Point(256, 149)
        username.Margin = New Padding(2, 2, 2, 2)
        username.Name = "username"
        username.Size = New Size(159, 23)
        username.TabIndex = 8
        ' 
        ' Email
        ' 
        Email.Location = New Point(256, 184)
        Email.Margin = New Padding(2, 2, 2, 2)
        Email.Name = "Email"
        Email.Size = New Size(159, 23)
        Email.TabIndex = 9
        ' 
        ' password
        ' 
        password.Location = New Point(256, 215)
        password.Margin = New Padding(2, 2, 2, 2)
        password.Name = "password"
        password.Size = New Size(159, 23)
        password.TabIndex = 10
        ' 
        ' cfm_password
        ' 
        cfm_password.Location = New Point(256, 251)
        cfm_password.Margin = New Padding(2, 2, 2, 2)
        cfm_password.Name = "cfm_password"
        cfm_password.Size = New Size(159, 23)
        cfm_password.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.buttons
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(336, 311)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 20)
        Button1.TabIndex = 12
        Button1.Text = "SIGN-UP"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(104, 383)
        Panel1.TabIndex = 13
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.Font = New Font("Freestyle Script", 20F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl.ForeColor = Color.Black
        lbl.Location = New Point(136, 25)
        lbl.Margin = New Padding(2, 0, 2, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(70, 32)
        lbl.TabIndex = 28
        lbl.Text = "Sign Up"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = Color.White
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Red
        btnClose.Location = New Point(391, 13)
        btnClose.Margin = New Padding(2, 2, 2, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 25)
        btnClose.TabIndex = 17
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnGoBackHome
        ' 
        btnGoBackHome.BackColor = Color.Honeydew
        btnGoBackHome.BackgroundImage = My.Resources.Resources.buttons
        btnGoBackHome.BackgroundImageLayout = ImageLayout.Stretch
        btnGoBackHome.FlatAppearance.BorderSize = 0
        btnGoBackHome.FlatStyle = FlatStyle.Flat
        btnGoBackHome.Font = New Font("Segoe UI", 9F)
        btnGoBackHome.ForeColor = Color.Black
        btnGoBackHome.Location = New Point(136, 311)
        btnGoBackHome.Margin = New Padding(2, 2, 2, 2)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(82, 20)
        btnGoBackHome.TabIndex = 41
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(483, 383)
        Controls.Add(btnGoBackHome)
        Controls.Add(btnClose)
        Controls.Add(lbl)
        Controls.Add(Button1)
        Controls.Add(cfm_password)
        Controls.Add(password)
        Controls.Add(Email)
        Controls.Add(username)
        Controls.Add(lastname)
        Controls.Add(firstname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGN-UP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents f_name As TextBox
    Friend WithEvents l_name As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents cfm_password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents firstname As TextBox
    Friend WithEvents lastname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnGoBackHome As Button
End Class

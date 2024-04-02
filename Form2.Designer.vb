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
        f_name = New TextBox()
        l_name = New TextBox()
        username = New TextBox()
        Email = New TextBox()
        password = New TextBox()
        cfm_password = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(212, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(212, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 1
        Label2.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(212, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(212, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 25)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(212, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 4
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(212, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 25)
        Label6.TabIndex = 5
        Label6.Text = "Confirm Password"
        ' 
        ' f_name
        ' 
        f_name.Location = New Point(406, 56)
        f_name.Name = "f_name"
        f_name.Size = New Size(150, 31)
        f_name.TabIndex = 6
        ' 
        ' l_name
        ' 
        l_name.Location = New Point(406, 115)
        l_name.Name = "l_name"
        l_name.Size = New Size(150, 31)
        l_name.TabIndex = 7
        ' 
        ' username
        ' 
        username.Location = New Point(406, 175)
        username.Name = "username"
        username.Size = New Size(150, 31)
        username.TabIndex = 8
        ' 
        ' Email
        ' 
        Email.Location = New Point(406, 233)
        Email.Name = "Email"
        Email.Size = New Size(150, 31)
        Email.TabIndex = 9
        ' 
        ' password
        ' 
        password.Location = New Point(406, 285)
        password.Name = "password"
        password.Size = New Size(150, 31)
        password.TabIndex = 10
        ' 
        ' cfm_password
        ' 
        cfm_password.Location = New Point(406, 346)
        cfm_password.Name = "cfm_password"
        cfm_password.Size = New Size(150, 31)
        cfm_password.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(329, 404)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 12
        Button1.Text = "SIGN-UP"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2024_03_31_at_9_29_17_AM
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(cfm_password)
        Controls.Add(password)
        Controls.Add(Email)
        Controls.Add(username)
        Controls.Add(l_name)
        Controls.Add(f_name)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        username = New TextBox()
        password = New TextBox()

        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True

        Label3.Location = New Point(138, 220)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)

        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True

        Label4.Location = New Point(138, 256)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)

        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True

        Label5.Location = New Point(140, 347)
        Label5.Margin = New Padding(2, 0, 2, 0)

        Label5.Name = "Label5"
        Label5.Size = New Size(115, 15)
        Label5.TabIndex = 4
        Label5.Text = "If you are a new user"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True

        Label6.Location = New Point(304, 349)
        Label6.Margin = New Padding(2, 0, 2, 0)

        Label6.Name = "Label6"
        Label6.Size = New Size(27, 15)
        Label6.TabIndex = 5
        Label6.Text = "first"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True

        LinkLabel1.Location = New Point(258, 347)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)

        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(48, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "sign_up"
        ' 
        ' Button1
        ' 

        Button1.BackgroundImage = My.Resources.Resources.buttons
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat

        Button1.Location = New Point(200, 306)
        Button1.Margin = New Padding(2)

        Button1.Name = "Button1"
        Button1.Size = New Size(78, 20)
        Button1.TabIndex = 7
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' username
        ' 

        username.Location = New Point(244, 220)
        username.Margin = New Padding(2)
        username.Name = "username"
        username.Size = New Size(106, 23)

        username.TabIndex = 8
        ' 
        ' password
        ' 

        password.Location = New Point(244, 256)
        password.Margin = New Padding(2)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(106, 23)
        password.TabIndex = 9

        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderColor = Color.Red
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red

        Button2.Location = New Point(422, 14)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(28, 22)

        Button2.TabIndex = 10
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Modern_Initial_E_Logo

        PictureBox1.Location = New Point(138, 31)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 200)

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)

        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(498, 53)
        Panel1.TabIndex = 12

        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font

        BackColor = Color.White
        ClientSize = New Size(498, 416)
        Controls.Add(Panel1)
        Controls.Add(password)
        Controls.Add(username)

        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)

        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)

        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "WELCOME"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox

    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel


End Class

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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(590, 35)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO EXPENSE TRACKER 2.0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(-7, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(468, 27)
        Label2.TabIndex = 1
        Label2.Text = "Where your expenses meet your budget"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(205, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(205, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 25)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(190, 416)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 25)
        Label5.TabIndex = 4
        Label5.Text = "If you are a new user"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(451, 416)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 25)
        Label6.TabIndex = 5
        Label6.Text = "first"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(372, 416)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(73, 25)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "sign_up"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(322, 339)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 7
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(410, 153)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(410, 249)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "WELCOME"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class

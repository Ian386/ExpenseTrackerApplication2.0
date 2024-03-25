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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(406, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(406, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(406, 175)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(406, 233)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 31)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(406, 285)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(150, 31)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(406, 346)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(150, 31)
        TextBox6.TabIndex = 11
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
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
End Class

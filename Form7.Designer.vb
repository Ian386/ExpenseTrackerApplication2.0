<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        DataGridView1 = New DataGridView()
        radEnjoyment = New RadioButton()
        radCls = New RadioButton()
        radHO = New RadioButton()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnGoBackHome = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 79)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(585, 400)
        DataGridView1.TabIndex = 0
        ' 
        ' radEnjoyment
        ' 
        radEnjoyment.AutoSize = True
        radEnjoyment.BackColor = Color.Transparent
        radEnjoyment.ForeColor = Color.White
        radEnjoyment.Location = New Point(633, 112)
        radEnjoyment.Name = "radEnjoyment"
        radEnjoyment.Size = New Size(121, 29)
        radEnjoyment.TabIndex = 1
        radEnjoyment.TabStop = True
        radEnjoyment.Text = "Enjoyment"
        radEnjoyment.UseVisualStyleBackColor = False
        ' 
        ' radCls
        ' 
        radCls.AutoSize = True
        radCls.BackColor = Color.Transparent
        radCls.ForeColor = Color.White
        radCls.Location = New Point(633, 165)
        radCls.Name = "radCls"
        radCls.Size = New Size(183, 29)
        radCls.TabIndex = 2
        radCls.TabStop = True
        radCls.Text = "Clothes and Basics"
        radCls.UseVisualStyleBackColor = False
        ' 
        ' radHO
        ' 
        radHO.AutoSize = True
        radHO.BackColor = Color.Transparent
        radHO.ForeColor = Color.White
        radHO.Location = New Point(633, 224)
        radHO.Name = "radHO"
        radHO.Size = New Size(196, 29)
        radHO.TabIndex = 3
        radHO.TabStop = True
        radHO.Text = "Hospital and Others"
        radHO.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Freestyle Script", 20F, FontStyle.Underline)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(125, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 47)
        Label1.TabIndex = 4
        Label1.Text = "Monthly Spend Per Category"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(620, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(219, 202)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Categories"
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
        btnGoBackHome.Location = New Point(657, 401)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(137, 39)
        btnGoBackHome.TabIndex = 41
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderColor = Color.Red
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(776, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 36)
        Button2.TabIndex = 42
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        ClientSize = New Size(861, 509)
        Controls.Add(Button2)
        Controls.Add(btnGoBackHome)
        Controls.Add(Label1)
        Controls.Add(radHO)
        Controls.Add(radCls)
        Controls.Add(radEnjoyment)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents radEnjoyment As RadioButton
    Friend WithEvents radCls As RadioButton
    Friend WithEvents radHO As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGoBackHome As Button
    Friend WithEvents Button2 As Button
End Class
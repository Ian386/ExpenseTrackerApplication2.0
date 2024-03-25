Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox4.Text
        ' Regular expression pattern for a valid email address
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        ' Check if the email address matches the pattern
        If Not Regex.IsMatch(email, pattern) Then
            MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If TextBox6.Text <> TextBox5.Text Then
            MessageBox.Show("Invalid Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' Check if all the textboxes are filled and the email address matches the pattern
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" AndAlso TextBox3.Text <> "" AndAlso TextBox4.Text <> "" AndAlso TextBox5.Text <> "" AndAlso TextBox6.Text <> "" AndAlso Regex.IsMatch(email, pattern) AndAlso TextBox6.Text = TextBox5.Text Then
            ' Set the global variable to indicate that sign-up button is clicked
            Dim form1 As New Form1
            Form1.signUpClicked = True
            Me.Close()
        Else ' If any of the textboxes are empty, show a message
            MessageBox.Show("Please fill all details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
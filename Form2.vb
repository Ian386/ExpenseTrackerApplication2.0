Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\OneDrive\Desktop\Expense Tracker 2.0\ETrackerApp.mdf1\ETrackerApp.mdf1.mdf;Integrated Security=True;Connect Timeout=30"
        con.Open()
        cmd = New SqlCommand("INSERT INTO user_table values('" & f_name.Text & "','" & l_name.Text & "','" & username.Text & "','" & Me.Email.Text & "','" & Me.password.Text & "')", con)


        Dim email As String = Me.Email.Text
        ' Regular expression pattern for a valid email address
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        ' Check if the email address matches the pattern


        If Not Regex.IsMatch(email, pattern) Then
            MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If cfm_password.Text <> password.Text Then
            MessageBox.Show("Password Mismatch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Check if all the textboxes are filled and the email address matches the pattern
        If f_name.Text = "" Or l_name.Text = "" Or username.Text = "" Or Me.Email.Text = "" Or password.Text = "" Or cfm_password.Text = "" Or Not Regex.IsMatch(email, pattern) Or cfm_password.Text <> password.Text Then
            MessageBox.Show("Please fill all fields correctly")
        Else ' If any of the textboxes are empty, show a message
            cmd = New SqlCommand("INSERT INTO user_table values('" & f_name.Text & "','" & l_name.Text & "','" & username.Text & "','" & Me.Email.Text & "','" & password.Text & "')", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User Registered Successfully")
            Dim form1 As New Form1
            Form1.signUpClicked = True
            Me.Close()
            f_name.Clear()
            l_name.Clear()
            username.Clear()
            Me.Email.Clear()
            password.Clear()
            cfm_password.Clear()
        End If
        con.Close()
    End Sub
End Class
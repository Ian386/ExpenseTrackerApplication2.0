Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\ETrackerApp.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"
        con.Open()
        cmd = New SqlCommand("INSERT INTO user_table values('" & firstname.Text & "','" & lastname.Text & "','" & username.Text & "','" & Me.Email.Text & "','" & Me.password.Text & "')", con)



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

        If firstname.Text = "" Or lastname.Text = "" Or username.Text = "" Or Me.Email.Text = "" Or password.Text = "" Or cfm_password.Text = "" Or Not Regex.IsMatch(email, pattern) Or cfm_password.Text <> password.Text Then
            MessageBox.Show("Please fill all fields correctly")
        Else ' If any of the textboxes are empty, show a message
            cmd = New SqlCommand("INSERT INTO user_table values('" & firstname.Text & "','" & lastname.Text & "','" & username.Text & "','" & Me.Email.Text & "','" & password.Text & "')", con)

            cmd.ExecuteNonQuery()
            MessageBox.Show("User Registered Successfully")
            Dim form1 As New Form1
            Form4.Show()
            Me.Close()

            firstname.Clear()
            lastname.Clear()

            username.Clear()
            Me.Email.Clear()
            password.Clear()
            cfm_password.Clear()

        End If
        con.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return

        End If
        con.Close()
    End Sub
End Class
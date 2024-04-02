Imports System.Data.SqlClient
Public Class Form1
    Public Shared signUpClicked As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\OneDrive\Desktop\Expense Tracker 2.0\ETrackerApp.mdf1\ETrackerApp.mdf1.mdf;Integrated Security=True;Connect Timeout=30"
        con.Open()
        Dim stmt As String = "SELECT * FROM user_table WHERE username = '" & username.Text & "' AND password = '" & password.Text & "'"
        cmd = New SqlCommand(stmt, con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            MessageBox.Show("Login Successful")
            Dim form4 As New Form4
            form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password")
            username.Clear()
            password.Clear()
        End If
        con.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2 As New Form2
        form2.Show()
    End Sub
End Class

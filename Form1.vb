Imports Microsoft.Data.SqlClient

Public Class Form1
    Public _userId As Integer

    ' Constructor with userId parameter
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nzamb\OneDrive\Documents\jkuat\DICA\sem_project\ExpenseTrackerApplication2.0\ETrackerApp.mdf;Integrated Security=True"
        con.Open()
        Dim stmt As String = "SELECT user_id FROM user_table WHERE username = @username AND password = @password"
        cmd = New SqlCommand(stmt, con)
        cmd.Parameters.AddWithValue("@username", username.Text)
        cmd.Parameters.AddWithValue("@password", password.Text)

        Dim userId As Integer = -1
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            userId = Convert.ToInt32(dr("user_id"))
            _userId = userId ' Set _userId
            MessageBox.Show("Login Successful.")
            Dim form4 As New Form4(userId)
            Me.Hide()
            form4.Show()
        Else
            MessageBox.Show("Invalid username or password")
            username.Clear()
            password.Clear()
        End If
        con.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2instance As New Form2(_userId) ' Pass _userId instead of userId
        form2instance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub
End Class

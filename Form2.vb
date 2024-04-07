Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class Form2

    Private _userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nzamb\OneDrive\Documents\jkuat\DICA\sem_project\ExpenseTrackerApplication2.0\ETrackerApp.mdf;Integrated Security=True"
        con.Open()

        Dim email As String = Me.Email.Text
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        If Not Regex.IsMatch(email, pattern) Then
            MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If cfm_password.Text <> password.Text Then
            MessageBox.Show("Password Mismatch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If firstname.Text = "" Or lastname.Text = "" Or username.Text = "" Or Me.Email.Text = "" Or password.Text = "" Or cfm_password.Text = "" Then
            MessageBox.Show("Please fill all fields correctly")
            Return
        End If

        cmd = New SqlCommand("INSERT INTO user_table values('" & firstname.Text & "','" & lastname.Text & "','" & username.Text & "','" & Me.Email.Text & "','" & password.Text & "')", con)
        cmd.ExecuteNonQuery()

        MessageBox.Show("User Registered Successfully")
        Dim form4Instance As New Form4(_userId)
        form4Instance.Show()
        Me.Close()

        firstname.Clear()
        lastname.Clear()
        username.Clear()
        Me.Email.Clear()
        password.Clear()
        cfm_password.Clear()

        con.Close()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnGoBackHome_Click(sender As Object, e As EventArgs) Handles btnGoBackHome.Click
        Me.Close()
        Dim form4Instance As New Form4(_userId)
        form4Instance.Show()

    End Sub

End Class
Public Class Form1
    Public Shared signUpClicked As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If signUpClicked Then
            Dim form4 As New Form4
            form4.Show()
            Dim form3 As New Form3
            form3.Show()
        Else
            ' If user has not clicked the sign-up button, open only Form4
            Dim form4 As New Form4
            form4.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form2 As New Form2
        form2.Show()
    End Sub
End Class

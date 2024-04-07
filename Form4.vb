Imports System.Data.Common
Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form4

    Private _userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentTime As DateTime = DateTime.Now
        Dim greeting As String
        If currentTime.Hour < 12 Then
            greeting = "Good morning"
        ElseIf currentTime.Hour < 18 Then
            greeting = "Good afternoon"
        Else
            greeting = "Good evening"
        End If

        ' Update the label text
        lblGreeting.Text = greeting

    End Sub
    Private Sub btnWallet_Click(sender As Object, e As EventArgs) Handles btnWallet.Click
        Dim form3Instance As New Form3(_userId)
        form3Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click
        btnBudget.FlatAppearance.BorderSize = 0
        Dim form5Instance As New Form5(_userId)
        form5Instance.Show()
        Me.Close()
    End Sub
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Dim form6Instance As New Form6(_userId)
        form6Instance.Show()
        Me.Close()
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        btnReports.FlatAppearance.BorderSize = 0
        Dim form7Instance As New Form7(_userId)
        form7Instance.Show()
        Me.Close()
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        btnHelp.FlatAppearance.BorderSize = 0
        Dim form8Instance As New Form8(_userId)
        form8Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

End Class
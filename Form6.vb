Imports System
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Form6

    Private _userId As Integer

    ' Constructor with userId parameter
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Dim sqlConn As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim sqlAdp As SqlDataAdapter

    Private selectedBudget As String = Nothing
    Private enteredAmount As Decimal = 0
    Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nzamb\OneDrive\Documents\jkuat\DICA\sem_project\ExpenseTrackerApplication2.0\ETrackerApp.mdf;Integrated Security=True"
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateBudgetsDropdown()
    End Sub
    Private Sub PopulateBudgetsDropdown()
        Try
            Using connection As New SqlConnection(connStr)
                connection.Open()
                Dim query As String = "SELECT id, bgt_name FROM Budget"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim budgetName As String = reader("bgt_name").ToString()
                            Dim budgetID As Integer = Convert.ToInt32(reader("id"))
                            Dim item As New ListItem(budgetName, budgetID)
                            cmbBudgets.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim selectedBudgetID As Integer = DirectCast(cmbBudgets.SelectedItem, ListItem).Value
        Dim amount As Decimal = Decimal.Parse(txtAmount.Text)

        ' Insert the transaction into the database
        Try
            Using connection As New SqlConnection(connStr)
                connection.Open()
                Dim query As String = "INSERT INTO Transactions (BudgetID, Amount) VALUES (@BudgetID,  @Amount)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@BudgetID", selectedBudgetID)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Transaction saved successfully!")
                    txtAmount.Text = String.Empty
                    cmbBudgets.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim form4Instance As New Form4(_userId)
        form4Instance.Show()
    End Sub

    Private Sub btnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click
        btnBudget.FlatAppearance.BorderSize = 0
        Dim form5Instance As New Form5(_userId)
        form5Instance.Show()
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        btnReports.FlatAppearance.BorderSize = 0
        Dim form7Instance As New Form7(_userId)
        form7Instance.Show()
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        btnHelp.FlatAppearance.BorderSize = 0
        Dim form8Instance As New Form8(_userId)
        form8Instance.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub
End Class
Public Class ListItem
    Public Property Text As String
    Public Property Value As Integer

    Public Sub New(text As String, value As Integer)
        Me.Text = text
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
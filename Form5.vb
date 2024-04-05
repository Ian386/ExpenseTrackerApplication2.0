Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Form5
    'connect to database
    Dim ConStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\ETrackerApp.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"
    Dim SqlConn As New SqlConnection(ConStr)
    'declare variables to be used within the whole project
    Private Shared _budgetAmount As Decimal
    Private Shared _timeRange As String
    Private Shared _startDate As Date
    Private Shared _endDate As Date
    Private Shared _BudgetName As String
    Dim WalletName As String
    'get the checked items from the checked list boxes in this form
    Dim CheckedBasics As New List(Of String)
    Dim CheckedEnjoy As New List(Of String)
    Dim CheckedHlthOther As New List(Of String)


    Public Shared Property BudgetAmount As Decimal
        Get
            Return _budgetAmount
        End Get
        Set(value As Decimal)
            _budgetAmount = value
        End Set
    End Property

    Public Shared Property TimeRange As String
        Get
            Return _timeRange
        End Get
        Set(value As String)
            _timeRange = value
        End Set
    End Property

    Public Shared Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Shared Property EndDate As Date
        Get
            Return _endDate
        End Get
        Set(value As Date)
            _endDate = value
        End Set
    End Property
    Public Shared Property BudgetName As String
        Get
            Return _BudgetName
        End Get
        Set(value As String)
            _BudgetName = value
        End Set
    End Property



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbStartDate.Visible = False
        lbEndDate.Visible = False
        txtStartDate.Visible = False
        txtEndDate.Visible = False

    End Sub

    Private Sub btnGoBackHome_Click(sender As Object, e As EventArgs) Handles btnGoBackHome.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub txtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        'convert to date

        If Date.TryParse(txtStartDate.Text, StartDate) Then
            StartDate = txtStartDate.Text
            StartDate = StartDate.ToString("yyyy-MM-dd")
        Else
            ' Invalid input, handle the error
            Console.WriteLine("Invalid Start Date. Please enter a valid date.")
            'set date to current date
            StartDate = Date.Today
        End If

    End Sub

    Private Sub txtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        'convert to date

        If Date.TryParse(txtEndDate.Text, EndDate) Then
            EndDate = txtEndDate.Text
            EndDate = EndDate.ToString("yyyy-MM-dd")
        Else
            ' Invalid input, handle the error
            Console.WriteLine("Invalid Start Date. Please enter a valid date.")
            'set date to null
            EndDate = Nothing
        End If


    End Sub

    Private Sub txtBudgetAmount_TextChanged(sender As Object, e As EventArgs) Handles txtBudgetAmount.TextChanged

        If Decimal.TryParse(txtBudgetAmount.Text, BudgetAmount) Then
            BudgetAmount = txtBudgetAmount.Text
        Else
            ' Invalid input, handle the error
            MsgBox("Invalid Budget Amount. Please enter a valid amount.")
        End If

    End Sub

    Private Sub txtEnterBudgetName_TextChanged(sender As Object, e As EventArgs) Handles txtEnterBudgetName.TextChanged
        'save the budget name
        BudgetName = txtEnterBudgetName.Text
    End Sub
    Public Function GetLastBudgetID() As Integer
        Dim lastBudgetID As Integer = -1 ' Default value if no record is found

        Try
            Using sqlConnection As New SqlConnection(ConStr)
                sqlConnection.Open()

                Dim query As String = "SELECT MAX(id) FROM budget"
                Dim command As New SqlCommand(query, sqlConnection)

                ' Execute the query and get the result (max budget ID)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    lastBudgetID = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions here
            Console.WriteLine("Error retrieving last budget ID: " & ex.Message)
        End Try

        Return lastBudgetID
    End Function
    Private Sub btnSaveNewBudget_Click(sender As Object, e As EventArgs) Handles btnSaveNewBudget.Click
        'save checked items to the list
        For Each item As Object In clbBasics.CheckedItems
            CheckedBasics.Add(item.ToString())
        Next
        For Each item As Object In clbEnjoyments.CheckedItems
            CheckedEnjoy.Add(item.ToString())
        Next
        For Each item As Object In clbHealthCare.CheckedItems
            CheckedHlthOther.Add(item.ToString())
        Next
        For Each item As Object In clbOtherExpenses.CheckedItems
            CheckedHlthOther.Add(item.ToString())
        Next
        'save wallet name to a variable
        WalletName = cbChooseWalllet.SelectedItem
        'save the budget amount
        BudgetAmount = txtBudgetAmount.Text
        'save the time range
        TimeRange = cbTimeRange.SelectedItem

        'save the budget name
        BudgetName = txtEnterBudgetName.Text
        Try
            Using SqlConn As New SqlConnection(ConStr)
                SqlConn.Open()

                Dim Addbudgetsql As String = "INSERT INTO budget (bgt_name, wallet_name, amount, time_range, start_date, end_date) VALUES (@BudgetName,@WalletName, @BudgetAmount, @TimeRange, @StartDate, @EndDate)"
                Dim cmd As New SqlCommand(Addbudgetsql, SqlConn)
                cmd.Parameters.AddWithValue("@BudgetName", BudgetName)
                cmd.Parameters.AddWithValue("@WalletName", WalletName)
                cmd.Parameters.AddWithValue("@BudgetAmount", BudgetAmount)
                cmd.Parameters.AddWithValue("@TimeRange", TimeRange)
                cmd.Parameters.AddWithValue("@StartDate", StartDate)
                cmd.Parameters.AddWithValue("@EndDate", EndDate)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Budget Added Successfully!")
                Else
                    MessageBox.Show("Budget Not Added!")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        ' Insert the checked items into the database
        Try
            'sql connection
            SqlConn.Open()

            Dim choosenBugdet_id As Integer = GetLastBudgetID()

            ' Insert items into clBasics table
            If CheckedBasics.Count > 0 Then
                For i As Integer = 0 To Math.Min(CheckedBasics.Count - 1, 2) ' Limit to 3 items or the number of checked items if less
                    Dim AddBasics As String = "INSERT INTO clBasics (bgt_id, item) VALUES (@bgt_id, @item)"
                    Dim cmd2 As New SqlCommand(AddBasics, SqlConn)
                    cmd2.Parameters.AddWithValue("@bgt_id", choosenBugdet_id)
                    cmd2.Parameters.AddWithValue("@item", CheckedBasics(i))
                    cmd2.ExecuteNonQuery()
                Next
            End If

            ' Insert items into enjoyment table
            If CheckedEnjoy.Count > 0 Then
                For i As Integer = 0 To Math.Min(CheckedEnjoy.Count - 1, 2)
                    Dim AddEnjoy As String = "INSERT INTO enjoyment (bgt_id, item) VALUES (@bgt_id,@item)"
                    Dim cmd3 As New SqlCommand(AddEnjoy, SqlConn)
                    cmd3.Parameters.AddWithValue("@bgt_id", choosenBugdet_id)
                    cmd3.Parameters.AddWithValue("@item", CheckedEnjoy(i))
                    cmd3.ExecuteNonQuery()
                Next
            End If

            ' Insert items into health_other table
            If CheckedHlthOther.Count > 0 Then
                For i As Integer = 0 To Math.Min(CheckedHlthOther.Count - 1, 3) ' Limit to 4 items or the number of checked items if less
                    Dim AddHlthOther As String = "INSERT INTO health_other (bgt_id, item) VALUES (@bgt_id,@item)"
                    Dim cmd4 As New SqlCommand(AddHlthOther, SqlConn)
                    cmd4.Parameters.AddWithValue("@bgt_id", choosenBugdet_id)
                    cmd4.Parameters.AddWithValue("@item", CheckedHlthOther(i))
                    cmd4.ExecuteNonQuery()
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If SqlConn.State = ConnectionState.Open Then
                SqlConn.Close()
            End If
        End Try
        'close the form and open the next form
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub cbTimeRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTimeRange.SelectedIndexChanged
        'show the start and end date text boxes if the user selects a custom time range
        If cbTimeRange.SelectedItem = "One time" Then
            lbStartDate.Visible = True
            lbEndDate.Visible = True
            txtStartDate.Visible = True
            txtEndDate.Visible = True
        Else
            lbStartDate.Visible = False
            lbEndDate.Visible = False
            txtStartDate.Visible = False
            txtEndDate.Visible = False
        End If
    End Sub

End Class
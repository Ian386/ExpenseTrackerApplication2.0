Imports Microsoft.Data.SqlClient

Public Class Form7

    Private _userId As Integer
    Private totalSpend As Decimal = 0

    Public Property UserId As Integer
        Get
            Return _userId
        End Get
        Set(value As Integer)
            _userId = value
        End Set
    End Property

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nzamb\OneDrive\Documents\jkuat\DICA\sem_project\ExpenseTrackerApplication2.0\ETrackerApp.mdf;Integrated Security=True"
    Private loggedInUserId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId ' Set _userId in the constructor
        loggedInUserId = userId
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WalletsExistForUser(loggedInUserId) Then
            pnlIndividualSummary.Visible = True
            pnlNoWalletsMessage.Visible = False
            btnRedirectToForm5.Visible = False
            PopulateWalletComboBox(loggedInUserId)
        Else
            pnlIndividualSummary.Visible = False
            pnlNoWalletsMessage.Visible = True
            btnRedirectToForm5.Visible = True
            cbWalletSelector.Visible = False
            Label6.Visible = False
        End If
    End Sub

    Private Function WalletsExistForUser(userId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM wallet WHERE User_id = @userId"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function

    Private Sub PopulateWalletComboBox(userId As Integer)
        Dim query As String = "SELECT name FROM wallet WHERE User_id = @userId"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", userId)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    cbWalletSelector.Items.Clear()
                    While reader.Read()
                        cbWalletSelector.Items.Add(reader("name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbWalletSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWalletSelector.SelectedIndexChanged
        If cbWalletSelector.SelectedItem IsNot Nothing Then
            lblWalletName.Text = cbWalletSelector.SelectedItem.ToString()
        Else
            lblWalletName.Text = ""
        End If
        Dim selectedWalletName As String = cbWalletSelector.SelectedItem.ToString()

        Dim query As String = "SELECT bgt_name FROM budget WHERE wallet_name = @walletName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@walletName", selectedWalletName)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    cbBudgetSelector.Items.Clear()
                    While reader.Read()
                        cbBudgetSelector.Items.Add(reader("bgt_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbBudgetSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBudgetSelector.SelectedIndexChanged

        Dim selectedBudgetName As String = cbBudgetSelector.SelectedItem.ToString()

        Dim budgetAmount As Decimal = 0
        Dim budgetId As Integer = -1

        ' Fetch the budget amount for the selected budget
        Dim budgetQuery As String = "SELECT id, amount FROM budget WHERE bgt_name = @budgetName"

        Using connection As New SqlConnection(connectionString)
            Using budgetCommand As New SqlCommand(budgetQuery, connection)
                budgetCommand.Parameters.AddWithValue("@budgetName", selectedBudgetName)

                connection.Open()
                Using reader As SqlDataReader = budgetCommand.ExecuteReader()
                    If reader.Read() Then
                        budgetId = Convert.ToInt32(reader("id"))
                        budgetAmount = Convert.ToDecimal(reader("amount"))
                        tbxAmount.Text = budgetAmount.ToString()
                    Else
                        tbxAmount.Text = ""
                    End If
                End Using
            End Using
        End Using

        If budgetId <> -1 Then
            totalSpend = 0 ' Reset totalSpend

            Dim basicsQuery As String = "SELECT SUM(spend) FROM clBasics WHERE bgt_id = @budgetId"
            Dim enjoymentQuery As String = "SELECT SUM(spend) FROM enjoyment WHERE bgt_id = @budgetId"
            Dim healthOtherQuery As String = "SELECT SUM(spend) FROM health_other WHERE bgt_id = @budgetId"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(basicsQuery, connection)
                    command.Parameters.AddWithValue("@budgetId", budgetId)
                    Dim basicsSpend As Object = command.ExecuteScalar()
                    totalSpend += If(basicsSpend IsNot DBNull.Value, Convert.ToDecimal(basicsSpend), 0)
                End Using

                Using command As New SqlCommand(enjoymentQuery, connection)
                    command.Parameters.AddWithValue("@budgetId", budgetId)
                    Dim enjoymentSpend As Object = command.ExecuteScalar()
                    totalSpend += If(enjoymentSpend IsNot DBNull.Value, Convert.ToDecimal(enjoymentSpend), 0)
                End Using

                Using command As New SqlCommand(healthOtherQuery, connection)
                    command.Parameters.AddWithValue("@budgetId", budgetId)
                    Dim healthOtherSpend As Object = command.ExecuteScalar()
                    totalSpend += If(healthOtherSpend IsNot DBNull.Value, Convert.ToDecimal(healthOtherSpend), 0)
                End Using
            End Using

            ' Display the spent amount in tbxSpent
            tbxSpent.Text = totalSpend.ToString()

            ' Calculate the balance
            Dim balance As Decimal = budgetAmount - totalSpend

            ' Display the balance in tbxBalance
            tbxBalance.Text = balance.ToString()
        Else
            tbxSpent.Text = ""
            tbxBalance.Text = ""
        End If

        UpdateProgressBar() ' Call UpdateProgressBar after updating totalSpend

        ' Check if totalSpend is greater than or equal to 90% of budgetAmount
        If totalSpend >= 0.9 * budgetAmount Then
            MessageBox.Show("You have reached 90% of your budget. Spend wisely.")
        End If

        ' Check if totalSpend equals budgetAmount
        If totalSpend = budgetAmount Then
            MessageBox.Show("You have exhausted your budgeted amount.")
        End If

        ' Check if totalSpend exceeds budgetAmount
        If totalSpend > budgetAmount Then
            MessageBox.Show("You have exceeded your budget.")
        End If

    End Sub

    Private Sub UpdateProgressBar()
        Dim budgetAmount As Decimal = Decimal.Parse(tbxAmount.Text) ' Fetch budget amount from tbxAmount

        If totalSpend <= budgetAmount Then
            ' Calculate the percentage of the budget spent
            Dim percentage As Integer = CInt((totalSpend / budgetAmount) * 100)
            ' Update progress bar value
            pbExpenses.Value = percentage
        Else
            ' If totalSpend exceeds budgetAmount, set progress bar to maximum
            pbExpenses.Value = pbExpenses.Maximum
        End If
    End Sub

    Private Sub btnRedirectToForm5_Click(sender As Object, e As EventArgs) Handles btnRedirectToForm5.Click
        Dim form4Instance As New Form4(_userId)
        form4Instance.Show()
    End Sub

    Private Sub btnGoBackHome_Click(sender As Object, e As EventArgs)
        Close()
        Dim form5Instance As New Form5(_userId)
        form5Instance.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim form4Instance As New Form4(_userId)
        form4Instance.Show()
        Me.Close()
    End Sub
    Private Sub btnWallets_Click(sender As Object, e As EventArgs) Handles btnWallets.Click
        Dim form3Instance As New Form3(_userId)
        form3Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim form8Instance As New Form8(_userId)
        form8Instance.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

End Class

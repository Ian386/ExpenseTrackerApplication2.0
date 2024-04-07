Imports System
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Form3

    Private _userId As Integer

    ' Constructor with userId parameter
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Dim sqlConn As SqlConnection
    Dim sqlCmd As SqlCommand
    Dim sqlAdp As SqlDataAdapter


    Private enteredName As String = Nothing
    Private selectedCurrency As String = Nothing
    Private enteredAmount As Decimal = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nzamb\OneDrive\Documents\jkuat\DICA\sem_project\ExpenseTrackerApplication2.0\ETrackerApp.mdf;Integrated Security=True"

        sqlConn = New SqlConnection(connStr)
        sqlConn.Open()
        ' Populate ComboBox with currency options
        ComboBoxCurrency.Items.AddRange({"USD", "CAD", "EUR", "AED", "AUD", "CNY", "CZK", "DJF", "EGP", "GBP", "HKD", "KES", "JPY", "SOS", "SEK", "TZC", "UGX", "UYU", "UZS", "VND", "XAF", "ZAR"})
        ' Set default selected item if needed
        ComboBoxCurrency.SelectedIndex = 0
    End Sub
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using sqlConn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\ETrackerApp.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")
            Try
                ' Open the connection
                sqlConn.Open()
                Dim query As String = "INSERT INTO wallet (name, amount, UserID) VALUES (@Name, @Amount, @UserID)"
                Using sqlCmd As New SqlCommand(query, sqlConn)
                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text)
                    sqlCmd.Parameters.AddWithValue("@Amount", Decimal.Parse(txtAmount.Text))
                    sqlCmd.Parameters.AddWithValue("@UserID", 1)
                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Wallet information added successfully.")
                    Else
                        MessageBox.Show("Failed to add wallet information.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        ' Get the entered name
        enteredName = txtName.Text

        ' Get the selected currency
        If ComboBoxCurrency.SelectedItem IsNot Nothing Then
            selectedCurrency = ComboBoxCurrency.SelectedItem.ToString()
        Else
            ' No currency selected
            MessageBox.Show("Please select a currency.")
            Return
        End If

        ' Get the entered amount
        If Decimal.TryParse(txtAmount.Text, enteredAmount) Then
            ' Valid amount entered
            ' Set the currency symbol based on the selected currency
            Dim currencySymbol As String
            Select Case selectedCurrency
                Case "USD"
                    currencySymbol = "$"
                Case "CAD"
                    currencySymbol = "CA$"
                Case "EUR"
                    currencySymbol = "€"
                Case "AED"
                    currencySymbol = "د.إ" ' United Arab Emirates Dirham
                Case "AUD"
                    currencySymbol = "A$"
                Case "CNY"
                    currencySymbol = "¥"
                Case "CZK"
                    currencySymbol = "Kč"
                Case "DJF"
                    currencySymbol = "Fdj"
                Case "EGP"
                    currencySymbol = "E£"
                Case "GBP"
                    currencySymbol = "£"
                Case "HKD"
                    currencySymbol = "HK$"
                Case "JPY"
                    currencySymbol = "¥"
                Case "KES"
                    currencySymbol = "Ksh"
                Case "SOS"
                    currencySymbol = "Ssh"
                Case "SEK"
                    currencySymbol = "kr"
                Case "TZC"
                    currencySymbol = "TSh"
                Case "UGX"
                    currencySymbol = "USh"
                Case "UYU"
                    currencySymbol = "$U"
                Case "UZS"
                    currencySymbol = "soʻm"
                Case "VND"
                    currencySymbol = "₫"
                Case "XAF"
                    currencySymbol = "FCFA"
                Case "ZAR"
                    currencySymbol = "R"
                Case Else
                    currencySymbol = selectedCurrency & " " ' Default to currency code for unknown currencies
            End Select

            ' Display the entered information
            MessageBox.Show("Name: " & enteredName & vbCrLf &
                        "Currency: " & selectedCurrency & vbCrLf &
                        "Amount: " & currencySymbol & enteredAmount.ToString())
            ' You can save the data to a database or perform further processing here
        Else
            ' Invalid amount entered
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    'To update wallet details
    Private Sub UpdateWallet(ByVal walletId As Integer, ByVal newName As String, ByVal newAmount As Decimal)
        Using sqlConn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Data Directory|EtrackerApp.mdf;Integrated Security=True;")
            Try
                sqlConn.Open()

                Dim query As String = "UPDATE wallet SET name = @NewName, amount = @NewAmount WHERE wallet_id = @WalletId"

                Using sqlCmd As New SqlCommand(query, sqlConn)
                    sqlCmd.Parameters.AddWithValue("@NewName", newName)
                    sqlCmd.Parameters.AddWithValue("@NewAmount", newAmount)
                    sqlCmd.Parameters.AddWithValue("@WalletId", walletId)

                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Wallet information updated successfully.")
                    Else
                        MessageBox.Show("Failed to update wallet information.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    'Run code UpdateWallet(walletId, newName, newAmount)


    'To add a wallet
    Private Sub AddWallet(ByVal name As String, ByVal amount As Decimal, ByVal ownerId As Integer)
        ' Define the connection string
        Dim connectionString As String = "Data Source=YourServer;Initial Catalog=EtrackerApp;Integrated Security=True"

        ' Define the SQL query to insert data into the wallet table
        Dim query As String = "INSERT INTO wallet (name, amount, owner_id) VALUES (@Name, @Amount, @OwnerId)"

        ' Create a new SqlConnection object using the connection string
        Using sqlConn As New SqlConnection(connectionString)
            Try
                ' Open the connection
                sqlConn.Open()

                ' Create a new SqlCommand object with the SQL query and SqlConnection
                Using sqlCmd As New SqlCommand(query, sqlConn)
                    ' Add parameters to the SQL query
                    sqlCmd.Parameters.AddWithValue("@Name", name)
                    sqlCmd.Parameters.AddWithValue("@Amount", amount)
                    sqlCmd.Parameters.AddWithValue("@user_id", ownerId)

                    ' Execute the SQL query
                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                    ' Check if the query was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Wallet added successfully.")
                    Else
                        MessageBox.Show("Failed to add wallet.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    ' run code AddWallet("My Wallet", 100.0, 1)



    'To delete wallet
    Private Sub DeleteWallet(ByVal walletId As Integer)
        Using sqlConn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Data Directory|EtrackerApp.mdf;Integrated Security=True;")
            Try
                sqlConn.Open()

                Dim query As String = "DELETE FROM wallet WHERE wallet_id = @WalletId"

                Using sqlCmd As New SqlCommand(query, sqlConn)
                    sqlCmd.Parameters.AddWithValue("@WalletId", walletId)

                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Wallet information deleted successfully.")
                    Else
                        MessageBox.Show("Failed to delete wallet information.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    'run DeleteWallet(walletId)

    'Querying Data
    Private Sub LoadWalletData()
        Using sqlConn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Data Directory|EtrackerApp.mdf;Integrated Security=True;")
            Try
                sqlConn.Open()

                Dim query As String = "SELECT * FROM wallet"

                Using sqlCmd As New SqlCommand(query, sqlConn)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader()
                        While reader.Read()
                            Dim walletId As Integer = Convert.ToInt32(reader("wallet_id"))
                            Dim name As String = reader("name").ToString()
                            Dim amount As Decimal = Convert.ToDecimal(reader("amount"))

                            ' Process the retrieved data (e.g., display in a DataGridView)
                            ' For example:
                            ' dataGridView.Rows.Add(walletId, name, amount)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    'run LoadWalletData()
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        sqlConn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim form4Instance As New Form7(_userId)
        form4Instance.Show()

        Me.Close()
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
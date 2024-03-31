Public Class Form3
    Private enteredName As String = Nothing
    Private selectedCurrency As String = Nothing
    Private enteredAmount As Decimal = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with currency options
        ComboBoxCurrency.Items.AddRange({"USD", "CAD", "EUR", "AED", "AUD", "CNY", "CZK", "DJF", "EGP", "GBP", "HKD", "KES", "JPY", "SOS", "SEK", "TZC", "UGX", "UYU", "UZS", "VND", "XAF", "ZAR"})
        ' Set default selected item if needed
        ComboBoxCurrency.SelectedIndex = 0
    End Sub
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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


    Private Sub bthHome_Click(sender As Object, e As EventArgs) Handles bthHome.Click
        ' Close the current form (Form3) and show the home form (Form1)
        Form4.Show()
        Me.Close()
    End Sub
End Class


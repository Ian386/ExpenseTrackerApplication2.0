Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form8

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\\sqlserVER\\E-Tracker database\\ETrackerApp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True"


    'Not done but works
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim currentUsername As String = "username"


        Dim firstName As String = ""
        Dim lastName As String = ""

        ' Using connection As New SqlConnection(connectionString)
        'Dim query As String = "Select firstname, lastname FROM user_table WHERE email = @Username"
        'Using command As New SqlCommand(query, connection)
        ' Command.Parameters.AddWithValue("@Username", currentUsername)
        'connection.Open()
        'Using reader As SqlDataReader = command.ExecuteReader()
        'If reader.Read() Then
        'firstName = Convert.ToString(reader("firstname"))
        'lastName = Convert.ToString(reader("lastname"))
        'End If'
        'End Using
        'End Using
        'End Using


        txtDisplayName.Text = $"{firstName} {lastName}"
    End Sub

    Private Sub btnChangeProfilePhoto_Click(sender As Object, e As EventArgs) Handles btnChangeProfilePhoto.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (.jpg;.jpeg;.png;.gif;.bmp)|.jpg;.jpeg;.png;.gif;.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim selectedFilePath As String = openFileDialog.FileName


                Dim originalImage As New Bitmap(selectedFilePath)


                Dim resizedImage As Bitmap = ResizeImage(originalImage, ProfilePicture.Width, ProfilePicture.Height)


                ProfilePicture.Image = resizedImage
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function ResizeImage(image As Image, width As Integer, height As Integer) As Bitmap
        Dim resizedImage As New Bitmap(width, height)

        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, width, height)
        End Using

        Return resizedImage
    End Function

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim username As String = txtUserName1.Text
        Dim currentPassword As String = txtCurrentPassword.Text


        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT password FROM user_table WHERE username = @Username"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()
                Dim storedPassword As String = Convert.ToString(command.ExecuteScalar())
                If String.IsNullOrEmpty(storedPassword) Then
                    MessageBox.Show("Username not found.")
                    txtUserName1.Clear()
                    txtCurrentPassword.Clear()
                    txtNewPassword.Clear()
                    txtConfirmPassword.Clear()
                    Return
                ElseIf storedPassword <> currentPassword Then
                    MessageBox.Show("Incorrect password entered.")
                    txtCurrentPassword.Clear()
                    txtNewPassword.Clear()
                    txtConfirmPassword.Clear()
                    Return
                End If
            End Using
        End Using

        Dim passwordPattern As String = "^(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%?&]{8,}$"
        If Not Regex.IsMatch(txtNewPassword.Text, passwordPattern) Then
            MessageBox.Show("Password must contain:" & vbCrLf &
                        "- At least one uppercase letter" & vbCrLf &
                        "- A special character" & vbCrLf &
                        "- One number" & vbCrLf &
                        "- At least 8 characters",
                        "Password Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            Return
        End If


        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Entered passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            Return
        End If


        Using connection As New SqlConnection(connectionString)
            Dim updateQuery As String = "UPDATE user_table SET password = @NewPassword WHERE username = @Username"
            Using command As New SqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using


        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim form4Instance As New Form4()
        form4Instance.Show()
        Me.Close()
    End Sub
    Private Sub btnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click

        Dim form5Instance As New Form5()
        form5Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        Dim form7Instance As New Form7()
        form7Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnEditWallets_Click(sender As Object, e As EventArgs) Handles btnEditWallets.Click
        Dim form3Instance As New Form3()
        form3Instance.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim form4Instance As New Form4()
        form4Instance.Show()
        Me.Close()
    End Sub


    Private Sub btnSubmitProfile_Click(sender As Object, e As EventArgs) Handles btnSubmitProfile.Click
        Dim currentUsername As String = txtUser.Text
        Dim password As String = txtPass.Text
        Dim newUsername As String = txtName.Text
        Dim newFirstName As String = txtFirstName.Text
        Dim newLastName As String = txtLastName.Text
        Dim newEmailAddress As String = txtEmailAddress.Text

        If Not ValidateUser(currentUsername, password) Then
            MessageBox.Show("Invalid Username or Incorrect Password.")
            txtName.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmailAddress.Clear()
            txtUser.Clear()
            txtPass.Clear()
            Return
        End If

        If UsernameExists(newUsername) Then
            MessageBox.Show("Username is already in use.")
            txtName.Clear()
            txtUser.Clear()
            txtPass.Clear()
            Return
        End If

        If EmailAddressExists(newEmailAddress) Then
            MessageBox.Show("Email address is already in use.")
            txtEmailAddress.Clear()
            txtUser.Clear()
            txtPass.Clear()
            Return
        End If

        If UpdateUserProfile(currentUsername, newUsername, newFirstName, newLastName, newEmailAddress) Then
            MessageBox.Show("Profile updated successfully.")
        Else
            MessageBox.Show("Failed to update profile. Please try again.")
        End If
    End Sub

    Private Function EmailAddressExists(emailAddress As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM user_table WHERE email = @Email"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", emailAddress)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function ValidateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM user_table WHERE username = @Username AND password = @Password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function UsernameExists(username As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM user_table WHERE username = @Username"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function UpdateUserProfile(currentUsername As String, newUsername As String, newFirstName As String, newLastName As String, newEmailAddress As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE user_table SET "
            Dim setClause As New List(Of String)()

            If Not String.IsNullOrEmpty(newUsername) Then
                setClause.Add("username = @NewUsername")
            End If
            If Not String.IsNullOrEmpty(newFirstName) Then
                setClause.Add("firstname = @NewFirstName")
            End If
            If Not String.IsNullOrEmpty(newLastName) Then
                setClause.Add("lastname = @NewLastName")
            End If
            If Not String.IsNullOrEmpty(newEmailAddress) Then
                setClause.Add("email = @NewEmailAddress")
            End If

            query &= String.Join(", ", setClause)

            query &= " WHERE username = @CurrentUsername"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CurrentUsername", currentUsername)
                If Not String.IsNullOrEmpty(newUsername) Then
                    command.Parameters.AddWithValue("@NewUsername", newUsername)
                End If
                If Not String.IsNullOrEmpty(newFirstName) Then
                    command.Parameters.AddWithValue("@NewFirstName", newFirstName)
                End If
                If Not String.IsNullOrEmpty(newLastName) Then
                    command.Parameters.AddWithValue("@NewLastName", newLastName)
                End If
                If Not String.IsNullOrEmpty(newEmailAddress) Then
                    command.Parameters.AddWithValue("@NewEmailAddress", newEmailAddress)
                End If

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Sub TogglePasswordVisibility(txtBox As TextBox, btn As Button)
        ' Toggle the PasswordChar property of the textbox
        If txtBox.PasswordChar = "*"c Then
            txtBox.PasswordChar = ControlChars.NullChar ' Show password text
            btn.Text = "Hide"
        Else
            txtBox.PasswordChar = "*"c ' Hide password text
            btn.Text = "Show"
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        TogglePasswordVisibility(txtPass, btnShow)
    End Sub

    Private Sub btnSee_Click(sender As Object, e As EventArgs) Handles btnSee.Click
        TogglePasswordVisibility(txtCurrentPassword, btnSee)
    End Sub

    Private Sub btnS2_Click(sender As Object, e As EventArgs) Handles btnS1.Click
        TogglePasswordVisibility(txtNewPassword, btnS1)
    End Sub

    Private Sub btnS3_Click(sender As Object, e As EventArgs) Handles btnS1.Click
        TogglePasswordVisibility(txtConfirmPassword, btnS3)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class
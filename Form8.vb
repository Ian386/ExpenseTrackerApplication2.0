Imports System.Text.RegularExpressions

Public Class Form8
    Private Sub btnChangeProfile_Click(sender As Object, e As EventArgs) Handles btnChangeProfile.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim selectedFilePath As String = openFileDialog.FileName

                ' Load the selected image
                Dim originalImage As New Bitmap(selectedFilePath)

                ' Resize the image to fit the PictureBox
                Dim resizedImage As Bitmap = ResizeImage(originalImage, ProfilePicture.Width, ProfilePicture.Height)

                ' Display the resized image in the PictureBox
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
        ' Check if the new password meets the criteria
        Dim passwordPattern As String = "^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
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

        Dim form6Instance As New Form6()
        form6Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnEditWallets_Click(sender As Object, e As EventArgs) Handles btnEditWallets.Click
        Dim form3Instance As New Form3()
        form3Instance.Show()
        Me.Close()
    End Sub
End Class
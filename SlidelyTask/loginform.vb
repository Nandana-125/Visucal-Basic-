Public Class loginform
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Lo        If textUsername.Text = "admin" And textPassword.Text = "admin" Then
            success.ShowDialog()
        ElseIf textUsername.Text = "" Or textPassword.Text = "" Then
        information.ShowDialog()
        textUsername.Text = ""
        textPassword.Text = ""
        textUsername.Focus()

        ElseIf IsNumeric(textUsername.Text) = True Or IsNumeric(textPassword.Text) = True Then
        warning.ShowDialog()
        textUsername.Text = ""
        textPassword.Text = ""
        textUsername.Focus()
        Else
        critical.ShowDialog()
        textUsername.Text = ""
        textPassword.Text = ""
        textUsername.Focus()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender, e) Handles btnLogin.Click, btnLogin.Click, btnLogin.Click, btnLogin.Click, btnLogin.Click

    End Sub

    Private Sub btnExit_Click(sender, e)

    End Sub

    Private Sub btnLogin_Click(sender, e)

    End Sub

    Private Sub btnLogin_Click(sender, e)

    End Sub

    Private Sub btnLogin_Click(sender, e)

    End Sub

    Private Sub btnLogin_Click(sender, e)

    End Sub
End Class

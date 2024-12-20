Imports System.Windows.Forms

Public Class Form1

    Private WithEvents txtUsername As New TextBox()
    Private WithEvents txtPassword As New TextBox()
    Private WithEvents btnRegister As New Button()
    Private WithEvents btnLogin As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Форма регистрации и входа"
        Me.Size = New Size(300, 250)


        Dim lblUsername As New Label()
        lblUsername.Text = "Имя пользователя:"
        lblUsername.Location = New Point(10, 20)

        txtUsername.Location = New Point(150, 20)
        txtUsername.Width = 120

        Dim lblPassword As New Label()
        lblPassword.Text = "Пароль:"
        lblPassword.Location = New Point(10, 60)

        txtPassword.Location = New Point(150, 60)
        txtPassword.Width = 120
        txtPassword.UseSystemPasswordChar = True

        btnRegister.Text = "Зарегистрироваться"
        btnRegister.Location = New Point(10, 100)
        btnRegister.Width = Me.ClientSize.Width - 20

        btnLogin.Text = "Войти"
        btnLogin.Location = New Point(10, 140)
        btnLogin.Width = Me.ClientSize.Width - 20


        Me.Controls.Add(lblUsername)
        Me.Controls.Add(txtUsername)
        Me.Controls.Add(lblPassword)
        Me.Controls.Add(txtPassword)
        Me.Controls.Add(btnRegister)
        Me.Controls.Add(btnLogin)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim profileForm As New ProfileForm(username)
            profileForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim profileForm As New ProfileForm(username)
            profileForm.Show()
            Me.Hide()
        End If
    End Sub
End Class


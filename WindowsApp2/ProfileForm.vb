Imports System.Windows.Forms
Imports System.Drawing

Public Class ProfileForm
    Inherits Form

    Private lblUsername As Label
    Private lblUserId As Label
    Private picProfile As PictureBox
    Private btnUpload As Button
    Private random As Random


    Public Sub New(username As String)
        InitializeComponent()


        Me.Text = "Профиль"
        Me.Size = New Size(400, 300)
        Me.BackColor = Color.White


        lblUsername = New Label()
        lblUserId = New Label()
        picProfile = New PictureBox()
        btnUpload = New Button()
        random = New Random()


        picProfile.Location = New Point(10, 10)
        picProfile.Size = New Size(100, 100)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.BorderStyle = BorderStyle.FixedSingle


        lblUsername.Text = "Никнейм: " & username
        lblUsername.Location = New Point(120, 20)
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 14, FontStyle.Bold)

        Dim userId As Integer = random.Next(1000, 9999)
        lblUserId.Text = "ID: " & userId.ToString()
        lblUserId.Location = New Point(120, 60)
        lblUserId.AutoSize = True
        lblUserId.Font = New Font("Arial", 12, FontStyle.Regular)


        btnUpload.Text = "Загрузить изображение"
        btnUpload.Location = New Point(10, 120)
        btnUpload.Size = New Size(150, 30)
        btnUpload.BackColor = Color.LightBlue
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Font = New Font("Arial", 10, FontStyle.Regular)
        AddHandler btnUpload.Click, AddressOf BtnUpload_Click

        Me.Controls.Add(lblUsername)
        Me.Controls.Add(lblUserId)
        Me.Controls.Add(picProfile)
        Me.Controls.Add(btnUpload)
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs)
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            openFileDialog.Title = "Выберите изображение профиля"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    picProfile.Image = Image.FromFile(openFileDialog.FileName)
                Catch ex As Exception
                    MessageBox.Show("Ошибка при загрузке изображения: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class


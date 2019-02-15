Imports MySql.Data.MySqlClient
Public Class RegisterNew
    Private sqlconnect As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim Username As String = txtUsername.Text
        Dim Password As String = txtPassword.Text
        Dim Phone As Integer
        Dim Birth As Date = dtpBirth.Text
        Dim Address As String = txtAddress.Text
        Dim Name As String = txtName.Text

        Dim Email As String = txtEmail.Text
        Dim ArrayStringCheck1() As String = {Username, Password, Address, Name, Email}
        Dim ArrayStringCheck2() As String = {Username, Password, Address, Name, Email}
        For i = 0 To ArrayStringCheck1.Length - 1
            If ArrayStringCheck1(i).ToString.Length <= 0 Then
                MessageBox.Show("You must fill everything")
                Exit Sub
            End If
        Next

        For i = 0 To ArrayStringCheck2.Length - 1
            If ArrayStringCheck2(i).ToString.Length > 20 Then
                MessageBox.Show("Username/Password/Address/Name/Email Character limit is 20")
                Exit Sub
            End If
        Next

        If Not Integer.TryParse(txtPhone.Text, Phone) Then
            MessageBox.Show("Phone must be 8 numbers")
            Exit Sub
        End If
        If Not Phone.ToString.Length = 8 Then
            MessageBox.Show("Your phone number must be 8 numbers")
            Exit Sub
        End If
        If Not ekteEpost(txtEmail.Text) Then
            MessageBox.Show("Email address is not valid.")
            Exit Sub
        End If

        If Not IsNumeric(txtPassword.Text) Then
            MessageBox.Show("Password must be number.")
            Exit Sub
        End If

        Using sqlconnect = New MySqlConnection(sqlconnectionstring)
            sqlconnect.Open()
            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM Learner WHERE Username=@Username", sqlconnect)
            sqlcommand.Parameters.AddWithValue("@Username", Username)
            If sqlcommand.ExecuteScalar = 1 Then
                MessageBox.Show("This username already exists")
                Exit Sub
            End If
            sqlcommand = New MySqlCommand("INSERT INTO Learner VALUES(NULL,'Learner',@Username,@Name,@Email,@Phone,@DateOfBirth,@Address,@Passwords,'No');", sqlconnect)
            sqlcommand.Parameters.AddWithValue("@Username", Username)
            sqlcommand.Parameters.AddWithValue("@Passwords", Password)
            sqlcommand.Parameters.AddWithValue("@Name", Name)
            sqlcommand.Parameters.AddWithValue("@Email", Email)
            sqlcommand.Parameters.AddWithValue("@Address", Address)
            sqlcommand.Parameters.AddWithValue("@Phone", Phone)
            sqlcommand.Parameters.AddWithValue("@DateOfBirth", Birth)
            sqlcommand.ExecuteNonQuery()
        End Using
        MessageBox.Show("New User Is Registered. ")
        btnClear.PerformClick()
    End Sub

    Private Sub RegisterNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear all text
        txtName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub
End Class
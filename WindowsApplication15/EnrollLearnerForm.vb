Imports MySql.Data.MySqlClient

Public Class EnrollLearnerForm
    Private sqlconnect As MySqlConnection
    Private Sqlcommand As MySqlCommand
    Private tblLearnerCourses As New DataTable
    Private tblLearner As New DataTable
    Private sqladapter As MySqlDataAdapter
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim FirstName As String = txtFirstName.Text
        Dim Phone As String = txtPhone.Text
        Dim ArrayStringcheck() As String = {FirstName, Phone}

        For i = 0 To ArrayStringcheck.Length - 1
            If ArrayStringcheck(i).Length <= 0 Then
                MessageBox.Show("You must fill all the boxes before searching")
                Exit Sub
            End If
        Next
        Using sqlconnect = New MySqlConnection(sqlconnectionstring)
            sqlconnect.Open()
            Sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM Learner WHERE Name='" & FirstName & "' AND Phone = '" & Phone & "' AND Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')", sqlconnect)
            If Sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("Sorry but this person is not in the database")
                Exit Sub
            End If
        End Using

        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()

        Sqlcommand = New MySqlCommand
        tblLearner = New DataTable("Learner")
        Sqlcommand.Connection = sqlconnect
        Sqlcommand.CommandText = " SELECT Learner.LearnerID,Name,Phone,Enrolled FROM Learner WHERE Name='" & FirstName & "' AND Phone = '" & Phone & "' AND Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')"
        sqladapter = New MySqlDataAdapter(Sqlcommand)
        sqladapter.Fill(tblLearner)
        LearnerGrid.DataSource = tblLearner


    End Sub

    Private Sub EnrollLearnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()
        Sqlcommand = New MySqlCommand
        tblLearner = New DataTable("Learner")
        Sqlcommand.Connection = sqlconnect
        Sqlcommand.CommandText = "SELECT LearnerID,Name,Phone,Enrolled FROM Learner WHERE Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')"
        sqladapter = New MySqlDataAdapter(Sqlcommand)
        sqladapter.Fill(tblLearner)
        LearnerGrid.DataSource = tblLearner
    End Sub

    Private Sub btnEnrollByGrid_Click(sender As Object, e As EventArgs) Handles btnEnrollByGrid.Click

        Dim query As String = LearnerGrid.CurrentRow.Cells(0).Value.ToString
        Dim Enrolled As String = LearnerGrid.CurrentRow.Cells(3).Value.ToString

        If Enrolled = "Yes" Then
            MessageBox.Show("This person is already enrolled")
            Exit Sub
        End If

        Using sqlconnect = New MySqlConnection(sqlconnectionstring)

            sqlconnect.Open()

            Sqlcommand = New MySqlCommand("UPDATE Learner SET Enrolled=@Enrolled WHERE LearnerID=@LearnerID", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.Parameters.AddWithValue("@Enrolled", "Yes")
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'1','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'2','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'3','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'4','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'5','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'6','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'7','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            tblLearner = New DataTable("Learner")
            Sqlcommand.CommandText = "SELECT LearnerID,Name,Phone,Enrolled FROM Learner WHERE Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')"
            sqladapter = New MySqlDataAdapter(Sqlcommand)
            sqladapter.Fill(tblLearner)
            LearnerGrid.DataSource = tblLearner
        End Using
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim query As String = LearnerGrid.CurrentRow.Cells(0).Value.ToString
        Dim Enrolled As String = LearnerGrid.CurrentRow.Cells(3).Value.ToString
        Dim FirstName As String = txtFirstName.Text
        Dim Phone As String = txtPhone.Text

        If FirstName.Length <= 0 Or Phone.Length <= 0 Then
            MessageBox.Show("You must search for a specific learner before you can enroll him/Her")
            Exit Sub
        End If

        If Enrolled = "Yes" Then
            MessageBox.Show("This person is already enrolled")
            Exit Sub
        End If

        Using sqlconnect = New MySqlConnection(sqlconnectionstring)

            sqlconnect.Open()

            tblLearner = New DataTable("Learner")
            Sqlcommand = New MySqlCommand("UPDATE Learner SET Enrolled=@Enrolled WHERE LearnerID=@LearnerID", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.Parameters.AddWithValue("@Enrolled", "Yes")
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'1','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'2','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'3','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'4','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'5','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'6','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            Sqlcommand = New MySqlCommand("INSERT INTO LearnerCourses VALUES(@LearnerID,'7','Not Done',0,0)", sqlconnect)
            Sqlcommand.Parameters.AddWithValue("@LearnerID", query)
            Sqlcommand.ExecuteNonQuery()

            tblLearner = New DataTable("Learner")

            Sqlcommand.CommandText = "SELECT LearnerID,Name,Phone,Enrolled FROM Learner WHERE Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')"
            sqladapter = New MySqlDataAdapter(Sqlcommand)
            sqladapter.Fill(tblLearner)
            LearnerGrid.DataSource = tblLearner
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefreshGrid.Click

        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()

        Sqlcommand = New MySqlCommand
        tblLearner = New DataTable("Learner")
        Sqlcommand.Connection = sqlconnect

        Sqlcommand.CommandText = "SELECT LearnerID,Name,Phone,Enrolled FROM Learner WHERE Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')"
        sqladapter = New MySqlDataAdapter(Sqlcommand)
        sqladapter.Fill(tblLearner)
        LearnerGrid.DataSource = tblLearner
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        AdminForm.Show()
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstName.Clear()
        txtPhone.Clear()
        LearnerGrid.DataSource = Nothing
        LearnerGrid.Rows.Clear()
        LearnerGrid.Refresh()
    End Sub
End Class
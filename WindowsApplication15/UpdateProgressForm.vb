Imports MySql.Data.MySqlClient

Public Class UpdateProgressForm
    Private sqlconnect As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private tblLearnerCourses As New DataTable
    Private sqladapter As MySqlDataAdapter
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"

    Private Sub UpdateProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()
        sqlcommand = New MySqlCommand
        tblLearnerCourses = New DataTable("LearnerCourses")

        sqlcommand.Connection = sqlconnect
        sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID GROUP BY Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid"

        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(tblLearnerCourses)
        ProgressGrid.DataSource = tblLearnerCourses
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim FirstName As String = txtFirstname.Text
        Dim CourseName As String = txtCourseName.Text
        Dim ArrayStringcheck() As String = {FirstName, CourseName}

        For i = 0 To ArrayStringcheck.Length - 1
            If ArrayStringcheck(i).Length <= 0 Then
                MessageBox.Show("You must fill all the boxes before searching")
                Exit Sub
            End If
        Next
        Using sqlconnect = New MySqlConnection(sqlconnectionstring)
            sqlconnect.Open()
            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID AND Name='" & FirstName & " ' AND CourseName='" & CourseName & "' GROUP BY Name,CourseName,Status,UnitTaken,AmountPaid", sqlconnect)

            If sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("I'm sorry,but this is not in our database")
                Exit Sub
            End If
        End Using

        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()
        sqlcommand = New MySqlCommand
        tblLearnerCourses = New DataTable("LearnerCourses")

        sqlcommand.Connection = sqlconnect
        sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID AND Name='" & FirstName & " ' AND CourseName='" & CourseName & "' GROUP BY Name,CourseName,Status,UnitTaken,AmountPaid"

        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(tblLearnerCourses)
        ProgressGrid.DataSource = tblLearnerCourses
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        AdminForm.Show()
        btnClear.PerformClick()
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click

        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM Learner WHERE LearnerID= @LearnerID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)

            If sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("This learner doesn't exist you must pick one from the list")
                Exit Sub
            End If

            sqlcommand = New MySqlCommand("Update LearnerCourses SET LearnerCourses.Status= @Status WHERE LearnerID= @LearnerID AND CourseID= @CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)
            sqlcommand.Parameters.AddWithValue("@CourseID", ProgressGrid.CurrentRow.Cells(2).Value.ToString)
            sqlcommand.Parameters.AddWithValue("@Status", CombStatus.Text)
            sqlcommand.ExecuteNonQuery()

            tblLearnerCourses = New DataTable("LearnerCourses")
            sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID GROUP BY Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid"


            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblLearnerCourses)
            ProgressGrid.DataSource = tblLearnerCourses
        End Using
        MessageBox.Show(" Status updated. ")
        btnClear.PerformClick()
    End Sub

    Private Sub btnUpdateUnitsTaken_Click(sender As Object, e As EventArgs) Handles btnUpdateUnitsTaken.Click

        Dim Units As Integer

        If Not Integer.TryParse(txtUnits.Text, Units) Then
            MessageBox.Show("The values in Units must be numeric")
            Exit Sub
        End If

        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM Learner WHERE LearnerID=@LearnerID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)

            If sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("This learner doesn't exist you must pick one from the list")
                Exit Sub
            End If

            sqlcommand = New MySqlCommand("Update `gruppeoppgavedb`.`LearnerCourses` SET UnitTaken=@UnitTaken WHERE LearnerID=@LearnerID AND CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)
            sqlcommand.Parameters.AddWithValue("@CourseID", ProgressGrid.CurrentRow.Cells(2).Value.ToString)
            sqlcommand.Parameters.AddWithValue("@UnitTaken", Units)
            sqlcommand.ExecuteNonQuery()


            tblLearnerCourses = New DataTable("LearnerCourses")
            sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID GROUP BY Name,CourseName,Status,UnitTaken,AmountPaid"

            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblLearnerCourses)
            ProgressGrid.DataSource = tblLearnerCourses
        End Using
        MessageBox.Show(" Units Taken Updated ")
        btnClear.PerformClick()
    End Sub

    Private Sub btnUpdatePaid_Click(sender As Object, e As EventArgs) Handles btnUpdatePaid.Click

        Dim Amountpaid As Integer

        Dim Unit As Integer = ProgressGrid.CurrentRow.Cells(5).Value
        If Not Integer.TryParse(txtAmountsPaid.Text, Amountpaid) Then
            MessageBox.Show("The values in Units must be numeric")
            Exit Sub
        End If

        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM Learner WHERE LearnerID=@LearnerID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)

            If sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("This learner doesn't exist you must pick one from the list")
                Exit Sub
            End If

            sqlcommand = New MySqlCommand("SELECT COUNT(*) FROM LearnerCourses WHERE UnitTaken=@UnitTaken", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@UnitTaken", ProgressGrid.CurrentRow.Cells(5).Value)

            If sqlcommand.ExecuteScalar = 0 Then
                MessageBox.Show("You don't have any units")
                Exit Sub
            End If

            sqlcommand = New MySqlCommand("Update LearnerCourses SET AmountPaid=@AmountPaid WHERE LearnerID=@LearnerID AND CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@LearnerID", ProgressGrid.CurrentRow.Cells(0).Value.ToString)
            sqlcommand.Parameters.AddWithValue("@CourseID", ProgressGrid.CurrentRow.Cells(2).Value.ToString)
            Amountpaid = Amountpaid * Unit
            sqlcommand.Parameters.AddWithValue("@AmountPaid", Amountpaid)
            sqlcommand.ExecuteNonQuery()

            tblLearnerCourses = New DataTable("LearnerCourses")
            sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID GROUP BY Name,CourseName,Status,UnitTaken,AmountPaid"

            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblLearnerCourses)
            ProgressGrid.DataSource = tblLearnerCourses
        End Using
        MessageBox.Show(" Paid Updated.")
        btnClear.PerformClick()
    End Sub

    Private Sub btnRefreshGrid_Click(sender As Object, e As EventArgs) Handles btnRefreshGrid.Click
        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()
        sqlcommand = New MySqlCommand
        tblLearnerCourses = New DataTable("LearnerCourses")
        sqlcommand.Connection = sqlconnect
        sqlcommand.CommandText = "SELECT Learner.LearnerID, Name,Course.CourseID,CourseName,Status,UnitTaken,AmountPaid FROM LearnerCourses,Learner,Course WHERE LearnerCourses.LearnerID = Learner.LearnerID AND Course.CourseID = LearnerCourses.CourseID GROUP BY Name,CourseName,Status,UnitTaken,AmountPaid"

        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(tblLearnerCourses)
        ProgressGrid.DataSource = tblLearnerCourses
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ProgressGrid.DataSource = Nothing
        ProgressGrid.Rows.Clear()
        ProgressGrid.Refresh()

        txtAmountsPaid.Clear()
        txtCourseName.Clear()
        txtFirstname.Clear()
        txtUnits.Clear()
        CombStatus.Text = ""
    End Sub
End Class
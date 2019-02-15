Imports MySql.Data.MySqlClient

Public Class UpdateCourseDetailsForm
    Private sqlconnect As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"
    Private tblCourse As New DataTable
    Private sqladapter As MySqlDataAdapter
    Private Sub UpdateCourseDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlconnect = New MySqlConnection(sqlconnectionstring)
        sqlconnect.Open()
        sqlcommand = New MySqlCommand
        tblCourse = New DataTable("Learner")
        sqlcommand.Connection = sqlconnect
        sqlcommand.CommandText = "SELECT * FROM Course"
        sqladapter = New MySqlDataAdapter(sqlcommand)
        sqladapter.Fill(tblCourse)
        CourseGrid.DataSource = tblCourse

    End Sub

    Private Sub BtnUpdateCourse_Click(sender As Object, e As EventArgs) Handles BtnUpdateCourse.Click

        Dim Coursename As String = txtCourseID.Text
        If Coursename.Length <= 0 Then
            MessageBox.Show("You must write something to update")
        End If

        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("Update Course SET CourseName=@CourseName WHERE CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
            sqlcommand.Parameters.AddWithValue("@CourseName", txtCourseName.Text)
            sqlcommand.ExecuteNonQuery()

            Brukere.CheckID(txtCourseID.Text)
            tblCourse = New DataTable
            sqlcommand.CommandText = "SELECT * FROM Course"
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblCourse)
            CourseGrid.DataSource = tblCourse
        End Using
        MessageBox.Show("Course Updated. ")
    End Sub

    Private Sub btnUpdateMandatory_Click(sender As Object, e As EventArgs) Handles btnUpdateMandatory.Click

        Dim Mandatory As String = txtMandatory.Text
        If Mandatory.Length <= 0 Then
            MessageBox.Show("You must write something to update")
            Exit Sub
        End If
        If Not Mandatory = "Yes" Or Mandatory = "No" Then
            MessageBox.Show("You can only write Yes or No as mandatory statement")
            Exit Sub
        End If
        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("Update Course SET Mandatory=@Mandatory WHERE CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
            sqlcommand.Parameters.AddWithValue("@Mandatory", txtMandatory.Text)
            sqlcommand.ExecuteNonQuery()

            Brukere.CheckID(txtCourseID.Text)
            tblCourse = New DataTable
            sqlcommand.CommandText = "SELECT * FROM Course"
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblCourse)
            CourseGrid.DataSource = tblCourse
        End Using
        MessageBox.Show("Mandatory Updated. ")
    End Sub

    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs) Handles btnUpdatePrice.Click
        Dim Price As Integer
        If Not Integer.TryParse(txtPrice.Text, Price) Then
            MessageBox.Show("You must write numbers in Price form")
            Exit Sub
        End If


        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("Update Course SET Price=@Price WHERE CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
            sqlcommand.Parameters.AddWithValue("@Price", Price)
            sqlcommand.ExecuteNonQuery()

            Brukere.CheckID(txtCourseID.Text)
            tblCourse = New DataTable
            sqlcommand.CommandText = "SELECT * FROM Course"
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblCourse)
            CourseGrid.DataSource = tblCourse
        End Using
        MessageBox.Show("Price Updated. ")
    End Sub

    Private Sub btnUpdateOfferDate_Click(sender As Object, e As EventArgs) Handles btnUpdateOfferDate.Click

        Dim OfferDate As Date = dtpOfferDate.Text
        Using Sqlconnect = New MySqlConnection(sqlconnectionstring)

            Sqlconnect.Open()
            sqlcommand = New MySqlCommand("UPDATE Course SET OfferDate=@OfferDate WHERE CourseID=@CourseID", Sqlconnect)
            sqlcommand.Parameters.AddWithValue("@CourseID", txtCourseID.Text)
            sqlcommand.Parameters.AddWithValue("@OfferDate", OfferDate)
            sqlcommand.ExecuteNonQuery()

            Brukere.CheckID(txtCourseID.Text)
            tblCourse = New DataTable
            sqlcommand.CommandText = "SELECT * FROM Course"
            sqladapter = New MySqlDataAdapter(sqlcommand)
            sqladapter.Fill(tblCourse)
            CourseGrid.DataSource = tblCourse
        End Using
        MessageBox.Show("Offer date Updated. ")
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        AdminForm.Show()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class AdminForm
    Private sqlconnect As MySqlConnection
    Dim tblLearner As New DataTable
    Dim sqladapter As MySqlDataAdapter
    Dim sqlcommand As MySqlCommand
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"


    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoggedinAsAdmin.Text = Brukere.Username(0)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Ask user about him will Exit program
        Dim DialogExit As DialogResult
        DialogExit = MessageBox.Show("Do you really want to exit program.", "Exit", MessageBoxButtons.YesNoCancel)

        If DialogExit = DialogResult.No Then
            DialogExit = True

        ElseIf DialogExit = DialogResult.Cancel Then
            DialogExit = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Got bake to login form
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnShowLearners_Click(sender As Object, e As EventArgs) Handles btnShowLearners.Click

        Using sqlconnect = New MySqlConnection(sqlconnectionstring)
            sqlconnect.Open()

            If RadAllLearners.Checked Then

                tblLearner = New DataTable("Learner")
                sqlcommand = New MySqlCommand("SELECT LearnerID,Name,Email,Phone,DateOfBirth,Address FROM Learner WHERE Username NOT IN(SELECT Username FROM Learner WHERE Username = 'Admin')", sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(tblLearner)
                LearnerGrid.DataSource = tblLearner

            ElseIf RadMørkekjøring.Checked Then

                tblLearner = New DataTable("Learner")
                sqlcommand = New MySqlCommand("SELECT Learner.LearnerID,Course.CourseId,Name,Email,Phone,DateOfBirth,Address FROM Learner,Course,LearnerCourses WHERE Learner.LearnerID = Learnercourses.LearnerId AND Course.CourseID = Learnercourses.CourseID AND Course.CourseID = '7' AND Status NOT IN (SELECT Status FROM Learnercourses WHERE Status='Compelete') AND Username NOT IN (SELECT Username FROM Learner WHERE Username='Admin') GROUP BY Learner.LearnerID,Course.CourseId,Name,Email,Phone,DateOfBirth,Address", sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(tblLearner)
                LearnerGrid.DataSource = tblLearner
            ElseIf RadNotEnrolled.Checked Then

                tblLearner = New DataTable("Learner")
                sqlcommand = New MySqlCommand("SELECT Learner.LearnerID,Name,Email,Phone,DateOfBirth,Address FROM Learner WHERE Enrolled ='No' AND Username NOT IN (SELECT Username FROM Learner WHERE Username='Admin') GROUP BY Learner.LearnerID,Name,Email,Phone,DateOfBirth,Address;", sqlconnect)
                sqladapter = New MySqlDataAdapter(sqlcommand)
                sqladapter.Fill(tblLearner)
                LearnerGrid.DataSource = tblLearner
            End If
        End Using
    End Sub

    Private Sub btnEnrollLearner_Click(sender As Object, e As EventArgs) Handles btnEnrollLearner.Click
        Me.Close()
        EnrollLearnerForm.Show()
    End Sub

    Private Sub btnUpdateProgress_Click(sender As Object, e As EventArgs) Handles btnUpdateProgress.Click
        Me.Close()
        UpdateProgressForm.Show()
    End Sub

    Private Sub btnUpdateCourseDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateCourseDetails.Click
        Me.Close()
        UpdateCourseDetailsForm.Show()

    End Sub

    Private Sub btnSelectRowDetails_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear everything
        LearnerGrid.DataSource = Nothing
        LearnerGrid.Rows.Clear()
        LearnerGrid.Refresh()

    End Sub
End Class
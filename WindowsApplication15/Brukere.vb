Imports MySql.Data.MySqlClient

Module Brukere

    'Modulen deklarerer og skaper objekter som brukes i alle skjemaene
    Private Const minConnectionString As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"
    Public minConnection As New MySqlConnection(minConnectionString)

    Public Query As String = ""
    Public Command As New MySqlCommand("", minConnection) 'skjemaene setter Command.CommandText
    Public minAdapter As New MySqlDataAdapter(Command)

    Public sqlRead As MySqlDataReader
    Public TabDataSet As New DataTable
    Public DBBindingSorce As BindingSource
    Private sqlconnect As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private sqlconnectionstring As String = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb"
    Private tblLearner As New DataTable
    Private sqladapter As MySqlDataAdapter

    Public Function ekteEpost(ByVal epost As String) As Boolean

        If epost.Contains("@") And epost.Contains(".") And epost.Length > 4 Then
            Return True
        Else
            Return False
        End If


    End Function

    Function learner()
        Dim brukernavn As String = ""
        Dim password As String = ""


        password = LogIn.txtPassord.Text
        brukernavn = LogIn.txtBrukernavn.Text


        Dim strquery As String = "SELECT * FROM learner WHERE Username='" & brukernavn & "' AND Password='" & password & "'"
        Return strquery
    End Function

    Function Admin()
        Dim brukernavn As String = ""
        Dim password As String = ""


        password = LogIn.txtPassord.Text
        brukernavn = LogIn.txtBrukernavn.Text


        Dim strquery As String = "SELECT * FROM learner WHERE Username='" & brukernavn & "' AND Password='" & password & "' AND Role"
        Return strquery
    End Function

    Sub CheckID(ByVal CourseID As String)
        If CourseID.Length <= 0 Then
            MessageBox.Show("You must pick a course by writing the ID in the Course ID textbox")
            Exit Sub
        End If
        Using SQLconnect = New MySqlConnection(sqlconnectionstring)
            SQLconnect.Open()
            sqlCommand = New MySqlCommand("SELECT COUNT(*) FROM Course WHERE CourseID=@CourseID", SQLconnect)
            sqlCommand.Parameters.AddWithValue("@CourseID", CourseID)
            If sqlCommand.ExecuteScalar = 0 Then
                MessageBox.Show("This course doesn't exist")
                Exit Sub
            End If
        End Using
    End Sub
    Function Username(ByVal User As String) As String
        User = LogIn.txtBrukernavn.Text
        Return User
    End Function
    Function Passwords(ByVal Pass As String) As String
        Pass = LogIn.txtPassord.Text
        Return Pass
    End Function

End Module

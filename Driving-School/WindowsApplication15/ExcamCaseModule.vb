Imports MySql.Data.MySqlClient
Module ExcamCaseModule


    'Modulen deklarerer og skaper objekter som brukes i alle skjemaene
    Private Const minConnectionString As String = "server=localhost;user id=root;password=bahaamahmad60;persistsecurityinfo=True;database=gruppeoppgavedb"
    Public minConnection As New MySqlConnection(minConnectionString)

    Public Query As String = ""
    Public Command As New MySqlCommand("", minConnection) 'skjemaene setter minCommand.CommandText
    Public minAdapter As New MySqlDataAdapter(Command)

    Public sqlCommand As New MySqlCommand("", minConnection)
    Public Adapter As New MySqlDataAdapter(sqlCommand)

    Public sqlRead As MySqlDataReader
    Public TabDataSet As New DataTable
    Public DBBindingSorce As BindingSource


    Public Function ekteEpost(ByVal epost As String) As Boolean

        If epost.Contains("@") And epost.Contains(".") And epost.Length > 4 Then
            Return True
        Else
            Return False
        End If


    End Function


End Module

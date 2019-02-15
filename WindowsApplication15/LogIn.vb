Imports MySql.Data.MySqlClient
Public Class LogIn

    Dim mysqlcon As MySqlConnection
    Dim strquery As String = ""
    Dim sqlCmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim RandomArray() As Integer
    Dim LengdePåArray As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlcon = New MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=gruppeoppgavedb")
        ' minConnection.Open()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoggin.Click
        Dim brukernavn As String = ""
        Dim password As String = ""
        btnLoggin.Enabled = False

        password = txtPassord.Text
        brukernavn = txtBrukernavn.Text
        If brukernavn = "" Or password = "" Then
            lblSatusBeskrivelse.Show()
            txtStatus.Show()
            txtStatus.Text = "Du må fylle inn brukernavn og passord"
        Else

            mysqlcon.Open()
            Dim myadapter As New MySqlDataAdapter
            strquery = "SELECT * FROM learner WHERE Username='" & brukernavn & "' AND Password='" & password & "' AND Role = '" & cbRole.SelectedItem & "'"
            sqlCmd = New MySqlCommand(strquery, mysqlcon)
            sqlCmd.Connection = mysqlcon
            sqlCmd.CommandText = strquery
            myadapter.SelectCommand = sqlCmd
            Dim mydata As MySqlDataReader
            mydata = sqlCmd.ExecuteReader


            If mydata.HasRows = True Then

                If cbRole.SelectedItem = "Admin" Then
                    txtPassord.Clear()
                    AdminForm.Show()
                    Me.Hide()

                    lblSatusBeskrivelse.Hide()
                    txtStatus.Clear()
                    txtStatus.Hide()
                    txtBrukernavn.Clear()
                Else
                    txtPassord.Clear()
                    LearnerForm.Show()
                    Me.Hide()

                    lblSatusBeskrivelse.Hide()
                    txtStatus.Clear()
                    txtStatus.Hide()
                    txtBrukernavn.Clear()
                End If

            Else
                    lblSatusBeskrivelse.Show()
                txtStatus.Show()
                txtStatus.Text = "Feil brukernavn eller passord"

            End If

            mysqlcon.Close()
        End If
    End Sub

    Private Function teksttest(text)
        'tester at verdien er nummer og at den ikke er større en 9999999999 (eller mindre en 10 "tall")
        If Not IsNumeric(text) And Len(text) < 10 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        txtStatus.Clear()
        btnLoggin.Enabled = False
        If IsNumeric(txtPassord.Text) And (teksttest(txtBrukernavn.Text) = True) Then
            btnLoggin.Enabled = True
        Else
            btnLoggin.Enabled = False
            lblSatusBeskrivelse.Show()
            txtStatus.Show()
            txtStatus.Text = "Passordet må være tall"
        End If


    End Sub

    Private Sub txtBrukernavn_TextChanged(sender As Object, e As EventArgs) Handles txtBrukernavn.TextChanged
        txtStatus.Clear()
        btnLoggin.Enabled = False


        If teksttest(txtBrukernavn.Text) = True Then
            btnLoggin.Enabled = True
        Else
            btnLoggin.Enabled = False
            lblSatusBeskrivelse.Show()
            txtStatus.Show()
            txtStatus.Text = "brukernavn må ha noen bokstaver" & vbCrLf & "og må være under 20 bokstaver"
        End If
    End Sub

    Private Sub btnExit_hover(sender As Object, e As EventArgs) Handles btnExit.MouseHover

        txtStatus.Show()
        lblSatusBeskrivelse.Show()
        txtStatus.Text = "Klikk på 'Exit' for å lukke programmet"
    End Sub
    Private Sub btnExit_Leave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        txtStatus.Hide()
        lblSatusBeskrivelse.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBrukernavn.Clear()
        txtPassord.Clear()
        txtStatus.Hide()
        lblSatusBeskrivelse.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterNew.Show()
        Me.Hide()
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
End Class

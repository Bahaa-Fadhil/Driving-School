Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class LearnerForm
    Private Sub grPersonalinfo_Enter(sender As Object, e As EventArgs) Handles grPersonalinfo.Enter

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

    Private Sub grShowExpenditure_Enter(sender As Object, e As EventArgs) Handles grShowExpenditure.Enter

    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click


        Try
            'Clear datagridview
            DataGridViewShowDetails.DataSource = Nothing
            DataGridViewShowDetails.Rows.Clear()
            DataGridViewShowDetails.Refresh()

            'open connection with database
            minConnection.Open()

            'SELECT Course details from Mysql database
            Command.CommandText = "SELECT course.CourseName, course.Mandatory, learnercourses.Status, course.OfferDate, course.Price, learnercourses.UnitTaken ,learnercourses.AmountPaid From learner, course, learnercourses WHERE learner.LearnerID = learnercourses.LearnerID AND course.CourseID = learnercourses.CourseID AND learner.Username = '" & lblUsername.Text & "'"
            Command.ExecuteNonQuery()

            Dim Tab As New DataTable

            minAdapter.SelectCommand = Command                      ' select sqlcommand 
            minAdapter.Fill(Tab)                             ' Fill DataTable         

            DataGridViewShowDetails.DataSource = Tab         ' legge data til DataGridView 
            minAdapter.Update(Tab)                           ' Oppdater Data i DataGridView
            DataGridViewShowDetails.Refresh()

            'lukke connetion med database
            minConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ")
        End Try

    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click

        Try
            'Clear datagridview
            DataGridViewShowDetails.Columns.Clear()
            DataGridViewShowDetails.DataSource = Nothing
            DataGridViewShowDetails.Rows.Clear()
            DataGridViewShowDetails.Refresh()
            grUpdateProfile.Enabled = True

            'open connection with database
            minConnection.Open()

            'SELECT Course details from Mysql database
            Command.CommandText = "SELECT  learner.LearnerID,learner.Name, learner.DateofBirth, learner.Address, learner.Phone, learner.Email FROM learner WHERE learner.Username = '" & lblUsername.Text & "'"
            Command.ExecuteNonQuery()

            Dim TabUpDate As New DataTable

            minAdapter.SelectCommand = Command                      ' select sqlcommand 
            minAdapter.Fill(TabUpDate)                             ' Fill DataTable         

            DataGridViewShowDetails.DataSource = TabUpDate         ' legge data til DataGridView 
            minAdapter.Update(TabUpDate)                           ' Oppdater Data i DataGridView
            DataGridViewShowDetails.Refresh()

            ' View data from datagridview to labels
            lblLearnID.Text = DataGridViewShowDetails.Rows(0).Cells("LearnerID").Value
            lblLearnName.Text = DataGridViewShowDetails.Rows(0).Cells("Name").Value
            lblBirthday.Text = DataGridViewShowDetails.Rows(0).Cells("DateofBirth").Value
            lblAdress.Text = DataGridViewShowDetails.Rows(0).Cells("Address").Value
            lblPhone.Text = DataGridViewShowDetails.Rows(0).Cells("Phone").Value
            lblEmail.Text = DataGridViewShowDetails.Rows(0).Cells("Email").Value

            'lukke connetion med database
            minConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ")
        End Try
    End Sub

    Private Sub LearnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDialog1.Document = PrintDocument1
        grUpdateProfile.Enabled = False
        grShowExpenditure.Enabled = False
        lblUsername.Text = LogIn.txtBrukernavn.Text

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try

            'Clear everything
            DataGridViewShowDetails.DataSource = Nothing
            DataGridViewShowDetails.Rows.Clear()
            DataGridViewShowDetails.Refresh()

            txtPassword.Clear()
            txtRepassword.Clear()
            txtPhone.Clear()
            txtAdress.Clear()
            txtEmail.Clear()
            lblLearnID.Text = ""
            lblLearnName.Text = ""
            dtpBrithday.Value = Date.Today
            lblBirthday.Text = ""
            lblPhone.Text = ""
            lblEmail.Text = ""
            lblAdress.Text = ""
            dtpBrithday.Text = ""

            lblCouresName1.Text = ""
            lblCouresName2.Text = ""
            lblCouresName3.Text = ""
            lblCouresName4.Text = ""
            lblCouresName5.Text = ""
            lblCouresName6.Text = ""
            lblCouresName7.Text = ""
            lblStatus1.Text = ""
            lblStatus2.Text = ""
            lblStatus3.Text = ""
            lblStatus4.Text = ""
            lblStatus5.Text = ""
            lblStatus6.Text = ""
            lblStatus7.Text = ""
            lblPrice1.Text = ""
            lblPrice2.Text = ""
            lblPrice3.Text = ""
            lblPrice4.Text = ""
            lblPrice5.Text = ""
            lblPrice6.Text = ""
            lblPrice7.Text = ""
            lblTotalCost.Text = ""

            grUpdateProfile.Enabled = False
            grShowExpenditure.Enabled = False
            dtpBrithday.Text = False

        Catch ex As Exception
            MessageBox.Show(ex, "Ti's nothing to clear.")
        End Try
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click

        Try
            'Clear datagridview
            DataGridViewShowDetails.DataSource = Nothing
            DataGridViewShowDetails.Rows.Clear()
            DataGridViewShowDetails.Refresh()
            grShowExpenditure.Enabled = True

            'open connection with database
            minConnection.Open()

            'SELECT Course details from Mysql database
            Command.CommandText = "Select  course.CourseName, course.Price, learnercourses.Status, course.OfferDate,learnercourses.UnitTaken ,learnercourses.AmountPaid FROM learner, learnercourses,course WHERE course.CourseID = learnercourses.CourseID And learnercourses.LearnerID = learner.LearnerID  And learner.Username = '" & lblUsername.Text & "'"
            Command.ExecuteNonQuery()


            Dim TabTotalCost As New DataTable
            minAdapter.SelectCommand = Command                      ' select sqlcommand 
            minAdapter.Fill(TabTotalCost)                             ' Fill DataTable         

            DataGridViewShowDetails.DataSource = TabTotalCost         ' legge data til DataGridView 
            minAdapter.Update(TabTotalCost)                           ' Oppdater Data i DataGridView
            DataGridViewShowDetails.Refresh()

            ' View data for all courses
            lblCouresName1.Text = DataGridViewShowDetails.Rows(0).Cells("CourseName").Value
            lblCouresName2.Text = DataGridViewShowDetails.Rows(1).Cells("CourseName").Value
            lblCouresName3.Text = DataGridViewShowDetails.Rows(2).Cells("CourseName").Value
            lblCouresName4.Text = DataGridViewShowDetails.Rows(3).Cells("CourseName").Value
            lblCouresName5.Text = DataGridViewShowDetails.Rows(4).Cells("CourseName").Value
            lblCouresName6.Text = DataGridViewShowDetails.Rows(5).Cells("CourseName").Value
            lblCouresName7.Text = DataGridViewShowDetails.Rows(6).Cells("CourseName").Value

            ' View data for all  course status
            lblStatus1.Text = DataGridViewShowDetails.Rows(0).Cells("Status").Value
            lblStatus2.Text = DataGridViewShowDetails.Rows(1).Cells("Status").Value
            lblStatus3.Text = DataGridViewShowDetails.Rows(2).Cells("Status").Value
            lblStatus4.Text = DataGridViewShowDetails.Rows(3).Cells("Status").Value
            lblStatus5.Text = DataGridViewShowDetails.Rows(4).Cells("Status").Value
            lblStatus6.Text = DataGridViewShowDetails.Rows(5).Cells("Status").Value
            lblStatus7.Text = DataGridViewShowDetails.Rows(6).Cells("Status").Value

            ' View data for all  course price
            lblPrice1.Text = (DataGridViewShowDetails.Rows(0).Cells("Price").Value * DataGridViewShowDetails.Rows(0).Cells("UnitTaken").Value)
            lblPrice2.Text = (DataGridViewShowDetails.Rows(1).Cells("Price").Value * DataGridViewShowDetails.Rows(1).Cells("UnitTaken").Value)
            lblPrice3.Text = (DataGridViewShowDetails.Rows(2).Cells("Price").Value * DataGridViewShowDetails.Rows(2).Cells("UnitTaken").Value)
            lblPrice4.Text = (DataGridViewShowDetails.Rows(3).Cells("Price").Value * DataGridViewShowDetails.Rows(3).Cells("UnitTaken").Value)
            lblPrice5.Text = (DataGridViewShowDetails.Rows(4).Cells("Price").Value * DataGridViewShowDetails.Rows(4).Cells("UnitTaken").Value)
            lblPrice6.Text = (DataGridViewShowDetails.Rows(5).Cells("Price").Value * DataGridViewShowDetails.Rows(5).Cells("UnitTaken").Value)
            lblPrice7.Text = (DataGridViewShowDetails.Rows(6).Cells("Price").Value * DataGridViewShowDetails.Rows(6).Cells("UnitTaken").Value)

            ' View data for total cost
            lblTotalCost.Text = (DataGridViewShowDetails.Rows(0).Cells("Price").Value * DataGridViewShowDetails.Rows(0).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(1).Cells("Price").Value * DataGridViewShowDetails.Rows(1).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(2).Cells("Price").Value * DataGridViewShowDetails.Rows(2).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(3).Cells("Price").Value * DataGridViewShowDetails.Rows(3).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(4).Cells("Price").Value * DataGridViewShowDetails.Rows(4).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(5).Cells("Price").Value * DataGridViewShowDetails.Rows(5).Cells("UnitTaken").Value) +
                (DataGridViewShowDetails.Rows(6).Cells("Price").Value * DataGridViewShowDetails.Rows(6).Cells("UnitTaken").Value)

            'lukke connetion med database
            minConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ")
        End Try

    End Sub

    Private Sub DataGridViewShowDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowDetails.CellContentClick
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim eksisterer As Boolean = False
            Dim msg As New MsgBoxResult

            If Not txtPassword.Text = txtRepassword.Text Then
                Throw New Exception("Password must be same! ")
            ElseIf txtPassword.Text <= 6 And txtRepassword.Text <= 6 Then
                Throw New Exception("Password must be least 6 characters")
            ElseIf dtpBrithday.Value >= Date.Today Then
                Throw New Exception("Birthday must be correct")
            ElseIf Not IsNumeric(txtPhone.Text) Or Not txtPhone.Text.Length = 8 Then
                Throw New Exception("Phone number is not correct")
            ElseIf Not ekteEpost(txtEmail.Text) Then
                msg = MsgBox("Email address is not valid, you will register your information without Email ? ", MsgBoxStyle.YesNo)
                If msg = MsgBoxResult.No Then
                    Throw New Exception("Not registered")
                ElseIf msg = MsgBoxResult.Yes Then
                    minConnection.Open()
                    Command.CommandText = "UPDATE `gruppeoppgavedb`.`learner` SET `Password`='" & txtRepassword.Text & "', `DateofBirth`='" & dtpBrithday.Text & "', `Address`='" & txtAdress.Text & "', `Phone`='" & txtPhone.Text & "'  WHERE `LearnerID`= '" & lblLearnID.Text & "'"
                    Command.ExecuteNonQuery()
                End If

            ElseIf txtAdress.Text.Length < 3 Then
                msg = MsgBox("Street Address not valid, you will register  your information without street address?", MsgBoxStyle.YesNo)
                If msg = MsgBoxResult.No Then
                    Throw New Exception("Not registered")
                ElseIf msg = MsgBoxResult.Yes Then
                    minConnection.Open()
                    Command.CommandText = "UPDATE `gruppeoppgavedb`.`learner` SET `Password`='" & txtRepassword.Text & "', `DateofBirth`='" & dtpBrithday.Text & "', `Phone`='" & txtPhone.Text & "'  WHERE `LearnerID`= '" & lblLearnID.Text & "'"
                    Command.ExecuteNonQuery()
                End If

            Else

                'open connection with database
                minConnection.Open()

                'SELECT Course details from Mysql database
                Command.CommandText = "UPDATE `gruppeoppgavedb`.`learner` SET `Password`='" & txtRepassword.Text & "', `DateofBirth`='" & dtpBrithday.Value & "', `Address`='" & txtAdress.Text & "', `Phone`='" & txtPhone.Text & "', `Email`='" & txtEmail.Text & "' WHERE `LearnerID`= '" & lblLearnID.Text & "'"
                Command.ExecuteNonQuery()

                minAdapter.SelectCommand = Command                      ' select sqlcommand 
                minAdapter.Fill(TabDataSet)                             ' Fill DataTable         

                DataGridViewShowDetails.DataSource = TabDataSet         ' legge data til DataGridView 
                minAdapter.Update(TabDataSet)                           ' Oppdater Data i DataGridView
                DataGridViewShowDetails.Refresh()

            End If

            ' vise lagret data i en MessageBox
            MessageBox.Show("Information saved. " & vbNewLine & vbNewLine & "Password: " & "**********" & vbNewLine & "Birthday: " & dtpBrithday.Value & vbNewLine & "Phone: " & txtPhone.Text & vbNewLine & "Email: " & txtEmail.Text & vbNewLine & "Address: " & txtAdress.Text & vbNewLine & vbNewLine & "Thank you for updating your information. ")
            btnClear.PerformClick()

            'lukke connetion med database
            minConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR ")
        End Try

    End Sub

    Private Sub SearchInGoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchInGoogleToolStripMenuItem.Click

        'searching in Google
        System.Diagnostics.Process.Start("https://www.google.no/?gfe_rd=cr&ei=bFUyV8j5Cqir8wfekLHQAw")

    End Sub

    Private Sub SearchInVisualStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchInVisualStudioToolStripMenuItem.Click
        'searching in Google
        System.Diagnostics.Process.Start("http://www.visual-basic-tutorials.com/")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Ask user about him will Exit program
        btnExit.PerformClick()
    End Sub

    Private Sub ShowDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowDetailsToolStripMenuItem1.Click
        btnShowDetails.PerformClick()
    End Sub

    Private Sub UpdateProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProfileToolStripMenuItem.Click
        btnUpdateProfile.PerformClick()
    End Sub

    Private Sub TotalCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalCostToolStripMenuItem.Click
        btnTotalCost.PerformClick()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        btnClear.PerformClick()
    End Sub

    Private Sub OnlinePrivacyStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlinePrivacyStatementToolStripMenuItem.Click

        System.Diagnostics.Process.Start("https://www.visualstudio.com/en-us/dn948229")
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = Now
    End Sub

    Private Sub PrintToPdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToPdfToolStripMenuItem.Click
        Dim msg As MsgBoxResult

        msg = MsgBox("Do you want to save Invoice/Fee.", MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            PrintDocument1.Print()
            PrintDocument1.ToString()
        Else
            Exit Sub
        End If
        btnClear.PerformClick()

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' printer Total Cost
        Dim Reportfont As Font = New Drawing.Font("Time New Roman", 12)
        e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)
        e.Graphics.DrawString(vbNewLine & vbNewLine & " Driving School  " & vbNewLine & vbNewLine, Reportfont, Brushes.Blue, 360, 100)

        e.Graphics.DrawString("Learner information:  ", Reportfont, Brushes.Red, 100, 200)
        e.Graphics.DrawString("Coursename:  " & lblCouresName1.Text, Reportfont, Brushes.Black, 100, 240)
        e.Graphics.DrawString("Status:  " & lblStatus1.Text, Reportfont, Brushes.Black, 380, 240)
        e.Graphics.DrawString("Price:  " & lblPrice1.Text & vbNewLine, Reportfont, Brushes.Black, 560, 240)
        e.Graphics.DrawString("Coursename:  " & lblCouresName2.Text, Reportfont, Brushes.Black, 100, 280)
        e.Graphics.DrawString("Status:  " & lblStatus2.Text, Reportfont, Brushes.Black, 380, 280)
        e.Graphics.DrawString("Price:  " & lblPrice2.Text & vbNewLine, Reportfont, Brushes.Black, 560, 280)
        e.Graphics.DrawString("Coursename:  " & lblCouresName3.Text, Reportfont, Brushes.Black, 100, 320)
        e.Graphics.DrawString("Status:  " & lblStatus3.Text, Reportfont, Brushes.Black, 380, 320)
        e.Graphics.DrawString("Price:  " & lblPrice3.Text & vbNewLine, Reportfont, Brushes.Black, 560, 320)
        e.Graphics.DrawString("Coursename:  " & lblCouresName4.Text, Reportfont, Brushes.Black, 100, 360)
        e.Graphics.DrawString("Status:  " & lblStatus4.Text, Reportfont, Brushes.Black, 380, 360)
        e.Graphics.DrawString("Price:  " & lblPrice4.Text & vbNewLine, Reportfont, Brushes.Black, 560, 360)
        e.Graphics.DrawString("Coursename:  " & lblCouresName5.Text, Reportfont, Brushes.Black, 100, 400)
        e.Graphics.DrawString("Status:  " & lblStatus5.Text, Reportfont, Brushes.Black, 380, 400)
        e.Graphics.DrawString("Price:  " & lblPrice5.Text & vbNewLine, Reportfont, Brushes.Black, 560, 400)
        e.Graphics.DrawString("Coursename:  " & lblCouresName6.Text, Reportfont, Brushes.Black, 100, 440)
        e.Graphics.DrawString("Status:  " & lblStatus6.Text, Reportfont, Brushes.Black, 380, 440)
        e.Graphics.DrawString("Price:  " & lblPrice6.Text & vbNewLine, Reportfont, Brushes.Black, 560, 440)
        e.Graphics.DrawString("Coursename:  " & lblCouresName7.Text, Reportfont, Brushes.Black, 100, 480)
        e.Graphics.DrawString("Status:  " & lblStatus7.Text, Reportfont, Brushes.Black, 380, 480)
        e.Graphics.DrawString("Price:  " & lblPrice7.Text & vbNewLine, Reportfont, Brushes.Black, 560, 480)
        e.Graphics.DrawString("Total sum:  " & lblTotalCost.Text & vbNewLine, Reportfont, Brushes.Black, 100, 540)
        e.Graphics.DrawString("Thank you for choosing us Driving School  " & vbNewLine, Reportfont, Brushes.Black, 100, 590)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Got bake to login form
        LogIn.Show()
        Me.Hide()
    End Sub


End Class
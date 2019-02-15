<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.btnUpdateCourseDetails = New System.Windows.Forms.Button()
        Me.btnUpdateProgress = New System.Windows.Forms.Button()
        Me.btnEnrollLearner = New System.Windows.Forms.Button()
        Me.btnShowLearners = New System.Windows.Forms.Button()
        Me.lblLogInAs = New System.Windows.Forms.Label()
        Me.txtLoggedinAsAdmin = New System.Windows.Forms.TextBox()
        Me.RadNotEnrolled = New System.Windows.Forms.RadioButton()
        Me.RadMørkekjøring = New System.Windows.Forms.RadioButton()
        Me.RadAllLearners = New System.Windows.Forms.RadioButton()
        Me.LearnerGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.LearnerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdateCourseDetails
        '
        Me.btnUpdateCourseDetails.Location = New System.Drawing.Point(295, 38)
        Me.btnUpdateCourseDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateCourseDetails.Name = "btnUpdateCourseDetails"
        Me.btnUpdateCourseDetails.Size = New System.Drawing.Size(126, 30)
        Me.btnUpdateCourseDetails.TabIndex = 2
        Me.btnUpdateCourseDetails.Text = "U&pdate Course Details"
        Me.btnUpdateCourseDetails.UseVisualStyleBackColor = True
        '
        'btnUpdateProgress
        '
        Me.btnUpdateProgress.Location = New System.Drawing.Point(123, 76)
        Me.btnUpdateProgress.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateProgress.Name = "btnUpdateProgress"
        Me.btnUpdateProgress.Size = New System.Drawing.Size(126, 30)
        Me.btnUpdateProgress.TabIndex = 1
        Me.btnUpdateProgress.Text = "&Update Progress"
        Me.btnUpdateProgress.UseVisualStyleBackColor = True
        '
        'btnEnrollLearner
        '
        Me.btnEnrollLearner.Location = New System.Drawing.Point(123, 38)
        Me.btnEnrollLearner.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollLearner.Name = "btnEnrollLearner"
        Me.btnEnrollLearner.Size = New System.Drawing.Size(126, 30)
        Me.btnEnrollLearner.TabIndex = 0
        Me.btnEnrollLearner.Text = "&Enroll a Learner"
        Me.btnEnrollLearner.UseVisualStyleBackColor = True
        '
        'btnShowLearners
        '
        Me.btnShowLearners.Location = New System.Drawing.Point(295, 76)
        Me.btnShowLearners.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowLearners.Name = "btnShowLearners"
        Me.btnShowLearners.Size = New System.Drawing.Size(126, 30)
        Me.btnShowLearners.TabIndex = 4
        Me.btnShowLearners.Text = "Show &Learners"
        Me.btnShowLearners.UseVisualStyleBackColor = True
        '
        'lblLogInAs
        '
        Me.lblLogInAs.AutoSize = True
        Me.lblLogInAs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogInAs.Location = New System.Drawing.Point(387, 31)
        Me.lblLogInAs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogInAs.Name = "lblLogInAs"
        Me.lblLogInAs.Size = New System.Drawing.Size(73, 19)
        Me.lblLogInAs.TabIndex = 6
        Me.lblLogInAs.Text = "Username:"
        '
        'txtLoggedinAsAdmin
        '
        Me.txtLoggedinAsAdmin.Location = New System.Drawing.Point(463, 28)
        Me.txtLoggedinAsAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoggedinAsAdmin.Name = "txtLoggedinAsAdmin"
        Me.txtLoggedinAsAdmin.ReadOnly = True
        Me.txtLoggedinAsAdmin.Size = New System.Drawing.Size(118, 26)
        Me.txtLoggedinAsAdmin.TabIndex = 7
        '
        'RadNotEnrolled
        '
        Me.RadNotEnrolled.AutoSize = True
        Me.RadNotEnrolled.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNotEnrolled.Location = New System.Drawing.Point(225, 20)
        Me.RadNotEnrolled.Margin = New System.Windows.Forms.Padding(4)
        Me.RadNotEnrolled.Name = "RadNotEnrolled"
        Me.RadNotEnrolled.Size = New System.Drawing.Size(105, 23)
        Me.RadNotEnrolled.TabIndex = 1
        Me.RadNotEnrolled.TabStop = True
        Me.RadNotEnrolled.Text = "Not Enrolled"
        Me.RadNotEnrolled.UseVisualStyleBackColor = True
        '
        'RadMørkekjøring
        '
        Me.RadMørkekjøring.AutoSize = True
        Me.RadMørkekjøring.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMørkekjøring.Location = New System.Drawing.Point(348, 20)
        Me.RadMørkekjøring.Margin = New System.Windows.Forms.Padding(4)
        Me.RadMørkekjøring.Name = "RadMørkekjøring"
        Me.RadMørkekjøring.Size = New System.Drawing.Size(180, 23)
        Me.RadMørkekjøring.TabIndex = 2
        Me.RadMørkekjøring.TabStop = True
        Me.RadMørkekjøring.Text = "Not Taken Mørkekjøring"
        Me.RadMørkekjøring.UseVisualStyleBackColor = True
        '
        'RadAllLearners
        '
        Me.RadAllLearners.AutoSize = True
        Me.RadAllLearners.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAllLearners.Location = New System.Drawing.Point(106, 20)
        Me.RadAllLearners.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAllLearners.Name = "RadAllLearners"
        Me.RadAllLearners.Size = New System.Drawing.Size(101, 23)
        Me.RadAllLearners.TabIndex = 0
        Me.RadAllLearners.TabStop = True
        Me.RadAllLearners.Text = "All Learners"
        Me.RadAllLearners.UseVisualStyleBackColor = True
        '
        'LearnerGrid
        '
        Me.LearnerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LearnerGrid.Location = New System.Drawing.Point(19, 31)
        Me.LearnerGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.LearnerGrid.Name = "LearnerGrid"
        Me.LearnerGrid.Size = New System.Drawing.Size(484, 279)
        Me.LearnerGrid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 620)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show Details"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 576)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Sign out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(360, 576)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 576)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEnrollLearner)
        Me.GroupBox4.Controls.Add(Me.btnUpdateProgress)
        Me.GroupBox4.Controls.Add(Me.btnUpdateCourseDetails)
        Me.GroupBox4.Controls.Add(Me.btnShowLearners)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 429)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(530, 125)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Whar do you like to do ?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LearnerGrid)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 331)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadAllLearners)
        Me.GroupBox2.Controls.Add(Me.RadMørkekjøring)
        Me.GroupBox2.Controls.Add(Me.RadNotEnrolled)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 52)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Role"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 686)
        Me.Controls.Add(Me.txtLoggedinAsAdmin)
        Me.Controls.Add(Me.lblLogInAs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving School - Admin"
        CType(Me.LearnerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateCourseDetails As Button
    Friend WithEvents btnUpdateProgress As Button
    Friend WithEvents btnEnrollLearner As Button
    Friend WithEvents btnShowLearners As Button
    Friend WithEvents lblLogInAs As Label
    Friend WithEvents txtLoggedinAsAdmin As TextBox
    Friend WithEvents RadNotEnrolled As RadioButton
    Friend WithEvents RadMørkekjøring As RadioButton
    Friend WithEvents RadAllLearners As RadioButton
    Friend WithEvents LearnerGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class

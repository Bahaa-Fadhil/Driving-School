<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollLearnerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollLearnerForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnrollByGrid = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnRefreshGrid = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LearnerGrid = New System.Windows.Forms.DataGridView()
        Me.GrpSearchforaStudent = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LearnerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSearchforaStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnEnrollByGrid)
        Me.GroupBox1.Controls.Add(Me.btnGoBack)
        Me.GroupBox1.Controls.Add(Me.btnRefreshGrid)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GrpSearchforaStudent)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(612, 613)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(174, 550)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnrollByGrid
        '
        Me.btnEnrollByGrid.Location = New System.Drawing.Point(298, 550)
        Me.btnEnrollByGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnrollByGrid.Name = "btnEnrollByGrid"
        Me.btnEnrollByGrid.Size = New System.Drawing.Size(112, 30)
        Me.btnEnrollByGrid.TabIndex = 3
        Me.btnEnrollByGrid.Text = "E&nroll"
        Me.btnEnrollByGrid.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(50, 550)
        Me.btnGoBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(112, 30)
        Me.btnGoBack.TabIndex = 2
        Me.btnGoBack.Text = "&Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnRefreshGrid
        '
        Me.btnRefreshGrid.Location = New System.Drawing.Point(422, 550)
        Me.btnRefreshGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshGrid.Name = "btnRefreshGrid"
        Me.btnRefreshGrid.Size = New System.Drawing.Size(112, 30)
        Me.btnRefreshGrid.TabIndex = 4
        Me.btnRefreshGrid.Text = "&Refresh Grid"
        Me.btnRefreshGrid.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LearnerGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 334)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Show data"
        '
        'LearnerGrid
        '
        Me.LearnerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LearnerGrid.Location = New System.Drawing.Point(22, 37)
        Me.LearnerGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.LearnerGrid.Name = "LearnerGrid"
        Me.LearnerGrid.Size = New System.Drawing.Size(523, 271)
        Me.LearnerGrid.TabIndex = 0
        '
        'GrpSearchforaStudent
        '
        Me.GrpSearchforaStudent.Controls.Add(Me.txtPhone)
        Me.GrpSearchforaStudent.Controls.Add(Me.Label1)
        Me.GrpSearchforaStudent.Controls.Add(Me.btnEnroll)
        Me.GrpSearchforaStudent.Controls.Add(Me.btnSearch)
        Me.GrpSearchforaStudent.Controls.Add(Me.txtFirstName)
        Me.GrpSearchforaStudent.Controls.Add(Me.lblFirstName)
        Me.GrpSearchforaStudent.Location = New System.Drawing.Point(28, 32)
        Me.GrpSearchforaStudent.Name = "GrpSearchforaStudent"
        Me.GrpSearchforaStudent.Size = New System.Drawing.Size(564, 144)
        Me.GrpSearchforaStudent.TabIndex = 0
        Me.GrpSearchforaStudent.TabStop = False
        Me.GrpSearchforaStudent.Text = "Search For A Student To Enroll"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(354, 57)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(141, 26)
        Me.txtPhone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Phone:"
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(354, 98)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(90, 28)
        Me.btnEnroll.TabIndex = 5
        Me.btnEnroll.Text = "&Enroll "
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(101, 98)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(98, 57)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(141, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(41, 60)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(53, 19)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = " Name:"
        '
        'EnrollLearnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 659)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EnrollLearnerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving School - Enroll Learner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LearnerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSearchforaStudent.ResumeLayout(False)
        Me.GrpSearchforaStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LearnerGrid As DataGridView
    Friend WithEvents btnRefreshGrid As Button
    Friend WithEvents btnEnrollByGrid As Button
    Friend WithEvents btnGoBack As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GrpSearchforaStudent As GroupBox
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
End Class

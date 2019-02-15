<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProgressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProgressForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpUpdate = New System.Windows.Forms.GroupBox()
        Me.txtAmountsPaid = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.CombStatus = New System.Windows.Forms.ComboBox()
        Me.lblAmountsPaid = New System.Windows.Forms.Label()
        Me.lblUnitsTaken = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnUpdateStatus = New System.Windows.Forms.Button()
        Me.btnUpdateUnitsTaken = New System.Windows.Forms.Button()
        Me.btnUpdatePaid = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressGrid = New System.Windows.Forms.DataGridView()
        Me.GrpSøk = New System.Windows.Forms.GroupBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.btnRefreshGrid = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrpUpdate.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProgressGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSøk.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrpUpdate)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GrpSøk)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 625)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GrpUpdate
        '
        Me.GrpUpdate.Controls.Add(Me.txtAmountsPaid)
        Me.GrpUpdate.Controls.Add(Me.txtUnits)
        Me.GrpUpdate.Controls.Add(Me.CombStatus)
        Me.GrpUpdate.Controls.Add(Me.lblAmountsPaid)
        Me.GrpUpdate.Controls.Add(Me.lblUnitsTaken)
        Me.GrpUpdate.Controls.Add(Me.lblStatus)
        Me.GrpUpdate.Controls.Add(Me.btnUpdateStatus)
        Me.GrpUpdate.Controls.Add(Me.btnUpdateUnitsTaken)
        Me.GrpUpdate.Controls.Add(Me.btnUpdatePaid)
        Me.GrpUpdate.Location = New System.Drawing.Point(23, 448)
        Me.GrpUpdate.Name = "GrpUpdate"
        Me.GrpUpdate.Size = New System.Drawing.Size(498, 162)
        Me.GrpUpdate.TabIndex = 2
        Me.GrpUpdate.TabStop = False
        Me.GrpUpdate.Text = "What do you wish to update?"
        '
        'txtAmountsPaid
        '
        Me.txtAmountsPaid.Location = New System.Drawing.Point(116, 107)
        Me.txtAmountsPaid.Name = "txtAmountsPaid"
        Me.txtAmountsPaid.Size = New System.Drawing.Size(109, 26)
        Me.txtAmountsPaid.TabIndex = 7
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(116, 75)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(109, 26)
        Me.txtUnits.TabIndex = 4
        '
        'CombStatus
        '
        Me.CombStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombStatus.FormattingEnabled = True
        Me.CombStatus.Items.AddRange(New Object() {"Ongoing", "Compelete", "Not Done", "Waiting"})
        Me.CombStatus.Location = New System.Drawing.Point(116, 42)
        Me.CombStatus.Name = "CombStatus"
        Me.CombStatus.Size = New System.Drawing.Size(109, 27)
        Me.CombStatus.TabIndex = 1
        '
        'lblAmountsPaid
        '
        Me.lblAmountsPaid.AutoSize = True
        Me.lblAmountsPaid.Location = New System.Drawing.Point(19, 110)
        Me.lblAmountsPaid.Name = "lblAmountsPaid"
        Me.lblAmountsPaid.Size = New System.Drawing.Size(93, 19)
        Me.lblAmountsPaid.TabIndex = 6
        Me.lblAmountsPaid.Text = "AmountsPaid:"
        '
        'lblUnitsTaken
        '
        Me.lblUnitsTaken.AutoSize = True
        Me.lblUnitsTaken.Location = New System.Drawing.Point(28, 78)
        Me.lblUnitsTaken.Name = "lblUnitsTaken"
        Me.lblUnitsTaken.Size = New System.Drawing.Size(84, 19)
        Me.lblUnitsTaken.TabIndex = 3
        Me.lblUnitsTaken.Text = "Units Taken:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(63, 45)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 19)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status:"
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.Location = New System.Drawing.Point(239, 40)
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.Size = New System.Drawing.Size(130, 28)
        Me.btnUpdateStatus.TabIndex = 2
        Me.btnUpdateStatus.Text = "Update Status"
        Me.btnUpdateStatus.UseVisualStyleBackColor = True
        '
        'btnUpdateUnitsTaken
        '
        Me.btnUpdateUnitsTaken.Location = New System.Drawing.Point(240, 73)
        Me.btnUpdateUnitsTaken.Name = "btnUpdateUnitsTaken"
        Me.btnUpdateUnitsTaken.Size = New System.Drawing.Size(130, 28)
        Me.btnUpdateUnitsTaken.TabIndex = 5
        Me.btnUpdateUnitsTaken.Text = "Update Units Taken"
        Me.btnUpdateUnitsTaken.UseVisualStyleBackColor = True
        '
        'btnUpdatePaid
        '
        Me.btnUpdatePaid.Location = New System.Drawing.Point(240, 105)
        Me.btnUpdatePaid.Name = "btnUpdatePaid"
        Me.btnUpdatePaid.Size = New System.Drawing.Size(130, 28)
        Me.btnUpdatePaid.TabIndex = 8
        Me.btnUpdatePaid.Text = "Update Amount Paid"
        Me.btnUpdatePaid.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 292)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Show data"
        '
        'ProgressGrid
        '
        Me.ProgressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProgressGrid.Location = New System.Drawing.Point(15, 37)
        Me.ProgressGrid.Name = "ProgressGrid"
        Me.ProgressGrid.Size = New System.Drawing.Size(466, 239)
        Me.ProgressGrid.TabIndex = 0
        '
        'GrpSøk
        '
        Me.GrpSøk.Controls.Add(Me.txtCourseName)
        Me.GrpSøk.Controls.Add(Me.lblCourse)
        Me.GrpSøk.Controls.Add(Me.btnSearch)
        Me.GrpSøk.Controls.Add(Me.lblFirstName)
        Me.GrpSøk.Controls.Add(Me.txtFirstname)
        Me.GrpSøk.Location = New System.Drawing.Point(23, 17)
        Me.GrpSøk.Name = "GrpSøk"
        Me.GrpSøk.Size = New System.Drawing.Size(499, 136)
        Me.GrpSøk.TabIndex = 0
        Me.GrpSøk.TabStop = False
        Me.GrpSøk.Text = "Search for User"
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(113, 60)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(128, 26)
        Me.txtCourseName.TabIndex = 3
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(53, 63)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(56, 19)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(113, 93)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(60, 34)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(49, 19)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "Name:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(113, 31)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(128, 26)
        Me.txtFirstname.TabIndex = 1
        '
        'btnRefreshGrid
        '
        Me.btnRefreshGrid.Location = New System.Drawing.Point(449, 639)
        Me.btnRefreshGrid.Name = "btnRefreshGrid"
        Me.btnRefreshGrid.Size = New System.Drawing.Size(90, 28)
        Me.btnRefreshGrid.TabIndex = 1
        Me.btnRefreshGrid.Text = "&Refresh Grid"
        Me.btnRefreshGrid.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(257, 639)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(90, 28)
        Me.btnGoBack.TabIndex = 2
        Me.btnGoBack.Text = "&Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(353, 639)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 28)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'UpdateProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 673)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRefreshGrid)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateProgressForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving School - Update Progress"
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpUpdate.ResumeLayout(False)
        Me.GrpUpdate.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ProgressGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSøk.ResumeLayout(False)
        Me.GrpSøk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GrpSøk As GroupBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents GrpUpdate As GroupBox
    Friend WithEvents txtAmountsPaid As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents CombStatus As ComboBox
    Friend WithEvents lblAmountsPaid As Label
    Friend WithEvents lblUnitsTaken As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnUpdateUnitsTaken As Button
    Friend WithEvents btnUpdatePaid As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProgressGrid As DataGridView
    Friend WithEvents btnRefreshGrid As Button
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnClear As Button
End Class

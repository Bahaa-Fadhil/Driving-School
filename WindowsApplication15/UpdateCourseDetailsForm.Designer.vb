<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCourseDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateCourseDetailsForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.dtpOfferDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtMandatory = New System.Windows.Forms.TextBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.lblOfferDate = New System.Windows.Forms.Label()
        Me.lblMandatory = New System.Windows.Forms.Label()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.btnUpdateOfferDate = New System.Windows.Forms.Button()
        Me.btnUpdatePrice = New System.Windows.Forms.Button()
        Me.btnUpdateMandatory = New System.Windows.Forms.Button()
        Me.BtnUpdateCourse = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CourseGrid = New System.Windows.Forms.DataGridView()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CourseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(532, 548)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Updating"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPrice)
        Me.GroupBox3.Controls.Add(Me.dtpOfferDate)
        Me.GroupBox3.Controls.Add(Me.txtCourseID)
        Me.GroupBox3.Controls.Add(Me.lblCourseID)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.txtMandatory)
        Me.GroupBox3.Controls.Add(Me.txtCourseName)
        Me.GroupBox3.Controls.Add(Me.lblOfferDate)
        Me.GroupBox3.Controls.Add(Me.lblMandatory)
        Me.GroupBox3.Controls.Add(Me.lblCourseName)
        Me.GroupBox3.Controls.Add(Me.btnUpdateOfferDate)
        Me.GroupBox3.Controls.Add(Me.btnUpdatePrice)
        Me.GroupBox3.Controls.Add(Me.btnUpdateMandatory)
        Me.GroupBox3.Controls.Add(Me.BtnUpdateCourse)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 206)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Updating by using ID"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(66, 130)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(43, 19)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price:"
        '
        'dtpOfferDate
        '
        Me.dtpOfferDate.Location = New System.Drawing.Point(113, 158)
        Me.dtpOfferDate.Name = "dtpOfferDate"
        Me.dtpOfferDate.Size = New System.Drawing.Size(137, 26)
        Me.dtpOfferDate.TabIndex = 9
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(113, 34)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(59, 26)
        Me.txtCourseID.TabIndex = 1
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Location = New System.Drawing.Point(34, 37)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(76, 19)
        Me.lblCourseID.TabIndex = 0
        Me.lblCourseID.Text = "Course ID:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(113, 127)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(137, 26)
        Me.txtPrice.TabIndex = 7
        '
        'txtMandatory
        '
        Me.txtMandatory.Location = New System.Drawing.Point(113, 96)
        Me.txtMandatory.Name = "txtMandatory"
        Me.txtMandatory.Size = New System.Drawing.Size(137, 26)
        Me.txtMandatory.TabIndex = 5
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(113, 65)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(137, 26)
        Me.txtCourseName.TabIndex = 3
        '
        'lblOfferDate
        '
        Me.lblOfferDate.AutoSize = True
        Me.lblOfferDate.Location = New System.Drawing.Point(32, 162)
        Me.lblOfferDate.Name = "lblOfferDate"
        Me.lblOfferDate.Size = New System.Drawing.Size(77, 19)
        Me.lblOfferDate.TabIndex = 8
        Me.lblOfferDate.Text = "Offer Date:"
        '
        'lblMandatory
        '
        Me.lblMandatory.AutoSize = True
        Me.lblMandatory.Location = New System.Drawing.Point(30, 99)
        Me.lblMandatory.Name = "lblMandatory"
        Me.lblMandatory.Size = New System.Drawing.Size(79, 19)
        Me.lblMandatory.TabIndex = 4
        Me.lblMandatory.Text = "Mandatory:"
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Location = New System.Drawing.Point(12, 68)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(97, 19)
        Me.lblCourseName.TabIndex = 2
        Me.lblCourseName.Text = "Course Name:"
        '
        'btnUpdateOfferDate
        '
        Me.btnUpdateOfferDate.Location = New System.Drawing.Point(314, 153)
        Me.btnUpdateOfferDate.Name = "btnUpdateOfferDate"
        Me.btnUpdateOfferDate.Size = New System.Drawing.Size(135, 28)
        Me.btnUpdateOfferDate.TabIndex = 13
        Me.btnUpdateOfferDate.Text = "Update Offer Date"
        Me.btnUpdateOfferDate.UseVisualStyleBackColor = True
        '
        'btnUpdatePrice
        '
        Me.btnUpdatePrice.Location = New System.Drawing.Point(314, 121)
        Me.btnUpdatePrice.Name = "btnUpdatePrice"
        Me.btnUpdatePrice.Size = New System.Drawing.Size(135, 28)
        Me.btnUpdatePrice.TabIndex = 12
        Me.btnUpdatePrice.Text = "Update Price"
        Me.btnUpdatePrice.UseVisualStyleBackColor = True
        '
        'btnUpdateMandatory
        '
        Me.btnUpdateMandatory.Location = New System.Drawing.Point(314, 90)
        Me.btnUpdateMandatory.Name = "btnUpdateMandatory"
        Me.btnUpdateMandatory.Size = New System.Drawing.Size(135, 28)
        Me.btnUpdateMandatory.TabIndex = 11
        Me.btnUpdateMandatory.Text = "Update Mandatory"
        Me.btnUpdateMandatory.UseVisualStyleBackColor = True
        '
        'BtnUpdateCourse
        '
        Me.BtnUpdateCourse.Location = New System.Drawing.Point(314, 59)
        Me.BtnUpdateCourse.Name = "BtnUpdateCourse"
        Me.BtnUpdateCourse.Size = New System.Drawing.Size(135, 28)
        Me.BtnUpdateCourse.TabIndex = 10
        Me.BtnUpdateCourse.Text = "Update Course"
        Me.BtnUpdateCourse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CourseGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 288)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Show data"
        '
        'CourseGrid
        '
        Me.CourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseGrid.Location = New System.Drawing.Point(12, 28)
        Me.CourseGrid.Name = "CourseGrid"
        Me.CourseGrid.Size = New System.Drawing.Size(476, 242)
        Me.CourseGrid.TabIndex = 0
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(392, 584)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(90, 28)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "&Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'UpdateCourseDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 622)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateCourseDetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving School - Update Course"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CourseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents dtpOfferDate As DateTimePicker
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents lblCourseID As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtMandatory As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lblOfferDate As Label
    Friend WithEvents lblMandatory As Label
    Friend WithEvents lblCourseName As Label
    Friend WithEvents btnUpdateOfferDate As Button
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents btnUpdateMandatory As Button
    Friend WithEvents BtnUpdateCourse As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CourseGrid As DataGridView
    Friend WithEvents btnGoBack As Button
End Class

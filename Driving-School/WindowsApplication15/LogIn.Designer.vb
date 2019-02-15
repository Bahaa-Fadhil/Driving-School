<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblSatusBeskrivelse = New System.Windows.Forms.Label()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.btnLoggin = New System.Windows.Forms.Button()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbRole
        '
        Me.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"Learner", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(104, 27)
        Me.cbRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(180, 27)
        Me.cbRole.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 326)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Register "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(215, 162)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(104, 102)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(243, 52)
        Me.txtStatus.TabIndex = 5
        Me.txtStatus.Visible = False
        '
        'lblSatusBeskrivelse
        '
        Me.lblSatusBeskrivelse.Location = New System.Drawing.Point(50, 110)
        Me.lblSatusBeskrivelse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSatusBeskrivelse.Name = "lblSatusBeskrivelse"
        Me.lblSatusBeskrivelse.Size = New System.Drawing.Size(50, 27)
        Me.lblSatusBeskrivelse.TabIndex = 4
        Me.lblSatusBeskrivelse.Text = "Status:"
        Me.lblSatusBeskrivelse.Visible = False
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(105, 68)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(243, 26)
        Me.txtPassord.TabIndex = 3
        '
        'lblPassord
        '
        Me.lblPassord.Location = New System.Drawing.Point(28, 71)
        Me.lblPassord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(73, 23)
        Me.lblPassord.TabIndex = 2
        Me.lblPassord.Text = "Password:"
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.Location = New System.Drawing.Point(24, 35)
        Me.lblBrukernavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(82, 25)
        Me.lblBrukernavn.TabIndex = 0
        Me.lblBrukernavn.Text = "Username:"
        '
        'btnLoggin
        '
        Me.btnLoggin.Enabled = False
        Me.btnLoggin.Location = New System.Drawing.Point(117, 162)
        Me.btnLoggin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoggin.Name = "btnLoggin"
        Me.btnLoggin.Size = New System.Drawing.Size(90, 30)
        Me.btnLoggin.TabIndex = 6
        Me.btnLoggin.Text = "&Login"
        Me.btnLoggin.UseVisualStyleBackColor = True
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(106, 34)
        Me.txtBrukernavn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(243, 26)
        Me.txtBrukernavn.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 326)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(50, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Role:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbRole)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Role"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.lblSatusBeskrivelse)
        Me.GroupBox2.Controls.Add(Me.txtPassord)
        Me.GroupBox2.Controls.Add(Me.lblPassord)
        Me.GroupBox2.Controls.Add(Me.lblBrukernavn)
        Me.GroupBox2.Controls.Add(Me.btnLoggin)
        Me.GroupBox2.Controls.Add(Me.txtBrukernavn)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 214)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 365)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving School - Log In"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblSatusBeskrivelse As Label
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents lblPassord As Label
    Friend WithEvents lblBrukernavn As Label
    Friend WithEvents btnLoggin As Button
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRequirements
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ck1 = New System.Windows.Forms.CheckBox()
        Me.ck5 = New System.Windows.Forms.CheckBox()
        Me.ck2 = New System.Windows.Forms.CheckBox()
        Me.ck3 = New System.Windows.Forms.CheckBox()
        Me.ck6 = New System.Windows.Forms.CheckBox()
        Me.btnSelectStudent = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ck9 = New System.Windows.Forms.CheckBox()
        Me.ck8 = New System.Windows.Forms.CheckBox()
        Me.ck7 = New System.Windows.Forms.CheckBox()
        Me.ck4 = New System.Windows.Forms.CheckBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ck1
        '
        Me.ck1.AutoSize = True
        Me.ck1.Location = New System.Drawing.Point(24, 44)
        Me.ck1.Name = "ck1"
        Me.ck1.Size = New System.Drawing.Size(117, 20)
        Me.ck1.TabIndex = 0
        Me.ck1.Text = "Application Form"
        Me.ck1.UseVisualStyleBackColor = True
        '
        'ck5
        '
        Me.ck5.AutoSize = True
        Me.ck5.Location = New System.Drawing.Point(203, 80)
        Me.ck5.Name = "ck5"
        Me.ck5.Size = New System.Drawing.Size(203, 20)
        Me.ck5.TabIndex = 0
        Me.ck5.Text = "(Photocopy) Transcript of records"
        Me.ck5.UseVisualStyleBackColor = True
        '
        'ck2
        '
        Me.ck2.AutoSize = True
        Me.ck2.Location = New System.Drawing.Point(24, 80)
        Me.ck2.Name = "ck2"
        Me.ck2.Size = New System.Drawing.Size(175, 20)
        Me.ck2.TabIndex = 0
        Me.ck2.Text = "(Photocopy) Birth certificate"
        Me.ck2.UseVisualStyleBackColor = True
        '
        'ck3
        '
        Me.ck3.AutoSize = True
        Me.ck3.Location = New System.Drawing.Point(24, 117)
        Me.ck3.Name = "ck3"
        Me.ck3.Size = New System.Drawing.Size(159, 20)
        Me.ck3.TabIndex = 0
        Me.ck3.Text = "(Original) Birth certificate"
        Me.ck3.UseVisualStyleBackColor = True
        '
        'ck6
        '
        Me.ck6.AutoSize = True
        Me.ck6.Location = New System.Drawing.Point(203, 117)
        Me.ck6.Name = "ck6"
        Me.ck6.Size = New System.Drawing.Size(187, 20)
        Me.ck6.TabIndex = 0
        Me.ck6.Text = "(Original) Transcript of records"
        Me.ck6.UseVisualStyleBackColor = True
        '
        'btnSelectStudent
        '
        Me.btnSelectStudent.Location = New System.Drawing.Point(45, 251)
        Me.btnSelectStudent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSelectStudent.Name = "btnSelectStudent"
        Me.btnSelectStudent.Size = New System.Drawing.Size(223, 30)
        Me.btnSelectStudent.TabIndex = 32
        Me.btnSelectStudent.Text = "Select Student"
        Me.btnSelectStudent.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(529, 28)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 31
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(682, 32)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 33)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(527, 45)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(151, 20)
        Me.txtSearch.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 47)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Student List"
        '
        'dgvStudentList
        '
        Me.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Location = New System.Drawing.Point(324, 73)
        Me.dgvStudentList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.RowHeadersWidth = 51
        Me.dgvStudentList.RowTemplate.Height = 24
        Me.dgvStudentList.Size = New System.Drawing.Size(436, 208)
        Me.dgvStudentList.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(223, 172)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Student Information"
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCourse.Location = New System.Drawing.Point(93, 122)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(102, 15)
        Me.txtCourse.TabIndex = 17
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Location = New System.Drawing.Point(93, 95)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(102, 15)
        Me.txtLastName.TabIndex = 16
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Location = New System.Drawing.Point(93, 67)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(102, 15)
        Me.txtFirstName.TabIndex = 15
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.Location = New System.Drawing.Point(93, 39)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(102, 15)
        Me.txtStudentID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Requirements Verification"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ck9)
        Me.GroupBox2.Controls.Add(Me.ck8)
        Me.GroupBox2.Controls.Add(Me.ck7)
        Me.GroupBox2.Controls.Add(Me.ck4)
        Me.GroupBox2.Controls.Add(Me.ck3)
        Me.GroupBox2.Controls.Add(Me.ck1)
        Me.GroupBox2.Controls.Add(Me.ck5)
        Me.GroupBox2.Controls.Add(Me.ck2)
        Me.GroupBox2.Controls.Add(Me.ck6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(45, 337)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(553, 173)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Requirements"
        '
        'ck9
        '
        Me.ck9.AutoSize = True
        Me.ck9.Location = New System.Drawing.Point(411, 117)
        Me.ck9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ck9.Name = "ck9"
        Me.ck9.Size = New System.Drawing.Size(124, 20)
        Me.ck9.TabIndex = 4
        Me.ck9.Text = "Payment of tuition"
        Me.ck9.UseVisualStyleBackColor = True
        '
        'ck8
        '
        Me.ck8.AutoSize = True
        Me.ck8.Location = New System.Drawing.Point(411, 80)
        Me.ck8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ck8.Name = "ck8"
        Me.ck8.Size = New System.Drawing.Size(98, 20)
        Me.ck8.TabIndex = 3
        Me.ck8.Text = "2x2 ID picture"
        Me.ck8.UseVisualStyleBackColor = True
        '
        'ck7
        '
        Me.ck7.AutoSize = True
        Me.ck7.Location = New System.Drawing.Point(411, 44)
        Me.ck7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ck7.Name = "ck7"
        Me.ck7.Size = New System.Drawing.Size(123, 20)
        Me.ck7.TabIndex = 2
        Me.ck7.Text = "Medical certificate"
        Me.ck7.UseVisualStyleBackColor = True
        '
        'ck4
        '
        Me.ck4.AutoSize = True
        Me.ck4.Location = New System.Drawing.Point(203, 44)
        Me.ck4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ck4.Name = "ck4"
        Me.ck4.Size = New System.Drawing.Size(159, 20)
        Me.ck4.TabIndex = 1
        Me.ck4.Text = "Certificate of Good Moral"
        Me.ck4.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.Location = New System.Drawing.Point(651, 477)
        Me.btnVerify.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(85, 33)
        Me.btnVerify.TabIndex = 34
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 287)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Visible = False
        '
        'FrmRequirements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 570)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSelectStudent)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRequirements"
        Me.Text = "FrmRequirements"
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ck1 As CheckBox
    Friend WithEvents ck5 As CheckBox
    Friend WithEvents ck2 As CheckBox
    Friend WithEvents ck3 As CheckBox
    Friend WithEvents ck6 As CheckBox
    Friend WithEvents btnSelectStudent As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ck9 As CheckBox
    Friend WithEvents ck8 As CheckBox
    Friend WithEvents ck7 As CheckBox
    Friend WithEvents ck4 As CheckBox
    Friend WithEvents btnVerify As Button
    Friend WithEvents Label6 As Label
End Class

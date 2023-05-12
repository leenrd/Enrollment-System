<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjects
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbIrregAdd = New System.Windows.Forms.ComboBox()
        Me.btnRemSub = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvSubjectSet = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSelectStudent = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSubjectSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Subject Adding/Dropping"
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
        Me.GroupBox1.Location = New System.Drawing.Point(68, 87)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 212)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Student Information"
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCourse.Location = New System.Drawing.Point(124, 150)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(136, 15)
        Me.txtCourse.TabIndex = 17
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Location = New System.Drawing.Point(124, 117)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(136, 15)
        Me.txtLastName.TabIndex = 16
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Location = New System.Drawing.Point(124, 82)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(136, 15)
        Me.txtFirstName.TabIndex = 15
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.Location = New System.Drawing.Point(124, 48)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(136, 15)
        Me.txtStudentID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Student ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'dgvStudentList
        '
        Me.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Location = New System.Drawing.Point(440, 87)
        Me.dgvStudentList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.RowHeadersWidth = 51
        Me.dgvStudentList.RowTemplate.Height = 24
        Me.dgvStudentList.Size = New System.Drawing.Size(581, 212)
        Me.dgvStudentList.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.cmbIrregAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(68, 414)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(297, 121)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "*for irregulars"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(189, 21)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 34)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbIrregAdd
        '
        Me.cmbIrregAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIrregAdd.FormattingEnabled = True
        Me.cmbIrregAdd.Location = New System.Drawing.Point(21, 71)
        Me.cmbIrregAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIrregAdd.Name = "cmbIrregAdd"
        Me.cmbIrregAdd.Size = New System.Drawing.Size(252, 24)
        Me.cmbIrregAdd.TabIndex = 0
        '
        'btnRemSub
        '
        Me.btnRemSub.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemSub.Location = New System.Drawing.Point(211, 548)
        Me.btnRemSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemSub.Name = "btnRemSub"
        Me.btnRemSub.Size = New System.Drawing.Size(155, 34)
        Me.btnRemSub.TabIndex = 14
        Me.btnRemSub.Text = "Drop"
        Me.btnRemSub.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(68, 548)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(137, 34)
        Me.btnClearAll.TabIndex = 13
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(68, 588)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(297, 46)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvSubjectSet
        '
        Me.dgvSubjectSet.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSubjectSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectSet.Location = New System.Drawing.Point(440, 375)
        Me.dgvSubjectSet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvSubjectSet.Name = "dgvSubjectSet"
        Me.dgvSubjectSet.RowHeadersWidth = 51
        Me.dgvSubjectSet.RowTemplate.Height = 24
        Me.dgvSubjectSet.Size = New System.Drawing.Size(581, 258)
        Me.dgvSubjectSet.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Subject Set"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Student List"
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(711, 52)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(917, 37)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(713, 32)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 23
        '
        'btnSelectStudent
        '
        Me.btnSelectStudent.Location = New System.Drawing.Point(68, 306)
        Me.btnSelectStudent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectStudent.Name = "btnSelectStudent"
        Me.btnSelectStudent.Size = New System.Drawing.Size(297, 37)
        Me.btnSelectStudent.TabIndex = 24
        Me.btnSelectStudent.Text = "Select Student"
        Me.btnSelectStudent.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Add/Drop"
        '
        'frmSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 674)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSelectStudent)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvSubjectSet)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRemSub)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSubjects"
        Me.Text = "frmSubjects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSubjectSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbIrregAdd As ComboBox
    Friend WithEvents btnRemSub As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvSubjectSet As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnSelectStudent As Button
    Friend WithEvents Label6 As Label
End Class

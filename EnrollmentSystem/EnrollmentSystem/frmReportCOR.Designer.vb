<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCOR
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSelectStudent = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRegno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(46, 477)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(297, 52)
        Me.btnPrint.TabIndex = 45
        Me.btnPrint.Text = "Print COR"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSelectStudent
        '
        Me.btnSelectStudent.Location = New System.Drawing.Point(44, 377)
        Me.btnSelectStudent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectStudent.Name = "btnSelectStudent"
        Me.btnSelectStudent.Size = New System.Drawing.Size(297, 37)
        Me.btnSelectStudent.TabIndex = 44
        Me.btnSelectStudent.Text = "Select Student"
        Me.btnSelectStudent.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(689, 34)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 43
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(893, 39)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 42
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(687, 54)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(409, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 42)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Student List"
        '
        'dgvStudentList
        '
        Me.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Location = New System.Drawing.Point(416, 89)
        Me.dgvStudentList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.RowHeadersWidth = 51
        Me.dgvStudentList.RowTemplate.Height = 24
        Me.dgvStudentList.Size = New System.Drawing.Size(581, 440)
        Me.dgvStudentList.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRegno)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 276)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Student Information"
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Location = New System.Drawing.Point(124, 213)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(136, 15)
        Me.txtStatus.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Status"
        '
        'txtRegno
        '
        Me.txtRegno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegno.Location = New System.Drawing.Point(124, 180)
        Me.txtRegno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegno.Name = "txtRegno"
        Me.txtRegno.Size = New System.Drawing.Size(136, 15)
        Me.txtRegno.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Reg no."
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 42)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "COR Printing"
        '
        'frmReportCOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1041, 582)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSelectStudent)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportCOR"
        Me.Text = "frmReportCOR"
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSelectStudent As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRegno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

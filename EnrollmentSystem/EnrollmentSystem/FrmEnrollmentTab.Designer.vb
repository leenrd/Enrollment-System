<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnrollmentTab
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DTPBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.cbStudentType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.cbEnrollmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.cbSY = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(625, 454)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(416, 62)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add Student"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(625, 534)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(211, 38)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.DTPBirth)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbSex)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(592, 203)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(211, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(25, 57)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(164, 26)
        Me.txtFirstName.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(211, 106)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 19)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Phone Number"
        '
        'DTPBirth
        '
        Me.DTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPBirth.Location = New System.Drawing.Point(395, 129)
        Me.DTPBirth.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPBirth.Name = "DTPBirth"
        Me.DTPBirth.Size = New System.Drawing.Size(164, 26)
        Me.DTPBirth.TabIndex = 26
        Me.DTPBirth.Value = New Date(2023, 4, 18, 16, 17, 32, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(391, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 19)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Birthdate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(21, 106)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Sex"
        '
        'cbSex
        '
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbSex.Location = New System.Drawing.Point(25, 127)
        Me.cbSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(164, 28)
        Me.cbSex.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(391, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(213, 129)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(164, 26)
        Me.txtPhone.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(213, 57)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(164, 26)
        Me.txtLastName.TabIndex = 4
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(395, 57)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(164, 26)
        Me.txtMiddleName.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtHouseNo)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtStreet)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtBarangay)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtZipCode)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 370)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(592, 202)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Address"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(21, 39)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 19)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "House No."
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(25, 60)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(164, 26)
        Me.txtHouseNo.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(211, 39)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 19)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Street"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(213, 60)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(164, 26)
        Me.txtStreet.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(391, 39)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 19)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Barangay"
        '
        'txtBarangay
        '
        Me.txtBarangay.Location = New System.Drawing.Point(395, 60)
        Me.txtBarangay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(164, 26)
        Me.txtBarangay.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(21, 95)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 19)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(25, 116)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(164, 26)
        Me.txtCity.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(211, 95)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 19)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Postal Code"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(213, 116)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(164, 26)
        Me.txtZipCode.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtRegNum)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbCourse)
        Me.GroupBox3.Controls.Add(Me.cbStudentType)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbSection)
        Me.GroupBox3.Controls.Add(Me.cbEnrollmentStatus)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbSemester)
        Me.GroupBox3.Controls.Add(Me.cbSY)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(623, 150)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(416, 288)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Student Credentials"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration No"
        '
        'txtRegNum
        '
        Me.txtRegNum.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.txtRegNum.Enabled = False
        Me.txtRegNum.Location = New System.Drawing.Point(33, 57)
        Me.txtRegNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegNum.Name = "txtRegNum"
        Me.txtRegNum.ReadOnly = True
        Me.txtRegNum.Size = New System.Drawing.Size(164, 26)
        Me.txtRegNum.TabIndex = 0
        Me.txtRegNum.Text = "1000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(216, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Course"
        '
        'cbCourse
        '
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSTM", "BSHM", "BSCE"})
        Me.cbCourse.Location = New System.Drawing.Point(219, 57)
        Me.cbCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(164, 28)
        Me.cbCourse.TabIndex = 10
        '
        'cbStudentType
        '
        Me.cbStudentType.FormattingEnabled = True
        Me.cbStudentType.Items.AddRange(New Object() {"New", "Old", "Regular", "Irregular", "Transferee", "Graduating"})
        Me.cbStudentType.Location = New System.Drawing.Point(33, 226)
        Me.cbStudentType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStudentType.Name = "cbStudentType"
        Me.cbStudentType.Size = New System.Drawing.Size(164, 28)
        Me.cbStudentType.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(29, 206)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Student Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(29, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Section"
        '
        'cbSection
        '
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Items.AddRange(New Object() {"SECTION ONE", "SECTION TWO", "SECTION THREE", "SECTION FOUR", "SECTION FIVE"})
        Me.cbSection.Location = New System.Drawing.Point(33, 112)
        Me.cbSection.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(164, 28)
        Me.cbSection.TabIndex = 8
        '
        'cbEnrollmentStatus
        '
        Me.cbEnrollmentStatus.FormattingEnabled = True
        Me.cbEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Partially Enrolled", "Reserved"})
        Me.cbEnrollmentStatus.Location = New System.Drawing.Point(219, 166)
        Me.cbEnrollmentStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEnrollmentStatus.Name = "cbEnrollmentStatus"
        Me.cbEnrollmentStatus.Size = New System.Drawing.Size(164, 28)
        Me.cbEnrollmentStatus.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(216, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "School Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(216, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "EnrollmentStatus"
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Items.AddRange(New Object() {"First Semester", "Second Semester"})
        Me.cbSemester.Location = New System.Drawing.Point(33, 166)
        Me.cbSemester.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(164, 28)
        Me.cbSemester.TabIndex = 19
        '
        'cbSY
        '
        Me.cbSY.FormattingEnabled = True
        Me.cbSY.Items.AddRange(New Object() {"2022-2023", "2023-2024"})
        Me.cbSY.Location = New System.Drawing.Point(219, 112)
        Me.cbSY.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSY.Name = "cbSY"
        Me.cbSY.Size = New System.Drawing.Size(164, 28)
        Me.cbSY.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(29, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Semester"
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(843, 534)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(197, 38)
        Me.btnClearAll.TabIndex = 30
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 107)
        Me.Panel1.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(43, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 42)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Enrollment Form"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.btnClearAll)
        Me.Guna2Panel1.Controls.Add(Me.GroupBox3)
        Me.Guna2Panel1.Controls.Add(Me.GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1065, 674)
        Me.Guna2Panel1.TabIndex = 27
        '
        'FrmEnrollmentTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 674)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEnrollmentTab"
        Me.Text = "2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DTPBirth As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBarangay As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents cbStudentType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents cbEnrollmentStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents cbSY As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class

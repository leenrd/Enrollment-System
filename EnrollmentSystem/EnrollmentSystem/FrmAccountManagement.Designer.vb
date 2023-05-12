<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccountManagement
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
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbAccountType = New System.Windows.Forms.ComboBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAcctype = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVAccounts = New System.Windows.Forms.DataGridView()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.AcceptsReturn = True
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(147, 159)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(160, 26)
        Me.txtPass.TabIndex = 1
        '
        'cbStatus
        '
        Me.cbStatus.Enabled = False
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Active ", "Inactive"})
        Me.cbStatus.Location = New System.Drawing.Point(147, 245)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(160, 28)
        Me.cbStatus.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(147, 70)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 26)
        Me.txtID.TabIndex = 1
        '
        'cbAccountType
        '
        Me.cbAccountType.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Admission", "Registrar"})
        Me.cbAccountType.Enabled = False
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Items.AddRange(New Object() {"Admin", "Admission", "Registrar"})
        Me.cbAccountType.Location = New System.Drawing.Point(147, 201)
        Me.cbAccountType.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.Size = New System.Drawing.Size(160, 28)
        Me.cbAccountType.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(147, 114)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(160, 26)
        Me.txtUser.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(74, 254)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 19)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status"
        '
        'lblAcctype
        '
        Me.lblAcctype.AutoSize = True
        Me.lblAcctype.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAcctype.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctype.Location = New System.Drawing.Point(26, 205)
        Me.lblAcctype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAcctype.Name = "lblAcctype"
        Me.lblAcctype.Size = New System.Drawing.Size(101, 19)
        Me.lblAcctype.TabIndex = 0
        Me.lblAcctype.Text = "AccountType"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPass.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(51, 166)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(76, 19)
        Me.lblPass.TabIndex = 0
        Me.lblPass.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblID.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(106, 74)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(25, 19)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblPass)
        Me.GroupBox1.Controls.Add(Me.lblAcctype)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.cbAccountType)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 313)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'DGVAccounts
        '
        Me.DGVAccounts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAccounts.Location = New System.Drawing.Point(404, 85)
        Me.DGVAccounts.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVAccounts.Name = "DGVAccounts"
        Me.DGVAccounts.RowHeadersWidth = 51
        Me.DGVAccounts.Size = New System.Drawing.Size(655, 405)
        Me.DGVAccounts.TabIndex = 3
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(779, 32)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 46
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(983, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 45
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(777, 52)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Account List"
        '
        'IconButton3
        '
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 20
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.Location = New System.Drawing.Point(24, 375)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(115, 49)
        Me.IconButton3.TabIndex = 50
        Me.IconButton3.Text = "Create"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(265, 375)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(115, 49)
        Me.IconButton2.TabIndex = 49
        Me.IconButton2.Text = "Update"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(144, 376)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(115, 49)
        Me.IconButton1.TabIndex = 48
        Me.IconButton1.Text = "Edit"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(24, 443)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(356, 48)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Create Account"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmAccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1092, 524)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVAccounts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAccountManagement"
        Me.Text = "FrmAccountManagement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbAccountType As ComboBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblAcctype As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVAccounts As DataGridView
    Friend WithEvents lblError As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
End Class

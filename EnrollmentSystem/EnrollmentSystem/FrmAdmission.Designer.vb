<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmission))
        Me.pnlAdmission = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlAdmission.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAdmission
        '
        Me.pnlAdmission.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAdmission.Controls.Add(Me.Label1)
        Me.pnlAdmission.Controls.Add(Me.PictureBox1)
        Me.pnlAdmission.Location = New System.Drawing.Point(312, 32)
        Me.pnlAdmission.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAdmission.Name = "pnlAdmission"
        Me.pnlAdmission.Size = New System.Drawing.Size(1065, 674)
        Me.pnlAdmission.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IconButton5)
        Me.GroupBox1.Controls.Add(Me.IconButton6)
        Me.GroupBox1.Controls.Add(Me.IconButton4)
        Me.GroupBox1.Controls.Add(Me.IconButton7)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 307)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sections"
        '
        'IconButton5
        '
        Me.IconButton5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Paperclip
        Me.IconButton5.IconColor = System.Drawing.Color.Black
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton5.Location = New System.Drawing.Point(19, 162)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(188, 60)
        Me.IconButton5.TabIndex = 13
        Me.IconButton5.Text = "Reports"
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.IconButton6.IconColor = System.Drawing.Color.Black
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 35
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton6.Location = New System.Drawing.Point(19, 96)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Size = New System.Drawing.Size(188, 60)
        Me.IconButton6.TabIndex = 12
        Me.IconButton6.Text = "Students"
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton7
        '
        Me.IconButton7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.Pager
        Me.IconButton7.IconColor = System.Drawing.Color.Black
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 35
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton7.Location = New System.Drawing.Point(19, 27)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(188, 60)
        Me.IconButton7.TabIndex = 11
        Me.IconButton7.Text = "Inquiries"
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = True
        '
        'IconButton8
        '
        Me.IconButton8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton8.ForeColor = System.Drawing.Color.Red
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        Me.IconButton8.IconColor = System.Drawing.Color.Red
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.IconSize = 20
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton8.Location = New System.Drawing.Point(60, 674)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Size = New System.Drawing.Size(163, 33)
        Me.IconButton8.TabIndex = 11
        Me.IconButton8.Text = "Log out"
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton8.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Controls.Add(Me.GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.IconButton8)
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(304, 762)
        Me.Guna2Panel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(60, 33)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'IconButton4
        '
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton4.Location = New System.Drawing.Point(19, 229)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(188, 63)
        Me.IconButton4.TabIndex = 6
        Me.IconButton4.Text = "Requirements"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.Panel1.Location = New System.Drawing.Point(280, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 804)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(421, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Click sections to see panel..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(330, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1386, 741)
        Me.Controls.Add(Me.pnlAdmission)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.pnlAdmission.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdmission As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

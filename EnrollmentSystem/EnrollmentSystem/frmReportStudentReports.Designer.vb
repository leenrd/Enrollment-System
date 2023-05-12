<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportStudentReports
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
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnrolled = New System.Windows.Forms.Button()
        Me.btnParEn = New System.Windows.Forms.Button()
        Me.btnReserved = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Location = New System.Drawing.Point(300, 263)
        Me.lblEmpty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(166, 13)
        Me.lblEmpty.TabIndex = 45
        Me.lblEmpty.Text = "Select Student Status to see list..."
        '
        'dgvReports
        '
        Me.dgvReports.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(9, 51)
        Me.dgvReports.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.RowTemplate.Height = 24
        Me.dgvReports.Size = New System.Drawing.Size(760, 412)
        Me.dgvReports.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Students List"
        '
        'btnEnrolled
        '
        Me.btnEnrolled.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnrolled.FlatAppearance.BorderSize = 0
        Me.btnEnrolled.Location = New System.Drawing.Point(218, 10)
        Me.btnEnrolled.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnrolled.Name = "btnEnrolled"
        Me.btnEnrolled.Size = New System.Drawing.Size(97, 34)
        Me.btnEnrolled.TabIndex = 47
        Me.btnEnrolled.Text = "Enrolled"
        Me.btnEnrolled.UseVisualStyleBackColor = True
        '
        'btnParEn
        '
        Me.btnParEn.Location = New System.Drawing.Point(319, 10)
        Me.btnParEn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnParEn.Name = "btnParEn"
        Me.btnParEn.Size = New System.Drawing.Size(110, 34)
        Me.btnParEn.TabIndex = 48
        Me.btnParEn.Text = "Partially Enrolled"
        Me.btnParEn.UseVisualStyleBackColor = True
        '
        'btnReserved
        '
        Me.btnReserved.Location = New System.Drawing.Point(433, 10)
        Me.btnReserved.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReserved.Name = "btnReserved"
        Me.btnReserved.Size = New System.Drawing.Size(97, 34)
        Me.btnReserved.TabIndex = 49
        Me.btnReserved.Text = "Reserved"
        Me.btnReserved.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(682, 7)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(87, 40)
        Me.IconButton1.TabIndex = 50
        Me.IconButton1.Text = "Print"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'frmReportStudentReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(781, 473)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.btnReserved)
        Me.Controls.Add(Me.btnParEn)
        Me.Controls.Add(Me.btnEnrolled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.dgvReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReportStudentReports"
        Me.Text = "frmReportStudentReports"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmpty As Label
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnrolled As Button
    Friend WithEvents btnParEn As Button
    Friend WithEvents btnReserved As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class

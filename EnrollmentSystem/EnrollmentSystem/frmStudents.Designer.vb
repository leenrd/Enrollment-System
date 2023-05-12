<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnParEn = New System.Windows.Forms.Button()
        Me.btnReserved = New System.Windows.Forms.Button()
        Me.btnEnrolled = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.gbLegend = New System.Windows.Forms.GroupBox()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(760, 44)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 35
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(964, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(758, 64)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(758, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Select student status to trigger search..."
        '
        'btnParEn
        '
        Me.btnParEn.Location = New System.Drawing.Point(438, 21)
        Me.btnParEn.Name = "btnParEn"
        Me.btnParEn.Size = New System.Drawing.Size(146, 42)
        Me.btnParEn.TabIndex = 31
        Me.btnParEn.Text = "Partially Enrolled"
        Me.btnParEn.UseVisualStyleBackColor = True
        '
        'btnReserved
        '
        Me.btnReserved.Location = New System.Drawing.Point(590, 21)
        Me.btnReserved.Name = "btnReserved"
        Me.btnReserved.Size = New System.Drawing.Size(129, 42)
        Me.btnReserved.TabIndex = 30
        Me.btnReserved.Text = "Reserved"
        Me.btnReserved.UseVisualStyleBackColor = True
        '
        'btnEnrolled
        '
        Me.btnEnrolled.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnrolled.FlatAppearance.BorderSize = 0
        Me.btnEnrolled.Location = New System.Drawing.Point(303, 21)
        Me.btnEnrolled.Name = "btnEnrolled"
        Me.btnEnrolled.Size = New System.Drawing.Size(129, 42)
        Me.btnEnrolled.TabIndex = 29
        Me.btnEnrolled.Text = "Enrolled"
        Me.btnEnrolled.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Students List"
        '
        'dgvReports
        '
        Me.dgvReports.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(26, 130)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.RowTemplate.Height = 24
        Me.dgvReports.Size = New System.Drawing.Size(1013, 524)
        Me.dgvReports.TabIndex = 27
        '
        'btnAll
        '
        Me.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.Location = New System.Drawing.Point(223, 20)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(74, 42)
        Me.btnAll.TabIndex = 36
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(21, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 22)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(291, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 22)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Location = New System.Drawing.Point(123, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(24, 22)
        Me.Panel3.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Enrolled"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Partially Enrolled"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Reserved"
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Location = New System.Drawing.Point(416, 386)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(220, 17)
        Me.lblEmpty.TabIndex = 43
        Me.lblEmpty.Text = "Select Student Status to see list..."
        '
        'gbLegend
        '
        Me.gbLegend.Controls.Add(Me.Label5)
        Me.gbLegend.Controls.Add(Me.Panel1)
        Me.gbLegend.Controls.Add(Me.Label6)
        Me.gbLegend.Controls.Add(Me.Panel2)
        Me.gbLegend.Controls.Add(Me.Panel3)
        Me.gbLegend.Controls.Add(Me.Label4)
        Me.gbLegend.Location = New System.Drawing.Point(26, 68)
        Me.gbLegend.Name = "gbLegend"
        Me.gbLegend.Size = New System.Drawing.Size(409, 56)
        Me.gbLegend.TabIndex = 44
        Me.gbLegend.TabStop = False
        Me.gbLegend.Text = "Legend"
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 674)
        Me.Controls.Add(Me.gbLegend)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnParEn)
        Me.Controls.Add(Me.btnReserved)
        Me.Controls.Add(Me.btnEnrolled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudents"
        Me.Text = "frmStudents"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLegend.ResumeLayout(False)
        Me.gbLegend.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnParEn As Button
    Friend WithEvents btnReserved As Button
    Friend WithEvents btnEnrolled As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents btnAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents gbLegend As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordCourse
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
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSections = New System.Windows.Forms.ComboBox()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.White
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 25
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(897, 13)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 49)
        Me.btnPrint.TabIndex = 55
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSections)
        Me.GroupBox1.Location = New System.Drawing.Point(406, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 50)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "courses"
        '
        'cmbSections
        '
        Me.cmbSections.FormattingEnabled = True
        Me.cmbSections.Location = New System.Drawing.Point(6, 21)
        Me.cmbSections.Name = "cmbSections"
        Me.cmbSections.Size = New System.Drawing.Size(197, 24)
        Me.cmbSections.TabIndex = 0
        '
        'dgvSections
        '
        Me.dgvSections.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Location = New System.Drawing.Point(32, 69)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.RowTemplate.Height = 24
        Me.dgvSections.Size = New System.Drawing.Size(981, 501)
        Me.dgvSections.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Courses Printing"
        '
        'frmRecordCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1041, 582)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSections)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecordCourse"
        Me.Text = "frmRecordCourse"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbSections As ComboBox
    Friend WithEvents dgvSections As DataGridView
    Friend WithEvents Label1 As Label
End Class

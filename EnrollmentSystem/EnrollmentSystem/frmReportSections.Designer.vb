<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSections
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
        Me.cmbSections = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSections
        '
        Me.cmbSections.FormattingEnabled = True
        Me.cmbSections.Location = New System.Drawing.Point(4, 17)
        Me.cmbSections.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSections.Name = "cmbSections"
        Me.cmbSections.Size = New System.Drawing.Size(149, 21)
        Me.cmbSections.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sections Printing"
        '
        'dgvSections
        '
        Me.dgvSections.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSections.Location = New System.Drawing.Point(22, 56)
        Me.dgvSections.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.RowTemplate.Height = 24
        Me.dgvSections.Size = New System.Drawing.Size(736, 407)
        Me.dgvSections.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSections)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(158, 41)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "sections"
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
        Me.btnPrint.Location = New System.Drawing.Point(671, 11)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 40)
        Me.btnPrint.TabIndex = 51
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'frmReportSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(781, 473)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSections)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReportSections"
        Me.Text = "frmReportSections"
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSections As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSections As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAAM
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.DGVAccounts = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(773, 31)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 48
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(977, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(771, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 46
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(367, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 41)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Admin"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(455, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 41)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Registrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(572, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 41)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Admission"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(279, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 41)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(44, 22)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(179, 42)
        Me.lblText.TabIndex = 41
        Me.lblText.Text = "Dashboard"
        '
        'DGVAccounts
        '
        Me.DGVAccounts.BackgroundColor = System.Drawing.Color.White
        Me.DGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAccounts.Location = New System.Drawing.Point(39, 90)
        Me.DGVAccounts.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVAccounts.Name = "DGVAccounts"
        Me.DGVAccounts.RowHeadersWidth = 51
        Me.DGVAccounts.Size = New System.Drawing.Size(1015, 414)
        Me.DGVAccounts.TabIndex = 40
        '
        'FrmAAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1092, 524)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.DGVAccounts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAAM"
        Me.Text = "Account Overview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblText As Label
    Friend WithEvents DGVAccounts As DataGridView
End Class

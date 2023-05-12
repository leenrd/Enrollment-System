Public Class FrmAdmission
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmLogin.Show()
    End Sub



    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        With FrmRequirements
            .TopLevel = False
            pnlAdmission.Controls.Add(FrmRequirements)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)
        With frmStudents
            .TopLevel = False
            pnlAdmission.Controls.Add(frmStudents)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs)
        With frmReports
            .TopLevel = False
            pnlAdmission.Controls.Add(frmReports)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        With FrmInquiries
            .TopLevel = False
            pnlAdmission.Controls.Add(FrmInquiries)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        With frmStudents
            .TopLevel = False
            pnlAdmission.Controls.Add(frmStudents)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        With frmReports
            .TopLevel = False
            pnlAdmission.Controls.Add(frmReports)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
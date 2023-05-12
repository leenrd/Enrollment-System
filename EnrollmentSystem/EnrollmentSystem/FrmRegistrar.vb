Public Class FrmRegistrar


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        With FrmEnrollmentTab
            .TopLevel = False
            pnlRegistrar.Controls.Add(FrmEnrollmentTab)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        With frmStudents
            .TopLevel = False
            pnlRegistrar.Controls.Add(frmStudents)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        With frmReports
            .TopLevel = False
            pnlRegistrar.Controls.Add(frmReports)
            .BringToFront()
            .Show()
        End With
    End Sub



    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        With frmSubjects
            .TopLevel = False
            pnlRegistrar.Controls.Add(frmSubjects)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        With FrmRequirements
            .TopLevel = False
            pnlRegistrar.Controls.Add(FrmRequirements)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
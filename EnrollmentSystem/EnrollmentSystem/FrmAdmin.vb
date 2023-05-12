Public Class FrmAdmin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        With FrmAAM
            .TopLevel = False
            pnlAdmin.Controls.Add(FrmAAM)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        With FrmAccountManagement
            .TopLevel = False
            pnlAdmin.Controls.Add(FrmAccountManagement)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
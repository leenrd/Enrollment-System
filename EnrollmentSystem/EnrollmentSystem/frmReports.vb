
Public Class frmReports
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmReportCOR
            .TopLevel = False
            pnlPrinting.Controls.Add(frmReportCOR)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With frmReportStudentReports
            .TopLevel = False
            pnlPrinting.Controls.Add(frmReportStudentReports)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmReportSections
            .TopLevel = False
            pnlPrinting.Controls.Add(frmReportSections)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frmRecordCourse
            .TopLevel = False
            pnlPrinting.Controls.Add(frmRecordCourse)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
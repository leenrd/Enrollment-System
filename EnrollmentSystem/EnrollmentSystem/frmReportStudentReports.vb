Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class frmReportStudentReports
    Private connectionString As String = ConnectionStr

    Private Sub btnEnrolled_Click(sender As Object, e As EventArgs) Handles btnEnrolled.Click
        lblEmpty.Visible = False
        LoadDataGridView("qrEnrolledStudents")
    End Sub

    Private Sub btnParEn_Click(sender As Object, e As EventArgs) Handles btnParEn.Click
        lblEmpty.Visible = False
        LoadDataGridView("qrPartiallyEnrStudents")
    End Sub

    Private Sub btnReserved_Click(sender As Object, e As EventArgs) Handles btnReserved.Click
        lblEmpty.Visible = False
        LoadDataGridView("qrReservedStudents")
    End Sub

    Private Sub LoadDataGridView(queryName As String)
        Dim query As String = "SELECT * FROM " & queryName & ";"
        Using connection As New OleDbConnection(connectionString)
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim data As New DataTable()
            adapter.Fill(data)
            dgvReports.DataSource = data
        End Using
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim printDialog As New PrintDialog()
        Dim printDocument As New Printing.PrintDocument()
        printDialog.Document = printDocument
        printDocument.DefaultPageSettings.Landscape = True

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim bitmap As New Bitmap(Me.dgvReports.Width, Me.dgvReports.Height)
        dgvReports.DrawToBitmap(bitmap, Me.dgvReports.Bounds)
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub

End Class
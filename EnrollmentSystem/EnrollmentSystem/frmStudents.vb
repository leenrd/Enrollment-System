Imports System.Data.OleDb

Public Class frmStudents
    Private connectionString As String = ConnectionStr

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadDataGridView("qrEnrolledStudents")
    End Sub

    Private Sub btnEnrolled_Click(sender As Object, e As EventArgs) Handles btnEnrolled.Click
        gbLegend.Visible = False
        lblEmpty.Visible = False
        LoadDataGridView("qrEnrolledStudents")
    End Sub

    Private Sub btnPartiallyEnrolled_Click(sender As Object, e As EventArgs) Handles btnParEn.Click
        gbLegend.Visible = False
        lblEmpty.Visible = False
        LoadDataGridView("qrPartiallyEnrStudents")
    End Sub

    Private Sub btnReserved_Click(sender As Object, e As EventArgs) Handles btnReserved.Click
        gbLegend.Visible = False
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'clear the search results when the search query is cleared
        If txtSearch.Text.Trim().Length = 0 Then
            CType(dgvReports.DataSource, DataTable).DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'get the search query from the text box
        Dim searchQuery As String = txtSearch.Text.Trim()

        'filter the data in the DataGridView to show only the matching rows
        If searchQuery.Length > 0 Then
            Dim filterExpression As String = String.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%'", searchQuery)
            CType(dgvReports.DataSource, DataTable).DefaultView.RowFilter = filterExpression
            If dgvReports.Rows.Count = 1 Then
                lblError.Text = "*Name is not in the database."
                lblError.Visible = True
                lblError.BringToFront()
                lblError.ForeColor = Color.Red
                lblError.AutoSize = True
            Else
                lblError.Visible = False
            End If

        Else
            CType(dgvReports.DataSource, DataTable).DefaultView.RowFilter = ""
            'lblError.Visible = False
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        lblEmpty.Visible = False
        gbLegend.Visible = True
        LoadDataGridView("tblStudents")
        For Each row As DataGridViewRow In dgvReports.Rows
            Dim enrollmentStatusCell As DataGridViewCell = row.Cells("EnrollmentStatus")
            If enrollmentStatusCell.Value IsNot Nothing Then
                Dim enrollmentStatus As String = enrollmentStatusCell.Value.ToString()
                If enrollmentStatus = "Enrolled" Then
                    row.DefaultCellStyle.BackColor = Color.Teal
                    row.DefaultCellStyle.ForeColor = Color.White
                ElseIf enrollmentStatus = "Partially Enrolled" Then
                    row.DefaultCellStyle.BackColor = Color.Firebrick
                    row.DefaultCellStyle.ForeColor = Color.White
                ElseIf enrollmentStatus = "Reserved" Then
                    row.DefaultCellStyle.BackColor = Color.Blue
                    row.DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Next
    End Sub



End Class
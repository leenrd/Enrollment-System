Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmReportCOR
    Private Sub frmReportCOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'retrieve the data from the tblStudents table
        Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
        Dim sql As String = "SELECT * FROM tblStudents"
        Dim adapter As New OleDbDataAdapter(sql, connectionString)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        'populate the DataGridView control with the retrieved data
        dgvStudentList.DataSource = dataTable
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'get the search query from the text box
        Dim searchQuery As String = txtSearch.Text.Trim()

        'filter the data in the DataGridView to show only the matching rows
        If searchQuery.Length > 0 Then
            Dim filterExpression As String = String.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%'", searchQuery)
            CType(dgvStudentList.DataSource, DataTable).DefaultView.RowFilter = filterExpression
            If dgvStudentList.Rows.Count = 1 Then
                lblError.Text = "*Name is not in the database."
                lblError.Visible = True
                lblError.BringToFront()
                lblError.ForeColor = Color.Red
                lblError.AutoSize = True
            Else
                lblError.Visible = False
            End If

        Else
            CType(dgvStudentList.DataSource, DataTable).DefaultView.RowFilter = ""
            'lblError.Visible = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'clear the search results when the search query is cleared
        If txtSearch.Text.Trim().Length = 0 Then
            CType(dgvStudentList.DataSource, DataTable).DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub dgvStudentList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudentList.SelectionChanged
        'check if there is a selected row in the DataGridView
        If dgvStudentList.SelectedRows.Count > 0 Then
            'get the details of the selected student
            Dim studentID As Integer = Convert.ToInt32(dgvStudentList.CurrentRow.Cells("StudentID").Value)
            Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
            Dim sql As String = "SELECT * FROM tblStudents WHERE StudentID = " & studentID
            Dim connection As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand(sql, connection)
            connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.Read() Then
                'display the student details in the textboxes
                txtStudentID.Text = reader("StudentID").ToString()
                txtFirstName.Text = reader("FirstName").ToString()
                txtLastName.Text = reader("LastName").ToString()
                txtCourse.Text = reader("Course").ToString()
                txtRegno.Text = reader("RegNumber").ToString()
                txtStatus.Text = reader("EnrollmentStatus").ToString()
            End If
            reader.Close()
            connection.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Create a new PrintDocument object
        Dim pd As New Printing.PrintDocument()

        ' Set the document name
        pd.DocumentName = "Certificate of Registration"

        ' Set the PrintPage event handler
        AddHandler pd.PrintPage, AddressOf PrintCertificateOfRegistration

        ' Create a new PrintPreviewDialog object
        Dim ppd As New PrintPreviewDialog()

        ' Set the document to be previewed
        ppd.Document = pd

        ' Display the preview dialog
        ppd.ShowDialog()
    End Sub

    Private Sub PrintCertificateOfRegistration(sender As Object, e As Printing.PrintPageEventArgs)
        ' Set the font and brush for drawing text
        Dim fontTitle As New Font("Arial", 18, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        ' Set the top margin
        Dim topMargin As Integer = 100

        ' Load the school logo
        Dim logo As Image = Image.FromFile(Application.StartupPath & "\ACADEMY_OF__1_-removebg-preview.png")

        ' Draw the school logo
        e.Graphics.DrawImage(logo, 100, topMargin, 150, 150)

        ' Draw the school name
        e.Graphics.DrawString("Academy of South Greenfield", fontTitle, brush, New Point(300, topMargin))

        ' Draw the certificate title
        topMargin += 200
        e.Graphics.DrawString("Certificate of Registration", fontHeader, brush, New Point(100, topMargin))

        ' Draw the student details
        topMargin += 50
        e.Graphics.DrawString("Student ID: " & txtStudentID.Text, fontSubHeader, brush, New Point(100, topMargin))
        topMargin += 25
        e.Graphics.DrawString("Name: " & txtFirstName.Text & " " & txtLastName.Text, fontSubHeader, brush, New Point(100, topMargin))
        topMargin += 25
        e.Graphics.DrawString("Course: " & txtCourse.Text, fontSubHeader, brush, New Point(100, topMargin))

        ' Draw the subjects
        topMargin += 50
        e.Graphics.DrawString("Subjects:", fontSubHeader, brush, New Point(100, topMargin))

        ' Get the subject codes for the selected student
        Dim subjectCodes As String = ""
        Dim studentID As String = txtStudentID.Text.Trim()
        Dim querySubjectCodes As String = "SELECT SubjectSet FROM tblStudents WHERE StudentID = " & studentID

        Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
        Dim connection As New OleDbConnection(connectionString)
        Dim commandSubjectCodes As New OleDbCommand(querySubjectCodes, connection)
        Dim readerSubjectCodes As OleDbDataReader = Nothing

        Try
            ' Open the connection and execute the query
            connection.Open()
            readerSubjectCodes = commandSubjectCodes.ExecuteReader()

            ' Get the subject codes
            If readerSubjectCodes.Read() Then
                subjectCodes = readerSubjectCodes("SubjectSet").ToString()
            End If

            ' Query the database to get the subject details
            If subjectCodes <> "" Then
                Dim querySubjectDetails As String = "SELECT [Subject Title], Units, [Subject Code] FROM tblSubjects WHERE [Subject Code] IN ('" & subjectCodes.Replace(",", "','") & "')"
                Dim commandSubjectDetails As New OleDbCommand(querySubjectDetails, connection)
                Dim readerSubjectDetails As OleDbDataReader = Nothing

                Try
                    ' Execute the query
                    readerSubjectDetails = commandSubjectDetails.ExecuteReader()

                    ' Set the column width
                    Dim columnWidth As Integer = 200

                    ' Draw the table headers
                    topMargin += 30
                    e.Graphics.DrawString("Subject Code", fontBody, brush, New RectangleF(100, topMargin, columnWidth, fontBody.Height))
                    e.Graphics.DrawString("Subject Title", fontBody, brush, New RectangleF(100 + columnWidth, topMargin, columnWidth, fontBody.Height))
                    e.Graphics.DrawString("Units", fontBody, brush, New RectangleF(100 + 2 * columnWidth, topMargin, columnWidth, fontBody.Height))

                    ' Draw the subject details
                    While readerSubjectDetails.Read()
                        topMargin += 25
                        e.Graphics.DrawString(readerSubjectDetails("Subject Code").ToString(), fontBody, brush, New RectangleF(100, topMargin, columnWidth, fontBody.Height))
                        e.Graphics.DrawString(readerSubjectDetails("Subject Title").ToString(), fontBody, brush, New RectangleF(100 + columnWidth, topMargin, columnWidth, fontBody.Height))
                        e.Graphics.DrawString(readerSubjectDetails("Units").ToString(), fontBody, brush, New RectangleF(100 + 2 * columnWidth, topMargin, columnWidth, fontBody.Height))
                    End While
                Catch ex As Exception
                    MessageBox.Show("An error occurred while retrieving subject details: " & ex.Message)
                Finally
                    If readerSubjectDetails IsNot Nothing Then readerSubjectDetails.Close()
                    If commandSubjectDetails IsNot Nothing Then commandSubjectDetails.Dispose()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving subject codes: " & ex.Message)
        Finally
            If readerSubjectCodes IsNot Nothing Then readerSubjectCodes.Close()
            If connection.State = ConnectionState.Open Then connection.Close()
            If commandSubjectCodes IsNot Nothing Then commandSubjectCodes.Dispose()
        End Try


        ' Draw the date
        topMargin += 50
        e.Graphics.DrawString("Issued on " & DateTime.Now.ToString("MMMM dd, yyyy"), fontSubHeader, brush, New Point(100, topMargin))
    End Sub






    Private Sub btnSelectStudent_Click(sender As Object, e As EventArgs) Handles btnSelectStudent.Click
        'update the label to show the selected student's name
        Label6.Visible = True
        Label6.ForeColor = Color.Green
        Label6.Text = "Selected Student: " & txtFirstName.Text & " " & txtLastName.Text
    End Sub

End Class
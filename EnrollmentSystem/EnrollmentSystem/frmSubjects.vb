Imports System.Data.OleDb

Public Class frmSubjects
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the data from the tblStudents table
        Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
        Dim sql As String = "SELECT * FROM tblStudents"
        Dim adapter As New OleDbDataAdapter(sql, connectionString)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        ' Populate the DataGridView control with the retrieved data
        dgvStudentList.DataSource = dataTable

        ' Clear the ComboBox control
        cmbIrregAdd.DataSource = Nothing
        cmbIrregAdd.SelectedIndex = -1

        ' Populate the ComboBox control with the subjects from tblSubjects
        Dim subjectsSql As String = "SELECT * FROM tblSubjects"
        Dim subjectAdapter As New OleDbDataAdapter(subjectsSql, connectionString)
        Dim subjectTable As New DataTable()
        subjectAdapter.Fill(subjectTable)
        With cmbIrregAdd
            .DataSource = subjectTable
            .DisplayMember = "Subject Title"
            .ValueMember = "Subject Code"
        End With

        ' Set the ComboBox control to empty string
        cmbIrregAdd.Text = ""
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
            End If
            reader.Close()
            connection.Close()
        End If
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if a subject is selected
        If cmbIrregAdd.SelectedValue IsNot Nothing Then
            Dim selectedSubjectCode As String = cmbIrregAdd.SelectedValue.ToString()
            Dim selectedSubjectName As String = cmbIrregAdd.Text

            ' Retrieve the units and course code for the selected subject from the database
            Dim units As String = ""
            Dim courseCode As String = ""
            Using conn As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb")
                conn.Open()
                Dim cmdUnits As New OleDbCommand("SELECT Units FROM tblSubjects WHERE SubjectCode = @SubjectCode", conn)
                cmdUnits.Parameters.Add("@SubjectCode", OleDbType.VarChar).Value = selectedSubjectCode
                units = cmdUnits.ExecuteScalar()?.ToString()

                Dim cmdCourse As New OleDbCommand("SELECT [Course Code] FROM tblSubjects WHERE [Subject Title] = @SubjectTitle", conn)
                cmdCourse.Parameters.Add("@SubjectTitle", OleDbType.VarChar).Value = selectedSubjectName
                courseCode = cmdCourse.ExecuteScalar()?.ToString()


                Dim cmdStudentCourse As New OleDbCommand("SELECT Course FROM tblStudents WHERE StudentID = @StudentID", conn)
                cmdStudentCourse.Parameters.Add("@StudentID", OleDbType.VarChar).Value = dgvStudentList.SelectedRows(0).Cells("StudentID").Value.ToString()
                Dim studentCourse As String = cmdStudentCourse.ExecuteScalar()?.ToString()

                If String.Equals(courseCode.Trim(), studentCourse.Trim(), StringComparison.OrdinalIgnoreCase) Then
                    ' Check if the selected subject is already added to the student's subjects
                    Dim dt As DataTable = CType(dgvSubjectSet.DataSource, DataTable)
                    Dim existingSubjectRows() As DataRow = dt.Select($"[Subject Code] = '{selectedSubjectCode}'")
                    If existingSubjectRows.Length > 0 Then
                        ' The selected subject is already added to the student's subjects, show an error message
                        MessageBox.Show($"The subject '{selectedSubjectName}' is already added to the student's subjects.")
                    Else
                        ' The selected subject is not added to the student's subjects, add a new row to the underlying DataTable
                        Dim newRow As DataRow = dt.NewRow()
                        newRow("Subject Code") = selectedSubjectCode
                        newRow("Subject Title") = selectedSubjectName
                        newRow("Units") = units
                        newRow("Course Code") = courseCode
                        dt.Rows.Add(newRow)
                    End If
                Else
                    MessageBox.Show("The selected subject is not offered for the student's course.")
                    MessageBox.Show(String.Format("courseCode: {0}, studentCourse: {1}", courseCode, studentCourse))

                End If
            End Using
        End If
    End Sub



    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        ' Clear all rows in the DataGridView except the first row
        If dgvSubjectSet.Rows.Count > 0 Then
            ' Get the underlying DataTable
            Dim dt As DataTable = CType(dgvSubjectSet.DataSource, DataTable)

            ' Clear the DataTable and add a new row
            dt.Rows.Clear()
            dt.Rows.Add(dt.NewRow())

            ' Reassign the DataTable to the DataGridView control and refresh it
            dgvSubjectSet.DataSource = dt
            dgvSubjectSet.Refresh()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim subjectSetList As New List(Of String)()

        For Each row As DataGridViewRow In dgvSubjectSet.Rows
            If Not String.IsNullOrEmpty(row.Cells("Subject Code").Value?.ToString()) Then
                subjectSetList.Add(row.Cells("Subject Code").Value.ToString())
            End If

        Next

        Dim subjectSet As String = String.Join(",", subjectSetList)

        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb")
        Dim cmd As New OleDbCommand()
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = "UPDATE tblStudents SET SubjectSet = @SubjectSet WHERE StudentID = @StudentID"
        cmd.Parameters.AddWithValue("@SubjectSet", subjectSet)
        cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data saved successfully.")

    End Sub

    Private Sub btnSelectStudent_Click(sender As Object, e As EventArgs) Handles btnSelectStudent.Click
        'get the details of the selected student
        Dim studentID As Integer = Convert.ToInt32(dgvStudentList.CurrentRow.Cells("StudentID").Value)
        Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
        Dim sql As String = "SELECT * FROM tblStudents WHERE StudentID = " & studentID
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand(sql, connection)
        connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()
        If reader.Read() Then
            'get the course and subject set of the selected student
            Dim course As String = reader("Course").ToString()
            Dim subjectSet As String = reader("SubjectSet").ToString()

            If String.IsNullOrEmpty(subjectSet) Then
                'display the subject set for the selected course in dgvSubjectSet
                sql = "SELECT [Subject Code], [Subject Title], Units, [Course Code] FROM [qr" & course & "]"
                command = New OleDbCommand(sql, connection)
                reader.Close()
                Dim adapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dgvSubjectSet.DataSource = dataTable
            Else
                'display the subjects in the subject set
                Dim subjectCodes As String() = subjectSet.Split(",")
                Dim subjectCodesList As New List(Of String)()

                For Each subjectCode In subjectCodes
                    subjectCodesList.Add("'" & subjectCode & "'")
                Next

                Dim subjectCodesString As String = String.Join(",", subjectCodesList)

                sql = "SELECT [Subject Code], [Subject Title], Units, [Course Code] FROM tblSubjects WHERE [Subject Code] IN (" & subjectCodesString & ")"
                command = New OleDbCommand(sql, connection)
                reader.Close()
                Dim adapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dgvSubjectSet.DataSource = dataTable
            End If
        End If
        connection.Close()
    End Sub


    Private Sub btnRemSub_Click(sender As Object, e As EventArgs) Handles btnRemSub.Click
        If dgvSubjectSet.SelectedRows.Count > 0 Then
            dgvSubjectSet.Rows.Remove(dgvSubjectSet.SelectedRows(0))
        End If
    End Sub
End Class
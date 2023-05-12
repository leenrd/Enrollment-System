Imports System.Data.OleDb
Public Class FrmRequirements
    Private Sub FrmRequirements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'retrieve the data from the tblStudents table
        Dim connectionString As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
        Dim sql As String = "SELECT * FROM tblStudents"
        Dim adapter As New OleDbDataAdapter(sql, connectionString)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        'populate the DataGridView control with the retrieved data
        dgvStudentList.DataSource = dataTable
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

    Private Sub btnSelectStudent_Click(sender As Object, e As EventArgs) Handles btnSelectStudent.Click
        'clear the checkmarks of the checkboxes
        ck1.Checked = False
        ck2.Checked = False
        ck3.Checked = False
        ck4.Checked = False
        ck5.Checked = False
        ck6.Checked = False
        ck7.Checked = False
        ck8.Checked = False
        ck9.Checked = False
        'etc...

        'check if there is a selected row in the DataGridView
        If dgvStudentList.SelectedRows.Count > 0 Then
            'get the ID of the selected student
            Dim studentID As Integer = Convert.ToInt32(dgvStudentList.CurrentRow.Cells("StudentID").Value)
            Dim studentName As String = dgvStudentList.CurrentRow.Cells("FirstName").Value.ToString()

            'update the label to show the selected student's name
            Label6.Visible = True
            Label6.ForeColor = Color.Green
            Label6.Text = "Selected Student: " & txtFirstName.Text & " " & txtLastName.Text


            'read the student's requirements from the database
            Dim connectionString As String = ConnectionStr
            Dim sql As String = "SELECT Requirements FROM tblStudents WHERE StudentID = " & studentID
            Dim connection As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand(sql, connection)
            connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()

            'check if the student's requirements field is empty
            If reader.Read() Then
                Dim requirements As String = reader("Requirements").ToString()
                If requirements = "" Then
                    'enable the checkboxes for selecting the student's requirements
                    ck1.Enabled = True
                    ck2.Enabled = True
                    ck3.Enabled = True
                    ck4.Enabled = True
                    ck5.Enabled = True
                    ck6.Enabled = True
                    ck7.Enabled = True
                    ck8.Enabled = True
                    ck9.Enabled = True
                    'etc...

                Else
                    'load the stored requirements into the checkboxes
                    If requirements.Contains("Requirement1") Then
                        ck1.Checked = True
                    End If
                    If requirements.Contains("Requirement2") Then
                        ck2.Checked = True
                    End If
                    If requirements.Contains("Requirement3") Then
                        ck3.Checked = True
                    End If
                    If requirements.Contains("Requirement4") Then
                        ck4.Checked = True
                    End If
                    If requirements.Contains("Requirement5") Then
                        ck5.Checked = True
                    End If
                    If requirements.Contains("Requirement6") Then
                        ck6.Checked = True
                    End If
                    If requirements.Contains("Requirement7") Then
                        ck7.Checked = True
                    End If
                    If requirements.Contains("Requirement8") Then
                        ck8.Checked = True
                    End If
                    If requirements.Contains("Requirement9") Then
                        ck9.Checked = True
                    End If
                End If
            End If

            reader.Close()
            connection.Close()
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        'get the selected student ID
        Dim studentID As Integer = Convert.ToInt32(txtStudentID.Text)

        'build the requirements string based on the checked boxes
        Dim requirements As String = ""
        If ck1.Checked Then
            requirements &= "Requirement1,"
        End If
        If ck2.Checked Then
            requirements &= "Requirement2,"
        End If
        If ck3.Checked Then
            requirements &= "Requirement3,"
        End If
        If ck4.Checked Then
            requirements &= "Requirement4,"
        End If
        If ck5.Checked Then
            requirements &= "Requirement5,"
        End If
        If ck6.Checked Then
            requirements &= "Requirement6,"
        End If
        If ck7.Checked Then
            requirements &= "Requirement7,"
        End If
        If ck8.Checked Then
            requirements &= "Requirement8,"
        End If
        If ck9.Checked Then
            requirements &= "Requirement9,"
        End If

        'remove the trailing comma if any
        If requirements.Length > 0 Then
            requirements = requirements.Substring(0, requirements.Length - 1)
        End If

        'update the requirements field in the database
        Dim connectionString As String = ConnectionStr
        Dim sql As String = "UPDATE tblStudents SET Requirements = @requirements WHERE StudentID = @studentID"
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand(sql, connection)
        command.Parameters.AddWithValue("@requirements", requirements)
        command.Parameters.AddWithValue("@studentID", studentID)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        'show a message to indicate that the requirements have been saved
        MessageBox.Show("Requirements have been saved for student " & txtFirstName.Text & " " & txtLastName.Text)
    End Sub

End Class
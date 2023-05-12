Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class FrmInquiries
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim sqlCommand As New OleDbCommand
    Dim sqlString As String
    Dim dr As OleDbDataReader
    Dim sqlSave As String


    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("Select * From tblInquiry", conn)
        dset = New DataSet
        da.Fill(dset, "tblInquiry")
        DGVInquiries.DataSource = dset.Tables("tblInquiry").DefaultView
    End Sub

    Private Sub DGVInquiries_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInquiries.CellClick
        Try
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtPhoneNum.Enabled = False
            Dim Index As Integer
            Index = e.RowIndex
            Dim selectedrow As DataGridViewRow = DGVInquiries.Rows(Index)
            txtID.Text = selectedrow.Cells(0).Value.ToString
            txtFirstName.Text = selectedrow.Cells(1).Value.ToString
            txtLastName.Text = selectedrow.Cells(2).Value.ToString
            txtPhoneNum.Text = selectedrow.Cells(3).Value.ToString
            cboAdvancement.Text = selectedrow.Cells(4).Value.ToString
        Catch ex As Exception
            'MessageBox.Show("Field Unselectable.")
            Call LoadList()
        End Try
    End Sub

    Function IsAllLetters(value As String) As Boolean
        For Each c As Char In value
            If Not Char.IsLetter(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function IsAllDigits(value As String) As Boolean
        For Each c As Char In value
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next
        Return True
    End Function
    Sub InsertInfo()
        conn.Close()
        conn.Open()
        sqlSave = "INSERT INTO tblInquiry ([FirstName],[LastName],[PhoneNum],[Advancement],[InquiryDate]) VALUES ('" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & txtPhoneNum.Text & "', '" & cboAdvancement.Text & "', '" & DTPDate.Value & "')"
        sqlCommand = New OleDbCommand(sqlSave, conn)
        sqlCommand.ExecuteNonQuery()
        MsgBox("Inquirer info Inserted", MsgBoxStyle.Information)
        Call LoadList()
        conn.Close()
    End Sub

    Sub LoadList()
        da = New OleDbDataAdapter("Select * From tblInquiry", conn)
        dset = New DataSet
        da.Fill(dset, "tblInquiry")
        DGVInquiries.DataSource = dset.Tables("tblInquiry").DefaultView
    End Sub




    Sub UpdateInfo()
        conn.Close()
        conn.Open()
        sqlString = "UPDATE [tblInquiry] SET [Advancement] = '" & cboAdvancement.Text & "', [InquiryDate] = '" & DTPDate.Value & "' WHERE [InquiryID] = " & txtID.Text & ""
        sqlCommand = New OleDbCommand(sqlString, conn)
        sqlCommand.ExecuteNonQuery()
        MsgBox("Status Updated")
        conn.Close()
        Call LoadList()
    End Sub

    Sub UpdateAll()
        conn.Close()
        conn.Open()
        sqlString = "UPDATE [tblInquiry] SET [Advancement] = '" & cboAdvancement.Text & "', [InquiryDate] = '" & DTPDate.Value & "' WHERE [FirstName] = '" & txtFirstName.Text & "' AND [LastName] = '" & txtLastName.Text & "'"
        sqlCommand = New OleDbCommand(sqlString, conn)
        sqlCommand.ExecuteNonQuery()
        MsgBox("All Status Updated")
        conn.Close()
        Call LoadList()
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchQuery As String = txtSearch.Text.Trim()

        If searchQuery.Length > 0 Then
            If dset IsNot Nothing AndAlso dset.Tables.Contains("tblInquiry") Then
                Dim inquiryTable As DataTable = dset.Tables("tblInquiry")

                If inquiryTable.Rows.Count > 0 Then
                    Dim filterExpression As String = String.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%'", searchQuery)
                    inquiryTable.DefaultView.RowFilter = filterExpression
                End If
            End If
        Else
            If dset IsNot Nothing AndAlso dset.Tables.Contains("tblInquiry") Then
                dset.Tables("tblInquiry").DefaultView.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = "Select * From tblInquiry Where [FirstName] Like '%" & txtSearch.Text & "%' OR [LastName] Like '%" & txtSearch.Text & "%'"

        If searchQuery.Length > 0 Then
            da = New OleDbDataAdapter(searchQuery, conn)
            dset = New DataSet
            da.Fill(dset, "tblInquiry")
            DGVInquiries.DataSource = dset.Tables("tblInquiry").DefaultView

            If DGVInquiries.Rows.Count = 1 Then
                lblError.Text = "*Name is not in the database."
                lblError.Visible = True
                lblError.BringToFront()
                lblError.ForeColor = Color.Red
                lblError.AutoSize = True
            Else
                lblError.Visible = False
            End If
        Else
            dset.Tables("tblInquiry").DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtPhoneNum.Enabled = True
        cboAdvancement.Enabled = True
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try

            txtID.Enabled = True
            Call UpdateInfo()
            txtID.Enabled = False
        Catch ex As Exception
            MsgBox("Can't Update selected record. Try Selecting it again", vbOK)
        End Try
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Call UpdateAll()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhoneNum.Clear()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Try
            If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Then
                MsgBox("Please Insert First Name", vbInformation)
                txtFirstName.Focus()
            ElseIf Not IsAllLetters(txtFirstName.Text) Then
                MsgBox("First Name should only contain letters.", vbInformation)
                txtFirstName.Focus()
            ElseIf String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
                MsgBox("Please Insert Last Name", vbInformation)
                txtLastName.Focus()
            ElseIf Not IsAllLetters(txtLastName.Text) Then
                MsgBox("Last Name should only contain letters.", vbInformation)
                txtLastName.Focus()
            ElseIf String.IsNullOrEmpty(txtPhoneNum.Text.Trim()) Then
                MsgBox("Please Insert Phone Number", vbInformation)
                txtPhoneNum.Focus()
            ElseIf Not IsAllDigits(txtPhoneNum.Text) Then
                MsgBox("Phone Number should only contain digits.", vbInformation)
                txtPhoneNum.Focus()
            Else
                Call InsertInfo()
            End If
        Catch ex As Exception
            MsgBox("Error inserting inquiry: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class
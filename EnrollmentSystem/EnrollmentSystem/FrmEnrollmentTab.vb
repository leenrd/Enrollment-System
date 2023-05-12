Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography

Public Class FrmEnrollmentTab
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim sqlCommand As New OleDbCommand
    Dim sqlString As String
    Dim dr As OleDbDataReader
    Dim sqlSave As String

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim result As MsgBoxResult = MsgBox("Are you sure the credentials are correct?", vbYesNo)
            If result = MsgBoxResult.Yes Then
                'call enroll function here
                'Test()
                Enroll()
            ElseIf result = MsgBoxResult.No Then


            End If

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Enroll()
        Try
            Dim newRegNum As Integer = 0
            Dim isUnique As Boolean = False
            ' Loop until a unique RegNumber is found
            While Not isUnique
                ' Generate a new RegNumber
                newRegNum = 1000 + CInt(Int((9999 * Rnd()) + 1))

                ' Check if the RegNumber already exists in the table
                da = New OleDbDataAdapter("Select * from tblStudents Where RegNumber = " & newRegNum.ToString(), conn)
                dset = New DataSet
                da.Fill(dset, "tblStudents")

                ' If there are no matching rows, the RegNumber is unique
                If dset.Tables("tblStudents").Rows.Count = 0 Then
                    isUnique = True
                End If
            End While

            ' Insert the new record using the unique RegNumber
            conn.Close()
            conn.Open()
            sqlSave = "INSERT INTO tblStudents ([RegNumber],[LastName],[FirstName],[MiddleName],[Sex], [Birthdate],[HouseNo], [Street], [Barangay], [City], [PostalCode], [PhoneNum],[StudentType] ,[EnrollmentStatus], [Course], [Section], [SchoolYear], [Semester]) VALUES ('" & newRegNum.ToString() & "', '" & txtLastName.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & cbSex.Text & "','" & DTPBirth.Value & "','" & txtHouseNo.Text & "','" & txtStreet.Text & "','" & txtBarangay.Text & "','" & txtCity.Text & "','" & txtZipCode.Text & "','" & txtPhone.Text & "','" & cbStudentType.Text & "','" & cbEnrollmentStatus.Text & "','" & cbCourse.Text & "','" & cbSection.Text & "','" & cbSY.Text & "','" & cbSemester.Text & "')"
            sqlCommand = New OleDbCommand(sqlSave, conn)
            sqlCommand.ExecuteNonQuery()
            MsgBox("Student information has been successfully added.", MsgBoxStyle.Information)
            conn.Close()

        Catch ex As OleDbException
            ' Handle the OleDbException here
            If ex.ErrorCode = -2147217913 Then
                MsgBox("A data type mismatch error occurred. Please check that all input fields contain the correct data type.", vbCritical)
            ElseIf ex.ErrorCode = -2147217873 Then
                MsgBox("The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship. Please change the RegNumber or other fields to ensure that the values are unique and try again.", vbCritical)
            Else
                MsgBox("An error occurred while trying to execute the Enroll() function: " & ex.Message, vbCritical)
            End If
        Catch ex As Exception
            ' Handle any other exceptions here
            MsgBox("An error occurred while trying to execute the Enroll() function: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (txtRegNum.Text = "") Then
                MsgBox("Please select a record to delete.", vbCritical)
            Else
                Dim cmd As New OleDbCommand("DELETE FROM tblStudents WHERE RegNumber=@regNum", conn)
                cmd.Parameters.AddWithValue("@regNum", txtRegNum.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MsgBox("Record deleted successfully", MsgBoxStyle.Information)

                ' Clear input controls
                ' txtStudentID.Clear()
                txtFirstName.Clear()
                txtRegNum.Clear()
                cbSection.Text = ""
                cbCourse.Text = ""
                cbSY.Text = ""
                cbSemester.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Clear all textboxes and comboboxes
            txtRegNum.Clear()
            txtLastName.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            cbSex.SelectedIndex = -1
            DTPBirth.Value = Now
            txtHouseNo.Clear()
            txtStreet.Clear()
            txtBarangay.Clear()
            txtCity.Clear()
            txtZipCode.Clear()
            txtPhone.Clear()
            cbStudentType.SelectedIndex = -1
            cbEnrollmentStatus.SelectedIndex = -1
            cbCourse.SelectedIndex = -1
            cbSection.SelectedIndex = -1
            cbSY.SelectedIndex = -1
            cbSemester.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtRegNum_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegNum.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbSex_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbSex.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DTPBirth_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DTPBirth.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHouseNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHouseNo.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStreet_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStreet.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBarangay_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarangay.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCity_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtZipCode_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZipCode.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



End Class

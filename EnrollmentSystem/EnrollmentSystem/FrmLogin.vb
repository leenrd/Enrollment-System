Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class FrmLogin
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim sqlCommand As New OleDbCommand
    Dim sqlString As String
    Dim dr As OleDbDataReader


    Sub Check(AccountType As String)
        conn.Close()
        conn.Open()
        sqlString = "Select * from TblAccounts WHERE Username ='" & txtUsername.Text & "' AND Password= '" & txtPassword.Text & "' AND AccountStatus = 'Active' AND AccountType = '" & AccountType & "'"
        sqlCommand = New OleDbCommand(sqlString, conn)
        dr = sqlCommand.ExecuteReader
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If txtUsername.Text = Nothing And txtPassword.Text = Nothing Then
            MsgBox("Empty Credentials", vbInformation)

        Else
            da = New OleDbDataAdapter("Select * from TblAccounts WHERE Username ='" & txtUsername.Text & "' AND Password= '" & txtPassword.Text & "' AND AccountStatus = 'Active'", conn)
            dset = New DataSet
            da.Fill(dset, "TblAccounts")


            If dset.Tables("TblAccounts").Rows.Count = 0 Then
                MessageBox.Show("Account Deactivated/Incorrect Credentials", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                'checks for admin Account type
            ElseIf dset.Tables("TblAccounts").Rows.Count > 0 Then

                Check("Admin")
                If dr.Read Then
                    FrmAdmin.Show()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                End If

                'checks for Admission

                Check("Admission")
                If dr.Read Then
                    FrmAdmission.Show() 'change this to FrmAdmission
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                End If

                'checks for Registrar

                Check("Registrar")
                If dr.Read Then
                    FrmRegistrar.Show() 'change this to FrmRegistrar
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        End
    End Sub
End Class

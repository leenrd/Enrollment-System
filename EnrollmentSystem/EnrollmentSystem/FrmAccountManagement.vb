Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

Public Class FrmAccountManagement
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim sqlCommand As New OleDbCommand
    Dim sqlString As String
    Dim dr As OleDbDataReader
    Dim sqlSave As String

    'Loads the DGV
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("Select * From tblAccounts", conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        DGVAccounts.DataSource = dset.Tables("tblAccounts").DefaultView
    End Sub


    Sub Check(AccountID As String)
        If txtID.Text = Nothing Then

        Else
            conn.Close()
            conn.Open()
            sqlString = "Select * from TblAccounts WHERE AccountID = " & txtID.Text & " AND Username = '" & txtUser.Text & "' AND Password = '" & txtPass.Text & "'"
            sqlCommand = New OleDbCommand(sqlString, conn)
            dr = sqlCommand.ExecuteReader

        End If

    End Sub


    Sub Create()
        Try


            da = New OleDbDataAdapter("Select * from TblAccounts WHERE Username = '" & txtUser.Text & "' AND Password = '" & txtPass.Text & "'", conn)
            dset = New DataSet
            da.Fill(dset, "TblAccounts")

            Check(txtID.Text)
            If dset.Tables("TblAccounts").Rows.Count > 0 Then
                MsgBox("An account with this ID already Exists", vbCritical)
            Else

                conn.Close()
                conn.Open()
                sqlSave = "INSERT INTO tblAccounts([AccountID],[Username],[Password],[AccountType],[AccountStatus]) VALUES ('" & txtID.Text & "', '" & txtUser.Text & "', '" & txtPass.Text & "', '" & cbAccountType.Text & "', '" & cbStatus.Text & "')"
                sqlCommand = New OleDbCommand(sqlSave, conn)
                sqlCommand.ExecuteNonQuery()
                MsgBox("New account has been created", MsgBoxStyle.Information)
                txtUser.Clear()
                txtPass.Clear()
                Call LoadList()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Please use number only on ID")
        End Try
    End Sub

    Sub LoadList()
        da = New OleDbDataAdapter("Select * From tblAccounts", conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        DGVAccounts.DataSource = dset.Tables("tblAccounts").DefaultView
    End Sub


    Private Sub DGVAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAccounts.CellClick
        Try
            Dim Index As Integer
            Index = e.RowIndex
            Dim selectedrow As DataGridViewRow = DGVAccounts.Rows(Index)
            txtID.Text = selectedrow.Cells(0).Value.ToString
            txtUser.Text = selectedrow.Cells(1).Value.ToString
            txtPass.Text = selectedrow.Cells(2).Value.ToString
            cbAccountType.Text = selectedrow.Cells(3).Value.ToString
            cbStatus.Text = selectedrow.Cells(4).Value.ToString
        Catch ex As Exception
            'MessageBox.Show("Field Unselectable.")
            Call LoadList()
        End Try
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IconButton3.Enabled = True
        txtID.Enabled = True
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'enables all the Boxes
        txtUser.Enabled = True
        txtPass.Enabled = True
        cbAccountType.Enabled = True
        cbStatus.Enabled = True
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try
            If txtID.Text = Nothing Then
                MsgBox("ID is missing, Please input the ID", vbInformation)


            ElseIf txtUser.Text = Nothing And txtPass.Text = Nothing Then
                MsgBox("Credentials are missing, Please input them", vbCritical)

            Else
                conn.Close()
                conn.Open()
                sqlString = "UPDATE [tblAccounts] SET [Username] = '" & txtUser.Text & "',[Password]= '" & txtPass.Text & "' ,[AccountType] = '" & cbAccountType.Text & "', [AccountStatus]='" & cbStatus.Text & "'  WHERE [AccountID]= " & txtID.Text & ""
                sqlCommand = New OleDbCommand(sqlString, conn)
                sqlCommand.ExecuteNonQuery()
                MsgBox("User Info Updated")
                conn.Close()
                Call LoadList()
                txtUser.Enabled = False
                txtPass.Enabled = False
                cbAccountType.Enabled = False
                cbStatus.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Please use number only on ID")
        End Try
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        If txtID.Text = Nothing Then
            MsgBox("please input an ID number", vbInformation)

        ElseIf txtUser.Text = Nothing Then
            MsgBox("please input a username", vbInformation)

        ElseIf txtPass.Text = Nothing Then
            MsgBox("please input a password", vbInformation)

        ElseIf txtUser.Text = Nothing And txtPass.Text = Nothing Then
            MsgBox("Credentials missing", vbInformation)

        ElseIf txtID.Text = Nothing And txtUser.Text = Nothing And txtPass.Text = Nothing Then
            MsgBox("Too many credentials missing to make an account", vbCritical)

        Else

            Call Create()

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchQuery As String = txtSearch.Text.Trim()

        If searchQuery.Length > 0 Then
            Dim filterExpression As String = String.Format("Username LIKE '%{0}%' OR AccountType LIKE '%{0}%'", searchQuery)
            dset.Tables("tblAccounts").DefaultView.RowFilter = filterExpression
        Else
            dset.Tables("tblAccounts").DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = txtSearch.Text.Trim()

        If searchQuery.Length > 0 Then
            Dim filterExpression As String = String.Format("Username LIKE '%{0}%' OR AccountType LIKE '%{0}%'", searchQuery)
            dset.Tables("tblAccounts").DefaultView.RowFilter = filterExpression
            If DGVAccounts.Rows.Count = 1 Then
                lblError.Text = "*Name is not in the database."
                lblError.Visible = True
                lblError.BringToFront()
                lblError.ForeColor = Color.Red
                lblError.AutoSize = True
            Else
                lblError.Visible = False
            End If
        Else
            dset.Tables("tblAccounts").DefaultView.RowFilter = ""
        End If
    End Sub
End Class
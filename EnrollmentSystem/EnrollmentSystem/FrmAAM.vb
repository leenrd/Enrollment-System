Imports System.Data.OleDb

Public Class FrmAAM
    Dim conn As New OleDbConnection(ConnectionStr)
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
    End Sub

    Private Sub LoadAccounts()
        Dim query As String = "SELECT * FROM tblAccounts;"
        da = New OleDbDataAdapter(query, conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        DGVAccounts.DataSource = dset.Tables("tblAccounts").DefaultView
    End Sub

    Private Sub FilterAccounts(accountType As String)
        Dim query As String = "SELECT * FROM tblAccounts WHERE AccountType = '" & accountType & "';"
        da = New OleDbDataAdapter(query, conn)
        dset = New DataSet
        da.Fill(dset, "tblAccounts")
        DGVAccounts.DataSource = dset.Tables("tblAccounts").DefaultView
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadAccounts()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FilterAccounts("Admin")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FilterAccounts("Registrar")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FilterAccounts("Admission")
    End Sub
End Class

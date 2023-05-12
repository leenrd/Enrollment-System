Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmReportSections
    Private connectionString As String = ConnectionStr

    Private Sub frmReportSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the section combobox with data from tblStudents
        Dim query As String = "SELECT DISTINCT [Section] FROM tblStudents;"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim adapter As New OleDbDataAdapter()
            adapter.SelectCommand = New OleDbCommand(query, connection)
            Dim data As New DataTable()
            adapter.Fill(data)
            For Each row As DataRow In data.Rows
                cmbSections.Items.Add(row("Section").ToString())
            Next
        End Using
    End Sub

    Private Sub cmbSections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSections.SelectedIndexChanged
        'Load the students in the selected section to the datagridview
        Dim sectionName As String = cmbSections.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM tblStudents WHERE [Section]=?"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("?", sectionName)
            Dim data As New DataTable()
            adapter.Fill(data)
            dgvSections.DataSource = data
        End Using
    End Sub




    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print the data in the datagridview
        Dim printDoc As New PrintDocument()
        printDoc.DefaultPageSettings.Landscape = True
        AddHandler printDoc.PrintPage, AddressOf Me.PrintPage
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc
        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim dgv As DataGridView = dgvSections
        Dim bm As New Bitmap(dgv.Width, dgv.Height)
        dgv.DrawToBitmap(bm, New Rectangle(0, 0, dgv.Width, dgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class

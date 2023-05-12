Imports System.Data.OleDb
Module DbConnectionModule

    Public ConnectionStr As String = "Provider=Microsoft.Jet.Oledb.4.0; data source =" & Application.StartupPath & "\EnrollmentSystemDb.mdb"
    Public conn As New OleDbConnection(ConnectionStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function

End Module

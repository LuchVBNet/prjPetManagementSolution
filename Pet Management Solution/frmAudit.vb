Public Class frmAudit
    Public Shared userName As String = String.Empty
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userName = String.Empty Then
            dbKit.PopulateDataGridView("SELECT * FROM viewauditlog", dgAudit)
        Else
            dbKit.PopulateDataGridView($"SELECT `ID`, `Timestamp`, `Type`, `Module`, `Comment` FROM viewauditlog WHERE User = '{userName}'", dgAudit)
        End If
    End Sub
End Class
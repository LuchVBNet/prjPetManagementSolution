Public Class frmAudit
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbKit.PopulateDataGridView("SELECT * FROM tblAuditLog", dgAudit)
    End Sub
End Class
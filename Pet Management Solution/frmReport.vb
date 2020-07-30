Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crPets1.SummaryInfo.ReportTitle = My.Application.Info.ProductName
        crPets1.SummaryInfo.ReportAuthor = $"By {auth.FirstName} {auth.LastName}"
        Dim strQuery As String
        strQuery = "SELECT * FROM viewpetsactive"
        crPets1.Subreports.Item("ActivePets").SetDataSource(dbKit.GetQuery(strQuery))
        strQuery = "SELECT * FROM viewpetsinactive"
        crPets1.Subreports.Item("InactivePets").SetDataSource(dbKit.GetQuery(strQuery))
        CrystalReportViewer1.ReportSource = crPets1
        CrystalReportViewer1.Refresh()
        'Add Print Button Listener
        For Each ctrl As Control In CrystalReportViewer1.Controls
            If TypeOf ctrl Is System.Windows.Forms.ToolStrip Then
                AddHandler(CType(ctrl, ToolStrip).Items(1).Click), AddressOf AfterPrint
            End If
        Next
    End Sub

    Private Sub AfterPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Create action after print
        Dim strQuery As String = String.Empty
        LogPrint(strQuery, "Print form")
        dbKit.RunQuery(strQuery)
    End Sub

End Class
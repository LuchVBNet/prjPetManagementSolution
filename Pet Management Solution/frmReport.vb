Public Class frmReport
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        'Dim strQuery As String = "SELECT petID, petName, petBirthdate, petGender, tbltype.typeName, tblbreed.breedname, petNotes, tblowner.ownerName, tblowner.ownerAddress, tblowner.ownerContactNumber, petStatus FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID ORDER BY petID"
        'Dim strQuery As String = "SELECT petID, petName, petGender, petBirthdate, petStatus, petNotes FROM tblPet"
        Dim strQuery As String = "SELECT * FROM viewpetsactive"
        DisplayReport(strQuery, rptPetsActive1, CrystalReportViewer1)
    End Sub
End Class
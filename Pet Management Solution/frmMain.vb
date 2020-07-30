' Name:         Pet Management Solution
' Programmer:   James Carlo S. Luchavez on July 15, 2020

Public Class frmMain
    Private strPetName, strTypeName, strOwnerName, strBreedName, strBirthdate, strGender, strStatus, strNotes As String
    Private intPetID, intTypeID, intOwnerID, intBreedID As Integer
    Private pet As Pet
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayInformation()
        Dim strQuery As String = "SELECT petID as `ID`, petName as `Name`, petBirthdate as `Birthdate`, petGender as `Gender`, tbltype.typeName as `Type`, tblbreed.breedname as `Breed`, petNotes as `Notes`, tblowner.ownerName as `Owner`, tblowner.ownerAddress as `Address`, tblowner.ownerContactNumber as `Contact`, petStatus as `Status` FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID ORDER BY petID"
        txtID.Text = dbKit.TableLastID("tblpet", "petID") + 1
        strQuery = "SELECT * FROM tbltype"
        dbKit.PopulateComboBox(strQuery, "typeID", "typeName", cboType)
        strQuery = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        dbKit.PopulateComboBox(strQuery, "breedID", "breedName", cboBreed)
        strQuery = "SELECT * FROM tblowner"
        dbKit.PopulateComboBox(strQuery, "ownerID", "ownerName", cboOwner)
        ' Additional Behaviors
        txtSearch.Text = String.Empty
        rdoAll.Checked = True
        refreshDataGridView()
        btnNew.PerformClick()
    End Sub

    Private Sub cboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboType.SelectionChangeCommitted
        Dim strQuery As String = $"SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = {cboType.SelectedValue}"
        cboBreed.Text = String.Empty
        dbKit.PopulateComboBox(strQuery, "breedID", "breedName", cboBreed)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Integer.TryParse(txtID.Text, intPetID)
        strPetName = txtName.Text
        strBirthdate = CDate(txtBirthdate.Text).ToString("yyyy-MM-dd")
        strGender = cboGender.Text
        intBreedID = cboBreed.SelectedValue
        intOwnerID = cboOwner.SelectedValue
        strNotes = txtNotes.Text
        strStatus = cboStatus.Text
        Try
            pet = New Pet(intPetID, intOwnerID, strPetName, strBirthdate, strGender, intBreedID, strNotes)
            refreshDataGridView()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: btnSave_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgPets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPets.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnPrint.Enabled = False
        Try
            'Create a Pet Object
            pet = New Pet(CType(dgPets.Item("ID", e.RowIndex).Value, Integer))
            txtID.Text = pet.ID
            txtName.Text = pet.Name
            txtBirthdate.Text = pet.Birthdate
            cboGender.SelectedItem = pet.Gender
            cboType.SelectedValue = pet.Type.ID
            'Start of Update (cbobreed)
            Dim strQuery As String = $"SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = {cboType.SelectedValue}"
            dbKit.PopulateComboBox(strQuery, "breedID", "breedName", cboBreed)
            'End of Update
            cboBreed.SelectedValue = pet.Breed.ID
            cboOwner.Text = pet.Owner.Name
            txtNotes.Text = pet.Notes
            cboStatus.SelectedItem = pet.Status
        Catch ex As Exception
            MessageBox.Show("Error: dgPets_CellClick() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        pet = Nothing
        txtID.Text = dbKit.TableLastID("tblpet", "petID") + 1
        btnSave.Enabled = True
        btnPrint.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtName.Text = String.Empty
        txtBirthdate.Text = String.Empty
        cboGender.SelectedIndex = 0
        cboType.SelectedIndex = 0
        cboBreed.SelectedIndex = 0
        cboOwner.SelectedIndex = 0
        txtNotes.Text = String.Empty
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        pet.Name = txtName.Text
        pet.Birthdate = txtBirthdate.Text
        pet.Gender = cboGender.Text
        pet.Breed = New PetBreed(cboBreed.SelectedValue)
        pet.Owner = New PetOwner(cboOwner.SelectedValue)
        pet.Notes = txtNotes.Text
        pet.Status = cboStatus.Text
        Try
            pet.Update()
            refreshDataGridView()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: btnUpdate_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub refreshDataGridView()
        Dim strQuery As String = "SELECT petID as 'ID', petName as 'Name', petBirthdate as 'Birth', petGender as 'Gender', tbltype.typeName as 'Type', tblbreed.breedname as 'Breed', tblowner.ownerName as 'Owner', tblowner.ownerAddress as 'Address', tblowner.ownerContactNumber as 'Phone', petNotes as 'Notes', petStatus as 'Status' FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID"
        'Active Status Filter
        If rdoActive.Checked Then
            strQuery += " WHERE petStatus = 'Active'"
        ElseIf rdoInactive.Checked Then
            strQuery += " WHERE petStatus = 'Inactive'"
        End If
        'Search Filter
        If txtSearch.Text.Trim.Length <> 0 Then
            Dim strSearch = "'%" & txtSearch.Text.Trim & "%'"
            strQuery += If(strQuery.Contains("WHERE"), " AND (", " WHERE ") & "petID LIKE " & strSearch & " OR petName LIKE " & strSearch & " OR petBirthdate LIKE " & strSearch & " OR petGender LIKE " & strSearch & " OR tbltype.typeName LIKE " & strSearch & " OR tblbreed.breedname LIKE " & strSearch & " OR petNotes LIKE " & strSearch & " OR tblowner.ownerName LIKE " & strSearch & " OR tblowner.ownerAddress LIKE " & strSearch & " OR tblowner.ownerContactNumber LIKE " & strSearch & If(strQuery.Contains("WHERE"), ")", "")
        End If
        strQuery += " ORDER BY petID"
        dbKit.PopulateDataGridView(strQuery, dgPets)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Integer.TryParse(txtID.Text, intPetID)
        pet = New Pet(intPetID)
        pet.UpdateStatus("Inactive")
        refreshDataGridView()
        btnNew.PerformClick()
    End Sub

    Private Sub rdoButton_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        refreshDataGridView()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshDataGridView()
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        Dim form As New frmType
        form.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tbltype"
        dbKit.PopulateComboBox(strQuery, "typeID", "typeName", cboType)
    End Sub

    Private Sub btnAddBreed_Click(sender As Object, e As EventArgs) Handles btnAddBreed.Click
        Dim form As New frmBreed
        form.PetTypeID = cboType.SelectedValue.ToString
        form.PetType = cboType.Text
        form.ShowDialog()
        Dim strQuery As String = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        dbKit.PopulateComboBox(strQuery, "breedID", "breedName", cboBreed)
    End Sub

    Private Sub btnAddOwner_Click(sender As Object, e As EventArgs) Handles btnAddOwner.Click
        Dim form As New frmOwner
        form.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tblowner"
        dbKit.PopulateComboBox(strQuery, "ownerID", "ownerName", cboOwner)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim form As New frmReport
        form.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub AboutPMSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim form As New frmAboutUs
        form.ShowDialog()
    End Sub

    Private Sub TestConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestConnectionToolStripMenuItem.Click
        dbKit.TestConnection()
    End Sub

    Private Sub DisplayInformation()
        Me.Text = My.Application.Info.ProductName
        lblUsername.Text = "Username: " & auth.Username
        lblFullName.Text = "Hello, " & auth.Type & " " & auth.FirstName & " " & auth.LastName & "!"
        statusDeveloped.Text = "Developed by: " & My.Application.Info.CompanyName & " | " & My.Application.Info.Copyright
    End Sub

    Private Sub TypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeToolStripMenuItem.Click
        btnAddType.PerformClick()
    End Sub

    Private Sub BreedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BreedToolStripMenuItem.Click
        btnAddBreed.PerformClick()
    End Sub

    Private Sub OwnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OwnerToolStripMenuItem.Click
        btnAddOwner.PerformClick()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim form As New frmUsers
        form.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim form As New frmAboutUs
        form.ShowDialog()
    End Sub

    Private Sub AuditLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditLogsToolStripMenuItem.Click
        Dim form As New frmAudit
        form.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CloseProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseProgramToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        auth.SigningOut()
    End Sub
End Class

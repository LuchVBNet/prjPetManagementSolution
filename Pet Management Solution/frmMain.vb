' Name:         Pet Management Solution
' Programmer:   James Carlo S. Luchavez on July 15, 2020

Public Class frmMain
    Private strPetName, strTypeName, strOwnerName, strBreedName, strBirthdate, strGender, strStatus, strNotes As String
    Private intPetID, intTypeID, intOwnerID, intBreedID As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayInformation()
        AddHandler pnlPet.PanelSelected, AddressOf PetSelected
        AddHandler Pet.AddedNewPet, AddressOf AddNewPet
        txtID.Text = dbKit.TableLastID(Pet.TableName, "petID") + 1
        PetType.PopulateComboBox(cboType)
        PetBreed.PopulateComboBox(cboBreed, cboType.SelectedValue)
        PetOwner.PopulateComboBox(cboOwner)
        cboGender.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        btnToggleStatus.Enabled = False
        refreshDataGridView()
    End Sub

    Private Sub AddNewPet(intID As Integer)
        pnlFlow.Controls.Add(New pnlPet(intID))
    End Sub

    Private Sub cboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboType.SelectionChangeCommitted
        PetBreed.PopulateComboBox(cboBreed, cboType.SelectedValue)
    End Sub

    Private Sub dgPets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPets.CellClick
        Try
            PetSelected(CType(dgPets.Item("ID", e.RowIndex).Value, Integer))
        Catch ex As Exception
            MessageBox.Show("Error: dgPets_CellClick() " & ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        mod_pet.ToggleStatus()
        btnClear.PerformClick()
        If tabViews.SelectedTab IsNot Nothing AndAlso tabViews.SelectedTab.Text = "Table View" Then
            refreshDataGridView()
        End If
    End Sub

    Private Sub refreshDataGridView() Handles rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged, tabViews.SelectedIndexChanged
        Dim strQuery As String = dbKit.GetSearchQuery(Pet.ViewName, txtSearch.Text.Trim, If(rdoAll.Checked, String.Empty, If(rdoActive.Checked, "Active", "Inactive")))
        If tabViews.SelectedTab IsNot Nothing AndAlso tabViews.SelectedTab.Text = "Grid View" Then 'this is for grid view
            pnlFlow.SuspendLayout()
            DisposeEverything(pnlFlow)
            For Each row As DataRow In dbKit.GetQuery(strQuery).Rows
                pnlFlow.Controls.Add(New pnlPet(CType(row(0), Integer)))
            Next
            pnlFlow.ResumeLayout()
        Else 'this is for table
            dbKit.PopulateDataGridView(strQuery, dgPets)
        End If
        GC.Collect()
    End Sub

    Public Sub PetSelected(intID As Integer)
        'Prepare Form
        btnConfirm.Text = "UPDATE"
        btnToggleStatus.Enabled = True
        'Create a Pet Object
        mod_pet = New Pet(intID)
        txtID.Text = mod_pet.ID
        txtName.Text = mod_pet.Name
        dtpBirth.Value = mod_pet.Birthdate
        cboGender.SelectedItem = mod_pet.Gender
        cboType.SelectedValue = mod_pet.Type.ID
        'Start of Update (cbobreed)
        PetBreed.PopulateComboBox(cboBreed, cboType.SelectedValue)
        'End of Update
        cboBreed.SelectedValue = mod_pet.Breed.ID
        cboOwner.Text = mod_pet.Owner.Name
        txtNotes.Text = mod_pet.Notes
        cboStatus.SelectedItem = mod_pet.Status
        If mod_pet.Status <> "Active" Then
            btnToggleStatus.Text = "ACTIVATE"
            btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
        Else
            btnToggleStatus.Text = "DEACTIVATE"
            btnToggleStatus.BackColor = System.Drawing.Color.Salmon
        End If
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click, TypeToolStripMenuItem.Click
        Dim form As New frmType
        form.ShowDialog()
        PetType.PopulateComboBox(cboType)
    End Sub

    Private Sub btnAddBreed_Click(sender As Object, e As EventArgs) Handles btnAddBreed.Click, BreedToolStripMenuItem.Click
        Dim form As New frmBreed
        mod_breed = New PetBreed(cboType.SelectedValue)
        form.ShowDialog()
        PetBreed.PopulateComboBox(cboBreed, cboType.SelectedValue)
    End Sub

    Private Sub btnAddOwner_Click(sender As Object, e As EventArgs) Handles btnAddOwner.Click, OwnerToolStripMenuItem.Click
        Dim form As New frmOwner
        form.ShowDialog()
        PetOwner.PopulateComboBox(cboOwner)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim form As New frmReport
        form.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnConfirm.Text = "ADD" Then
            Integer.TryParse(txtID.Text, intPetID)
            strPetName = txtName.Text
            strBirthdate = CDate(dtpBirth.Value).ToString("yyyy-MM-dd")
            strGender = cboGender.Text
            intBreedID = cboBreed.SelectedValue
            intOwnerID = cboOwner.SelectedValue
            strNotes = txtNotes.Text
            strStatus = cboStatus.Text
            Try
                mod_pet = New Pet(intPetID, intOwnerID, strPetName, strBirthdate, strGender, intBreedID, strNotes)
            Catch ex As Exception
                MessageBox.Show("Error: btnSave_Click() " & ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            mod_pet.Name = txtName.Text
            mod_pet.Birthdate = dtpBirth.Value
            mod_pet.Gender = cboGender.Text
            mod_pet.Breed = New PetBreed(cboBreed.SelectedValue)
            mod_pet.Owner = New PetOwner(cboOwner.SelectedValue)
            mod_pet.Notes = txtNotes.Text
            mod_pet.Status = cboStatus.Text
            Try
                mod_pet.Update()
            Catch ex As Exception
                MessageBox.Show("Error: btnUpdate_Click() " & ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If tabViews.SelectedTab IsNot Nothing AndAlso tabViews.SelectedTab.Text = "Table View" Then
            refreshDataGridView()
        End If
        btnClear.PerformClick()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            refreshDataGridView()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = dbKit.TableLastID(Pet.TableName, "petID") + 1
        btnConfirm.Text = "ADD"
        btnToggleStatus.Text = "TOGGLE"
        btnToggleStatus.BackColor = DefaultBackColor
        btnToggleStatus.Enabled = False
        txtName.Clear()
        dtpBirth.Value = Date.Now
        txtNotes.Clear()
        cboGender.SelectedIndex = 0
        cboType.SelectedIndex = 0
        cboBreed.SelectedIndex = 0
        cboOwner.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
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
        lblUsername.Text = $"Username: {auth.Username}"
        lblFullName.Text = $"Hello, {auth.Type} {auth.FirstName} {auth.LastName}!"
        statusDeveloped.Text = $"Developed by: {My.Application.Info.CompanyName} | {My.Application.Info.Copyright}"
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
        frmAudit.userName = String.Empty
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

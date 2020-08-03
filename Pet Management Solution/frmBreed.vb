Public Class frmBreed

    Private intID, intTypeID As Integer
    Private strBreedName As String

    Private Sub frmBreed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
        cboPetType.SelectedValue = mod_breed.Type.ID
    End Sub

    Private Sub refreshDataGridView()
        dbKit.PopulateDataGridView(PetBreed.ViewName, txtSearch.Text.Trim, If(rdoAll.Checked, String.Empty, If(rdoActive.Checked, "Active", "Inactive")), dgBreed)
    End Sub

    Private Sub search_Changed(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        refreshDataGridView()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Integer.TryParse(txtID.Text, intID)
        strBreedName = txtPetBreed.Text.Trim
        intTypeID = cboPetType.SelectedValue
        If btnConfirm.Text.Contains("ADD") Then
            mod_breed = New PetBreed(intID, strBreedName, intTypeID)
        Else
            mod_breed.Type = New PetType(cboPetType.SelectedValue)
            mod_breed.Name = txtPetBreed.Text.Trim
            mod_breed.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        PetType.PopulateComboBox(cboPetType)
        refreshDataGridView()
        txtID.Text = dbKit.TableLastID(PetBreed.TableName, "breedID") + 1
        cboPetType.SelectedIndex = 0
        txtPetBreed.Clear()
        btnConfirm.Text = "ADD"
        btnToggleStatus.Text = "TOGGLE"
        btnToggleStatus.BackColor = System.Drawing.SystemColors.Control
        btnToggleStatus.Enabled = False
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        mod_breed.ToggleStatus()
        btnPlus.PerformClick()
    End Sub

    Private Sub dgBreed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBreed.CellClick
        Dim i As Integer = e.RowIndex
        Try
            With dgBreed
                mod_breed = New PetBreed(CType(.Item("ID", i).Value, Integer))
                txtID.Text = mod_breed.ID
                cboPetType.SelectedValue = mod_breed.Type.ID
                txtPetBreed.Text = mod_breed.Name
                btnConfirm.Text = "UPDATE"
                btnToggleStatus.Enabled = True
                If mod_breed.Status <> "Active" Then
                    btnToggleStatus.Text = "ACTIVATE"
                    btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
                    btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlText
                Else
                    btnToggleStatus.Text = "DEACTIVATE"
                    btnToggleStatus.BackColor = System.Drawing.Color.Salmon
                    btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlLight
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
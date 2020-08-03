Public Class frmOwner

    Private Sub frmOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub refreshDataGridView()
        dbKit.PopulateDataGridView(PetOwner.ViewName, txtSearch.Text.Trim, If(rdoAll.Checked, String.Empty, If(rdoActive.Checked, "Active", "Inactive")), dgOwner)
    End Sub

    Private Sub search_Changed(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        refreshDataGridView()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intID As Integer = CType(txtID.Text, Integer)
        Dim strName As String = txtName.Text.Trim
        Dim strAddress As String = txtAddress.Text.Trim
        Dim strPhone As String = txtPhone.Text.Trim
        If btnConfirm.Text.Contains("ADD") Then
            mod_owner = New PetOwner(intID, strName, strAddress, strPhone)
        Else
            mod_owner.Name = txtName.Text
            mod_owner.Address = txtAddress.Text
            mod_owner.Phone = txtPhone.Text
            mod_owner.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        mod_owner.ToggleStatus()
        btnPlus.PerformClick()
    End Sub

    Private Sub dgOwner_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOwner.CellClick
        'Create a Pet Owner Object
        Try
            mod_owner = New PetOwner(CType(dgOwner.Item("ID", e.RowIndex).Value, Integer))
            'Populate the Text Boxes / Combo Boxes
            txtID.Text = mod_owner.ID
            txtName.Text = mod_owner.Name
            txtAddress.Text = mod_owner.Address
            txtPhone.Text = mod_owner.Phone
            btnConfirm.Text = "UPDATE"
            btnToggleStatus.Enabled = True
            If mod_owner.Status <> "Active" Then
                btnToggleStatus.Text = "ACTIVATE"
                btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
                btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlText
            Else
                btnToggleStatus.Text = "DEACTIVATE"
                btnToggleStatus.BackColor = System.Drawing.Color.Salmon
                btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlLight
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        refreshDataGridView()
        txtID.Text = dbKit.TableLastID(PetOwner.TableName, "ownerID") + 1
        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        btnConfirm.Text = "ADD"
        btnToggleStatus.Text = "TOGGLE"
        btnToggleStatus.BackColor = System.Drawing.SystemColors.Control
        btnToggleStatus.Enabled = False
    End Sub
End Class
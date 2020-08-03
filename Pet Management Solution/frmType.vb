Public Class frmType
    Private intID As Integer
    Private strTypeName As String

    Private Sub frmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub refreshDataGridView()
        dbKit.PopulateDataGridView(PetType.ViewName, txtSearch.Text.Trim, If(rdoAll.Checked, String.Empty, If(rdoActive.Checked, "Active", "Inactive")), dgType)
    End Sub

    Private Sub search_Changed(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        refreshDataGridView()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Integer.TryParse(txtID.Text, intID)
        strTypeName = txtPetType.Text
        If btnConfirm.Text.Contains("ADD") Then
            mod_type = New PetType(intID, strTypeName)
        Else
            mod_type.Name = txtPetType.Text
            mod_type.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        refreshDataGridView()
        txtID.Text = dbKit.TableLastID(PetType.TableName, "typeID") + 1
        txtPetType.Clear()
        btnConfirm.Text = "ADD"
        btnToggleStatus.Text = "TOGGLE"
        btnToggleStatus.BackColor = System.Drawing.SystemColors.Control
        btnToggleStatus.Enabled = False
    End Sub

    Private Sub dgType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgType.CellClick
        Dim i As Integer = e.RowIndex
        Try
            With dgType
                mod_type = New PetType(CType(.Item("ID", i).Value, Integer))
                'Set textbox
                txtID.Text = mod_type.ID
                txtPetType.Text = mod_type.Name
                btnConfirm.Text = "UPDATE"
                btnToggleStatus.Enabled = True
                If mod_type.Status <> "Active" Then
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

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        mod_type.ToggleStatus()
        btnPlus.PerformClick()
    End Sub
End Class
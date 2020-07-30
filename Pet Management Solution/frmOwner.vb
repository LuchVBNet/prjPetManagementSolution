Public Class frmOwner
    Private petOwner As PetOwner

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intID As Integer = CType(txtID.Text, Integer)
        Dim strName As String = txtName.Text.Trim
        Dim strAddress As String = txtAddress.Text.Trim
        Dim strPhone As String = txtPhone.Text.Trim
        If btnConfirm.Text.Contains("ADD") Then
            petOwner = New PetOwner(intID, strName, strAddress, strPhone)
        Else
            petOwner.Name = txtName.Text
            petOwner.Address = txtAddress.Text
            petOwner.Phone = txtPhone.Text
            petOwner.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim intID As Integer
        Integer.TryParse(txtID.Text, intID)
        petOwner = New PetOwner(intID)
        petOwner.UpdateStatus("Active")
        btnPlus.PerformClick()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Dim intID As Integer
        Integer.TryParse(txtID.Text, intID)
        petOwner = New PetOwner(intID)
        petOwner.UpdateStatus("Inactive")
        btnPlus.PerformClick()
    End Sub

    Private Sub dgOwner_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOwner.CellClick
        btnConfirm.Text = "UPDATE"
        'Create a Pet Owner Object
        petOwner = New PetOwner(CType(dgOwner.Item("ownerID", e.RowIndex).Value, Integer))
        'Populate the Text Boxes / Combo Boxes
        txtID.Text = petOwner.ID
        txtName.Text = petOwner.Name
        txtAddress.Text = petOwner.Address
        txtPhone.Text = petOwner.Phone
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim strQuery As String = "SELECT * FROM tblowner"
        dbKit.PopulateDataGridView(strQuery, dgOwner)
        txtID.Text = dbKit.TableLastID("tblowner", "ownerID") + 1
        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        btnConfirm.Text = "ADD"
    End Sub
End Class
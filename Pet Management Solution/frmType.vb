Public Class frmType
    Private type As PetType
    Private intID As Integer
    Private strTypeName As String

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Integer.TryParse(txtID.Text, intID)
        strTypeName = txtPetType.Text
        If btnConfirm.Text.Contains("ADD") Then
            type = New PetType(intID, strTypeName)
        Else
            type.Name = txtPetType.Text
            type.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim strQuery As String = "SELECT * FROM viewtypetally"
        dbKit.PopulateDataGridView(strQuery, dgTypeTally)
        txtID.Text = dbKit.TableLastID("tbltype", "typeID") + 1
        txtPetType.Clear()
        btnConfirm.Text = "ADD"
    End Sub

    Private Sub dgTypeTally_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTypeTally.CellClick
        btnConfirm.Text = "UPDATE"
        Dim i As Integer = e.RowIndex
        Try
            With dgTypeTally
                type = New PetType(CType(.Item("ID", i).Value, Integer))
                'Set textbox
                txtID.Text = type.ID
                txtPetType.Text = type.Name
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Integer.TryParse(txtID.Text, intID)
        type = New PetType(intID)
        type.UpdateStatus("Active")
        btnPlus.PerformClick()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Integer.TryParse(txtID.Text, intID)
        type = New PetType(intID)
        type.UpdateStatus("Inactive")
        btnPlus.PerformClick()
    End Sub
End Class
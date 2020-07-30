Public Class frmBreed

    Private _intPetType As Integer
    Private _strPetType As String
    Private breed As PetBreed
    Private intID, intTypeID As Integer
    Private strBreedName As String

    Public WriteOnly Property PetTypeID As Integer
        Set(value As Integer)
            _intPetType = value
        End Set
    End Property

    Public WriteOnly Property PetType As String
        Set(value As String)
            _strPetType = value
        End Set
    End Property

    Private Sub frmBreed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
        cboPetType.SelectedValue = _intPetType
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Integer.TryParse(txtID.Text, intID)
        strBreedName = txtPetBreed.Text.Trim
        intTypeID = cboPetType.SelectedValue
        If btnConfirm.Text.Contains("ADD") Then
            breed = New PetBreed(intID, strBreedName, intTypeID)
        Else
            breed.Type = New PetType(cboPetType.SelectedValue)
            breed.Name = txtPetBreed.Text.Trim
            breed.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim strQuery As String = "SELECT * FROM tbltype"
        dbKit.PopulateComboBox(strQuery, "typeID", "typeName", cboPetType)
        strQuery = "SELECT * FROM viewbreedtally"
        dbKit.PopulateDataGridView(strQuery, dgBreed)
        txtID.Text = dbKit.TableLastID("tblbreed", "breedID") + 1
        cboPetType.SelectedIndex = 0
        txtPetBreed.Clear()
        btnConfirm.Text = "ADD"
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Integer.TryParse(txtID.Text, intID)
        breed = New PetBreed(intID)
        breed.UpdateStatus("Active")
        btnPlus.PerformClick()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Integer.TryParse(txtID.Text, intID)
        breed = New PetBreed(intID)
        breed.UpdateStatus("Inactive")
        btnPlus.PerformClick()
    End Sub

    Private Sub dgBreed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBreed.CellClick
        btnConfirm.Text = "UPDATE"
        Dim i As Integer = e.RowIndex
        Try
            With dgBreed
                breed = New PetBreed(CType(.Item("ID", i).Value, Integer))
                txtID.Text = breed.ID
                cboPetType.SelectedValue = breed.Type.ID
                txtPetBreed.Text = breed.Name
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
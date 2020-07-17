Public Class frmBreed

    Private _intPetType As String

    Public WriteOnly Property PetTypeID As Integer
        Set(value As Integer)
            _intPetType = value
        End Set
    End Property

    Private Sub frmBreed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPetType.Text = GetPetType(_intPetType)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strPetBreed As String = txtPetBreed.Text.Trim
        Dim strQuery As String
        Try
            strQuery = "INSERT INTO tblbreed (breedname, typeID) VALUES ('" & strPetBreed & "', '" & _intPetType.ToString & "')"
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record saved.")
            'refreshDataGridView()
            'btnNew.PerformClick()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: btnConfirm_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
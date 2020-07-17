Public Class frmType
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strPetType As String = txtPetType.Text.Trim
        Dim strQuery As String
        Try
            strQuery = "INSERT INTO tbltype (typeName) VALUES ('" & strPetType & "')"
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record saved.")
            'refreshDataGridView()
            'btnNew.PerformClick()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: btnSave_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
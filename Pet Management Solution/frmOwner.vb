Public Class frmOwner
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strName As String = txtName.Text
        Dim strAddress As String = txtAddress.Text
        Dim strPhone As String = txtPhone.Text
        Dim strQuery As String
        Try
            strQuery = "INSERT INTO tblowner (ownerName, ownerAddress, ownerContactNumber) VALUES ('" & strName & "', '" & strAddress & "', '" & strPhone & "')"
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record saved.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: btnConfirm_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
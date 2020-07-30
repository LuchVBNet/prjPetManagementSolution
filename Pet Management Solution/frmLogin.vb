Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim form As New frmMain
        auth = New User(txtUser.Text, txtPass.Text)
        If auth.LoggedIn Then
            Me.Hide()
            form.ShowDialog()
            txtUser.Clear()
            txtPass.Clear()
            Try
                Me.Show()
            Catch ex As Exception

            End Try
        ElseIf auth.Username <> String.Empty AndAlso Not auth.IsActive Then
            MessageBox.Show("Access denied. User is deactivated already. Contact system administrator.", "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Access denied. Invalid username or password.", "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class

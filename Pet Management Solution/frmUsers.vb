Public Class frmUsers

    Private account As User
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim strQuery As String = "SELECT * FROM viewusers"
        dbKit.PopulateDataGridView(strQuery, dgUsers)
        txtID.Text = dbKit.TableLastID("tbluser", "userID") + 1
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPassword2.Clear()
        cboType.SelectedIndex = 0
        btnConfirm.Text = "ADD"
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intID As String = CType(txtID.Text, Integer)
        Dim strFirstName As String = txtFirstName.Text.Trim
        Dim strLastName As String = txtLastName.Text.Trim
        Dim strPhone As String = txtPhone.Text.Trim
        Dim strUsername As String = txtUsername.Text.Trim
        Dim strPassword As String = txtPassword.Text.Trim
        Dim strPassword2 As String = txtPassword2.Text.Trim
        Dim intType As Integer = cboType.SelectedIndex
        Dim strQuery As String = String.Empty
        If btnConfirm.Text.Contains("ADD") Then
            If strPassword = strPassword2 Then
                account = New User(intID, strFirstName, strLastName, strPhone, strUsername, strPassword, intType)
            Else
                MessageBox.Show("Account creation failed. Password mismatch. Retype password.", "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            account.FirstName = strFirstName
            account.LastName = strLastName
            account.Phone = strPhone
            account.Username = strUsername
            account.Password = If(strPassword = strPassword2, strPassword, "")
            account.TypeID = intType
            account.Update()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim intID As String = CType(txtID.Text, Integer)
        account = New User(intID)
        account.UpdateStatus("Active")
        btnPlus.PerformClick()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Dim intID As String = CType(txtID.Text, Integer)
        account = New User(intID)
        account.UpdateStatus("Inactive")
        btnPlus.PerformClick()
    End Sub

    Private Sub dgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellClick
        btnConfirm.Text = "UPDATE"
        Dim i As Integer = e.RowIndex
        Try
            With dgUsers
                account = New User(CType(.Item("ID", i).Value, Integer))
                txtFirstName.Text = account.FirstName
                txtLastName.Text = account.LastName
                txtPhone.Text = account.Phone
                txtUsername.Text = account.Username
                cboType.SelectedItem = account.Type
            End With
        Catch ex As Exception
            MessageBox.Show("Error: dgUsers_CellClick() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
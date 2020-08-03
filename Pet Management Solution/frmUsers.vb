Public Class frmUsers

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler pnlUser.PanelSelected, AddressOf UserSelected
        AddHandler User.AddedNewUser, AddressOf AddNewUser
        btnClear.PerformClick()
        refreshDataGridView()
    End Sub

    Private Sub AddNewUser(intID As Integer)
        pnlFlow.Controls.Add(New pnlUser(intID))
    End Sub

    Private Sub UserSelected(intID As Integer)
        mod_user = New User(intID)
        lblID.Text = mod_user.ID
        txtFirstName.Text = mod_user.FirstName
        txtLastName.Text = mod_user.LastName
        txtPhone.Text = mod_user.Phone
        txtUsername.Text = mod_user.Username
        cboType.SelectedItem = mod_user.Type
        btnConfirm.Text = "UPDATE"
        btnToggleStatus.Enabled = True
        If mod_user.Status <> "Active" Then
            btnToggleStatus.Text = "ACTIVATE"
            btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
            btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Else
            btnToggleStatus.Text = "DEACTIVATE"
            btnToggleStatus.BackColor = System.Drawing.Color.Salmon
            btnToggleStatus.ForeColor = System.Drawing.SystemColors.ControlLight
        End If
    End Sub

    Private Sub refreshDataGridView() Handles tabViews.SelectedIndexChanged, rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        Dim strQuery As String = dbKit.GetSearchQuery(User.ViewName, txtSearch.Text.Trim, If(rdoAll.Checked, String.Empty, If(rdoActive.Checked, "Active", "Inactive")))
        If tabViews.SelectedTab IsNot Nothing AndAlso tabViews.SelectedTab.Text = "Grid View" Then
            pnlFlow.SuspendLayout()
            pnlFlow.Controls.Clear()
            For Each row As DataRow In dbKit.GetQuery(strQuery).Rows
                pnlFlow.Controls.Add(New pnlUser(CType(row(0), Integer)))
            Next
            pnlFlow.ResumeLayout()
        Else
            dbKit.PopulateDataGridView(strQuery, dgUser)
        End If

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intID As String = CType(lblID.Text, Integer)
        Dim strFirstName As String = txtFirstName.Text.Trim
        Dim strLastName As String = txtLastName.Text.Trim
        Dim strPhone As String = txtPhone.Text.Trim
        Dim strUsername As String = txtUsername.Text.Trim
        Dim strPassword As String = txtPassword.Text.Trim
        Dim strPassword2 As String = txtPassword2.Text.Trim
        Dim intType As Integer = cboType.SelectedIndex
        Dim strQuery As String = String.Empty
        If btnConfirm.Text.Contains("ADD") Then
            If strPassword <> String.Empty AndAlso strPassword = strPassword2 Then
                mod_user = New User(intID, strFirstName, strLastName, strPhone, strUsername, strPassword, intType)
            ElseIf strPassword = String.Empty Then
                MessageBox.Show("Account creation failed. Empty password.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Account creation failed. Password mismatch. Retype password.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            mod_user.FirstName = strFirstName
            mod_user.LastName = strLastName
            mod_user.Phone = strPhone
            mod_user.Username = strUsername
            mod_user.Password = If(strPassword <> String.Empty AndAlso strPassword = strPassword2, strPassword, String.Empty)
            mod_user.TypeID = intType
            mod_user.Update()
        End If
        btnClear.PerformClick()
    End Sub

    Private Sub dgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUser.CellClick
        Dim i As Integer = e.RowIndex
        Try
            With dgUser
                UserSelected(CType(.Item("ID", i).Value, Integer))
            End With
        Catch ex As Exception
            MessageBox.Show("ID not found.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        mod_user.ToggleStatus()
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblID.Text = dbKit.TableLastID(User.TableName, "userID") + 1
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPassword2.Clear()
        btnToggleStatus.Text = "Toggle"
        btnToggleStatus.BackColor = System.Drawing.SystemColors.Control
        btnToggleStatus.Enabled = False
        cboType.SelectedIndex = 0
        btnConfirm.Text = "ADD"
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            refreshDataGridView()
        End If
    End Sub
End Class
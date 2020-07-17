' Name:         Pet Management Solution
' Programmer:   James Carlo S. Luchavez on July 15, 2020

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        Dim strQuery As String = "SELECT petID as `ID`, petName as `Name`, petBirthdate as `Birthdate`, petGender as `Gender`, tbltype.typeName as `Type`, tblbreed.breedname as `Breed`, petNotes as `Notes`, tblowner.ownerName as `Owner`, tblowner.ownerAddress as `Address`, tblowner.ownerContactNumber as `Contact`, petStatus as `Status` FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID ORDER BY petID"
        txtID.Text = RecordCount() + 1
        strQuery = "SELECT * FROM tbltype"
        LoadQueryToComboBox(strQuery, "typeID", "typeName", cboType)
        strQuery = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        LoadQueryToComboBox(strQuery, "breedID", "breedName", cboBreed)
        strQuery = "SELECT * FROM tblowner"
        LoadQueryToComboBox(strQuery, "ownerID", "ownerName", cboOwner)

        ' Additional Behaviors
        txtSearch.Text = String.Empty
        rdoAll.Checked = True
        refreshDataGridView()
        btnNew.PerformClick()
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        dbConnectionTest()
    End Sub

    Private Sub cboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboType.SelectionChangeCommitted
        Dim strQuery As String = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        Try
            LoadQueryToComboBox(strQuery, "breedID", "breedName", cboBreed)
        Catch ex As Exception
            MessageBox.Show("Error: cboType_SelectionChangeCommitted() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strQuery As String
        Try
            strQuery = "INSERT INTO tblpet VALUES (" &
                txtID.Text & ", " &
                cboOwner.SelectedValue.ToString & ", '" &
                txtName.Text & "', '" &
                CDate(txtBirthdate.Text).ToString("yyyy-MM-dd") & "', '" &
                cboGender.Text & "', '" &
                cboStatus.Text & "', " &
                cboBreed.SelectedValue.ToString & ", '" &
                txtNotes.Text & "')"
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record saved.")
            refreshDataGridView()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: btnSave_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgPets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPets.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnPrint.Enabled = False
        Dim i As Integer = e.RowIndex
        Try
            With dgPets
                txtID.Text = .Item("petID", i).Value
                txtName.Text = .Item("petName", i).Value
                txtBirthdate.Text = .Item("petBirthdate", i).Value
                cboGender.Text = .Item("petGender", i).Value
                cboType.Text = .Item("typeName", i).Value
                cboBreed.Text = .Item("breedName", i).Value
                cboOwner.Text = .Item("ownerName", i).Value
                txtNotes.Text = .Item("petNotes", i).Value
                cboStatus.Text = .Item("petStatus", i).Value
            End With
        Catch ex As Exception
            MessageBox.Show("Error: dgPets_CellClick() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Text = RecordCount() + 1
        btnSave.Enabled = True
        btnPrint.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtName.Text = String.Empty
        txtBirthdate.Text = String.Empty
        cboGender.SelectedIndex = 0
        cboType.SelectedIndex = 0
        cboBreed.SelectedIndex = 0
        cboOwner.SelectedIndex = 0
        txtNotes.Text = String.Empty
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strQuery As String
        Try
            strQuery = "UPDATE tblpet SET petName = '" & txtName.Text & "', petBirthdate = '" & CDate(txtBirthdate.Text).ToString("yyyy-MM-dd") & "', petGender = '" & cboGender.Text & "', petBreed = " & cboBreed.SelectedValue.ToString & ", ownerID = " & cboOwner.SelectedValue.ToString & ", petNotes = '" & txtNotes.Text & "', petStatus='" & cboStatus.Text & "'  WHERE petID = " & txtID.Text
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record updated.")
            refreshDataGridView()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: btnUpdate_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadQueryToComboBox(strQuery As String, strValueColumn As String, strDisplayColumn As String, ByRef cboBox As ComboBox)
        cboBox.DataSource = LoadToComboBox(strQuery)
        cboBox.ValueMember = LoadToComboBox(strQuery).Columns(strValueColumn).ToString
        cboBox.DisplayMember = LoadToComboBox(strQuery).Columns(strDisplayColumn).ToString
    End Sub

    Private Sub refreshDataGridView()
        Dim strQuery As String = "SELECT petID, petName, petBirthdate, petGender, tbltype.typeName, tblbreed.breedname, petNotes, tblowner.ownerName, tblowner.ownerAddress, tblowner.ownerContactNumber, petStatus FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID"
        'Active Status Filter
        If rdoActive.Checked Then
            strQuery += " WHERE petStatus = 'Active'"
        ElseIf rdoInactive.Checked Then
            strQuery += " WHERE petStatus = 'Inactive'"
        End If
        'Search Filter
        If txtSearch.Text.Trim.Length <> 0 Then
            Dim strSearch = "'%" & txtSearch.Text.Trim & "%'"
            strQuery += If(strQuery.Contains("WHERE"), " AND (", " WHERE ") & "petID LIKE " & strSearch & " OR petName LIKE " & strSearch & " OR petBirthdate LIKE " & strSearch & " OR petGender LIKE " & strSearch & " OR tbltype.typeName LIKE " & strSearch & " OR tblbreed.breedname LIKE " & strSearch & " OR petNotes LIKE " & strSearch & " OR tblowner.ownerName LIKE " & strSearch & " OR tblowner.ownerAddress LIKE " & strSearch & " OR tblowner.ownerContactNumber LIKE " & strSearch & If(strQuery.Contains("WHERE"), ")", "")
        End If
        strQuery += " ORDER BY petID"
        DisplayRecords(strQuery, dgPets)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strQuery As String
        Try
            strQuery = "UPDATE tblpet SET petStatus='Inactive'  WHERE petID = " & txtID.Text
            'MsgBox(strQuery)
            SQLManager(strQuery, "Pet status set to INACTIVE.")
            refreshDataGridView()
            btnNew.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: btnDelete_Click() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rdoButton_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInactive.CheckedChanged, rdoAll.CheckedChanged, rdoActive.CheckedChanged
        refreshDataGridView()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshDataGridView()
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        Dim form As New frmType
        form.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tbltype"
        LoadQueryToComboBox(strQuery, "typeID", "typeName", cboType)
    End Sub

    Private Sub btnAddBreed_Click(sender As Object, e As EventArgs) Handles btnAddBreed.Click
        Dim form As New frmBreed
        form.PetTypeID = cboType.SelectedValue.ToString
        form.ShowDialog()
        Dim strQuery As String = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        LoadQueryToComboBox(strQuery, "breedID", "breedName", cboBreed)
    End Sub

    Private Sub btnAddOwner_Click(sender As Object, e As EventArgs) Handles btnAddOwner.Click
        Dim form As New frmOwner
        form.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tblowner"
        LoadQueryToComboBox(strQuery, "ownerID", "ownerName", cboOwner)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim form As New frmReport
        form.ShowDialog()
    End Sub
End Class

Public Class PetBreed
    Private breedID As Integer
    Private breedname As String
    Private typeID As Integer
    Private breedStatus As String
    'Queries
    Private strQuery As String
    Private strAuditLog As String
    'Tables & Views
    Private Const strTable As String = "tblbreed"
    Private Const strView As String = "viewbreed"

    'Create New Breed
    Public Sub New(intID As Integer, strBreedName As String, intTypeID As Integer)
        strQuery = $"INSERT INTO {strTable} VALUES ({intID}, '{strBreedName}', {intTypeID}, 'Active')"
        'MsgBox(strQuery)
        If dbKit.RunQuery(strQuery) Then
            MessageBox.Show("New pet breed created.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Pet Breed form", "pet breed", intID)
            dbKit.RunQuery(strAuditLog)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search Breed by ID
    Public Sub New(intID As Integer)
        strQuery = $"SELECT * FROM {strTable} WHERE breedID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                breedID = intID
                breedname = .Item("breedname")
                typeID = CType(.Item("typeID"), Integer)
                breedStatus = .Item("breedStatus")
            End With
            'MsgBox($"Hello: {breedID}, {breedname}, {typeID}, {breedStatus}")
            mod_type = New PetType(typeID)
        Else
            MsgBox("Pet breed not found.")
        End If
        ClearQueries()
    End Sub

    'Custom Functions

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE {strTable} SET breedname = '{breedname}', typeID = {mod_type.ID} WHERE breedID = {breedID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("Pet breed updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        ClearQueries()
    End Sub

    Public Sub UpdateStatus(strStatus As String)
        Me.Status = strStatus
        If strAuditLog <> String.Empty Then
            'Check first for dependency
            If strStatus = "Inactive" Then
                Dim intCount As Integer = CType(dbKit.GetQuery($"SELECT `Pet Count` FROM {strView} WHERE ID = {breedID}").Rows(0).Item("Pet Count"), Integer)
                If intCount > 0 Then
                    MessageBox.Show("Deactivation failed. Deactivate first all pets under this pet breed.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If
            strQuery = $"UPDATE {strTable} SET breedStatus='{breedStatus}' WHERE breedID = {breedID}"
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"Breed status set to {breedStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Sub ToggleStatus()
        UpdateStatus(If(breedStatus = "Active", "Inactive", "Active"))
    End Sub

    Private Sub ClearQueries()
        strQuery = String.Empty
        strAuditLog = String.Empty
    End Sub

    Public Shared Sub PopulateComboBox(ByRef cboBox As ComboBox, typeID As Integer)
        PopulateComboBox(cboBox, typeID, "Active")
    End Sub
    Public Shared Sub PopulateComboBox(ByRef cboBox As ComboBox, typeID As Integer, strStatus As String)
        Dim strQuery As String = $"SELECT * FROM {strTable} WHERE typeID = {typeID}"
        If strStatus <> String.Empty Then
            strQuery += $" AND breedStatus = '{strStatus}'"
        End If
        cboBox.Text = String.Empty
        dbKit.PopulateComboBox(strQuery, "breedID", "breedName", cboBox)
    End Sub



    'Properties
    Public Property Type As PetType
        Get
            Return mod_type
        End Get
        Set(value As PetType)
            If LogUpdate(strAuditLog, "Pet Breed form", "type name", "breed", breedID, mod_type.Name, value.Name) Then
                mod_type = value
            End If
        End Set
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return breedID
        End Get
    End Property

    Public Shared ReadOnly Property TableName As String
        Get
            Return strTable
        End Get
    End Property

    Public Shared ReadOnly Property ViewName As String
        Get
            Return strView
        End Get
    End Property

    Public Property Name As String
        Get
            Return breedname
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Pet Breed form", "breed name", "breed", breedID, breedname, value) Then
                breedname = value
            End If
        End Set
    End Property

    Public Property Status As String
        Get
            Return breedStatus
        End Get
        Set(value As String)
            value = value.Trim
            If breedStatus <> value Then
                If value <> "Active" Then
                    LogDeactivate(strAuditLog, "Pet Breed form", "pet breed", breedID)
                Else
                    LogActivate(strAuditLog, "Pet Breed form", "pet breed", breedID)
                End If
                breedStatus = value
            End If
        End Set
    End Property
End Class

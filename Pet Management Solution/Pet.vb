Public Class Pet
    Private petID As Integer
    Private ownerID As Integer
    Private petName As String
    Private petBirthdate As String
    Private petGender As String
    Private petStatus As String
    Private breedID As Integer
    Private petNotes As String
    'Queries
    Private strQuery As String
    Private strAuditLog As String
    'Tables & Views
    Private Const strTable As String = "tblpet"
    Private Const strView As String = "viewpet"
    'ColumnNames Array
    Private strColumnNames As String()
    'Event
    Public Shared Event UpdateInformation(intID As Integer)
    Public Shared Event AddedNewPet(intID As Integer)

    'Create New Pet
    Public Sub New(intPetID As Integer, intOwnerID As Integer, strPetName As String, strBirthdate As String, strGender As String, intBreedID As Integer, strNotes As String)
        strQuery = $"INSERT INTO {strTable} VALUES ({intPetID}, {intOwnerID}, '{strPetName}', '{strBirthdate}', '{strGender}', 'Active', {intBreedID}, '{strNotes}')"
        If dbKit.RunQuery(strQuery) Then
            MessageBox.Show("New pet saved.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Main form", "pet", intPetID)
            dbKit.RunQuery(strAuditLog)
            RaiseEvent AddedNewPet(intPetID)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search Pet By ID
    Public Sub New(intID As Integer)
        strQuery = $"SELECT * FROM {strTable} WHERE petID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                petID = intID
                ownerID = CType(.Item("ownerID"), Integer)
                petName = .Item("petName")
                petBirthdate = .Item("petBirthdate")
                Age = dbKit.GetQuery($"SELECT Age from {strView} WHERE ID = {intID}").Rows(0).Item("Age")
                petGender = .Item("petGender")
                petStatus = .Item("petStatus")
                breedID = CType(.Item("petBreed"), Integer)
                petNotes = .Item("petNotes")
            End With
            mod_owner = New PetOwner(ownerID)
            mod_breed = New PetBreed(breedID)
        End If
        ClearQueries()
    End Sub

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE {strTable} SET petName = '{petName}', petBirthdate = '{CDate(petBirthdate).ToString("yyyy-MM-dd")}', petGender = '{petGender}', petBreed = {mod_breed.ID}, ownerID = {mod_owner.ID}, petNotes = '{petNotes}', petStatus='{petStatus}'  WHERE petID = {petID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("Record updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
                RaiseEvent UpdateInformation(petID)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        ClearQueries()
    End Sub

    Public Sub UpdateStatus(strStatus As String)
        Me.Status = strStatus
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE {strTable} SET petStatus='{petStatus}' WHERE petID = {petID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"Pet status set to {petStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
                RaiseEvent UpdateInformation(petID)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Sub ToggleStatus()
        UpdateStatus(If(petStatus = "Active", "Inactive", "Active"))
    End Sub

    Private Sub ClearQueries()
        strQuery = String.Empty
        strAuditLog = String.Empty
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return petID
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

    Public Property Owner As PetOwner
        Get
            Return mod_owner
        End Get
        Set(value As PetOwner)
            If LogUpdate(strAuditLog, "Main form", "pet owner", "pet", petID, mod_owner.Name, value.Name) Then
                mod_owner = value
            End If
        End Set
    End Property

    Public Property Breed As PetBreed
        Get
            Return mod_breed
        End Get
        Set(value As PetBreed)
            If LogUpdate(strAuditLog, "Main form", "pet breed", "pet", petID, mod_breed.Name, value.Name) Then
                LogUpdate(strAuditLog, "Main form", "pet type", "pet", petID, mod_breed.Type.Name, value.Type.Name)
                mod_breed = value
            End If
        End Set
    End Property

    Public ReadOnly Property Type As PetType
        Get
            Return mod_breed.Type
        End Get
    End Property

    Public Property Name As String
        Get
            Return petName
        End Get
        Set(value As String)
            value = value.Trim
            If LogUpdate(strAuditLog, "Main form", "pet name", "pet", petID, petName, value) Then
                petName = value
            End If
        End Set
    End Property

    Public Property Birthdate As String
        Get
            Return petBirthdate
        End Get
        Set(value As String)
            value = value.Trim
            If LogUpdate(strAuditLog, "Main form", "pet birthdate", "pet", petID, petBirthdate, value) Then
                petBirthdate = value
            End If
        End Set
    End Property

    Public ReadOnly Property Age As String

    Public Property Gender As String
        Get
            Return petGender
        End Get
        Set(value As String)
            value = value.Trim
            If LogUpdate(strAuditLog, "Main form", "pet gender", "pet", petID, petGender, value) Then
                petGender = value
            End If
        End Set
    End Property

    Public Property Status As String
        Get
            Return petStatus
        End Get
        Set(value As String)
            value = value.Trim
            If petStatus <> value Then
                If value <> "Active" Then
                    LogDeactivate(strAuditLog, "Main form", "pet", petID)
                Else
                    LogActivate(strAuditLog, "Main form", "pet", petID)
                End If
                petStatus = value
            End If
        End Set
    End Property

    Public Property Notes As String
        Get
            Return petNotes
        End Get
        Set(value As String)
            value = value.Trim
            If LogUpdate(strAuditLog, "Main form", "pet notes", "pet", petID, petNotes, value) Then
                petNotes = value
            End If
        End Set
    End Property
End Class

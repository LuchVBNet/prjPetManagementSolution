Public Class PetBreed
    Private breedID As Integer
    Private breedname As String
    Private typeID As Integer
    Private breedStatus As String
    Private petType As PetType
    Private strQuery As String
    Private strAuditLog As String

    'Create New Breed
    Public Sub New(intID As Integer, strBreedName As String, intTypeID As Integer)
        strQuery = $"INSERT INTO tblbreed VALUES ({intID}, '{strBreedName}', {intTypeID}, 'Active')"
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
        strQuery = $"SELECT * FROM tblbreed WHERE breedID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                breedID = intID
                breedname = .Item("breedname")
                typeID = CType(.Item("typeID"), Integer)
                breedStatus = .Item("breedStatus")
            End With
            'MsgBox($"Hello: {breedID}, {breedname}, {typeID}, {breedStatus}")
            petType = New PetType(typeID)
        Else
            MsgBox("Pet breed not found.")
        End If
        ClearQueries()
    End Sub

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE tblbreed SET breedname = '{breedname}', typeID = {petType.ID} WHERE breedID = {breedID}"
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
            strQuery = $"UPDATE tblpet SET petStatus='{breedStatus}' WHERE petID = {breedID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"Breed status set to {breedStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Private Sub ClearQueries()
        strQuery = String.Empty
        strAuditLog = String.Empty
    End Sub

    Public Property Type As PetType
        Get
            Return petType
        End Get
        Set(value As PetType)
            If LogUpdate(strAuditLog, "Pet Breed form", "type name", "breed", breedID, petType.Name, value.Name) Then
                petType = value
            End If
        End Set
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return breedID
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

    Public ReadOnly Property AuditLog As String
        Get
            Return strAuditLog
        End Get
    End Property
End Class

Public Class PetType
    Private typeID As Integer
    Private typeName As String
    Private typeStatus As String
    Private strQuery As String
    Private strAuditLog As String

    'Create New Pet Type
    Public Sub New(intID As Integer, strPetType As String)
        strQuery = $"INSERT INTO tbltype VALUES ({intID}, '{strPetType}', 'Active')"
        If dbKit.RunQuery(StrQuery) Then
            MessageBox.Show("New pet type saved.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Pet Type form", "pet type", intID)
            dbKit.RunQuery(strAuditLog)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search Type by ID
    Public Sub New(intID As Integer)
        strQuery = $"SELECT * FROM tbltype WHERE typeID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                typeID = intID
                typeName = .Item("typeName")
                typeStatus = .Item("typeStatus")
            End With
            'MsgBox($"Hello: {typeID}, {typeName}, {typeStatus}")
        Else
            MsgBox("Pet breed not found.")
        End If
        ClearQueries()
    End Sub

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE tbltype SET typeName = '{typeName}' WHERE typeID = {typeID}"
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("Pet type updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Sub UpdateStatus(strStatus As String)
        Me.Status = strStatus
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE tbltype SET typeStatus='{typeStatus}' WHERE typeID = {typeID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"Pet type status set to {typeStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Public ReadOnly Property ID As Integer
        Get
            Return typeID
        End Get
    End Property

    Public Property Name As String
        Get
            Return typeName
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Pet Type form", "type name", "pet type", typeID, typeName, value) Then
                typeName = value
            End If
        End Set
    End Property

    Public Property Status As String
        Get
            Return typeStatus
        End Get
        Set(value As String)
            value = value.Trim
            If typeStatus <> value Then
                If value <> "Active" Then
                    LogDeactivate(strAuditLog, "Pet Type form", "pet", typeID)
                Else
                    LogActivate(strAuditLog, "Pet Type form", "pet", typeID)
                End If
                typeStatus = value
            End If
        End Set
    End Property

    Public ReadOnly Property AuditLog As String
        Get
            Return strAuditLog
        End Get
    End Property
End Class

Public Class PetOwner
    Private ownerID As Integer
    Private ownerName As String
    Private ownerAddress As String
    Private ownerContactNumber As String
    Private ownerStatus As String
    'Queries
    Private strQuery As String
    Private strAuditLog As String
    'Tables & Views
    Private Const strTable As String = "tblowner"
    Private Const strView As String = "viewowner"

    'Create New Owner
    Public Sub New(intID As Integer, strName As String, strAddress As String, strPhone As String)
        strQuery = $"INSERT INTO {TableName} VALUES ({intID},'{strName}', '{strAddress}', '{strPhone}', 'Active')"
        If dbKit.RunQuery(strQuery) Then
            MessageBox.Show("New pet owner registered.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Pet Owner form", "owner", intID)
            dbKit.RunQuery(strAuditLog)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search Owner by ID
    Public Sub New(intID As Integer)
        Dim dt As DataTable = dbKit.GetQuery($"SELECT * FROM {TableName} WHERE ownerID = {intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                ownerID = intID
                ownerName = .Item("ownerName")
                ownerAddress = .Item("ownerAddress")
                ownerContactNumber = .Item("ownerContactNumber")
                ownerStatus = .Item("ownerStatus")
            End With
            'MsgBox($"Hello: {ownerName},{ownerAddress}, {ownerContactNumber}, {ownerStatus}")
        Else
            MsgBox("Pet owner not found.")
        End If
    End Sub

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE {strTable} SET ownerName = '{ownerName}', ownerAddress = '{ownerAddress}', ownerContactNumber = '{ownerContactNumber}' WHERE ownerID = {ownerID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("Pet owner updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                Dim intCount As Integer = CType(dbKit.GetQuery($"SELECT `Pet Count` FROM {strView} WHERE ID = {ownerID}").Rows(0).Item("Pet Count"), Integer)
                If intCount > 0 Then
                    MessageBox.Show("Deactivation failed. Deactivate first all pets under this pet owner.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If
            strQuery = $"UPDATE {strTable} SET ownerStatus='{ownerStatus}' WHERE ownerID = {ownerID}"
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"Owner status set to {ownerStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Sub ToggleStatus()
        UpdateStatus(If(ownerStatus = "Active", "Inactive", "Active"))
    End Sub

    Private Sub ClearQueries()
        strQuery = String.Empty
        strAuditLog = String.Empty
    End Sub

    Public Shared Sub PopulateComboBox(ByRef cboBox As ComboBox)
        PopulateComboBox(cboBox, "Active")
    End Sub
    Public Shared Sub PopulateComboBox(ByRef cboBox As ComboBox, strStatus As String)
        cboBox.Text = String.Empty
        dbKit.PopulateComboBox(cboBox, strView, strStatus)
    End Sub

    'Properties
    Public ReadOnly Property ID As Integer
        Get
            Return ownerID
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
            Return ownerName
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Pet Owner form", "owner name", "owner", ownerID, ownerName, value) Then
                ownerName = value
            End If
        End Set
    End Property

    Public Property Address As String
        Get
            Return ownerAddress
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Pet Owner form", "owner address", "owner", ownerID, ownerAddress, value) Then
                ownerAddress = value
            End If
        End Set
    End Property

    Public Property Phone As String
        Get
            Return ownerContactNumber
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Pet Owner form", "owner phone", "owner", ownerID, ownerContactNumber, value) Then
                ownerContactNumber = value
            End If
        End Set
    End Property

    Public Property Status As String
        Get
            Return ownerStatus
        End Get
        Set(value As String)
            value = value.Trim
            If ownerStatus <> value Then
                If value <> "Active" Then
                    LogDeactivate(strAuditLog, "Pet Owner form", "owner", ownerID)
                Else
                    LogActivate(strAuditLog, "Pet Owner form", "owner", ownerID)
                End If
                ownerStatus = value
            End If
        End Set
    End Property
End Class

Public Class User
    Private userFirstName As String
    Private userLastName As String
    Private userContactNum As String
    Private strUsername As String
    Private userPassword As String
    Private userType As Integer
    Private strType As String
    Private userStatus As String
    'Queries
    Private strQuery As String
    Private strAuditLog As String
    'Tables & Views
    Private Const strTable As String = "tbluser"
    Private Const strView As String = "viewuser"
    'Events
    Public Shared Event UpdateInformation(intID As Integer)
    Public Shared Event AddedNewUser(intID As Integer)

    ' User Signing In
    Public Sub New(strUser As String, strPass As String)
        strQuery = $"SELECT * FROM {strTable} WHERE userName = '{strUser}' LIMIT 1"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        Dim isValid As Boolean
        If dt.Rows.Count() > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With row
                ID = CType(.Item("userID"), Integer)
                userFirstName = .Item("userFirstName")
                userLastName = .Item("userLastName")
                userContactNum = .Item("userContactNum")
                strUsername = .Item("userName")
                userPassword = String.Empty
                userType = CType(.Item("userType"), Integer)
                userStatus = .Item("userStatus")
            End With
            isValid = CheckPassword(strUsername, strPass)
            If isValid AndAlso userStatus = "Active" Then
                LoggedIn = True
            Else
                LoggedIn = False
            End If
            SigningIn()
        Else
            LoggedIn = False
        End If
        ClearQueries()
    End Sub

    'Create New User
    Public Sub New(intUserID As Integer, strFirstName As String, strLastName As String, strPhone As String, strUsername As String, strPassword As String, intType As Integer)
        strQuery = $"INSERT INTO {strTable} VALUES ({intUserID},'{strFirstName}', '{strLastName}', '{strPhone}', '{strUsername}', md5('{strPassword}'), {intType}, 'Active')"
        If dbKit.RunQuery(strQuery) Then
            MessageBox.Show("New account created.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Users form", "account", intUserID)
            dbKit.RunQuery(strAuditLog)
            RaiseEvent AddedNewUser(intUserID)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search User By ID
    Public Sub New(intID As Integer)
        strQuery = $"SELECT * FROM {strTable} WHERE userID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                ID = intID
                userFirstName = .Item("userFirstName")
                userLastName = .Item("userLastName")
                userContactNum = .Item("userContactNum")
                strUsername = .Item("userName")
                userType = CType(.Item("userType"), Integer)
                userStatus = .Item("userStatus")
            End With
        Else
            MsgBox("User not found.")
        End If
        ClearQueries()
    End Sub

    Public Sub Update()
        If strAuditLog <> String.Empty Then
            If userPassword = String.Empty Then
                strQuery = $"UPDATE {strTable} SET userFirstName = '{userFirstName}', userLastName = '{userLastName}', userContactNum = '{userContactNum}', userName = '{strUsername}', userType = '{userType}' WHERE userID = {ID}"
            Else
                strQuery = $"UPDATE {strTable} SET userFirstName = '{userFirstName}', userLastName = '{userLastName}', userContactNum = '{userContactNum}', userName = '{strUsername}', userPassword = md5('{userPassword}'), userType = '{userType}' WHERE userID = {ID}"
            End If
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("User account updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
                RaiseEvent UpdateInformation(ID)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        ClearQueries()
    End Sub

    Public Sub UpdateStatus(strStatus As String)
        Me.Status = strStatus
        If strAuditLog <> String.Empty Then
            strQuery = $"UPDATE {strTable} SET userStatus='{userStatus}' WHERE userID = {ID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"User status set to {userStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
                RaiseEvent UpdateInformation(ID)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Sub ToggleStatus()
        UpdateStatus(If(userStatus = "Active", "Inactive", "Active"))
    End Sub

    Public Shared Function CheckPassword(strUser As String, strPass As String) As Boolean
        If strPass = String.Empty Then
            Return False
        End If
        Dim strQuery As String = $"SELECT userPassword = md5('{strPass}') AS `Valid` FROM {strTable} WHERE userName = '{strUser}'"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        Return CType(dt.Rows(0).Item("Valid"), Integer) = 1
    End Function

    Private Sub SigningIn()
        If LoggedIn Then
            LogValidLogin(strAuditLog, ID)
        Else
            LogInvalidLogin(strAuditLog, ID)
        End If
        dbKit.RunQuery(strAuditLog)
    End Sub

    Public Sub SigningOut()
        If LoggedIn Then
            LogLogout(strAuditLog)
            dbKit.RunQuery(strAuditLog)
        End If
    End Sub

    Private Sub ClearQueries()
        strQuery = String.Empty
        strAuditLog = String.Empty
    End Sub

    ' Properties
    Public ReadOnly Property LoggedIn As Boolean

    Public ReadOnly Property ID As Integer

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

    Public Property Username As String
        Get
            Return strUsername
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "username", "account", ID, strUsername, value) Then
                strUsername = value
            End If
        End Set
    End Property

    Public WriteOnly Property Password As String
        Set(value As String)
            If LogUpdatePassword(strAuditLog, "Users form", "password", "account", ID, strUsername, value) Then
                userPassword = value
            Else
                userPassword = String.Empty
            End If
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return userFirstName
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "first name", "account", ID, userFirstName, value) Then
                userFirstName = value
            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return userLastName
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "last name", "account", ID, userLastName, value) Then
                userLastName = value
            End If
        End Set
    End Property

    Public Property Phone As String
        Get
            Return userContactNum
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "phone", "account", ID, userContactNum, value) Then
                userContactNum = value
            End If
        End Set
    End Property

    Public Property TypeID As Integer
        Get
            Return userType
        End Get
        Set(value As Integer)
            If LogUpdate(strAuditLog, "Users form", "user type", "account", ID, Type, If(value = 0, "Encoder", "Admin")) Then
                userType = value
            End If
        End Set
    End Property

    Public ReadOnly Property Type As String
        Get
            Return If(userType = 0, "Encoder", "Admin")
        End Get
    End Property



    Public Property Status As String
        Get
            Return userStatus
        End Get
        Set(value As String)
            value = value.Trim
            If userStatus <> value Then
                If value <> "Active" Then
                    LogDeactivate(strAuditLog, "Main form", "pet", ID)
                Else
                    LogActivate(strAuditLog, "Main form", "pet", ID)
                End If
                userStatus = value
            End If
        End Set
    End Property

    Public ReadOnly Property IsActive As Boolean
        Get
            Return userStatus = "Active"
        End Get
    End Property
End Class

Public Class User
    Private userID As Integer
    Private userFirstName As String
    Private userLastName As String
    Private userContactNum As String
    Private strUsername As String
    Private userPassword As String
    Private userType As Integer
    Private strType As String
    Private userStatus As String
    Private boolLogin As Boolean
    Private strQuery As String
    Private strAuditLog As String

    ' User Signing In
    Public Sub New(strUser As String, strPass As String)
        strQuery = $"SELECT userID, userName, userFirstName, userLastName, userContactNum, userType, userStatus FROM tblUser WHERE userName = '{strUser}' LIMIT 1"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        Dim isValid As Boolean
        If dt.Rows.Count() > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With row
                userID = CType(.Item("userID"), Integer)
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
                boolLogin = True
            Else
                boolLogin = False
            End If
            SigningIn()
        Else
            boolLogin = False
        End If
        ClearQueries()
    End Sub

    'Create New User
    Public Sub New(intUserID As Integer, strFirstName As String, strLastName As String, strPhone As String, strUsername As String, strPassword As String, intType As Integer)
        strQuery = $"INSERT INTO tbluser VALUES ({intUserID},'{strFirstName}', '{strLastName}', '{strPhone}', '{strUsername}', md5('{strPassword}'), {intType}, 'Active')"
        If dbKit.RunQuery(strQuery) Then
            MessageBox.Show("New account created.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LogCreate(strAuditLog, "Users form", "account", intUserID)
            dbKit.RunQuery(strAuditLog)
        Else
            MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearQueries()
    End Sub

    'Search User By ID
    Public Sub New(intID As Integer)
        strQuery = $"SELECT * FROM tbluser WHERE userID = {intID}"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                userID = intID
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
            If userPassword <> String.Empty Then
                strQuery = $"UPDATE tbluser SET userFirstName = '{userFirstName}', userLastName = '{userLastName}', userContactNum = '{userContactNum}', userName = '{strUsername}', userType = '{userType}' WHERE userID = {userID}"
            Else
                strQuery = $"UPDATE tbluser SET userFirstName = '{userFirstName}', userLastName = '{userLastName}', userContactNum = '{userContactNum}', userName = '{strUsername}', userPassword = md5('{userPassword}'), userType = '{userType}' WHERE userID = {userID}"
            End If
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show("User account updated.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            strQuery = $"UPDATE tbluser SET userStatus='{userStatus}' WHERE userID = {userID}"
            'MsgBox(strQuery)
            If dbKit.RunQuery(strQuery) Then
                MessageBox.Show($"User status set to {userStatus.ToUpper}.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbKit.RunQuery(strAuditLog)
            Else
                MessageBox.Show("Database error. Inform immediate supervisor.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ClearQueries()
        End If
    End Sub

    Public Function CheckPassword(strUser As String, strPass As String)
        strQuery = $"SELECT userPassword = md5('{strPass}') AS `isValid` FROM tblUser WHERE userName = '{strUser}'"
        Dim dt As DataTable = dbKit.GetQuery(strQuery)
        Return CType(dt.Rows(0).Item("isValid"), Integer) = 1
    End Function

    Private Sub SigningIn()
        If boolLogin Then
            LogValidLogin(strAuditLog, userID)
        Else
            LogInvalidLogin(strAuditLog, userID)
        End If
        dbKit.RunQuery(strAuditLog)
    End Sub

    Public Sub SigningOut()
        If boolLogin Then
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
        Get
            Return boolLogin
        End Get
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return userID
        End Get
    End Property

    Public Property Username As String
        Get
            Return strUsername
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "username", "account", userID, strUsername, value) Then
                strUsername = value
            End If
        End Set
    End Property

    Public WriteOnly Property Password As String
        Set(value As String)
            If LogUpdatePassword(strAuditLog, "Users form", "password", "account", userID, strUsername, value) Then
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
            If LogUpdate(strAuditLog, "Users form", "first name", "account", userID, userFirstName, value) Then
                userFirstName = value
            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return userLastName
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "last name", "account", userID, userLastName, value) Then
                userLastName = value
            End If
        End Set
    End Property

    Public Property Phone As String
        Get
            Return userContactNum
        End Get
        Set(value As String)
            If LogUpdate(strAuditLog, "Users form", "phone", "account", userID, userContactNum, value) Then
                userContactNum = value
            End If
        End Set
    End Property

    Public Property TypeID As Integer
        Get
            Return userType
        End Get
        Set(value As Integer)
            If LogUpdate(strAuditLog, "Users form", "user type", "account", userID, Type, If(value = 0, "Encoder", "Admin")) Then
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
                    LogDeactivate(strAuditLog, "Main form", "pet", userID)
                Else
                    LogActivate(strAuditLog, "Main form", "pet", userID)
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

    Public ReadOnly Property AuditLog As String
        Get
            Return strAuditLog
        End Get
    End Property
End Class

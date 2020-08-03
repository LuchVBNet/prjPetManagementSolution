Imports CrystalDecisions.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class MySQLKit
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable
    Private strArray As String()
    Private intCount As Integer
    Private _db_host, _db_name, _db_username, _db_password As String
    Private strConn As String

    Public ReadOnly Property DBHost As String
        Get
            Return _db_host
        End Get
    End Property

    Public ReadOnly Property DBName As String
        Get
            Return _db_name
        End Get
    End Property

    Public ReadOnly Property DBUser As String
        Get
            Return _db_username
        End Get
    End Property

    Public WriteOnly Property DBPass As String
        Set(value As String)
            _db_password = value
        End Set
    End Property

    ' Constructor that requires hostname, database name, username, and password
    Public Sub New(strDBHost As String, strDBName As String, strDBUser As String, strDBPass As String)
        _db_host = strDBHost
        _db_name = strDBName
        _db_username = strDBUser
        _db_password = strDBPass
        strConn = $"Server={_db_host}; Database={_db_name}; Port=3306; Uid={_db_username}; Pwd={_db_password}; Convert Zero Datetime=True;"
        dbConn = New MySqlConnection(strConn)
    End Sub

    ' Constructor that requires database name, username, and password
    Public Sub New(strDBName As String, strDBUser As String, strDBPass As String)
        Me.New("localhost", strDBName, strDBUser, strDBPass)
    End Sub

    ' Constructor that requires database name only
    Public Sub New(strDBName As String)
        Me.New(strDBName, "root", "")
    End Sub

    ' Connect to Database
    Private Function OpenDB() As Boolean
        Try
            dbConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: OpenDB() " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dbConn.Close()
        End Try
    End Function

    Public Sub TestConnection()
        If OpenDB() Then
            MessageBox.Show("Connection to database is successful!", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function GetQuery(strSQL As String) As DataTable
        'MsgBox(strSQL)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            GetQuery = dt
        Catch ex As Exception
            GetQuery = New DataTable
            MessageBox.Show("Error: GetQuery() " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
    End Function

    Public Function RunQuery(strSQL As String) As Boolean
        'MsgBox(strSQL)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(strSQL, dbConn)
            With sqlCommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: RunQuery() " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dbConn.Close()
        End Try
    End Function

    Public Sub PopulateDataGridView(strSQL As String, ByRef dg As DataGridView)
        dg.DataSource = GetQuery(strSQL)
    End Sub

    Public Sub PopulateDataGridView(strTable As String, strSearchKey As String, strStatus As String, ByRef dg As DataGridView)
        Dim strSQL As String = GetSearchQuery(strTable, strSearchKey, strStatus)
        PopulateDataGridView(strSQL, dg)
    End Sub
    Public Sub PopulateComboBox(strSQL As String, strValueColumn As String, strDisplayColumn As String, ByRef cboBox As ComboBox)
        dt = GetQuery(strSQL)
        If dt.Columns.Count > 0 Then
            cboBox.DataSource = dt
            cboBox.ValueMember = dt.Columns(strValueColumn).ToString
            cboBox.DisplayMember = dt.Columns(strDisplayColumn).ToString
        End If
    End Sub

    Public Sub PopulateComboBox(ByRef cboBox As ComboBox, strViewName As String, strStatus As String)
        Dim strSQL As String = $"SELECT ID, Name FROM {strViewName}"
        If strStatus <> String.Empty Then
            strSQL += $" WHERE Status='{strStatus}'"
        End If
        PopulateComboBox(strSQL, "ID", "Name", cboBox)
    End Sub

    Public Sub PopulateComboBox(ByRef cboBox As ComboBox, strViewName As String)
        PopulateComboBox(cboBox, strViewName, "Active")
    End Sub

    Public Function GetColumnNames(strTable As String) As String()
        dt = GetQuery($"SELECT * FROM {strTable}")
        intCount = dt.Columns.Count
        If intCount > 0 Then
            ReDim strArray(intCount - 1)
            For index = 0 To intCount - 1
                strArray(index) = dt.Columns(index).ColumnName
            Next
        Else
            strArray = Nothing
        End If
        Return strArray
    End Function

    'Get Like Query
    Public Function GetSearchQuery(strTable As String, strSearchKey As String, strStatus As String) As String
        Dim strLikeQuery As String = String.Empty
        Dim strStatusQuery As String = String.Empty
        strArray = GetColumnNames(strTable)
        intCount = strArray.Length
        If intCount > 0 AndAlso strSearchKey <> String.Empty Then
            strLikeQuery = "WHERE ("
            For index = 0 To intCount - 1
                strLikeQuery += $"`{strArray(index)}` LIKE '%{strSearchKey}%' {If(index <> intCount - 1, "OR ", String.Empty)}"
            Next
            strLikeQuery += ")"
        End If
        If strStatus <> String.Empty Then
            strStatusQuery = If(strLikeQuery = String.Empty, " WHERE ", " AND ")
            strStatusQuery += $"Status = '{strStatus}'"
        End If
        Return $"SELECT * FROM {strTable} {strLikeQuery} {strStatusQuery} ORDER BY `ID`"
    End Function

    Public Function TableLastID(strTableName As String, strIDName As String) As Integer
        intCount = 0
        Dim strSQL As String = $"SELECT * FROM {strTableName} ORDER BY {strIDName} DESC LIMIT 1"
        dt = GetQuery(strSQL)
        If dt.Rows.Count > 0 Then
            intCount = dt.Rows(0).Item(strIDName)
        Else
            intCount = 0
        End If
        Return intCount
    End Function


End Class

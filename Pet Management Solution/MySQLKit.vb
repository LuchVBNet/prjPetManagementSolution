Imports CrystalDecisions.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class MySQLKit
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable
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
    Public Sub PopulateComboBox(strSQL As String, strValueColumn As String, strDisplayColumn As String, ByRef cboBox As ComboBox)
        dt = GetQuery(strSQL)
        cboBox.DataSource = dt
        cboBox.ValueMember = dt.Columns(strValueColumn).ToString
        cboBox.DisplayMember = dt.Columns(strDisplayColumn).ToString
    End Sub

    Public Function TableLastID(strTableName As String, strIDName As String) As Integer
        Dim count As Integer
        Dim strSQL As String = $"SELECT * FROM {strTableName} ORDER BY {strIDName} DESC LIMIT 1"
        dt = GetQuery(strSQL)
        If dt.Rows.Count > 0 Then
            count = dt.Rows(0).Item(strIDName)
        Else
            count = 0
        End If
        Return count
    End Function


End Class

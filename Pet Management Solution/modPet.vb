' Name:         MySQL Connector
' Programmer:   James Carlo S.Luchavez on July 15, 2020

Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Windows.Forms
Module modPet
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable
    Dim strConn As String = "Server=localhost; User ID=root; Database=dbpets; Convert Zero Datetime=True"

    Public Sub dbConnectionTest()
        If dbConnection() Then
            MessageBox.Show("DB test connection is successful.", "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error: dbConnectionTest()", "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function dbConnection() As Boolean
        Try
            dbConn = New MySqlConnection(strConn)
            dbConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: dbConnection() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dbConn.Close()
        End Try
    End Function

    Public Sub DisplayRecords(strSQL As String, dg As DataGridView)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            dg.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: DisplayRecords() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub DisplayReport(strSQL As String, ByRef report As rptPetsActive, ByRef reportViewer As CrystalReportViewer)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            'MsgBox(dt.Rows.Count)
            report.SetDataSource(dt)
            reportViewer.ReportSource = report
            reportViewer.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: DisplayReport() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()

        End Try
    End Sub

    Public Function RecordCount() As Integer
        Dim count As Integer = 0
        Dim strSQL As String = "SELECT * FROM tblpet ORDER BY petID DESC LIMIT 1"
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                count = dt.Rows(0).Item("petID")
            Else
                count = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error: RecordCount() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
        Return count
    End Function

    Public Function GetPetType(intTypeID As Integer) As String
        Dim strSQL As String = "SELECT typeName FROM tbltype WHERE typeID = " & intTypeID.ToString
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("typeName")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: GetPetType() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
        Return String.Empty
    End Function

    Public Function LoadToComboBox(strSQL As String) As DataTable
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(strSQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error: LoadToComboBox() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
        Return dt
    End Function

    Public Sub SQLManager(strSQL As String, strMsg As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(strSQL, dbConn)
            With sqlCommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show(strMsg, "Pet DMBS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: SQLManager() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbConn.Close()
        End Try
    End Sub
End Module

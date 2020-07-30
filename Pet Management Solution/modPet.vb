' Name:         MySQL Connector
' Programmer:   James Carlo S.Luchavez on July 15, 2020

Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Windows.Forms
Module modPet
    Public auth As User
    Public dbKit As MySQLKit
    Sub New()
        dbKit = New MySQLKit("localhost", "dbpets", "root", "")
        'dbKit = New MySQLKit("luchmewep.mysql.database.azure.com", "dbpets", "luchmewep@luchmewep", "B32eeee0.")
    End Sub

    'Audit Functions
    Public Sub LogInvalidLogin(ByRef strQuery As String, intID As Integer)
        strQuery = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 0, {intID}, 'Login form', 'Invalid username/password')"
    End Sub

    Public Sub LogValidLogin(ByRef strQuery As String, intID As Integer)
        strQuery = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 1, {intID}, 'Login form', 'Successful login.')"
    End Sub

    Public Sub LogLogout(ByRef strQuery As String)
        strQuery = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 6, {auth.ID}, 'Login form', 'Logged out successfully.')"
    End Sub

    Public Sub LogCreate(ByRef strQuery As String, strForm As String, strObject As String, intID As Integer)
        strQuery = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 2, {auth.ID}, '{strForm}', 'Create new {strObject} - #{intID}.')"
    End Sub

    Public Function LogUpdate(ByRef strQuery As String, strForm As String, strColumn As String, strObject As String, intID As Integer, oldValue As String, newValue As String) As Boolean
        If oldValue <> newValue Then
            strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 3, {auth.ID}, '{strForm}', 'Update {strColumn} of {strObject} - #{intID} from ""{oldValue}"" to ""{newValue}"".');"
            'MsgBox($"{prevValue} to {newValue}")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LogUpdatePassword(ByRef strQuery As String, strForm As String, strColumn As String, strObject As String, intID As Integer, strUsername As String, newValue As String) As Boolean
        If auth.CheckPassword(strUsername, newValue) Then
            strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 3, {auth.ID}, '{strForm}', 'Update {strColumn} of {strObject} - #{intID}.');"
            'MsgBox($"{prevValue} to {newValue}")
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LogDeactivate(ByRef strQuery As String, strForm As String, strObject As String, intID As Integer)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 4, {auth.ID}, '{strForm}', 'Deactivated {strObject} - #{intID}.')"
    End Sub

    Public Sub LogActivate(ByRef strQuery As String, strForm As String, strObject As String, intID As Integer)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 4, {auth.ID}, '{strForm}', 'Activated {strObject} - #{intID}.')"
    End Sub

    Public Sub LogPrint(ByRef strQuery As String, strForm As String)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 5, {auth.ID}, '{strForm}', 'Print Inactive and Active Pets.')"
    End Sub

End Module

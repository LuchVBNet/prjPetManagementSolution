' Name:         MySQL Connector
' Programmer:   James Carlo S.Luchavez on July 15, 2020

Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Windows.Forms
Imports System.ComponentModel
Module modPet
    Public auth As User
    Public mod_user As User
    Public mod_pet As Pet
    Public mod_breed As PetBreed
    Public mod_type As PetType
    Public mod_owner As PetOwner
    Public dbKit As MySQLKit
    Sub New()
        ' LOCAL
        dbKit = New MySQLKit("localhost", "dbpets", "root", "")

        ' ONLINE
        'dbKit = New MySQLKit("btmownbmbobe9hjv3aek-mysql.services.clever-cloud.com", "btmownbmbobe9hjv3aek", "ub8otayzjqumpkxr", "fxsfBTdKh05iKOzwGyBv")
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
        If Not User.CheckPassword(strUsername, newValue) Then
            strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 3, {auth.ID}, '{strForm}', 'Update {strColumn} of {strObject} - #{intID}.');"
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LogDeactivate(ByRef strQuery As String, strForm As String, strObject As String, intID As Integer)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 4, {auth.ID}, '{strForm}', 'Deactivated {strObject} - #{intID}.')"
        'MsgBox(strQuery)
    End Sub

    Public Sub LogActivate(ByRef strQuery As String, strForm As String, strObject As String, intID As Integer)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 4, {auth.ID}, '{strForm}', 'Activated {strObject} - #{intID}.')"
        'MsgBox(strQuery)
    End Sub

    Public Sub LogPrint(ByRef strQuery As String, strForm As String)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES (now(), 5, {auth.ID}, '{strForm}', 'Print Inactive and Active Pets.')"
    End Sub

    'Reusable disposer
    Public Sub DisposeEverything(panelFlow As FlowLayoutPanel)
        For Each control As Control In panelFlow.Controls
            control.Dispose()
        Next
        panelFlow.Controls.Clear()
    End Sub

End Module

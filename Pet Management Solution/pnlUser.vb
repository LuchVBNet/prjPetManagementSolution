Public Class pnlUser
    Private user As User
    Public Shared Event PanelSelected(intID As Integer)
    Public Sub New(intID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user = New User(intID)
        AddHandler User.UpdateInformation, AddressOf UpdateInformation
    End Sub

    Private Sub UpdateInformation(intID As Integer)
        If user.ID = intID Then
            user = New User(intID)
            RefreshInformation()
        End If
    End Sub

    Public Sub RefreshInformation() Handles MyBase.Load
        lblName.Text = $"{user.FirstName} {user.LastName}"
        lblUsername.Text = user.Username
        lblContact.Text = user.Phone
        lblStatus.Text = user.Status
        btnToggleStatus.Text = $"{If(user.Status = "Active", "Deactivate", "Activate")} account"
        lblType.Text = user.Type
        btnToggleType.Text = If(user.Type = "Admin", "Demote to Encoder", "Promote to Admin")
        If user.Status <> "Active" Then
            Me.BackColor = System.Drawing.Color.Gainsboro
            lblStatus.BackColor = System.Drawing.Color.OrangeRed
            lblStatus.ForeColor = System.Drawing.SystemColors.ControlLight
        Else
            Me.BackColor = System.Drawing.Color.Bisque
            lblStatus.BackColor = System.Drawing.Color.PaleGreen
            lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        End If
        lblType.ForeColor = If(user.TypeID = 1, System.Drawing.Color.RoyalBlue, DefaultForeColor)
    End Sub

    Private Sub form_Click(sender As Object, e As EventArgs) Handles MyBase.Click, StatusStrip1.Click, PictureBox1.Click, lblUsername.Click, lblType.Click, lblStatus.Click, lblName.Click, lblContact.Click
        RaiseEvent PanelSelected(user.ID)
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        user.ToggleStatus()
    End Sub

    Private Sub btnToggleType_Click(sender As Object, e As EventArgs) Handles btnToggleType.Click
        user.TypeID = If(user.TypeID = 1, 0, 1)
        user.Update()
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Dim form As New frmAudit
        frmAudit.userName = user.Username
        form.ShowDialog()
    End Sub
End Class

Public Class pnlPet
    Public Shared Event PanelSelected(intID As Integer)
    Private pet As Pet
    Public Sub New(intID As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pet = New Pet(intID)
        AddHandler Pet.UpdateInformation, AddressOf UpdateInformation
    End Sub

    Private Sub UpdateInformation(intID As Integer)
        If pet.ID = intID Then
            pet = New Pet(intID)
            refreshInformation()
        End If
    End Sub

    Private Sub pnlPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshInformation()
    End Sub

    Public Sub refreshInformation()
        lblName.Text = pet.Name
        lblType.Text = pet.Type.Name
        lblBreed.Text = pet.Breed.Name
        lblGender.Text = pet.Gender
        striptxtBirth.Text = $"{pet.Birthdate} ({pet.Age})"
        lblOwner.Text = pet.Owner.Name
        striptxtStatus.Text = pet.Status
        tipStatus.SetToolTip(Me, pet.Notes)
        If pet.Status <> "Active" Then
            Me.BackColor = System.Drawing.Color.Gainsboro
            striptxtStatus.BackColor = System.Drawing.Color.OrangeRed
            striptxtStatus.ForeColor = System.Drawing.SystemColors.ControlLight
        Else
            Me.BackColor = System.Drawing.Color.Bisque
            striptxtStatus.BackColor = System.Drawing.Color.PaleGreen
            striptxtStatus.ForeColor = System.Drawing.SystemColors.ControlText
        End If
    End Sub

    Private Sub lblNotes_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ToggleStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleStatusToolStripMenuItem.Click
        pet.ToggleStatus()
    End Sub

    Private Sub form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, statusStrip.MouseUp, PictureBox1.MouseUp, lblType.MouseUp, lblOwner.MouseUp, lblName.MouseUp, lblGender.MouseUp, lblBreed.MouseUp, lbl6.MouseUp, lbl4.MouseUp, lbl3.MouseUp, lbl2.MouseUp, lbl1.MouseUp, MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            RaiseEvent PanelSelected(pet.ID)
        Else
            rightClickMenu.Show(sender, e.Location)
        End If
    End Sub

    Private Sub UpdatePetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePetToolStripMenuItem.Click
        RaiseEvent PanelSelected(pet.ID)
    End Sub
End Class

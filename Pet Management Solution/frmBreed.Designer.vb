<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblPetBreed = New System.Windows.Forms.Label()
        Me.txtPetBreed = New System.Windows.Forms.TextBox()
        Me.lblPetType = New System.Windows.Forms.Label()
        Me.txtPetType = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(145, 107)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 32)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(50, 107)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(89, 32)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblPetBreed
        '
        Me.lblPetBreed.AutoSize = True
        Me.lblPetBreed.Location = New System.Drawing.Point(28, 56)
        Me.lblPetBreed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPetBreed.Name = "lblPetBreed"
        Me.lblPetBreed.Size = New System.Drawing.Size(73, 18)
        Me.lblPetBreed.TabIndex = 2
        Me.lblPetBreed.Text = "Pet Breed"
        '
        'txtPetBreed
        '
        Me.txtPetBreed.Location = New System.Drawing.Point(109, 53)
        Me.txtPetBreed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetBreed.Name = "txtPetBreed"
        Me.txtPetBreed.Size = New System.Drawing.Size(148, 24)
        Me.txtPetBreed.TabIndex = 3
        '
        'lblPetType
        '
        Me.lblPetType.AutoSize = True
        Me.lblPetType.Location = New System.Drawing.Point(35, 24)
        Me.lblPetType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPetType.Name = "lblPetType"
        Me.lblPetType.Size = New System.Drawing.Size(66, 18)
        Me.lblPetType.TabIndex = 0
        Me.lblPetType.Text = "Pet Type"
        '
        'txtPetType
        '
        Me.txtPetType.Location = New System.Drawing.Point(109, 21)
        Me.txtPetType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetType.Name = "txtPetType"
        Me.txtPetType.Size = New System.Drawing.Size(148, 24)
        Me.txtPetType.TabIndex = 1
        '
        'frmBreed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.lblPetType)
        Me.Controls.Add(Me.txtPetType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblPetBreed)
        Me.Controls.Add(Me.txtPetBreed)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBreed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Pet Breed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblPetBreed As Label
    Friend WithEvents txtPetBreed As TextBox
    Friend WithEvents lblPetType As Label
    Friend WithEvents txtPetType As TextBox
End Class

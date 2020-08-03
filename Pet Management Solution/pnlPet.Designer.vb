<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPet
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.tipStatus = New System.Windows.Forms.ToolTip(Me.components)
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.striptxtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.striptxtBirth = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdatePetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToggleStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.statusStrip.SuspendLayout()
        Me.rightClickMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(74, 5)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(38, 13)
        Me.lbl3.TabIndex = 1
        Me.lbl3.Text = "Name:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(74, 57)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(45, 13)
        Me.lbl4.TabIndex = 2
        Me.lbl4.Text = "Gender:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(74, 44)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 13)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Breed:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(74, 31)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Type:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(125, 31)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(30, 13)
        Me.lblType.TabIndex = 5
        Me.lblType.Text = "Dog"
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreed.Location = New System.Drawing.Point(125, 44)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(30, 13)
        Me.lblBreed.TabIndex = 6
        Me.lblBreed.Text = "Dog"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(74, 18)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(41, 13)
        Me.lbl6.TabIndex = 8
        Me.lbl6.Text = "Owner:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(125, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(30, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Dog"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(125, 57)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(30, 13)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "Dog"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.Location = New System.Drawing.Point(125, 18)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(30, 13)
        Me.lblOwner.TabIndex = 13
        Me.lblOwner.Text = "Dog"
        '
        'statusStrip
        '
        Me.statusStrip.BackColor = System.Drawing.Color.Transparent
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.striptxtStatus, Me.striptxtBirth})
        Me.statusStrip.Location = New System.Drawing.Point(0, 78)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(260, 22)
        Me.statusStrip.TabIndex = 18
        Me.statusStrip.Text = "StatusStrip1"
        '
        'striptxtStatus
        '
        Me.striptxtStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.striptxtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.striptxtStatus.Name = "striptxtStatus"
        Me.striptxtStatus.Size = New System.Drawing.Size(43, 17)
        Me.striptxtStatus.Text = "Active"
        Me.striptxtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'striptxtBirth
        '
        Me.striptxtBirth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.striptxtBirth.Name = "striptxtBirth"
        Me.striptxtBirth.Size = New System.Drawing.Size(171, 17)
        Me.striptxtBirth.Spring = True
        Me.striptxtBirth.Text = "10/11/12"
        Me.striptxtBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdatePetToolStripMenuItem
        '
        Me.UpdatePetToolStripMenuItem.Name = "UpdatePetToolStripMenuItem"
        Me.UpdatePetToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UpdatePetToolStripMenuItem.Text = "Update Pet"
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePetToolStripMenuItem, Me.ToggleStatusToolStripMenuItem})
        Me.rightClickMenu.Name = "ContextMenuStrip2"
        Me.rightClickMenu.Size = New System.Drawing.Size(145, 48)
        '
        'ToggleStatusToolStripMenuItem
        '
        Me.ToggleStatusToolStripMenuItem.Name = "ToggleStatusToolStripMenuItem"
        Me.ToggleStatusToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ToggleStatusToolStripMenuItem.Text = "Toggle Status"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Pet_Management_Solution.My.Resources.Resources.doge
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlPet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lblBreed)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "pnlPet"
        Me.Size = New System.Drawing.Size(260, 100)
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.rightClickMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents tipStatus As ToolTip
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents striptxtStatus As ToolStripStatusLabel
    Friend WithEvents UpdatePetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rightClickMenu As ContextMenuStrip
    Friend WithEvents ToggleStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents striptxtBirth As ToolStripStatusLabel
End Class

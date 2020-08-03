<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlUser))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.stripSettings = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnToggleStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnToggleType = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblType, Me.stripSettings})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 178)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(200, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 17)
        Me.lblStatus.Text = "Active"
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(81, 17)
        Me.lblType.Spring = True
        Me.lblType.Text = "ADMIN"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(191, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "James Carlo Luchavez"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 133)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(191, 17)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "luchmewep"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContact
        '
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(6, 150)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(191, 21)
        Me.lblContact.TabIndex = 5
        Me.lblContact.Text = "09085353416"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Pet_Management_Solution.My.Resources.Resources.luffy
        Me.PictureBox1.Location = New System.Drawing.Point(47, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'stripSettings
        '
        Me.stripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stripSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToggleStatus, Me.btnToggleType, Me.btnLogs})
        Me.stripSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stripSettings.Image = CType(resources.GetObject("stripSettings.Image"), System.Drawing.Image)
        Me.stripSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stripSettings.Name = "stripSettings"
        Me.stripSettings.Size = New System.Drawing.Size(61, 20)
        Me.stripSettings.Text = "Actions"
        Me.stripSettings.ToolTipText = "Update settings..."
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(180, 22)
        Me.btnToggleStatus.Text = "Deactivate"
        '
        'btnToggleType
        '
        Me.btnToggleType.Name = "btnToggleType"
        Me.btnToggleType.Size = New System.Drawing.Size(180, 22)
        Me.btnToggleType.Text = "Change to Encoder"
        '
        'btnLogs
        '
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(180, 22)
        Me.btnLogs.Text = "Show Logs"
        '
        'pnlUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "pnlUser"
        Me.Size = New System.Drawing.Size(200, 200)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblType As ToolStripStatusLabel
    Friend WithEvents stripSettings As ToolStripDropDownButton
    Friend WithEvents btnToggleStatus As ToolStripMenuItem
    Friend WithEvents btnToggleType As ToolStripMenuItem
    Friend WithEvents btnLogs As ToolStripMenuItem
End Class

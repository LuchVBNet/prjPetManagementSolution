<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabViews = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.pnlFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnToggleStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabViews.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.tab2.SuspendLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtPassword2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(228, 513)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(181, 91)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(42, 13)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "1000"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Pet_Management_Solution.My.Resources.Resources.luffy
        Me.PictureBox1.Location = New System.Drawing.Point(157, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(8, 233)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(140, 20)
        Me.txtPassword2.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Confirm"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Encoder", "Admin"})
        Me.cboType.Location = New System.Drawing.Point(8, 271)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(140, 21)
        Me.cboType.TabIndex = 13
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(42, 315)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(70, 23)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.Text = "ADD"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Type"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(8, 194)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(140, 20)
        Me.txtPassword.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(8, 155)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(140, 20)
        Me.txtUsername.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(8, 116)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(140, 20)
        Me.txtPhone.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(8, 77)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(140, 20)
        Me.txtLastName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(8, 38)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(143, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Salmon
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(116, 315)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID:"
        '
        'tabViews
        '
        Me.tabViews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabViews.Controls.Add(Me.tab1)
        Me.tabViews.Controls.Add(Me.tab2)
        Me.tabViews.Location = New System.Drawing.Point(245, 62)
        Me.tabViews.Name = "tabViews"
        Me.tabViews.SelectedIndex = 0
        Me.tabViews.Size = New System.Drawing.Size(650, 461)
        Me.tabViews.TabIndex = 2
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.pnlFlow)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(642, 435)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Grid View"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'pnlFlow
        '
        Me.pnlFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFlow.Location = New System.Drawing.Point(3, 3)
        Me.pnlFlow.Name = "pnlFlow"
        Me.pnlFlow.Size = New System.Drawing.Size(636, 429)
        Me.pnlFlow.TabIndex = 0
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.dgUser)
        Me.tab2.Controls.Add(Me.MenuStrip1)
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(642, 435)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "Table View"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AllowUserToOrderColumns = True
        Me.dgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUser.Location = New System.Drawing.Point(3, 27)
        Me.dgUser.Margin = New System.Windows.Forms.Padding(2)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.Size = New System.Drawing.Size(636, 405)
        Me.dgUser.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToggleStatus})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(69, 20)
        Me.btnToggleStatus.Text = "ACTIVATE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.rdoInactive)
        Me.GroupBox3.Controls.Add(Me.rdoActive)
        Me.GroupBox3.Controls.Add(Me.rdoAll)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(650, 44)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'rdoInactive
        '
        Me.rdoInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Location = New System.Drawing.Point(581, 14)
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Size = New System.Drawing.Size(63, 17)
        Me.rdoInactive.TabIndex = 4
        Me.rdoInactive.Text = "Inactive"
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'rdoActive
        '
        Me.rdoActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Location = New System.Drawing.Point(520, 14)
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Size = New System.Drawing.Size(55, 17)
        Me.rdoActive.TabIndex = 3
        Me.rdoActive.Text = "Active"
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Location = New System.Drawing.Point(478, 14)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 2
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(58, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1
        '
        'frmUsers
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 531)
        Me.Controls.Add(Me.tabViews)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(920, 570)
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabViews.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab2.ResumeLayout(False)
        Me.tab2.PerformLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dgUser As DataGridView
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblID As Label
    Friend WithEvents tabViews As TabControl
    Friend WithEvents tab1 As TabPage
    Friend WithEvents tab2 As TabPage
    Friend WithEvents pnlFlow As FlowLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnToggleStatus As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgPets = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.btnToggleStatus = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAddOwner = New System.Windows.Forms.Button()
        Me.btnAddBreed = New System.Windows.Forms.Button()
        Me.btnAddType = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboOwner = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBreed = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusDeveloped = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblFullName = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterfiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabViews = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.tabViews.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.tab2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rdoInactive)
        Me.GroupBox2.Controls.Add(Me.rdoActive)
        Me.GroupBox2.Controls.Add(Me.rdoAll)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 44)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rdoInactive
        '
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Location = New System.Drawing.Point(283, 14)
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Size = New System.Drawing.Size(63, 17)
        Me.rdoInactive.TabIndex = 4
        Me.rdoInactive.Text = "Inactive"
        Me.tooltipMain.SetToolTip(Me.rdoInactive, "Inactive Pets")
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'rdoActive
        '
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Location = New System.Drawing.Point(222, 14)
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Size = New System.Drawing.Size(55, 17)
        Me.rdoActive.TabIndex = 3
        Me.rdoActive.Text = "Active"
        Me.tooltipMain.SetToolTip(Me.rdoActive, "Active Pets")
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Location = New System.Drawing.Point(180, 14)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 2
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.tooltipMain.SetToolTip(Me.rdoAll, "All Pets")
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPrint.Location = New System.Drawing.Point(555, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.tooltipMain.SetToolTip(Me.btnPrint, "Print Active and Inactive Pets")
        Me.btnPrint.UseVisualStyleBackColor = True
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
        Me.txtSearch.Location = New System.Drawing.Point(58, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1
        Me.tooltipMain.SetToolTip(Me.txtSearch, "Press Enter to Search")
        '
        'dgPets
        '
        Me.dgPets.AllowUserToAddRows = False
        Me.dgPets.AllowUserToDeleteRows = False
        Me.dgPets.AllowUserToOrderColumns = True
        Me.dgPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPets.Location = New System.Drawing.Point(3, 3)
        Me.dgPets.Name = "dgPets"
        Me.dgPets.ReadOnly = True
        Me.dgPets.Size = New System.Drawing.Size(621, 318)
        Me.dgPets.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpBirth)
        Me.GroupBox1.Controls.Add(Me.btnToggleStatus)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.btnAddOwner)
        Me.GroupBox1.Controls.Add(Me.btnAddBreed)
        Me.GroupBox1.Controls.Add(Me.btnAddType)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboOwner)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboBreed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pet Information Form"
        '
        'dtpBirth
        '
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirth.Location = New System.Drawing.Point(71, 78)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(135, 20)
        Me.dtpBirth.TabIndex = 5
        Me.dtpBirth.Value = New Date(2020, 8, 3, 0, 0, 0, 0)
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.Location = New System.Drawing.Point(212, 371)
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(93, 23)
        Me.btnToggleStatus.TabIndex = 20
        Me.btnToggleStatus.Text = "TOGGLE"
        Me.btnToggleStatus.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(113, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(14, 371)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(93, 23)
        Me.btnConfirm.TabIndex = 18
        Me.btnConfirm.Text = "ADD"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Pet_Management_Solution.My.Resources.Resources.doge
        Me.PictureBox1.Location = New System.Drawing.Point(213, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(69, 320)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(129, 21)
        Me.cboStatus.TabIndex = 17
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(69, 211)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(243, 103)
        Me.txtNotes.TabIndex = 15
        '
        'btnAddOwner
        '
        Me.btnAddOwner.Location = New System.Drawing.Point(213, 184)
        Me.btnAddOwner.Name = "btnAddOwner"
        Me.btnAddOwner.Size = New System.Drawing.Size(28, 23)
        Me.btnAddOwner.TabIndex = 23
        Me.btnAddOwner.Text = "+"
        Me.btnAddOwner.UseVisualStyleBackColor = True
        '
        'btnAddBreed
        '
        Me.btnAddBreed.Location = New System.Drawing.Point(213, 155)
        Me.btnAddBreed.Name = "btnAddBreed"
        Me.btnAddBreed.Size = New System.Drawing.Size(28, 23)
        Me.btnAddBreed.TabIndex = 22
        Me.btnAddBreed.Text = "+"
        Me.btnAddBreed.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.Location = New System.Drawing.Point(213, 128)
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(28, 23)
        Me.btnAddType.TabIndex = 21
        Me.btnAddType.Text = "+"
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Notes"
        '
        'cboOwner
        '
        Me.cboOwner.FormattingEnabled = True
        Me.cboOwner.Location = New System.Drawing.Point(69, 184)
        Me.cboOwner.Name = "cboOwner"
        Me.cboOwner.Size = New System.Drawing.Size(137, 21)
        Me.cboOwner.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Owner"
        '
        'cboBreed
        '
        Me.cboBreed.FormattingEnabled = True
        Me.cboBreed.Location = New System.Drawing.Point(69, 157)
        Me.cboBreed.Name = "cboBreed"
        Me.cboBreed.Size = New System.Drawing.Size(137, 21)
        Me.cboBreed.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Breed"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(69, 130)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(137, 21)
        Me.cboType.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(69, 104)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(137, 21)
        Me.cboGender.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(138, 20)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Birthdate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(69, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(137, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsername, Me.statusDeveloped})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(484, 17)
        Me.lblUsername.Spring = True
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusDeveloped
        '
        Me.statusDeveloped.Name = "statusDeveloped"
        Me.statusDeveloped.Size = New System.Drawing.Size(484, 17)
        Me.statusDeveloped.Spring = True
        Me.statusDeveloped.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFullName, Me.MasterfiToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblFullName
        '
        Me.lblFullName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblFullName.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.CloseProgramToolStripMenuItem})
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(12, 20)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'CloseProgramToolStripMenuItem
        '
        Me.CloseProgramToolStripMenuItem.Name = "CloseProgramToolStripMenuItem"
        Me.CloseProgramToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CloseProgramToolStripMenuItem.Text = "&Quit"
        '
        'MasterfiToolStripMenuItem
        '
        Me.MasterfiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeToolStripMenuItem, Me.BreedToolStripMenuItem, Me.OwnerToolStripMenuItem, Me.AuditLogsToolStripMenuItem})
        Me.MasterfiToolStripMenuItem.Name = "MasterfiToolStripMenuItem"
        Me.MasterfiToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MasterfiToolStripMenuItem.Text = "&Master File"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TypeToolStripMenuItem.Text = "&Type"
        '
        'BreedToolStripMenuItem
        '
        Me.BreedToolStripMenuItem.Name = "BreedToolStripMenuItem"
        Me.BreedToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BreedToolStripMenuItem.Text = "&Breed"
        '
        'OwnerToolStripMenuItem
        '
        Me.OwnerToolStripMenuItem.Name = "OwnerToolStripMenuItem"
        Me.OwnerToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OwnerToolStripMenuItem.Text = "&Owner"
        '
        'AuditLogsToolStripMenuItem
        '
        Me.AuditLogsToolStripMenuItem.Name = "AuditLogsToolStripMenuItem"
        Me.AuditLogsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AuditLogsToolStripMenuItem.Text = "&Audit Logs"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.TestConnectionToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UsersToolStripMenuItem.Text = "&User Management"
        '
        'TestConnectionToolStripMenuItem
        '
        Me.TestConnectionToolStripMenuItem.Name = "TestConnectionToolStripMenuItem"
        Me.TestConnectionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TestConnectionToolStripMenuItem.Text = "&Test Connection"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(245, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AboutToolStripMenuItem.Text = "&About Pet Management Solution"
        '
        'pnlFlow
        '
        Me.pnlFlow.AutoScroll = True
        Me.pnlFlow.BackColor = System.Drawing.Color.Transparent
        Me.pnlFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFlow.Location = New System.Drawing.Point(3, 3)
        Me.pnlFlow.Name = "pnlFlow"
        Me.pnlFlow.Size = New System.Drawing.Size(621, 318)
        Me.pnlFlow.TabIndex = 0
        '
        'tabViews
        '
        Me.tabViews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabViews.Controls.Add(Me.tab1)
        Me.tabViews.Controls.Add(Me.tab2)
        Me.tabViews.Location = New System.Drawing.Point(337, 78)
        Me.tabViews.Name = "tabViews"
        Me.tabViews.SelectedIndex = 0
        Me.tabViews.Size = New System.Drawing.Size(635, 350)
        Me.tabViews.TabIndex = 3
        Me.tooltipMain.SetToolTip(Me.tabViews, "Switch Views")
        '
        'tab1
        '
        Me.tab1.BackColor = System.Drawing.Color.Transparent
        Me.tab1.Controls.Add(Me.pnlFlow)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(627, 324)
        Me.tab1.TabIndex = 1
        Me.tab1.Text = "Grid View"
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.dgPets)
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(627, 324)
        Me.tab2.TabIndex = 0
        Me.tab2.Text = "Table View"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.tabViews)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabViews.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgPets As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAddOwner As Button
    Friend WithEvents btnAddBreed As Button
    Friend WithEvents btnAddType As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cboOwner As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBreed As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusDeveloped As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterfiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BreedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OwnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFullName As ToolStripMenuItem
    Friend WithEvents TestConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnToggleStatus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents pnlFlow As FlowLayoutPanel
    Friend WithEvents tabViews As TabControl
    Friend WithEvents tab1 As TabPage
    Friend WithEvents tab2 As TabPage
    Friend WithEvents tooltipMain As ToolTip
    Friend WithEvents dtpBirth As DateTimePicker
End Class

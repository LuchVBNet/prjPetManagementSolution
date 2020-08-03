<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwner
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnToggleStatus = New System.Windows.Forms.Button()
        Me.dgOwner = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(4, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(5, 72)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(57, 69)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(95, 162)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(20, 162)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(71, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "ADD"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(5, 98)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(57, 95)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(187, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner Information"
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Location = New System.Drawing.Point(160, 16)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(23, 21)
        Me.btnPlus.TabIndex = 10
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(57, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnToggleStatus)
        Me.GroupBox2.Controls.Add(Me.dgOwner)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 61)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(564, 289)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggleStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleStatus.Location = New System.Drawing.Point(471, 17)
        Me.btnToggleStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(87, 23)
        Me.btnToggleStatus.TabIndex = 0
        Me.btnToggleStatus.Text = "ACTIVATE"
        Me.btnToggleStatus.UseVisualStyleBackColor = False
        '
        'dgOwner
        '
        Me.dgOwner.AllowUserToAddRows = False
        Me.dgOwner.AllowUserToDeleteRows = False
        Me.dgOwner.AllowUserToOrderColumns = True
        Me.dgOwner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOwner.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgOwner.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgOwner.Location = New System.Drawing.Point(4, 44)
        Me.dgOwner.Margin = New System.Windows.Forms.Padding(2)
        Me.dgOwner.Name = "dgOwner"
        Me.dgOwner.ReadOnly = True
        Me.dgOwner.Size = New System.Drawing.Size(554, 241)
        Me.dgOwner.TabIndex = 1
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
        Me.GroupBox3.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 44)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'rdoInactive
        '
        Me.rdoInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Location = New System.Drawing.Point(695, 14)
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
        Me.rdoActive.Location = New System.Drawing.Point(634, 14)
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
        Me.rdoAll.Location = New System.Drawing.Point(592, 14)
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
        Me.Label10.Location = New System.Drawing.Point(4, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(51, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1
        '
        'frmOwner
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "frmOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pet Owner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnToggleStatus As Button
    Friend WithEvents dgOwner As DataGridView
    Friend WithEvents btnPlus As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
End Class

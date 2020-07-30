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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPetType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgBreed = New System.Windows.Forms.DataGridView()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBreed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(130, 189)
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
        Me.btnConfirm.Location = New System.Drawing.Point(35, 189)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(89, 32)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "ADD"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblPetBreed
        '
        Me.lblPetBreed.AutoSize = True
        Me.lblPetBreed.Location = New System.Drawing.Point(20, 91)
        Me.lblPetBreed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPetBreed.Name = "lblPetBreed"
        Me.lblPetBreed.Size = New System.Drawing.Size(73, 18)
        Me.lblPetBreed.TabIndex = 2
        Me.lblPetBreed.Text = "Pet Breed"
        '
        'txtPetBreed
        '
        Me.txtPetBreed.Location = New System.Drawing.Point(101, 88)
        Me.txtPetBreed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetBreed.Name = "txtPetBreed"
        Me.txtPetBreed.Size = New System.Drawing.Size(148, 24)
        Me.txtPetBreed.TabIndex = 3
        '
        'lblPetType
        '
        Me.lblPetType.AutoSize = True
        Me.lblPetType.Location = New System.Drawing.Point(20, 58)
        Me.lblPetType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPetType.Name = "lblPetType"
        Me.lblPetType.Size = New System.Drawing.Size(66, 18)
        Me.lblPetType.TabIndex = 0
        Me.lblPetType.Text = "Pet Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPetType)
        Me.GroupBox1.Controls.Add(Me.lblPetType)
        Me.GroupBox1.Controls.Add(Me.txtPetBreed)
        Me.GroupBox1.Controls.Add(Me.lblPetBreed)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 227)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Breed Information"
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Location = New System.Drawing.Point(255, 24)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(26, 24)
        Me.btnPlus.TabIndex = 11
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(100, 24)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(148, 24)
        Me.txtID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'cboPetType
        '
        Me.cboPetType.FormattingEnabled = True
        Me.cboPetType.Location = New System.Drawing.Point(100, 55)
        Me.cboPetType.Name = "cboPetType"
        Me.cboPetType.Size = New System.Drawing.Size(149, 26)
        Me.cboPetType.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgBreed)
        Me.GroupBox2.Controls.Add(Me.btnDeactivate)
        Me.GroupBox2.Controls.Add(Me.btnActivate)
        Me.GroupBox2.Location = New System.Drawing.Point(311, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 227)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'dgBreed
        '
        Me.dgBreed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgBreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBreed.Location = New System.Drawing.Point(7, 23)
        Me.dgBreed.Name = "dgBreed"
        Me.dgBreed.Size = New System.Drawing.Size(332, 160)
        Me.dgBreed.TabIndex = 9
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.Salmon
        Me.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeactivate.Location = New System.Drawing.Point(228, 189)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(111, 32)
        Me.btnDeactivate.TabIndex = 8
        Me.btnDeactivate.Text = "DEACTIVATE"
        Me.btnDeactivate.UseVisualStyleBackColor = False
        '
        'btnActivate
        '
        Me.btnActivate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivate.Location = New System.Drawing.Point(133, 189)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(89, 32)
        Me.btnActivate.TabIndex = 7
        Me.btnActivate.Text = "ACTIVATE"
        Me.btnActivate.UseVisualStyleBackColor = False
        '
        'frmBreed
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(669, 251)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBreed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pet Breed"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgBreed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblPetBreed As Label
    Friend WithEvents txtPetBreed As TextBox
    Friend WithEvents lblPetType As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPetType As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgBreed As DataGridView
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnPlus As Button
End Class

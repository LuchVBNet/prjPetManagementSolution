<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType
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
        Me.txtPetType = New System.Windows.Forms.TextBox()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgTypeTally = New System.Windows.Forms.DataGridView()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTypeTally, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPetType
        '
        Me.txtPetType.Location = New System.Drawing.Point(100, 56)
        Me.txtPetType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetType.Name = "txtPetType"
        Me.txtPetType.Size = New System.Drawing.Size(148, 24)
        Me.txtPetType.TabIndex = 1
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Location = New System.Drawing.Point(26, 59)
        Me.lblPetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(66, 18)
        Me.lblPetName.TabIndex = 0
        Me.lblPetName.Text = "Pet Type"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Location = New System.Drawing.Point(30, 162)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(89, 32)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(125, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPetType)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.lblPetName)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Information"
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
        Me.txtID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgTypeTally)
        Me.GroupBox2.Controls.Add(Me.btnDeactivate)
        Me.GroupBox2.Controls.Add(Me.btnActivate)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 200)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'dgTypeTally
        '
        Me.dgTypeTally.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTypeTally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTypeTally.Location = New System.Drawing.Point(6, 23)
        Me.dgTypeTally.Name = "dgTypeTally"
        Me.dgTypeTally.Size = New System.Drawing.Size(325, 133)
        Me.dgTypeTally.TabIndex = 8
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BackColor = System.Drawing.Color.Salmon
        Me.btnDeactivate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeactivate.Location = New System.Drawing.Point(221, 162)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(110, 32)
        Me.btnDeactivate.TabIndex = 7
        Me.btnDeactivate.Text = "DEACTIVATE"
        Me.btnDeactivate.UseVisualStyleBackColor = False
        '
        'btnActivate
        '
        Me.btnActivate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivate.Location = New System.Drawing.Point(126, 162)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(89, 32)
        Me.btnActivate.TabIndex = 6
        Me.btnActivate.Text = "ACTIVATE"
        Me.btnActivate.UseVisualStyleBackColor = False
        '
        'frmType
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(657, 224)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pet Type"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTypeTally, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPetType As TextBox
    Friend WithEvents lblPetName As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgTypeTally As DataGridView
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnPlus As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendor
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
        Me.mnuVendor = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvVendor = New System.Windows.Forms.DataGridView()
        Me.mnuVendor.SuspendLayout()
        CType(Me.dgvVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuVendor
        '
        Me.mnuVendor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuVendor.Location = New System.Drawing.Point(0, 0)
        Me.mnuVendor.Name = "mnuVendor"
        Me.mnuVendor.Size = New System.Drawing.Size(739, 24)
        Me.mnuVendor.TabIndex = 0
        Me.mnuVendor.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuClose.Text = "Close"
        '
        'dgvVendor
        '
        Me.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendor.Location = New System.Drawing.Point(13, 28)
        Me.dgvVendor.Name = "dgvVendor"
        Me.dgvVendor.Size = New System.Drawing.Size(714, 346)
        Me.dgvVendor.TabIndex = 1
        '
        'frmVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 386)
        Me.Controls.Add(Me.dgvVendor)
        Me.Controls.Add(Me.mnuVendor)
        Me.MainMenuStrip = Me.mnuVendor
        Me.Name = "frmVendor"
        Me.Text = "Vendor"
        Me.mnuVendor.ResumeLayout(False)
        Me.mnuVendor.PerformLayout()
        CType(Me.dgvVendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuVendor As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents dgvVendor As DataGridView
End Class

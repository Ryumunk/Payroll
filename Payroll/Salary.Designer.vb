<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalary
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
        Me.mnuSalary = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSalary = New System.Windows.Forms.DataGridView()
        Me.mnuSalary.SuspendLayout()
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuSalary
        '
        Me.mnuSalary.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuSalary.Location = New System.Drawing.Point(0, 0)
        Me.mnuSalary.Name = "mnuSalary"
        Me.mnuSalary.Size = New System.Drawing.Size(1284, 24)
        Me.mnuSalary.TabIndex = 0
        Me.mnuSalary.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReport, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuReport
        '
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(109, 22)
        Me.mnuReport.Text = "Report"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(109, 22)
        Me.mnuClose.Text = "Close"
        '
        'dgvSalary
        '
        Me.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalary.Location = New System.Drawing.Point(13, 28)
        Me.dgvSalary.Name = "dgvSalary"
        Me.dgvSalary.Size = New System.Drawing.Size(1259, 318)
        Me.dgvSalary.TabIndex = 1
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 358)
        Me.Controls.Add(Me.dgvSalary)
        Me.Controls.Add(Me.mnuSalary)
        Me.MainMenuStrip = Me.mnuSalary
        Me.Name = "frmSalary"
        Me.Text = "Salary"
        Me.mnuSalary.ResumeLayout(False)
        Me.mnuSalary.PerformLayout()
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSalary As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents dgvSalary As DataGridView
    Friend WithEvents mnuReport As ToolStripMenuItem
End Class

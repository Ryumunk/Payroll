<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.mnuPayroll = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnVendors = New System.Windows.Forms.Button()
        Me.mnuPayroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPayroll
        '
        Me.mnuPayroll.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAbout, Me.mnuHelp})
        Me.mnuPayroll.Location = New System.Drawing.Point(0, 0)
        Me.mnuPayroll.Name = "mnuPayroll"
        Me.mnuPayroll.Size = New System.Drawing.Size(607, 24)
        Me.mnuPayroll.TabIndex = 0
        Me.mnuPayroll.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(103, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(103, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 52)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(153, 66)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnSalary
        '
        Me.btnSalary.Location = New System.Drawing.Point(192, 52)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(153, 66)
        Me.btnSalary.TabIndex = 2
        Me.btnSalary.Text = "Salary"
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(12, 138)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(153, 66)
        Me.btnEmployee.TabIndex = 3
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(192, 138)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(153, 66)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(429, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 66)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnVendors
        '
        Me.btnVendors.Location = New System.Drawing.Point(13, 222)
        Me.btnVendors.Name = "btnVendors"
        Me.btnVendors.Size = New System.Drawing.Size(153, 66)
        Me.btnVendors.TabIndex = 6
        Me.btnVendors.Text = "Vendors"
        Me.btnVendors.UseVisualStyleBackColor = True
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 306)
        Me.Controls.Add(Me.btnVendors)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.mnuPayroll)
        Me.MainMenuStrip = Me.mnuPayroll
        Me.Name = "frmPayroll"
        Me.Text = "Payroll"
        Me.mnuPayroll.ResumeLayout(False)
        Me.mnuPayroll.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPayroll As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnSalary As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnVendors As Button
    Friend WithEvents mnuHelp As ToolStripMenuItem
End Class

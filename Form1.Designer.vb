<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AppointmentToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.AppointmentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(149, 32)
        Me.AppointmentToolStripMenuItem.Text = "Appointments"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.ViewToolStripMenuItem1})
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(108, 32)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(180, 32)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(180, 32)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(103, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WelCome To Repair Shop"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class

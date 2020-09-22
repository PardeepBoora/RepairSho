<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAppointment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboRepair = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkbox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(333, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(537, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(69, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repair Type"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(299, 73)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 5
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(522, 76)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(121, 21)
        Me.cboCustomer.TabIndex = 6
        '
        'cboRepair
        '
        Me.cboRepair.FormattingEnabled = True
        Me.cboRepair.Location = New System.Drawing.Point(211, 142)
        Me.cboRepair.Name = "cboRepair"
        Me.cboRepair.Size = New System.Drawing.Size(121, 21)
        Me.cboRepair.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(23, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Description"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(28, 220)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(457, 96)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSave.Location = New System.Drawing.Point(52, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 41)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnCancel.Location = New System.Drawing.Point(423, 364)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 41)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkbox
        '
        Me.chkbox.AutoSize = True
        Me.chkbox.Location = New System.Drawing.Point(391, 146)
        Me.chkbox.Name = "chkbox"
        Me.chkbox.Size = New System.Drawing.Size(107, 17)
        Me.chkbox.TabIndex = 12
        Me.chkbox.Text = "Must be licenced"
        Me.chkbox.UseVisualStyleBackColor = True
        '
        'NewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkbox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboRepair)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewAppointment"
        Me.Text = "NewAppointment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTime As TextBox
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents cboRepair As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkbox As CheckBox
End Class

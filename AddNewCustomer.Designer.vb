<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCustomer
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblName.Location = New System.Drawing.Point(137, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblPhone.Location = New System.Drawing.Point(137, 153)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(69, 25)
        Me.lblPhone.TabIndex = 1
        Me.lblPhone.Text = "Phone"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(265, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 23)
        Me.txtName.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPhone.Location = New System.Drawing.Point(265, 157)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(146, 23)
        Me.txtPhone.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnSave.Location = New System.Drawing.Point(167, 236)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 50)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnCancel.Location = New System.Drawing.Point(322, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 50)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddNewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Name = "AddNewCustomer"
        Me.Text = "AddNewCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class

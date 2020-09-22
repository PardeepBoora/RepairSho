<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RepairServiceDataSet = New RepairShop.RepairServiceDataSet()
        Me.CustomerShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerShopTableAdapter = New RepairShop.RepairServiceDataSetTableAdapters.CustomerShopTableAdapter()
        Me.CustIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepairServiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerShopBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(55, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(585, 267)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RepairServiceDataSet
        '
        Me.RepairServiceDataSet.DataSetName = "RepairServiceDataSet"
        Me.RepairServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerShopBindingSource
        '
        Me.CustomerShopBindingSource.DataMember = "CustomerShop"
        Me.CustomerShopBindingSource.DataSource = Me.RepairServiceDataSet
        '
        'CustomerShopTableAdapter
        '
        Me.CustomerShopTableAdapter.ClearBeforeFill = True
        '
        'CustIdDataGridViewTextBoxColumn
        '
        Me.CustIdDataGridViewTextBoxColumn.DataPropertyName = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.HeaderText = "CustId"
        Me.CustIdDataGridViewTextBoxColumn.Name = "CustIdDataGridViewTextBoxColumn"
        Me.CustIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepairServiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RepairServiceDataSet As RepairServiceDataSet
    Friend WithEvents CustomerShopBindingSource As BindingSource
    Friend WithEvents CustomerShopTableAdapter As RepairServiceDataSetTableAdapters.CustomerShopTableAdapter
    Friend WithEvents CustIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

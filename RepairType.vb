Public Class RepairType
    Private adapter As New RepairServiceDataSetTableAdapters.RepairTypeTableAdapter
    Public ReadOnly Property items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Description"
            Return table
        End Get
    End Property
End Class

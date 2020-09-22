Public Class Customers
    Private adapter As New RepairServiceDataSetTableAdapters.CustomerShopTableAdapter
    Public Shared LastError As String
    Dim origCustomerRow As RepairServiceDataSet.CustomerShopRow
    Public ReadOnly Property items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Name"
            Return table
        End Get
    End Property
    Public ReadOnly Property NextCustomerID As Short
        Get
            Dim lastCustId As Short = adapter.GetLastCustId()
            Const increment_value As Short = 1
            If lastCustId = 0 Then
                Return 1
            Else
                Return lastCustId + increment_value
            End If
        End Get
    End Property
    Public Function PhoneDuplicate(id As Short, phone As String) As Boolean
        Dim existingCustomer As DataRow = adapter.FindByPhone(phone).FirstOrDefault()
        If existingCustomer Is Nothing Then
            Return False
        End If
        Return id <> existingCustomer(0)
    End Function
    Public Function FindById(custId As Short) As RepairServiceDataSet.CustomerShopRow
        Dim table As DataTable = adapter.FindById(custId)
        Return CType(table.Rows(0), RepairServiceDataSet.CustomerShopRow)
    End Function

    Public Function Insert(custId As Short, name As String, phone As String) As Boolean
        Try
            adapter.Insert(custId, name, phone)
            Return True
        Catch ex As Exception
            lastError = "failed to insert new customer.reasons:" & ex.Message
            Return False
        End Try
    End Function
    Public Function Update(custId As Short, name As String, phone As String) As Boolean
        Try
            origCustomerRow = adapter.GetData().FindByCustId(custId)
            adapter.Insert(custId, name, phone, origCustomerRow.CustId, origCustomerRow.Name, origCustomerRow.Phone)
            Return True
        Catch ex As Exception
            LastError = "failed to insert new customer.reasons:" & ex.Message
            Return False
        End Try
    End Function
    Public Function Delete(custId As Short) As Boolean
        Dim rowAffected As Integer = 0
        If MessageBox.Show("delete Customer?", "delete Customer?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            origCustomerRow = adapter.GetData().FindByCustId(custId)
            rowAffected = adapter.Delete(origCustomerRow.CustId, origCustomerRow.Name, origCustomerRow.Phone)

        End If
        Return rowAffected > 0
    End Function
End Class

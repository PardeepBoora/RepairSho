Public Class Appointments
    Private adapter As New RepairServiceDataSetTableAdapters.AppiontmentTableAdapter
    Public Shared LastError As String
    Dim origAppointment As RepairServiceDataSet.AppointmentListRow
    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    Public Function GetByCustomerId(custId As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "custId =" & custId
        Return table
    End Function

    Public Function FindByApptId(apptId As Short) As RepairServiceDataSet.AppiontmentRow
        Dim table As RepairServiceDataSet.AppiontmentDataTable = adapter.GetData()
        Return table.FindByApptId(apptId)
    End Function

    Public Shared Function CombineDateTime(aDate As DateTime, aTime As DateTime) As DateTime
        Dim ts As New TimeSpan(aTime.Hour, aTime.Minute, 0)
        Return aTime.Add(ts)
    End Function

    Public Function Insert(typeId As Short, description As String, licesence As Boolean, custId As Short,
                           schedule As DateTime) As Boolean
        Try
            adapter.Insert(typeId, description, licesence, custId, schedule)
            Return True
        Catch ex As Exception
            LastError = "failed to insert new customer.reasons:" & ex.Message
            Return False
        End Try
    End Function
    Public Function Update(apptId As Short, typeId As Short, description As String, licesence As Boolean,
                           custId As Short, schedule As DateTime) As Boolean
        Try
            origAppointment = adapter.GetData().FindByApptId(apptId)
            adapter.Update(typeId, description, licesence, custId, schedule, origAppointment.ApptId)
            Return True
        Catch ex As Exception
            LastError = "failed to insert new customer.reasons:" & ex.Message
            Return False
        End Try
    End Function
    Public Function Delete(apptId As Short) As Boolean
        Dim rowAffected As Integer = 0
        If MessageBox.Show("delete Customer?", "delete Customer?", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then


        End If
        Return rowAffected > 0
    End Function
End Class

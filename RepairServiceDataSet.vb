Partial Class RepairServiceDataSet
    Partial Public Class AppiontmentDataTable
        Private Sub AppiontmentDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ApptIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Public Class frmCustomers
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'DsCustomers.vcustomers' table. You can move, or remove it, as needed.
        Me.VcustomersTableAdapter.Fill(Me.DsCustomers.vcustomers)

    End Sub
End Class
Public Class frmTasks
    Private Sub frmTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTasks.vtasks' table. You can move, or remove it, as needed.
        Me.VtasksTableAdapter.Fill(Me.DsTasks.vtasks)

    End Sub
End Class
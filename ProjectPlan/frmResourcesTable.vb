Public Class frmResourcesTable
    Private Sub frmResourcesTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim thisDGV As DataGridView = Me.dgvPlanning

            thisDGV.Rows.Add()
            thisDGV.Rows.Add()
            thisDGV.Rows.Add()


            Dim thisDGVTest1 As DataGridView = Me.dgvtest1

            thisDGV.Item(0, 0).Value = "0.0"
            thisDGV.Item(0, 1).Value = "0.1"
            thisDGV.Item(0, 2).Value = "0.2"
            thisDGV.Item(1, 0).Value = "1.0"
            thisDGV.Item(1, 1).Value = "1.1"
            thisDGV.Item(1, 2).Value = "1.2"
            thisDGV.Item(2, 0).Value = "2.0"
            thisDGV.Item(2, 1).Value = "2.1"
            thisDGV.Item(2, 2).Value = "2.2"

            Dim thisTextBox As New TextBox
            thisTextBox.Text = "Toto"



        Catch ex As Exception

        End Try
    End Sub
End Class
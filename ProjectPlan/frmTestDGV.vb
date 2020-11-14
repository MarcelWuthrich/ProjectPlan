Public Class frmTestDGV
    Private Sub frmTestDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectPlanDataSet1.vProjectList' table. You can move, or remove it, as needed.
        Me.VProjectListTableAdapter.Fill(Me.ProjectPlanDataSet1.vProjectList)

        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim bs As New BindingSource
        bs = VProjectListBindingSource

        bs.Filter = "title like '%SERV%'"

        DataGridView1.DataSource = bs

    End Sub
End Class
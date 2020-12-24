Public Class frmResourcesTable
    Private Sub frmResourcesTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.dtpDateFrom.Value = DateSerial(Year(Today), Month(Today), 1)
            Me.dtpDateTo.Value = DateSerial(Year(Today), Month(Today) + 1, 0)


            pTestDisplay1()




            Dim thisDGV As DataGridView = Me.dgvPlanning


            'thisDGV.Rows.Add()
            'thisDGV.Rows.Add()
            'thisDGV.Rows.Add()


            'Dim thisDGVTest1 As DataGridView = Me.dgvtest1

            'thisDGV.Item(0, 0).Value = "0.0"
            'thisDGV.Item(0, 1).Value = "0.1"
            'thisDGV.Item(0, 2).Value = "0.2"
            'thisDGV.Item(1, 0).Value = "1.0"
            'thisDGV.Item(1, 1).Value = "1.1"
            'thisDGV.Item(1, 2).Value = "1.2"
            'thisDGV.Item(2, 0).Value = "2.0"
            'thisDGV.Item(2, 1).Value = "2.1"
            'thisDGV.Item(2, 2).Value = "2.2"

            'Dim thisTextBox As New TextBox
            'thisTextBox.Text = "Toto"



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub pTestDisplay1()

        Try

            Me.dgvPlanning.Rows.Clear()

            Dim thisDay As Date = Today
            Dim lastDay = DateAdd(DateInterval.Day, 7, thisDay)


            While thisDay < lastDay
                Debug.Print(thisDay)

                Dim col As New DataGridViewTextBoxColumn
                col.HeaderText = Format(thisDay, "d") & vbCrLf & "08h00"
                dgvPlanning.Columns.Add(col)

                col = New DataGridViewTextBoxColumn
                col.HeaderText = Format(thisDay, "d") & vbCrLf & "09h00"
                dgvPlanning.Columns.Add(col)

                col = New DataGridViewTextBoxColumn
                col.HeaderText = Format(thisDay, "d") & vbCrLf & "10h00"
                dgvPlanning.Columns.Add(col)

                col = New DataGridViewTextBoxColumn
                col.HeaderText = Format(thisDay, "d") & vbCrLf & "11h00"
                dgvPlanning.Columns.Add(col)

                thisDay = DateAdd(DateInterval.Day, 1, thisDay)
            End While

            dgvPlanning.Rows.Add("test")
            dgvPlanning.Rows.Add()
            dgvPlanning.Rows.Add()

            dgvPlanning.Rows(1).HeaderCell.Value = "test"

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

End Class
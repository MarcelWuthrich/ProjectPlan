Public Class frmResourcesTable
    Private Sub frmResourcesTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.dtpDateFrom.Value = DateSerial(Year(Today), Month(Today), 1)
            Me.dtpDateTo.Value = DateSerial(Year(Today), Month(Today) + 1, 0)

            Me.dgvPlanning.Columns.Clear()
            Me.dgvPlanning.Rows.Clear()

            Dim thisDGV As DataGridView = Me.dgvPlanning

            thisDGV.Columns.Add("Col1", "Header Col1")

            dgvPlanning.Rows.Add(10)
            dgvPlanning.Rows.Add()
            dgvPlanning.Rows.Add()

            thisDGV.Rows(0).HeaderCell.Value = Format(Today, "D") & " " & "08h00"
            thisDGV.Rows(1).HeaderCell.Value = Format(Today, "D") & " " & "09h00"
            thisDGV.Rows(2).HeaderCell.Value = Format(Today, "D") & " " & "10h00"

            'Dim StartHours() As Integer = {8, 9, 10, 11, 13, 14, 15, 16}

            'Me.dgvPlanning.Columns.Clear()

            'Dim col As New DataGridViewColumn

            'Dim thisDay As Date = Today
            'Dim MaxDay As Date = DateAdd(DateInterval.Day, 4, thisDay)

            'While thisDay < MaxDay
            '    For Each thisHour In StartHours
            '        col = New DataGridViewColumn
            '        col.HeaderText = Format(thisDay, "dd") & vbCrLf & Format(thisHour, "00") & "h00"
            '        dgvPlanning.Columns.Add(col)
            '    Next thisHour
            '    thisDay = DateAdd(DateInterval.Day, 1, thisDay)
            'End While


            'Dim myRow As New DataGridViewRow
            'Dim myID As Integer = dgvPlanning.Rows.Add()

            'myRow = dgvPlanning.Rows(myID)
            'myRow.Cells(0).Value = "valeur 0"
            'myRow.Cells(1).Value = "valeur 1"


            'Dim myRow As String() = {"1", "2", "3"}
            'dgvPlanning.Rows.Add(myRow)





            'Dim thisDGVTest1 As DataGridView = Me.dgvPlanning

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

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
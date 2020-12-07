Public Class frmResourcesAdmin
    Private Sub frmResourcesAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayProjectMembers()
            pDisplayResourcesAdmin()

            Me.radDaily.Checked = True

            pClearFieldsDaily()


        Catch ex As Exception

        End Try

    End Sub
    Private Sub pDisplayResourcesAdmin()
        Try

            'TODO: This line of code loads data into the 'DsResoucesAdmin.vresourcesadmin' table. You can move, or remove it, as needed.
            Me.VresourcesadminTableAdapter.Fill(Me.DsResoucesAdmin.vresourcesadmin)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VresourcesadminBindingSource
            thisBindingSource.Filter = myFilter

            dgvResourcesAdmin.DataSource = thisBindingSource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjectMembers()

        Try

            'TODO: This line of code loads data into the 'ProjectplanDataSet.vprojectmembers' table. You can move, or remove it, as needed.
            Me.VprojectmembersTableAdapter.Fill(Me.dsProjectPlan.vprojectmembers)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VprojectmembersBindingSource
            thisBindingSource.Filter = myFilter

            dgvProjectMembers.DataSource = thisBindingSource

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

    Private Sub radDaily_CheckedChanged(sender As Object, e As EventArgs) Handles radDaily.CheckedChanged
        Try

            If Me.radDaily.Checked = True Then
                Me.grpDaily.Visible = True
                Me.grpWeekly.Visible = False
            End If

            pClearFieldsDaily()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles radWeekly.CheckedChanged
        Try

            If Me.radWeekly.Checked = True Then
                Me.grpWeekly.Visible = True
                Me.grpDaily.Visible = False
            End If

            pClearFieldsDaily()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub texDayFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texDayFrom.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texDayTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texDayTo.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texWeekFrom.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texWeekTo.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfWeeks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texNumberOfWeeks.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)

            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))
                MessageBox.Show(Me.texNumberOfWeeks.Text)
            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texNumberOfDays.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcPlan_Click(sender As Object, e As EventArgs) Handles btcPlan.Click
        Try

            'Validation des champs
            pValidateFieldsDaily()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub pClearFieldsDaily()
        Try
            Me.texMessage.Text = ""
            Me.texNumberOfDays.BackColor = Nothing
            Me.texDayFrom.BackColor = Nothing
            Me.texDayTo.BackColor = Nothing

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub pValidateFieldsDaily()
        Try

            pClearFieldsDaily()

            Dim thisNumberOfDays As Integer = 0
            Dim thisDayFrom As Integer = 0
            Dim thisDayTo As Integer = 0

            Try
                thisNumberOfDays = CInt(Me.texNumberOfDays.Text)
            Catch ex As Exception
            End Try

            Try
                thisDayFrom = CInt(Me.texDayFrom.Text)
            Catch ex As Exception
            End Try

            Try
                thisDayTo = CInt(Me.texDayTo.Text)
            Catch ex As Exception
            End Try


            Select Case thisNumberOfDays
                Case 1 To 365
                    'OK nombre de jours valables
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Max. 365 jours. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Max. 365 jours. "
                    End If
                    Me.texNumberOfDays.BackColor = Color.Pink
            End Select


            Select Case thisDayFrom

                Case 8, 9, 10, 11, 13, 14, 15, 16
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    End If
                    Me.texDayFrom.BackColor = Color.Pink
            End Select

            Select Case thisDayTo
                Case 9, 10, 11, 12, 14, 15, 16, 17
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    End If
                    Me.texDayTo.BackColor = Color.Pink
            End Select



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class
Imports System.Data.SqlClient

Public Class frmProjectMembers


    Private Sub frmProjectMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub pDisplayProjectMembers()

        Try
            Dim ActiveRow As Integer = 0
            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT ID_ProjectMember FROM ProjectsMembers"



            'On vide le DataGridView

            dgvProjectsMembers.Rows.Clear()
            dgvProjectsMembers.Columns.Clear()


            'Définition du DataGridView
            dgvProjectsMembers.ReadOnly = True
            dgvProjectsMembers.AllowUserToAddRows = False
            dgvProjectsMembers.AllowUserToDeleteRows = False
            dgvProjectsMembers.MultiSelect = False


            'Définition des colonnes
            dgvProjectsMembers.Columns.Add("ID_ProjectMember", "ID_ProjectMember")
            dgvProjectsMembers.Columns.Add("Prenom", "Prénom")
            dgvProjectsMembers.Columns.Add("Nom", "Nom")
            dgvProjectsMembers.Columns.Add("Tâche", "Tâche")


            MySQLConnection.ConnectionString = cnProjectPlan
            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                Dim thisMember As New myProjectMember
                Dim thisTask As New myTask

                'Lecture du premier paramètre COUNT
                Try
                    thisMember.ID_ProjectMember = mySQLDataReader.GetValue(0)
                    thisMember.Read()

                    thisTask.ID_Task = thisMember.CE_ID_Task
                    thisTask.Read()

                    'On ajoute le projet dans le DataGridView
                    dgvProjectsMembers.Rows.Add()
                    dgvProjectsMembers.Item(0, ActiveRow).Value = thisMember.ID_ProjectMember
                    dgvProjectsMembers.Item(1, ActiveRow).Value = thisMember.FirstName
                    dgvProjectsMembers.Item(2, ActiveRow).Value = thisMember.Lastname
                    dgvProjectsMembers.Item(3, ActiveRow).Value = thisTask.Task

                    'La colonne 0 (ID_Project) n'est pas visible
                    dgvProjectsMembers.Columns(0).Visible = False

                    'On ajuste  la taille des colonnes
                    dgvProjectsMembers.Columns(1).Width = 150
                    dgvProjectsMembers.Columns(2).Width = 150
                    dgvProjectsMembers.Columns(3).Width = 100

                    ActiveRow = ActiveRow + 1
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()

            dgvProjectsMembers.Rows(0).Selected = True
            ID_ProjectMember = dgvProjectsMembers.Item(0, dgvProjectsMembers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub dgvProjectsMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectsMembers.CellClick

        Try

            dgvProjectsMembers.Rows(dgvProjectsMembers.CurrentCell.RowIndex).Selected = True
            ID_ProjectMember = dgvProjectsMembers.Item(0, dgvProjectsMembers.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcClose_Click(sender As Object, e As EventArgs) Handles btcClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcAdd_Click(sender As Object, e As EventArgs) Handles btcAdd.Click

        Try

            ID_ProjectMember = 0

            Dim myForm As Form = frmProjectMemberDetails

            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub btcEdit_Click(sender As Object, e As EventArgs) Handles btcEdit.Click
        Try

            Dim myForm As Form = frmProjectMemberDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectMembers()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
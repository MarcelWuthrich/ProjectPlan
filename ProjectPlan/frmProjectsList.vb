Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class frmProjectsList
    Private Sub frmProjectsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Polulate des statuts
            pPopulateFilterStatus()

            'Polulate des categories
            pPopulateFilterCategory()

            'Affichage de tous les projets
            pDisplayProjects()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pDisplayProjects()

        Try
            Dim ActiveRow As Integer = 0
            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = ""
            If Me.chkAllProjects.Checked = True Then
                Sql = "SELECT ID_Project FROM Projects;"
            Else
                Sql = "SELECT ID_Project FROM Projects WHERE CE_ID_Status in (6,7,8,9);"
            End If

            Me.Cursor = Cursors.WaitCursor

            'On vide le DataGridView
            dgvProjets.Rows.Clear()
            dgvProjets.Columns.Clear()

            'On rend certains éléments invisible durant le chargement des données
            dgvProjets.Visible = False



            'Définition du DataGridView
            dgvProjets.ReadOnly = True
            dgvProjets.AllowUserToAddRows = False
            dgvProjets.AllowUserToDeleteRows = False
            dgvProjets.MultiSelect = False


            'Définition des colonnes
            'dgvProjets.Columns.Add("ID_Project", "ID_Project")
            dgvProjets.Columns.Add("ID", "ID")
            dgvProjets.Columns.Add("Titre", "Titre")
            dgvProjets.Columns.Add("Categorie", "Catégorie")
            dgvProjets.Columns.Add("Description", "Description")
            dgvProjets.Columns.Add("Statut", "Statut")
            dgvProjets.Columns.Add("Deadline", "Deadline")
            dgvProjets.Columns.Add("Chef de projet", "Chef de projet")
            dgvProjets.Columns.Add("Ressources", "Ressources estimées")
            dgvProjets.Columns.Add("Ressources", "Ressources réalisées")
            dgvProjets.Columns.Add("Taux", "Taux de réalisation")
            dgvProjets.Columns.Add("Priorité", "Priorité")
            dgvProjets.Columns.Add("Urgence", "Urgence")


            MySQLConnection.ConnectionString = cnProjectPlan
            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                Dim thisProject As New myProject
                Dim thisCategory As New myProjectCategory
                Dim thisPrio As New myPriority
                Dim thisUrgency As New myUrgency

                'Lecture du premier paramètre COUNT
                Try
                    'Lecture du projet
                    thisProject.ID_Project = mySQLDataReader.GetValue(0)
                    thisProject.Read()

                    'Lecture de la catégorie
                    thisCategory.ID_Category = thisProject.CE_ID_Category
                    thisCategory.Read()

                    'Lecture de la priorité
                    thisPrio.ID_Priority = thisProject.CE_ID_Priority
                    thisPrio.Read()

                    'Lecture de l'urgence
                    thisUrgency.ID_Urgency = thisProject.CE_ID_Urgency
                    thisUrgency.Read()

                    'On ajoute le projet dans le DataGridView
                    dgvProjets.Rows.Add()
                    dgvProjets.Item(0, ActiveRow).Value = thisProject.ID_Project
                    dgvProjets.Item(1, ActiveRow).Value = thisProject.Title
                    dgvProjets.Item(2, ActiveRow).Value = thisCategory.Category
                    dgvProjets.Item(3, ActiveRow).Value = thisProject.Description
                    Dim _myStatus As New myStatus
                    _myStatus.ID_Status = thisProject.CE_ID_Status
                    _myStatus.Read()
                    dgvProjets.Item(4, ActiveRow).Value = _myStatus.Status
                    dgvProjets.Item(5, ActiveRow).Value = Format(thisProject.DeadLine, "yyyy-MM-dd")
                    Dim _myPM As New myProjectManager
                    _myPM.ID_ProjectManager = thisProject.CE_ID_ProjectManager
                    _myPM.Read()
                    dgvProjets.Item(6, ActiveRow).Value = _myPM.FullName
                    dgvProjets.Item(7, ActiveRow).Value = thisProject.EstimatedResources
                    dgvProjets.Item(8, ActiveRow).Value = thisProject.EffectiveResources
                    dgvProjets.Item(9, ActiveRow).Value = thisProject.ImplementationRate
                    dgvProjets.Item(10, ActiveRow).Value = thisPrio.Priority
                    dgvProjets.Item(11, ActiveRow).Value = thisUrgency.Urgency

                    'La colonne 0 (ID_Project) n'est pas visible
                    'dgvProjets.Columns(0).Visible = False
                    'dgvProjets.Columns(0).Visible = True

                    'On ajuste automatiquement la taille des coloness titre et catégorie
                    Dim myCol0 As DataGridViewColumn = dgvProjets.Columns(0)
                    myCol0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvProjets.AutoResizeColumn(1)
                    dgvProjets.AutoResizeColumn(2)
                    dgvProjets.AutoResizeColumn(4)
                    dgvProjets.AutoResizeColumn(5)
                    dgvProjets.AutoResizeColumn(6)
                    dgvProjets.AutoResizeColumn(7)
                    dgvProjets.AutoResizeColumn(8)
                    dgvProjets.AutoResizeColumn(9)
                    dgvProjets.AutoResizeColumn(10)
                    dgvProjets.AutoResizeColumn(11)


                    'Le solde la largeur est attribué à la description
                    Dim myMinWidth As Integer = 60
                    Dim myWidth As Integer = dgvProjets.Width - dgvProjets.Columns(1).Width - dgvProjets.Columns(2).Width - dgvProjets.Columns(4).Width - dgvProjets.Columns(5).Width - dgvProjets.Columns(6).Width - dgvProjets.Columns(7).Width - dgvProjets.Columns(8).Width - dgvProjets.Columns(9).Width - dgvProjets.Columns(10).Width - dgvProjets.Columns(11).Width - 70
                    If myWidth >= myMinWidth Then
                        dgvProjets.Columns(3).Width = myWidth
                    Else
                        dgvProjets.Columns(3).Width = myMinWidth
                    End If



                    ActiveRow = ActiveRow + 1
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()

            dgvProjets.Rows(0).Selected = True
            ID_Project = dgvProjets.Item(0, dgvProjets.CurrentCell.RowIndex).Value

            'On rend certains éléments visible après le chargement des données
            dgvProjets.Visible = True

            Me.labProjectsNumber.Text = "Projects : " & dgvProjets.RowCount & "/" & dgvProjets.RowCount

            'Si le filtre contient une valeur, on filtre
            If Me.texFilter.Text <> "" Or Me.lovFilterStatus.SelectedIndex <> 0 Or Me.lovFilterCategory.SelectedIndex <> 0 Then
                pFilterDGV()
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception

            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try
    End Sub


    Private Sub pFilterDGV()

        Try

            Dim ProjectDisplayedCount As Integer = 0

            'On lit le status
            Dim ID_Status As Integer = Val(DirectCast(lovFilterStatus.SelectedItem, KeyValuePair(Of String, String)).Key)
            Dim myStatus As New myStatus
            If ID_Status <> 0 Then
                myStatus.ID_Status = Val(ID_Status)
                myStatus.Read()
            End If

            'On lit la catégorie
            Dim ID_Category As Integer = Val(DirectCast(lovFilterCategory.SelectedItem, KeyValuePair(Of String, String)).Key)
            Dim myCategory As New myProjectCategory
            If ID_Category <> 0 Then
                myCategory.ID_Category = Val(ID_Category)
                myCategory.Read()
            End If


            Dim I = 0

            For I = 0 To dgvProjets.RowCount - 1

                Dim StrFound As Integer = 0
                Dim StatusFound As Integer = 0
                Dim CategoryFound As Integer = 0

                'On recherche le texte à filtrer dans les champs 0, 1 ou 3 (ID, titre, description)
                StrFound &= InStr(UCase(dgvProjets.Item(0, I).Value), UCase(Me.texFilter.Text))
                StrFound &= InStr(UCase(dgvProjets.Item(1, I).Value), UCase(Me.texFilter.Text))
                StrFound &= InStr(UCase(dgvProjets.Item(3, I).Value), UCase(Me.texFilter.Text))

                'On recherche le status
                StatusFound = InStr(dgvProjets.Item(4, I).Value, myStatus.Status)



                'On recherche la catégorie
                CategoryFound = InStr(dgvProjets.Item(2, I).Value, myCategory.Category)

                'On recherche la catégorie
                CategoryFound = InStr(dgvProjets.Item(2, I).Value, myCategory.Category)


                If StrFound > 0 And StatusFound > 0 And CategoryFound > 0 Then
                    dgvProjets.Rows(I).Visible = True
                    ProjectDisplayedCount = ProjectDisplayedCount + 1
                Else
                    dgvProjets.Rows(I).Visible = False
                End If

            Next I

            Me.labProjectsNumber.Text = "Projects : " & ProjectDisplayedCount & "/" & dgvProjets.RowCount

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pPopulateFilterStatus()

        Try

            Me.lovFilterStatus.Items.Clear()

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT ID_Status, Status FROM Status WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MySQLConnection As New SqlConnection

            Dim Status As String = ""
            Dim ID_Status As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'On insère une ligne vide
            myDictionnary.Add(Str(0), "")

            MySQLConnection.ConnectionString = cnProjectPlan
            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)
            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read


                Try
                    ID_Status = mySQLDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Status = mySQLDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Status), Status)

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()

            Me.lovFilterStatus.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovFilterStatus.DisplayMember = "Value"
            Me.lovFilterStatus.ValueMember = "Key"

            Me.lovFilterStatus.SelectedIndex = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pPopulateFilterCategory()

        Try

            Me.lovFilterCategory.Items.Clear()

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT ID_Category, Category FROM ProjectCategories WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MySQLConnection As New SqlConnection

            Dim Category As String = ""
            Dim ID_Category As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'On insère une ligne vide
            myDictionnary.Add(Str(0), "")

            MySQLConnection.ConnectionString = cnProjectPlan
            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)
            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read


                Try
                    ID_Category = mySQLDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Category = mySQLDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Category), Category)

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()

            Me.lovFilterCategory.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovFilterCategory.DisplayMember = "Value"
            Me.lovFilterCategory.ValueMember = "Key"

            Me.lovFilterCategory.SelectedIndex = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcFilter_Click(sender As Object, e As EventArgs) Handles btcFilter.Click
        Try

            pFilterDGV()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjets.CellClick

        Try

            dgvProjets.Rows(dgvProjets.CurrentCell.RowIndex).Selected = True
            ID_Project = dgvProjets.Item(0, dgvProjets.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjets_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjets.CellDoubleClick

        Try

            dgvProjets.Rows(dgvProjets.CurrentCell.RowIndex).Selected = True
            ID_Project = dgvProjets.Item(0, dgvProjets.CurrentCell.RowIndex).Value

            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjects()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcFilterClear_Click(sender As Object, e As EventArgs) Handles btcFilterClear.Click

        Try

            Me.texFilter.Text = ""
            Me.lovFilterStatus.SelectedIndex = 0
            Me.lovFilterCategory.SelectedIndex = 0

            pFilterDGV()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub chkAllProjects_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllProjects.CheckedChanged

        Try
            'Affichage de tous les projets
            pDisplayProjects()
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

    Private Sub btcAddProject_Click(sender As Object, e As EventArgs) Handles btcAddProject.Click
        Try

            ID_Project = 0

            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjects()
            pFilterDGV()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcModifyProject_Click(sender As Object, e As EventArgs) Handles btcModifyProject.Click
        Try

            Dim RowSelected As Integer = dgvProjets.CurrentCell.RowIndex

            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjects()

            pFilterDGV()
            dgvProjets.Rows(3).Selected = True


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub dgvProjets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjets.CellContentClick

    End Sub
End Class
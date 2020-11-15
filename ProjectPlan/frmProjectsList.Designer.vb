<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectsList))
        Me.chkAllProjects = New System.Windows.Forms.CheckBox()
        Me.labFilterCategory = New System.Windows.Forms.Label()
        Me.labFilterStatus = New System.Windows.Forms.Label()
        Me.LabFilterText = New System.Windows.Forms.Label()
        Me.labProjectsNumber = New System.Windows.Forms.Label()
        Me.lovFilterCategory = New System.Windows.Forms.ComboBox()
        Me.lovFilterStatus = New System.Windows.Forms.ComboBox()
        Me.btcFilterClear = New System.Windows.Forms.Button()
        Me.btcFilter = New System.Windows.Forms.Button()
        Me.texFilter = New System.Windows.Forms.TextBox()
        Me.btcModifyProject = New System.Windows.Forms.Button()
        Me.btcAddProject = New System.Windows.Forms.Button()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.VProjectListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjectList = New ProjectPlan.dsProjectList()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.dgvProjets = New System.Windows.Forms.DataGridView()
        Me.VProjectListTableAdapter = New ProjectPlan.dsProjectListTableAdapters.vProjectListTableAdapter()
        Me.IDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_ProjectManager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Urgency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrgencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpFilters.SuspendLayout()
        CType(Me.VProjectListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAllProjects
        '
        Me.chkAllProjects.AutoSize = True
        Me.chkAllProjects.Location = New System.Drawing.Point(452, 45)
        Me.chkAllProjects.Name = "chkAllProjects"
        Me.chkAllProjects.Size = New System.Drawing.Size(95, 17)
        Me.chkAllProjects.TabIndex = 19
        Me.chkAllProjects.Text = "Project inactifs"
        Me.chkAllProjects.UseVisualStyleBackColor = True
        '
        'labFilterCategory
        '
        Me.labFilterCategory.AutoSize = True
        Me.labFilterCategory.Location = New System.Drawing.Point(328, 24)
        Me.labFilterCategory.Name = "labFilterCategory"
        Me.labFilterCategory.Size = New System.Drawing.Size(52, 13)
        Me.labFilterCategory.TabIndex = 18
        Me.labFilterCategory.Text = "Catégorie"
        '
        'labFilterStatus
        '
        Me.labFilterStatus.AutoSize = True
        Me.labFilterStatus.Location = New System.Drawing.Point(202, 24)
        Me.labFilterStatus.Name = "labFilterStatus"
        Me.labFilterStatus.Size = New System.Drawing.Size(35, 13)
        Me.labFilterStatus.TabIndex = 17
        Me.labFilterStatus.Text = "Statut"
        '
        'LabFilterText
        '
        Me.LabFilterText.AutoSize = True
        Me.LabFilterText.Location = New System.Drawing.Point(14, 24)
        Me.LabFilterText.Name = "LabFilterText"
        Me.LabFilterText.Size = New System.Drawing.Size(34, 13)
        Me.LabFilterText.TabIndex = 16
        Me.LabFilterText.Text = "Texte"
        '
        'labProjectsNumber
        '
        Me.labProjectsNumber.Location = New System.Drawing.Point(801, 42)
        Me.labProjectsNumber.Name = "labProjectsNumber"
        Me.labProjectsNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labProjectsNumber.Size = New System.Drawing.Size(118, 21)
        Me.labProjectsNumber.TabIndex = 15
        Me.labProjectsNumber.Text = "Projets : 10/10"
        Me.labProjectsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lovFilterCategory
        '
        Me.lovFilterCategory.FormattingEnabled = True
        Me.lovFilterCategory.Location = New System.Drawing.Point(325, 42)
        Me.lovFilterCategory.Name = "lovFilterCategory"
        Me.lovFilterCategory.Size = New System.Drawing.Size(121, 21)
        Me.lovFilterCategory.TabIndex = 14
        '
        'lovFilterStatus
        '
        Me.lovFilterStatus.FormattingEnabled = True
        Me.lovFilterStatus.Location = New System.Drawing.Point(198, 42)
        Me.lovFilterStatus.Name = "lovFilterStatus"
        Me.lovFilterStatus.Size = New System.Drawing.Size(121, 21)
        Me.lovFilterStatus.TabIndex = 13
        '
        'btcFilterClear
        '
        Me.btcFilterClear.Image = CType(resources.GetObject("btcFilterClear.Image"), System.Drawing.Image)
        Me.btcFilterClear.Location = New System.Drawing.Point(634, 40)
        Me.btcFilterClear.Name = "btcFilterClear"
        Me.btcFilterClear.Size = New System.Drawing.Size(23, 23)
        Me.btcFilterClear.TabIndex = 12
        Me.btcFilterClear.UseVisualStyleBackColor = True
        '
        'btcFilter
        '
        Me.btcFilter.Location = New System.Drawing.Point(553, 40)
        Me.btcFilter.Name = "btcFilter"
        Me.btcFilter.Size = New System.Drawing.Size(75, 23)
        Me.btcFilter.TabIndex = 11
        Me.btcFilter.Text = "Filtre"
        Me.btcFilter.UseVisualStyleBackColor = True
        '
        'texFilter
        '
        Me.texFilter.Location = New System.Drawing.Point(11, 42)
        Me.texFilter.Name = "texFilter"
        Me.texFilter.Size = New System.Drawing.Size(180, 20)
        Me.texFilter.TabIndex = 9
        '
        'btcModifyProject
        '
        Me.btcModifyProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcModifyProject.Location = New System.Drawing.Point(1172, 267)
        Me.btcModifyProject.Name = "btcModifyProject"
        Me.btcModifyProject.Size = New System.Drawing.Size(107, 23)
        Me.btcModifyProject.TabIndex = 8
        Me.btcModifyProject.Text = "Modifier"
        Me.btcModifyProject.UseVisualStyleBackColor = True
        '
        'btcAddProject
        '
        Me.btcAddProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcAddProject.Location = New System.Drawing.Point(1172, 238)
        Me.btcAddProject.Name = "btcAddProject"
        Me.btcAddProject.Size = New System.Drawing.Size(107, 23)
        Me.btcAddProject.TabIndex = 7
        Me.btcAddProject.Text = "Ajouter"
        Me.btcAddProject.UseVisualStyleBackColor = True
        '
        'grpFilters
        '
        Me.grpFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilters.Controls.Add(Me.lovFilterCategory)
        Me.grpFilters.Controls.Add(Me.btcFilterClear)
        Me.grpFilters.Controls.Add(Me.chkAllProjects)
        Me.grpFilters.Controls.Add(Me.lovFilterStatus)
        Me.grpFilters.Controls.Add(Me.labFilterCategory)
        Me.grpFilters.Controls.Add(Me.texFilter)
        Me.grpFilters.Controls.Add(Me.labFilterStatus)
        Me.grpFilters.Controls.Add(Me.labProjectsNumber)
        Me.grpFilters.Controls.Add(Me.btcFilter)
        Me.grpFilters.Controls.Add(Me.LabFilterText)
        Me.grpFilters.Location = New System.Drawing.Point(12, 12)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(1130, 102)
        Me.grpFilters.TabIndex = 20
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Filtres"
        '
        'VProjectListBindingSource
        '
        Me.VProjectListBindingSource.DataMember = "vProjectList"
        Me.VProjectListBindingSource.DataSource = Me.DsProjectList
        '
        'DsProjectList
        '
        Me.DsProjectList.DataSetName = "dsProjectList"
        Me.DsProjectList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btcClose
        '
        Me.btcClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcClose.Location = New System.Drawing.Point(1172, 296)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(107, 23)
        Me.btcClose.TabIndex = 21
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'dgvProjets
        '
        Me.dgvProjets.AllowUserToAddRows = False
        Me.dgvProjets.AllowUserToDeleteRows = False
        Me.dgvProjets.AllowUserToOrderColumns = True
        Me.dgvProjets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProjets.AutoGenerateColumns = False
        Me.dgvProjets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectDataGridViewTextBoxColumn, Me.CE_ID_Category, Me.CE_ID_Status, Me.CE_ID_Priority, Me.CE_ID_ProjectManager, Me.CE_ID_Urgency, Me.CE_ID_Customer, Me.TitleDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DeadlineDataGridViewTextBoxColumn, Me.BeginDate, Me.FirstNameDataGridViewTextBoxColumn, Me.LastName, Me.EstimatedResourcesDataGridViewTextBoxColumn, Me.EffectiveResourcesDataGridViewTextBoxColumn, Me.ImplementationRateDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.UrgencyDataGridViewTextBoxColumn, Me.Description})
        Me.dgvProjets.DataSource = Me.VProjectListBindingSource
        Me.dgvProjets.Location = New System.Drawing.Point(12, 120)
        Me.dgvProjets.Name = "dgvProjets"
        Me.dgvProjets.ReadOnly = True
        Me.dgvProjets.Size = New System.Drawing.Size(1130, 540)
        Me.dgvProjets.TabIndex = 22
        '
        'VProjectListTableAdapter
        '
        Me.VProjectListTableAdapter.ClearBeforeFill = True
        '
        'IDProjectDataGridViewTextBoxColumn
        '
        Me.IDProjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDProjectDataGridViewTextBoxColumn.Name = "IDProjectDataGridViewTextBoxColumn"
        Me.IDProjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProjectDataGridViewTextBoxColumn.Width = 43
        '
        'CE_ID_Category
        '
        Me.CE_ID_Category.DataPropertyName = "CE_ID_Category"
        Me.CE_ID_Category.HeaderText = "CE_ID_Category"
        Me.CE_ID_Category.Name = "CE_ID_Category"
        Me.CE_ID_Category.ReadOnly = True
        Me.CE_ID_Category.Visible = False
        Me.CE_ID_Category.Width = 111
        '
        'CE_ID_Status
        '
        Me.CE_ID_Status.DataPropertyName = "CE_ID_Status"
        Me.CE_ID_Status.HeaderText = "CE_ID_Status"
        Me.CE_ID_Status.Name = "CE_ID_Status"
        Me.CE_ID_Status.ReadOnly = True
        Me.CE_ID_Status.Visible = False
        Me.CE_ID_Status.Width = 99
        '
        'CE_ID_Priority
        '
        Me.CE_ID_Priority.DataPropertyName = "CE_ID_Priority"
        Me.CE_ID_Priority.HeaderText = "CE_ID_Priority"
        Me.CE_ID_Priority.Name = "CE_ID_Priority"
        Me.CE_ID_Priority.ReadOnly = True
        Me.CE_ID_Priority.Visible = False
        '
        'CE_ID_ProjectManager
        '
        Me.CE_ID_ProjectManager.DataPropertyName = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.HeaderText = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.Name = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.ReadOnly = True
        Me.CE_ID_ProjectManager.Visible = False
        Me.CE_ID_ProjectManager.Width = 144
        '
        'CE_ID_Urgency
        '
        Me.CE_ID_Urgency.DataPropertyName = "CE_ID_Urgency"
        Me.CE_ID_Urgency.HeaderText = "CE_ID_Urgency"
        Me.CE_ID_Urgency.Name = "CE_ID_Urgency"
        Me.CE_ID_Urgency.ReadOnly = True
        Me.CE_ID_Urgency.Visible = False
        Me.CE_ID_Urgency.Width = 109
        '
        'CE_ID_Customer
        '
        Me.CE_ID_Customer.DataPropertyName = "CE_ID_Customer"
        Me.CE_ID_Customer.HeaderText = "CE_ID_Customer"
        Me.CE_ID_Customer.Name = "CE_ID_Customer"
        Me.CE_ID_Customer.ReadOnly = True
        Me.CE_ID_Customer.Visible = False
        Me.CE_ID_Customer.Width = 113
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 53
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Categorie"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 77
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'DeadlineDataGridViewTextBoxColumn
        '
        Me.DeadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.HeaderText = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.Name = "DeadlineDataGridViewTextBoxColumn"
        Me.DeadlineDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeadlineDataGridViewTextBoxColumn.Width = 74
        '
        'BeginDate
        '
        Me.BeginDate.DataPropertyName = "BeginDate"
        Me.BeginDate.HeaderText = "Début"
        Me.BeginDate.Name = "BeginDate"
        Me.BeginDate.ReadOnly = True
        Me.BeginDate.Width = 61
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 68
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Nom"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 54
        '
        'EstimatedResourcesDataGridViewTextBoxColumn
        '
        Me.EstimatedResourcesDataGridViewTextBoxColumn.DataPropertyName = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.HeaderText = "Ressources estimées"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Name = "EstimatedResourcesDataGridViewTextBoxColumn"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Width = 121
        '
        'EffectiveResourcesDataGridViewTextBoxColumn
        '
        Me.EffectiveResourcesDataGridViewTextBoxColumn.DataPropertyName = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.HeaderText = "Ressources effectives"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Name = "EffectiveResourcesDataGridViewTextBoxColumn"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Width = 125
        '
        'ImplementationRateDataGridViewTextBoxColumn
        '
        Me.ImplementationRateDataGridViewTextBoxColumn.DataPropertyName = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.HeaderText = "Taux implémentation"
        Me.ImplementationRateDataGridViewTextBoxColumn.Name = "ImplementationRateDataGridViewTextBoxColumn"
        Me.ImplementationRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImplementationRateDataGridViewTextBoxColumn.Width = 118
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priorité"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriorityDataGridViewTextBoxColumn.Width = 64
        '
        'UrgencyDataGridViewTextBoxColumn
        '
        Me.UrgencyDataGridViewTextBoxColumn.DataPropertyName = "Urgency"
        Me.UrgencyDataGridViewTextBoxColumn.HeaderText = "Urgence"
        Me.UrgencyDataGridViewTextBoxColumn.Name = "UrgencyDataGridViewTextBoxColumn"
        Me.UrgencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.UrgencyDataGridViewTextBoxColumn.Width = 73
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 85
        '
        'frmProjectsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 681)
        Me.Controls.Add(Me.dgvProjets)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.btcAddProject)
        Me.Controls.Add(Me.btcModifyProject)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectsList"
        Me.Text = "Liste des projets"
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        CType(Me.VProjectListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkAllProjects As CheckBox
    Friend WithEvents labFilterCategory As Label
    Friend WithEvents labFilterStatus As Label
    Friend WithEvents LabFilterText As Label
    Friend WithEvents labProjectsNumber As Label
    Friend WithEvents lovFilterCategory As ComboBox
    Friend WithEvents lovFilterStatus As ComboBox
    Friend WithEvents btcFilterClear As Button
    Friend WithEvents btcFilter As Button
    Friend WithEvents texFilter As TextBox
    Friend WithEvents btcModifyProject As Button
    Friend WithEvents btcAddProject As Button
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents btcClose As Button
    Friend WithEvents dgvProjets As DataGridView
    Friend WithEvents DsProjectList As dsProjectList
    Friend WithEvents VProjectListBindingSource As BindingSource
    Friend WithEvents VProjectListTableAdapter As dsProjectListTableAdapters.vProjectListTableAdapter
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Category As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Status As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Priority As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_ProjectManager As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Urgency As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Customer As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeginDate As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
End Class

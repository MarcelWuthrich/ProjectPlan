<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProjectsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.btcClose = New System.Windows.Forms.Button()
        Me.dgvProjets = New System.Windows.Forms.DataGridView()
        Me.VprojectlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetVProjectList = New ProjectPlan.DataSetVProjectList()
        Me.VprojectlistTableAdapter = New ProjectPlan.DataSetVProjectListTableAdapters.vprojectlistTableAdapter()
        Me.ID_Project = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Priority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Urgency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urgency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deadline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResources = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResources = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_ProjectManager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerFirstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE_ID_Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpFilters.SuspendLayout()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetVProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvProjets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Project, Me.Title, Me.CE_ID_Status, Me.Status, Me.CE_ID_Priority, Me.Priority, Me.CE_ID_Category, Me.Category, Me.CE_ID_Urgency, Me.Urgency, Me.BeginDate, Me.Deadline, Me.EstimatedResources, Me.EffectiveResources, Me.ImplementationRate, Me.CE_ID_ProjectManager, Me.ManagerFirstname, Me.ManagerLastname, Me.CE_ID_Customer, Me.CustomerFirstname, Me.CustomerLastname, Me.Description})
        Me.dgvProjets.DataSource = Me.VprojectlistBindingSource
        Me.dgvProjets.Location = New System.Drawing.Point(12, 120)
        Me.dgvProjets.Name = "dgvProjets"
        Me.dgvProjets.ReadOnly = True
        Me.dgvProjets.Size = New System.Drawing.Size(1130, 540)
        Me.dgvProjets.TabIndex = 22
        '
        'VprojectlistBindingSource
        '
        Me.VprojectlistBindingSource.DataMember = "vprojectlist"
        Me.VprojectlistBindingSource.DataSource = Me.DataSetVProjectList
        '
        'DataSetVProjectList
        '
        Me.DataSetVProjectList.DataSetName = "DataSetVProjectList"
        Me.DataSetVProjectList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectlistTableAdapter
        '
        Me.VprojectlistTableAdapter.ClearBeforeFill = True
        '
        'ID_Project
        '
        Me.ID_Project.DataPropertyName = "ID_Project"
        Me.ID_Project.HeaderText = "ID"
        Me.ID_Project.Name = "ID_Project"
        Me.ID_Project.ReadOnly = True
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Titre"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'CE_ID_Status
        '
        Me.CE_ID_Status.DataPropertyName = "CE_ID_Status"
        Me.CE_ID_Status.HeaderText = "CE_ID_Status"
        Me.CE_ID_Status.Name = "CE_ID_Status"
        Me.CE_ID_Status.ReadOnly = True
        Me.CE_ID_Status.Visible = False
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Statut"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'CE_ID_Priority
        '
        Me.CE_ID_Priority.DataPropertyName = "CE_ID_Priority"
        Me.CE_ID_Priority.HeaderText = "CE_ID_Priority"
        Me.CE_ID_Priority.Name = "CE_ID_Priority"
        Me.CE_ID_Priority.ReadOnly = True
        Me.CE_ID_Priority.Visible = False
        '
        'Priority
        '
        Me.Priority.DataPropertyName = "Priority"
        Me.Priority.HeaderText = "Priorité"
        Me.Priority.Name = "Priority"
        Me.Priority.ReadOnly = True
        '
        'CE_ID_Category
        '
        Me.CE_ID_Category.DataPropertyName = "CE_ID_Category"
        Me.CE_ID_Category.HeaderText = "CE_ID_Category"
        Me.CE_ID_Category.Name = "CE_ID_Category"
        Me.CE_ID_Category.ReadOnly = True
        Me.CE_ID_Category.Visible = False
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Categorie"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'CE_ID_Urgency
        '
        Me.CE_ID_Urgency.DataPropertyName = "CE_ID_Urgency"
        Me.CE_ID_Urgency.HeaderText = "CE_ID_Urgency"
        Me.CE_ID_Urgency.Name = "CE_ID_Urgency"
        Me.CE_ID_Urgency.ReadOnly = True
        Me.CE_ID_Urgency.Visible = False
        '
        'Urgency
        '
        Me.Urgency.DataPropertyName = "Urgency"
        Me.Urgency.HeaderText = "Urgence"
        Me.Urgency.Name = "Urgency"
        Me.Urgency.ReadOnly = True
        '
        'BeginDate
        '
        Me.BeginDate.DataPropertyName = "BeginDate"
        Me.BeginDate.HeaderText = "Début"
        Me.BeginDate.Name = "BeginDate"
        Me.BeginDate.ReadOnly = True
        '
        'Deadline
        '
        Me.Deadline.DataPropertyName = "Deadline"
        Me.Deadline.HeaderText = "Deadline"
        Me.Deadline.Name = "Deadline"
        Me.Deadline.ReadOnly = True
        '
        'EstimatedResources
        '
        Me.EstimatedResources.DataPropertyName = "EstimatedResources"
        Me.EstimatedResources.HeaderText = "Res. estimées"
        Me.EstimatedResources.Name = "EstimatedResources"
        Me.EstimatedResources.ReadOnly = True
        '
        'EffectiveResources
        '
        Me.EffectiveResources.DataPropertyName = "EffectiveResources"
        Me.EffectiveResources.HeaderText = "Res. effectives"
        Me.EffectiveResources.Name = "EffectiveResources"
        Me.EffectiveResources.ReadOnly = True
        '
        'ImplementationRate
        '
        Me.ImplementationRate.DataPropertyName = "ImplementationRate"
        Me.ImplementationRate.HeaderText = "Taux impl."
        Me.ImplementationRate.Name = "ImplementationRate"
        Me.ImplementationRate.ReadOnly = True
        '
        'CE_ID_ProjectManager
        '
        Me.CE_ID_ProjectManager.DataPropertyName = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.HeaderText = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.Name = "CE_ID_ProjectManager"
        Me.CE_ID_ProjectManager.ReadOnly = True
        Me.CE_ID_ProjectManager.Visible = False
        '
        'ManagerFirstname
        '
        Me.ManagerFirstname.DataPropertyName = "ManagerFirstname"
        Me.ManagerFirstname.HeaderText = "ManagerFirstname"
        Me.ManagerFirstname.Name = "ManagerFirstname"
        Me.ManagerFirstname.ReadOnly = True
        '
        'ManagerLastname
        '
        Me.ManagerLastname.DataPropertyName = "ManagerLastname"
        Me.ManagerLastname.HeaderText = "ManagerLastname"
        Me.ManagerLastname.Name = "ManagerLastname"
        Me.ManagerLastname.ReadOnly = True
        '
        'CE_ID_Customer
        '
        Me.CE_ID_Customer.DataPropertyName = "CE_ID_Customer"
        Me.CE_ID_Customer.HeaderText = "CE_ID_Customer"
        Me.CE_ID_Customer.Name = "CE_ID_Customer"
        Me.CE_ID_Customer.ReadOnly = True
        Me.CE_ID_Customer.Visible = False
        '
        'CustomerFirstname
        '
        Me.CustomerFirstname.DataPropertyName = "CustomerFirstname"
        Me.CustomerFirstname.HeaderText = "CustomerFirstname"
        Me.CustomerFirstname.Name = "CustomerFirstname"
        Me.CustomerFirstname.ReadOnly = True
        '
        'CustomerLastname
        '
        Me.CustomerLastname.DataPropertyName = "CustomerLastname"
        Me.CustomerLastname.HeaderText = "CustomerLastname"
        Me.CustomerLastname.Name = "CustomerLastname"
        Me.CustomerLastname.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Visible = False
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
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetVProjectList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataSetVProjectList As DataSetVProjectList
    Friend WithEvents VprojectlistBindingSource As BindingSource
    Friend WithEvents VprojectlistTableAdapter As DataSetVProjectListTableAdapters.vprojectlistTableAdapter
    Friend WithEvents ID_Project As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Status As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Priority As DataGridViewTextBoxColumn
    Friend WithEvents Priority As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Category As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Urgency As DataGridViewTextBoxColumn
    Friend WithEvents Urgency As DataGridViewTextBoxColumn
    Friend WithEvents BeginDate As DataGridViewTextBoxColumn
    Friend WithEvents Deadline As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResources As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResources As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRate As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_ProjectManager As DataGridViewTextBoxColumn
    Friend WithEvents ManagerFirstname As DataGridViewTextBoxColumn
    Friend WithEvents ManagerLastname As DataGridViewTextBoxColumn
    Friend WithEvents CE_ID_Customer As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstname As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLastname As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
End Class

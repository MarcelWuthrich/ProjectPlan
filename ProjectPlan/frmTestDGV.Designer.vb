<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestDGV
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VProjectListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectPlanDataSet1 = New ProjectPlan.ProjectPlanDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VProjectListTableAdapter = New ProjectPlan.ProjectPlanDataSet1TableAdapters.vProjectListTableAdapter()
        Me.IDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrgencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VProjectListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectPlanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ID_Category, Me.CategoryDataGridViewTextBoxColumn, Me.ID_Status, Me.StatusDataGridViewTextBoxColumn, Me.DeadlineDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.EstimatedResourcesDataGridViewTextBoxColumn, Me.EffectiveResourcesDataGridViewTextBoxColumn, Me.ImplementationRateDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.UrgencyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VProjectListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1072, 498)
        Me.DataGridView1.TabIndex = 0
        '
        'VProjectListBindingSource
        '
        Me.VProjectListBindingSource.DataMember = "vProjectList"
        Me.VProjectListBindingSource.DataSource = Me.ProjectPlanDataSet1
        Me.VProjectListBindingSource.Filter = ""
        '
        'ProjectPlanDataSet1
        '
        Me.ProjectPlanDataSet1.DataSetName = "ProjectPlanDataSet1"
        Me.ProjectPlanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VProjectListTableAdapter
        '
        Me.VProjectListTableAdapter.ClearBeforeFill = True
        '
        'IDProjectDataGridViewTextBoxColumn
        '
        Me.IDProjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.HeaderText = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.Name = "IDProjectDataGridViewTextBoxColumn"
        Me.IDProjectDataGridViewTextBoxColumn.Width = 82
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 53
        '
        'ID_Category
        '
        Me.ID_Category.DataPropertyName = "ID_Category"
        Me.ID_Category.HeaderText = "ID_Category"
        Me.ID_Category.Name = "ID_Category"
        Me.ID_Category.Width = 91
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Categorie"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 77
        '
        'ID_Status
        '
        Me.ID_Status.DataPropertyName = "ID_Status"
        Me.ID_Status.HeaderText = "ID_Status"
        Me.ID_Status.Name = "ID_Status"
        Me.ID_Status.Width = 79
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 62
        '
        'DeadlineDataGridViewTextBoxColumn
        '
        Me.DeadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.HeaderText = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.Name = "DeadlineDataGridViewTextBoxColumn"
        Me.DeadlineDataGridViewTextBoxColumn.Width = 74
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 68
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 54
        '
        'EstimatedResourcesDataGridViewTextBoxColumn
        '
        Me.EstimatedResourcesDataGridViewTextBoxColumn.DataPropertyName = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.HeaderText = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Name = "EstimatedResourcesDataGridViewTextBoxColumn"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Width = 129
        '
        'EffectiveResourcesDataGridViewTextBoxColumn
        '
        Me.EffectiveResourcesDataGridViewTextBoxColumn.DataPropertyName = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.HeaderText = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Name = "EffectiveResourcesDataGridViewTextBoxColumn"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Width = 125
        '
        'ImplementationRateDataGridViewTextBoxColumn
        '
        Me.ImplementationRateDataGridViewTextBoxColumn.DataPropertyName = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.HeaderText = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.Name = "ImplementationRateDataGridViewTextBoxColumn"
        Me.ImplementationRateDataGridViewTextBoxColumn.Width = 126
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.Width = 63
        '
        'UrgencyDataGridViewTextBoxColumn
        '
        Me.UrgencyDataGridViewTextBoxColumn.DataPropertyName = "Urgency"
        Me.UrgencyDataGridViewTextBoxColumn.HeaderText = "Urgency"
        Me.UrgencyDataGridViewTextBoxColumn.Name = "UrgencyDataGridViewTextBoxColumn"
        Me.UrgencyDataGridViewTextBoxColumn.Width = 72
        '
        'frmTestDGV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 664)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTestDGV"
        Me.Text = "frmTestDGV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VProjectListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectPlanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProjectPlanDataSet1 As ProjectPlanDataSet1
    Friend WithEvents VProjectListBindingSource As BindingSource
    Friend WithEvents VProjectListTableAdapter As ProjectPlanDataSet1TableAdapters.vProjectListTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents IDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_Category As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID_Status As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

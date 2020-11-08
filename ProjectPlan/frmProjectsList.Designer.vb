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
        Me.dgvProjets = New System.Windows.Forms.DataGridView()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.btcClose = New System.Windows.Forms.Button()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAllProjects
        '
        Me.chkAllProjects.AutoSize = True
        Me.chkAllProjects.Location = New System.Drawing.Point(605, 45)
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
        Me.btcFilterClear.Location = New System.Drawing.Point(544, 40)
        Me.btcFilterClear.Name = "btcFilterClear"
        Me.btcFilterClear.Size = New System.Drawing.Size(23, 23)
        Me.btcFilterClear.TabIndex = 12
        Me.btcFilterClear.UseVisualStyleBackColor = True
        '
        'btcFilter
        '
        Me.btcFilter.Location = New System.Drawing.Point(463, 40)
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
        'dgvProjets
        '
        Me.dgvProjets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjets.Location = New System.Drawing.Point(12, 120)
        Me.dgvProjets.Name = "dgvProjets"
        Me.dgvProjets.Size = New System.Drawing.Size(1130, 540)
        Me.dgvProjets.TabIndex = 5
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
        'frmProjectsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 681)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.dgvProjets)
        Me.Controls.Add(Me.btcAddProject)
        Me.Controls.Add(Me.btcModifyProject)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectsList"
        Me.Text = "Liste des projets"
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
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
    Friend WithEvents dgvProjets As DataGridView
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents btcClose As Button
End Class

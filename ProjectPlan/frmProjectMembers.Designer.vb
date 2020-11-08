<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectMembers
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectMembers))
        Me.dgvProjectsMembers = New System.Windows.Forms.DataGridView()
        Me.btcAdd = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcDelete = New System.Windows.Forms.Button()
        CType(Me.dgvProjectsMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProjectsMembers
        '
        Me.dgvProjectsMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectsMembers.Location = New System.Drawing.Point(12, 35)
        Me.dgvProjectsMembers.Name = "dgvProjectsMembers"
        Me.dgvProjectsMembers.Size = New System.Drawing.Size(463, 266)
        Me.dgvProjectsMembers.TabIndex = 0
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(516, 108)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 1
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(516, 137)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 2
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(516, 278)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 4
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(516, 166)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 5
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'frmProjectMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 360)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvProjectsMembers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectMembers"
        Me.ShowInTaskbar = False
        Me.Text = "Membres de projets"
        CType(Me.dgvProjectsMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProjectsMembers As DataGridView
    Friend WithEvents btcAdd As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcClose As Button
    Protected Friend WithEvents btcDelete As Button
End Class

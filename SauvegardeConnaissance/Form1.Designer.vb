<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PanelTitre = New System.Windows.Forms.Panel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.Button1Home = New System.Windows.Forms.Button()
        Me.Button1Donne = New System.Windows.Forms.Button()
        Me.Button1Nouveau = New System.Windows.Forms.Button()
        Me.Button1Reglage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDonne = New System.Windows.Forms.Panel()
        Me.PanelNew = New System.Windows.Forms.Panel()
        Me.PanelReglages = New System.Windows.Forms.Panel()
        Me.PanelTitre.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.PanelHome.SuspendLayout()
        Me.PanelDonne.SuspendLayout()
        Me.PanelNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitre
        '
        Me.PanelTitre.BackColor = System.Drawing.Color.Red
        Me.PanelTitre.Controls.Add(Me.Label1)
        Me.PanelTitre.Controls.Add(Me.Panel6)
        Me.PanelTitre.Location = New System.Drawing.Point(-7, -7)
        Me.PanelTitre.Name = "PanelTitre"
        Me.PanelTitre.Size = New System.Drawing.Size(839, 87)
        Me.PanelTitre.TabIndex = 0
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.Button1Reglage)
        Me.PanelButton.Controls.Add(Me.Button1Nouveau)
        Me.PanelButton.Controls.Add(Me.Button1Donne)
        Me.PanelButton.Controls.Add(Me.Button1Home)
        Me.PanelButton.Location = New System.Drawing.Point(-3, 75)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(174, 482)
        Me.PanelButton.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(184, 104)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(459, 405)
        Me.Panel6.TabIndex = 0
        '
        'PanelHome
        '
        Me.PanelHome.BackColor = System.Drawing.Color.White
        Me.PanelHome.Controls.Add(Me.PanelDonne)
        Me.PanelHome.Location = New System.Drawing.Point(166, 75)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(679, 479)
        Me.PanelHome.TabIndex = 2
        '
        'Button1Home
        '
        Me.Button1Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Home.Location = New System.Drawing.Point(15, 11)
        Me.Button1Home.Name = "Button1Home"
        Me.Button1Home.Size = New System.Drawing.Size(137, 103)
        Me.Button1Home.TabIndex = 0
        Me.Button1Home.Text = "Home"
        Me.Button1Home.UseVisualStyleBackColor = True
        '
        'Button1Donne
        '
        Me.Button1Donne.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Donne.Location = New System.Drawing.Point(15, 120)
        Me.Button1Donne.Name = "Button1Donne"
        Me.Button1Donne.Size = New System.Drawing.Size(137, 101)
        Me.Button1Donne.TabIndex = 1
        Me.Button1Donne.Text = "Données"
        Me.Button1Donne.UseVisualStyleBackColor = True
        '
        'Button1Nouveau
        '
        Me.Button1Nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Nouveau.Location = New System.Drawing.Point(15, 227)
        Me.Button1Nouveau.Name = "Button1Nouveau"
        Me.Button1Nouveau.Size = New System.Drawing.Size(137, 101)
        Me.Button1Nouveau.TabIndex = 2
        Me.Button1Nouveau.Text = "Nouveau"
        Me.Button1Nouveau.UseVisualStyleBackColor = True
        '
        'Button1Reglage
        '
        Me.Button1Reglage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Reglage.Location = New System.Drawing.Point(15, 334)
        Me.Button1Reglage.Name = "Button1Reglage"
        Me.Button1Reglage.Size = New System.Drawing.Size(137, 101)
        Me.Button1Reglage.TabIndex = 3
        Me.Button1Reglage.Text = "Réglages"
        Me.Button1Reglage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ethnocentric Rg", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(811, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sauvegarde de vos connaissances"
        '
        'PanelDonne
        '
        Me.PanelDonne.BackColor = System.Drawing.Color.White
        Me.PanelDonne.Controls.Add(Me.PanelNew)
        Me.PanelDonne.Location = New System.Drawing.Point(0, 0)
        Me.PanelDonne.Name = "PanelDonne"
        Me.PanelDonne.Size = New System.Drawing.Size(679, 479)
        Me.PanelDonne.TabIndex = 3
        '
        'PanelNew
        '
        Me.PanelNew.BackColor = System.Drawing.Color.White
        Me.PanelNew.Controls.Add(Me.PanelReglages)
        Me.PanelNew.Location = New System.Drawing.Point(0, 0)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(679, 479)
        Me.PanelNew.TabIndex = 4
        '
        'PanelReglages
        '
        Me.PanelReglages.BackColor = System.Drawing.Color.White
        Me.PanelReglages.Location = New System.Drawing.Point(3, 0)
        Me.PanelReglages.Name = "PanelReglages"
        Me.PanelReglages.Size = New System.Drawing.Size(679, 479)
        Me.PanelReglages.TabIndex = 4
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(824, 520)
        Me.Controls.Add(Me.PanelHome)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTitre)
        Me.Name = "Form1"
        Me.PanelTitre.ResumeLayout(False)
        Me.PanelTitre.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelHome.ResumeLayout(False)
        Me.PanelDonne.ResumeLayout(False)
        Me.PanelNew.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents ButtonGestion As System.Windows.Forms.Button
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents ButtonReglages As System.Windows.Forms.Button
    Friend WithEvents ButtonDonnes As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelHomeConnaissance As System.Windows.Forms.Label
    Friend WithEvents LabelDonneRecherche As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListViewDonnee As System.Windows.Forms.ListView
    Friend WithEvents LabelNouveauTitre As System.Windows.Forms.Label
    Friend WithEvents PanelNouveau As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ConnaissancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConnaissancesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConnaissancesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConnaissancesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelTitre As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents Button1Nouveau As System.Windows.Forms.Button
    Friend WithEvents Button1Donne As System.Windows.Forms.Button
    Friend WithEvents Button1Home As System.Windows.Forms.Button
    Friend WithEvents PanelHome As System.Windows.Forms.Panel
    Friend WithEvents Button1Reglage As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelDonne As System.Windows.Forms.Panel
    Friend WithEvents PanelNew As System.Windows.Forms.Panel
    Friend WithEvents PanelReglages As System.Windows.Forms.Panel

End Class

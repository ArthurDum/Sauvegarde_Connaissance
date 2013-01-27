<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim Km_IdLabel As System.Windows.Forms.Label
        Dim TitreLabel As System.Windows.Forms.Label
        Dim ContenuLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataBaseDataSet = New SauvegardeConnaissance.DataBaseDataSet()
        Me.ConnaissancesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnaissancesTableAdapter = New SauvegardeConnaissance.DataBaseDataSetTableAdapters.ConnaissancesTableAdapter()
        Me.TableAdapterManager = New SauvegardeConnaissance.DataBaseDataSetTableAdapters.TableAdapterManager()
        Me.ConnaissancesBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Km_IdTextBox = New System.Windows.Forms.TextBox()
        Me.TitreTextBox = New System.Windows.Forms.TextBox()
        Me.ContenuTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Km_IdLabel = New System.Windows.Forms.Label()
        TitreLabel = New System.Windows.Forms.Label()
        ContenuLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnaissancesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnaissancesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConnaissancesBindingSource1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Km_IdLabel
        '
        Km_IdLabel.AutoSize = True
        Km_IdLabel.Location = New System.Drawing.Point(12, 45)
        Km_IdLabel.Name = "Km_IdLabel"
        Km_IdLabel.Size = New System.Drawing.Size(37, 13)
        Km_IdLabel.TabIndex = 1
        Km_IdLabel.Text = "Km Id:"
        '
        'TitreLabel
        '
        TitreLabel.AutoSize = True
        TitreLabel.Location = New System.Drawing.Point(12, 71)
        TitreLabel.Name = "TitreLabel"
        TitreLabel.Size = New System.Drawing.Size(31, 13)
        TitreLabel.TabIndex = 3
        TitreLabel.Text = "Titre:"
        '
        'ContenuLabel
        '
        ContenuLabel.AutoSize = True
        ContenuLabel.Location = New System.Drawing.Point(12, 97)
        ContenuLabel.Name = "ContenuLabel"
        ContenuLabel.Size = New System.Drawing.Size(50, 13)
        ContenuLabel.TabIndex = 5
        ContenuLabel.Text = "Contenu:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 124)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 7
        DateLabel.Text = "Date:"
        '
        'DataBaseDataSet
        '
        Me.DataBaseDataSet.DataSetName = "DataBaseDataSet"
        Me.DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConnaissancesBindingSource1
        '
        Me.ConnaissancesBindingSource1.DataMember = "Connaissances"
        Me.ConnaissancesBindingSource1.DataSource = Me.DataBaseDataSet
        '
        'ConnaissancesTableAdapter
        '
        Me.ConnaissancesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConnaissancesTableAdapter = Me.ConnaissancesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SauvegardeConnaissance.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConnaissancesBindingSource1BindingNavigator
        '
        Me.ConnaissancesBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.ConnaissancesBindingSource1BindingNavigator.BindingSource = Me.ConnaissancesBindingSource1
        Me.ConnaissancesBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.ConnaissancesBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.ConnaissancesBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ConnaissancesBindingSource1BindingNavigatorSaveItem})
        Me.ConnaissancesBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConnaissancesBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.ConnaissancesBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.ConnaissancesBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.ConnaissancesBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.ConnaissancesBindingSource1BindingNavigator.Name = "ConnaissancesBindingSource1BindingNavigator"
        Me.ConnaissancesBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ConnaissancesBindingSource1BindingNavigator.Size = New System.Drawing.Size(529, 25)
        Me.ConnaissancesBindingSource1BindingNavigator.TabIndex = 0
        Me.ConnaissancesBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Ajouter nouveau"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Nombre total d'éléments"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Supprimer"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Placer en premier"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Déplacer vers le haut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Position actuelle"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Déplacer vers le bas"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Placer en dernier"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ConnaissancesBindingSource1BindingNavigatorSaveItem
        '
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("ConnaissancesBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem.Name = "ConnaissancesBindingSource1BindingNavigatorSaveItem"
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConnaissancesBindingSource1BindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'Km_IdTextBox
        '
        Me.Km_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource1, "Km Id", True))
        Me.Km_IdTextBox.Location = New System.Drawing.Point(68, 42)
        Me.Km_IdTextBox.Name = "Km_IdTextBox"
        Me.Km_IdTextBox.ReadOnly = True
        Me.Km_IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Km_IdTextBox.TabIndex = 2
        '
        'TitreTextBox
        '
        Me.TitreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource1, "Titre", True))
        Me.TitreTextBox.Location = New System.Drawing.Point(68, 68)
        Me.TitreTextBox.Name = "TitreTextBox"
        Me.TitreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitreTextBox.TabIndex = 4
        '
        'ContenuTextBox
        '
        Me.ContenuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource1, "Contenu", True))
        Me.ContenuTextBox.Location = New System.Drawing.Point(68, 94)
        Me.ContenuTextBox.Name = "ContenuTextBox"
        Me.ContenuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContenuTextBox.TabIndex = 6
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConnaissancesBindingSource1, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(68, 120)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 8
        '
        'Form2
        '
        Me.ClientSize = New System.Drawing.Size(529, 530)
        Me.Controls.Add(Km_IdLabel)
        Me.Controls.Add(Me.Km_IdTextBox)
        Me.Controls.Add(TitreLabel)
        Me.Controls.Add(Me.TitreTextBox)
        Me.Controls.Add(ContenuLabel)
        Me.Controls.Add(Me.ContenuTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.ConnaissancesBindingSource1BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnaissancesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnaissancesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConnaissancesBindingSource1BindingNavigator.ResumeLayout(False)
        Me.ConnaissancesBindingSource1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents DataBaseDataSet As SauvegardeConnaissance.DataBaseDataSet
    Friend WithEvents ConnaissancesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ConnaissancesTableAdapter As SauvegardeConnaissance.DataBaseDataSetTableAdapters.ConnaissancesTableAdapter
    Friend WithEvents TableAdapterManager As SauvegardeConnaissance.DataBaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConnaissancesBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConnaissancesBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Km_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContenuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class

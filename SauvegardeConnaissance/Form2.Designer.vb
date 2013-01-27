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
        Dim Titre_ConnaissancesLabel As System.Windows.Forms.Label
        Dim Contenu_ConnaissancesLabel As System.Windows.Forms.Label
        Dim Date_ConnaissancesLabel As System.Windows.Forms.Label
        Dim Km_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FirstDatabaseDataSet = New SauvegardeConnaissance.FirstDatabaseDataSet()
        Me.ConnaissancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnaissancesTableAdapter = New SauvegardeConnaissance.FirstDatabaseDataSetTableAdapters.ConnaissancesTableAdapter()
        Me.TableAdapterManager = New SauvegardeConnaissance.FirstDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ConnaissancesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConnaissancesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Titre_ConnaissancesTextBox = New System.Windows.Forms.TextBox()
        Me.Contenu_ConnaissancesTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ConnaissancesDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Km_IDTextBox = New System.Windows.Forms.TextBox()
        Titre_ConnaissancesLabel = New System.Windows.Forms.Label()
        Contenu_ConnaissancesLabel = New System.Windows.Forms.Label()
        Date_ConnaissancesLabel = New System.Windows.Forms.Label()
        Km_IDLabel = New System.Windows.Forms.Label()
        CType(Me.FirstDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnaissancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnaissancesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConnaissancesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titre_ConnaissancesLabel
        '
        Titre_ConnaissancesLabel.AutoSize = True
        Titre_ConnaissancesLabel.Location = New System.Drawing.Point(12, 40)
        Titre_ConnaissancesLabel.Name = "Titre_ConnaissancesLabel"
        Titre_ConnaissancesLabel.Size = New System.Drawing.Size(106, 13)
        Titre_ConnaissancesLabel.TabIndex = 1
        Titre_ConnaissancesLabel.Text = "Titre Connaissances:"
        '
        'Contenu_ConnaissancesLabel
        '
        Contenu_ConnaissancesLabel.AutoSize = True
        Contenu_ConnaissancesLabel.Location = New System.Drawing.Point(12, 66)
        Contenu_ConnaissancesLabel.Name = "Contenu_ConnaissancesLabel"
        Contenu_ConnaissancesLabel.Size = New System.Drawing.Size(125, 13)
        Contenu_ConnaissancesLabel.TabIndex = 3
        Contenu_ConnaissancesLabel.Text = "Contenu Connaissances:"
        '
        'Date_ConnaissancesLabel
        '
        Date_ConnaissancesLabel.AutoSize = True
        Date_ConnaissancesLabel.Location = New System.Drawing.Point(12, 93)
        Date_ConnaissancesLabel.Name = "Date_ConnaissancesLabel"
        Date_ConnaissancesLabel.Size = New System.Drawing.Size(108, 13)
        Date_ConnaissancesLabel.TabIndex = 5
        Date_ConnaissancesLabel.Text = "Date Connaissances:"
        '
        'Km_IDLabel
        '
        Km_IDLabel.AutoSize = True
        Km_IDLabel.Location = New System.Drawing.Point(12, 118)
        Km_IDLabel.Name = "Km_IDLabel"
        Km_IDLabel.Size = New System.Drawing.Size(39, 13)
        Km_IDLabel.TabIndex = 7
        Km_IDLabel.Text = "Km ID:"
        '
        'FirstDatabaseDataSet
        '
        Me.FirstDatabaseDataSet.DataSetName = "FirstDatabaseDataSet"
        Me.FirstDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConnaissancesBindingSource
        '
        Me.ConnaissancesBindingSource.DataMember = "Connaissances"
        Me.ConnaissancesBindingSource.DataSource = Me.FirstDatabaseDataSet
        '
        'ConnaissancesTableAdapter
        '
        Me.ConnaissancesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConnaissancesTableAdapter = Me.ConnaissancesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SauvegardeConnaissance.FirstDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConnaissancesBindingNavigator
        '
        Me.ConnaissancesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConnaissancesBindingNavigator.BindingSource = Me.ConnaissancesBindingSource
        Me.ConnaissancesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConnaissancesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConnaissancesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConnaissancesBindingNavigatorSaveItem})
        Me.ConnaissancesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConnaissancesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConnaissancesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConnaissancesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConnaissancesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConnaissancesBindingNavigator.Name = "ConnaissancesBindingNavigator"
        Me.ConnaissancesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConnaissancesBindingNavigator.Size = New System.Drawing.Size(629, 25)
        Me.ConnaissancesBindingNavigator.TabIndex = 0
        Me.ConnaissancesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ConnaissancesBindingNavigatorSaveItem
        '
        Me.ConnaissancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnaissancesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConnaissancesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConnaissancesBindingNavigatorSaveItem.Name = "ConnaissancesBindingNavigatorSaveItem"
        Me.ConnaissancesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConnaissancesBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'Titre_ConnaissancesTextBox
        '
        Me.Titre_ConnaissancesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource, "Titre Connaissances", True))
        Me.Titre_ConnaissancesTextBox.Location = New System.Drawing.Point(143, 37)
        Me.Titre_ConnaissancesTextBox.Name = "Titre_ConnaissancesTextBox"
        Me.Titre_ConnaissancesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Titre_ConnaissancesTextBox.TabIndex = 2
        '
        'Contenu_ConnaissancesTextBox
        '
        Me.Contenu_ConnaissancesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource, "Contenu Connaissances", True))
        Me.Contenu_ConnaissancesTextBox.Location = New System.Drawing.Point(143, 63)
        Me.Contenu_ConnaissancesTextBox.Name = "Contenu_ConnaissancesTextBox"
        Me.Contenu_ConnaissancesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Contenu_ConnaissancesTextBox.TabIndex = 4
        '
        'Date_ConnaissancesDateTimePicker
        '
        Me.Date_ConnaissancesDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConnaissancesBindingSource, "Date Connaissances", True))
        Me.Date_ConnaissancesDateTimePicker.Location = New System.Drawing.Point(143, 89)
        Me.Date_ConnaissancesDateTimePicker.Name = "Date_ConnaissancesDateTimePicker"
        Me.Date_ConnaissancesDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_ConnaissancesDateTimePicker.TabIndex = 6
        '
        'Km_IDTextBox
        '
        Me.Km_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConnaissancesBindingSource, "Km ID", True))
        Me.Km_IDTextBox.Location = New System.Drawing.Point(143, 115)
        Me.Km_IDTextBox.Name = "Km_IDTextBox"
        Me.Km_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Km_IDTextBox.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 415)
        Me.Controls.Add(Titre_ConnaissancesLabel)
        Me.Controls.Add(Me.Titre_ConnaissancesTextBox)
        Me.Controls.Add(Contenu_ConnaissancesLabel)
        Me.Controls.Add(Me.Contenu_ConnaissancesTextBox)
        Me.Controls.Add(Date_ConnaissancesLabel)
        Me.Controls.Add(Me.Date_ConnaissancesDateTimePicker)
        Me.Controls.Add(Km_IDLabel)
        Me.Controls.Add(Me.Km_IDTextBox)
        Me.Controls.Add(Me.ConnaissancesBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.FirstDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnaissancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnaissancesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConnaissancesBindingNavigator.ResumeLayout(False)
        Me.ConnaissancesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstDatabaseDataSet As SauvegardeConnaissance.FirstDatabaseDataSet
    Friend WithEvents ConnaissancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConnaissancesTableAdapter As SauvegardeConnaissance.FirstDatabaseDataSetTableAdapters.ConnaissancesTableAdapter
    Friend WithEvents TableAdapterManager As SauvegardeConnaissance.FirstDatabaseDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Titre_ConnaissancesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contenu_ConnaissancesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ConnaissancesDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Km_IDTextBox As System.Windows.Forms.TextBox
End Class

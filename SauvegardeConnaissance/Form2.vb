Public Class Form2

    Private Sub ConnaissancesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConnaissancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FirstDatabaseDataSet)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ConnaissancesBindingSource.EndEdit()
        Me.ConnaissancesTableAdapter.Update(Me.FirstDatabaseDataSet.Connaissances)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'FirstDatabaseDataSet.Connaissances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ConnaissancesTableAdapter.Fill(Me.FirstDatabaseDataSet.Connaissances)
        'TODO: cette ligne de code charge les données dans la table 'FirstDatabaseDataSet.Connaissances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ConnaissancesTableAdapter.Fill(Me.FirstDatabaseDataSet.Connaissances)
        'TODO: cette ligne de code charge les données dans la table 'FirstDatabaseDataSet.Connaissances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ConnaissancesTableAdapter.Fill(Me.FirstDatabaseDataSet.Connaissances)
        'TODO: cette ligne de code charge les données dans la table 'FirstDatabaseDataSet.Connaissances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ConnaissancesTableAdapter.Fill(Me.FirstDatabaseDataSet.Connaissances)

    End Sub

    Private Sub ConnaissancesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConnaissancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FirstDatabaseDataSet)

    End Sub

    Private Sub ConnaissancesBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ConnaissancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FirstDatabaseDataSet)

    End Sub

    Private Sub ConnaissancesBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnaissancesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConnaissancesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FirstDatabaseDataSet)

    End Sub
End Class
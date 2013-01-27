Public Class Form2

    Private Sub ConnaissancesBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnaissancesBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConnaissancesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataBaseDataSet)

    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ConnaissancesBindingSource1.EndEdit()
        Me.ConnaissancesTableAdapter.Update(Me.DataBaseDataSet.Connaissances)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'DataBaseDataSet.Connaissances'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ConnaissancesTableAdapter.Fill(Me.DataBaseDataSet.Connaissances)

    End Sub

    Private Sub ConnaissancesBindingSource1_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ConnaissancesBindingSource1.AddingNew
        'Me.ConnaissancesBindingSource1.
        DateDateTimePicker.Value = "01/01/1999"
        'Dim t As Object
        't = Me.ConnaissancesBindingSource1.Current
        'ContenuTextBox.Text = "TOTO"


    End Sub







End Class
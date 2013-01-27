Public Class Form1

#Region "Déclaration des variables"

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListViewDonnee.Scrollable = True
        'TextBoxNouveauContenu.ScrollBars = True
    End Sub

#Region " Gestion en fonction de quel boutton est cliquer"

    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHome.Click
        ButtonHome.BackColor = Color.Yellow
        ButtonDonnes.BackColor = Color.LightGray
        ButtonNew.BackColor = Color.LightGray
        ButtonGestion.BackColor = Color.LightGray
        ButtonReglages.BackColor = Color.LightGray
        ListViewDonnee.Visible = False
        LabelDonneRecherche.Visible = False
        LabelHomeConnaissance.Visible = True
        PanelNouveau.Visible = False
    End Sub

    Private Sub ButtonDonnes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDonnes.Click
        ButtonHome.BackColor = Color.LightGray
        ButtonDonnes.BackColor = Color.Yellow
        ButtonNew.BackColor = Color.LightGray
        ButtonGestion.BackColor = Color.LightGray
        ButtonReglages.BackColor = Color.LightGray
        ListViewDonnee.Visible = True
        LabelDonneRecherche.Visible = True
        LabelHomeConnaissance.Visible = False
        PanelNouveau.Visible = False
    End Sub

    Private Sub ButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        ButtonHome.BackColor = Color.LightGray
        ButtonDonnes.BackColor = Color.LightGray
        ButtonNew.BackColor = Color.Yellow
        ButtonGestion.BackColor = Color.LightGray
        ButtonReglages.BackColor = Color.LightGray
        LabelHomeConnaissance.Visible = False
        ListViewDonnee.Visible = False
        LabelDonneRecherche.Visible = False
        PanelNouveau.Visible = True
    End Sub

    Private Sub ButtonGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGestion.Click
        ButtonHome.BackColor = Color.LightGray
        ButtonDonnes.BackColor = Color.LightGray
        ButtonNew.BackColor = Color.LightGray
        ButtonGestion.BackColor = Color.Yellow
        ButtonReglages.BackColor = Color.LightGray
        LabelHomeConnaissance.Visible = False
        ListViewDonnee.Visible = False
        LabelDonneRecherche.Visible = False
        PanelNouveau.Visible = False
    End Sub

    Private Sub ButtonReglages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReglages.Click
        ButtonHome.BackColor = Color.LightGray
        ButtonDonnes.BackColor = Color.LightGray
        ButtonNew.BackColor = Color.LightGray
        ButtonGestion.BackColor = Color.LightGray
        ButtonReglages.BackColor = Color.Yellow
        LabelHomeConnaissance.Visible = False
        ListViewDonnee.Visible = False
        LabelDonneRecherche.Visible = False
        PanelNouveau.Visible = False
    End Sub

#End Region

    Private Sub Creer_new_Item()

        'Récupère le titre
        Dim Titre As String
        'Titre = TextBoxNouveauTitre.Text
        Titre = ""
        'Remplace les espaces du titre par des _
        Dim correctString As String = Titre.Replace(" ", "_")
        'TextBox2Titre.Text = correctString

        'Configure le nouvelle item
        Dim item1 As New ListViewItem(Titre, 0)
        item1.BackColor = Color.LightGray
        item1.Text = Titre

        'Ajoute le nouvelle item
        ListViewDonnee.Items.AddRange(New ListViewItem() {item1})


    End Sub

    Private Sub Enregistrer()
        ' My.Computer.FileSystem.WriteAllText( _
        '"C:\Users\Arthur-Progr\Documents\LifeMusic\SauvegardeConnaissance\Sauvegarde" + "\" + TextBox2Titre.Text + ".txt", TextBoxNouveauContenu.Text, True)
    End Sub

    Private Sub ButtonNewEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Creer_new_Item()
        Enregistrer()
    End Sub
End Class

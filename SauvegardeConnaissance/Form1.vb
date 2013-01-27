Public Class Form1

#Region "Déclaration des variables"

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListViewDonnee.Scrollable = True
        'TextBoxNouveauContenu.ScrollBars = True
    End Sub

#Region " Gestion en fonction de quel boutton est cliquer"


    Private Sub Button1Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Home.Click
        Button1Home.BackColor = Color.Yellow
        Button1Donne.BackColor = Color.LightGray
        Button1Nouveau.BackColor = Color.LightGray
        Button1Reglage.BackColor = Color.LightGray
        PanelHome.Visible = True
        PanelDonne.Visible = False
        PanelNew.Visible = False
        PanelReglages.Visible = False
    End Sub

    Private Sub Button1Donne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Donne.Click
        Button1Home.BackColor = Color.LightGray
        Button1Donne.BackColor = Color.Yellow
        Button1Nouveau.BackColor = Color.LightGray
        Button1Reglage.BackColor = Color.LightGray
        PanelHome.Visible = False
        PanelDonne.Visible = True
        PanelNew.Visible = False
        PanelReglages.Visible = False
    End Sub

    Private Sub Button1Nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Nouveau.Click
        Button1Home.BackColor = Color.LightGray
        Button1Donne.BackColor = Color.LightGray
        Button1Nouveau.BackColor = Color.Yellow
        Button1Reglage.BackColor = Color.LightGray
        PanelHome.Visible = False
        PanelDonne.Visible = False
        PanelNew.Visible = True
        PanelReglages.Visible = False
    End Sub

    Private Sub Button1Reglage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1Reglage.Click
        Button1Home.BackColor = Color.LightGray
        Button1Donne.BackColor = Color.LightGray
        Button1Nouveau.BackColor = Color.LightGray
        Button1Reglage.BackColor = Color.Yellow
        PanelHome.Visible = False
        PanelDonne.Visible = False
        PanelNew.Visible = False
        PanelReglages.Visible = True
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

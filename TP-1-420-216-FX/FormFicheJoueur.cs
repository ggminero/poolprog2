using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_420_216_FX
{
    /// <summary>
    /// Classe du formulaire de la fiche des joueurs.
    /// </summary>
    public partial class FormFicheJoueur : Form
    {
        #region ATTRIBUTS
        /// <summary>
        /// Le Joueur sélectionné
        /// </summary>
        private Joueur _joueur;

        /// <summary>
        /// Le'Équipe sélectionné
        /// </summary>
        private Equipe _equipeDuJoueur;

        #endregion

        /// <summary>
        /// Constructeur acceptant le joue
        /// </summary>
        /// <param name="equipe"></param>
        /// <param name="joueur"></param>
        #region Constructeur
        public FormFicheJoueur(Equipe equipe, Joueur joueur)
        {
            _joueur = joueur;
            _equipeDuJoueur = equipe;

            InitializeComponent();
        }

        #endregion

        private void frmFicheJoueurLoad_Load(object sender, EventArgs e)
        {
            // converti le utin à chaîne de caractère pour la construction du url
            string PhotoId = _joueur.NoPhoto.ToString();
            string codeId = _joueur.CodeEquipe.Trim();
            //on construit le url avec string format avec l'id de la photo du joueur sélectionné et le code de l'équipe
            pictureBoxJoueur.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/headshots/nhl/players/full/{0}.png&w=350&h=254", PhotoId));
            pictureBoxEquipe.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/teamlogos/nhl/500/{0}.png&w=150&h=150&transparent=true", codeId));
            pictureBoxEquipe.SizeMode = PictureBoxSizeMode.StretchImage;

            var positonFormat = _joueur.Position.ToString();

            //affiche les statistiques des joueurs dans la fiche des joueurs
            labelAidesPoints.Text = _joueur.Stats.NbAides.ToString();
            labelButsPoints.Text = _joueur.Stats.NbButs.ToString();
            labelPlusMoinPoints.Text = _joueur.Stats.PlusOuMoins.ToString();
            labelPointsPool.Text = _joueur.Stats.NbPointsPool().ToString();
            labelNometPos.Text = _joueur.Nom + " (" + Utilitaire.FormaterChainePascalOuMixte(positonFormat) + ")";
            labelNomEquipEtVille.Text = _equipeDuJoueur.Nom + " (" + _equipeDuJoueur.Ville + ")";

        }
        private void frmFicheJoueurQuitter_Quitter(object sender, EventArgs e)
        {
            Close();
        }
    }
}

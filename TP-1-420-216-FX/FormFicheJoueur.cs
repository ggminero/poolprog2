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
    public partial class FormFicheJoueur : Form
    {
        #region ATTRIBUTS
        //private uint _joueurPhotoId;
        //private string _joueurCode;
        //private int _joueurButs;
        //private int _joueurAide;
        //private int _joueurPlusMoin;
        //private int _joueurPoints;

        /// <summary>
        /// Le Joueur selectionné
        /// </summary>
        private Joueur _joueur;

        /// <summary>
        /// Le'Équipe selectionné
        /// </summary>
        private Equipe _equipeDuJoueur;

        #endregion

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
            // converti le utin a chaine de charactere pour la cosntruction du uri
            string PhotoId = _joueur.NoPhoto.ToString();
            string codeId = _joueur.Code.Trim();
            //on construil le uri avec string format avec l'id de la photo du joueur selectionné et le code de l'équipe
            pictureBoxJoueur.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/headshots/nhl/players/full/{0}.png&w=350&h=254", PhotoId));
            pictureBoxEquipe.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/teamlogos/nhl/500/{0}.png&w=150&h=150&transparent=true", codeId));
            pictureBoxEquipe.SizeMode = PictureBoxSizeMode.StretchImage;

            var positonFormat = _joueur.Position.ToString();

            //affiche les stats des jouers dans la fiche des joueurs
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

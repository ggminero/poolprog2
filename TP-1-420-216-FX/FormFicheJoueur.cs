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
    /// Classe pour le formulaire affichant la fiche d'un joueur
    /// </summary>
    public partial class FormFicheJoueur : Form
    {
        /// <summary>
        /// Attributs de la classe
        /// </summary>
        private uint _joueurPhotoId;
        private string _joueurCode;
        private int _joueurButs;
        private int _joueurAide;
        private int _joueurPlusMoin;
        private int _joueurPoints;

        public FormFicheJoueur(uint joueurPhotoId, string joueurCode, int joueurButs, int joueurAide,
            int joueurPlusMoin, int joueurPoints)
        {
            this._joueurPhotoId = joueurPhotoId;
            this._joueurCode = joueurCode;
            this._joueurButs = joueurButs;
            this._joueurAide = joueurAide;
            this._joueurPlusMoin = joueurPlusMoin;
            this._joueurPoints = joueurPoints;


            InitializeComponent();
        }

        private void frmFicheJoueurLoad_Load(object sender, EventArgs e)
        {
            Console.WriteLine("loading?");
            // converti le utin a chaine de charactere pour la cosntruction du uri
            string photoId = this._joueurPhotoId.ToString();
            string codeId = this._joueurCode.Trim();
            //on construil le uri avec string format avec l'id de la photo du joueur selectionné et le code de l'équipe
            this.pictureBoxJoueur.Load(
                String.Format(@"http://a.espncdn.com/combiner/i?img=/i/headshots/nhl/players/full/{0}.png&w=350&h=254",
                    photoId));
            this.pictureBoxEquipe.Load(
                String.Format(
                    @"http://a.espncdn.com/combiner/i?img=/i/teamlogos/nhl/500/{0}.png&w=150&h=150&transparent=true",
                    codeId));

            //affiche les stats des jouers dans la fiche des joueurs
            this.labelAidesPoints.Text = this._joueurAide.ToString();
            this.labelButsPoints.Text = this._joueurButs.ToString();
            this.labelPlusMoinPoints.Text = this._joueurPlusMoin.ToString();
            this.labelPointsPool.Text = this._joueurPoints.ToString();

        }

    }
}

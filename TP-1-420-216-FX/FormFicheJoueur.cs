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

        private uint _joueurPhotoId;
        private string _joueurCode;
        private int _joueurButs;
        private int _joueurAide;
        private int _joueurPlusMoin;
        private int _joueurPoints;

        public FormFicheJoueur(uint joueurPhotoId, string joueurCode, int joueurButs, int joueurAide, 
            int joueurPlusMoin, int joueurPoints)
        {   
            _joueurPhotoId = joueurPhotoId;
            _joueurCode = joueurCode;
            _joueurButs = joueurButs;
            _joueurAide = joueurAide;
            _joueurPlusMoin = joueurPlusMoin;
            _joueurPoints = joueurPoints;
            

            InitializeComponent();
        }

        private void frmFicheJoueurLoad_Load(object sender, EventArgs e)
        {
            Console.WriteLine("loading?");
            // converti le utin a chaine de charactere pour la cosntruction du uri
            string PhotoId = _joueurPhotoId.ToString();
            string codeId = _joueurCode.Trim();
            //on construil le uri avec string format avec l'id de la photo du joueur selectionné et le code de l'équipe
            pictureBoxJoueur.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/headshots/nhl/players/full/{0}.png&w=350&h=254", PhotoId));
            pictureBoxEquipe.Load(String.Format(@"http://a.espncdn.com/combiner/i?img=/i/teamlogos/nhl/500/{0}.png&w=150&h=150&transparent=true", codeId));

            //affiche les stats des jouers dans la fiche des joueurs
            labelAidesPoints.Text = _joueurAide.ToString();
            labelButsPoints.Text = _joueurButs.ToString();
            labelPlusMoinPoints.Text = _joueurPlusMoin.ToString();
            labelPointsPool.Text = _joueurPoints.ToString();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    /// <summary>
    /// Les fichiers texte.
    /// </summary>
    static class Constants
    {
        public const string FichierParticipants = "participants.txt";
        public const string FichierJoueursStats = "joueurs_stats.txt";
        public const string FichierEquipes   = "equipes.txt";

    }
    /// <summary>
    /// Classe représentant le pool de hockey de la LNH.
    /// </summary>
    public class PoolHockeyLnh
    {

        #region ATTRIBUTS

        /// <summary>
        /// Les Joueurs chargés du fichier texte
        /// </summary>
        private Joueur[] _lesJoueurs;

        /// <summary>
        /// Les Participants chargés du fichier texte
        /// </summary>
        private Participant[] _lesParticipants;

        /// <summary>
        /// Les Équipes chargés du fichier texte
        /// </summary>
        private Equipe[] _lesEquipes;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Les Joueurs
        /// </summary>
        public Joueur[] LesJoueurs
        {
            get { return _lesJoueurs; }
            private set { _lesJoueurs = value; }
        }

        /// <summary>
        /// Les équipes
        /// </summary>
        public Equipe[] LesEquipes
        {
            get { return _lesEquipes; }
            private set { _lesEquipes = value; }
        }

        /// <summary>
        /// Code de l'équipe du Joueur.
        /// </summary>
        public Participant[] LesParticipants
        {
            get { return _lesParticipants; }
            private set { _lesParticipants = value; }
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur sans paramètre qui charge les données nécessaires pour le pool de hockey de la LNH.
        /// </summary>
        public PoolHockeyLnh()
        {
            this.LesEquipes = Utilitaire.ChargerEquipes(Constants.FichierEquipes);
            this.LesParticipants = Utilitaire.ChargerParticipants(Constants.FichierParticipants); ;
            this.LesJoueurs = Utilitaire.ChargerJoueurs(Constants.FichierJoueursStats);
        }

        #endregion
           
        #region METHODES
        /// <summary>
        /// Recherche l'équipe du joueur
        /// </summary>
        /// <param name="codeEquipe"></param>
        public Equipe RechercherEquipe(String codeEquipe)
        {
            //variable locale pour compter le nombre d'équipes
            int nbrEquipes = this.LesEquipes.Count();
            Equipe equipe;
            //pour chaque équipe, on valide que le code soit 
            //équivalent a celle entré 'codeEquipe'
            //retourne null si l'équipe n'est pas dans la liste
            for (int i=0; i<nbrEquipes; i++)
            {
                Equipe uneEquipe = new Equipe(this.LesEquipes[i].Nom, this.LesEquipes[i].Code, this.LesEquipes[i].Ville);

                if (codeEquipe.Equals(this.LesEquipes[i].Code))
                {
                    return _lesEquipes[i];
                }
            }

            return null;
        }
        /// <summary>
        /// Recherche l'indice du joueur
        /// </summary>
        /// <param name="JoueurRech"></param>
        public int RechercherIndiceJoueur(Joueur JoueurRech)
        {
            
            //Console.WriteLine(Array.IndexOf(_lesJoueurs, JoueurRech));
            if(_lesJoueurs.Contains(JoueurRech))
            {
                return Array.IndexOf(this.LesJoueurs, JoueurRech);
            }
            return -1;

        }
        /// <summary>
        /// Recherche les Points au pool du participant
        /// </summary>
        /// <param name="participant"></param>
        public short PointsAuPool(Participant participant)
        {
            //variables pour additionner les points au pool des joueurs du participant
            short pointsAuPoolDesJoueurs = 0;

            //Vecteur des joueurs du participant sélectionnée
            var joueursSelect = Encoding.UTF8.GetString(participant.VectNoJoueurPool).Split(',');
            Console.WriteLine(joueursSelect.Length);

            //pour chaque joueur du participant, on additionne les points au pool des statistiques à la variable 
            //pointsAuPoolDesJoueurs (avec validation de la longueur de la liste et un élément vide)
            if(joueursSelect.Length != 0 && joueursSelect[0] != "")
            { 
                foreach (var joueur in joueursSelect)
                {
                    pointsAuPoolDesJoueurs += this.LesJoueurs[Int32.Parse(joueur) - 1].Stats.NbPointsPool();
                }
                return pointsAuPoolDesJoueurs;
            }
            else
            {
                return 0;
            }
            
        }


        #endregion

  
    }
}

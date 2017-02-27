using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    static class Constants
    {
        public const string FichierParticipants = "participants.txt";
        public const string FichierJoueursStats = "joueurs_stats.txt";
        public const string FichierEquipes   = "equipes.txt";

    }

    class PoolHockeyLnh
    {

        #region ATTRIBUTS

        /// <summary>
        /// Les Joueurs chargés du fichier txt
        /// </summary>
        private Joueur[] _lesJoueurs;

        /// <summary>
        /// Les Participants chargés du fichier txt
        /// </summary>
        private Participant[] _lesParticipants;

        /// <summary>
        /// Les Équipes chargés du fichier txt
        /// </summary>
        private Equipe[] _lesEquipes;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Les Joueurs
        /// </summary>
        public Joueur[] lesJoueurs
        {
            get { return _lesJoueurs; }
            private set { _lesJoueurs = value; }
        }

        /// <summary>
        /// Les Equipes
        /// </summary>
        public Equipe[] lesEquipes
        {
            get { return _lesEquipes; }
            private set { _lesEquipes = value; }
        }

        /// <summary>
        /// Code de l'équipe du Joueur.
        /// </summary>
        public Participant[] lesParticipants
        {
            get { return _lesParticipants; }
            private set { _lesParticipants = value; }
        }

        #endregion

        #region METHODES
        /// <summary>
        /// Recherche l'equipe du joueur
        /// </summary>
        /// <param name="codeEquipe"></param>
        public Equipe RechercherEquipe(String codeEquipe)
        {
            //variable local epour compter le nombre d'equipes
            int nbrEquipes = _lesEquipes.Count();
            
            //pour chaque equipe, on valide que le code soit 
            //équivalent a celle entré 'codeEquipe'
            //retourne null si l'equipe n'est ps dans la liste
            for (int i=0; i<nbrEquipes; i++)
            {
                if(codeEquipe.Equals(_lesEquipes[i].Code))
                {
                    return _lesEquipes[i];
                }
                else
                {
                    return null;
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
                return Array.IndexOf(_lesJoueurs, JoueurRech);
            }
            return -1;

        }
        /// <summary>
        /// Recherche les Points au pool du participant
        /// </summary>
        /// <param name="participant"></param>
        public short PointsAuPool(Participant participant)
        {
            //varialbes pour additioner les points au pool des joueurs du participant
            short pointsAuPoolDesJoueurs = 0;

            //Vecteur des joueurs du participant selectionnée
            var joueursSelect = Encoding.UTF8.GetString(participant.VectNoJoueurPool).Split(',');
            Console.WriteLine(joueursSelect.Length);

            //pour chaque joueur du participant on additionne les points au pool des stats a la variable 
            //pointsAuPoolDesJoueurs (avec validation de la longueur de la liste et un élément vide)
            if(joueursSelect.Length != 0 && joueursSelect[0] != "")
            { 
                foreach (var joueur in joueursSelect)
                {
                    pointsAuPoolDesJoueurs += _lesJoueurs[Int32.Parse(joueur) - 1].Stats.NbPointsPool();
                }
                return pointsAuPoolDesJoueurs;
            }
            else
            {
                return 0;
            }
            
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur sans paramètre qui charge les données nécessaires pour le pool de hockey de la LNH.
        /// </summary>
        /// </summary>
        public PoolHockeyLnh()
        {
            _lesEquipes = Utilitaire.ChargerEquipes(Constants.FichierEquipes);
            _lesParticipants = Utilitaire.ChargerParticipants(Constants.FichierParticipants); ;
            _lesJoueurs = Utilitaire.ChargerJoueur(Constants.FichierJoueursStats);
        }

        #endregion
    }
}

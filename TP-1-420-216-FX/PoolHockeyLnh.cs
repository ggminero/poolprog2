using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    class PoolHockeyLnh
    {
        /// <summary>
        /// Classe représentant le pool de hockey de la LNH
        /// </summary>
        
        #region CONSTANTES PUBLIQUES

        /// <summary>
        /// Nom du fichier texte CSV contenant les informations sur les participants
        /// </summary>
        public const string FichierParticipants = "participants.txt";

        /// <summary>
        /// Nom du fichier texte CSV contenant les informations sur les joueurs et leurs statistiques
        /// </summary>
        public const string FichierJoueursStats = "joueurs_stats.txt";

        /// <summary>
        /// Nom du fichier texte CSV contenant les informations sur les équipes
        /// </summary>
        public const string FichierEquipes = "equipes.txt";

        #endregion

        #region ATTRIBUTS

        /// <summary>
        /// Les participants au pool de hockey de la LNH.
        /// </summary>
        private Participant[] _lesParticipants = null;

        /// <summary>
        /// Les joueurs de la LNH disponibles pour le pool de hockey.
        /// </summary>
        private Joueur[] _lesJoueurs = null;

        /// <summary>
        /// Toutes les équipes de la LNH.
        /// </summary>
        private Equipe[] _lesEquipes = null;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Les participants au pool de hockey de la LNH.
        /// </summary>
        public Participant[] LesParticipants
        {
            get { return this._lesParticipants; }
            private set { this._lesParticipants = value; }
        }

        /// <summary>
        /// Les joueurs de la LNH disponibles pour le pool de hockey.
        /// </summary>
        public Joueur[] LesJoueurs
        {
            get { return this._lesJoueurs; }
            private set { this._lesJoueurs = value; }
        }

        /// <summary>
        /// Toutes les équipes de la LNH.
        /// </summary>
        public Equipe[] LesEquipes
        {
            get { return this._lesEquipes; }
            private set { this._lesEquipes = value; }
        }

        #endregion

        #region MÉTHODES

        /// <summary>
        /// Recherche et retourne l'équipe correspondant au code; 
        /// retourne null si l’équipe n’est pas trouvée.
        /// </summary>
        public Equipe RechercherEquipe(string codeEquipe)
        {
            for (int i = 0; i < this.LesEquipes.Length; i++)
            {
                switch (codeEquipe)
                {
                    case "":
                        this.LesEquipes[i].this.Nom = "pit";
                        break;


                }
            }
        }
    }
}

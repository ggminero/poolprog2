using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    /// <summary>
    /// Classe représentant le pool de hockey de la LNH
    /// </summary>
    public class PoolHockeyLnh
    {
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
            // Création du vecteur des équipes
            this.LesEquipes = new Equipe[PoolHockeyLnh.FichierEquipes.Length];
            
            // Variables qui serviront à créer un objet Equipe
            string nom = "";
            string ville = "";
            
            // Création d'un objet Equipe
            Equipe uneEquipe = new Equipe(nom, ville, codeEquipe);

            for (int i = 0; i < this.LesEquipes.Length; i++)
            {
                // Affiche le nom et la ville de l'équipe selon le code approprié
                switch (codeEquipe)
                {
                    case "pit":
                        nom = "Penguin";
                        ville = "Pittsburgh";
                        break;
                    case "phi":
                        nom = "Flyers";
                        ville = "Philadelphie";
                        break;
                    case "nyr":
                        nom = "Rangers";
                        ville = "New York";
                        break;
                    case "nyi":
                        nom = "Islanders";
                        ville = "New York";
                        break;
                    case "nj":
                        nom = "Devils";
                        ville = "New Jersey";
                        break;
                    case "stl":
                        nom = "Blues";
                        ville = "St. Louis";
                        break;
                    case "nsh":
                        nom = "Predators";
                        ville = "Nashville";
                        break;
                    case "det":
                        nom = "Red Wings";
                        ville = "Detroit";
                        break;
                    case "cbj":
                        nom = "Blue Jackets";
                        ville = "Colombus";
                        break;
                    case "chi":
                        nom = "Blackhawks";
                        ville = "Chicago";
                        break;
                    case "tor":
                        nom = "Maple Leafs";
                        ville = "Toronto";
                        break;
                    case "ott":
                        nom = "Sénateurs";
                        ville = "Ottawa";
                        break;
                    case "mtl":
                        nom = "Canadiens";
                        ville = "Montréal";
                        break;
                    case "buf":
                        nom = "Sabres";
                        ville = "Buffalo";
                        break;
                    case "bos":
                        nom = "Bruins";
                        ville = "Boston";
                        break;
                    case "van":
                        nom = "Canucks";
                        ville = "Vancouver";
                        break;
                    case "min":
                        nom = "Wild";
                        ville = "Minnesota";
                        break;
                    case "edm":
                        nom = "Oilers";
                        ville = "Edmonton";
                        break;
                    case "col":
                        nom = "Avalanche";
                        ville = "Colorado";
                        break;
                    case "cgy":
                        nom = "Flames";
                        ville = "Calgary";
                        break;
                    case "wsh":
                        nom = "Capitals";
                        ville = "Washington";
                        break;
                    case "tb":
                        nom = "Lightning";
                        ville = "Tampa Bay";
                        break;
                    case "fla":
                        nom = "Panthers";
                        ville = "Floride";
                        break;
                    case "car":
                        nom = "Hurricanes";
                        ville = "Caroline";
                        break;
                    case "sj":
                        nom = "Sharks";
                        ville = "San Jose";
                        break;
                    case "ri":
                        nom = "Coyotes";
                        ville = "Arizona";
                        break;
                    case "la":
                        nom = "Kings";
                        ville = "Los Angeles";
                        break;
                    case "dal":
                        nom = "Stars";
                        ville = "Dallas";
                        break;
                    case "ana":
                        nom = "Ducks";
                        ville = "Anaheim";
                        break;
                    case "wpg":
                        nom = "Jets";
                        ville = "Winnipeg";
                        break;
                    default :
                        return null;                    
                }               
                uneEquipe = new Equipe(codeEquipe, nom, ville);
                
            }
            // Retourne le nom et la ville de l'équipe
            return uneEquipe;
           
        }

        /// <summary>
        /// Recherche un joueur dans le vecteur de joueurs du pool et retourne son indice
        /// </summary>
        public int RechercheIndiceJoueur(Joueur joueurRech)
        {
            int indiceJoueur = 0;
           
            // Création du vecteur de joueurs
            this.LesJoueurs = new Joueur[PoolHockeyLnh.FichierJoueursStats.Length];

            // Boucle pour parcourir le vecteur des joueurs
            for (int i = 0; i < this.LesJoueurs.Length; i++)
            {
                if (this.LesJoueurs[i] == joueurRech)
                {
                    indiceJoueur = i - 1;
                }
                else
                {
                    indiceJoueur = indiceJoueur - 1;
                }
            }
            
            // Retourne l'indice du joueur
            return indiceJoueur;
        }



        /// <summary>
        /// Permet d'obtenir le nombre total de points au pool d'un participant (pour tous ses joueurs).
        /// </summary>
        public short PointsAuPool(Participant participant)
        {
            short nbPointsParticipants = 0;
            byte nbButs = 0;
            byte nbAides = 0;
            short plusOuMoins = 0;
            short nbJoueurs = 0;
            
            // Appel de la classe StatsJoueurs
            StatsJoueur nbPoints = new StatsJoueur(nbButs, nbAides, plusOuMoins);
            
            // Boucle pour avoir accès à tous les participants
            for (int i = 0; i < this.LesParticipants.Length; i++)
            {
                nbPointsParticipants = (short) ((short)nbPoints.NbPointsPool() * nbJoueurs);
            }
            
            // Retourne le nombre de points pour tout les joueurs d'un participant
            return nbPointsParticipants;
        }
        #endregion
    }
}

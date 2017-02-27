using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    public class Joueur
    {
        #region ATTRIBUTS

        /// <summary>
        /// Code de l'équipe du Joueur.
        /// </summary>
        private String _code;

        /// <summary>
        /// Nom du Joueur.
        /// </summary>
        private String _nom;

        /// <summary>
        /// Position du joueur.
        /// </summary>
        private PositionHockey _position;

        /// <summary>
        /// Numéro permettant d'obtenir la photo du joueur.
        /// </summary>
        private uint _noPhoto;

        /// <summary>
        /// Les statistiques du joueur.
        /// </summary>
        private StatsJoueur _stats;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Code de l'équipe du Joueur.
        /// </summary>
        public String Code
        {
            get { return this._code; }
            private set { this._code = value; }
        }

        /// <summary>
        /// Nom du Joueur.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        /// <summary>
        /// Position du joueur.
        /// </summary>
        public PositionHockey Position
        {
            get { return _position; }
            private set { _position = value; }
        }

        /// <summary>
        /// Numéro permettant d'obtenir la photo du joueur.
        /// </summary>
        public uint NoPhoto
        {
            get { return _noPhoto; }
            private set { _noPhoto = value; }
        }

        /// <summary>
        /// Les statistiques du joueur.
        /// </summary>
        public StatsJoueur Stats
        {
            get { return _stats; }
            private set { _stats = value; }
        }

        #endregion

        #region ToString
        public override string ToString()
        {

            var positonFormat = Position.ToString();

            string joueur = String.Format("{0,-18} {1,-15} ({2,-4}) b ={3,3}, a ={4,3}, (+/-) ={5,3} Points = {6,3} ",
                Nom, Utilitaire.FormaterChainePascalOuMixte(positonFormat), Code, Stats.NbButs, Stats.NbAides, 
                Stats.PlusOuMoins, Stats.NbPointsPool());

            return joueur;
        }
        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur paramétré qui accepte les cinq attributs d'un joueur. 
        /// </summary>
        /// <param name="code">Code de l'équipe du Joueur.</param>
        /// <param name="nom">Nom du Joueur.</param>
        /// <param name="position">Position du joueur.</param>
        /// <param name="noPhoto">Numéro permettant d'obtenir la photo du joueur.</param>
        /// <param name="stats">Les statistiques du joueur.</param>
        /// </summary>
        public Joueur(String nom, String code, PositionHockey position, uint noPhoto, StatsJoueur stats)
        {
            _code = code;
            _nom = nom;
            _position = position;
            _noPhoto = noPhoto;
            _stats = stats;
        }

        #endregion
    }
}

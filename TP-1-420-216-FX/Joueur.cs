using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    class Joueur
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
            get { return this._nom; }
            private set { this._nom = value; }
        }

        /// <summary>
        /// Position du joueur.
        /// </summary>
        public PositionHockey Position
        {
            get { return this._position; }
            private set { this._position = value; }
        }

        /// <summary>
        /// Numéro permettant d'obtenir la photo du joueur.
        /// </summary>
        public uint NoPhoto
        {
            get { return this._noPhoto; }
            private set { this._noPhoto = value; }
        }

        /// <summary>
        /// Les statistiques du joueur.
        /// </summary>
        public StatsJoueur Stats
        {
            get { return this._stats; }
            private set { this._stats = value; }
        }

        #endregion

        #region ToString
        public override string ToString()
        {
            int points = Stats.NbButs + Stats.NbAides + Stats.PlusOuMoins / 2;
            string joueur = String.Format("{0,-18} {1,-15} ({2,-4}) b ={3,3}, a ={4,3}, (+/-) ={5,3} Points = {6,3} ",
                Nom, Utilitaire.FormaterChainePascalOuMixte(positionFormat), Code, Stats.NbButs, Stats.NbAides, Stats.PlusOuMoins, points);

            return joueur;
        }
        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'une équipe.
        /// </summary>
        /// <param name="code">Code de l'équipe du Joueur.</param>
        /// <param name="nom">Nom du Joueur.</param>
        /// <param name="position">Position du joueur.</param>
        /// <param name="noPhoto">Numéro permettant d'obtenir la photo du joueur.</param>
        /// <param name="stats">Les statistiques du joueur.</param>
        /// </summary>
        public Joueur(String nom, String code, PositionHockey position, uint noPhoto, StatsJoueur stats)
        {
            this.Code = code;
            this.Nom = nom;
            this.Position = position;
            this.NoPhoto = noPhoto;
            this.Stats = stats;
        }

        #endregion
    }
}

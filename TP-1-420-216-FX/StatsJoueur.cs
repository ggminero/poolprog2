#region MÉTADONNÉES

// Nom du fichier : StatsJoueur.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2016-02-10
// Date de modification : 2016-02-10

#endregion

#region USING

using System;

#endregion

namespace TP_1_420_216_FX
{
    /// <summary>
    /// Classe représentant les statistiques d'un joueur de hockey.
    /// </summary>
    public class StatsJoueur
    {
        #region ATTRIBUTS

        /// <summary>
        /// Nombre de buts du joueur.
        /// </summary>
        private byte _nbButs;

        /// <summary>
        /// Nombre d'aides du joueur (aussi appelé passes décisives ou assistances).
        /// </summary>
        private byte _nbAides;

        /// <summary>
        /// Plus ou moins du joueur.
        /// </summary>
        private short _plusOuMoins;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Nombre de buts du joueur.
        /// </summary>
        public byte NbButs
        {
            get { return _nbButs; }
            private set { _nbButs = value; }
        }

        /// <summary>
        /// Nombre d'aides du joueur (aussi appelé passes décisives ou assistances).
        /// </summary>
        public byte NbAides
        {
            get { return _nbAides; }
            private set { _nbAides = value; }
        }

        /// <summary>
        /// Plus ou moins du joueur.
        /// </summary>
        public short PlusOuMoins
        {
            get { return _plusOuMoins; }
            private set { _plusOuMoins = value; }
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs pour les statistiques d'un joueur.
        /// </summary>
        /// <param name="nbButs">Nombre de buts du joueur.</param>
        /// <param name="nbAides">Nombre d'aides du joueur.</param>
        /// <param name="plusOuMoins">Plus ou moins du joueur.</param>
        public StatsJoueur(byte nbButs, byte nbAides, short plusOuMoins)
        {
            NbButs = nbButs;
            NbAides = nbAides;
            PlusOuMoins = plusOuMoins;
        }

        #endregion

        #region MÉTHODES

        /// <summary>
        /// Permet d'obtenir la valeur en points pour le pool de hockey des statistiques du joueur.
        /// </summary>
        /// <returns>Nombre de points pour le pool de hockey.</returns>
        public short NbPointsPool()
        {
            int totPoints = (NbAides + NbButs + (PlusOuMoins / 2));
            short shortPoints = Convert.ToInt16(totPoints);
            return shortPoints;
        }

        #endregion
    }
}
#region MÉTADONNÉES

// Nom du fichier : Equipe.cs
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
    /// Classe représentant une équipe de hockey.
    /// </summary>
    public class Equipe
    {
        #region ATTRIBUTS

        /// <summary>
        /// Code de l'équipe.
        /// </summary>
        private String _code;

        /// <summary>
        /// Nom de l'équipe.
        /// </summary>
        private String _nom;

        /// <summary>
        /// Ville où est située l'équipe.
        /// </summary>
        private String _ville;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Code de l'équipe.
        /// </summary>
        public String Code
        {
            get { return this._code; }
            private set { this._code = value; }
        }

        /// <summary>
        /// Nom de l'équipe.
        /// </summary>
        public String Nom
        {
            get { return this._nom; }
            private set { this._nom = value; }
        }

        /// <summary>
        /// Ville où est située l'équipe.
        /// </summary>
        public String Ville
        {
            get { return this._ville; }
            private set { this._ville = value; }
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'une équipe.
        /// </summary>
        /// <param name="code">Code de l'équipe.</param>
        /// <param name="nom">Nom de l'équipe.</param>
        /// <param name="ville">Ville où est située l'équipe.</param>
        public Equipe(String code, String nom, String ville)
        {
            this.Code = code;
            this.Nom = nom;
            this.Ville = ville;
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    class Participant
    {
        #region ATTRIBUTS

        /// <summary>
        /// Vecteur des numéros de joueurs choisis par le participant.  
        /// Le numéro d'un joueur moins un correspond à l'indice du joueur 
        /// dans le vecteur de tous les joueurs.
        /// </summary>
        private byte[] _vectNoJoueurPool;

        /// <summary>
        /// Nom du Participant.
        /// </summary>
        private String _nom;


        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Vecteur des numéros de joueurs choisis par le participant.  
        /// Le numéro d'un joueur moins un correspond à l'indice du joueur 
        /// dans le vecteur de tous les joueurs.
        /// </summary>
        public byte[]  VectNoJoueurPool
        {
            get { return _vectNoJoueurPool; }
            private set { _vectNoJoueurPool = value; }
        }

        /// <summary>
        /// Nom du Participant.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }
        
        #endregion

        #region ToString
        public override string ToString()
        {
            string participant = Nom;

            return participant;
        }
        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur paramétré qui accepte les trois attributs d'une équipe.
        /// </summary>
        /// <param name="code">Code de l'équipe du Joueur.</param>
        /// <param name="nom">Nom du Joueur.</param>
        /// </summary>
        public Participant(String nom, byte[] vectNoJoueurPool)
        {
            _vectNoJoueurPool = vectNoJoueurPool;
            _nom = nom;
        }

        #endregion
    }
}

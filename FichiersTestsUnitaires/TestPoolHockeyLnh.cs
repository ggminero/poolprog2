#region MÉTADONNÉES

// Nom du fichier : TestPoolHockeyLnh.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2016-02-10
// Date de modification : 2016-02-10

#endregion

#region USING

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1_Solution;

#endregion

namespace TestsUnitaires
{
    /// <summary>
    /// Tests unitaires pour la classe "PoolHockeyLNH".
    /// </summary>
    [TestClass]
    public class TestPoolHockeyLnh
    {
        #region MÉTHODES

        /// <summary>
        /// Tests unitaires pour le "Constructeur".
        /// </summary>
        [TestMethod]
        public void TestConstructeurPoolHockeyLnh()
        {
            PoolHockeyLnh pool = new PoolHockeyLnh();

            Assert.AreEqual(30, pool.LesEquipes.Length);
            Assert.AreEqual(40, pool.LesJoueurs.Length);
            Assert.AreEqual(14, pool.LesParticipants.Length);
        }

        /// <summary>
        /// Tests unitaires pour la méthode "RechercherEquipe".
        /// </summary>
        [TestMethod]
        public void TestRechercherEquipe()
        {
            PoolHockeyLnh pool = new PoolHockeyLnh();

            Equipe equipe = pool.LesEquipes[0];
            Assert.AreEqual(equipe, pool.RechercherEquipe(equipe.Code));

            equipe = pool.LesEquipes[pool.LesEquipes.Length - 1];
            Assert.AreEqual(equipe, pool.RechercherEquipe(equipe.Code));

            equipe = new Equipe("qc", "Nordiques", "Québec");
            Assert.IsNull(pool.RechercherEquipe(equipe.Code));
        }

        /// <summary>
        /// Tests unitaires pour la méthode "RechercherIndiceJoueur".
        /// </summary>
        [TestMethod]
        public void TestRechercherIndiceJoueur()
        {
            PoolHockeyLnh pool = new PoolHockeyLnh();

            Joueur joueur = pool.LesJoueurs[0];
            Assert.AreEqual(0, pool.RechercherIndiceJoueur(joueur));

            joueur = pool.LesJoueurs[pool.LesJoueurs.Length - 1];
            Assert.AreEqual((pool.LesJoueurs.Length - 1), pool.RechercherIndiceJoueur(joueur));

            joueur = new Joueur("Peter Stastny", "qc", PositionHockey.Centre, 9999, new StatsJoueur(0, 0, 0));
            Assert.AreEqual(-1, pool.RechercherIndiceJoueur(joueur));
        }

        /// <summary>
        /// Tests unitaires pour la méthode "PointsAuPool".
        /// </summary>
        [TestMethod]
        public void TestPointsAuPool()
        {
            PoolHockeyLnh pool = new PoolHockeyLnh();

            Participant part = pool.LesParticipants[0];
            Assert.AreEqual(522, pool.PointsAuPool(part));

            part = pool.LesParticipants[8];
            Assert.AreEqual(0, pool.PointsAuPool(part));

            part = pool.LesParticipants[pool.LesParticipants.Length - 1];
            Assert.AreEqual(307, pool.PointsAuPool(part));
        }
        #endregion
    }
}
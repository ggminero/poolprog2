#region MÉTADONNÉES

// Nom du fichier : TestStatsJoueur.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2016-02-09
// Date de modification : 2016-02-10

#endregion

#region USING

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1_Solution;

#endregion

namespace TestsUnitaires
{
    /// <summary>
    /// Tests unitaires pour la classe "StatsJoueur".
    /// </summary>
    [TestClass]
    public class TestStatsJoueur
    {
        #region MÉTHODES

        /// <summary>
        /// Tests unitaires pour la méthode "NbPointsPool".
        /// </summary>
        [TestMethod]
        public void TestNbPointsPool()
        {
            StatsJoueur sj = new StatsJoueur(23, 31, 8);
            Assert.AreEqual(58, sj.NbPointsPool());
            sj = new StatsJoueur(0, 2, 7);
            Assert.AreEqual(5, sj.NbPointsPool());
            sj = new StatsJoueur(3, 0, -3);
            Assert.AreEqual(2, sj.NbPointsPool());
            sj = new StatsJoueur(0, 0, -6);
            Assert.AreEqual(-3, sj.NbPointsPool());
        }

        #endregion
    }
}
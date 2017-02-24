#region MÉTADONNÉES

// Nom du fichier : TestJoueur.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2016-02-10
// Date de modification : 2016-02-10

#endregion

#region USING

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1_Solution;

#endregion

namespace TestsUnitaires
{
    /// <summary>
    /// Tests unitaires pour la classe "Joueur".
    /// </summary>
    [TestClass]
    public class TestJoueur
    {
        #region MÉTHODES

        /// <summary>
        /// Tests unitaires pour le "Constructeur".
        /// </summary>
        [TestMethod]
        public void TestConstructeurJoueur()
        {
            StatsJoueur sj = new StatsJoueur(50, 66, 35);
            Joueur joueur = new Joueur("Stéphane Lapointe", "mtl", PositionHockey.Centre, 12345, sj);
            Assert.AreEqual("Stéphane Lapointe", joueur.Nom);
            Assert.AreEqual("mtl", joueur.CodeEquipe);
            Assert.AreEqual(PositionHockey.Centre, joueur.Position);
            Assert.AreEqual(12345u, joueur.NoPhoto);
            Assert.AreEqual(50, joueur.Stats.NbButs);
            Assert.AreEqual(66, joueur.Stats.NbAides);
            Assert.AreEqual(35, joueur.Stats.PlusOuMoins);
            Assert.AreEqual(133, joueur.Stats.NbPointsPool());
        }

        /// <summary>
        /// Tests unitaires pour la méthode "ToString".
        /// </summary>
        [TestMethod]
        public void TestToStringJoueur()
        {
            StatsJoueur sj = new StatsJoueur(44, 31, 22);
            Joueur joueur = new Joueur("Patrick Kane", "chi", PositionHockey.AilierDroit, 3735, sj);
            String chaineToString = joueur.ToString().ToLower();
            Assert.IsTrue(chaineToString.Contains("patrick kane"));
            Assert.IsTrue(chaineToString.Contains("chi"));
            Assert.IsTrue(chaineToString.Contains("ailier droit"));
            Assert.IsTrue(chaineToString.Contains("44"));
            Assert.IsTrue(chaineToString.Contains("31"));
            Assert.IsTrue(chaineToString.Contains("22"));
            Assert.IsTrue(chaineToString.Contains(joueur.Stats.NbPointsPool().ToString()));
        }

        #endregion
    }
}
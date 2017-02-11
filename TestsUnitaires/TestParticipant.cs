#region MÉTADONNÉES

// Nom du fichier : TestParticipant.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2016-02-10
// Date de modification : 2016-02-10

#endregion

#region USING

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_1_420_216_FX;

#endregion

namespace TestsUnitaires
{
    /// <summary>
    /// Tests unitaires pour la classe "Participant".
    /// </summary>
    [TestClass]
    public class TestParticipant
    {
        #region MÉTHODES

        /// <summary>
        /// Tests unitaires pour le "Constructeur".
        /// </summary>
        [TestMethod]
        public void TestConstructeurParticipant()
        {
            Participant part = new Participant("Bob L'éponge", new byte[] {});
            Assert.AreEqual("Bob L'éponge", part.Nom);
            Assert.AreEqual(0, part.VectNoJoueurPool.Length);

            byte[] noJoueurs = new byte[] {1, 3, 7, 8, 11, 15, 26, 31, 33, 37};
            part = new Participant("Francis  Beaulieu", noJoueurs);
            Assert.AreEqual(noJoueurs.Length, part.VectNoJoueurPool.Length);
            for (int i = 0; i < noJoueurs.Length; i++)
                Assert.AreEqual(noJoueurs[i], part.VectNoJoueurPool[i]);
        }

        /// <summary>
        /// Tests unitaires pour la méthode "ToString".
        /// </summary>
        [TestMethod]
        public void TestToStringParticipant()
        {
            Participant part = new Participant("Bob L'éponge", new byte[] {});
            Assert.AreEqual("Bob L'éponge", part.ToString());
        }

        #endregion
    }
}
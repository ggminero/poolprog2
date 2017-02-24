#region MÉTADONNÉES

// Nom du fichier : TestUtilitaire.cs
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
    /// Tests unitaires pour la classe statique "Utilitaire".
    /// </summary>
    [TestClass]
    public class TestUtilitaire
    {
        #region MÉTHODES

        /// <summary>
        /// Tests unitaires pour la méthode statique "ChargerEquipes".
        /// </summary>
        [TestMethod]
        public void TestChargerEquipes()
        {
            const String fichierEquipes = "equipes.txt";
            Equipe[] equipes = Utilitaire.ChargerEquipes(fichierEquipes);

            Assert.AreEqual(30, equipes.Length);

            Assert.AreEqual("pit", equipes[0].Code);
            Assert.AreEqual("Penguins", equipes[0].Nom);
            Assert.AreEqual("Pittsburgh", equipes[0].Ville);

            Assert.AreEqual("chi", equipes[9].Code);
            Assert.AreEqual("Blackhawks", equipes[9].Nom);
            Assert.AreEqual("Chicago", equipes[9].Ville);

            Assert.AreEqual("wpg", equipes[29].Code);
            Assert.AreEqual("Jets", equipes[29].Nom);
            Assert.AreEqual("Winnipeg", equipes[29].Ville);
        }

        /// <summary>
        /// Tests unitaires pour la méthode statique "ChargerJoueurs".
        /// </summary>
        [TestMethod]
        public void TestChargerJoueurs()
        {
            const String fichierJoueursStats = "joueurs_stats.txt";
            Joueur[] joueurs = Utilitaire.ChargerJoueurs(fichierJoueursStats);

            Assert.AreEqual(joueurs.Length, 40);

            Assert.AreEqual("Patrick Kane", joueurs[0].Nom);
            Assert.AreEqual("chi", joueurs[0].CodeEquipe);
            Assert.AreEqual(PositionHockey.AilierDroit, joueurs[0].Position);
            Assert.AreEqual(3735u, joueurs[0].NoPhoto);
            Assert.AreEqual(44, joueurs[0].Stats.NbButs);
            Assert.AreEqual(31, joueurs[0].Stats.NbAides);
            Assert.AreEqual(22, joueurs[0].Stats.PlusOuMoins);
            Assert.AreEqual(86, joueurs[0].Stats.NbPointsPool());

            Assert.AreEqual("Johnny Gaudreau", joueurs[9].Nom);
            Assert.AreEqual("cgy", joueurs[9].CodeEquipe);
            Assert.AreEqual(PositionHockey.AilierGauche, joueurs[9].Position);
            Assert.AreEqual(2563039u, joueurs[9].NoPhoto);
            Assert.AreEqual(28, joueurs[9].Stats.NbButs);
            Assert.AreEqual(21, joueurs[9].Stats.NbAides);
            Assert.AreEqual(6, joueurs[9].Stats.PlusOuMoins);
            Assert.AreEqual(52, joueurs[9].Stats.NbPointsPool());

            Assert.AreEqual("Lee Stempniak", joueurs[39].Nom);
            Assert.AreEqual("nj", joueurs[39].CodeEquipe);
            Assert.AreEqual(PositionHockey.AilierDroit, joueurs[39].Position);
            Assert.AreEqual(3083u, joueurs[39].NoPhoto);
            Assert.AreEqual(23, joueurs[39].Stats.NbButs);
            Assert.AreEqual(15, joueurs[39].Stats.NbAides);
            Assert.AreEqual(7, joueurs[39].Stats.PlusOuMoins);
            Assert.AreEqual(41, joueurs[39].Stats.NbPointsPool());
        }

        /// <summary>
        /// Tests unitaires pour la méthode statique "ChargerParticipants".
        /// </summary>
        [TestMethod]
        public void TestChargerParticipants()
        {
            const String fichierParticipants = "participants.txt";
            Participant[] participants = Utilitaire.ChargerParticipants(fichierParticipants);

            Assert.AreEqual(14, participants.Length);

            Assert.AreEqual("Rabah Archambault", participants[0].Nom);
            Assert.AreEqual(10, participants[0].VectNoJoueurPool.Length);
            Assert.AreEqual(1, participants[0].VectNoJoueurPool[0]);
            Assert.AreEqual(11, participants[0].VectNoJoueurPool[4]);
            Assert.AreEqual(37, participants[0].VectNoJoueurPool[9]);

            Assert.AreEqual("Michael Ducharme", participants[4].Nom);
            Assert.AreEqual(10, participants[4].VectNoJoueurPool.Length);
            Assert.AreEqual(3, participants[4].VectNoJoueurPool[0]);
            Assert.AreEqual(16, participants[4].VectNoJoueurPool[4]);
            Assert.AreEqual(40, participants[4].VectNoJoueurPool[9]);

            Assert.AreEqual("Maombi Maheux", participants[8].Nom);
            Assert.AreEqual(0, participants[8].VectNoJoueurPool.Length);

            Assert.AreEqual("Guillaume Métivier", participants[9].Nom);
            Assert.AreEqual(1, participants[9].VectNoJoueurPool.Length);
            Assert.AreEqual(1, participants[9].VectNoJoueurPool[0]);
        }

        /// <summary>
        /// Tests unitaires pour la méthode statique "EnregistrerParticipants".
        /// </summary>
        [TestMethod]
        public void TestEnregistrerParticipants()
        {
            Participant[] participantsInit = new Participant[2];
            participantsInit[0] = new Participant("Olivier Roy", new byte[] {1, 3, 40});
            participantsInit[1] = new Participant("Alexandre Tremblay", new byte[] {});

            // Enregistrement des participants.
            const String fichierParticipants = "participants-tests-unitaires.txt";
            Utilitaire.EnregistrerParticipants(fichierParticipants, participantsInit);

            // Lecture des participants.
            Participant[] participantsLus = Utilitaire.ChargerParticipants(fichierParticipants);

            Assert.AreEqual(participantsInit.Length, participantsLus.Length);

            Assert.AreEqual("Olivier Roy", participantsLus[0].Nom);
            Assert.AreEqual(3, participantsLus[0].VectNoJoueurPool.Length);
            Assert.AreEqual(1, participantsLus[0].VectNoJoueurPool[0]);
            Assert.AreEqual(3, participantsLus[0].VectNoJoueurPool[1]);
            Assert.AreEqual(40, participantsLus[0].VectNoJoueurPool[2]);

            Assert.AreEqual("Alexandre Tremblay", participantsLus[1].Nom);
            Assert.AreEqual(0, participantsLus[1].VectNoJoueurPool.Length);

            // Autre test avec aucun participant.
            participantsInit = new Participant[0];

            Utilitaire.EnregistrerParticipants(fichierParticipants, participantsInit);
            participantsLus = Utilitaire.ChargerParticipants(fichierParticipants);
            Assert.AreEqual(participantsInit.Length, participantsLus.Length);
        }

        /// <summary>
        /// Tests unitaires pour la méthode statique "FormaterChainePascalOuMixte".
        /// </summary>
        [TestMethod]
        public void TestFormaterChainePascalOuMixte()
        {
            Assert.AreEqual("", Utilitaire.FormaterChainePascalOuMixte(""));
            Assert.AreEqual("ailier droit", Utilitaire.FormaterChainePascalOuMixte("AilierDroit"));
            Assert.AreEqual("nb de poutines mangées", Utilitaire.FormaterChainePascalOuMixte("nbDePoutinesMangées"));
            Assert.AreEqual("allotoi", Utilitaire.FormaterChainePascalOuMixte("allotoi"));
            Assert.AreEqual("allotoi", Utilitaire.FormaterChainePascalOuMixte("Allotoi"));
        }

        #endregion
    }
}
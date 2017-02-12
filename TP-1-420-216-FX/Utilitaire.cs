using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TP_1_420_216_FX
{
    public class Utilitaire
    {
        #region MÉTHODES

        /// <summary>
        /// Permet de charger les données d'un fichier texte et de créer 
        /// les objets "Equipe" correspondants (désérialisation).
        /// </summary>
        public static Equipe[] ChargerEquipes(string cheminFichier)
        {
            // Création du flux en lecture du fichier
            StreamReader fluxLectEquipe = new StreamReader(cheminFichier);

            // Lecture du fichier
            string fichierEquipe = fluxLectEquipe.ReadToEnd();

            // Création d'un vecteur de chaînes
            String[] vectLignes = fichierEquipe.Split('\n');

            // Nombre de lignes non vides dans le fichier.
            int nbLignes;
            if (vectLignes[vectLignes.Length - 1] == "")
                nbLignes = vectLignes.Length - 1;
            else
                nbLignes = vectLignes.Length;

            // Création du vecteur des équipes
            Equipe[] vectEquipes = new Equipe[nbLignes];

            // Fermeture du flux vers le fichier.
            fluxLectEquipe.Close();

            // On retourne le vecteur d'équipes créé.
            return vectEquipes;
        }

        /// <summary>
        /// Permet de charger les données d'un fichier texte 
        /// et de créer les objets "Joueur" correspondants (désérialisation).
        /// </summary>
        public static Joueur[] ChargerJoueurs(string cheminFichier)
        {
            // Création du flux en lecture du fichier
            StreamReader fluxLectJoueur = new StreamReader(cheminFichier);

            // Lecture du fichier
            string fichierJoueurs = fluxLectJoueur.ReadToEnd();

            // Création d'un vecteur de chaînes
            String[] vectLignes = fichierJoueurs.Split('\n');

            // Nombre de lignes non vides dans le fichier.
            int nbLignes;
            if (vectLignes[vectLignes.Length - 1] == "")
                nbLignes = vectLignes.Length - 1;
            else
                nbLignes = vectLignes.Length;

            // Création du vecteur des joueurs
            Joueur[] vectJoueur = new Joueur[nbLignes];

            // Fermeture du flux vers le fichier.
            fluxLectJoueur.Close();

            // On retourne le vecteur de joueurs créé.
            return vectJoueur;
        }

        /// <summary>
        /// Permet de charger les données d'un fichier texte et de créer 
        /// les objets "Participant" correspondants (désérialisation).
        /// </summary>
        public static Participant[] ChargerParticipants(string cheminFichier)
        {
            // Création du flux en lecture du fichier
            StreamReader fluxLectPart = new StreamReader(cheminFichier);

            // Lecture du fichier
            string fichierParticipants = fluxLectPart.ReadToEnd();

            // Création d'un vecteur de chaînes
            String[] vectLignes = fichierParticipants.Split('\n');

            // Nombre de lignes non vides dans le fichier.
            int nbLignes;
            if (vectLignes[vectLignes.Length - 1] == "")
                nbLignes = vectLignes.Length - 1;
            else
                nbLignes = vectLignes.Length;

            // Création du vecteur des joueurs
            Participant[] vectPart = new Participant[nbLignes];

            // Fermeture du flux vers le fichier.
            fluxLectPart.Close();

            // On retourne le vecteur de joueurs créé.
            return vectPart;
        }
    }
}

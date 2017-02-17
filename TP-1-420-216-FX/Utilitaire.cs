using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        /// Permet d'enregistrer les données sur les participants dans un fichier
        /// texte(sérialisation). --> CLASSE PARTICIPANT À CRÉER
        /// </summary>
        public static void EnregistrerParticipants(string cheminFichier, Participant[] vectParticipants)
        {
            // Création du flux d'écriture dont le chemin d'accès est "cheminFichier"
            StreamWriter fluxEnregistre = new StreamWriter(cheminFichier, false);

            // Chaîne de caractères pour la version sérialisé d'un objet "Participant"
            string participantTexte;

            // Traitement de chaque objet du vecteur
            for (int i = 0; i < vectParticipants.Length; i++)
            {
                // Création de la version sérialisée de l'objet "Participant"
                participantTexte = vectParticipants[i].Prenom + ", ";

                // Écriture de la version sérialisée de l'objet dans un fichier
                fluxEnregistre.WriteLine(participantTexte);
            }

            // Fermeture du flux vers le fichier
            fluxEnregistre.Close();
        }

        /// <summary>
        /// Permet de formater pour l'affichage
        /// une chaîne de caractères en format casse Pascal ou casse mixte.
        /// </summary>
        public static String FormaterChainePascalOuMixte(string chaine)// --> à compléter
        {
            int indice = 0;
            char premiereLettreDeuxiemeMot = ' ';
            char lettreMaj = Char.ToUpper(premiereLettreDeuxiemeMot);
            
            // Version formatée de la chaine de caractères
            string chaineFormate = "";
            
            // Le deuxième mot en casse Pascal doit commencer par une majuscule
            int positionDebutDeuxiemeMot = chaine.IndexOf(lettreMaj);
            
            // Formatage de la chaine de caractères
            while (positionDebutDeuxiemeMot != 1)
            {
                if (chaine[indice] == lettreMaj)
                {
                     chaineFormate = chaine.ToLower()
                }
            }
           
        }

        /// <summary>
        /// Permet d'obtenir une image sur le Web à partir d'un URL.
        /// </summary>
        public static Image ChargerImageUrl(string url)
        {
            // Image à créer et retourner.
            Image imageUrl = null;
            // Réponse HTTP.
            WebResponse reponseHttp = null;
            // Flux de données HTTP.
            Stream fluxHttp = null;

            try
            {
                // Création de la connexion HTTP vers la ressource désignée par l'URL reçu en paramètre.
                HttpWebRequest requeteHttp = (HttpWebRequest)WebRequest.Create(url);
                requeteHttp.AllowWriteStreamBuffering = true;

                // Délai maximum d'attente de la requête.
                requeteHttp.Timeout = 5000;

                // Obtention de la réponse HTTP à partir de la requête HTTP.
                reponseHttp = requeteHttp.GetResponse();

                // Obtention du flux de données à partir de la réponse HTTP.
                fluxHttp = reponseHttp.GetResponseStream();

                // Création de l'image à retourner
                imageUrl = Image.FromStream(fluxHttp);
            }
            catch (Exception e)
            {
                // Il y a eu une erreur, affichage d'un message dans la console.
                Console.WriteLine("ERREUR : Impossible d'obtenir l'image avec l'URL suivant : {0}\nMessage : {1}", url,
                    e.Message);
            }
            finally
            {
                // Libération des ressources utilisée (sans possibilité de lever une erreur).
                try
                {
                    // ReSharper disable once PossibleNullReferenceException
                    fluxHttp.Close();
                }
                catch
                {
                }
                try
                {
                    // ReSharper disable once PossibleNullReferenceException
                    reponseHttp.Close();
                }
                catch
                {
                }
            }

            // Retourne l'image chargée ou bien "null" si une exception est levée.
            return imageUrl;
        }
        
        #endregion 
    }
}



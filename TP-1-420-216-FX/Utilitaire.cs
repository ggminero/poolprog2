using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TP_1_420_216_FX
{
    /// <summary>
    /// Classe statique contenant des méthodes utilitaires
    /// </summary>
    public static class Utilitaire
    {

        /// <summary>
        /// Méthode qui sert à charger les données du fichier texte contenant les participants
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Equipe[] ChargerEquipes(string cheminFichier)
        {
            // Création du flux en lecture du fichier texte
            StreamReader fluxLecture = new StreamReader(cheminFichier);

            // Lecture du fichier texte
            string fichierTexte = fluxLecture.ReadToEnd();

            // Création d'un vecteur de chaînes de caractères contenant chaque ligne individuellement.
            String[] vectLignes = fichierTexte.Split('\n');           

            // Nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Equipe
            int nbrLignes = File.ReadLines(cheminFichier).Count();

            // Création d'un vecteur d'équipe 
            Equipe[] vectEquipes = new Equipe[nbrLignes];

            // Vecteur pour conserver les champs séparément sur une ligne
            String[] vectChamps;

            // Variables pour la création d'un objet Equipe
            string nom, ville, code;

            // Traitement de chaque ligne du fichier 
            for (int i = 0; i < vectEquipes.Length; i++)
            {
                // Séparation des champs sur la ligne en traitement
                vectChamps = vectLignes[i].Split(',');

                // Récupération du nom de l'équipe, de sa ville et de son code
                nom = vectChamps[0].Trim();
                ville = vectChamps[1].Trim();
                code = vectChamps[2].Trim();

                // Création de l'objet "Equipe" et ajout au vecteur
                vectEquipes[i] = new Equipe(nom, ville, code);
            }

            // Fermeture du flux vers le fichier
            fluxLecture.Close();

            // Retour du vecteur d'équipe
            return vectEquipes;

        }


        /// <summary>
        /// Méthode qui sert à charger les données du fichier texte contenant les participants
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Participant[] ChargerParticipants(string cheminFichier)
        {
            //compteur pour créer les objets Participant
            int nbrParticipants = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Participant
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Participant[] listeParticipants = new Participant[nbrLignes];
            
            //lecture du fichier texte
            using (StreamReader lecture = new StreamReader(cheminFichier))
            {
                string ligne;
                
                // Lecture des lignes du fichier jusqu'à la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {

                    //split la ligne a un vecteur
                    List<String> vecteurLigne = new List<String>(ligne.Split(','));

                    string nom = vecteurLigne[0];

                    //Enlève le nom du vecteur pour avoir que des numéros de joueurs choisis 
                    vecteurLigne.RemoveAt(0);
                    //Crée un nouveau vecteur avec les numéros de joueurs choisis 
                    string newByteString = String.Join(",", vecteurLigne);

                    //nous convertissions la chaîne de caractères a un byte array
                    byte[] bytes = Encoding.UTF8.GetBytes(newByteString);
                    
                    //init un objet Participant avec les attributs de la classe
                    Participant unParticipant = new Participant(nom, bytes);

                    //ajout de l'objet participant au vecteur listeParticipants
                    listeParticipants[nbrParticipants] = unParticipant;
                    nbrParticipants += 1;
                }
            }
                    return listeParticipants;
        }
        
        /// <summary>
        /// Permet de charger les données du fichier Joueur
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <returns></returns>
        public static Joueur[] ChargerJoueur(string cheminFichier)
        {
            //compteur pour créer les objets Joueur
            int nbrJoueurs = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Joueur
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Joueur[] listeJoueur = new Joueur[nbrLignes];

            //lecture du fichier texte
            using (StreamReader lecture = new StreamReader(cheminFichier))
            {

                string ligne;

                // Lecture des lignes du fichier jusqu'à la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {
                    
                    //split la ligne pour ajouter chaque élément de la ligne a un vecteur
                    //joueurs avant d'initialiser un objet Joueur 
                    var joueurs = ligne.Split(',');

                    //variables locales pour déterminer les attributs du Joueur
                    // nom, code... avant d'initialiser un objet Joueur
                    int indexPostition;
                    string nom = joueurs[0];
                    string code = joueurs[1];
                    uint noPhoto = Convert.ToUInt32(joueurs[3]);
                    byte nbButs = Convert.ToByte(joueurs[4]);
                    byte nbAides = Convert.ToByte(joueurs[5]);
                    short plusOuMoins = Convert.ToInt16(joueurs[6]);

                    //Enlève l'espace de l'élément du vecteur
                    string positionJoueur = joueurs[2].Trim();
                    
                    //Switch pour déterminer la position du joueur 
                    switch (positionJoueur)
                    {
                        case "C":
                            indexPostition = 0;
                            break;
                        case "AD":
                            indexPostition = 1;
                            break;
                        case "AG":
                            indexPostition = 2;
                            break;
                        case "D":
                            indexPostition = 3; 
                            break;
                        case "G":
                            indexPostition = 4;
                            break;

                        default:
                            indexPostition = 0;
                            break;
                    }
                    
                    //Initialisation des objets StatsJoueurs, Joueur  avant d'ajouter au vecteur d'objet joueur
                    StatsJoueur statusUn = new StatsJoueur(nbButs, nbAides, plusOuMoins);
                    Joueur unJoueur = new Joueur(joueurs[0], joueurs[1], (PositionHockey)indexPostition, Convert.ToUInt32(joueurs[3]), statusUn);

                    //Console.WriteLine(unJoueur);
                    listeJoueur[nbrJoueurs] = unJoueur;

                    //compteur pour itérer les lignes du fichier texte, +1 a chaque itération
                    nbrJoueurs += 1;
                }
            }

            return listeJoueur;
        }

        /// <summary>
        /// Méthode permettant d'enregistrer les participants
        /// </summary>
        public static void EnregistrerPArticipants()
        {
            Console.WriteLine("enregistré");
        }
        /// <summary>
        /// Permet de formater pour l'affichage une chaîne de caractères en format casse Pascal ou casse mixte.
        /// </summary>
        /// <param name="chaineNonPascale"></param>
        /// <returns></returns>
        public static string FormaterChainePascalOuMixte(string chaineNonPascale)
        {
            //Déclaration de variables pour créer une chaîne en format pascale
            // et un compteur pour identifier la place ou il y a des majuscules dans 
            // la chaîne de caractères
            string chainePascale = String.Empty;
            int compteur = 0;

            //Itération sur la chaîne de caractères
            for(int i=0; i< chaineNonPascale.Length;i++)
            {
                //Si caractère majuscule, +1 au compteur
                if(char.IsUpper(chaineNonPascale[i]))
                {
                    compteur++;
                    //si plus de 1 char majuscule, on insère un espace a la place
                    // du deuxième char majuscule et on converti en minuscule
                    if (compteur >= 2)
                    {
                        chainePascale = chaineNonPascale.Insert(i, " ");
                        chainePascale = chainePascale.ToLower();
                    }
                    //sinon on converti toute la chaîne en minuscule sans l'ajout d'espace
                    else
                    {
                        chainePascale = chaineNonPascale.ToLower();
                    }
                }

            }

            return chainePascale;
        }

    }
}

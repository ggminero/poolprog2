using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TP_1_420_216_FX
{
    public class Utilitaire
    {

        /// <summary>
        /// Méthode permetant de charger les participats a partir d'un fichier texte
        /// </summary>
        /// <param name="cheminFichier"></param>
        public static Participant[] ChargerParticipants(string cheminFichier)
        {
            //compteur pour créer les objets Participant
            int nbrParticipants = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Participant
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Participant[] listeParticipants = new Participant[nbrLignes];
            Console.WriteLine(nbrLignes);
            //lecture du fichier text
            using (StreamReader lecture = new StreamReader(cheminFichier))
            {
                string ligne;
                
                // Lecture des lignes du fichier jusqu'a la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {

                    //split la ligne a un vecteur
                    List<String> vecteurLigne = new List<String>(ligne.Split(','));

                    string nom = vecteurLigne[0].Trim();

                    //Enleve le nom du vecteur pour avoir que des numéros de joueurs choisis 
                    vecteurLigne.RemoveAt(0);
                    //Crée un nouveau vecteur avec les numéros de joueurs choisis 
                    string newByteString = String.Join(",", vecteurLigne);

                    //nous convertissions la chaine de characteres a un byte array
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
        /// Méthode permetant de charger les équipes a partir d'un fichier texte
        /// </summary>
        /// <param name="cheminFichier"></param>
        public static Equipe[] ChargerEquipes(string cheminFichier)
        {
            int nbrEquipes = 0;

            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Equipe[] listeEquipes = new Equipe[nbrLignes];

            using (StreamReader lecture = new StreamReader(cheminFichier))
            {
                string ligne;

                // Lecture des lignes du fichier jusqu'a la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {
                    List<String> vecteurLigne = new List<String>(ligne.Split(','));


                    Equipe unEquipe = new Equipe(vecteurLigne[0].Trim(), vecteurLigne[1].Trim(), vecteurLigne[2].Trim());
                    listeEquipes[nbrEquipes] = unEquipe;

                    nbrEquipes += 1;
                }
            }          
            
            return listeEquipes;
        }

        /// <summary>
        /// Méthode permetant de charger les joueurs a partir d'un fichier texte
        /// </summary>
        /// <param name="cheminFichier"></param>
        public static Joueur[] ChargerJoueurs(string cheminFichier)
        {
            //compteur pour créer les objets Joueur
            int nbrJoueurs = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Joueur
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Joueur[] listeJoueur = new Joueur[nbrLignes];

            //lecture du fichier text
            using (StreamReader lecture = new StreamReader(cheminFichier))
            {

                string ligne;

                // Lecture des lignes du fichier jusqu'a la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {
                    
                    //split la ligne pour ajouter chaque element de la ligne a un vecteur
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

                    //Enleve l'espace de l'element du vecteur
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
                    
                    //init des objets StatsJoueurs, Joueur  avant d'ajouter au vecteur d'objet joueur
                    StatsJoueur statusUn = new StatsJoueur(nbButs, nbAides, plusOuMoins);
                    Joueur unJoueur = new Joueur(joueurs[0], joueurs[1], (PositionHockey)indexPostition, Convert.ToUInt32(joueurs[3]), statusUn);

                    //Console.WriteLine(unJoueur);
                    listeJoueur[nbrJoueurs] = unJoueur;

                    //compteur pour itérer les lignes du fichier text, +1 a chaque itération
                    nbrJoueurs += 1;
                }
            }

            return listeJoueur;
        }

        /// <summary>
        /// Méthode permettant d'enregistrer les participants si il y a eu
        /// lieu des changement a leur joueurs sur la forme
        /// </summary>
        /// <param name="cheminFichier"></param>
        /// <param name="lesParticipants"></param>
        public static void EnregistrerParticipants(String cheminFichier, Participant[] lesParticipants)
        {
            // Chaîne de caractères pour la version sérialisée d'un objet Participant
            string participantTexte = String.Empty;

            // Création du flux d'enregistrement du fichier participants
            StreamWriter fluxEnregistrement = new StreamWriter(cheminFichier);

            
            //String participantTexte;
            
            // Traitement de chaque objet Participant du vecteur
            for (int i = 0; i < lesParticipants.Length; i++)
            {
                // Sérialisation de l'objet Personne
                participantTexte = lesParticipants[i].Nom + ", " + lesParticipants[i].VectNoJoueurPool;

                // Écriture de la version sérialisée d'un objet Participant
                fluxEnregistrement.WriteLine(participantTexte);                                              
            }
            Console.WriteLine(participantTexte);
            // Fermeture du flux
            fluxEnregistrement.Close();
        }

        /// <summary>
        /// Méthode permettant de formater une chaîne pascal
        /// </summary>
        /// <param name="chaineNonPascale"></param>
        public static string FormaterChainePascalOuMixte(string chaineNonPascale)
        {
            //déclaration de variables pour créer une chaîne en format pascale
            // et on itere la chaine pour concatener des espaces avant une majuscule
            //finallement, on enlève les espaces aux extremités et converti a Lower
            string chainePascale = String.Empty;
            
            foreach(Char charactere in chaineNonPascale)          
            //itération sur la chaîne de caractère          
            {
                if(Char.IsUpper(charactere))
                {
                    chainePascale += " ";
                    chainePascale += charactere.ToString();  
                }
                else
                {
                    chainePascale += charactere.ToString();
                }
            }
            return chainePascale.ToLower().Trim();
        }

    }
}

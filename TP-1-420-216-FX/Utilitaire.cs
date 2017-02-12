using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TP_1_420_216_FX
{
    class Utilitaire
    {
        

        public static Participant[] ChargerParticipants(string cheminFichier)
        {
            //compteur pour créer les objets Participants
            int nbrParticipants = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Joueur
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Participant[] listeParticipants = new Participant[nbrLignes];

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

                    //Enleve l'espace de l'element du veteur
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
        public static Joueur[] ChargerJoueur(string cheminFichier)
        {
            //compteur pour créer les objets Joueur
            int nbrJoueurs = 0;

            //nombre de lignes dans le fichier texte pour déterminer la longueur du vecteur Joueur
            var nbrLignes = File.ReadLines(cheminFichier).Count();
            Joueur[] listeJoueur = new Joueur[nbrLignes];

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

                    //Enleve l'espace de l'element du veteur
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

        public static void EnregistrerPArticipants()
        {
            Console.WriteLine("enregistré");
        }
    }
}

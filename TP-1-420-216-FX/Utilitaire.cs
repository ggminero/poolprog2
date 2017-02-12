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
        

        public static List<string> ChargerParticipants(string cheminFichier)
        {
            List<string> Participant = new List<string>();

            using (StreamReader lecture = new StreamReader("participants.txt"))
            {
                string ligne;
                // Lecture des lignes du fichier jusqu'a la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {
                    //split la chaine de charactere a chaque virgule et on prends le premier
                    //elément de la liste, on l'ajoute a la liste _participants pour
                    //binder a la Listbox quand on l'initialize
                    var nom_participant = ligne.Split(',')[0];

                    Participant.Add(nom_participant);

                }

                //listBoxParticipants.DataSource = _participants;
            }

            return Participant;
        }
        public static List<string> ChargerJoueur(string cheminFichier)
        {
            List<string> Joueurs = new List<string>();

            using (StreamReader lecture = new StreamReader("joueurs_stats.txt"))
            {
                string ligne;
                // Lecture des lignes du fichier jusqu'a la fin du fichier
                while ((ligne = lecture.ReadLine()) != null)
                {
                    //ajoute chaque joueur a la liste _joueurs pour ajouter
                    //a la ListBox quand on l'initialize
                    var joueurs = ligne;

                    Joueurs.Add(joueurs);

                }
                
            }
            return Joueurs;
        }

        public static void EnregistrerPArticipants()
        {
            Console.WriteLine("enregistré");
        }
    }
}

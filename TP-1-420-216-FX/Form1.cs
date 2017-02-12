using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_420_216_FX
{
    public partial class FormPoolHockey : Form
    {
        List<string> _participants = new List<string>();

        public FormPoolHockey()
        {
            InitializeComponent();

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

                    _participants.Add(nom_participant);
                    
                }

                listBoxParticipants.DataSource = _participants;

            }

        }

        /// <summary>
        /// Ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

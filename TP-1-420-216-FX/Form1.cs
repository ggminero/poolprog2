﻿using System;
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
        
        public FormPoolHockey()
        {
            InitializeComponent();

            //enleve la selection par défault des elements de type listbox
            listBoxParticipants.ClearSelected();
            listBoxJoueurs.ClearSelected();

            //Initialize les listBox avec les données chargées a partire de la classe Utilitaire
            listBoxParticipants.DataSource = Utilitaire.ChargerParticipants("participants.txt");
            listBoxJoueurs.DataSource = Utilitaire.ChargerJoueur("joueurs_stats.txt");
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

        /// <summary>
        /// Ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            Utilitaire.EnregistrerPArticipants();

            //this.Close();
        }
    }
}
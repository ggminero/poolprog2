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
        //init du pool de hockey dans la forme
        PoolHockeyLnh lePool = new PoolHockeyLnh();
        
        public FormPoolHockey()
        {
            InitializeComponent();

            //Initialize les listBox avec les données chargées a partire de la classe Utilitaire
            listBoxParticipants.DataSource = lePool.lesParticipants;    
            listBoxJoueurs.DataSource = lePool.lesJoueurs;        

            //enleve la selection par défault des elements de type listbox
            listBoxParticipants.ClearSelected();
            listBoxJoueurs.ClearSelected();
            comboBoxEchange.Visible = false;          

        }

        /// <summary>
        /// Ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            Utilitaire.EnregistrerParticipants();

        }

        /// <summary>
        /// Affiche FormFicheJoueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoirFiche_Click(object sender, EventArgs e)
        {
            // variables locals pour avoir les joueurs et équipes
            Joueur[] lesJoueurs = lePool.lesJoueurs;
            Equipe[] lesEquipes = lePool.lesEquipes;

            // Retourne le participant selectionné de la ListBox avec stats en vecteur
            var nomJoueurSelect = listBoxJoueurs.SelectedItem.ToString().Split(' ');
            
            //On additione les 2 premiers éléments du vecteur pour avoir le nom
            string joueurSelect = nomJoueurSelect[0] +" "+ nomJoueurSelect[1]; //listBoxJoueurs.SelectedItem.ToString();

            // Retourne l'index du participant selectionné de la ListBox.
            int partIndex = listBoxJoueurs.FindString(joueurSelect);
            
            //iteration sur la liste des joueurs
            foreach (Joueur joueur in lesJoueurs)
            {
                // si le nom dans la chaine de characteres
                if (joueurSelect.Contains(joueur.Nom))
                {
                    lePool.RechercherIndiceJoueur(joueur);
                    //iteration sur la liste des equipes
                    foreach (Equipe equipe in lesEquipes)
                    {
                        //Si le code d'équipe est au code dequipe du joueurs on init la fiche du joueur
                        if (equipe.Code.Trim().Contains(joueur.Code.Trim()))
                        {
                            FormFicheJoueur formJoueur = new FormFicheJoueur(equipe, joueur);
                            formJoueur.ShowDialog();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// active les boutons pour voir la fiche des joueurs et
        /// echanger joueur quands l'index de la listbox des joueurs 
        /// est non null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxJoueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si un joueur de la liste est selectionné
            //on active les btns, sinon ils restent inactifs.
            if (listBoxJoueurs.SelectedIndex != -1)
            {
                btnVoirFiche.Enabled = true;

                if (listBoxParticipants.SelectedIndex != -1)
                {
                    btnEchangerJoueur.Enabled = true;
                }
            }
            else
            {
                btnVoirFiche.Enabled = false;
                btnEchangerJoueur.Enabled = false;
            }
        }

        /// <summary>
        /// active la groupbox avec le nom du participant selectionné
        /// et les points au pool quands l'index de la listbox des participants 
        /// est non null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variable pour le calcul de points des participants dans la pool
            int pointsPool = 0;

            //si un participant est selectionné on affiche la groupBox avec les  stats
            //duparticipant, sinon, elle reste caché
            if (listBoxParticipants.SelectedIndex != -1)
            {
                groupBoxParticipant.Enabled = true;
                groupBoxParticipant.Visible = true;

                // Retourne le participant selectionné de la ListBox.
                string partSelect = listBoxParticipants.SelectedItem.ToString();

                // Retourne l'index du participant selectionné de la ListBox.
                int partIndex = listBoxParticipants.FindString(partSelect);

                // set la listBox de joueurs a null pour pouvoir rafréshire les elements
                listBoxJoueurs.DataSource = null;

                Joueur[] lesJoueurs = lePool.lesJoueurs;

                //iteration sur la liste de participants
                foreach (Participant part in lePool.lesParticipants)
                {

                    //crée une liste a partir du vecteur bytes
                    var joueursSelect = Encoding.UTF8.GetString(part.VectNoJoueurPool).Split(',');

                    // si le nom est le bon
                    if (part.Nom.Equals(partSelect))
                    {
                       
                        //on clear la listbox de joueurs
                        listBoxJoueurs.Items.Clear();
                        //iteration sur la liste de joueurs selectionné
                        //du byte array et on ajoute a la listBox de joueurs
                        //validation pour participant sans joueurs
                        if (!joueursSelect[0].Equals(""))
                        {
                            foreach (var joueur in joueursSelect)
                            {
                                listBoxJoueurs.Items.Add(lePool.lesJoueurs[Int32.Parse(joueur) - 1]);
                            }
                        }
                        
                    }

                }


                //change le nom du participant a afficher dans la groupBox
                labelNom.Text = partSelect;

                //change le nombre de points du participant a afficher dans la groupBox
                foreach (var joueur in lePool.lesJoueurs)
                {
                    //si le joueur est déja dans la liste, on calcul les points
                    if (listBoxJoueurs.Items.Contains(joueur))
                    {
                        pointsPool += joueur.Stats.NbAides + joueur.Stats.NbButs + joueur.Stats.PlusOuMoins / 2;
                    }
                }
                //assigne la variable et converti a chaine de charactere
                labelNbrPoints.Text = pointsPool.ToString();
            }
            else
            {
                groupBoxParticipant.Enabled = false;
                groupBoxParticipant.Visible = false;
            }
        }

        /// <summary>
        /// la section pour les échanges (Label et ComboBox de type « DropDownList ») s’affichent
        /// avec les joueurs disponibles pour échanger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEchanger_Click(object sender, EventArgs e)
        {
            comboBoxEchange.Visible = true;
            comboBoxEchange.Enabled = true;

            //Remplissage de ComboBox Echanger avec les valeurs de la méthode retourné de
            //de chargerjoueur de la classe utilitaire. On exclue les joueurs déja choisi
            //iteration sur la liste de joueurs
            foreach (var joueur in lePool.lesJoueurs)
            {
                //si le joueur est déja dasn la liste, on n'ajoute pas a la comboBox
                if (!listBoxJoueurs.Items.Contains(joueur))
                {
                    comboBoxEchange.Items.Add(joueur);
                }
            }
        }

        /// <summary>
        /// re-init le formulaire avec les valeurs par défault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToutLesJoueurs_Click(object sender, EventArgs e)
        {
            listBoxJoueurs.DataSource = null;
            //on clear la listbox de joueurs
            listBoxJoueurs.Items.Clear();
            comboBoxEchange.Visible = false;
            groupBoxParticipant.Visible = false;
            btnEchangerJoueur.Enabled = false;
            btnVoirFiche.Enabled = false;
            listBoxJoueurs.DataSource = lePool.lesJoueurs;
            //enleve la selection par défault des elements de type listbox
            listBoxParticipants.ClearSelected();
            listBoxJoueurs.ClearSelected();

        }
        
    }
}

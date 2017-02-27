namespace TP_1_420_216_FX
{
    partial class FormPoolHockey
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTousLesJoueurs = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnVoirFiche = new System.Windows.Forms.Button();
            this.btnEchangerJoueur = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.listBoxJoueurs = new System.Windows.Forms.ListBox();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.groupBoxParticipant = new System.Windows.Forms.GroupBox();
            this.labelNbrPoints = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelJoueurs = new System.Windows.Forms.Label();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.labelPoolHockey = new System.Windows.Forms.Label();
            this.comboBoxEchange = new System.Windows.Forms.ComboBox();
            this.groupBoxParticipant.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTousLesJoueurs
            // 
            this.btnTousLesJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTousLesJoueurs.Location = new System.Drawing.Point(304, 61);
            this.btnTousLesJoueurs.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnTousLesJoueurs.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnTousLesJoueurs.Name = "btnTousLesJoueurs";
            this.btnTousLesJoueurs.Size = new System.Drawing.Size(120, 25);
            this.btnTousLesJoueurs.TabIndex = 0;
            this.btnTousLesJoueurs.Text = "Tous les Joueurs";
            this.btnTousLesJoueurs.UseVisualStyleBackColor = true;
            this.btnTousLesJoueurs.Click += new System.EventHandler(this.btnToutLesJoueurs_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(430, 61);
            this.btnEnregistrer.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnEnregistrer.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 25);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // btnVoirFiche
            // 
            this.btnVoirFiche.Enabled = false;
            this.btnVoirFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirFiche.Location = new System.Drawing.Point(304, 96);
            this.btnVoirFiche.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnVoirFiche.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnVoirFiche.Name = "btnVoirFiche";
            this.btnVoirFiche.Size = new System.Drawing.Size(120, 25);
            this.btnVoirFiche.TabIndex = 2;
            this.btnVoirFiche.Text = "Voir fiche";
            this.btnVoirFiche.UseVisualStyleBackColor = true;
            this.btnVoirFiche.Click += new System.EventHandler(this.btnVoirFiche_Click);
            // 
            // btnEchangerJoueur
            // 
            this.btnEchangerJoueur.Enabled = false;
            this.btnEchangerJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEchangerJoueur.Location = new System.Drawing.Point(430, 96);
            this.btnEchangerJoueur.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnEchangerJoueur.MinimumSize = new System.Drawing.Size(120, 25);
            this.btnEchangerJoueur.Name = "btnEchangerJoueur";
            this.btnEchangerJoueur.Size = new System.Drawing.Size(120, 25);
            this.btnEchangerJoueur.TabIndex = 3;
            this.btnEchangerJoueur.Text = "Échanger joueur";
            this.btnEchangerJoueur.UseVisualStyleBackColor = true;
            this.btnEchangerJoueur.Click += new System.EventHandler(this.btnEchanger_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(758, 61);
            this.btnquitter.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnquitter.MinimumSize = new System.Drawing.Size(100, 25);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(100, 25);
            this.btnquitter.TabIndex = 4;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // listBoxJoueurs
            // 
            this.listBoxJoueurs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxJoueurs.FormattingEnabled = true;
            this.listBoxJoueurs.ItemHeight = 14;
            this.listBoxJoueurs.Location = new System.Drawing.Point(252, 142);
            this.listBoxJoueurs.Name = "listBoxJoueurs";
            this.listBoxJoueurs.Size = new System.Drawing.Size(606, 326);
            this.listBoxJoueurs.TabIndex = 5;
            this.listBoxJoueurs.SelectedIndexChanged += new System.EventHandler(this.listBoxJoueurs_SelectedIndexChanged);
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.Location = new System.Drawing.Point(12, 142);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(219, 329);
            this.listBoxParticipants.TabIndex = 6;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            // 
            // groupBoxParticipant
            // 
            this.groupBoxParticipant.Controls.Add(this.labelNbrPoints);
            this.groupBoxParticipant.Controls.Add(this.labelPoints);
            this.groupBoxParticipant.Controls.Add(this.labelNom);
            this.groupBoxParticipant.Location = new System.Drawing.Point(13, 35);
            this.groupBoxParticipant.Name = "groupBoxParticipant";
            this.groupBoxParticipant.Size = new System.Drawing.Size(218, 85);
            this.groupBoxParticipant.TabIndex = 7;
            this.groupBoxParticipant.TabStop = false;
            this.groupBoxParticipant.Text = "Participant";
            this.groupBoxParticipant.Visible = false;
            // 
            // labelNbrPoints
            // 
            this.labelNbrPoints.AutoSize = true;
            this.labelNbrPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrPoints.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNbrPoints.Location = new System.Drawing.Point(97, 48);
            this.labelNbrPoints.Name = "labelNbrPoints";
            this.labelNbrPoints.Size = new System.Drawing.Size(42, 13);
            this.labelNbrPoints.TabIndex = 2;
            this.labelNbrPoints.Text = "Points";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(6, 48);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(92, 13);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Points au pool:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNom.Location = new System.Drawing.Point(6, 26);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelJoueurs
            // 
            this.labelJoueurs.AutoSize = true;
            this.labelJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueurs.Location = new System.Drawing.Point(252, 123);
            this.labelJoueurs.Name = "labelJoueurs";
            this.labelJoueurs.Size = new System.Drawing.Size(66, 17);
            this.labelJoueurs.TabIndex = 8;
            this.labelJoueurs.Text = "Joueurs";
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticipants.Location = new System.Drawing.Point(22, 123);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(94, 17);
            this.labelParticipants.TabIndex = 9;
            this.labelParticipants.Text = "Participants";
            // 
            // labelPoolHockey
            // 
            this.labelPoolHockey.AutoSize = true;
            this.labelPoolHockey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoolHockey.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelPoolHockey.Location = new System.Drawing.Point(283, 9);
            this.labelPoolHockey.Name = "labelPoolHockey";
            this.labelPoolHockey.Size = new System.Drawing.Size(326, 31);
            this.labelPoolHockey.TabIndex = 10;
            this.labelPoolHockey.Text = "Pool de hockey de la LNH";
            // 
            // comboBoxEchange
            // 
            this.comboBoxEchange.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEchange.FormattingEnabled = true;
            this.comboBoxEchange.Location = new System.Drawing.Point(563, 98);
            this.comboBoxEchange.Name = "comboBoxEchange";
            this.comboBoxEchange.Size = new System.Drawing.Size(295, 22);
            this.comboBoxEchange.TabIndex = 11;
            // 
            // FormPoolHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 483);
            this.Controls.Add(this.comboBoxEchange);
            this.Controls.Add(this.labelPoolHockey);
            this.Controls.Add(this.labelParticipants);
            this.Controls.Add(this.labelJoueurs);
            this.Controls.Add(this.groupBoxParticipant);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.listBoxJoueurs);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnEchangerJoueur);
            this.Controls.Add(this.btnVoirFiche);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnTousLesJoueurs);
            this.Name = "FormPoolHockey";
            this.Text = "Pool de hockey de la LNH";
            this.groupBoxParticipant.ResumeLayout(false);
            this.groupBoxParticipant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTousLesJoueurs;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnVoirFiche;
        private System.Windows.Forms.Button btnEchangerJoueur;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.ListBox listBoxJoueurs;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.GroupBox groupBoxParticipant;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelJoueurs;
        private System.Windows.Forms.Label labelNbrPoints;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Label labelPoolHockey;
        private System.Windows.Forms.ComboBox comboBoxEchange;
    }
}


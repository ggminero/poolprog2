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
            this.tousLesJoueurs = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.voirFiche = new System.Windows.Forms.Button();
            this.echangerJoueur = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.listBoxJoueurs = new System.Windows.Forms.ListBox();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNbrPoints = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelJoueurs = new System.Windows.Forms.Label();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.labelPoolHockey = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tousLesJoueurs
            // 
            this.tousLesJoueurs.Location = new System.Drawing.Point(330, 61);
            this.tousLesJoueurs.MaximumSize = new System.Drawing.Size(100, 25);
            this.tousLesJoueurs.MinimumSize = new System.Drawing.Size(100, 25);
            this.tousLesJoueurs.Name = "tousLesJoueurs";
            this.tousLesJoueurs.Size = new System.Drawing.Size(100, 25);
            this.tousLesJoueurs.TabIndex = 0;
            this.tousLesJoueurs.Text = "Tous les Joueurs";
            this.tousLesJoueurs.UseVisualStyleBackColor = true;
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(447, 61);
            this.enregistrer.MaximumSize = new System.Drawing.Size(100, 25);
            this.enregistrer.MinimumSize = new System.Drawing.Size(100, 25);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(100, 25);
            this.enregistrer.TabIndex = 1;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // voirFiche
            // 
            this.voirFiche.Enabled = false;
            this.voirFiche.Location = new System.Drawing.Point(330, 96);
            this.voirFiche.MaximumSize = new System.Drawing.Size(100, 25);
            this.voirFiche.MinimumSize = new System.Drawing.Size(100, 25);
            this.voirFiche.Name = "voirFiche";
            this.voirFiche.Size = new System.Drawing.Size(100, 25);
            this.voirFiche.TabIndex = 2;
            this.voirFiche.Text = "Voir fiche";
            this.voirFiche.UseVisualStyleBackColor = true;
            // 
            // echangerJoueur
            // 
            this.echangerJoueur.Enabled = false;
            this.echangerJoueur.Location = new System.Drawing.Point(447, 96);
            this.echangerJoueur.MaximumSize = new System.Drawing.Size(100, 25);
            this.echangerJoueur.MinimumSize = new System.Drawing.Size(100, 25);
            this.echangerJoueur.Name = "echangerJoueur";
            this.echangerJoueur.Size = new System.Drawing.Size(100, 25);
            this.echangerJoueur.TabIndex = 3;
            this.echangerJoueur.Text = "Échanger joueur";
            this.echangerJoueur.UseVisualStyleBackColor = true;
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(716, 61);
            this.quitter.MaximumSize = new System.Drawing.Size(100, 25);
            this.quitter.MinimumSize = new System.Drawing.Size(100, 25);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(100, 25);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // listBoxJoueurs
            // 
            this.listBoxJoueurs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxJoueurs.FormattingEnabled = true;
            this.listBoxJoueurs.ItemHeight = 14;
            this.listBoxJoueurs.Location = new System.Drawing.Point(252, 142);
            this.listBoxJoueurs.Name = "listBoxJoueurs";
            this.listBoxJoueurs.Size = new System.Drawing.Size(564, 326);
            this.listBoxJoueurs.TabIndex = 5;
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.Location = new System.Drawing.Point(12, 142);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(219, 329);
            this.listBoxParticipants.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNbrPoints);
            this.groupBox1.Controls.Add(this.labelPoints);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participant";
            this.groupBox1.Visible = false;
            // 
            // labelNbrPoints
            // 
            this.labelNbrPoints.AutoSize = true;
            this.labelNbrPoints.Location = new System.Drawing.Point(97, 48);
            this.labelNbrPoints.Name = "labelNbrPoints";
            this.labelNbrPoints.Size = new System.Drawing.Size(35, 13);
            this.labelNbrPoints.TabIndex = 2;
            this.labelNbrPoints.Text = "label5";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(6, 48);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(36, 13);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Points";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 26);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
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
            this.labelPoolHockey.Location = new System.Drawing.Point(283, 22);
            this.labelPoolHockey.Name = "labelPoolHockey";
            this.labelPoolHockey.Size = new System.Drawing.Size(326, 31);
            this.labelPoolHockey.TabIndex = 10;
            this.labelPoolHockey.Text = "Pool de hockey de la LNH";
            // 
            // FormPoolHockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 483);
            this.Controls.Add(this.labelPoolHockey);
            this.Controls.Add(this.labelParticipants);
            this.Controls.Add(this.labelJoueurs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.listBoxJoueurs);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.echangerJoueur);
            this.Controls.Add(this.voirFiche);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.tousLesJoueurs);
            this.Name = "FormPoolHockey";
            this.Text = "Pool de hockey de la LNH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tousLesJoueurs;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button voirFiche;
        private System.Windows.Forms.Button echangerJoueur;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.ListBox listBoxJoueurs;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelJoueurs;
        private System.Windows.Forms.Label labelNbrPoints;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Label labelPoolHockey;
    }
}


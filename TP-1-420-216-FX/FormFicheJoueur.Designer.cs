﻿namespace TP_1_420_216_FX
{
    partial class FormFicheJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNometPos = new System.Windows.Forms.Label();
            this.labelNomEquipEtVille = new System.Windows.Forms.Label();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelPlusMoinPoints = new System.Windows.Forms.Label();
            this.labelAidesPoints = new System.Windows.Forms.Label();
            this.labelButsPoints = new System.Windows.Forms.Label();
            this.labelPlusMoins = new System.Windows.Forms.Label();
            this.labelAides = new System.Windows.Forms.Label();
            this.labelButs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPointsPool = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxJoueur = new System.Windows.Forms.PictureBox();
            this.pictureBoxEquipe = new System.Windows.Forms.PictureBox();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNometPos
            // 
            this.labelNometPos.AutoSize = true;
            this.labelNometPos.Location = new System.Drawing.Point(162, 34);
            this.labelNometPos.Name = "labelNometPos";
            this.labelNometPos.Size = new System.Drawing.Size(74, 13);
            this.labelNometPos.TabIndex = 0;
            this.labelNometPos.Text = "nomEtPosition";
            // 
            // labelNomEquipEtVille
            // 
            this.labelNomEquipEtVille.AutoSize = true;
            this.labelNomEquipEtVille.Location = new System.Drawing.Point(131, 99);
            this.labelNomEquipEtVille.Name = "labelNomEquipEtVille";
            this.labelNomEquipEtVille.Size = new System.Drawing.Size(89, 13);
            this.labelNomEquipEtVille.TabIndex = 1;
            this.labelNomEquipEtVille.Text = "nomEquipeEtVille";
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelPlusMoinPoints);
            this.groupBoxStats.Controls.Add(this.labelAidesPoints);
            this.groupBoxStats.Controls.Add(this.labelButsPoints);
            this.groupBoxStats.Controls.Add(this.labelPlusMoins);
            this.groupBoxStats.Controls.Add(this.labelAides);
            this.groupBoxStats.Controls.Add(this.labelButs);
            this.groupBoxStats.Location = new System.Drawing.Point(25, 156);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(144, 155);
            this.groupBoxStats.TabIndex = 2;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statistiques";
            // 
            // labelPlusMoinPoints
            // 
            this.labelPlusMoinPoints.AutoSize = true;
            this.labelPlusMoinPoints.Location = new System.Drawing.Point(99, 111);
            this.labelPlusMoinPoints.Name = "labelPlusMoinPoints";
            this.labelPlusMoinPoints.Size = new System.Drawing.Size(65, 13);
            this.labelPlusMoinPoints.TabIndex = 8;
            this.labelPlusMoinPoints.Text = "nbrPlusMoin";
            // 
            // labelAidesPoints
            // 
            this.labelAidesPoints.AutoSize = true;
            this.labelAidesPoints.Location = new System.Drawing.Point(99, 72);
            this.labelAidesPoints.Name = "labelAidesPoints";
            this.labelAidesPoints.Size = new System.Drawing.Size(48, 13);
            this.labelAidesPoints.TabIndex = 7;
            this.labelAidesPoints.Text = "nbrAides";
            // 
            // labelButsPoints
            // 
            this.labelButsPoints.AutoSize = true;
            this.labelButsPoints.Location = new System.Drawing.Point(99, 35);
            this.labelButsPoints.Name = "labelButsPoints";
            this.labelButsPoints.Size = new System.Drawing.Size(43, 13);
            this.labelButsPoints.TabIndex = 6;
            this.labelButsPoints.Text = "nbrButs";
            // 
            // labelPlusMoins
            // 
            this.labelPlusMoins.AutoSize = true;
            this.labelPlusMoins.Location = new System.Drawing.Point(15, 111);
            this.labelPlusMoins.Name = "labelPlusMoins";
            this.labelPlusMoins.Size = new System.Drawing.Size(21, 13);
            this.labelPlusMoins.TabIndex = 5;
            this.labelPlusMoins.Text = "+/-";
            // 
            // labelAides
            // 
            this.labelAides.AutoSize = true;
            this.labelAides.Location = new System.Drawing.Point(15, 72);
            this.labelAides.Name = "labelAides";
            this.labelAides.Size = new System.Drawing.Size(33, 13);
            this.labelAides.TabIndex = 4;
            this.labelAides.Text = "Aides";
            // 
            // labelButs
            // 
            this.labelButs.AutoSize = true;
            this.labelButs.Location = new System.Drawing.Point(15, 35);
            this.labelButs.Name = "labelButs";
            this.labelButs.Size = new System.Drawing.Size(28, 13);
            this.labelButs.TabIndex = 3;
            this.labelButs.Text = "Buts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Poits au pool";
            // 
            // labelPointsPool
            // 
            this.labelPointsPool.AutoSize = true;
            this.labelPointsPool.Location = new System.Drawing.Point(118, 332);
            this.labelPointsPool.Name = "labelPointsPool";
            this.labelPointsPool.Size = new System.Drawing.Size(51, 13);
            this.labelPointsPool.TabIndex = 10;
            this.labelPointsPool.Text = "nbrPoints";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJoueur
            // 
            this.pictureBoxJoueur.Location = new System.Drawing.Point(313, 62);
            this.pictureBoxJoueur.Name = "pictureBoxJoueur";
            this.pictureBoxJoueur.Size = new System.Drawing.Size(294, 283);
            this.pictureBoxJoueur.TabIndex = 12;
            this.pictureBoxJoueur.TabStop = false;
            // 
            // pictureBoxEquipe
            // 
            this.pictureBoxEquipe.Location = new System.Drawing.Point(25, 62);
            this.pictureBoxEquipe.Name = "pictureBoxEquipe";
            this.pictureBoxEquipe.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxEquipe.TabIndex = 13;
            this.pictureBoxEquipe.TabStop = false;
            // 
            // FormFicheJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 409);
            this.Controls.Add(this.pictureBoxEquipe);
            this.Controls.Add(this.pictureBoxJoueur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPointsPool);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.labelNomEquipEtVille);
            this.Controls.Add(this.labelNometPos);
            this.Name = "FormFicheJoueur";
            this.Text = "Fiche de joueur";
            this.Load += new System.EventHandler(this.frmFicheJoueurLoad_Load);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNometPos;
        private System.Windows.Forms.Label labelNomEquipEtVille;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label labelPlusMoinPoints;
        private System.Windows.Forms.Label labelAidesPoints;
        private System.Windows.Forms.Label labelButsPoints;
        private System.Windows.Forms.Label labelPlusMoins;
        private System.Windows.Forms.Label labelAides;
        private System.Windows.Forms.Label labelButs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPointsPool;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxJoueur;
        private System.Windows.Forms.PictureBox pictureBoxEquipe;
    }
}
namespace TP_1_420_216_FX
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
            this.labelNometPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNometPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNometPos.Location = new System.Drawing.Point(201, 9);
            this.labelNometPos.Name = "labelNometPos";
            this.labelNometPos.Size = new System.Drawing.Size(189, 31);
            this.labelNometPos.TabIndex = 0;
            this.labelNometPos.Text = "nomEtPosition";
            // 
            // labelNomEquipEtVille
            // 
            this.labelNomEquipEtVille.AutoSize = true;
            this.labelNomEquipEtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEquipEtVille.Location = new System.Drawing.Point(131, 99);
            this.labelNomEquipEtVille.Name = "labelNomEquipEtVille";
            this.labelNomEquipEtVille.Size = new System.Drawing.Size(105, 13);
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
            this.groupBoxStats.Size = new System.Drawing.Size(144, 110);
            this.groupBoxStats.TabIndex = 2;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statistiques";
            // 
            // labelPlusMoinPoints
            // 
            this.labelPlusMoinPoints.AutoSize = true;
            this.labelPlusMoinPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusMoinPoints.Location = new System.Drawing.Point(73, 81);
            this.labelPlusMoinPoints.Name = "labelPlusMoinPoints";
            this.labelPlusMoinPoints.Size = new System.Drawing.Size(76, 13);
            this.labelPlusMoinPoints.TabIndex = 8;
            this.labelPlusMoinPoints.Text = "nbrPlusMoin";
            // 
            // labelAidesPoints
            // 
            this.labelAidesPoints.AutoSize = true;
            this.labelAidesPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAidesPoints.Location = new System.Drawing.Point(73, 57);
            this.labelAidesPoints.Name = "labelAidesPoints";
            this.labelAidesPoints.Size = new System.Drawing.Size(56, 13);
            this.labelAidesPoints.TabIndex = 7;
            this.labelAidesPoints.Text = "nbrAides";
            // 
            // labelButsPoints
            // 
            this.labelButsPoints.AutoSize = true;
            this.labelButsPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButsPoints.Location = new System.Drawing.Point(73, 35);
            this.labelButsPoints.Name = "labelButsPoints";
            this.labelButsPoints.Size = new System.Drawing.Size(50, 13);
            this.labelButsPoints.TabIndex = 6;
            this.labelButsPoints.Text = "nbrButs";
            // 
            // labelPlusMoins
            // 
            this.labelPlusMoins.AutoSize = true;
            this.labelPlusMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusMoins.Location = new System.Drawing.Point(15, 81);
            this.labelPlusMoins.Name = "labelPlusMoins";
            this.labelPlusMoins.Size = new System.Drawing.Size(32, 13);
            this.labelPlusMoins.TabIndex = 5;
            this.labelPlusMoins.Text = "+/- :";
            // 
            // labelAides
            // 
            this.labelAides.AutoSize = true;
            this.labelAides.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAides.Location = new System.Drawing.Point(15, 57);
            this.labelAides.Name = "labelAides";
            this.labelAides.Size = new System.Drawing.Size(46, 13);
            this.labelAides.TabIndex = 4;
            this.labelAides.Text = "Aides :";
            // 
            // labelButs
            // 
            this.labelButs.AutoSize = true;
            this.labelButs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButs.Location = new System.Drawing.Point(15, 35);
            this.labelButs.Name = "labelButs";
            this.labelButs.Size = new System.Drawing.Size(40, 13);
            this.labelButs.TabIndex = 3;
            this.labelButs.Text = "Buts :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(22, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Poits au pool :";
            // 
            // labelPointsPool
            // 
            this.labelPointsPool.AutoSize = true;
            this.labelPointsPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsPool.ForeColor = System.Drawing.Color.Maroon;
            this.labelPointsPool.Location = new System.Drawing.Point(134, 288);
            this.labelPointsPool.Name = "labelPointsPool";
            this.labelPointsPool.Size = new System.Drawing.Size(77, 17);
            this.labelPointsPool.TabIndex = 10;
            this.labelPointsPool.Text = "nbrPoints";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJoueur
            // 
            this.pictureBoxJoueur.Location = new System.Drawing.Point(291, 62);
            this.pictureBoxJoueur.Name = "pictureBoxJoueur";
            this.pictureBoxJoueur.Size = new System.Drawing.Size(316, 283);
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
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(642, 355);
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
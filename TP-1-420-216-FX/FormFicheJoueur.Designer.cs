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
            this.labelButs = new System.Windows.Forms.Label();
            this.labelAides = new System.Windows.Forms.Label();
            this.labelPlusMoins = new System.Windows.Forms.Label();
            this.labelButsPoints = new System.Windows.Forms.Label();
            this.labelAidesPoints = new System.Windows.Forms.Label();
            this.labelPlusMoinPoints = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxStats.SuspendLayout();
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
            this.labelNomEquipEtVille.Location = new System.Drawing.Point(124, 114);
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
            // labelButs
            // 
            this.labelButs.AutoSize = true;
            this.labelButs.Location = new System.Drawing.Point(15, 35);
            this.labelButs.Name = "labelButs";
            this.labelButs.Size = new System.Drawing.Size(28, 13);
            this.labelButs.TabIndex = 3;
            this.labelButs.Text = "Buts";
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
            // labelPlusMoins
            // 
            this.labelPlusMoins.AutoSize = true;
            this.labelPlusMoins.Location = new System.Drawing.Point(15, 111);
            this.labelPlusMoins.Name = "labelPlusMoins";
            this.labelPlusMoins.Size = new System.Drawing.Size(21, 13);
            this.labelPlusMoins.TabIndex = 5;
            this.labelPlusMoins.Text = "+/-";
            // 
            // labelButsPoints
            // 
            this.labelButsPoints.AutoSize = true;
            this.labelButsPoints.Location = new System.Drawing.Point(99, 35);
            this.labelButsPoints.Name = "labelButsPoints";
            this.labelButsPoints.Size = new System.Drawing.Size(35, 13);
            this.labelButsPoints.TabIndex = 6;
            this.labelButsPoints.Text = "label6";
            // 
            // labelAidesPoints
            // 
            this.labelAidesPoints.AutoSize = true;
            this.labelAidesPoints.Location = new System.Drawing.Point(99, 72);
            this.labelAidesPoints.Name = "labelAidesPoints";
            this.labelAidesPoints.Size = new System.Drawing.Size(35, 13);
            this.labelAidesPoints.TabIndex = 7;
            this.labelAidesPoints.Text = "label7";
            // 
            // labelPlusMoinPoints
            // 
            this.labelPlusMoinPoints.AutoSize = true;
            this.labelPlusMoinPoints.Location = new System.Drawing.Point(99, 111);
            this.labelPlusMoinPoints.Name = "labelPlusMoinPoints";
            this.labelPlusMoinPoints.Size = new System.Drawing.Size(35, 13);
            this.labelPlusMoinPoints.TabIndex = 8;
            this.labelPlusMoinPoints.Text = "label8";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "nbrPoints";
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
            // FormFicheJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.labelNomEquipEtVille);
            this.Controls.Add(this.labelNometPos);
            this.Name = "FormFicheJoueur";
            this.Text = "Fiche de joueur";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}
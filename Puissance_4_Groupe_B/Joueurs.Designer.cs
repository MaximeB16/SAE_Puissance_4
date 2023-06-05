
namespace Puissance_4_Groupe_B
{
    partial class Joueurs
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.btnJvIA = new System.Windows.Forms.Button();
            this.btnJvJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 406);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(105, 32);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblJoueur
            // 
            this.lblJoueur.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoueur.Location = new System.Drawing.Point(121, 9);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(526, 118);
            this.lblJoueur.TabIndex = 6;
            this.lblJoueur.Text = "Joueurs";
            this.lblJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJvIA
            // 
            this.btnJvIA.BackgroundImage = global::Puissance_4_Groupe_B.Properties.Resources.Joueur_VS_IA;
            this.btnJvIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJvIA.Location = new System.Drawing.Point(34, 130);
            this.btnJvIA.Name = "btnJvIA";
            this.btnJvIA.Size = new System.Drawing.Size(340, 233);
            this.btnJvIA.TabIndex = 9;
            this.btnJvIA.Tag = "b";
            this.btnJvIA.UseVisualStyleBackColor = true;
            this.btnJvIA.Click += new System.EventHandler(this.open_frmCouleurs);
            // 
            // btnJvJ
            // 
            this.btnJvJ.BackgroundImage = global::Puissance_4_Groupe_B.Properties.Resources.Joueur_VS_Joueur;
            this.btnJvJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJvJ.Location = new System.Drawing.Point(417, 130);
            this.btnJvJ.Name = "btnJvJ";
            this.btnJvJ.Size = new System.Drawing.Size(340, 233);
            this.btnJvJ.TabIndex = 10;
            this.btnJvJ.Tag = "a";
            this.btnJvJ.UseVisualStyleBackColor = true;
            this.btnJvJ.Click += new System.EventHandler(this.open_frmCouleurs);
            // 
            // Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJvJ);
            this.Controls.Add(this.btnJvIA);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.btnRetour);
            this.Name = "Joueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Joueurs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Button btnJvIA;
        private System.Windows.Forms.Button btnJvJ;
    }
}
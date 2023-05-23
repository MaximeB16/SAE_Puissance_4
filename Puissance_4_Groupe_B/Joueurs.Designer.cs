
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
            this.grpJvJ = new System.Windows.Forms.GroupBox();
            this.picJvJ = new System.Windows.Forms.PictureBox();
            this.grpJvIA = new System.Windows.Forms.GroupBox();
            this.picJvIA = new System.Windows.Forms.PictureBox();
            this.grpJvJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJvJ)).BeginInit();
            this.grpJvIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJvIA)).BeginInit();
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
            // grpJvJ
            // 
            this.grpJvJ.Controls.Add(this.picJvJ);
            this.grpJvJ.Location = new System.Drawing.Point(86, 130);
            this.grpJvJ.Name = "grpJvJ";
            this.grpJvJ.Size = new System.Drawing.Size(295, 239);
            this.grpJvJ.TabIndex = 7;
            this.grpJvJ.TabStop = false;
            this.grpJvJ.Text = "J vs J";
            // 
            // picJvJ
            // 
            this.picJvJ.Location = new System.Drawing.Point(7, 23);
            this.picJvJ.Name = "picJvJ";
            this.picJvJ.Size = new System.Drawing.Size(282, 210);
            this.picJvJ.TabIndex = 0;
            this.picJvJ.TabStop = false;
            this.picJvJ.Click += new System.EventHandler(this.open_frmCouleurs);
            // 
            // grpJvIA
            // 
            this.grpJvIA.Controls.Add(this.picJvIA);
            this.grpJvIA.Location = new System.Drawing.Point(403, 130);
            this.grpJvIA.Name = "grpJvIA";
            this.grpJvIA.Size = new System.Drawing.Size(294, 239);
            this.grpJvIA.TabIndex = 8;
            this.grpJvIA.TabStop = false;
            this.grpJvIA.Text = "J vs IA";
            // 
            // picJvIA
            // 
            this.picJvIA.Location = new System.Drawing.Point(7, 23);
            this.picJvIA.Name = "picJvIA";
            this.picJvIA.Size = new System.Drawing.Size(281, 210);
            this.picJvIA.TabIndex = 0;
            this.picJvIA.TabStop = false;
            this.picJvIA.Click += new System.EventHandler(this.open_frmCouleurs);
            // 
            // Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpJvIA);
            this.Controls.Add(this.grpJvJ);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.btnRetour);
            this.Name = "Joueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Joueurs_Load);
            this.grpJvJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picJvJ)).EndInit();
            this.grpJvIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picJvIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.GroupBox grpJvJ;
        private System.Windows.Forms.PictureBox picJvJ;
        private System.Windows.Forms.GroupBox grpJvIA;
        private System.Windows.Forms.PictureBox picJvIA;
    }
}
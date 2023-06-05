
namespace Puissance_4_Groupe_B
{
    partial class TailleGrille
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
            this.lblTailleGrille = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btn5x6 = new System.Windows.Forms.Button();
            this.btn7x9 = new System.Windows.Forms.Button();
            this.btn6x7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTailleGrille
            // 
            this.lblTailleGrille.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTailleGrille.Location = new System.Drawing.Point(128, 9);
            this.lblTailleGrille.Name = "lblTailleGrille";
            this.lblTailleGrille.Size = new System.Drawing.Size(526, 118);
            this.lblTailleGrille.TabIndex = 3;
            this.lblTailleGrille.Text = "Taille Grille";
            this.lblTailleGrille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 507);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(105, 32);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btn5x6
            // 
            this.btn5x6.BackgroundImage = global::Puissance_4_Groupe_B.Properties.Resources.Grille5x6;
            this.btn5x6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5x6.Location = new System.Drawing.Point(90, 150);
            this.btn5x6.Name = "btn5x6";
            this.btn5x6.Size = new System.Drawing.Size(211, 170);
            this.btn5x6.TabIndex = 5;
            this.btn5x6.Tag = "a";
            this.btn5x6.UseVisualStyleBackColor = true;
            this.btn5x6.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // btn7x9
            // 
            this.btn7x9.BackgroundImage = global::Puissance_4_Groupe_B.Properties.Resources.Grille7x9;
            this.btn7x9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7x9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7x9.Location = new System.Drawing.Point(479, 150);
            this.btn7x9.Name = "btn7x9";
            this.btn7x9.Size = new System.Drawing.Size(211, 166);
            this.btn7x9.TabIndex = 6;
            this.btn7x9.Tag = "b";
            this.btn7x9.UseVisualStyleBackColor = true;
            this.btn7x9.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // btn6x7
            // 
            this.btn6x7.BackgroundImage = global::Puissance_4_Groupe_B.Properties.Resources.Grille6x7;
            this.btn6x7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6x7.Location = new System.Drawing.Point(284, 341);
            this.btn6x7.Name = "btn6x7";
            this.btn6x7.Size = new System.Drawing.Size(211, 166);
            this.btn6x7.TabIndex = 7;
            this.btn6x7.Tag = "c";
            this.btn6x7.UseVisualStyleBackColor = true;
            this.btn6x7.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // TailleGrille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btn6x7);
            this.Controls.Add(this.btn7x9);
            this.Controls.Add(this.btn5x6);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTailleGrille);
            this.Name = "TailleGrille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TailleGrille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.TailleGrille_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTailleGrille;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btn5x6;
        private System.Windows.Forms.Button btn7x9;
        private System.Windows.Forms.Button btn6x7;
    }
}

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
            this.grp5x6 = new System.Windows.Forms.GroupBox();
            this.pic5x6 = new System.Windows.Forms.PictureBox();
            this.grp7x9 = new System.Windows.Forms.GroupBox();
            this.pic7x9 = new System.Windows.Forms.PictureBox();
            this.grp6x7 = new System.Windows.Forms.GroupBox();
            this.pic6x7 = new System.Windows.Forms.PictureBox();
            this.grp5x6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5x6)).BeginInit();
            this.grp7x9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic7x9)).BeginInit();
            this.grp6x7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic6x7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTailleGrille
            // 
            this.lblTailleGrille.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTailleGrille.Location = new System.Drawing.Point(123, 9);
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
            // grp5x6
            // 
            this.grp5x6.Controls.Add(this.pic5x6);
            this.grp5x6.Location = new System.Drawing.Point(59, 130);
            this.grp5x6.Name = "grp5x6";
            this.grp5x6.Size = new System.Drawing.Size(317, 189);
            this.grp5x6.TabIndex = 5;
            this.grp5x6.TabStop = false;
            this.grp5x6.Text = "5 x 6";
            // 
            // pic5x6
            // 
            this.pic5x6.Image = global::Puissance_4_Groupe_B.Properties.Resources.Grille5x6;
            this.pic5x6.Location = new System.Drawing.Point(7, 23);
            this.pic5x6.Name = "pic5x6";
            this.pic5x6.Size = new System.Drawing.Size(304, 160);
            this.pic5x6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5x6.TabIndex = 0;
            this.pic5x6.TabStop = false;
            this.pic5x6.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // grp7x9
            // 
            this.grp7x9.Controls.Add(this.pic7x9);
            this.grp7x9.Location = new System.Drawing.Point(397, 130);
            this.grp7x9.Name = "grp7x9";
            this.grp7x9.Size = new System.Drawing.Size(337, 189);
            this.grp7x9.TabIndex = 6;
            this.grp7x9.TabStop = false;
            this.grp7x9.Text = "7 x 9";
            // 
            // pic7x9
            // 
            this.pic7x9.Image = global::Puissance_4_Groupe_B.Properties.Resources.Grille7x9;
            this.pic7x9.Location = new System.Drawing.Point(6, 23);
            this.pic7x9.Name = "pic7x9";
            this.pic7x9.Size = new System.Drawing.Size(325, 160);
            this.pic7x9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic7x9.TabIndex = 0;
            this.pic7x9.TabStop = false;
            this.pic7x9.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // grp6x7
            // 
            this.grp6x7.Controls.Add(this.pic6x7);
            this.grp6x7.Location = new System.Drawing.Point(215, 325);
            this.grp6x7.Name = "grp6x7";
            this.grp6x7.Size = new System.Drawing.Size(337, 189);
            this.grp6x7.TabIndex = 7;
            this.grp6x7.TabStop = false;
            this.grp6x7.Text = "6 x 7";
            // 
            // pic6x7
            // 
            this.pic6x7.Image = global::Puissance_4_Groupe_B.Properties.Resources.Grille6x7;
            this.pic6x7.Location = new System.Drawing.Point(6, 23);
            this.pic6x7.Name = "pic6x7";
            this.pic6x7.Size = new System.Drawing.Size(324, 160);
            this.pic6x7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6x7.TabIndex = 0;
            this.pic6x7.TabStop = false;
            this.pic6x7.Click += new System.EventHandler(this.open_frmJoueurs);
            // 
            // TailleGrille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.grp6x7);
            this.Controls.Add(this.grp7x9);
            this.Controls.Add(this.grp5x6);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTailleGrille);
            this.Name = "TailleGrille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TailleGrille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.TailleGrille_Load);
            this.grp5x6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic5x6)).EndInit();
            this.grp7x9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic7x9)).EndInit();
            this.grp6x7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic6x7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTailleGrille;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox grp5x6;
        private System.Windows.Forms.PictureBox pic5x6;
        private System.Windows.Forms.GroupBox grp7x9;
        private System.Windows.Forms.PictureBox pic7x9;
        private System.Windows.Forms.GroupBox grp6x7;
        private System.Windows.Forms.PictureBox pic6x7;
    }
}
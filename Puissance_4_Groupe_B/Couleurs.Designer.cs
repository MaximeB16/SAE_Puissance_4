
namespace Puissance_4_Groupe_B
{
    partial class Couleurs
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
            this.lblCouleurs = new System.Windows.Forms.Label();
            this.picJ1 = new System.Windows.Forms.PictureBox();
            this.picJ2 = new System.Windows.Forms.PictureBox();
            this.lblMJ1 = new System.Windows.Forms.Label();
            this.lblMJ2 = new System.Windows.Forms.Label();
            this.lblPJ1 = new System.Windows.Forms.Label();
            this.lblPJ2 = new System.Windows.Forms.Label();
            this.rdoJ1 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 406);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(105, 32);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblCouleurs
            // 
            this.lblCouleurs.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCouleurs.Location = new System.Drawing.Point(40, 9);
            this.lblCouleurs.Name = "lblCouleurs";
            this.lblCouleurs.Size = new System.Drawing.Size(526, 118);
            this.lblCouleurs.TabIndex = 7;
            this.lblCouleurs.Text = "Couleurs";
            this.lblCouleurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picJ1
            // 
            this.picJ1.Image = global::Puissance_4_Groupe_B.Properties.Resources.PionRougeBase;
            this.picJ1.Location = new System.Drawing.Point(121, 227);
            this.picJ1.Name = "picJ1";
            this.picJ1.Size = new System.Drawing.Size(100, 100);
            this.picJ1.TabIndex = 8;
            this.picJ1.TabStop = false;
            // 
            // picJ2
            // 
            this.picJ2.Image = global::Puissance_4_Groupe_B.Properties.Resources.PionJauneBase;
            this.picJ2.Location = new System.Drawing.Point(405, 227);
            this.picJ2.Name = "picJ2";
            this.picJ2.Size = new System.Drawing.Size(100, 100);
            this.picJ2.TabIndex = 9;
            this.picJ2.TabStop = false;
            // 
            // lblMJ1
            // 
            this.lblMJ1.AutoSize = true;
            this.lblMJ1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMJ1.Location = new System.Drawing.Point(31, 227);
            this.lblMJ1.Name = "lblMJ1";
            this.lblMJ1.Size = new System.Drawing.Size(84, 89);
            this.lblMJ1.TabIndex = 10;
            this.lblMJ1.Tag = "a";
            this.lblMJ1.Text = "<";
            this.lblMJ1.Click += new System.EventHandler(this.update_pion);
            // 
            // lblMJ2
            // 
            this.lblMJ2.AutoSize = true;
            this.lblMJ2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMJ2.Location = new System.Drawing.Point(315, 227);
            this.lblMJ2.Name = "lblMJ2";
            this.lblMJ2.Size = new System.Drawing.Size(84, 89);
            this.lblMJ2.TabIndex = 11;
            this.lblMJ2.Tag = "c";
            this.lblMJ2.Text = "<";
            this.lblMJ2.Click += new System.EventHandler(this.update_pion);
            // 
            // lblPJ1
            // 
            this.lblPJ1.AutoSize = true;
            this.lblPJ1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPJ1.Location = new System.Drawing.Point(227, 227);
            this.lblPJ1.Name = "lblPJ1";
            this.lblPJ1.Size = new System.Drawing.Size(84, 89);
            this.lblPJ1.TabIndex = 12;
            this.lblPJ1.Tag = "b";
            this.lblPJ1.Text = ">";
            this.lblPJ1.Click += new System.EventHandler(this.update_pion);
            // 
            // lblPJ2
            // 
            this.lblPJ2.AutoSize = true;
            this.lblPJ2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPJ2.Location = new System.Drawing.Point(511, 227);
            this.lblPJ2.Name = "lblPJ2";
            this.lblPJ2.Size = new System.Drawing.Size(84, 89);
            this.lblPJ2.TabIndex = 13;
            this.lblPJ2.Tag = "d";
            this.lblPJ2.Text = ">";
            this.lblPJ2.Click += new System.EventHandler(this.update_pion);
            // 
            // rdoJ1
            // 
            this.rdoJ1.AutoSize = true;
            this.rdoJ1.Checked = true;
            this.rdoJ1.Location = new System.Drawing.Point(101, 192);
            this.rdoJ1.Name = "rdoJ1";
            this.rdoJ1.Size = new System.Drawing.Size(14, 13);
            this.rdoJ1.TabIndex = 14;
            this.rdoJ1.TabStop = true;
            this.rdoJ1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(511, 192);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nom J1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Nom J2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Connor";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Couleurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdoJ1);
            this.Controls.Add(this.lblPJ2);
            this.Controls.Add(this.lblPJ1);
            this.Controls.Add(this.lblMJ2);
            this.Controls.Add(this.lblMJ1);
            this.Controls.Add(this.picJ2);
            this.Controls.Add(this.picJ1);
            this.Controls.Add(this.lblCouleurs);
            this.Controls.Add(this.btnRetour);
            this.Name = "Couleurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Couleurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Couleurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblCouleurs;
        private System.Windows.Forms.PictureBox picJ1;
        private System.Windows.Forms.PictureBox picJ2;
        private System.Windows.Forms.Label lblMJ1;
        private System.Windows.Forms.Label lblMJ2;
        private System.Windows.Forms.Label lblPJ1;
        private System.Windows.Forms.Label lblPJ2;
        private System.Windows.Forms.RadioButton rdoJ1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
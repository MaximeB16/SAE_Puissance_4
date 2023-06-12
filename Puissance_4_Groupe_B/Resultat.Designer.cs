
namespace Puissance_4_Groupe_B
{
    partial class Resultat
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
            btnQuitter = new System.Windows.Forms.Button();
            btnNewGame = new System.Windows.Forms.Button();
            lbl1 = new System.Windows.Forms.Label();
            lbl2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnQuitter
            // 
            btnQuitter.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuitter.Location = new System.Drawing.Point(408, 364);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new System.Drawing.Size(369, 62);
            btnQuitter.TabIndex = 1;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNewGame.Location = new System.Drawing.Point(22, 364);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new System.Drawing.Size(369, 62);
            btnNewGame.TabIndex = 2;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += button3_Click;
            // 
            // lbl1
            // 
            lbl1.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl1.Location = new System.Drawing.Point(55, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(281, 66);
            lbl1.TabIndex = 3;
            lbl1.Text = "Victoire de";
            // 
            // lbl2
            // 
            lbl2.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl2.Location = new System.Drawing.Point(113, 137);
            lbl2.Name = "lbl2";
            lbl2.Size = new System.Drawing.Size(581, 199);
            lbl2.TabIndex = 4;
            lbl2.Text = "Victoire de";
            lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnNewGame);
            Controls.Add(btnQuitter);
            Name = "Resultat";
            Text = "Resultat";
            Load += Resultat_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}
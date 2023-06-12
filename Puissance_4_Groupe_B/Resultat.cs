using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeu;

namespace Puissance_4_Groupe_B
{
    public partial class Resultat : Form
    {
        internal bool mode_sombre;
        internal Couleurs FrmParam;
        internal Grille PartieSuivante;

        public Resultat()
        {
            InitializeComponent();
        }

        private void Resultat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmParam.Show();
        }

        private void Resultat_Load_1(object sender, EventArgs e)
        {
            FrmParam = (Couleurs)this.Owner.Owner;
            mode_sombre = FrmParam.mode_sombre;
            FrmParam.Hide();
            PartieSuivante = FrmParam.PartieSuivante;
            if (FrmParam.fin == -1)
            {
                lbl1.Visible = false;
                lbl2.Text = "MATCH NUL";
            }
            else
            {
                lbl1.Visible = true;
                if (!FrmParam.PartieSuivante.get_Tour())
                {
                    lbl2.Text = FrmParam.PartieSuivante.get_NomJ1();
                }
                else
                {
                    lbl2.Text = FrmParam.PartieSuivante.get_NomJ2();
                }
            }
            if (mode_sombre)
            {
                this.BackColor = Color.FromArgb(29, 29, 29);
                foreach (Control sect in this.Controls)
                {
                    sect.ForeColor = Color.FromArgb(240, 240, 240);
                    sect.BackColor = Color.FromArgb(29, 29, 29);
                }
            }
            else
            {
                this.BackColor = Color.White;
                foreach (Control sect in this.Controls)
                {
                    sect.ForeColor = Color.Black;
                    sect.BackColor = Color.White;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}

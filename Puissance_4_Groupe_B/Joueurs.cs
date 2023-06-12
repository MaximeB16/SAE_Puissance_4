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
    public partial class Joueurs : Form
    {
        internal TailleGrille FrmParam;
        internal Grille PartieSuivante;
        internal bool mode_sombre;

        public Joueurs()
        {
            InitializeComponent();
        }

        private void Joueurs_Load(object sender, EventArgs e)
        {
            FrmParam = (TailleGrille)this.Owner;
            mode_sombre = FrmParam.mode_sombre;
            FrmParam.Hide();
            PartieSuivante = FrmParam.PartieSuivante;
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

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            FrmParam.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_frmCouleurs(object sender, EventArgs e)
        {
            
            Button tmpPic = (Button)sender;
            if (tmpPic.Tag.ToString() == "b")
            {
                PartieSuivante.update_NbJ(1);
            }
            else if (tmpPic.Tag.ToString() == "a")
            {
                PartieSuivante.update_NbJ(2);
            }
            Couleurs frmC = new Couleurs();
            frmC.Show(this);
        }
    }
}

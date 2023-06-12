using System;
using Jeu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_4_Groupe_B
{
    public partial class TailleGrille : Form
    {
        internal FrmMenu Menu = new FrmMenu();
        internal Grille PartieSuivante;
        internal bool mode_sombre;
        public TailleGrille()
        {
            InitializeComponent();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_frmJoueurs(object sender, EventArgs e)
        {
            int l;
            int c;
            Button tmpbtn = (Button)sender;
            if (tmpbtn.Tag.ToString() == "a")
            {
                l = 5;
                c = 6;
            }
            else if (tmpbtn.Tag.ToString() == "c")
            {
                l = 6;
                c = 7;
            }
            else
            {
                l = 7;
                c = 9;
            }
            PartieSuivante = new Grille(l, c);
            Joueurs frmJ = new Joueurs();
            frmJ.Show(this);
        }

        private void TailleGrille_Load(object sender, EventArgs e)
        {
            Menu = (FrmMenu)this.Owner;
            mode_sombre = Menu.mode_sombre;
            this.Owner.Hide();
            if (Menu.mode_sombre)
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
    }
}
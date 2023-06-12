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
    public partial class TailleS : Form
    {
        internal Couleurs FrmParam;
        internal Grille PartieSuivante;
        internal bool mode_sombre;

        public TailleS()
        {
            InitializeComponent();
        }

        private void TailleS_Load(object sender, EventArgs e)
        {
            FrmParam = (Couleurs)this.Owner;
            FrmParam.Hide();
            mode_sombre = FrmParam.mode_sombre;
            PartieSuivante = FrmParam.PartieSuivante;
            PartieSuivante.restart();
            picJ1.Image = FrmParam.Pions_Basique[FrmParam.pion1];
            picJ2.Image = FrmParam.Pions_Basique[FrmParam.pion2];
            lblJ1.Text = PartieSuivante.get_NomJ(0);
            lblJ2.Text = PartieSuivante.get_NomJ(1);
            if (mode_sombre)
            {
                this.BackColor = Color.FromArgb(29, 29, 29);
                lblJ1.ForeColor = Color.FromArgb(240, 240, 240);
                lblJ2.ForeColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                this.BackColor = Color.White;
                lblJ1.ForeColor = Color.Black;
                lblJ2.ForeColor = Color.Black;
            }
        }

        private void Coup(int c)
        {
            Couleurs FrmParam = (Couleurs)this.Owner;
            Bitmap pionJ1 = FrmParam.Pions_Basique[FrmParam.pion1];
            Bitmap pionJ2 = FrmParam.Pions_Basique[FrmParam.pion2];
            PictureBox[,] GrilleJeu = { { pic00, pic01, pic02, pic03, pic04, pic05 }, { pic10, pic11, pic12, pic13, pic14, pic15 }, { pic20, pic21, pic22, pic23, pic24, pic25 }, { pic30, pic31, pic32, pic33, pic34, pic35 }, { pic40, pic41, pic42, pic43, pic44, pic45 } };
            if (PartieSuivante.case_la_plus_basse(c) >= 0)
            {
                if (PartieSuivante.get_Tour())
                {
                    GrilleJeu[PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ1;
                }
                else
                {
                    GrilleJeu[PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ2;
                }
                int fin = PartieSuivante.coup(c);
                if (fin != 0)
                {
                    Resultat frmR = new Resultat();
                    frmR.Show(this);
                }
            }
        }

        private void RecupCoo(object sender, MouseEventArgs e)
        {
            int CoordXSouris = e.X;

            int colonne = 0;

            while (CoordXSouris > colonne * pnl1.Size.Width / 6)
            {
                colonne += 1;
            }
            colonne -= 1;
            Coup(colonne);
        }

        private void RecupCooPictureBox(object sender, MouseEventArgs e)
        {
            PictureBox tmplbl = (PictureBox)sender;

            int CoordXLabel = tmplbl.Location.X;

            int CoordXSouris = e.X;

            int colonne = 0;

            while (CoordXSouris + CoordXLabel > colonne * pnl1.Size.Width / 6)
            {
                colonne += 1;
            }
            colonne -= 1;
            Coup(colonne);
        }

        private void TailleS_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmParam.Show();
        }
    }
}

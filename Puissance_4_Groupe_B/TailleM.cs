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
    public partial class TailleM : Form
    {
        internal Couleurs FrmParam;
        internal Grille PartieSuivante;

        public TailleM()
        {
            InitializeComponent();
        }

        private void Coup(int c)
        {
            Bitmap pionJ1 = FrmParam.Pions_Basique[FrmParam.pion1];
            Bitmap pionJ2 = FrmParam.Pions_Basique[FrmParam.pion2];
            PictureBox[,] GrilleJeu = { { pic00, pic01, pic02, pic03, pic04, pic05, pic06 }, { pic10, pic11, pic12, pic13, pic14, pic15, pic16 }, { pic20, pic21, pic22, pic23, pic24, pic25, pic26 }, { pic30, pic31, pic32, pic33, pic34, pic35, pic36 }, { pic40, pic41, pic42, pic43, pic44, pic45, pic46 }, { pic50, pic51, pic52, pic53, pic54, pic55, pic56 } };
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

        private void TailleM_Load(object sender, EventArgs e)
        {
            Couleurs FrmParam = (Couleurs)Owner;
            FrmParam.Hide();
            PartieSuivante = FrmParam.PartieSuivante;
            PartieSuivante.restart();
            picJ1.Image = FrmParam.Pions_Basique[FrmParam.pion1];
            picJ2.Image = FrmParam.Pions_Basique[FrmParam.pion2];
            lblJ1.Text = PartieSuivante.get_NomJ1();
            lblJ2.Text = PartieSuivante.get_NomJ2();
        }

        private void RecupCoo(object sender, MouseEventArgs e)
        {
            int CoordXSouris = e.X;

            int colonne = 0;

            while (CoordXSouris > colonne * pnl1.Size.Width / 7)
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

            while (CoordXSouris + CoordXLabel > colonne * pnl1.Size.Width / 7)
            {
                colonne += 1;
            }
            colonne -= 1;
            Coup(colonne);
        }

        private void TailleM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmParam.Show();
        }
    }
}

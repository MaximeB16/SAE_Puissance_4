using System;
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
    public partial class TailleL : Form
    {
        internal Couleurs FrmParam;
        public TailleL()
        {
            InitializeComponent();
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            FrmParam = (Couleurs)this.Owner;
            Couleurs FrmPion = (Couleurs)Owner;
            this.Owner.Hide();
            FrmParam.FrmParam.FrmParam.PartieSuivante.restart();
            picJ1.Image = FrmPion.Pions_Basique[FrmPion.pion1];
            picJ2.Image = FrmPion.Pions_Basique[FrmPion.pion2];
            lblJ1.Text = FrmParam.FrmParam.FrmParam.PartieSuivante.get_NomJ1();
            lblJ2.Text = FrmParam.FrmParam.FrmParam.PartieSuivante.get_NomJ2();
        }

        private void Coup(int c)
        {
            Couleurs FrmPion = (Couleurs)this.Owner;
            System.Drawing.Bitmap pionJ1 = FrmPion.Pions_Basique[FrmPion.pion1];
            System.Drawing.Bitmap pionJ2 = FrmPion.Pions_Basique[FrmPion.pion2];
            PictureBox[,] GrilleJeu = { { pic00, pic01, pic02, pic03, pic04, pic05, pic06, pic07, pic08 }, { pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18 }, { pic20, pic21, pic22, pic23, pic24, pic25, pic26, pic27, pic28 }, { pic30, pic31, pic32, pic33, pic34, pic35, pic36, pic37, pic38 }, { pic40, pic41, pic42, pic43, pic44, pic45, pic46, pic47, pic48 }, { pic50, pic51, pic52, pic53, pic54, pic55, pic56, pic57, pic58 }, { pic60, pic61, pic62, pic63, pic64, pic65, pic66, pic67, pic68 } };
            if (FrmParam.FrmParam.FrmParam.PartieSuivante.case_la_plus_basse(c) >= 0)
            {
                if (FrmParam.FrmParam.FrmParam.PartieSuivante.get_Tour())
                {
                    GrilleJeu[FrmParam.FrmParam.FrmParam.PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ1;
                }
                else
                {
                    GrilleJeu[FrmParam.FrmParam.FrmParam.PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ2;
                }
                int fin = FrmParam.FrmParam.FrmParam.PartieSuivante.coup(c);
                if (fin != 0)
                {
                    Resultat frmR = new Resultat();
                    frmR.Show(this);
                }
            }
        }

        private void TailleL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void RecupCoo(object sender, MouseEventArgs e)
        {
            int CoordXSouris = e.X;

            int colonne = 0;

            while (CoordXSouris > colonne * pnl1.Size.Width / 9)
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

            while (CoordXSouris + CoordXLabel > colonne * pnl1.Size.Width / 9)
            {
                colonne += 1;
            }
            colonne -= 1;
            Coup(colonne);
        }
    }
}

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
        internal Couleurs FrmParam = new Couleurs();
        internal Grille PartieSuivante;
        internal bool mode_sombre;
        internal IA ia;


        public TailleM()
        {
            InitializeComponent();
            ia = new IA(PartieSuivante);
        }
        private void Coup(int c)
        {
            ia.UpdateGrille(PartieSuivante);
            Couleurs FrmParam = (Couleurs)this.Owner;
            System.Drawing.Bitmap pionJ1 = FrmParam.Pions_Basique[FrmParam.pion1];
            System.Drawing.Bitmap pionJ2 = FrmParam.Pions_Basique[FrmParam.pion2];
            PictureBox[,] GrilleJeu = { { pic00, pic01, pic02, pic03, pic04, pic05, pic06 }, { pic10, pic11, pic12, pic13, pic14, pic15, pic16 }, { pic20, pic21, pic22, pic23, pic24, pic25, pic26 }, { pic30, pic31, pic32, pic33, pic34, pic35, pic36 }, { pic40, pic41, pic42, pic43, pic44, pic45, pic46 }, { pic50, pic51, pic52, pic53, pic54, pic55, pic56 } };
            if (PartieSuivante.case_la_plus_basse(c) >= 0)
            {
                if (PartieSuivante.get_Tour())
                {

                    GrilleJeu[PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ1;
                    FrmParam.fin = PartieSuivante.coup(c);
                    if (FrmParam.fin == 4 || FrmParam.fin == 0)
                    {
                        Resultat frmR = new Resultat();
                        frmR.Show(this);
                    }
                }
                else
                {
                    if (PartieSuivante.get_Nb_Joueurs() == 2)
                    {

                        GrilleJeu[PartieSuivante.case_la_plus_basse(c), c].BackgroundImage = pionJ2;
                        FrmParam.fin = PartieSuivante.coup(c);
                        if (FrmParam.fin == 4 || FrmParam.fin == 0)
                        {
                            Resultat frmR = new Resultat();
                            frmR.Show(this);
                        }
                    }
                }
                PartieSuivante.update_case_basse(c);

                if (PartieSuivante.get_Nb_Joueurs() == 1 && FrmParam.fin != 4)
                {
                    Random random = new Random();
                    int coupAJouer = ia.JouerUnCoupFictif(6,PartieSuivante.get_Tour(),random.Next(PartieSuivante.get_Colonnes()),1);
                    FrmParam.fin = PartieSuivante.coup(coupAJouer);

                    GrilleJeu[PartieSuivante.case_la_plus_basse(coupAJouer), coupAJouer].BackgroundImage = pionJ2;
                    PartieSuivante.update_case_basse(coupAJouer);
                    if (FrmParam.fin == 4 || FrmParam.fin == 0)
                    {
                        Resultat frmR = new Resultat();
                        frmR.Show(this);
                    }
                }
            }
            ia.UpdateGrille(PartieSuivante);
        }

        private void TailleM_Load(object sender, EventArgs e)
        {
            Couleurs FrmParam = (Couleurs)this.Owner;
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
            PictureBox[,] GrilleJeu = { { pic00, pic01, pic02, pic03, pic04, pic05, pic06 }, { pic10, pic11, pic12, pic13, pic14, pic15, pic16 }, { pic20, pic21, pic22, pic23, pic24, pic25, pic26 }, { pic30, pic31, pic32, pic33, pic34, pic35, pic36 }, { pic40, pic41, pic42, pic43, pic44, pic45, pic46 }, { pic50, pic51, pic52, pic53, pic54, pic55, pic56 } };

            for (int i=0; i <6; i++)
            {
                for(int j = 0; j <7; j++)
                {
                    GrilleJeu[i, j].MouseClick += RecupCooPictureBox;
                }
            }
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
            this.Owner.Show();
        }

        private void picJ2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Couleurs : Form
    {
        internal Joueurs FrmParam;
        internal Grille PartieSuivante;
        internal Bitmap[] Pions_Basique = { Properties.Resources.PionRougeBase, Properties.Resources.PionJauneBase, Properties.Resources.PionCyanBase, Properties.Resources.PionBleuBase, Properties.Resources.PionRoseBase, Properties.Resources.PionVertBase, Properties.Resources.PionVertClaireBase, Properties.Resources.PionVioletBase };
        internal int pion1 = 0;
        internal int pion2 = 1;

        public Couleurs()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Couleurs_Load(object sender, EventArgs e)
        {
            FrmParam = (Joueurs)this.Owner;
            FrmParam.Hide();
            PartieSuivante = FrmParam.PartieSuivante;
            if (PartieSuivante.get_Nb_Joueurs() == 2)
            {
                txtNomJ2.ReadOnly = false;
            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void update_pion(object sender, EventArgs e)
        {
            Label lblTemp = (Label)sender;
            if( lblTemp.Tag.ToString()=="a")
            {
                if (pion1 == 0)
                {
                    pion1 = 7;
                }
                else
                {
                    pion1 -= 1;
                }
                picJ1.Image = Pions_Basique[pion1];
            }else if(lblTemp.Tag.ToString() == "b")
            {
                if (pion1 == 7)
                {
                    pion1 = 0;
                }
                else
                {
                    pion1 += 1;
                }
                picJ1.Image = Pions_Basique[pion1];
            }
            else if (lblTemp.Tag.ToString() == "c")
            {
                if (pion2 == 0)
                {
                    pion2 = 7;
                }
                else
                {
                    pion2 -= 1;
                }
                picJ2.Image = Pions_Basique[pion2];
            }
            else if (lblTemp.Tag.ToString() == "d")
            {
                if (pion2 == 7)
                {
                    pion2 = 0;
                }
                else
                {
                    pion2 += 1;
                }
                picJ2.Image = Pions_Basique[pion2];
            }
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            if (pion1 != pion2 && txtNomJ1.Text != txtNomJ2.Text)
            {
                PartieSuivante.update_NomJ(txtNomJ1.Text, txtNomJ2.Text);

                PartieSuivante.set_tour(rdoJ1.Checked);

                if (PartieSuivante.get_Lignes() == 4)
                {
                    TailleS FrmJ = new TailleS();
                    FrmJ.Show(this);
                }
                else if (PartieSuivante.get_Lignes() == 5)
                {
                    TailleM FrmJ = new TailleM();
                    FrmJ.Show(this);
                }
                else if (PartieSuivante.get_Lignes() == 6)
                {
                    TailleL FrmJ = new TailleL();
                    FrmJ.Show(this);
                }
            }
        }
    }
}

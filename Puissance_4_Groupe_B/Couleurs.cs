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
    public partial class Couleurs : Form
    {
        System.Drawing.Bitmap[] Pions_Basique = { Properties.Resources.PionRougeBase, Properties.Resources.PionJauneBase, Properties.Resources.PionCyanBase, Properties.Resources.PionBleuBase, Properties.Resources.PionRoseBase, Properties.Resources.PionVertBase, Properties.Resources.PionVertClaireBase, Properties.Resources.PionVioletBase };
        int pion1 = 0;
        int pion2 = 0;

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
            this.Owner.Hide();
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

    }
}

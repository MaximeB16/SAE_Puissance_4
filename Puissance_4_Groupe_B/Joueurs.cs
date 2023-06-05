﻿using System;
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
    public partial class Joueurs : Form
    {
        internal TailleGrille FrmParam;
        public Joueurs()
        {
            InitializeComponent();
        }

        private void Joueurs_Load(object sender, EventArgs e)
        {
            FrmParam = (TailleGrille)this.Owner;
            this.Owner.Hide();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
                FrmParam.PartieSuivante.update_NbJ(1);
            }
            else if (tmpPic.Tag.ToString() == "a")
            {
                FrmParam.PartieSuivante.update_NbJ(2);
            }
            Couleurs frmC = new Couleurs();
            frmC.Show(this);
        }
    }
}

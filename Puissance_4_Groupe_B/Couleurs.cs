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
    public partial class Couleurs : Form
    {
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
    }
}

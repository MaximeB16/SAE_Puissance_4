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
    public partial class Resultat : Form
    {
        internal Couleurs FrmParam;
        internal Grille PartieSuivante;

        public Resultat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartieSuivante.restart();
            this.Close();
        }

        private void Resultat_Load(object sender, EventArgs e)
        {
            FrmParam = (Couleurs)this.Owner;
            FrmParam.Hide();
            PartieSuivante = FrmParam.PartieSuivante;
        }

        private void Resultat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmParam.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Joueurs : Form
    {
        public Joueurs()
        {
            InitializeComponent();
        }

        private void Joueurs_Load(object sender, EventArgs e)
        {
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
            Couleurs frmC = new Couleurs();
            frmC.Show(this);
        }
    }
}

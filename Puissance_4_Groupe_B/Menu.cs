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
    public partial class FrmMenu : Form
    {
        internal bool mode_sombre = false;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            TailleGrille frmTG = new TailleGrille();
            frmTG.Show(this);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode_sombre = !mode_sombre;
            if (mode_sombre)
            {
                this.BackColor = Color.FromArgb(29, 29, 29);
                foreach(Control sect in this.Controls)
                {
                    sect.ForeColor = Color.FromArgb(240, 240, 240);
                    sect.BackColor = Color.FromArgb(29, 29, 29);
                }
                button1.BackColor = Color.FromArgb(240, 240, 240);
                button1.ForeColor = Color.FromArgb(29, 29, 29);
            }
            else
            {
                this.BackColor = Color.White;
                foreach (Control sect in this.Controls)
                {
                    sect.ForeColor = Color.Black;
                    sect.BackColor = Color.White;
                }
                button1.BackColor = Color.FromArgb(29, 29, 29);
                button1.ForeColor = Color.White;
            }
        }
    }
}

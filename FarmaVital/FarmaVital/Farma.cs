using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaVital
{
    public partial class Farma : Form
    {
   

        public Farma()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqClieFarma clie = new PesqClieFarma();
            this.Hide();
            clie.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesqMedFarma md = new PesqMedFarma();
            this.Hide();
            md.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Farma_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Caixa f = new Caixa();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrnLogin lg = new FrnLogin();
            this.Hide();
            lg.ShowDialog();
        }
    }
}

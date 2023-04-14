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
    public partial class FrmMenuadm : Form
    {

        

        public FrmMenuadm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PesqFabricante fabri = new PesqFabricante();
            this.Hide();
            fabri.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PesqFuncionarios fnc = new PesqFuncionarios();
            this.Hide();
            fnc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesqCliente clie = new PesqCliente();
            this.Hide();
            clie.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesqMedicamentos med = new PesqMedicamentos();
            this.Hide();
            med.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //AbrirForm(new FrmFabricante(), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void DesativarBtn()
        {
           
        }


        private void FrmMenuadm_Load(object sender, EventArgs e)
        {

        }

        private void panelMENU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FrnLogin lg = new FrnLogin();
            this.Hide();
            lg.ShowDialog();
        }
    }
}

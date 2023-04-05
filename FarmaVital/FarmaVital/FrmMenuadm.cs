using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            FrmMedicamentos med = new FrmMedicamentos();
            this.Hide();
            med.ShowDialog();
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionarios func = new FrmFuncionarios();
            this.Hide();
            func.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PesqFabricante fabri = new PesqFabricante();
            this.Hide();
            fabri.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PesqFuncionarios func = new PesqFuncionarios();
            this.Hide();
            func.ShowDialog();
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
           
        }
    }
}

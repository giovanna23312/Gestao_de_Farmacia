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
            FrmFabricante fabri = new FrmFabricante();
            this.Hide();
            fabri.ShowDialog();

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
    }
}

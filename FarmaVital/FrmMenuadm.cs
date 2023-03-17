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
            FrmFornecedores forne = new FrmFornecedores();
            this.Hide();
            forne.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente clie = new FrmCliente();
            this.Hide();
            clie.ShowDialog();
        }
    }
}

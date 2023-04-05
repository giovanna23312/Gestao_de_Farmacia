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
    public partial class PesqMedFarma : Form
    {
        public PesqMedFarma()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Farma menu = new Farma();
            this.Hide();
            menu.ShowDialog();
        }

        private void PesqMedFarma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMedicamentos med = new FrmMedicamentos();
            this.Hide();
            med.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                medicamentosBindingSource.Filter = "";
            }
            else
            {
                medicamentosBindingSource.Filter = string.Format("Med_NMed like'%{0}%'", textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            AlterClientes clie = new AlterClientes();
            this.Hide();
            clie.ShowDialog();
        }
    }
}

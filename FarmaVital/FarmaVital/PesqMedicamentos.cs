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
    public partial class PesqMedicamentos : Form
    {
        public PesqMedicamentos()
        {
            InitializeComponent();
        }

        private void PesqMedicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamento'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentoTableAdapter.Fill(this.farmaDataSet.medicamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                medicamentosBindingSource.Filter = "";
            }
            else
            {
                medicamentosBindingSource.Filter = string.Format("Med_nmMed like'%{0}%'", textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuadm adm = new FrmMenuadm();
            this.Hide();
            adm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMedADM med = new FrmMedADM();
            this.Hide();
            med.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                medicamentosBindingSource.Filter = "";
            }
            else
            {
                medicamentosBindingSource.Filter = string.Format("Med_nmMed like'%{0}%'", textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

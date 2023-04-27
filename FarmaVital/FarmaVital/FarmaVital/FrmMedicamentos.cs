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
    public partial class FrmMedicamentos : Form
    {
        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            medicamentosBindingSource.AddNew();

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            medicamentosBindingSource.EndEdit();
            medicamentosTableAdapter.Update(farmaDataSet.medicamentos);
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            medicamentosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show("Medicametos cadastrados com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //chamar um novo registro
            medicamentosBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqMedicamentos med = new PesqMedicamentos();
            this.Hide();
            med.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesqMedFarma med = new PesqMedFarma();
            this.Hide();
            med.ShowDialog();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PesqMedFarma pesq = new PesqMedFarma();
            this.Hide();
            pesq.ShowDialog();
        }
    }
}

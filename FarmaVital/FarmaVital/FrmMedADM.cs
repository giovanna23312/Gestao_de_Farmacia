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
    public partial class FrmMedADM : Form
    {
        public FrmMedADM()
        {
            InitializeComponent();
        }

        private void FrmMedADM_Load(object sender, EventArgs e)
        {
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



        private void button4_Click(object sender, EventArgs e)
        {
            PesqMedicamentos med = new PesqMedicamentos();
            this.Hide();
            med.ShowDialog();
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
    }
}

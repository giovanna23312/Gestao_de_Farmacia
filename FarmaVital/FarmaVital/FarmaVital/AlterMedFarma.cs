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
    public partial class AlterMedFarma : Form
    {
        public AlterMedFarma()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesqMedFarma med = new PesqMedFarma();
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
            MessageBox.Show("Medicametos Alterados com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //chamar um novo registro
            medicamentosBindingSource.AddNew();
        }

        private void AlterMedFarma_Load(object sender, EventArgs e)
        {
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            if (Class1.codigo == "")
            { medicamentosBindingSource.AddNew(); }
            else
            { medicamentosBindingSource.Filter = string.Format("Med_cod={0}", Class1.codigo); }
        }
    }
}

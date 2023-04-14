using FarmaVital.FarmaDataSetTableAdapters;
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
    public partial class AlterMedADM : Form
    {
        public AlterMedADM()
        {
            InitializeComponent();
        }

        private void AlterMedADM_Load(object sender, EventArgs e)
        {
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            if (Class1.codigo == "")
            { medicamentosBindingSource.AddNew(); }
            else
            { medicamentosBindingSource.Filter = string.Format("Med_cod={0}", Class1.codigo); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Validate();
            medicamentosBindingSource.EndEdit();
            medicamentosTableAdapter.Update(farmaDataSet.medicamentos);
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);
            medicamentosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            //  MessageBox.Show(" alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Medicamentos alterados com sucesso\", \"Ok\", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);\r\n sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            PesqMedicamentos pesq = new PesqMedicamentos();
            this.Hide();
            pesq.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqMedicamentos pesq = new PesqMedicamentos();
            this.Hide();
            pesq.ShowDialog();
        }
    }
}

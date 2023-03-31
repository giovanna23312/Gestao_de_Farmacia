using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaVital
{
    public partial class PesquisarFabri : Form
    {
        public PesquisarFabri()
        {
            InitializeComponent();
        }

        private void PesquisarFabri_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
            if (Class1.codigo == "")
            { fabricanteBindingSource.AddNew(); }
            else
            { fabricanteBindingSource.Filter = string.Format("fabri_cd={0}", Class1.codigo); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            fabricanteBindingSource.EndEdit();
            fabricanteTableAdapter.Update(farmaDataSet.fabricante);
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
            fabricanteBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoas Fisicas alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            textBox7.Focus();

            AlterFabricante pesq = new AlterFabricante();
            this.Hide();
            pesq.ShowDialog();
        }
    }
}

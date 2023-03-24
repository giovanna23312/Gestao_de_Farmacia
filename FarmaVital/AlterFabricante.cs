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
    public partial class AlterFabricante : Form
    {
        public AlterFabricante()
        {
            InitializeComponent();
        }

        private void AlterFabricante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fabricanteBindingSource.Filter = string.Format("fabri_CD={0}"
              , textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                fabricanteBindingSource.Filter = "";
            }
            else
            {
                fabricanteBindingSource.Filter = string.Format("fabri_nmfan like'%{0}%'", textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            PesquisarFabri pesq = new PesquisarFabri();
            pesq.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            PesquisarFabri pesq = new PesquisarFabri();
            pesq.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class PesqFabricante : Form
    {
        public PesqFabricante()
        {
            InitializeComponent();
        }

        private void AlterFabricante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            // this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   fabricanteBindingSource.Filter = string.Format("fabri_CD={0}"
          //    , textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  if (textBox2.Text.Length == 0)
            {
         //       fabricanteBindingSource.Filter = "";
            }
          //  else
            {
           //     fabricanteBindingSource.Filter = string.Format("fabri_nmfan like'%{0}%'", textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMenuadm adm = new FrmMenuadm();
            this.Hide();
            adm.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmFabricante fabri = new FrmFabricante();
            this.Hide();
            fabri.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            AlterFabricante pesq = new AlterFabricante();
            pesq.ShowDialog();
        }
    }
} 




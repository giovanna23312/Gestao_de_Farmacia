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
    public partial class PesqFuncionarios : Form
    {
        public PesqFuncionarios()
        {
            InitializeComponent();
        }

        private void PesqFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                funcionariosBindingSource.Filter = "";
            }
            else
            {
                funcionariosBindingSource.Filter = string.Format("Func_nome like'%{0}%'", textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuadm adm = new FrmMenuadm();
            this.Hide();
            adm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmFuncionarios func = new FrmFuncionarios();
            this.Hide();
            func.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                funcionariosBindingSource.Filter = "";
            }
            else
            {
                funcionariosBindingSource.Filter = string.Format("Fun_cpf like'%{0}%'", textBox1.Text);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            AlterFuncio pesq = new AlterFuncio();
            pesq.ShowDialog();

        }
    }
}

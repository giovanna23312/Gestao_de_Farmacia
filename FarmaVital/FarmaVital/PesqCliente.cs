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
    public partial class PesqCliente : Form
    {
        public PesqCliente()
        {
            InitializeComponent();
        }

        private void PesqCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.farmaDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmMenuadm adm = new FrmMenuadm();
            this.Hide();
            adm.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCliente clie = new FrmCliente();
            this.Hide();
            clie.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                clienteBindingSource.Filter = "";
            }
            else
            {
                clienteBindingSource.Filter = string.Format("clie_cpf like'%{0}%'", textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                clienteBindingSource.RemoveCurrent();
                clienteTableAdapter.Update(farmaDataSet.cliente); //salvar
                this.clienteTableAdapter.Fill(this.farmaDataSet.cliente);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

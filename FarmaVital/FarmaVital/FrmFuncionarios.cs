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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);
            funcionariosBindingSource.AddNew();


            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }



        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(farmaDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);
           funcionariosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show("Funcionarios cadastrados com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //chamar um novo registro
            funcionariosBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesqFuncionarios func = new PesqFuncionarios();
            this.Hide();
            func.ShowDialog();
        }
    }
}

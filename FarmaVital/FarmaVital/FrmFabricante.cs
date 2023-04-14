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
    public partial class FrmFabricante : Form
    {
        public FrmFabricante()
        {
            InitializeComponent();
        }

        private void FrmFabricante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
            fabricanteBindingSource.AddNew();


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
            fabricanteBindingSource.EndEdit();
           fabricanteTableAdapter.Update(farmaDataSet.fabricante);
           this.fabricanteTableAdapter.Fill(this.farmaDataSet.fabricante);
           fabricanteBindingSource.MoveLast();

            //chamar um novo registro
            fabricanteBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Cadastro de Fabricante feito com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesqFabricante fabri = new PesqFabricante();
            this.Hide();
            fabri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqFabricante pesq = new PesqFabricante();
            this.Hide();
            pesq.ShowDialog();
        }
    }
}


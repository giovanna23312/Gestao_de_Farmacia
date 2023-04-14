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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter.Fill(this.farmaDataSet.medicamentos);

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pesquisa = textBox3.Text;
            foreach (DataGridViewRow row in
                dataGridView2.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[5].Value.ToString()
                        + " | R$ " +
                        row.Cells[10].Value.ToString()
                        );

                    listBox2.Items.Add(row.Cells[10].Value.ToString());
                    double valorTotal = 0;

                    //listBox2.Items.Add(row.Cells[0].Value.ToString());

                    foreach (string v in listBox2.Items)
                    {
                        double dv = Double.Parse(v);
                        valorTotal += dv;
                    }
                    textBox4.Text = "Valor total: " + valorTotal.ToString();

                    break;

                }


            }
        }

        private void Caixa_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet1.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter1.Fill(this.farmaDataSet1.medicamentos);
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet1.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter1.Fill(this.farmaDataSet1.medicamentos);
            //      TODO: esta linha de código carrega dados na tabela 'farmaDataSet1.medicamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicamentosTableAdapter1.Fill(this.farmaDataSet1.medicamentos);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {
                medicamentosBindingSource.Filter = string.Format("Med_cod={0}", textBox3.Text);
            }
            else
            {
                medicamentosBindingSource.Filter = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Produtos.Items.Count > 0)
            {
                string pesquisa = textBox3.Text;
                foreach (DataGridViewRow row in
                    dataGridView2.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString().Contains(pesquisa))
                    {
                        Produtos.Items.Remove(
                            row.Cells[1].Value.ToString()
                            + " | " +
                            row.Cells[5].Value.ToString()
                            + " | R$ " +
                            row.Cells[10].Value.ToString()
                            );



                        listBox2.Items.Remove(row.Cells[10].Value.ToString());
                        double valorTotal = 0.0;

                        foreach (string v in listBox2.Items)
                        {
                            double dv = Double.Parse(v);
                            valorTotal += dv;
                        }
                        textBox4.Text = "Valor total: " + valorTotal.ToString();

                        break;

                    }
                }
                MessageBox.Show("O item foi removido com sucesso", "Remoção de item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O carrinho está vazio, nada para tirar", "Erro no caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }


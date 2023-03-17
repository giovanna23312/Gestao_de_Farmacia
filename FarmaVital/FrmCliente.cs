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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaVitalDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.farmaVitalDataSet.cliente);
            clienteBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(farmaVitalDataSet.cliente);
            this.clienteTableAdapter.Fill(this.farmaVitalDataSet.cliente);
            clienteBindingSource.MoveLast();

            //chamar um novo registro
            clienteBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Seu cliente foi cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}

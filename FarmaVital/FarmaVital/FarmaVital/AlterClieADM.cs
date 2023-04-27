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
    public partial class AlterClieADM : Form
    {
        public AlterClieADM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(farmaDataSet.cliente);
            this.clienteTableAdapter.Fill(this.farmaDataSet.cliente);
            clienteBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            // MessageBox.Show(" alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Clientes alterado com sucesso\", \"Ok\", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);\r\n sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            PesqCliente pesq = new PesqCliente();
            this.Hide();
            pesq.ShowDialog();
        }

        private void AlterClieADM_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.farmaDataSet.cliente);
            if (Class1.codigo == "")
            { clienteBindingSource.AddNew(); }
            else
            { clienteBindingSource.Filter = string.Format("clie_cd={0}", Class1.codigo); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesqCliente pesq = new PesqCliente();
            this.Hide();
            pesq.ShowDialog();

        }
    }
}

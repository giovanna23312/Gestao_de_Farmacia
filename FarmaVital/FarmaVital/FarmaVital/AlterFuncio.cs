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
    public partial class AlterFuncio : Form
    {
        public AlterFuncio()
        {
            InitializeComponent();
        }

        private void AlterFuncio_Load(object sender, EventArgs e)
        {
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);
            if (Class1.codigo == "")
            { funcionariosBindingSource.AddNew(); }
            else
            { funcionariosBindingSource.Filter = string.Format("Fun_cd={0}", Class1.codigo); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(farmaDataSet.funcionarios);
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);
            funcionariosBindingSource.MoveLast();

            //aparece a mensagem quando der certo
           //  MessageBox.Show(" alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            textBox1.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Funcionario alterada com sucesso\", \"Ok\", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);\r\n sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            PesqFuncionarios pesq = new PesqFuncionarios();
            this.Hide();
            pesq.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesqFuncionarios pesq = new PesqFuncionarios();
            this.Hide();
            pesq.ShowDialog();
        }
    }
}

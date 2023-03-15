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
    public partial class FrnLogin : Form
    {
        public FrnLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "giovanna") && (textBox2.Text == "8825"))
            {
                this.Visible = false;
                FrmMenuadm newform3 = new FrmMenuadm();
                newform3.ShowDialog();
            }
            else
                MessageBox.Show("Usuário ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

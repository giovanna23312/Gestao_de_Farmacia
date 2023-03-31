using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FarmaVital
{
    public partial class FrnLogin : Form
    {
        public FrnLogin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();


        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "senac") && (textBox2.Text == "123"))
            {
                this.Visible = false;
                FrmMenuadm menu = new FrmMenuadm();
                menu.ShowDialog();
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
